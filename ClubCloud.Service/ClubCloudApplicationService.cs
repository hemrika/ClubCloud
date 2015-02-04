//-----------------------------------------------------------------------
// <copyright file="HelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using ClubCloud.KNLTB.ServIt.CrmService;
    using ClubCloud.Provider;
    using ClubCloud.Service.Model;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Client.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Net;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Security;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// The WCF Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [ServiceFactoryUsingAuthSchemeInEndpointAddress(UsingAuthSchemeInEndpointAddress = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Runtime.InteropServices.Guid("e00d1eca-a977-4ba9-a357-5fd35dfc0f63")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService", IncludeExceptionDetailInFaults = true)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    internal class ClubCloudApplicationService : ClubCloud.Service.IClubCloudApplicationService
    {
        #region Global

        private static SortedList<string, CookieContainer> containers;

        private static ClubCloud.Service.Model.BeheerContainer _beheerModel = null;

        public static ClubCloud.Service.Model.BeheerContainer beheerModel
        {
            get
            {
                if (_beheerModel == null)
                {
                    _beheerModel = new BeheerContainer(GetConnectionString());
                }

                if (_beheerModel.Database.Connection.State == System.Data.ConnectionState.Broken)
                {
                    _beheerModel.Database.Connection.Close();
                }

                if (_beheerModel.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _beheerModel.Database.Connection.Open();
                }

                return _beheerModel;
            }
            //set { ClubCloudApplicationService.beheerModel = value; }
        }

        private static ClubCloud.Service.Model.BoekhoudingContainer boekhoudingModel = null;
        private static ClubCloud.Service.Model.SignalRContainer signalRModel = null;

        /// <summary>
        /// Deserialize XML string with multiple instances of 'separatorNode' to List<Object>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <param name="separatorNode"></param>
        /// <returns></returns>
        public static List<T> DeserializeObjectList<T>(string xml, string separatorNode)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes(separatorNode);
            List<T> instances = new List<T>();
            foreach (XmlNode node in nodes)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlReaderSettings settings = new XmlReaderSettings();
                using (StringReader textReader = new StringReader(node.OuterXml))
                {
                    using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                    {
                        instances.Add((T)serializer.Deserialize(xmlReader));
                    }
                }
            }
            return instances;
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        public void CheckDatabaseExists()
        {
            //CheckDatabase();
        }
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="catalog"></param>
        private static void CheckDatabase(string catalog = null)
        {
            if (catalog == null)
            {
                using (ClubCloud.Service.Model.BeheerContainer Beheermodel = new Model.BeheerContainer(GetConnectionString(catalog)))
                {
                    Beheermodel.Database.CreateIfNotExists();
                    Beheermodel.Database.Initialize(false);
                    Beheermodel.Database.CompatibleWithModel(false);
                }
                return;
            }

            if (catalog.StartsWith("ClubCloudService_Boekhouding", StringComparison.InvariantCultureIgnoreCase))
            {
                using (ClubCloud.Service.Model.BoekhoudingContainer Boekhoudingmodel = new Model.BoekhoudingContainer(GetConnectionString(catalog)))
                {
                    Boekhoudingmodel.Database.CreateIfNotExists();
                    Boekhoudingmodel.Database.Initialize(false);
                    Boekhoudingmodel.Database.CompatibleWithModel(false);
                }
            }

            if (catalog.StartsWith("ClubCloudService_SignalR", StringComparison.InvariantCultureIgnoreCase))
            {
                using (ClubCloud.Service.Model.SignalRContainer SignalRmodel = new Model.SignalRContainer(GetConnectionString(catalog)))
                {
                    SignalRmodel.Database.CreateIfNotExists();
                    SignalRmodel.Database.Initialize(false);
                    SignalRmodel.Database.CompatibleWithModel(false);
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="catalog"></param>
        /// <returns></returns>
        private static string GetConnectionString(string catalog = null)
        {
            ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
            SqlConnectionStringBuilder builder = null;

            if (application == null)
            {
                throw new InvalidOperationException("Could not find the current Service Application.");
            }

            using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString + ";MultipleActiveResultSets=true;"))
            {
                builder = new SqlConnectionStringBuilder(connection.ConnectionString);

                if (!string.IsNullOrWhiteSpace(catalog))
                {
                    builder.InitialCatalog = catalog;
                }
            }

            if (builder != null)
            {
                return builder.ConnectionString;
            }

            return application.Database.DatabaseConnectionString;
        }

        /// <summary>
        /// Serialize List<Object> to one XML string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string SerializeObjectList<T>(T value)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false);
            settings.Indent = false;
            settings.OmitXmlDeclaration = false;
            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, value);
                }
                return textWriter.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="wachtwoord"></param>
        /// <returns></returns>
        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord)
        {
            CookieContainer container = new CookieContainer();
            if (containers == null)
            {
                containers = new SortedList<string, CookieContainer>();
            }

            bool expired = false;
            if (containers.Keys.Contains(bondsnummer))
            {
                container = containers.FirstOrDefault(c => c.Key == bondsnummer).Value;

                CookieCollection cookies = container.GetCookies(new Uri("http://www.mijnknltb.nl"));
                cookies.Add(container.GetCookies(new Uri("http://servit.mijnknltb.nl")));
                cookies.Add(container.GetCookies(new Uri("http://mijnknltb.nl")));

                foreach (Cookie cookie in cookies)
                {
                    if (cookie.Expired)
                    {
                        expired = cookie.Expired;
                        break;
                    }
                }
            }

            if (container != null && container.Count > 0 && !expired)
            {
                return container;
            }
            else
            {
                if (containers.Keys.Contains(bondsnummer))
                {
                    containers.Remove(bondsnummer);
                }

                ClubCloud.KNLTB.Security.KNLTBContainer KNLTBContainer = new KNLTB.Security.KNLTBContainer();
                KNLTBContainer.MijnRequestAcces(bondsnummer, wachtwoord);

                Stopwatch s = new Stopwatch();
                s.Start();
                while (KNLTBContainer.Container == null && s.Elapsed < TimeSpan.FromSeconds(30)) { }
                s.Stop();

                containers.Add(bondsnummer, KNLTBContainer.Container);

                return KNLTBContainer.Container;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="entityName"></param>
        /// <param name="moreRecords"></param>
        /// <param name="pageNum"></param>
        /// <returns></returns>
        private List<BusinessEntity> RetrieveMultiple(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, out bool moreRecords, ref int pageNum)
        {
            return RetrieveMultiple(service, entityName, out moreRecords, ref pageNum, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="entityName"></param>
        /// <param name="moreRecords"></param>
        /// <param name="pageNum"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        private List<BusinessEntity> RetrieveMultiple(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, out bool moreRecords, ref int pageNum, FilterExpression filter)
        {
            RetrieveMultipleResponse results = null;
            List<BusinessEntity> entities = new List<BusinessEntity>();

            //ColumnSetBase cols = new AllColumns();

            FilterExpression expression = new FilterExpression();
            if (filter != null)
            {
                expression = filter;
            }

            PagingInfo pageInfo = new PagingInfo();

            //Limit while debugging
#if DEBUG
            pageInfo.Count = 10;
#else
            pageInfo.Count = 50;
#endif
            pageInfo.PageNumber = pageNum;
            QueryExpression query = new QueryExpression();

            query.EntityName = entityName;
            query.ColumnSet = new AllColumns();
            query.Criteria = expression;
            query.PageInfo = pageInfo;
            query.Distinct = true;

            // Create the request object.
            RetrieveMultipleRequest request = new RetrieveMultipleRequest();

            // Set the properties of the request object.
            request.Query = query;
            //request.ReturnDynamicEntities = true;

            // Execute the request.
            try
            {
                results = (RetrieveMultipleResponse)service.Execute(request);
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
            }

            moreRecords = false;

            if (results != null)
            {
                moreRecords = results.BusinessEntityCollection.MoreRecords;
                if (moreRecords)
                {
                    pageNum++;
                }

                entities = results.BusinessEntityCollection.BusinessEntities.ToList<BusinessEntity>();
            }
#if DEBUG
            moreRecords = false;
#endif
            return entities;
        }

        /*
        private void ValidateBondsnummer(ref string bondsnummer)
        {
            ValidateBondsnummer(ref bondsnummer,Guid.Empty);
        }
        */

        private void ValidateBondsnummer(ref string bondsnummer, Guid verenigingId)
        {
            string working = bondsnummer;

            ClubCloud_Gebruiker gebruiker = null;
            ClubCloud_Setting settings = null;

            //if (beheerModel == null )
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{
            gebruiker = beheerModel.ClubCloud_Gebruikers.FirstOrDefault(g => g.Bondsnummer == working);

            if (gebruiker != null)
            {
                settings = beheerModel.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
            }

            if (settings != null)
            {
                if (!settings.Access && !string.IsNullOrEmpty(settings.Password))
                {
                    gebruiker = null;
                }
            }
            else
            {
                gebruiker = null;
            }

            if (gebruiker == null && verenigingId != Guid.Empty)
            {
                List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

                functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId.Value == verenigingId && f.Autorisatie == true && (f.FunctieId == new Guid("516B73DD-61B8-4B5F-BD15-78232C2D071C") || f.FunctieId == new Guid("C91FB5B2-E6CB-4B34-B9DC-BEBDFD6D35C7"))).ToList();

                if (functionarissen != null && functionarissen.Count > 0)
                {
                    foreach (ClubCloud_Functionaris functionaris in functionarissen)
                    {
                        gebruiker = beheerModel.ClubCloud_Gebruikers.Find(functionaris.GebruikerId.Value);

                        settings = beheerModel.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
                        if (settings != null)
                        {
                            if (settings.Access && !string.IsNullOrEmpty(settings.Password))
                            {
                                break;
                            }
                        }
                    }
                }
            }
            //}


            if (gebruiker != null)
            {
                bondsnummer = gebruiker.Bondsnummer;
            }
            else
            {
                bondsnummer = string.Empty;
            }
        }

        #endregion

        #region Security

        private ClubCloud_Setting GetSettings(int bondsnummer, ClubCloud_Functie functie = null)
        {
            //CheckDatabase();

            ClubCloud_Setting settings = null;
            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            if (functie != null)
            {
                functies.Add(functie);
            }
            else
            {
                ClubCloud_Functie Ledenadministratie = beheerModel.ClubCloud_Functies.Find(new Guid("C91FB5B2-E6CB-4B34-B9DC-BEBDFD6D35C7"));
                functies.Add(Ledenadministratie);
                ClubCloud_Functie Gedelegeerd_Ledenadministratie = beheerModel.ClubCloud_Functies.Find(new Guid("516B73DD-61B8-4B5F-BD15-78232C2D071C"));
                functies.Add(Gedelegeerd_Ledenadministratie);
            }

            ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(bondsnummer);

            bool heeftFunctie = false;

            if (usersettings != null && usersettings.Access && !string.IsNullOrEmpty(usersettings.Password) && usersettings.GebruikerId.HasValue)
            {
                //TODO Loop for getsettings
                List<ClubCloud_Functionaris> functionarissen = FunctionarissenByGebruiker(bondsnummer, usersettings.GebruikerId.Value, false, usersettings);

                foreach (ClubCloud_Functionaris functionaris in functionarissen)
                {
                    if (functies.Contains(functionaris.ClubCloud_Functie))
                    {
                        heeftFunctie = true;
                        break;
                    }
                }
            }
            else
            {
                if (usersettings != null && usersettings.VerenigingId.HasValue)
                {
                    List<ClubCloud_Functionaris> functionarissen = FunctionarissenByVereniging(bondsnummer, usersettings.VerenigingId.Value, false, settings);

                    foreach (ClubCloud_Functionaris functionaris in functionarissen)
                    {
                        if (functies.Contains(functionaris.ClubCloud_Functie))
                        {
                            usersettings = beheerModel.ClubCloud_Settings.Find(functionaris.ClubCloud_Gebruiker.Bondsnummer);
                            if (usersettings.Access && !string.IsNullOrEmpty(usersettings.Password))
                            {
                                heeftFunctie = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (heeftFunctie)
            {
                settings = usersettings;
            }
            else
            {
                //No earlier contact has been made.
                if (usersettings != null && usersettings.Access && !string.IsNullOrEmpty(usersettings.Password))
                {
                    settings = usersettings;
                }
            }
            //}
            return settings;
        }

        private ClubCloud_Setting GetSettings(string bondsnummer)
        {
            return GetSettings(int.Parse(bondsnummer));
        }

        #endregion

        #region SignlR

        public string ScaleOutConnection(string catalog)
        {
            try
            {
                return GetConnectionString(catalog);
            }
            catch { }
            finally
            {
                CheckDatabase(catalog);
            }
            return string.Empty;
        }

        #endregion

        #region MembershipProvider

        private ZimbraMembershipProvider m_membershipProvider;

        public ZimbraMembershipProvider Provider
        {
            get
            {
                if (this.m_membershipProvider == null)
                {
                    this.m_membershipProvider = System.Web.Security.Membership.Providers["ZimbraMembershipProvider"] as ZimbraMembershipProvider;
                }
                return this.m_membershipProvider;
            }
        }

        private async Task<bool> UpdateMembershipuser(ClubCloud_Gebruiker gebruiker)
        {
            try
            {

                //if (beheerModel == null)
                //{
                //    beheerModel = new Model.BeheerContainer(GetConnectionString());
                //}

                //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                //{

                ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.GebruikerId == gebruiker.Id);
                if (updatesettings != null)// && updatesettings.Id != null)
                {
                    ZimbraMembershipUser zuser = await Provider.GetZimbraUserAsync(updatesettings.Id.ToString(), true);

                    if (zuser == null)
                    { }

                    /*
                        zuser.cn = gebruiker.VolledigeNaam;
                        zuser.co = gebruiker.NationaliteitId.ToString();
                        zuser.company = gebruiker.OrganisatieNummer;
                        zuser.departmentNumber = gebruiker.DistrictNaam;
                        zuser.displayName = gebruiker.VolledigeNaam;
                        zuser.employeeNumber = gebruiker.Id.ToString();
                        zuser.givenName = gebruiker.Voornamen;
                        zuser.homePhone = gebruiker.TelefoonAvond;
                        zuser.homePostalAddress = gebruiker.Straat + " " + gebruiker.Huisnummer + " " + Environment.NewLine + gebruiker.Postcode + "," + gebruiker.Plaats + " " + Environment.NewLine + gebruiker.Gemeente;
                        zuser.initials = gebruiker.Voorletters;
                        zuser.l = gebruiker.Plaats;
                        zuser.mobile = gebruiker.Mobiel;
                        zuser.o = gebruiker.OrganisatieNummer;
                        zuser.postalAddress = gebruiker.Straat + " " + gebruiker.Huisnummer + " " + Environment.NewLine + gebruiker.Postcode + "," + gebruiker.Plaats + " " + Environment.NewLine + gebruiker.Gemeente;
                        zuser.postalCode = gebruiker.Postcode;
                        zuser.sn = gebruiker.Achternaam;
                        zuser.st = gebruiker.Gemeente;
                        zuser.street = gebruiker.Straat + " " + gebruiker.Huisnummer;
                        zuser.telephoneNumber = gebruiker.Mobiel;
                        zuser.zimbraPrefMailForwardingAddress = gebruiker.Email;
                        Provider.UpdateUser(zuser as MembershipUser);
                        */

                    if (zuser != null)
                        await Provider.UpdateZimbraUserAsync(zuser);
                }
                //}

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<bool> UpdateMembershipuser(ClubCloud_Vereniging vereniging)
        {
            try
            {

                //if (beheerModel == null)
                //{
                //    beheerModel = new Model.BeheerContainer(GetConnectionString());
                //}

                //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                //{

                ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.VerenigingId == vereniging.Id);

                if (updatesettings != null)// && updatesettings.Id != null)
                {
                    ZimbraMembershipUser zuser = await Provider.GetZimbraUserAsync(updatesettings.Id.ToString(), true);

                    if (zuser == null)
                    {
                        MembershipCreateStatus status = MembershipCreateStatus.Success;
                        MembershipUser nuser = Provider.CreateUser(vereniging.Nummer, "", vereniging.EmailKNLTB, "", "", true, null, out status);

                        if (status != null && status == MembershipCreateStatus.Success)
                        {
                            zuser = nuser as ZimbraMembershipUser;
                        }
                        /*
                        zuser.cn = vereniging.Naam;
                        //zuser.co
                        //zuser.Comment
                        zuser.company = vereniging.Naam;
                        //zuser.CreationDate
                        zuser.departmentNumber = vereniging.KvKnummer;
                        zuser.displayName = vereniging.Naam;
                        zuser.Email = vereniging.Nummer + "@clubcloud.nl";
                        //zuser.EmailForwarding = vereniging.EmailKNLTB;
                        //zuser.EmailAlias
                        zuser.employeeNumber = vereniging.Nummer;
                        zuser.zimbraPrefMailForwardingAddress = vereniging.EmailKNLTB;
                        */
                    }

                    /*
                        zuser.cn = gebruiker.VolledigeNaam;
                        zuser.co = gebruiker.NationaliteitId.ToString();
                        zuser.company = gebruiker.OrganisatieNummer;
                        zuser.departmentNumber = gebruiker.DistrictNaam;
                        zuser.displayName = gebruiker.VolledigeNaam;
                        zuser.employeeNumber = gebruiker.Id.ToString();
                        zuser.givenName = gebruiker.Voornamen;
                        zuser.homePhone = gebruiker.TelefoonAvond;
                        zuser.homePostalAddress = gebruiker.Straat + " " + gebruiker.Huisnummer + " " + Environment.NewLine + gebruiker.Postcode + "," + gebruiker.Plaats + " " + Environment.NewLine + gebruiker.Gemeente;
                        zuser.initials = gebruiker.Voorletters;
                        zuser.l = gebruiker.Plaats;
                        zuser.mobile = gebruiker.Mobiel;
                        zuser.o = gebruiker.OrganisatieNummer;
                        zuser.postalAddress = gebruiker.Straat + " " + gebruiker.Huisnummer + " " + Environment.NewLine + gebruiker.Postcode + "," + gebruiker.Plaats + " " + Environment.NewLine + gebruiker.Gemeente;
                        zuser.postalCode = gebruiker.Postcode;
                        zuser.sn = gebruiker.Achternaam;
                        zuser.st = gebruiker.Gemeente;
                        zuser.street = gebruiker.Straat + " " + gebruiker.Huisnummer;
                        zuser.telephoneNumber = gebruiker.Mobiel;
                        zuser.zimbraPrefMailForwardingAddress = gebruiker.Email;
                        Provider.UpdateUser(zuser as MembershipUser);
                        */

                    if (zuser != null)
                        await Provider.UpdateZimbraUserAsync(zuser);
                }
                //}

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Gebruikers

        #region Settings

        public ClubCloud_Setting GetClubCloudSettings(int bondsnummer)
        {
            return GetClubCloudSettings(bondsnummer.ToString());
        }

        public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            try
            {
                currentsettings = beheerModel.ClubCloud_Settings.Find(int.Parse(bondsnummer));
            }
            catch
            {

                currentsettings = null;
            }

            if (currentsettings == null)
            {
                currentsettings = new ClubCloud_Setting { Id = int.Parse(bondsnummer) };
                beheerModel.ClubCloud_Settings.Add(currentsettings);
                beheerModel.SaveChanges();
                currentsettings.Id = int.Parse(bondsnummer);
                beheerModel.SaveChanges();
            }
            //}
            currentsettings.Password = string.Empty;

            return currentsettings;
        }

        public ClubCloud_Setting SetClubCloudSettings(ClubCloud_Setting settings)
        {
            ClubCloud_Setting tobeupdated = beheerModel.ClubCloud_Settings.Find(settings.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(settings);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Settings.Find(settings.Id);
            return tobeupdated;
        }

        /*
        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                currentsettings.facebook_allow = settings.facebook_allow;
                currentsettings.facebook_access_token = settings.facebook_access_token;
                currentsettings.facebook_setting = settings.facebook_setting;
                currentsettings.Gewijzigd = DateTime.Now;
                beheerModel.SaveChanges();
            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            currentsettings.financieel = settings.financieel;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }
        */

        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            //CheckDatabase();
            GetClubCloudSettings(settings.Id);

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);

            currentsettings.Agree = settings.Agree;

            if (currentsettings.Agree && (currentsettings.Password != settings.Password))
            {
                currentsettings.Password = settings.Password;
            }
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();

            CookieContainer cc = RequestContainer(currentsettings.Id.ToString(), currentsettings.Password);

            if (cc != null)
            {
                ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                try
                {
                    WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                    currentsettings.Access = true;
                    currentsettings.Gewijzigd = DateTime.Now;
                    beheerModel.SaveChanges();

                    ClubCloud_Gebruiker gebruiker = GebruikerByNummer(currentsettings.Id.ToString(), currentsettings.Id.ToString());
                    if (gebruiker != null)
                    {
                        currentsettings.GebruikerId = gebruiker.Id;

                        if (gebruiker.VerenigingId.HasValue)
                        {
                            currentsettings.VerenigingId = gebruiker.VerenigingId.Value;
                            beheerModel.SaveChanges();

                            List<ClubCloud_Lidmaatschap> lidmaatschappen = LidmaatschappenByGebruiker(currentsettings.Id.ToString(), gebruiker.Id);
                        }
                    }
                }
                catch (WebException wex)
                {
                    HttpWebResponse response = wex.Response as HttpWebResponse;
                    if (response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        currentsettings.Access = false;
                    }
                }
            }

            beheerModel.SaveChanges();

            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        /*
        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            currentsettings.privacy = settings.privacy;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            //currentsettings.mijnknltb_tracking = settings.mijnknltb_tracking;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            currentsettings.twitter_allow = settings.twitter_allow;
            currentsettings.twitter_oauth_token = settings.twitter_oauth_token;
            currentsettings.twitter_oauth_token_secret = settings.twitter_oauth_token_secret;
            currentsettings.twitter_setting = settings.twitter_setting;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }
        */

        #endregion

        /*
        public ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null)
                {
                    if (settings.GebruikerId.HasValue)
                    {
                        gebruiker = beheerModel.ClubCloud_Gebruikers.Find(settings.GebruikerId.Value);
                    }
                    else
                    {
                        gebruiker = null;
                    }

                    if (gebruiker == null || refresh)
                    {
                        if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                        {
                            CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                            if (cc != null)
                            {
                                using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc))
                                {

                                }
                            }

                        }
                    }
                }

                if (beheerModel.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }
                beheerModel.SaveChanges();


            }
            return gebruiker;
        }
        */

        /*
        public ClubCloud_Gebruiker GetClubCloudGebruikerByBondsnummer(string bondsnummer, string bondsnummerGebruiker, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = beheerModel.ClubCloud_Settings.Find(int.Parse(bondsnummerGebruiker));

                if (settings != null)
                {
                    if (settings.GebruikerId.HasValue)
                    {
                        gebruiker = beheerModel.ClubCloud_Gebruikers.Find(settings.GebruikerId.Value);
                    }
                    else
                    {
                        gebruiker = null;
                    }
                }

                if (gebruiker == null || refresh)
                {
                    settings = beheerModel.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {

                            //LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

                            //GetPersoonsgegevensResponse persoonResponse = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = bondsnummerGebruiker });
                            //if (persoonResponse != null && persoonResponse.Persoonsgegevens != null)
                            //{
                            //    Persoonsgegevens persoon = persoonResponse.Persoonsgegevens;

                            //    gebruiker = new ClubCloud_Gebruiker
                            //    {
                            //        Achternaam = persoon.Achternaam,
                            //        DistrictNaam = persoon.DistrictNaam,
                            //        Email = persoon.Email,
                            //        Geboortedatum = persoon.Geboortedatum,
                            //        Geboorteplaats = persoon.Geboorteplaats,
                            //        Gemeente = persoon.Gemeente,
                            //        Geslacht = persoon.Geslacht,
                            //        Huisnummer = persoon.Huisnummer,
                            //        Id = persoon.Id,
                            //        IsLid = persoon.IsLid,
                            //        Mobiel = persoon.Mobiel,
                            //        NationaliteitId = persoon.NationaliteitId,
                            //        OrganisatieNummer = persoon.OrganisatieNummer,
                            //        Plaats = persoon.Plaats,
                            //        Postcode = persoon.Postcode,
                            //        RatingDubbel = persoon.RatingDubbel,
                            //        RatingEnkel = persoon.RatingEnkel,
                            //        Roepnaam = persoon.Roepnaam,
                            //        SpeelsterkteDubbel = persoon.SpeelsterkteDubbel,
                            //        SpeelsterkteEnkel = persoon.SpeelsterkteEnkel,
                            //        Straat = persoon.Straat,
                            //        TelefoonAvond = persoon.TelefoonAvond,
                            //        TelefoonOverdag = persoon.TelefoonOverdag,
                            //        Toevoeging = persoon.Toevoeging,
                            //        Tussenvoegsel = persoon.Tussenvoegsel,
                            //        VolledigeNaam = persoon.VolledigeNaam,
                            //        Voorletters = persoon.Voorletters,
                            //        Voornamen = persoon.Voornamen
                            //    };

                            //    beheerModel.ClubCloud_Gebruikers.Add(gebruiker);

                            //}

                        }

                    }

                }

                beheerModel.SaveChanges();

                if (beheerModel.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }




            }
            return gebruiker;
        }
        */

        public bool SetClubCloudGebruiker(string bondsnummer, Guid verenigingId, ClubCloud_Gebruiker gebruiker, bool refresh = false)
        {
            try
            {
                //CheckDatabase();

                //if (beheerModel == null)
                //{
                //    beheerModel = new Model.BeheerContainer(GetConnectionString());
                //}

                //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                //{

                ClubCloud_Setting settings = beheerModel.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
                ClubCloud_Gebruiker currentgebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruiker.Id);

                if (currentgebruiker != null)
                {
                    if (settings != null && (!settings.GebruikerId.HasValue || !settings.VerenigingId.HasValue))
                    {
                        settings.VerenigingId = gebruiker.VerenigingId.Value;
                        settings.GebruikerId = gebruiker.Id;
                        beheerModel.SaveChanges();
                    }

                    currentgebruiker.Aanhef = gebruiker.Aanhef;
                    currentgebruiker.AanhefAttentie = gebruiker.AanhefAttentie;
                    currentgebruiker.AanhefBrief = gebruiker.AanhefBrief;
                    currentgebruiker.Achternaam = gebruiker.Achternaam;
                    currentgebruiker.Achtervoegsel = gebruiker.Achtervoegsel;
                    //currentgebruiker.Actief = gebruiker.Actief;
                    currentgebruiker.AddressGeheim = gebruiker.AddressGeheim;
                    currentgebruiker.BankIban = gebruiker.BankIban;
                    currentgebruiker.BankNummer = gebruiker.BankNummer;
                    currentgebruiker.BankPlaats = gebruiker.BankPlaats;
                    currentgebruiker.Beroep = gebruiker.Beroep;
                    currentgebruiker.Beschrijving = gebruiker.Beschrijving;
                    //currentgebruiker.Bondsnummer = gebruiker.Bondsnummer;
                    currentgebruiker.EmailGeheim = gebruiker.EmailGeheim;
                    currentgebruiker.EmailKNLTB = gebruiker.EmailKNLTB;
                    currentgebruiker.EmailOverig = gebruiker.EmailOverig;
                    currentgebruiker.EmailWebSite = gebruiker.EmailWebSite;
                    currentgebruiker.Fax = gebruiker.Fax;
                    //currentgebruiker.FotoId = gebruiker.FotoId;
                    currentgebruiker.FTPsite = gebruiker.FTPsite;
                    currentgebruiker.Geboortedatum = gebruiker.Geboortedatum.Value;
                    currentgebruiker.Geboorteplaats = gebruiker.Geboorteplaats;
                    currentgebruiker.Geslacht = gebruiker.Geslacht;
                    currentgebruiker.Gewijzigd = DateTime.Now;
                    //currentgebruiker.Id = gebruiker.Id;
                    currentgebruiker.Kinderen = gebruiker.Kinderen;
                    currentgebruiker.KinderenAantal = gebruiker.KinderenAantal;
                    currentgebruiker.Mobiel = gebruiker.Mobiel;
                    currentgebruiker.NationaliteitId = gebruiker.NationaliteitId.Value;
                    if (gebruiker.OverlijdensDatum.HasValue)
                        currentgebruiker.OverlijdensDatum = gebruiker.OverlijdensDatum.Value;
                    currentgebruiker.Partner = gebruiker.Partner;
                    currentgebruiker.Roepnaam = gebruiker.Roepnaam;
                    currentgebruiker.TelefoonAvond = gebruiker.TelefoonAvond;
                    currentgebruiker.TelefoonGeheim = gebruiker.TelefoonGeheim;
                    currentgebruiker.TelefoonOverdag = gebruiker.TelefoonOverdag;
                    currentgebruiker.TelefoonOverig = gebruiker.TelefoonOverig;
                    currentgebruiker.Tussenvoegsel = gebruiker.Tussenvoegsel;
                    //currentgebruiker.VerenigingId = gebruiker.VerenigingId;
                    currentgebruiker.Volledigenaam = string.Format("{0} {1}, {2}", gebruiker.Tussenvoegsel, gebruiker.Achternaam, gebruiker.Voorletters);
                    currentgebruiker.Voorletters = gebruiker.Voorletters;
                    currentgebruiker.Voornaam = gebruiker.Voornaam;
                    currentgebruiker.Voornamen = gebruiker.Voornamen;
                    currentgebruiker.Website = gebruiker.Website;

                    if (beheerModel.ChangeTracker.HasChanges())
                    {
                        UpdateMembershipuser(gebruiker);
                    }
                    beheerModel.SaveChanges();

                    if (gebruiker.ClubCloud_Address != null && gebruiker.ClubCloud_Address.Count > 0)
                    {
                        foreach (ClubCloud_Address address in gebruiker.ClubCloud_Address)
                        {
                            ClubCloud_Address currentaddress = beheerModel.ClubCloud_Addresses.Find(address.Id);
                            //currentaddress.Actief = address.Actief;
                            currentaddress.AddressGeheim = address.AddressGeheim;
                            currentaddress.Fax = address.Fax;
                            currentaddress.GeoLocation = address.GeoLocation;
                            currentaddress.Gewijzigd = DateTime.Now;
                            //currentaddress.Id = address.Id;
                            currentaddress.Gemeente = address.Gemeente;
                            currentaddress.Land = address.Land;
                            currentaddress.Latitude = address.Latitude;
                            currentaddress.Longitude = address.Longitude;
                            currentaddress.Naam = address.Naam;
                            currentaddress.Nummer = address.Nummer;
                            //currentaddress.ParentId = address.ParentId.Value;
                            currentaddress.Postbus = address.Postbus;
                            currentaddress.Postcode = address.Postcode;
                            currentaddress.Provincie = address.Provincie;
                            currentaddress.Stad = address.Stad;
                            currentaddress.Straat = address.Straat;
                            currentaddress.TelefoonPrimair = address.TelefoonPrimair;
                            currentaddress.TelefoonSecundair = address.TelefoonSecundair;
                            currentaddress.TelefoonTertiair = address.TelefoonTertiair;
                            currentaddress.Toevoeging = address.Toevoeging;

                            beheerModel.SaveChanges();
                        }
                    }

                    if (gebruiker.ClubCloud_Lidmaatschap != null && gebruiker.ClubCloud_Lidmaatschap.Count > 0)
                    {
                        foreach (ClubCloud_Lidmaatschap lidmaatschap in gebruiker.ClubCloud_Lidmaatschap)
                        {
                            ClubCloud_Lidmaatschap currentlidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.Id);
                            //currentlidmaatschap.Actief = lidmaatschap.Actief;
                            currentlidmaatschap.Autorisatie = lidmaatschap.Autorisatie;
                            currentlidmaatschap.Begin = lidmaatschap.Begin;
                            currentlidmaatschap.Einde = lidmaatschap.Einde.Value;
                            currentlidmaatschap.Gewijzigd = DateTime.Now;
                            currentlidmaatschap.InternNummer = lidmaatschap.InternNummer;
                            currentlidmaatschap.Opzegging = lidmaatschap.Opzegging.Value;
                            currentlidmaatschap.PasDatum = lidmaatschap.PasDatum.Value;
                            currentlidmaatschap.PasNieuw = lidmaatschap.PasNieuw;
                            currentlidmaatschap.PasNood = currentlidmaatschap.PasNood;
                            currentlidmaatschap.PasNoodDatum = lidmaatschap.PasNoodDatum.Value;
                            currentlidmaatschap.PasTypeId = lidmaatschap.PasTypeId;
                            currentlidmaatschap.PasTypeNaam = lidmaatschap.PasTypeNaam;
                            currentlidmaatschap.PasVolgnummer = lidmaatschap.PasVolgnummer;
                            currentlidmaatschap.PasWedstrijd = lidmaatschap.PasWedstrijd;
                            currentlidmaatschap.SoortId = lidmaatschap.SoortId;
                            //currentlidmaatschap.SoortNaam = lidmaatschap.SoortNaam;
                            currentlidmaatschap.SpeelsterkteDubbel = lidmaatschap.SpeelsterkteDubbel;
                            currentlidmaatschap.SpeelsterkteEnkel = lidmaatschap.SpeelsterkteEnkel;
                            //currentlidmaatschap.VerenigingId = lidmaatschap.VerenigingId.Value;
                            beheerModel.SaveChanges();
                        }
                    }
                }

                beheerModel.SaveChanges();
                //}
                return true;
            }
            catch { return false; }

        }

        public ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            gebruiker = GebruikerByNummer(bondsnummer, nummer, refresh);
            return gebruiker;
        }

        public ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Foto foto = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            foto = FotoByBondsnummer(bondsnummer, nummer, refresh);
            return foto;
        }

        public ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            foto = FotoByGebruikerId(bondsnummer, gebruikerId, refresh);
            return foto;
        }

        public ClubCloud_Foto UpdateFoto(string bondsnummer, Guid verenigingId,ClubCloud_Foto foto)
        {
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            foto = SetFoto(foto);
            return foto;
        }

        public ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            gebruiker = GebruikerById(bondsnummer, gebruikerId, refresh);
            return gebruiker;
        }

        public List<ClubCloud_Address> GetAddressByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Address> addressen = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            addressen = AddressByParent(bondsnummer, gebruikerId, refresh);
            return addressen;
        }

        public List<ClubCloud_Lidmaatschap> GetLidmaatschapByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            lidmaatschappen = LidmaatschappenByGebruiker(bondsnummer, gebruikerId, refresh);
            return lidmaatschappen;
        }


        /*
		public SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false)
		{
			//CheckDatabase();

			SpelersProfiel profiel = new SpelersProfiel();


			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = GetSettings(bondsnummer);

				if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

					if (cc != null)
					{
						LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

						GetSpelersProfielDetailResponse profielResponse = LedenAdministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = settings.Id.ToString() });
						if (profielResponse != null)
						{
							profiel = (SpelersProfiel)profielResponse;
						}

						if(refresh)
						{
							GetTracking(bondsnummer, refresh);
						}
					}
				}
			}

			return profiel;
		}
        */

        /*
		public ClubCloud_Tracking GetTracking(string bondsnummer, bool refresh = false)
		{
			//CheckDatabase();

			ClubCloud_Tracking spelertracking = new ClubCloud_Tracking();// { Id = int.Parse(bondsnummer) };

			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = GetSettings(bondsnummer);

				if (settings != null && settings.mijnknltb_tracking)
				{
					spelertracking = beheerModel.ClubCloud_TrackingSet.SingleOrDefault(p => p.Id == settings.GebruikerId);

					if (spelertracking == null && settings.mijnknltb_tracking)
					{
						spelertracking = beheerModel.ClubCloud_TrackingSet.Create();
						spelertracking.Id = settings.GebruikerId.Value;
						beheerModel.ClubCloud_TrackingSet.Add(spelertracking);
						beheerModel.SaveChanges();
					}

					if (spelertracking != null && settings.mijnknltb_tracking || refresh)
					{
						List<SpelersProfiel> profielen = null;

						if (!string.IsNullOrWhiteSpace(spelertracking.Data))
						{
							profielen = (List<SpelersProfiel>)DeserializeObjectList<SpelersProfiel>(spelertracking.Data, "SpelersProfiel");
						}
						else
						{
							profielen = new List<SpelersProfiel>();
						}

						if (settings.Access)
						{
							CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

							if (cc != null)
							{
								LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
								GetSpelersProfielDetailResponse profielResponse = LedenAdministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = settings.Id.ToString() });

								if (profielResponse != null)
								{
									SpelersProfiel profiel = profielResponse as SpelersProfiel;
									{
										if (profiel != null)
										{
											if (profielen.Count >= 12)
											{
												profielen.RemoveAt(profielen.Count - 1);
											}
											profielen.Insert(0, profiel);
										}
									}
								}
							}
						}
                        if (profielen.Count > 0)
                        {
                            spelertracking.Data = SerializeObjectList(profielen);
                        }
					}
				}
				beheerModel.SaveChanges();
			}
			return spelertracking;
		}
        */

        /*
		public List<ClubCloud_Gebruiker_Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
		{
			//CheckDatabase();

			List<ClubCloud_Gebruiker_Vereniging> verenigingen = new List<ClubCloud_Gebruiker_Vereniging>();

			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = GetSettings(bondsnummer);

				if (settings != null && settings.GebruikerId.HasValue)
				{
					verenigingen = beheerModel.ClubCloud_Gebruiker_Verenigingen.Where(gv => gv.Id == settings.GebruikerId.Value).ToList<ClubCloud_Gebruiker_Vereniging>();

					if (verenigingen == null || verenigingen.Count == 0 || refresh)
					{

						if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
						{
							CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

							if (cc != null)
							{
								LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
								GetMijnVerenigingenResponse verenigingenResponse = LedenAdministratie.GetMijnVerenigingen(new GetMijnVerenigingenRequest { Bondsnummer = bondsnummer });
								if (verenigingenResponse != null && verenigingenResponse.Verenigingen != null && verenigingenResponse.Verenigingen.Length > 0)
								{
									foreach (ClubCloud.KNLTB.ServIt.LedenAdministratieService.Vereniging vereniging in verenigingenResponse.Verenigingen)
									{
										ClubCloud_Gebruiker_Vereniging gebruiker_vereniging = verenigingen.SingleOrDefault(v => v.VerenigingId == vereniging.Id);// && vereniging.Id == settings.GebruikerId.Value);

										if (gebruiker_vereniging == null)// || gebruiker_vereniging.VerenigingId == null || gebruiker_vereniging.VerenigingId == Guid.Empty)
										{
											gebruiker_vereniging = new ClubCloud_Gebruiker_Vereniging
											{
												Id = settings.GebruikerId.Value,
												VerenigingId = vereniging.Id,
												VerenigingNaam = vereniging.Naam
											};
											beheerModel.ClubCloud_Gebruiker_Verenigingen.Add(gebruiker_vereniging);
											verenigingen.Add(gebruiker_vereniging);
										}
										else
										{
											gebruiker_vereniging.VerenigingNaam = vereniging.Naam;
										}
									}
								}
							}
						}
					}
				}
				beheerModel.SaveChanges();
			}

			return verenigingen;
		}
        */

        /*
		//public List<ClubCloud_Abbonnement> GetAbonnementen(Guid persoonsId, bool refresh = false)
		public List<ClubCloud_Gebruiker_Abonement> GetAbonnementen(string bondsnummer, Guid persoonsId, bool refresh = false)
		{
			//CheckDatabase();

			List<ClubCloud_Gebruiker_Abonement> abonnementen = new List<ClubCloud_Gebruiker_Abonement>();

			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = GetSettings(bondsnummer);

				if (settings != null)
				{
					abonnementen = beheerModel.ClubCloud_Gebruiker_Abonementen.Where(gv => gv.Id == settings.GebruikerId.Value).ToList<ClubCloud_Gebruiker_Abonement>();

					if (abonnementen != null && abonnementen.Count == 0 || refresh)
					{
						if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
						{
							CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

							if (cc != null)
							{
								LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, settings.Id.ToString());
								GetSoortAbonneesResponse abonneesResponse = LedenAdministratie.GetSoortAbonnees( new GetSoortAbonneesRequest{ PersoonId = persoonsId});

								if(abonneesResponse != null && abonneesResponse.SoortAbonnement != null && abonneesResponse.SoortAbonnement.Length > 0)
								{
									foreach (SoortAbonnement abonnement in abonneesResponse.SoortAbonnement)
									{
										//abonnement.Beschrijving

									}
								}
							}
						}
					}
				}

				beheerModel.SaveChanges();
			}

			return abonnementen;
		}
        */

        /*
		public List<ClubCloud_District> GetDistricten(string bondsnummer, bool refresh = false)
		{
			//CheckDatabase();
			List<ClubCloud_District> districten = new List<ClubCloud_District>();
			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				districten = beheerModel.ClubCloud_Districten.Where(d => d.Id != null).ToList();

				if (districten == null || districten.Count == 0 || refresh)
				{
					if(districten == null)
					{
						districten = new List<ClubCloud_District>();
					}

					ClubCloud_Setting settings = GetSettings(bondsnummer);
					if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
							GetDistrictResponse districtenResponse = LedenAdministratie.GetDistrict(new GetDistrictRequest { Bondsnummer = bondsnummer });

							if (districtenResponse != null && districtenResponse.Districten.Length > 0)
							{
								foreach (District district in districtenResponse.Districten)
								{
									ClubCloud_District cdistrict = beheerModel.ClubCloud_Districten.SingleOrDefault(d => d.Id == district.Id);

									if(cdistrict == null)
									{
										cdistrict = beheerModel.ClubCloud_Districten.Create();
										cdistrict.Id = district.Id;
										cdistrict.DistrictNaam = district.DistrictNaam;
										beheerModel.ClubCloud_Districten.Add(cdistrict);
										districten.Add(cdistrict);
									}
									else
									{
										cdistrict.DistrictNaam = district.DistrictNaam;
									}
								}


							}
						}
					}
				}
				beheerModel.SaveChanges();
			}
			
				return districten;
		}
        */

        #endregion

        #region Club


        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            //CheckDatabase();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();


            vereniging = VerenigingById(bondsnummer, verenigingId, refresh);

            return vereniging;
        }

        /*
        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                vereniging = beheerModel.ClubCloud_Verenigingen.FirstOrDefault(v => v.Nummer == vereniginsnummer);
                //vereniging = beheerModel.ClubCloud_Verenigingen.Select<ClubCloud_Vereniging, ClubCloud_Vereniging>(v => v.Verenigingsnummer == vereniginsnummer).First<ClubCloud_Vereniging>();

                if (vereniging == null || refresh)
                {
                    ClubCloud_Setting settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                        }
                    }
                }
            }

            return vereniging;
        }
        */

        #endregion

        #region Mijn

        #endregion

        #region Afhangen

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Latitude"></param>
        /// <param name="Longitude"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = null;
            ClubCloud_Address address;// = null;

            try
            {

            string LatitudeCI = Latitude.ToString(CultureInfo.InvariantCulture);
            //double LatitudeCI = double.Parse(Latitude, CultureInfo.InvariantCulture);
            string LongitudeCI = Longitude.ToString(CultureInfo.InvariantCulture);
            //double LongitudeCI = double.Parse(Longitude, CultureInfo.InvariantCulture);

            string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);
            // 4326 is most common coordinate system used by GPS/Maps
            DbGeography Location = DbGeography.PointFromText(PointInText, 4326);

            System.Data.ConnectionState state = beheerModel.Database.Connection.State;

            address = (from u in beheerModel.ClubCloud_Addresses
                                         where u.GeoLocation != null 
                                         orderby u.GeoLocation.Distance(Location)
                                         select u).FirstOrDefault();

            //&& u.GeoLocation.Distance(Location) < 100
            //address = beheerModel.ClubCloud_Addresses.FirstOrDefault(a => a.GeoLocation.Distance(Location) < 99999.0);

            if (address != null && address.ParentId.Value != null && address.GeoLocation != null)
            {
                double? distance = address.GeoLocation.Distance(Location);
                ValidateBondsnummer(ref bondsnummer, address.ParentId.Value);
                return VerenigingById(bondsnummer, address.ParentId.Value, refresh);
                //return _vereniging;
            }
            //}
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return vereniging;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingNummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = null;

            vereniging = VerenigingByNummer(bondsnummer, verenigingNummer, refresh);
            return vereniging;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Vereniging GetVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            vereniging = VerenigingById(bondsnummer, verenigingId, refresh);
            return vereniging;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Afhang GetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, bool refresh)
        {
            ClubCloud_Afhang afhang = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            afhang = beheerModel.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId == verenigingId);

            if (afhang == null)
            {
                afhang = beheerModel.ClubCloud_Afhangen.Create();
                afhang.Id = Guid.NewGuid();
                afhang.MaandBegin = Month.januari;
                afhang.MaandEinde = Month.december;
                afhang.BaanBegin = TimeSpan.FromHours(9);
                afhang.BaanEinde = TimeSpan.FromHours(23);
                afhang.VerenigingId = verenigingId;
                beheerModel.ClubCloud_Afhangen.Add(afhang);
                beheerModel.SaveChanges();
            }
            return afhang;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="afhang"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Afhang SetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, ClubCloud_Afhang afhang, bool refresh)
        {
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            ClubCloud_Afhang tobeupdated = beheerModel.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId == verenigingId);
            beheerModel.Entry(tobeupdated).CurrentValues.SetValues(afhang);
            beheerModel.SaveChanges();
            tobeupdated = beheerModel.ClubCloud_Afhangen.Find(afhang.Id);
            return tobeupdated;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            banen = BanenByVerenigingId(bondsnummer, verenigingId, refresh);
            return banen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="accommodatieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            banen = BanenByAccomodatieId(bondsnummer, accommodatieId, refresh);
            return banen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="baanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Baan GetBaanById(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
        {
            ClubCloud_Baan baan = new ClubCloud_Baan();
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            baan = BaanById(bondsnummer, baanId, refresh);
            return baan;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            List<ClubCloud_Baan> banen = BanenByVerenigingId(bondsnummer, verenigingId, refresh);

            if (banen != null && banen.Count > 0 || refresh)
            {

                //if (beheerModel == null)
                //{
                //    beheerModel = new Model.BeheerContainer(GetConnectionString());
                //}

                //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                //{


                foreach (ClubCloud_Baan baan in banen)
                {
                    List<ClubCloud_Baanschema> schemaperbaan = beheerModel.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id).ToList();
                    baanschema.AddRange(schemaperbaan);
                }
                //}
            }

            return baanschema;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="accommodatieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);
            List<ClubCloud_Baan> banen = BanenByAccomodatieId(bondsnummer, accommodatieId, refresh);

            if (banen != null && banen.Count > 0 || refresh)
            {

                //if (beheerModel == null)
                //{
                //    beheerModel = new Model.BeheerContainer(GetConnectionString());
                //}

                //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                //{


                foreach (ClubCloud_Baan baan in banen)
                {
                    List<ClubCloud_Baanschema> schemaperbaan = beheerModel.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id).ToList();
                    baanschema.AddRange(schemaperbaan);
                }
                //}
            }

            return baanschema;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            ClubCloud_Reservering reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);

            if (reservering != null || refresh)
            {
                ValidateBondsnummer(ref bondsnummer, verenigingId);
                if (reservering.Gebruiker_Een != null && reservering.Gebruiker_Een.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Een = GebruikerById(bondsnummer, reservering.Gebruiker_Een.Value, refresh);
                    gebruikers.Add(Gebruiker_Een);
                }

                if (reservering.Gebruiker_Twee != null && reservering.Gebruiker_Twee.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Twee = GebruikerById(bondsnummer, reservering.Gebruiker_Twee.Value, refresh);
                    gebruikers.Add(Gebruiker_Twee);
                }

                if (reservering.Gebruiker_Drie != null && reservering.Gebruiker_Drie.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Drie = GebruikerById(bondsnummer, reservering.Gebruiker_Drie.Value, refresh);
                    gebruikers.Add(Gebruiker_Drie);
                }

                if (reservering.Gebruiker_Vier != null && reservering.Gebruiker_Vier.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Vier = GebruikerById(bondsnummer, reservering.Gebruiker_Vier.Value, refresh);
                    gebruikers.Add(Gebruiker_Vier);
                }
            }
            //}

            return gebruikers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, verenigingId);


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            List<ClubCloud_Baan> banen = beheerModel.ClubCloud_Banen.Where(b => b.AccomodatieId.Value == vereniging.AccomodatieId.Value).ToList();

            DateTime today = DateTime.Today;
            DateTime tomorrow = DateTime.Today.AddDays(1);
            foreach (ClubCloud_Baan baan in banen)
            {
                List<ClubCloud_Reservering> baanreserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baan.Id && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
                reserveringen.AddRange(baanreserveringen);
            }
            /*
            foreach(ClubCloud_Reservering reservering in reserveringen )
            {
                if (reservering.Gebruiker_Een.HasValue)
                {
                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Een.Value);
                    reservering.ClubCloud_Gebruiker_Een = gebruiker;
                }

                if (reservering.Gebruiker_Twee.HasValue)
                {
                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Twee.Value);
                    reservering.ClubCloud_Gebruiker_Twee = gebruiker;
                }

                if (reservering.Gebruiker_Drie.HasValue)
                {
                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Drie.Value);
                    reservering.ClubCloud_Gebruiker_Drie = gebruiker;
                }

                if (reservering.Gebruiker_Vier.HasValue)
                {
                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Vier.Value);
                    reservering.ClubCloud_Gebruiker_Vier = gebruiker;
                }
            }
            */
            //}

            return reserveringen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="nummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            ClubCloud_Gebruiker gebruiker = GebruikerByNummer(bondsnummer, nummer);


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            DateTime today = DateTime.Today;
            DateTime tomorrow = DateTime.Today.AddDays(1);
            reserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => (r.Gebruiker_Een.Value == gebruiker.Id || r.Gebruiker_Twee.Value == gebruiker.Id || r.Gebruiker_Drie.Value == gebruiker.Id || r.Gebruiker_Vier.Value == gebruiker.Id) && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
            //}

            return reserveringen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="reserveringId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
        {
            ClubCloud_Reservering reservering = null;

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);
            //}

            return reservering;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            DateTime today = DateTime.Today;
            DateTime tomorrow = DateTime.Today.AddDays(1);

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            reserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baanId && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
            //}

            return reserveringen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="baanId"></param>
        /// <param name="leden"></param>
        /// <param name="tijd"></param>
        /// <param name="final"></param>
        /// <param name="push"></param>
        /// <returns></returns>
        public ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum, TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "")
        {
            ClubCloud_Reservering reservering = new ClubCloud_Reservering();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            //ClubCloud_Afhang afhang = beheerModel.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId.Value == verenigingId);

            reservering = beheerModel.ClubCloud_Reserveringen.Create();
            reservering.Id = Guid.NewGuid();
            reservering.BaanId = baanId;
            reservering.Datum = Datum;
            reservering.Tijd = Tijd;
            reservering.Duur = Duur;
            reservering.Soort = Soort;
            reservering.Beschrijving = Beschrijving;
            reservering.Final = final;

            foreach (Guid gebruiker in gebruikers)
            {
                if (!reservering.Gebruiker_Een.HasValue && reservering.Gebruiker_Een.Value != Guid.Empty)
                {
                    reservering.Gebruiker_Een = gebruiker;
                    continue;
                }

                if (!reservering.Gebruiker_Twee.HasValue && reservering.Gebruiker_Twee.Value != Guid.Empty)
                {
                    reservering.Gebruiker_Twee = gebruiker;
                    continue;
                }

                if (!reservering.Gebruiker_Drie.HasValue && reservering.Gebruiker_Drie.Value != Guid.Empty)
                {
                    reservering.Gebruiker_Drie = gebruiker;
                    continue;
                }

                if (!reservering.Gebruiker_Vier.HasValue && reservering.Gebruiker_Vier.Value != Guid.Empty)
                {
                    reservering.Gebruiker_Vier = gebruiker;
                    continue;
                }
            }
            beheerModel.ClubCloud_Reserveringen.Add(reservering);
            beheerModel.SaveChanges();
            //}

            return reservering;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="reserveringId"></param>
        /// <param name="baanId"></param>
        /// <param name="leden"></param>
        /// <param name="tijd"></param>
        /// <param name="final"></param>
        /// <param name="push"></param>
        /// <returns></returns>
        public ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud_Reservering reservering, bool final = false, bool push = false)
        {

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            //ClubCloud_Afhang afhangen = beheerModel.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId.Value ==  verenigingId);

            ClubCloud_Reservering Ureservering = beheerModel.ClubCloud_Reserveringen.Find(reservering.Id);

            if (Ureservering != null)
            {

                Ureservering.BaanId = reservering.BaanId;
                Ureservering.Datum = reservering.Datum;
                Ureservering.Tijd = reservering.Tijd;
                Ureservering.Duur = reservering.Duur;
                Ureservering.Soort = reservering.Soort;
                Ureservering.Beschrijving = reservering.Beschrijving;
                Ureservering.Final = reservering.Final;

                Ureservering.Gebruiker_Een = null;
                if (!reservering.Gebruiker_Een.HasValue && reservering.Gebruiker_Een.Value != Guid.Empty)
                {
                    Ureservering.Gebruiker_Een = reservering.Gebruiker_Een.Value;
                }

                Ureservering.Gebruiker_Twee = null;
                if (!reservering.Gebruiker_Twee.HasValue && reservering.Gebruiker_Twee.Value != Guid.Empty)
                {
                    Ureservering.Gebruiker_Twee = reservering.Gebruiker_Twee.Value;
                }

                Ureservering.Gebruiker_Drie = null;
                if (!reservering.Gebruiker_Drie.HasValue && reservering.Gebruiker_Drie.Value != Guid.Empty)
                {
                    Ureservering.Gebruiker_Drie = reservering.Gebruiker_Drie.Value;
                }

                Ureservering.Gebruiker_Vier = null;
                if (!reservering.Gebruiker_Vier.HasValue && reservering.Gebruiker_Vier.Value != Guid.Empty)
                {
                    Ureservering.Gebruiker_Vier = reservering.Gebruiker_Vier.Value;
                }
            }
            beheerModel.SaveChanges();
            //}

            return reservering;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="reserveringId"></param>
        /// <param name="push"></param>
        /// <returns></returns>
        public bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false)
        {
            try
            {

                //if (beheerModel == null)
                //{
                //    beheerModel = new Model.BeheerContainer(GetConnectionString());
                //}

                //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                //{

                ClubCloud_Reservering reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);
                beheerModel.ClubCloud_Reserveringen.Remove(reservering);
                beheerModel.SaveChanges();
                //}
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        public List<ClubCloud_Gebruiker> GetGebruikersBySearch(string bondsnummer, string prefixText, int count, bool refresh = false)
        {
            string fts = BeheerFullTextInterceptor.Fts(prefixText);


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            List<ClubCloud_Gebruiker> gebruikers = beheerModel.ClubCloud_Gebruikers.Where(g => g.Volledigenaam.Contains(fts)).Take(count).ToList();
            return gebruikers;
            //}
            //return new List<ClubCloud_Gebruiker>();
        }

        #endregion

        #region Beheer

        public ClubCloud_Gebruiker_DataView GetGebruikersByQuery(string bondsnummer, Guid verenigingId, System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, bool refresh = false)
        {
            ClubCloud_Gebruiker_DataView gebruikersDV = new ClubCloud_Gebruiker_DataView();

            ValidateBondsnummer(ref bondsnummer, verenigingId);


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Gebruiker");
            List<SqlParameter> sqlparams = new List<SqlParameter>();
            List<SqlParameter> sqlparamscount = new List<SqlParameter>();
            string and = " AND ";
            if (parameters != null && parameters.Count > 0)
            {
                querybuilder.Append(" WHERE ");

                foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
                {
                    querybuilder.Append(parameter.Name + " = @" + parameter.Name + and);
                    Type type = TypeConvertor.ToNetType(parameter.DbType);
                    object value = TypeDescriptor.GetConverter(type).ConvertFrom(parameter.DefaultValue);// typeof(string)));

                    sqlparams.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
                    sqlparamscount.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
                }

                querybuilder.Remove(querybuilder.Length - and.Length, and.Length);

            }

            if (!string.IsNullOrWhiteSpace(selectArgs.SortExpression))
            {
                querybuilder.Append(" ORDER BY " + selectArgs.SortExpression);
            }

            gebruikersDV.ClubCloud_Gebruiker = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Gebruiker>();

            if (selectArgs.RetrieveTotalRowCount)
            {

                gebruikersDV.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
            }
            //}
            return gebruikersDV;
        }

        /*
        internal static void Where(Type type, string name, System.Web.UI.WebControls.ParameterCollection parameters)
        {
            System.Web.UI.WebControls.LinqDataSource source = new System.Web.UI.WebControls.LinqDataSource();
            source.WhereParameters.Add(parameters[0]);
            //source.
            foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
            {
                //System.Linq.Queryable q= Queryable.Where()
            }
        }
        */

        internal static Expression GebruikerOrderByExpression(string expression)
        {
            try
            {
                if (expression.Contains("DESC"))
                {
                    expression = expression.Replace("DESC", "").Trim();
                }

                ParameterExpression param = Expression.Parameter(typeof(ClubCloud_Gebruiker), "gebruiker");
                //Expression.Convert(Expression.Property(param, expression));
                return Expression.Lambda<Func<ClubCloud_Gebruiker, object>>(Expression.Convert(Expression.Property(param, expression), typeof(object)), param);

                //List<ClubCloud_Gebruiker> source = new List<ClubCloud_Gebruiker> ();
                //source.AsQueryable<ClubCloud_Gebruiker>().OrderByDescending<ClubCloud_Gebruiker, object>(sortExpression,param);
                /*
                if (!SortDescending)
                    return source.AsQueryable<ClubCloud_Gebruiker>().OrderBy<ClubCloud_Gebruiker, object>(sortExpression);
                else
                    return source.AsQueryable<ClubCloud_Gebruiker>().OrderByDescending<ClubCloud_Gebruiker, object>(sortExpression);
                 */
            }
            catch
            {
                return null;
            }
        }

        /*
        private List<ClubCloud_Gebruiker> SortGebruikers(List<ClubCloud_Gebruiker> gebuikers, string sort)
        {
            switch (sort.ToLower())
            {
                default:
                    gebuikers = gebuikers.OrderBy(u => u.FirstName).ThenBy(u => u.LastName);
                    break;
                case "namedesc":
                    gebuikers = gebuikers.OrderByDescending(u => u.FirstName).ThenByDescending(u => u.LastName);
                    break;
                case "emailasc":
                    gebuikers = gebuikers.OrderBy(u => u.Email);
                    break;
                case "emaildesc":
                    gebuikers = gebuikers.OrderByDescending(u => u.Email);
                    break;
                case "typeasc":
                    gebuikers = gebuikers.OrderBy(u => u.UsertypeSortingOrder);
                    break;
                case "typedesc":
                    gebuikers = gebuikers.OrderByDescending(u => u.UsertypeSortingOrder);
                    break;
            }
            return gebuikers;
        }
        */

        #endregion

        #region Data

        #region Nationaliteit

        /// <summary>
        /// GetNationaliteiten
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Nationaliteit> GetNationaliteiten(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Nationaliteit> nationaliteiten = new System.Collections.Generic.List<ClubCloud_Nationaliteit>();

            //CheckDatabase();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            nationaliteiten = beheerModel.ClubCloud_Nationaliteiten.Where(n => n.Naam != string.Empty).ToList<ClubCloud_Nationaliteit>();

            if (settings == null)
            {
                settings = GetSettings(bondsnummer);
            }

            if (nationaliteiten == null && nationaliteiten.Count == 0 || refresh)
            {
                if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_nationaliteit", out moreRecords, ref pageNum);

                            foreach (sgt_alg_nationaliteit entity in entities)
                            {
                                ClubCloud_Nationaliteit nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Find(entity.sgt_alg_nationaliteitid.Value);

                                if (nationaliteit == null)
                                {
                                    nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Create();
                                    nationaliteit.Id = entity.sgt_alg_nationaliteitid.Value;
                                    nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                    nationaliteit.Code = entity.sgt_verkorte_code;
                                    beheerModel.ClubCloud_Nationaliteiten.Add(nationaliteit);
                                    nationaliteiten.Add(nationaliteit);
                                }
                                else
                                {
                                    nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                    nationaliteit.Code = entity.sgt_verkorte_code;
                                    nationaliteiten.Add(nationaliteit);
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return nationaliteiten;
        }

        /// <summary>
        /// GetNationaliteiten
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Nationaliteit GetNationaliteitById(string bondsnummer, Guid nationaliteitId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Nationaliteit nationaliteit = new ClubCloud_Nationaliteit();

            //CheckDatabase();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Find(nationaliteitId);

            if (settings == null)
            {
                settings = GetSettings(bondsnummer);
            }

            if (nationaliteit == null || refresh)
            {
                if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_nationaliteitid", Operator = ConditionOperator.Equal, Values = new object[1] { nationaliteitId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_nationaliteit", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_nationaliteit entity in entities)
                            {
                                nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Find(entity.sgt_alg_nationaliteitid.Value);

                                if (nationaliteit == null)
                                {
                                    nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Create();
                                    nationaliteit.Id = entity.sgt_alg_nationaliteitid.Value;
                                    nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                    nationaliteit.Code = entity.sgt_verkorte_code;
                                    beheerModel.ClubCloud_Nationaliteiten.Add(nationaliteit);
                                }
                                else
                                {
                                    nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                    nationaliteit.Code = entity.sgt_verkorte_code;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return nationaliteit;
        }

        #endregion

        #region District

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="districtId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_District DistrictById(string bondsnummer, Guid districtId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_District district = new ClubCloud_District();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            district = beheerModel.ClubCloud_Districten.Find(districtId);

            if (district != null)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_districtid", Operator = ConditionOperator.Equal, Values = new object[1] { districtId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_district entity in entities)
                            {
                                district = beheerModel.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                if (district == null)
                                {
                                    district = beheerModel.ClubCloud_Districten.Create();
                                    district.Id = entity.sgt_alg_districtid.Value;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    district.Naam = entity.sgt_alg_district1;
                                    district.Omschrijving = entity.sgt_omschrijving;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_regioid != null)
                                    {
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                    }
                                    district.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Districten.Add(district);

                                }
                                else
                                {
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    district.Naam = entity.sgt_alg_district1;
                                    district.Omschrijving = entity.sgt_omschrijving;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_regioid != null)
                                    {
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                    }
                                    district.Actief = entity.statuscode.name;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return district;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="regioId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_District DistrictByRegio(string bondsnummer, Guid regioId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_District district = new ClubCloud_District();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            district = beheerModel.ClubCloud_Districten.SingleOrDefault(d => d.RegioId == regioId);

            if (district != null)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_regioid", Operator = ConditionOperator.Equal, Values = new object[1] { regioId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_district entity in entities)
                            {
                                district = beheerModel.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                if (district == null)
                                {
                                    district = beheerModel.ClubCloud_Districten.Create();
                                    district.Id = entity.sgt_alg_districtid.Value;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    district.Naam = entity.sgt_alg_district1;
                                    district.Omschrijving = entity.sgt_omschrijving;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_regioid != null)
                                    {
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                    }

                                    district.RegioId = entity.sgt_regioid.Value;
                                    district.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Districten.Add(district);
                                }
                                else
                                {
                                    district.Id = entity.sgt_alg_districtid.Value;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    district.Naam = entity.sgt_alg_district1;
                                    district.Omschrijving = entity.sgt_omschrijving;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_regioid != null)
                                    {
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                    }

                                    district.RegioId = entity.sgt_regioid.Value;
                                    district.Actief = entity.statuscode.name;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return district;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_District> Districten(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_District> districten = new List<ClubCloud_District>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            districten = beheerModel.ClubCloud_Districten.ToList();

            if (districten != null && districten.Count == 0)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum);

                            foreach (sgt_alg_district entity in entities)
                            {
                                ClubCloud_District district = beheerModel.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                if (district == null)
                                {
                                    district = beheerModel.ClubCloud_Districten.Create();
                                    district.Id = entity.sgt_alg_districtid.Value;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    district.Naam = entity.sgt_alg_district1;
                                    district.Omschrijving = entity.sgt_omschrijving;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_regioid != null)
                                    {
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                    }

                                    district.RegioId = entity.sgt_regioid.Value;
                                    district.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Districten.Add(district);
                                    districten.Add(district);
                                }
                                else
                                {
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    district.Naam = entity.sgt_alg_district1;
                                    district.Omschrijving = entity.sgt_omschrijving;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_regioid != null)
                                    {
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                    }

                                    district.Actief = entity.statuscode.name;
                                    districten.Add(district);
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return districten;
            //sgt_alg_functie
        }
        #endregion

        #region Regio

        private ClubCloud_Regio RegioById(string bondsnummer, Guid regioId, string naam = null, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Regio regio = new ClubCloud_Regio();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            regio = beheerModel.ClubCloud_Regios.Find(regioId);

            if (regio == null && naam != null)
            {
                regio = beheerModel.ClubCloud_Regios.Create();
                regio.Id = regioId;
                regio.Naam = naam;
                beheerModel.ClubCloud_Regios.Add(regio);
            }
            beheerModel.SaveChanges();
            //}
            return regio;
        }

        private List<ClubCloud_Regio> Regios(string bondsnummer, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Regio> regios = new List<ClubCloud_Regio>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            regios = beheerModel.ClubCloud_Regios.ToList();

            //}
            return regios;
        }

        #endregion

        #region Rechtsvorm

        private ClubCloud_Rechtsvorm RechtsvormById(string bondsnummer, Guid rechtsvormId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Rechtsvorm rechtsvorm = new ClubCloud_Rechtsvorm();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            rechtsvorm = beheerModel.ClubCloud_Rechtsvormen.Find(rechtsvormId);

            if (rechtsvorm != null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_rechtsvormid", Operator = ConditionOperator.Equal, Values = new object[1] { rechtsvormId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_rechtsvorm", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_rechtsvorm entity in entities)
                            {
                                rechtsvorm = beheerModel.ClubCloud_Rechtsvormen.Find(entity.sgt_alg_rechtsvormid.Value);

                                if (rechtsvorm == null)
                                {
                                    rechtsvorm = beheerModel.ClubCloud_Rechtsvormen.Create();
                                    rechtsvorm.Id = entity.sgt_alg_rechtsvormid.Value;
                                    rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                    rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                    rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                    rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                    rechtsvorm.Code = entity.sgt_verkorte_code;
                                    rechtsvorm.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Rechtsvormen.Add(rechtsvorm);
                                }
                                else
                                {
                                    rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                    rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                    rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                    rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                    rechtsvorm.Code = entity.sgt_verkorte_code;
                                    rechtsvorm.Actief = entity.statuscode.name;
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return rechtsvorm;
            //sgt_alg_functie
        }

        private List<ClubCloud_Rechtsvorm> Rechtsvormen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Rechtsvorm> rechtsvormen = new List<ClubCloud_Rechtsvorm>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            rechtsvormen = beheerModel.ClubCloud_Rechtsvormen.ToList();

            if (rechtsvormen != null && rechtsvormen.Count == 0)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_rechtsvorm", out moreRecords, ref pageNum);

                            foreach (sgt_alg_rechtsvorm entity in entities)
                            {
                                ClubCloud_Rechtsvorm rechtsvorm = beheerModel.ClubCloud_Rechtsvormen.Find(entity.sgt_alg_rechtsvormid.Value);

                                if (rechtsvorm == null)
                                {
                                    rechtsvorm = beheerModel.ClubCloud_Rechtsvormen.Create();
                                    rechtsvorm.Id = entity.sgt_alg_rechtsvormid.Value;
                                    rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                    rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                    rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                    rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                    rechtsvorm.Code = entity.sgt_verkorte_code;
                                    rechtsvorm.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Rechtsvormen.Add(rechtsvorm);
                                    rechtsvormen.Add(rechtsvorm);
                                }
                                else
                                {
                                    rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                    rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                    rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                    rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                    rechtsvorm.Code = entity.sgt_verkorte_code;
                                    rechtsvorm.Actief = entity.statuscode.name;
                                    rechtsvormen.Add(rechtsvorm);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return rechtsvormen;
            //sgt_alg_functie
        }
        #endregion

        #region Vereniging

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging VerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{
            vereniging = beheerModel.ClubCloud_Verenigingen.Find(verenigingId);

            if (vereniging == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "accountid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                            foreach (account entity in entities)
                            {
                                vereniging = beheerModel.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                //vereniging = beheerModel.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                if (vereniging == null)
                                {
                                    vereniging = beheerModel.ClubCloud_Verenigingen.Create();
                                    vereniging.Id = entity.accountid.Value;

                                    entityToVereniging(entity, vereniging, bondsnummer, settings);

                                    beheerModel.ClubCloud_Verenigingen.Add(vereniging);

                                }
                                else
                                {
                                    entityToVereniging(entity, vereniging, bondsnummer, settings);

                                }
                                GetClubCloudSettings(vereniging.Nummer);
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return vereniging;

        }

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingNummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging VerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            vereniging = beheerModel.ClubCloud_Verenigingen.SingleOrDefault(l => l.Nummer == verenigingNummer);

            if (vereniging == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "accountnumber", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingNummer } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                            foreach (account entity in entities)
                            {
                                vereniging = beheerModel.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                if (vereniging == null)
                                {
                                    vereniging = beheerModel.ClubCloud_Verenigingen.Create();
                                    vereniging.Id = entity.accountid.Value;

                                    entityToVereniging(entity, vereniging, bondsnummer, settings);

                                    beheerModel.ClubCloud_Verenigingen.Add(vereniging);

                                }
                                else
                                {
                                    entityToVereniging(entity, vereniging, bondsnummer, settings);

                                }
                                GetClubCloudSettings(vereniging.Nummer);
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return vereniging;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingNummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        public void VerenigingenUpdate(string bondsnummer, bool refresh = false)
        {
            //CheckDatabase();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
            {
                CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                if (cc != null)
                {
                    ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                    bool moreRecords = true;
                    int pageNum = 1;
                    while (moreRecords)
                    {
                        //ConditionExpression condition = new ConditionExpression { AttributeName = "accountnumber", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingNummer } };
                        //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                        List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum);

                        foreach (account entity in entities)
                        {
                            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                            if (vereniging == null)
                            {
                                vereniging = beheerModel.ClubCloud_Verenigingen.Create();
                                vereniging.Id = entity.accountid.Value;

                                entityToVereniging(entity, vereniging, bondsnummer, settings);

                                beheerModel.ClubCloud_Verenigingen.Add(vereniging);

                            }
                            else
                            {
                                entityToVereniging(entity, vereniging, bondsnummer, settings);

                            }

                            beheerModel.SaveChanges();

                            BestuursOrgaanByVereniging(bondsnummer, vereniging.Id, true, settings);
                            FunctionarissenByVereniging(bondsnummer, vereniging.Id, true, settings);
                        }
                    }
                }
            }
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="vereniging"></param>
        /// <param name="bondsnummer"></param>
        private void entityToVereniging(account entity, ClubCloud_Vereniging vereniging, string bondsnummer, ClubCloud_Setting settings = null)
        {
            vereniging.Nummer = entity.accountnumber;
            vereniging.Naam = entity.name;

            if (entity.sgt_districtid != null)
            {
                ClubCloud_District district = DistrictById(bondsnummer, entity.sgt_districtid.Value, false, settings);
                //vereniging.ClubCloud_District = district;
                vereniging.DistrictId = entity.sgt_districtid.Value;
            }

            vereniging.KvKnummer = entity.sgt_kvk_nummer;
            if (entity.sgt_kvkplaatsid != null)
            {
                vereniging.KvKplaats = entity.sgt_kvkplaatsid.name;
            }

            vereniging.BankNummer = entity.sgt_rekeningnummer;
            vereniging.BankIban = entity.sgt_iban_code;
            vereniging.BankPlaats = entity.sgt_rekeningnummer_plaats;

            if (entity.sgt_rechtsvormid != null)
            {
                ClubCloud_Rechtsvorm recht = RechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value, false, settings);
                //vereniging.ClubCloud_Rechtsvorm = recht;
                vereniging.RechtsvormId = entity.sgt_rechtsvormid.Value;
            }

            if (entity.sgt_hoofdaccomodatieid != null)
            {
                ClubCloud_Accomodatie accomodatie = AccommodatieById(bondsnummer, entity.sgt_hoofdaccomodatieid.Value, false, settings);
                //vereniging.ClubCloud_Accomodatie = accomodatie;
                vereniging.AccomodatieId = entity.sgt_hoofdaccomodatieid.Value;
            }

            if (entity.address1_addressid != null)
            {
                ClubCloud_Address bezoek = AddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                //vereniging.ClubCloud_Address.Add(bezoek);
            }
            if (entity.address2_addressid != null)
            {
                ClubCloud_Address post = AddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                //vereniging.ClubCloud_Address.Add(post);
            }

            if (entity.parentaccountid != null)
            {
                ClubCloud_Regio regio = RegioById(bondsnummer, entity.parentaccountid.Value, entity.parentaccountid.name);
                //vereniging.ClubCloud_Regio = regio;
                vereniging.RegioId = entity.parentaccountid.Value;
            }

            vereniging.EmailKNLTB = entity.emailaddress1;
            vereniging.EmailWebSite = entity.emailaddress2;
            vereniging.EmailOverig = entity.emailaddress3;
            vereniging.Fax = entity.fax;
            vereniging.FTPsite = entity.ftpsiteurl;
            vereniging.Website = entity.websiteurl;
            vereniging.Beschrijving = entity.description;
            vereniging.TelefoonOverdag = entity.telephone1;
            vereniging.TelefoonAvond = entity.telephone2;
            vereniging.TelefoonOverig = entity.telephone1;
            if (entity.sgt_datum_oprichting != null)
            {
                vereniging.Oprichting = DateTime.Parse(entity.sgt_datum_oprichting.Value);
            }
            if (entity.sgt_datumer_kenning != null)
            {
                vereniging.Erkenning = DateTime.Parse(entity.sgt_datumer_kenning.Value);
            }
            if (entity.sgt_datum_afmelding != null)
            {
                vereniging.Gestopt = DateTime.Parse(entity.sgt_datum_afmelding.Value);
            }
            if (entity.sgt_aantal_maanden_geopend != null)
            {
                vereniging.Maanden = entity.sgt_aantal_maanden_geopend.Value;
            }
            vereniging.Actief = entity.statuscode.name;
            vereniging.Gewijzigd = DateTime.Now;


        }

        #endregion

        #region Adres

        private async Task AddressByIdAsync(string bondsnummer, Guid addressId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            AddressById(bondsnummer, addressId, false, settings);
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="addressId"></param>
        /// <param name="refresh"></param>
        /// <returns>ClubCloud_Address</returns>
        private ClubCloud_Address AddressById(string bondsnummer, Guid addressId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Address address = new ClubCloud_Address();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            address = beheerModel.ClubCloud_Addresses.Find(addressId);

            if (address == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "customeraddressid", Operator = ConditionOperator.Equal, Values = new object[1] { addressId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum, expression);

                            foreach (customeraddress entity in entities)
                            {
                                address = beheerModel.ClubCloud_Addresses.Find(entity.customeraddressid.Value);

                                if (address == null)
                                {
                                    address = beheerModel.ClubCloud_Addresses.Create();
                                    address.Id = entity.customeraddressid.Value;
                                    address.Stad = entity.city;
                                    if (entity.latitude != null)
                                    {
                                        address.Latitude = entity.latitude.Value;
                                    }
                                    if (entity.longitude != null)
                                    {
                                        address.Longitude = entity.longitude.Value;
                                    }

                                    if (entity.latitude != null && entity.longitude != null)
                                    {
                                        string LatitudeCI = entity.latitude.Value.ToString(CultureInfo.InvariantCulture);
                                        string LongitudeCI = entity.longitude.Value.ToString(CultureInfo.InvariantCulture);

                                        string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);
                                        address.GeoLocation = DbGeography.PointFromText(PointInText, 4326);
                                    }

                                    address.Gemeente = entity.county;
                                    address.Land = entity.country;
                                    address.Fax = entity.fax;
                                    address.Straat = entity.line1;
                                    address.Nummer = entity.line2;
                                    address.Toevoeging = entity.line3;
                                    address.Naam = entity.name;

                                    if (entity.parentid != null)
                                    {
                                        address.ParentId = entity.parentid.Value;
                                    }
                                    address.Postcode = entity.postalcode;
                                    address.Postbus = entity.postofficebox;
                                    address.Provincie = entity.stateorprovince;
                                    address.TelefoonPrimair = entity.telephone1;
                                    address.TelefoonSecundair = entity.telephone2;
                                    address.TelefoonTertiair = entity.telephone3;
                                    address.Gewijzigd = DateTime.Now;
                                    beheerModel.ClubCloud_Addresses.Add(address);
                                }
                                else
                                {
                                    address.Stad = entity.city;
                                    if (entity.latitude != null)
                                    {
                                        address.Latitude = entity.latitude.Value;
                                    }
                                    if (entity.longitude != null)
                                    {
                                        address.Longitude = entity.longitude.Value;
                                    }

                                    if (entity.latitude != null && entity.longitude != null)
                                    {
                                        string LatitudeCI = entity.latitude.Value.ToString(CultureInfo.InvariantCulture);
                                        string LongitudeCI = entity.longitude.Value.ToString(CultureInfo.InvariantCulture);

                                        string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);

                                        address.GeoLocation = DbGeography.PointFromText(PointInText, 4326);
                                    }

                                    address.Gemeente = entity.county;
                                    address.Land = entity.country;
                                    address.Fax = entity.fax;
                                    address.Straat = entity.line1;
                                    address.Nummer = entity.line2;
                                    address.Toevoeging = entity.line3;
                                    address.Naam = entity.name;
                                    if (entity.parentid != null)
                                    {
                                        address.ParentId = entity.parentid.Value;
                                    }
                                    address.Postcode = entity.postalcode;
                                    address.Postbus = entity.postofficebox;
                                    address.Provincie = entity.stateorprovince;
                                    address.TelefoonPrimair = entity.telephone1;
                                    address.TelefoonSecundair = entity.telephone2;
                                    address.TelefoonTertiair = entity.telephone3;
                                    address.Gewijzigd = DateTime.Now;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return address;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="parentId"></param>
        /// <param name="refresh"></param>
        /// <returns>List<ClubCloud_Address></returns>
        private List<ClubCloud_Address> AddressByParent(string bondsnummer, Guid parentId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Address> addresses = new List<ClubCloud_Address>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{
            addresses = beheerModel.ClubCloud_Addresses.Where(a => a.ParentId == parentId).ToList();

            if (addresses == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { parentId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum, expression);

                            foreach (customeraddress entity in entities)
                            {
                                ClubCloud_Address address = beheerModel.ClubCloud_Addresses.Find(entity.customeraddressid.Value);

                                if (addresses == null)
                                {
                                    address = beheerModel.ClubCloud_Addresses.Create();
                                    address.Id = entity.customeraddressid.Value;
                                    address.Stad = entity.city;
                                    if (entity.latitude != null)
                                    {
                                        address.Latitude = entity.latitude.Value;
                                    }
                                    if (entity.longitude != null)
                                    {
                                        address.Longitude = entity.longitude.Value;
                                    }

                                    if (entity.latitude != null && entity.longitude != null)
                                    {
                                        string LatitudeCI = entity.latitude.Value.ToString(CultureInfo.InvariantCulture);
                                        string LongitudeCI = entity.longitude.Value.ToString(CultureInfo.InvariantCulture);

                                        string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);

                                        address.GeoLocation = DbGeography.PointFromText(PointInText, 4326);
                                    }
                                    address.Gemeente = entity.county;
                                    address.Land = entity.country;
                                    address.Fax = entity.fax;
                                    address.Straat = entity.line1;
                                    address.Nummer = entity.line2;
                                    address.Toevoeging = entity.line3;
                                    address.Naam = entity.name;
                                    if (entity.parentid != null)
                                    {
                                        address.ParentId = entity.parentid.Value;
                                    }
                                    address.Postcode = entity.postalcode;
                                    address.Postbus = entity.postofficebox;
                                    address.Provincie = entity.stateorprovince;
                                    address.TelefoonPrimair = entity.telephone1;
                                    address.TelefoonSecundair = entity.telephone2;
                                    address.TelefoonTertiair = entity.telephone3;
                                    address.Gewijzigd = DateTime.Now;
                                    beheerModel.ClubCloud_Addresses.Add(address);
                                    addresses.Add(address);

                                }
                                else
                                {
                                    address.Stad = entity.city;
                                    if (entity.latitude != null)
                                    {
                                        address.Latitude = entity.latitude.Value;
                                    }
                                    if (entity.longitude != null)
                                    {
                                        address.Longitude = entity.longitude.Value;
                                    }

                                    if (entity.latitude != null && entity.longitude != null)
                                    {
                                        string LatitudeCI = entity.latitude.Value.ToString(CultureInfo.InvariantCulture);
                                        string LongitudeCI = entity.longitude.Value.ToString(CultureInfo.InvariantCulture);

                                        string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);

                                        address.GeoLocation = DbGeography.PointFromText(PointInText, 4326);
                                    }

                                    address.Gemeente = entity.county;
                                    address.Land = entity.country;
                                    address.Fax = entity.fax;
                                    address.Straat = entity.line1;
                                    address.Nummer = entity.line2;
                                    address.Toevoeging = entity.line3;
                                    address.Naam = entity.name;
                                    if (entity.parentid != null)
                                    {
                                        address.ParentId = entity.parentid.Value;
                                    }
                                    address.Postcode = entity.postalcode;
                                    address.Postbus = entity.postofficebox;
                                    address.Provincie = entity.stateorprovince;
                                    address.TelefoonPrimair = entity.telephone1;
                                    address.TelefoonSecundair = entity.telephone2;
                                    address.TelefoonTertiair = entity.telephone3;
                                    address.Gewijzigd = DateTime.Now;
                                    addresses.Add(address);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return addresses;
        }

        #endregion

        #region Functie

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Functie FunctieById(string bondsnummer, Guid functieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Functie functie = new ClubCloud_Functie();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            functie = beheerModel.ClubCloud_Functies.Find(functieId);

            if (functie == null)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_functieid", Operator = ConditionOperator.Equal, Values = new object[1] { functieId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functie", out moreRecords, ref pageNum);

                            foreach (sgt_alg_functie entity in entities)
                            {
                                functie = beheerModel.ClubCloud_Functies.Find(entity.sgt_alg_functieid.Value);

                                if (functie == null)
                                {
                                    functie = beheerModel.ClubCloud_Functies.Create();
                                    functie.Id = entity.sgt_alg_functieid.Value;
                                    functie.Beschrijving = entity.sgt_beschrijving;
                                    functie.Code = entity.sgt_verkorte_code;
                                    functie.Meervoud = entity.sgt_meervoudsnaam;
                                    functie.Naam = entity.sgt_alg_functie1;
                                    functie.Omschrijving = entity.sgt_omschrijving;
                                    if (entity.sgt_toegang_crm_toegestaan != null)
                                    {
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                    }

                                    functie.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Functies.Add(functie);
                                }
                                else
                                {
                                    functie.Beschrijving = entity.sgt_beschrijving;
                                    functie.Code = entity.sgt_verkorte_code;
                                    functie.Meervoud = entity.sgt_meervoudsnaam;
                                    functie.Naam = entity.sgt_alg_functie1;
                                    functie.Omschrijving = entity.sgt_omschrijving;
                                    if (entity.sgt_toegang_crm_toegestaan != null)
                                    {
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                    }

                                    functie.Actief = entity.statuscode.name;
                                }

                                beheerModel.SaveChanges();

                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return functie;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        private List<ClubCloud_Functie> Functies(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            functies = beheerModel.ClubCloud_Functies.ToList();
            if (functies != null && functies.Count == 0)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functie", out moreRecords, ref pageNum);

                            foreach (sgt_alg_functie entity in entities)
                            {
                                ClubCloud_Functie functie = beheerModel.ClubCloud_Functies.Find(entity.sgt_alg_functieid.Value);

                                if (functie == null)
                                {
                                    functie = beheerModel.ClubCloud_Functies.Create();
                                    functie.Id = entity.sgt_alg_functieid.Value;
                                    functie.Beschrijving = entity.sgt_beschrijving;
                                    functie.Code = entity.sgt_verkorte_code;
                                    functie.Meervoud = entity.sgt_meervoudsnaam;
                                    functie.Naam = entity.sgt_alg_functie1;
                                    functie.Omschrijving = entity.sgt_omschrijving;
                                    if (entity.sgt_toegang_crm_toegestaan != null)
                                    {
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                    }
                                    functie.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Functies.Add(functie);
                                    functies.Add(functie);
                                }
                                else
                                {
                                    functie.Beschrijving = entity.sgt_beschrijving;
                                    functie.Code = entity.sgt_verkorte_code;
                                    functie.Meervoud = entity.sgt_meervoudsnaam;
                                    functie.Naam = entity.sgt_alg_functie1;
                                    functie.Omschrijving = entity.sgt_omschrijving;
                                    if (entity.sgt_toegang_crm_toegestaan != null)
                                    {
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                    }

                                    functie.Actief = entity.statuscode.name;
                                    functies.Add(functie);
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return functies;
            //sgt_alg_functie
        }

        #endregion

        #region Functionaris

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functionaris"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Functionaris FunctionarisCreate(string bondsnummer, ClubCloud_Functionaris functionaris, bool refresh = false)
        {
            //CheckDatabase();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            if (functionaris.Id == null)
            {
                sgt_alg_functionaris sgt_functionaris = new sgt_alg_functionaris
                {
                    //sgt_alg_name = functionaris.GebruikerNaam,
                    sgt_basisorganisatieid = new Lookup { name = functionaris.ClubCloud_Vereniging.Naam, Value = functionaris.ClubCloud_Vereniging.Id },
                    //sgt_bestuursorgaanid = new Lookup { name = functionaris.BestuursorgaanNaam, Value = functionaris.BestuursorgaanId },
                    //sgt_districtid = new Lookup { name = functionaris.DistrictNaam, Value = functionaris.DistrictId },
                    //sgt_functieid = new Lookup { name = functionaris.FunctieNaam, Value = functionaris.FunctieId },
                    //sgt_functionarisid = new Lookup { name = functionaris.GebruikerNaam, Value = functionaris.GebruikerId },
                    sgt_termijn_begint = new CrmDateTime { Value = functionaris.TermijnBegin.ToString() },
                    sgt_termijn_loopt_af = new CrmDateTime { Value = functionaris.TermijnEinde.Value.ToString() }
                };

                TargetCreateSgt_alg_functionaris create = new TargetCreateSgt_alg_functionaris { Sgt_alg_functionaris = sgt_functionaris };


                beheerModel.ClubCloud_Functionarissen.Add(functionaris);

                beheerModel.SaveChanges();
            }
            //}

            return functionaris;
        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="FunctieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> FunctionarissenByFunctie(string bondsnummer, Guid VerenigingId, Guid FunctieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.FunctieId == FunctieId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

            if (functionarissen != null && functionarissen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_functieid", Operator = ConditionOperator.Equal, Values = new object[1] { FunctieId } };
                        FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_functionaris entity in entities)
                            {
                                ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.SingleOrDefault(f => f.Id == entity.sgt_alg_functionarisid.Value);

                                if (functionaris == null)
                                {
                                    functionaris = beheerModel.ClubCloud_Functionarissen.Create();
                                    functionaris.Id = entity.sgt_alg_functionarisid.Value;
                                    EntityToFunctionaris(entity, functionaris, bondsnummer);


                                    beheerModel.ClubCloud_Functionarissen.Add(functionaris);
                                    functionarissen.Add(functionaris);

                                }
                                else
                                {
                                    EntityToFunctionaris(entity, functionaris, bondsnummer);
                                    functionarissen.Add(functionaris);
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return functionarissen;

        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> FunctionarissenByGebruiker(int bondsnummer, Guid gebruikerId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return FunctionarissenByGebruiker(bondsnummer.ToString(), gebruikerId, refresh, settings);
        }
        */

        private async Task FunctionarissenByGebruikerAsync(string bondsnummer, List<BusinessEntity> entities)
        {

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{


            foreach (contact entity in entities)
            {
                if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                {
                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                    List<ClubCloud_Functionaris> functies = FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                    foreach (ClubCloud_Functionaris functie in functies)
                    {
                        gebruiker.ClubCloud_Functionaris.Add(functie);
                        beheerModel.SaveChanges();
                    }
                }

            }
            beheerModel.SaveChanges();
            //}
        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> FunctionarissenByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return FunctionarissenByGebruiker(int.Parse(bondsnummer), gebruikerId, refresh, settings);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> FunctionarissenByVereniging(int bondsnummer, Guid VerenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return FunctionarissenByVereniging(bondsnummer.ToString(), VerenigingId, refresh, settings);
        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> FunctionarissenByVereniging(string bondsnummer, Guid VerenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

            if (functionarissen != null && functionarissen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_basisorganisatieid", Operator = ConditionOperator.Equal, Values = new object[1] { VerenigingId } };
                        FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_functionaris entity in entities)
                            {
                                ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                if (functionaris == null)
                                {
                                    functionaris = beheerModel.ClubCloud_Functionarissen.Create();
                                    functionaris.Id = entity.sgt_alg_functionarisid.Value;

                                    EntityToFunctionaris(entity, functionaris, bondsnummer, settings);

                                    beheerModel.ClubCloud_Functionarissen.Add(functionaris);
                                    functionarissen.Add(functionaris);

                                }
                                else
                                {
                                    EntityToFunctionaris(entity, functionaris, bondsnummer, settings);
                                    functionarissen.Add(functionaris);

                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                beheerModel.SaveChanges();
                //functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList();
            }
            beheerModel.SaveChanges();
            //}
            return functionarissen;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functionaris"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Functionaris FunctionarisUpdate(string bondsnummer, ClubCloud_Functionaris functionaris, bool refresh = false)
        {
            //CheckDatabase();
            ClubCloud_Functionaris updatable = functionaris;


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            updatable = beheerModel.ClubCloud_Functionarissen.Find(functionaris.Id);
            updatable.TermijnBegin = functionaris.TermijnBegin;
            updatable.TermijnEinde = functionaris.TermijnEinde;


            if (beheerModel.ChangeTracker.HasChanges())
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        sgt_alg_functionaris sgt_functionaris = new sgt_alg_functionaris
                        {
                            sgt_termijn_begint = new CrmDateTime { Value = functionaris.TermijnBegin.ToString() },
                            sgt_termijn_loopt_af = new CrmDateTime { Value = functionaris.TermijnEinde.Value.ToString() }
                        };

                        TargetUpdateSgt_alg_functionaris update = new TargetUpdateSgt_alg_functionaris { Sgt_alg_functionaris = sgt_functionaris };

                        UpdateRequest updateRequest = new UpdateRequest { Target = update };
                        UpdateResponse updateResponse = service.Execute(updateRequest) as UpdateResponse;

                        if (updatable.Actief != functionaris.Actief)
                        {
                            updatable.Actief = functionaris.Actief;

                            SetStateSgt_alg_functionarisRequest stateRequest = null;
                            if (functionaris.Actief == Sgt_alg_functieState.Active.ToString())
                            {
                                stateRequest = new SetStateSgt_alg_functionarisRequest { EntityId = functionaris.Id, Sgt_alg_functionarisState = Sgt_alg_functionarisState.Active, Sgt_alg_functionarisStatus = 1 };
                            }
                            else
                            {
                                stateRequest = new SetStateSgt_alg_functionarisRequest { EntityId = functionaris.Id, Sgt_alg_functionarisState = Sgt_alg_functionarisState.Inactive, Sgt_alg_functionarisStatus = 2 };
                            }

                            SetStateSgt_alg_functionarisResponse stateResponse = service.Execute(stateRequest) as SetStateSgt_alg_functionarisResponse;
                        }
                    }
                }

                beheerModel.SaveChanges();
                updatable = beheerModel.ClubCloud_Functionarissen.Find(functionaris.Id);
            }
            //}

            return updatable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="functionaris"></param>
        /// <param name="bondsnummer"></param>
        private void EntityToFunctionaris(sgt_alg_functionaris entity, ClubCloud_Functionaris functionaris, string bondsnummer, ClubCloud_Setting settings = null)
        {
            if (entity.sgt_functieid != null)
            {
                ClubCloud_Functie functie = FunctieById(bondsnummer, entity.sgt_functieid.Value, false, settings);
                //functionaris.ClubCloud_Functie = functie;
                functionaris.FunctieId = entity.sgt_functieid.Value;
            }

            if (entity.sgt_functionarisid != null)
            {
                ClubCloud_Gebruiker gebruiker = GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, false, settings);
                //functionaris.ClubCloud_Gebruiker = gebruiker;
                functionaris.GebruikerId = entity.sgt_functionarisid.Value;
            }

            ClubCloud_Vereniging vereniging = null;
            if (entity.sgt_basisorganisatieid != null)
            {
                vereniging = VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                //functionaris.ClubCloud_Vereniging = vereniging;
                functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;
            }

            if (entity.sgt_bestuursorgaanid != null)
            {
                ClubCloud_Bestuursorgaan orgaan = BestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, false, settings);
                //functionaris.ClubCloud_Bestuursorgaan = orgaan;
                functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;
            }

            if (entity.sgt_termijn_begint != null)
            {
                functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
            }
            else
            {
                if (vereniging != null && vereniging.Oprichting.HasValue)
                {
                    functionaris.TermijnBegin = vereniging.Oprichting.Value;
                }
                else
                {
                    functionaris.TermijnBegin = DateTime.Now;
                }
            }

            if (entity.sgt_termijn_loopt_af != null)
            {
                functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
            }
            if (entity.sgt_autorisatie_gezet != null)
            {
                functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
            }
            functionaris.Actief = entity.statuscode.name;
            functionaris.Gewijzigd = DateTime.Now;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> FunctionarissenByGebruiker(int bondsnummer, Guid gebruikerId, bool refresh, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.GebruikerId == gebruikerId).ToList();// && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

            if (functionarissen != null && functionarissen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_functionarisid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                        FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_functionaris entity in entities)
                            {
                                ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                if (functionaris == null)
                                {
                                    functionaris = beheerModel.ClubCloud_Functionarissen.Create();
                                    functionaris.Id = entity.sgt_alg_functionarisid.Value;

                                    EntityToFunctionaris(entity, functionaris, bondsnummer.ToString(), settings);

                                    beheerModel.ClubCloud_Functionarissen.Add(functionaris);
                                    functionarissen.Add(functionaris);

                                }
                                else
                                {
                                    EntityToFunctionaris(entity, functionaris, bondsnummer.ToString(), settings);
                                    functionarissen.Add(functionaris);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                beheerModel.SaveChanges();
                //functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.GebruikerId == gebruikerId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
            }
            beheerModel.SaveChanges();
            //}
            return functionarissen;

        }

        #endregion

        #region Bestuur

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="bestuursorgaanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Bestuursorgaan BestuursOrgaanById(string bondsnummer, Guid bestuursorgaanId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Bestuursorgaan bestuursorgaan = new ClubCloud_Bestuursorgaan();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(bestuursorgaanId);

            if (bestuursorgaan == null)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_bestuursorgaanid", Operator = ConditionOperator.Equal, Values = new object[1] { bestuursorgaanId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_bestuursorgaan entity in entities)
                            {
                                bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                if (bestuursorgaan == null)
                                {
                                    bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Create();
                                    bestuursorgaan.Id = entity.sgt_alg_bestuursorgaanid.Value;
                                    bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                    bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value);
                                        //bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }
                                    if (entity.sgt_typebestuursorgaanid != null)
                                    {
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                    }
                                    bestuursorgaan.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                }
                                else
                                {
                                    bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                    bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value);
                                        //bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }
                                    if (entity.sgt_typebestuursorgaanid != null)
                                    {
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                    }
                                    bestuursorgaan.Actief = entity.statuscode.name;
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return bestuursorgaan;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_bestuursorgaan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> BestuursOrgaanByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.Where(b => b.VerenigingId == verenigingId).ToList();

            if (bestuursorganen != null && bestuursorganen.Count == 0)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_basisorganisatieid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_bestuursorgaan entity in entities)
                            {
                                ClubCloud_Bestuursorgaan bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                if (bestuursorgaan == null)
                                {
                                    bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Create();
                                    bestuursorgaan.Id = entity.sgt_alg_bestuursorgaanid.Value;
                                    bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                    bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value);
                                        //bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }
                                    if (entity.sgt_typebestuursorgaanid != null)
                                    {
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                    }
                                    bestuursorgaan.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                    bestuursorganen.Add(bestuursorgaan);
                                }
                                else
                                {
                                    bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                    bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value);
                                        //bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }
                                    if (entity.sgt_typebestuursorgaanid != null)
                                    {
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                    }
                                    bestuursorgaan.Actief = entity.statuscode.name;
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return bestuursorganen;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_bestuursorgaan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> BestuursOrganen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.ToList();

            if (bestuursorganen != null && bestuursorganen.Count == 0)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum);

                            foreach (sgt_alg_bestuursorgaan entity in entities)
                            {
                                ClubCloud_Bestuursorgaan bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                if (bestuursorgaan == null)
                                {
                                    bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Create();
                                    bestuursorgaan.Id = entity.sgt_alg_bestuursorgaanid.Value;
                                    bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                    bestuursorgaan.Beschrijving = entity.sgt_beschrijving;

                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value);
                                        bestuursorgaan.ClubCloud_Vereniging = vereniging;
                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }
                                    if (entity.sgt_typebestuursorgaanid != null)
                                    {
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                    }
                                    bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                    bestuursorgaan.Actief = entity.statuscode.name;
                                    beheerModel.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                    bestuursorganen.Add(bestuursorgaan);
                                }
                                else
                                {
                                    bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                    bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value);
                                        bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }
                                    if (entity.sgt_typebestuursorgaanid != null)
                                    {
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                    }
                                    bestuursorgaan.Actief = entity.statuscode.name;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return bestuursorganen;
            //sgt_alg_functie
        }

        #endregion

        //TODO
        #region Baan

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> BanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, verenigingId, refresh);

            if (vereniging != null)
            {
                banen = beheerModel.ClubCloud_Banen.Where(b => b.AccomodatieId.Value == vereniging.AccomodatieId.Value).ToList();
            }

            if (banen == null || banen.Count == 0 || refresh)
            {
                banen = new List<ClubCloud_Baan>();

                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        List<sgt_alg_baan_gereserveerd_vereniging> abgv = new List<sgt_alg_baan_gereserveerd_vereniging>();

                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_verenigingid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan_gereserveerd_vereniging", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_baan_gereserveerd_vereniging entity in entities)
                            {
                                abgv.Add(entity);
                            }
                        }

                        if (abgv.Count > 0)
                        {
                            foreach (sgt_alg_baan_gereserveerd_vereniging abgv_item in abgv)
                            {
                                ClubCloud_Accomodatie accommodatie = null;

                                if (abgv_item.sgt_accommodatieid != null)
                                {
                                    accommodatie = AccommodatieById(bondsnummer, abgv_item.sgt_accommodatieid.Value, false);
                                }

                                if (accommodatie != null)
                                {
                                    for (int i = 1; i <= accommodatie.BanenAantalBuiten; i++)
                                    {
                                        ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Buiten);

                                        if (baan == null)
                                        {
                                            baan = beheerModel.ClubCloud_Banen.Create();
                                            baan.Id = Guid.NewGuid();
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Buiten)";
                                            baan.Baansoort = BaanSoort.Buiten;
                                            baan.Nummer = i;
                                            beheerModel.ClubCloud_Banen.Add(baan);

                                        }
                                        else
                                        {
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Buiten)";
                                            baan.Baansoort = BaanSoort.Buiten;
                                        }

                                        banen.Add(baan);
                                    }

                                    for (int i = 1; i <= accommodatie.BanenAantalBinnen; i++)
                                    {
                                        ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Binnen);

                                        if (baan == null)
                                        {
                                            baan = beheerModel.ClubCloud_Banen.Create();
                                            baan.Id = Guid.NewGuid();
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Binnen)";
                                            baan.Baansoort = BaanSoort.Binnen;
                                            baan.Nummer = i;
                                            beheerModel.ClubCloud_Banen.Add(baan);

                                        }
                                        else
                                        {
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Binnen)";
                                            baan.Baansoort = BaanSoort.Binnen;
                                        }

                                        banen.Add(baan);
                                    }

                                    for (int i = 1; i <= accommodatie.BlaashalAantalBanen; i++)
                                    {
                                        ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Blaashal);

                                        if (baan == null)
                                        {
                                            baan = beheerModel.ClubCloud_Banen.Create();
                                            baan.Id = Guid.NewGuid();
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Blaashal)";
                                            baan.Baansoort = BaanSoort.Blaashal;
                                            baan.Nummer = i;
                                            beheerModel.ClubCloud_Banen.Add(baan);

                                        }
                                        else
                                        {
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Blaashal)";
                                            baan.Baansoort = BaanSoort.Blaashal;
                                        }

                                        banen.Add(baan);
                                    }

                                }
                                beheerModel.SaveChanges();
                            }
                        }

                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return banen;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baansoortId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> BanenByAccomodatieId(string bondsnummer, Guid accommodatieid, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            banen = beheerModel.ClubCloud_Banen.Where(b => b.AccomodatieId.Value == accommodatieid).ToList();

            if (banen == null || banen.Count == 0 || refresh)
            {
                banen = new List<ClubCloud_Baan>();
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        List<sgt_alg_baan_gereserveerd_vereniging> abgv = new List<sgt_alg_baan_gereserveerd_vereniging>();

                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { accommodatieid } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan_gereserveerd_vereniging", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_baan_gereserveerd_vereniging entity in entities)
                            {
                                abgv.Add(entity);
                            }
                        }

                        if (abgv.Count > 0)
                        {
                            foreach (sgt_alg_baan_gereserveerd_vereniging abgv_item in abgv)
                            {
                                ClubCloud_Accomodatie accommodatie = null;

                                if (abgv_item.sgt_accommodatieid != null)
                                {
                                    accommodatie = AccommodatieById(bondsnummer, abgv_item.sgt_accommodatieid.Value, false);
                                }

                                if (accommodatie != null)
                                {
                                    for (int i = 1; i <= accommodatie.BanenAantalBuiten; i++)
                                    {
                                        ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Buiten);

                                        if (baan == null)
                                        {
                                            baan = beheerModel.ClubCloud_Banen.Create();
                                            baan.Id = Guid.NewGuid();
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Buiten)";
                                            baan.Baansoort = BaanSoort.Buiten;
                                            baan.Nummer = i;
                                            beheerModel.ClubCloud_Banen.Add(baan);

                                        }
                                        else
                                        {
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Buiten)";
                                            baan.Baansoort = BaanSoort.Buiten;
                                        }

                                        banen.Add(baan);
                                    }

                                    for (int i = 1; i <= accommodatie.BanenAantalBinnen; i++)
                                    {
                                        ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Binnen);

                                        if (baan == null)
                                        {
                                            baan = beheerModel.ClubCloud_Banen.Create();
                                            baan.Id = Guid.NewGuid();
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Binnen)";
                                            baan.Baansoort = BaanSoort.Binnen;
                                            baan.Nummer = i;
                                            beheerModel.ClubCloud_Banen.Add(baan);

                                        }
                                        else
                                        {
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Binnen)";
                                            baan.Baansoort = BaanSoort.Binnen;
                                        }

                                        banen.Add(baan);
                                    }

                                    for (int i = 1; i <= accommodatie.BlaashalAantalBanen; i++)
                                    {
                                        ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Blaashal);

                                        if (baan == null)
                                        {
                                            baan = beheerModel.ClubCloud_Banen.Create();
                                            baan.Id = Guid.NewGuid();
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Blaashal)";
                                            baan.Baansoort = BaanSoort.Blaashal;
                                            baan.Nummer = i;
                                            beheerModel.ClubCloud_Banen.Add(baan);

                                        }
                                        else
                                        {
                                            baan.AccomodatieId = accommodatie.Id;
                                            baan.Naam = "Baan " + i.ToString() + " (Blaashal)";
                                            baan.Baansoort = BaanSoort.Blaashal;
                                        }

                                        banen.Add(baan);
                                    }

                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return banen;
        }

        private ClubCloud_Baan BaanById(string bondsnummer, Guid baanId, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Baan baan = new ClubCloud_Baan();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            baan = beheerModel.ClubCloud_Banen.Find(baanId);
            //}
            return baan;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baansoortId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Baansoort BaansoortById(string bondsnummer, Guid baansoortId, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Baansoort baansoort = new ClubCloud_Baansoort();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            baansoort = beheerModel.ClubCloud_Baansoorten.Find(baansoortId);

            if (baansoort == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_baansoortid", Operator = ConditionOperator.Equal, Values = new object[1] { baansoortId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baansoort", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_baansoort entity in entities)
                            {
                                baansoort = beheerModel.ClubCloud_Baansoorten.Find(entity.sgt_alg_baansoortid.Value);

                                if (baansoort == null)
                                {
                                    baansoort.Id = entity.sgt_alg_baansoortid.Value;
                                    baansoort.Naam = entity.sgt_alg_baansoort1;

                                    if (entity.sgt_beschrijving != null)
                                    {
                                        baansoort.Beschrijving = entity.sgt_beschrijving;
                                    }

                                    if (entity.sgt_omschrijving != null)
                                    {
                                        baansoort.Omschrijving = entity.sgt_omschrijving;
                                    }

                                    if (entity.sgt_baantypeid != null)
                                    {
                                        BaantypeById(bondsnummer, entity.sgt_baantypeid.Value, entity.sgt_baantypeid.name, false);
                                        baansoort.BaantypeId = entity.sgt_baantypeid.Value;
                                    }

                                    if (entity.sgt_verkorte_code != null)
                                    {
                                        baansoort.Code = entity.sgt_verkorte_code;
                                    }

                                    if (entity.sgt_meervoudsnaam != null)
                                    {
                                        baansoort.Meervoud = entity.sgt_meervoudsnaam;
                                    }

                                    baansoort.Actief = entity.statuscode.name;

                                    beheerModel.ClubCloud_Baansoorten.Add(baansoort);
                                }
                                else
                                {
                                    baansoort.Naam = entity.sgt_alg_baansoort1;
                                    if (entity.sgt_beschrijving != null)
                                    {
                                        baansoort.Beschrijving = entity.sgt_beschrijving;
                                    }

                                    if (entity.sgt_omschrijving != null)
                                    {
                                        baansoort.Omschrijving = entity.sgt_omschrijving;
                                    }

                                    if (entity.sgt_baantypeid != null)
                                    {
                                        BaantypeById(bondsnummer, entity.sgt_baantypeid.Value, entity.sgt_baantypeid.name, false);
                                        baansoort.BaantypeId = entity.sgt_baantypeid.Value;
                                    }

                                    if (entity.sgt_verkorte_code != null)
                                    {
                                        baansoort.Code = entity.sgt_verkorte_code;
                                    }

                                    if (entity.sgt_meervoudsnaam != null)
                                    {
                                        baansoort.Meervoud = entity.sgt_meervoudsnaam;
                                    }

                                    baansoort.Actief = entity.statuscode.name;
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return baansoort;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baansoort> Baansoorten(string bondsnummer, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Baansoort> baansoorten = new List<ClubCloud_Baansoort>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            baansoorten = beheerModel.ClubCloud_Baansoorten.ToList();

            if (baansoorten == null || baansoorten.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baansoort", out moreRecords, ref pageNum);

                            foreach (sgt_alg_baansoort entity in entities)
                            {
                                ClubCloud_Baansoort baansoort = beheerModel.ClubCloud_Baansoorten.Find(entity.sgt_alg_baansoortid.Value);

                                if (baansoort == null)
                                {
                                    baansoort.Id = entity.sgt_alg_baansoortid.Value;
                                    baansoort.Naam = entity.sgt_alg_baansoort1;

                                    if (entity.sgt_beschrijving != null)
                                    {
                                        baansoort.Beschrijving = entity.sgt_beschrijving;
                                    }

                                    if (entity.sgt_omschrijving != null)
                                    {
                                        baansoort.Omschrijving = entity.sgt_omschrijving;
                                    }

                                    if (entity.sgt_baantypeid != null)
                                    {
                                        BaantypeById(bondsnummer, entity.sgt_baantypeid.Value, entity.sgt_baantypeid.name, false);
                                        baansoort.BaantypeId = entity.sgt_baantypeid.Value;
                                    }

                                    if (entity.sgt_verkorte_code != null)
                                    {
                                        baansoort.Code = entity.sgt_verkorte_code;
                                    }

                                    if (entity.sgt_meervoudsnaam != null)
                                    {
                                        baansoort.Meervoud = entity.sgt_meervoudsnaam;
                                    }
                                    baansoort.Actief = entity.statuscode.name;

                                    beheerModel.ClubCloud_Baansoorten.Add(baansoort);
                                    baansoorten.Add(baansoort);
                                }
                                else
                                {
                                    baansoort.Naam = entity.sgt_alg_baansoort1;
                                    if (entity.sgt_beschrijving != null)
                                    {
                                        baansoort.Beschrijving = entity.sgt_beschrijving;
                                    }

                                    if (entity.sgt_omschrijving != null)
                                    {
                                        baansoort.Omschrijving = entity.sgt_omschrijving;
                                    }

                                    if (entity.sgt_baantypeid != null)
                                    {
                                        BaantypeById(bondsnummer, entity.sgt_baantypeid.Value, entity.sgt_baantypeid.name, false);
                                        baansoort.BaantypeId = entity.sgt_baantypeid.Value;
                                    }

                                    if (entity.sgt_verkorte_code != null)
                                    {
                                        baansoort.Code = entity.sgt_verkorte_code;
                                    }

                                    if (entity.sgt_meervoudsnaam != null)
                                    {
                                        baansoort.Meervoud = entity.sgt_meervoudsnaam;
                                    }
                                    baansoort.Actief = entity.statuscode.name;
                                    baansoorten.Add(baansoort);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return baansoorten;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baantypeId"></param>
        /// <param name="naam"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Baantype BaantypeById(string bondsnummer, Guid baantypeId, string naam = null, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Baantype baantype = new ClubCloud_Baantype();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            baantype = beheerModel.ClubCloud_Baantypes.Find(baantypeId);

            if (baantype == null && naam != null)
            {
                baantype = beheerModel.ClubCloud_Baantypes.Create();
                baantype.Id = baantypeId;
                baantype.Naam = naam;
                beheerModel.ClubCloud_Baantypes.Add(baantype);
            }
            beheerModel.SaveChanges();
            //}
            return baantype;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baantype> Baantypes(string bondsnummer, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Baantype> baantypes = new List<ClubCloud_Baantype>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            baantypes = beheerModel.ClubCloud_Baantypes.ToList();

            //}
            return baantypes;
        }

        /*
        /// <summary>
        /// sgt_alg_speciale_baan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="accomodatieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> SpecialebaanByAccomodatie(string bondsnummer, Guid accomodatieId, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan specialebaan = new sgt_alg_speciale_baan();
            return banen;
        }

        /// <summary>
        /// sgt_alg_speciale_baan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="specialebaanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> SpecialebaanById(string bondsnummer, Guid specialebaanId, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan specialebaan = new sgt_alg_speciale_baan();
            return banen;
        }

        private List<ClubCloud_BaanSpeciaal> SpecialebaanBySoort(string bondsnummer, Guid baansoortId, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan baansoort = new sgt_alg_speciale_baan();
            return banen;
        }

        /// <summary>
        /// sgt_alg_speciale_baan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> Specialebanen(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan specialebaan = new sgt_alg_speciale_baan();

            return banen;
        }
        */

        #endregion

        #region Accomodatie

        /// <summary>
        /// sgt_alg_accommodatie
        /// </summary>
        private ClubCloud_Accomodatie AccommodatieById(string bondsnummer, Guid accomodatieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            accomodatie = beheerModel.ClubCloud_Accomodaties.Find(accomodatieId);

            if (accomodatie == null)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { accomodatieId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_accommodatie", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_accommodatie entity in entities)
                            {
                                accomodatie = beheerModel.ClubCloud_Accomodaties.Find(entity.sgt_alg_accommodatieid.Value);

                                if (accomodatie == null)
                                {
                                    accomodatie = beheerModel.ClubCloud_Accomodaties.Create();
                                    accomodatie.Id = entity.sgt_alg_accommodatieid.Value;
                                    EntityToAccomodatie(entity, accomodatie, beheerModel, bondsnummer, settings);
                                    beheerModel.ClubCloud_Accomodaties.Add(accomodatie);
                                }
                                else
                                {
                                    EntityToAccomodatie(entity, accomodatie, beheerModel, bondsnummer, settings);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return accomodatie;
        }

        /// <summary>
        /// sgt_alg_accommodatie
        /// </summary>
        private ClubCloud_Accomodatie AccommodatieByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            Guid accomodatieId = beheerModel.ClubCloud_Verenigingen.Find(verenigingId).AccomodatieId.Value;
            accomodatie = beheerModel.ClubCloud_Accomodaties.Find(accomodatieId);

            if (accomodatie == null)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { accomodatieId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_accommodatie", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_accommodatie entity in entities)
                            {
                                accomodatie = beheerModel.ClubCloud_Accomodaties.Find(entity.sgt_alg_accommodatieid.Value);

                                if (accomodatie == null)
                                {
                                    accomodatie = beheerModel.ClubCloud_Accomodaties.Create();
                                    accomodatie.Id = entity.sgt_alg_accommodatieid.Value;
                                    EntityToAccomodatie(entity, accomodatie, beheerModel, bondsnummer, settings);
                                    beheerModel.ClubCloud_Accomodaties.Add(accomodatie);
                                }
                                else
                                {
                                    EntityToAccomodatie(entity, accomodatie, beheerModel, bondsnummer, settings);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }

            beheerModel.SaveChanges();
            //}
            return accomodatie;
        }

        private void EntityToAccomodatie(sgt_alg_accommodatie entity, ClubCloud_Accomodatie accomodatie, BeheerContainer model, string bondsnummer, ClubCloud_Setting settings = null)
        {
            accomodatie.Naam = entity.sgt_alg_accommodatie1;

            if (entity.sgt_totaal_aantal_banen != null)
            {
                accomodatie.BanenAantal = entity.sgt_totaal_aantal_banen.Value;
            }

            if (entity.sgt_aantal_banen_binnen != null)
            {
                accomodatie.BanenAantalBinnen = entity.sgt_aantal_banen_binnen.Value;
            }

            if (entity.sgt_aantal_banen_buiten != null)
            {
                accomodatie.BanenAantalBuiten = entity.sgt_aantal_banen_buiten.Value;
            }

            if (entity.sgt_blaashal != null)
            {
                accomodatie.Blaashal = entity.sgt_blaashal.Value;
            }

            if (entity.sgt_soort_blaashal != null)
            {
                accomodatie.BlaashalSoort = entity.sgt_soort_blaashal.name;
            }

            if (entity.sgt_baan_blaashal != null)
            {
                accomodatie.BlaashalAantalBanen = entity.sgt_baan_blaashal.Value;
            }

            if (entity.sgt_playgrounds != null)
            {
                accomodatie.Playgrounds = entity.sgt_playgrounds.Value;
            }

            if (entity.sgt_aantal_playgrounds != null)
            {
                accomodatie.PlaygroundsAantal = entity.sgt_aantal_playgrounds.Value;
            }

            if (entity.sgt_oefenmuren != null)
            {
                accomodatie.Oefenmuren = entity.sgt_oefenmuren.Value;
            }

            if (entity.sgt_aantal_oefenmuren != null)
            {
                accomodatie.OefenmurenAantal = entity.sgt_aantal_oefenmuren.Value;
            }

            if (entity.sgt_minibanen != null)
            {
                accomodatie.Minibanen = entity.sgt_minibanen.Value;
            }

            if (entity.sgt_aantal_minibanen != null)
            {
                accomodatie.MinibanenAantal = entity.sgt_aantal_minibanen.Value;
            }

            if (entity.sgt_overkapping != null)
            {
                accomodatie.Overkapping = entity.sgt_overkapping.Value;
            }

            if (entity.sgt_soort_overkapping != null)
            {
                accomodatie.OverkappingSoort = entity.sgt_soort_overkapping.name;
            }

            if (entity.sgt_aantal_parkeerplaatsen != null)
            {
                accomodatie.AantalParkeerplaatsen = entity.sgt_aantal_parkeerplaatsen.Value;
            }

            if (entity.sgt_aantal_mv_parkeerplaatsen != null)
            {
                accomodatie.AantalParkeerplaatsenMindervalide = entity.sgt_aantal_mv_parkeerplaatsen.Value;
            }

            if (entity.sgt_ov_bereikbaar != null)
            {
                accomodatie.MetOVBereikbaar = entity.sgt_ov_bereikbaar.Value;
            }

            if (entity.sgt_email != null)
            {
                accomodatie.Email = entity.sgt_email;
            }

            if (entity.sgt_telefoon != null)
            {
                accomodatie.Telefoon = entity.sgt_telefoon;
            }

            if (entity.sgt_website != null)
            {
                accomodatie.Website = entity.sgt_website;
            }

            if (entity.sgt_status_clubhuis != null)
            {
                accomodatie.ClubhuisStatus = entity.sgt_status_clubhuis.name;
            }

            if (entity.sgt_bouwjaar_clubhuis != null)
            {
                accomodatie.ClubhuisBouwjaar = entity.sgt_bouwjaar_clubhuis;
            }

            if (entity.sgt_bouwaardid != null)
            {
                accomodatie.ClubhuisBouwaard = entity.sgt_bouwaardid.name;
            }

            if (entity.sgt_m2_clubhuis != null)
            {
                accomodatie.ClubhuisOppervlakte = entity.sgt_m2_clubhuis.Value;
            }

            if (entity.sgt_liggingid != null)
            {
                accomodatie.ClubhuisLigging = entity.sgt_liggingid.name;
            }

            if (entity.sgt_beveiliging != null)
            {
                accomodatie.ClubhuisBeveiliging = entity.sgt_beveiliging.name;
            }

            if (entity.sgt_status_hal != null)
            {
                accomodatie.HalStatus = entity.sgt_status_hal.name;
            }

            if (entity.sgt_bouwjaar_hal != null)
            {
                accomodatie.HalBouwjaar = entity.sgt_bouwjaar_hal;
            }

            if (entity.sgt_klasse_hal != null)
            {
                accomodatie.HalBouwaard = entity.sgt_klasse_hal.name;
            }

            if (entity.sgt_m2_hal != null)
            {
                accomodatie.HalOppervlakte = entity.sgt_m2_hal.Value;
            }

            /*
            entity.sgt_aantal_douches_dames;
            entity.sgt_aantal_douches_heren;
            entity.sgt_aantal_ehbo_fysio_ruimtes;
            entity.sgt_aantal_fysio_ruimtes;
            entity.sgt_aantal_kleed_wasruimtes;
            entity.sgt_aantal_kleedruimte_dames;

            entity.sgt_aantal_toiletten;
            entity.sgt_aantal_toiletten_dames;
            
            entity.sgt_aantal_verg_wed_ruimtes;
            entity.sgt_aantal_wasruimtes_clubhuis;
            entity.sgt_aantal_wasruimtes_dames;
            entity.sgt_aantal_wasruimtes_heren;
            entity.sgt_aantal_wedstrijdruimtes;
            
            
            entity.sgt_ehbo_ruimte;
            entity.sgt_fysio_ruimte;
            entity.sgt_jeugdhonk;
            entity.sgt_kantine;
            entity.sgt_keuken;
            entity.sgt_kleedruimte;
            entity.sgt_kleedruimte_dames;
                     
            entity.sgt_rolstoeltoegankelijk;
            entity.sgt_soortverlichtingid;
            entity.sgt_speeltoestellen;
            entity.sgt_toiletten_mindervaliden;
            entity.sgt_vergaderruimte;
            entity.sgt_wasruimte;
            entity.sgt_wasruimte_dames;
            entity.sgt_wedstrijdruimte;
            */

            if (entity.sgt_districtid != null)
            {
                accomodatie.DistrictId = entity.sgt_districtid.Value;
            }

            if (entity.sgt_regioid != null)
            {
                accomodatie.RegioId = entity.sgt_regioid.Value;
            }

            accomodatie.Gewijzigd = DateTime.Now;
            /*
            accomodatie.RolStoeltoegankelijk = entity.statuscode.name;            
            accomodatie.Speeltoestellen = entity.statuscode.name;
            accomodatie.Actief = entity.statuscode.name;
            */

            if (entity.sgt_alg_accommodatieid.Value != null)
            {
                List<ClubCloud_Address> addressen = AddressByParent(bondsnummer, entity.sgt_alg_accommodatieid.Value, false, settings);

                if (addressen.Count > 0)
                {
                    foreach (ClubCloud_Address addr in addressen)
                    {

                        ClubCloud_Address address = beheerModel.ClubCloud_Addresses.Find(addr.Id);

                        if (address.Naam.Equals("Bezoekadres", StringComparison.InvariantCultureIgnoreCase))
                        {
                            //address.Fax
                            address.Land = entity.sgt_bezoekadreslandcodeid.name;
                            //address.Latitude
                            //address.Longitude
                            address.Nummer = entity.sgt_bezoekadres_huisnummer;
                            address.ParentId = entity.sgt_alg_accommodatieid.Value;
                            //address.Postbus
                            address.Gemeente = entity.sgt_bezoekadres_gemeente;
                            address.Postcode = entity.sgt_bezoekadres_postcode;
                            address.Provincie = entity.sgt_bezoekadres_gemeente;
                            address.Stad = entity.sgt_bezoekadres_plaats;
                            address.Straat = entity.sgt_bezoekadres_straat;
                            //address.TelefoonPrimair
                            //address.TelefoonSecundair
                            //address.TelefoonTertiair
                            address.Toevoeging = entity.sgt_bezoekadres_toevoeging;
                            address.Actief = entity.statuscode.name;
                            address.Gewijzigd = DateTime.Now;
                        }

                        if (address.Naam.Equals("Postadres", StringComparison.InvariantCultureIgnoreCase))
                        {
                            //address.Fax
                            address.Land = entity.sgt_postadreslandcodeid.name;
                            //address.Latitude
                            //address.Longitude
                            address.Nummer = entity.sgt_postadres_huisnummer;
                            address.ParentId = entity.sgt_alg_accommodatieid.Value;
                            //address.Postbus
                            address.Gemeente = entity.sgt_postadres_gemeente;
                            address.Postcode = entity.sgt_postadres_postcode;
                            address.Provincie = entity.sgt_postadres_gemeente;
                            address.Stad = entity.sgt_postadres_plaats;
                            address.Straat = entity.sgt_postadres_straat;
                            //address.TelefoonPrimair
                            //address.TelefoonSecundair
                            //address.TelefoonTertiair
                            address.Toevoeging = entity.sgt_postadres_toevoeging;
                            address.Actief = entity.statuscode.name;
                            address.Gewijzigd = DateTime.Now;
                        }
                        beheerModel.SaveChanges();
                    }

                }
                else
                {
                    ClubCloud_Address bezoek_address = beheerModel.ClubCloud_Addresses.Create();

                    bezoek_address.Id = Guid.NewGuid();
                    bezoek_address.ParentId = entity.sgt_alg_accommodatieid.Value;
                    bezoek_address.Naam = "Bezoekadres";
                    //bezoek_address.Fax
                    bezoek_address.Land = entity.sgt_bezoekadreslandcodeid.name;
                    //bezoek_address.Latitude
                    //bezoek_address.Longitude
                    bezoek_address.Nummer = entity.sgt_bezoekadres_huisnummer;
                    bezoek_address.ParentId = entity.sgt_alg_accommodatieid.Value;
                    //bezoek_address.Postbus
                    bezoek_address.Gemeente = entity.sgt_bezoekadres_gemeente;
                    bezoek_address.Postcode = entity.sgt_bezoekadres_postcode;
                    bezoek_address.Provincie = entity.sgt_bezoekadres_gemeente;
                    bezoek_address.Stad = entity.sgt_bezoekadres_plaats;
                    bezoek_address.Straat = entity.sgt_bezoekadres_straat;
                    //bezoek_address.TelefoonPrimair
                    //bezoek_address.TelefoonSecundair
                    //bezoek_address.TelefoonTertiair
                    bezoek_address.Toevoeging = entity.sgt_bezoekadres_toevoeging;
                    bezoek_address.Actief = entity.statuscode.name;
                    bezoek_address.Gewijzigd = DateTime.Now;
                    beheerModel.ClubCloud_Addresses.Add(bezoek_address);
                    beheerModel.SaveChanges();

                    ClubCloud_Address post_address = beheerModel.ClubCloud_Addresses.Create();

                    post_address.Id = Guid.NewGuid();
                    post_address.ParentId = entity.sgt_alg_accommodatieid.Value;
                    post_address.Naam = "Postadres";
                    //post_address.Fax
                    post_address.Land = entity.sgt_postadreslandcodeid.name;
                    //post_address.Latitude
                    //post_address.Longitude
                    post_address.Nummer = entity.sgt_postadres_huisnummer;
                    post_address.ParentId = entity.sgt_alg_accommodatieid.Value;
                    //post_address.Postbus
                    post_address.Gemeente = entity.sgt_postadres_gemeente;
                    post_address.Postcode = entity.sgt_postadres_postcode;
                    post_address.Provincie = entity.sgt_postadres_gemeente;
                    post_address.Stad = entity.sgt_postadres_plaats;
                    post_address.Straat = entity.sgt_postadres_straat;
                    //post_address.TelefoonPrimair
                    //post_address.TelefoonSecundair
                    //post_address.TelefoonTertiair
                    post_address.Toevoeging = entity.sgt_postadres_toevoeging;
                    post_address.Actief = entity.statuscode.name;
                    post_address.Gewijzigd = DateTime.Now;
                    beheerModel.ClubCloud_Addresses.Add(post_address);
                    beheerModel.SaveChanges();
                }
            }
        }

        #endregion

        #region Lidmaatschap

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="lidmaatschapId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Lidmaatschap LidmaatschapById(string bondsnummer, Guid lidmaatschapId, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Lidmaatschap lidmaatschap = new ClubCloud_Lidmaatschap();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschapId);

            if (lidmaatschap == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_lidmaatschapid", Operator = ConditionOperator.Equal, Values = new object[1] { lidmaatschapId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_lidmaatschap entity in entities)
                            {
                                lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                if (lidmaatschap == null)
                                {
                                    lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Create();
                                    lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer);
                                    beheerModel.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                }
                                else
                                {
                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer);

                                }

                                if (entity.sgt_lidid != null)
                                {
                                    GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return lidmaatschap;
        }

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> Lidmaatschappen(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.VerenigingId == verenigingId).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum);

                            foreach (sgt_alg_lidmaatschap entity in entities)
                            {
                                ClubCloud_Lidmaatschap lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                if (lidmaatschap == null)
                                {
                                    lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Create();
                                    lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                    beheerModel.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                    lidmaatschappen.Add(lidmaatschap);

                                }
                                else
                                {
                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                    lidmaatschappen.Add(lidmaatschap);
                                }

                                if (entity.sgt_lidid != null)
                                {
                                    GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return lidmaatschappen;
        }

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="lidId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> LidmaatschappenByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.GebruikerId == gebruikerId).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_lidid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_lidmaatschap entity in entities)
                            {
                                ClubCloud_Lidmaatschap lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                if (lidmaatschap == null)
                                {
                                    lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Create();
                                    lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                    beheerModel.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                    lidmaatschappen.Add(lidmaatschap);

                                }
                                else
                                {
                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                    lidmaatschappen.Add(lidmaatschap);
                                }

                                beheerModel.SaveChanges();

                                if (entity.sgt_lidid != null)
                                {
                                    GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                }
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}

            return lidmaatschappen;
        }

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> LidmaatschappenByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            //CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(f => f.VerenigingId == verenigingId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_verenigingid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum, expression);

                            foreach (sgt_alg_lidmaatschap entity in entities)
                            {
                                ClubCloud_Lidmaatschap lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                if (lidmaatschap == null)
                                {
                                    lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Create();
                                    lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);

                                    beheerModel.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                    lidmaatschappen.Add(lidmaatschap);

                                }
                                else
                                {
                                    EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                    lidmaatschappen.Add(lidmaatschap);
                                }

                                beheerModel.SaveChanges();

                                if (entity.sgt_lidid != null)
                                {
                                    GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                }
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return lidmaatschappen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lidmaatschap"></param>
        /// <param name="bondsnummer"></param>
        private void EntityToLidmaatschap(sgt_alg_lidmaatschap entity, ClubCloud_Lidmaatschap lidmaatschap, string bondsnummer, ClubCloud_Setting settings = null)
        {
            if (entity.sgt_autorisatie_gezet != null)
            {
                lidmaatschap.Autorisatie = entity.sgt_autorisatie_gezet.Value;
            }
            //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;

            if (entity.sgt_lidid != null)
            {
                ClubCloud_Gebruiker gebruiker = GebruikerById(bondsnummer, entity.sgt_lidid.Value, false, settings);
                //lidmaatschap.ClubCloud_Gebruiker = gebruiker;
                lidmaatschap.GebruikerId = entity.sgt_lidid.Value;
            }

            lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

            if (entity.sgt_soort_lidmaatschapid != null)
            {
                ClubCloud_LidmaatschapSoort soort = LidmaatschapSoortById(bondsnummer, entity.sgt_soort_lidmaatschapid.Value, entity.sgt_soort_lidmaatschapid.name);
                //lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                lidmaatschap.SoortId = soort.Id;//entity.sgt_soort_lidmaatschapid.Value;
            }

            if (entity.sgt_verenigingid != null)
            {
                ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_verenigingid.Value, false, settings);
                //lidmaatschap.ClubCloud_Vereniging = vereniging;
                lidmaatschap.VerenigingId = entity.sgt_verenigingid.Value;
            }

            //entity.sgt_toernooiorganisatieid.name;
            //entity.sgt_toernooiorganisatieid.type;
            //entity.sgt_toernooiorganisatieid.Value;
            if (entity.sgt_lidmaatschap_vanaf != null)
            {
                lidmaatschap.Begin = DateTime.Parse(entity.sgt_lidmaatschap_vanaf.Value);
            }
            if (entity.sgt_lidmaatschap_beeindigd != null)
            {
                lidmaatschap.Einde = DateTime.Parse(entity.sgt_lidmaatschap_beeindigd.Value);
            }

            if (entity.sgt_datum_opgezegd != null)
            {
                lidmaatschap.Opzegging = DateTime.Parse(entity.sgt_datum_opgezegd.Value);
            }

            if (entity.sgt_nieuwe_pas_nodig != null)
            {
                lidmaatschap.PasNieuw = entity.sgt_nieuwe_pas_nodig.Value;
            }

            if (entity.sgt_pastypeid != null)
            {
                lidmaatschap.PasTypeNaam = entity.sgt_pastypeid.name;
                //lidmaatschap.PasTypeId = entity.sgt_pastypeid.type;
                lidmaatschap.PasTypeId = entity.sgt_pastypeid.Value;
            }

            if (entity.sgt_wedstrijdpas != null)
            {
                lidmaatschap.PasWedstrijd = entity.sgt_wedstrijdpas.Value;
            }

            lidmaatschap.PasVolgnummer = entity.sgt_volgnummer_pas;

            if (entity.sgt_noodpas_nodig != null)
            {
                lidmaatschap.PasNood = entity.sgt_noodpas_nodig.Value;
            }
            if (entity.sgt_datum_laatste_noodpas != null)
            {
                lidmaatschap.PasNoodDatum = DateTime.Parse(entity.sgt_datum_laatste_noodpas.Value);
            }

            if (entity.sgt_datum_laatste_pas != null)
            {
                lidmaatschap.PasDatum = DateTime.Parse(entity.sgt_datum_laatste_pas.Value);
            }

            if (entity.sgt_speelsterkte_dubbel != null)
            {
                lidmaatschap.SpeelsterkteDubbel = entity.sgt_speelsterkte_dubbel.Value;
            }
            if (entity.sgt_speelsterkte_enkel != null)
            {
                lidmaatschap.SpeelsterkteEnkel = entity.sgt_speelsterkte_enkel.Value;
            }

            lidmaatschap.Actief = entity.statuscode.name;
            lidmaatschap.Gewijzigd = DateTime.Now;

        }


        private ClubCloud_LidmaatschapSoort LidmaatschapSoortById(string bondsnummer, Guid lidmaatschapSoortId, string naam = null, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_LidmaatschapSoort lidmaatschapSoort = new ClubCloud_LidmaatschapSoort();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            lidmaatschapSoort = beheerModel.ClubCloud_LidmaatschapSoorten.Find(lidmaatschapSoortId);

            if (lidmaatschapSoort == null && naam != null)
            {
                lidmaatschapSoort = beheerModel.ClubCloud_LidmaatschapSoorten.Create();
                lidmaatschapSoort.Id = lidmaatschapSoortId;
                lidmaatschapSoort.Naam = naam;
                beheerModel.ClubCloud_LidmaatschapSoorten.Add(lidmaatschapSoort);
            }
            beheerModel.SaveChanges();
            //}
            return lidmaatschapSoort;
        }

        private List<ClubCloud_LidmaatschapSoort> LidmaatschapSoorten(string bondsnummer, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_LidmaatschapSoort> lidmaatschapSoorten = new List<ClubCloud_LidmaatschapSoort>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            lidmaatschapSoorten = beheerModel.ClubCloud_LidmaatschapSoorten.ToList();

            //}
            return lidmaatschapSoorten;
        }

        #endregion

        #region Profielen

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> SpelersProfielByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            profielen = beheerModel.ClubCloud_Profielen.Where(p => p.GebruikerId == gebruikerId).ToList();

            if (profielen == null || profielen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_naamid ", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                            foreach (sgt_dss_spelersprofiel entity in entities)
                            {
                                ClubCloud_Profiel profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_aangepast.Value));

                                if (profiel == null)
                                {
                                    profiel = beheerModel.ClubCloud_Profielen.Create();
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    profiel.Datum = DateTime.Parse(entity.sgt_datum_aangepast.Value);
                                    EntityToProfiel(entity, profiel, bondsnummer);
                                    beheerModel.ClubCloud_Profielen.Add(profiel);
                                }
                                else
                                {
                                    EntityToProfiel(entity, profiel, bondsnummer);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }

            }
            beheerModel.SaveChanges();
            //} 
            return profielen;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="profielId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Profiel SpelersProfielById(string bondsnummer, Guid profielId, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Profiel profiel = new ClubCloud_Profiel();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            profiel = beheerModel.ClubCloud_Profielen.SingleOrDefault(p => p.Id == profielId);

            if (profiel == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_spelersprofielid", Operator = ConditionOperator.Equal, Values = new object[1] { profielId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                            foreach (sgt_dss_spelersprofiel entity in entities)
                            {
                                profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_aangepast.Value));

                                if (profiel == null)
                                {
                                    profiel = beheerModel.ClubCloud_Profielen.Create();
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    profiel.Datum = DateTime.Parse(entity.sgt_datum_aangepast.Value);
                                    EntityToProfiel(entity, profiel, bondsnummer);
                                    beheerModel.ClubCloud_Profielen.Add(profiel);
                                }
                                else
                                {
                                    EntityToProfiel(entity, profiel, bondsnummer);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                beheerModel.SaveChanges();
            }
            //}
            return profiel;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="nummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> SpelersProfielByNummer(string bondsnummer, string nummer, bool refresh = false)
        {
            //CheckDatabase();

            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            profielen = beheerModel.ClubCloud_Profielen.Where(p => p.Bondsnummer == nummer).ToList();

            if (profielen == null || profielen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                            foreach (sgt_dss_spelersprofiel entity in entities)
                            {
                                ClubCloud_Profiel profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_aangepast.Value));

                                if (profiel == null)
                                {
                                    profiel = beheerModel.ClubCloud_Profielen.Create();
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    profiel.Datum = DateTime.Parse(entity.sgt_datum_aangepast.Value);
                                    EntityToProfiel(entity, profiel, bondsnummer);
                                    beheerModel.ClubCloud_Profielen.Add(profiel);
                                }
                                else
                                {
                                    EntityToProfiel(entity, profiel, bondsnummer);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return profielen;
        }

        private void EntityToProfiel(sgt_dss_spelersprofiel entity, ClubCloud_Profiel profiel, string bondsnummer)
        {
            profiel.Bondsnummer = entity.sgt_dss_bondsnummer;
            profiel.GebruikerId = entity.sgt_naamid.Value;

            if (entity.sgt_aantal_partij_resultaten_dubbel != null)
                profiel.Enkel_Aantal = entity.sgt_aantal_partij_resultaten_dubbel.Value;

            if (entity.sgt_aantal_partij_resultatenenkel != null)
                profiel.Dubbel_aantal = entity.sgt_aantal_partij_resultatenenkel.Value;

            if (entity.sgt_speelsterkte_enkel != null)
                profiel.Enkel_Speelsterkte = entity.sgt_speelsterkte_enkel.Value;

            if (entity.sgt_speelsterkte_enkel_oud != null)
                profiel.Enkel_Speelsterkte_Vorig = entity.sgt_speelsterkte_enkel_oud.Value;

            if (entity.sgt_speelsterkte_dubbel != null)
                profiel.Dubbel_Speelsterkte = entity.sgt_speelsterkte_dubbel.Value;

            if (entity.sgt_speelsterkte_dubbel_oud != null)
                profiel.Dubbel_Speelsterkte_Vorig = entity.sgt_speelsterkte_dubbel_oud.Value;

            if (entity.sgt_eindejaarsrating_enkel != null)
                profiel.Enkel_Rating_Eindejaar = entity.sgt_eindejaarsrating_enkel.Value;

            if (entity.sgt_eindejaarsrating_dubbel != null)
                profiel.Dubbel_Rating_Eindejaar = entity.sgt_eindejaarsrating_dubbel.Value;

            if (entity.sgt_rating_enkel != null)
                profiel.Enkel_Rating_Actueel = entity.sgt_rating_enkel.Value;

            if (entity.sgt_rating_dubbel != null)
                profiel.Dubbel_Rating_Actueel = entity.sgt_rating_dubbel.Value;

            profiel.Actief = entity.statuscode.name;
            profiel.Gewijzigd = DateTime.Now;

        }

        #endregion

        #region Gebruiker

        /// <summary>
        /// contact
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GebruikerById(string bondsnummer, Guid gebruikerId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            gebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruikerId);

            if (gebruiker == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "contactid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                            foreach (contact entity in entities)
                            {
                                if (settings.Id == int.Parse(entity.sgt_bondsnummer) && (settings.GebruikerId == null || settings.VerenigingId == null))
                                {
                                    ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                                    if (entity.sgt_primaire_vereniging_id != null)
                                        updatesettings.VerenigingId = entity.sgt_primaire_vereniging_id.Value;

                                    if (entity.contactid != null)
                                        updatesettings.GebruikerId = entity.contactid.Value;

                                    beheerModel.SaveChanges();
                                    settings = updatesettings;
                                }

                                gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                if (gebruiker == null)
                                {
                                    gebruiker = beheerModel.ClubCloud_Gebruikers.Create();
                                    gebruiker.Id = entity.contactid.Value;

                                    ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);


                                    beheerModel.ClubCloud_Gebruikers.Add(gebruiker);
                                    UpdateMembershipuser(gebruiker);

                                }
                                else
                                {
                                    ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);
                                    UpdateMembershipuser(gebruiker);

                                }

                                try
                                {
                                    beheerModel.SaveChanges();
                                }
                                catch { }

                                if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                {
                                    List<ClubCloud_Functionaris> functies = FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, false, settings);
                                    /*
                                    foreach (ClubCloud_Functionaris functie in functies)
                                    {
                                        gebruiker.ClubCloud_Functionaris.Add(functie);
                                    }
                                    */
                                }
                                try
                                {
                                    beheerModel.SaveChanges();
                                }
                                catch { }

                            }
                        }
                    }
                }
            }

            //TODO
            if (beheerModel.ChangeTracker.HasChanges())
            {
                UpdateMembershipuser(gebruiker);
            }

            beheerModel.SaveChanges();
            //}
            return gebruiker;
        }

        /// <summary>
        /// contact
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="nummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GebruikerByNummer(string bondsnummer, string nummer, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{
            gebruiker = beheerModel.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);

            if (gebruiker == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { "19949820" } };
                            //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                            foreach (contact entity in entities)
                            {
                                if (settings.Id == int.Parse(entity.sgt_bondsnummer) && (settings.GebruikerId == null || settings.VerenigingId == null))
                                {
                                    ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                                    if (entity.sgt_primaire_vereniging_id != null)
                                        updatesettings.VerenigingId = entity.sgt_primaire_vereniging_id.Value;

                                    if (entity.contactid != null)
                                        updatesettings.GebruikerId = entity.contactid.Value;

                                    beheerModel.SaveChanges();
                                    settings = updatesettings;
                                }


                                gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                if (gebruiker == null)
                                {
                                    gebruiker = beheerModel.ClubCloud_Gebruikers.Create();
                                    gebruiker.Id = entity.contactid.Value;

                                    ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);

                                    beheerModel.ClubCloud_Gebruikers.Add(gebruiker);
                                    UpdateMembershipuser(gebruiker);
                                }
                                else
                                {
                                    ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);
                                    UpdateMembershipuser(gebruiker);

                                }

                                try
                                {
                                    beheerModel.SaveChanges();
                                }
                                catch { }


                                if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                {
                                    List<ClubCloud_Functionaris> functies = FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                                    /*
                                    foreach (ClubCloud_Functionaris functie in functies)
                                    {
                                        gebruiker.ClubCloud_Functionaris.Add(functie);
                                    }
                                    */
                                }
                                try
                                {
                                    beheerModel.SaveChanges();
                                }
                                catch { }

                            }
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return gebruiker;
        }


        /*
        /// <summary>
        /// contact
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GebruikersByQuery(string bondsnummer, Guid verenigingId, System.Web.UI.WebControls.ParameterCollection parameters, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                var query = (from ClubCloud_Gebruiker c1 in beheerModel.ClubCloud_Gebruikers where c1. select c1).Skip(3).Take(3);

                
                //Parameter param = WhereParameters[0];
                //System.Data.SqlClient.SqlParameter sqlParam = new System.Data.SqlClient.SqlParameter();
                //sqlParam.DbType = param.DbType;
                //sqlParam.Direction = param.Direction;
                //sqlParam.IsNullable = param.ConvertEmptyStringToNull;
                //sqlParam.ParameterName = param.Name;
                //sqlParam.Value = param.DefaultValue;
                

                SqlParameter[] sqlparams = new SqlParameter[2] { new SqlParameter("@actief", "Actief"), new SqlParameter("@verenigingId", verenigingId) };
                gebruikers = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>("SELECT * FROM dbo.ClubCloud_Gebruiker WHERE Actief = @actief AND verenigingId = @verenigingId", sqlparams).ToList<ClubCloud_Gebruiker>();
            }
            return gebruikers;
        }
        */

        private List<ClubCloud_Gebruiker> Gebruikers(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            gebruikers = beheerModel.ClubCloud_Gebruikers.Where(f => f.VerenigingId == verenigingId && f.Actief.Equals("Actief", StringComparison.CurrentCultureIgnoreCase)).ToList();

            if (gebruikers != null && gebruikers.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        bool moreRecords = true;
                        int pageNum = 1;
                        while (moreRecords)
                        {
                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_primaire_vereniging_id", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                            foreach (contact entity in entities)
                            {
                                if (settings.Id == int.Parse(entity.sgt_bondsnummer) && (settings.GebruikerId == null || settings.VerenigingId == null))
                                {
                                    ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                                    if (entity.parentcustomerid != null)
                                        updatesettings.VerenigingId = entity.parentcustomerid.Value;

                                    if (entity.contactid != null)
                                        updatesettings.GebruikerId = entity.contactid.Value;

                                    beheerModel.SaveChanges();
                                    settings = updatesettings;
                                }

                                ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                if (gebruiker == null)
                                {
                                    gebruiker = beheerModel.ClubCloud_Gebruikers.Create();
                                    gebruiker.Id = entity.contactid.Value;

                                    ContactToGebruiker(entity, verenigingId, gebruiker, bondsnummer);

                                    beheerModel.ClubCloud_Gebruikers.Add(gebruiker);
                                    UpdateMembershipuser(gebruiker);
                                    gebruikers.Add(gebruiker);

                                }
                                else
                                {
                                    ContactToGebruiker(entity, verenigingId, gebruiker, bondsnummer);
                                    UpdateMembershipuser(gebruiker);
                                    gebruikers.Add(gebruiker);

                                }

                                try
                                {
                                    beheerModel.SaveChanges();
                                }
                                catch { }

                            }

                            FunctionarissenByGebruikerAsync(bondsnummer, entities);
                        }
                    }
                }
            }
            beheerModel.SaveChanges();
            //}
            return gebruikers;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="gebruiker"></param>
        /// <param name="bondsnummer"></param>
        private void ContactToGebruiker(contact entity, Guid verenigingId, ClubCloud_Gebruiker gebruiker, string bondsnummer, ClubCloud_Setting settings = null)
        {
            gebruiker.Bondsnummer = entity.sgt_bondsnummer;
            gebruiker.Beschrijving = entity.description;

            if (entity.parentcustomerid != null)
            {
                gebruiker.VerenigingId = entity.parentcustomerid.Value;
            }
            else
            {
                gebruiker.VerenigingId = verenigingId;
            }

            //gebruiker.EmailGeheim;
            gebruiker.EmailKNLTB = entity.emailaddress1;
            gebruiker.EmailWebSite = entity.emailaddress2;
            gebruiker.EmailOverig = entity.emailaddress3;

            if (entity.sgt_telefoon_geheim != null)
            {
                gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
            }

            gebruiker.TelefoonOverdag = entity.telephone1;
            gebruiker.TelefoonAvond = entity.telephone2;
            gebruiker.TelefoonOverig = entity.telephone3;
            gebruiker.Mobiel = entity.mobilephone;
            gebruiker.Fax = entity.fax;

            gebruiker.FTPsite = entity.ftpsiteurl;
            gebruiker.Website = entity.websiteurl;

            gebruiker.BankIban = entity.sgt_iban_code;
            gebruiker.BankNummer = entity.sgt_rekeningnummer;
            gebruiker.BankPlaats = entity.sgt_rekeningnummer_plaats;

            gebruiker.Roepnaam = entity.nickname;
            gebruiker.Aanhef = entity.salutation;
            gebruiker.Voornaam = entity.firstname;
            gebruiker.Voornamen = entity.sgt_voornamen;
            gebruiker.Volledigenaam = entity.fullname;
            gebruiker.Achternaam = entity.lastname;
            gebruiker.Tussenvoegsel = entity.middlename;
            gebruiker.Achtervoegsel = entity.suffix;

            //TODO
            //gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
            if (entity.birthdate != null)
            {
                gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
            }
            gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
            if (entity.sgt_datum_overleden != null)
            {
                gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
            }
            if (entity.sgt_nationaliteitid != null)
            {
                gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;
            }
            if (entity.sgt_2e_nationaliteitid != null)
            {
                gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;
            }
            gebruiker.Beroep = entity.jobtitle;

            /*
            if (entity.haschildrencode != null)
            {
                gebruiker.Kinderen = entity.haschildrencode.Value;
            }
            */

            if (entity.numberofchildren != null)
            {
                gebruiker.KinderenAantal = entity.numberofchildren.Value;
            }
            else
            {
                gebruiker.KinderenAantal = 0;
            }
            gebruiker.Partner = entity.spousesname;

            gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
            gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;

            if (!String.IsNullOrWhiteSpace(entity.sgt_fotonummer) || !String.IsNullOrEmpty(entity.sgt_fotonummer))
            {
                gebruiker.FotoId = int.Parse(entity.sgt_fotonummer);
            }

            if (entity.sgt_adres_geheim != null)
            {
                gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
            }

            AddressByIdAsync(bondsnummer, entity.address1_addressid.Value, false, settings);
            //ClubCloud_Address bezoek = AddressByIdAsync(bondsnummer, entity.address1_addressid.Value, false, settings);
            //gebruiker.ClubCloud_Address..Add(bezoek);
            AddressByIdAsync(bondsnummer, entity.address2_addressid.Value, false, settings);
            //ClubCloud_Address post = AddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
            //gebruiker.ClubCloud_Address.Add(post);

            gebruiker.Actief = entity.statuscode.name;
            gebruiker.Gewijzigd = DateTime.Now;

        }

        #endregion


        #endregion

        #region Foto

        #region Get

        private ClubCloud_Foto FotoByBondsnummer(string bondsnummer, string nummer, bool refresh = false)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{
            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);

            if (gebruiker != null)
            {
                int ibondsnummer = int.Parse(gebruiker.Bondsnummer);
                foto = beheerModel.ClubCloud_Fotos.SingleOrDefault(f => f.FotoId == gebruiker.FotoId || f.FotoId == ibondsnummer);
            }

            if ((foto == null && gebruiker != null) || refresh)
            {
                foto = RetrieveFoto(bondsnummer, gebruiker.Bondsnummer, gebruiker.FotoId);
                beheerModel.SaveChanges();
            }
            
            //}
            return foto;
        }

        private ClubCloud_Foto FotoByGebruikerId(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{
            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruikerId);

            if (gebruiker != null)
            {
                int ibondsnummer = int.Parse(gebruiker.Bondsnummer);
                foto = beheerModel.ClubCloud_Fotos.SingleOrDefault(f => f.FotoId == gebruiker.FotoId || f.FotoId == ibondsnummer);
            }

            if ((foto == null && gebruiker != null) || refresh)
            {
                foto = RetrieveFoto(bondsnummer, gebruiker.Bondsnummer, gebruiker.FotoId);
                beheerModel.SaveChanges();
            }
            //}
            return foto;
        }

        private ClubCloud_Foto RetrieveFoto(string bondsnummer, string nummer, int FotoId)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();
            ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
            {
                CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                if (cc != null)
                {
                    using (ClubCloud.KNLTB.Media.KNLTBFoto KNLTBfoto = new KNLTB.Media.KNLTBFoto())
                    {
                        Tuple<Image, string, long> result = Task.Run(async () => await KNLTBfoto.RequestFotoAsync(nummer, cc)).Result;
                        Image data = result.Item1;
                        //KNLTBfoto.RequestFoto(gebruiker.Bondsnummer, cc);
                        //Image data = KNLTBfoto.Foto;

                        foto = beheerModel.ClubCloud_Fotos.Create();
                        foto.Id = Guid.NewGuid();
                        foto.ContentType = result.Item2;
                        foto.ContentLength = result.Item3;

                        MemoryStream ms = new MemoryStream();
                        data.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        foto.ContentData = ms.ToArray();
                        foto.Gewijzigd = DateTime.Now;

                        if (FotoId > 0)
                        {
                            foto.FotoId = FotoId;
                        }
                        else
                        {
                            foto.FotoId = int.Parse(nummer);
                        }

                        beheerModel.ClubCloud_Fotos.Add(foto);
                        beheerModel.SaveChanges();
                        //pictureBox1.Image = KNLTBfoto.Foto;
                        //pictureBox1.Height = KNLTBfoto.Foto.Height;
                        //pictureBox1.Width = KNLTBfoto.Foto.Width;

                        // <asp:Image ID="Image1" runat="server" Visible = "false"/>
                        //byte[] bytes = (byte[])GetData("SELECT Data FROM tblFiles WHERE Id =" + id).Rows[0]["Data"];
                        //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        //Image1.ImageUrl = "data:image/png;base64," + base64String;
                    }
                }
            }
            return foto;
        }

        #endregion

        #region Set

        private ClubCloud_Foto SetFoto(ClubCloud_Foto foto)
        {
            ClubCloud_Foto tobeupdated = beheerModel.ClubCloud_Fotos.Find(foto.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(foto);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Fotos.Find(foto.Id);
            return tobeupdated;
        }

        #endregion

        #endregion

        #region Sponsoren

        #region Get

        public List<ClubCloud_Sponsor> GetSponsorenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh)
        {
            List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
            sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.VerenigingId == verenigingId).ToList();
            return sponsoren;
        }

        public ClubCloud_Sponsor GetSponsorById(string bondsnummer, Guid verenigingId, Guid sponsorId, bool refresh)
        {
            ClubCloud_Sponsor sponsor = new ClubCloud_Sponsor();
            sponsor = beheerModel.ClubCloud_Sponsoren.Find(sponsorId);//.Where(f => f.VerenigingId == verenigingId).ToList();
            return sponsor;
        }

        public ClubCloud_Sponsor_Afbeelding GetSponsorImageById(string bondsnummer, Guid verenigingId, Guid afbeeldingId, bool refresh)
        {
            ClubCloud_Sponsor_Afbeelding afbeelding = new ClubCloud_Sponsor_Afbeelding();
            afbeelding = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeeldingId);
            return afbeelding;
        }

        public List<ClubCloud_Sponsor> GetSponsorImageUsageById(string bondsnummer, Guid verenigingId, Guid imageId, bool refresh)
        {
            List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
            sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.AfbeeldingId == imageId).ToList();
            return sponsoren;
        }

        #endregion

        #region Set

        public ClubCloud_Sponsor SetSponsor(ClubCloud_Sponsor sponsor)
        {
            ClubCloud_Sponsor tobeupdated = beheerModel.ClubCloud_Sponsoren.Find(sponsor.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(sponsor);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Sponsoren.Find(sponsor.Id);
            return tobeupdated;
        }

        public ClubCloud_Sponsor_Afbeelding SetSponsorImage(ClubCloud_Sponsor_Afbeelding afbeelding)
        {
            ClubCloud_Sponsor_Afbeelding tobeupdated = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeelding.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(afbeelding);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeelding.Id);
            return tobeupdated;
        }

        #endregion

        #region Delete

        public bool DeleteSponsor(ClubCloud_Sponsor sponsor)
        {
            bool succes = true;
            try
            {
                bool removeimage = false;

                if (sponsor.AfbeeldingId.HasValue)
                {
                    removeimage = true;
                    List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
                    sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.AfbeeldingId == sponsor.AfbeeldingId && f.Id != sponsor.Id).ToList();
                    if (sponsoren != null && sponsoren.Count > 0)
                    {
                        removeimage = false;
                    }

                }
                ClubCloud_Sponsor toberemoved = beheerModel.ClubCloud_Sponsoren.Find(sponsor.Id);
                beheerModel.ClubCloud_Sponsoren.Remove(toberemoved);
                beheerModel.SaveChanges();

                if (removeimage)
                {
                    ClubCloud_Sponsor_Afbeelding afbeelding = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(sponsor.AfbeeldingId);
                    beheerModel.ClubCloud_Sponsor_Afbeeldingen.Remove(afbeelding);
                    beheerModel.SaveChanges();
                }
            }
            catch { succes = false; }

            return succes;

        }

        public bool DeleteSponsorImage(ClubCloud_Sponsor_Afbeelding afbeelding)
        {
            bool succes = true;
            try
            {
                bool removeimage = true;

                List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
                sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.AfbeeldingId == afbeelding.Id).ToList();
                if (sponsoren != null && sponsoren.Count > 0)
                {
                    removeimage = false;
                }

                if (removeimage)
                {
                    ClubCloud_Sponsor_Afbeelding toberemoved = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeelding.Id);
                    beheerModel.ClubCloud_Sponsor_Afbeeldingen.Remove(toberemoved);
                    beheerModel.SaveChanges();
                }
                succes = removeimage;
            }
            catch { succes = false; }

            return succes;
        }

        #endregion

        #endregion

        #region Aanmelden
        public bool CreateClubCloudWebSite(string verenigingsnummer)
        {
            bool succeed = false;

            try
            {

                ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
                if (application == null)
                {
                    throw new InvalidOperationException("Could not find the current Service Application.");
                }

                //SPDatabaseParameters databaseParameters = null;
                SqlConnectionStringBuilder builder = null;

                using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString))
                {
                    builder = new SqlConnectionStringBuilder(connection.ConnectionString);
                }
                string contentDatabase = null;
                if (builder != null)
                {
                    builder.InitialCatalog = string.Format("ClubCloudService_{0}_WebSite", verenigingsnummer);

                    /*
                        SPSecurity.RunWithElevatedPrivileges(delegate()
                        {
                            SPWebService contentservice = Microsoft.SharePoint.Administration.SPWebService.ContentService;
                            contentservice.RemoteAdministratorAccessDenied = false;
                            contentservice.Update();
                        });
                    */
                    //SPSecurity.RunWithElevatedPrivileges(delegate()
                    //{

                    //SPWebApplication webapp = SPWebApplication.Lookup(new Uri("http://websites.clubcloud.nl"));

                    //SPContentDatabase spcontentdatabase = webapp.ContentDatabases.Add(builder.DataSource, builder.InitialCatalog, null, null, 2000, 5000, 0, true);
                    /*
                    SPContentDatabase spcontentdatabase = SPContentDatabase.CreateUnattachedContentDatabase(builder);
                    */

                    //spcontentdatabase.Provision();

                    //spcontentdatabase.GrantOwnerAccessToDatabaseAccount();

                    /*
                    ClubCloudWebSiteDatabase ccDatabase = new ClubCloudWebSiteDatabase(databaseParameters);

                    ccDatabase.Provision();

                    ccDatabase.GrantApplicationPoolAccess(application.ApplicationPool.ProcessAccount.SecurityIdentifier);
                    */
                    /*
                    if (!string.IsNullOrEmpty(databaseParameters.FailoverPartner))
                    {
                        spcontentdatabase.AddFailoverServiceInstance(databaseParameters.FailoverPartner);
                    }
                    */
                    //spcontentdatabase.Update(true);
                    contentDatabase = builder.InitialCatalog;
                    //});
                    /*
                        SPSecurity.RunWithElevatedPrivileges(delegate()
                        {
                            SPWebService contentservice = Microsoft.SharePoint.Administration.SPWebService.ContentService;
                            contentservice.RemoteAdministratorAccessDenied = true;
                            contentservice.Update();
                        });
                    */

                    builder.InitialCatalog = string.Format("ClubCloudService_{0}_Data", verenigingsnummer);

                    using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(builder.ConnectionString))
                    {

                        if (beheerModel.Database.CreateIfNotExists())
                        {
                            beheerModel.Database.Initialize(true);
                        }
                    }

                    SPSecurity.RunWithElevatedPrivileges(delegate()
                    {
                        //using (SPSite eSite = new SPSite("http://websites.clubcloud.nl"))
                        //{
                        //using (SPWeb eWeb = eSite.OpenWeb())
                        //{
                        //eWeb.AllowUnsafeUpdates = true;
                        //SPWebApplication webApp = eSite.WebApplication;
                        //SPSiteCollection sites = eSite.WebApplication.Sites;
                        //var rootQuery = from SPSite site in webApp.Sites select site;
                        //SPSite rootSite = rootQuery.FirstOrDefault();
                        SPWebApplication webApp = SPWebApplication.Lookup(new Uri("http://websites.clubcloud.nl"));
                        SPContentDatabase newDatabase = null;

                        if (webApp != null)
                        {
                            bool continueValue = false;
                            if (!string.IsNullOrEmpty(contentDatabase))
                            {
                                //check if database exists
                                var query = from SPContentDatabase database in webApp.ContentDatabases
                                            where database.Name == contentDatabase
                                            select database;

                                //var config = from SPContentDatabase database in webApp.ContentDatabases
                                //             /* where database.TypeName == contentDatabase*/
                                //             select database;
                                newDatabase = query.FirstOrDefault();

                            }
                            continueValue = newDatabase == null ? false : true;

                            if (continueValue)
                            {
                                ClubCloud_Vereniging vereniging = null;
                                builder.InitialCatalog = "ClubCloudService_DB";
                                using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(builder.ConnectionString))
                                {
                                    vereniging = beheerModel.ClubCloud_Verenigingen.Add(new ClubCloud_Vereniging { Nummer = verenigingsnummer, Naam = "S.V. Kampong", Id = new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") });
                                    beheerModel.SaveChanges();

                                    //vereniging = beheerModel.ClubCloud_Verenigingen.Find(int.Parse(verenigingsnummer));
                                }

                                if (vereniging != null)
                                {

                                    string url = string.Format("http://{0}.clubcloud.nl", verenigingsnummer);
                                    SPSite createdSite = webApp.Sites.Add(url, vereniging.Naam, vereniging.Naam, 1043, "STS#1", @"12073385",
                                    "Rutger hemrika", "12073385@clubcloud.nl", null, null, null, true);
                                    //createdSite.SetUrl(new Uri("http://"++".clubcloud.n"))
                                    SPContentDatabase database = createdSite.ContentDatabase;
                                    if (database.Name != contentDatabase)
                                    {
                                        Dictionary<SPSite, string> failed = new Dictionary<SPSite, string>();

                                        database.Move(newDatabase, new List<SPSite>() { createdSite }, out failed);

                                        if (failed.Count > 0)
                                        {
                                            succeed = false;
                                        }
                                        else
                                        {
                                            succeed = true;
                                        }
                                    }
                                    else
                                    {
                                        succeed = true;
                                    }
                                }
                            }
                        }
                        //}
                        //}
                    });

                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                succeed = false;
            }

            return succeed;
        }
        #endregion
    }
}
