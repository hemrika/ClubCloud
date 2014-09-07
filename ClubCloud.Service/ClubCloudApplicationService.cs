//-----------------------------------------------------------------------
// <copyright file="HelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    //using ClubCloud.KNLTB.ServIt.CompetitieService;
    using ClubCloud.KNLTB.ServIt.CrmService;
    //using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
    using ClubCloud.Provider;
    using ClubCloud.Service.Model;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Client.Services;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// The WCF Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Runtime.InteropServices.Guid("e00d1eca-a977-4ba9-a357-5fd35dfc0f63")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    internal class ClubCloudApplicationService : ClubCloud.Service.IClubCloudApplicationService
    {
        #region Global

        private static SortedList<string, CookieContainer> containers;

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

        /// <summary>
        /// 
        /// </summary>
        public void CheckDatabaseExists()
        {
            CheckDatabase();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="catalog"></param>
        private static void CheckDatabase(string catalog = null)
        {
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString(catalog)))
            {
                model.Database.Initialize(false);
                model.Database.CreateIfNotExists();
                model.Database.CompatibleWithModel(false);
            }

            using (ClubCloud.Service.Model.MijnContainer model = new Model.MijnContainer(GetConnectionString(catalog)))
            {
                model.Database.Initialize(false);
                model.Database.CreateIfNotExists();
                model.Database.CompatibleWithModel(false);
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

            using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString))
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
                container = containers.SingleOrDefault(c => c.Key == bondsnummer).Value;

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
            pageInfo.Count = 50;
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

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                gebruiker = model.ClubCloud_Gebruikers.FirstOrDefault(g => g.Bondsnummer == working);

                if (gebruiker != null)
                {
                    settings = model.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
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

                    functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId.Value == verenigingId && f.Autorisatie == true && (f.FunctieId == new Guid("516B73DD-61B8-4B5F-BD15-78232C2D071C") || f.FunctieId == new Guid("C91FB5B2-E6CB-4B34-B9DC-BEBDFD6D35C7"))).ToList();

                    if (functionarissen != null && functionarissen.Count > 0)
                    {
                        foreach (ClubCloud_Functionaris functionaris in functionarissen)
                        {
                            gebruiker = model.ClubCloud_Gebruikers.Find(functionaris.GebruikerId.Value);

                            settings = model.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
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
            }


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
            CheckDatabase();

            ClubCloud_Setting settings = null;
            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                if (functie != null)
                {
                    functies.Add(functie);
                }
                else
                {
                    ClubCloud_Functie Ledenadministratie = model.ClubCloud_Functies.Find(new Guid("C91FB5B2-E6CB-4B34-B9DC-BEBDFD6D35C7"));
                    functies.Add(Ledenadministratie);
                    ClubCloud_Functie Gedelegeerd_Ledenadministratie = model.ClubCloud_Functies.Find(new Guid("516B73DD-61B8-4B5F-BD15-78232C2D071C"));
                    functies.Add(Gedelegeerd_Ledenadministratie);
                }

                ClubCloud_Setting usersettings = model.ClubCloud_Settings.Find(bondsnummer);

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
                        List<ClubCloud_Functionaris> functionarissen = FunctionarissenByVereniging(bondsnummer, usersettings.VerenigingId.Value,false,settings);

                        foreach (ClubCloud_Functionaris functionaris in functionarissen)
                        {
                            if (functies.Contains(functionaris.ClubCloud_Functie))
                            {
                                usersettings = model.ClubCloud_Settings.Find(functionaris.ClubCloud_Gebruiker.Bondsnummer);
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
            }
            return settings;
        }

        private ClubCloud_Setting GetSettings(string bondsnummer)
        {
            return GetSettings(int.Parse(bondsnummer));
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
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                try
                {
                    currentsettings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                }
                catch
                {

                    currentsettings = null;
                }

                if (currentsettings == null)
                {
                    currentsettings = new ClubCloud_Setting { Id = int.Parse(bondsnummer) };
                    model.ClubCloud_Settings.Add(currentsettings);
                    model.SaveChanges();
                    currentsettings.Id = int.Parse(bondsnummer);
                    model.SaveChanges();
                }
            }
            currentsettings.Password = string.Empty;

            return currentsettings;
        }

        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                currentsettings.facebook_allow = settings.facebook_allow;
                currentsettings.facebook_access_token = settings.facebook_access_token;
                currentsettings.facebook_setting = settings.facebook_setting;
                model.SaveChanges();
            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                currentsettings.financieel = settings.financieel;
                model.SaveChanges();
            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            CheckDatabase();
            GetClubCloudSettings(settings.Id);

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);

                currentsettings.Agree = settings.Agree;

                if (currentsettings.Agree && (currentsettings.Password != settings.Password))
                {
                    currentsettings.Password = settings.Password;
                }

                model.SaveChanges();

                CookieContainer cc = RequestContainer(currentsettings.Id.ToString(), currentsettings.Password);

                if (cc != null)
                {
                    ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
                    try
                    {
                        WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                        currentsettings.Access = true;
                        model.SaveChanges();

                        ClubCloud_Gebruiker gebruiker = GebruikerByNummer(currentsettings.Id.ToString(), currentsettings.Id.ToString());
                        if (gebruiker != null)
                        {
                            currentsettings.GebruikerId = gebruiker.Id;

                            if (gebruiker.VerenigingId.HasValue)
                            {
                                currentsettings.VerenigingId = gebruiker.VerenigingId.Value;
                                model.SaveChanges();

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

                model.SaveChanges();

            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                currentsettings.privacy = settings.privacy;
                model.SaveChanges();
            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                //currentsettings.mijnknltb_tracking = settings.mijnknltb_tracking;
                model.SaveChanges();
            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                currentsettings.twitter_allow = settings.twitter_allow;
                currentsettings.twitter_oauth_token = settings.twitter_oauth_token;
                currentsettings.twitter_oauth_token_secret = settings.twitter_oauth_token_secret;
                currentsettings.twitter_setting = settings.twitter_setting;
                model.SaveChanges();
            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }
        #endregion

        public ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null)
                {
                    if (settings.GebruikerId.HasValue)
                    {
                        gebruiker = model.ClubCloud_Gebruikers.Find(settings.GebruikerId.Value);
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

                if (model.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }
                model.SaveChanges();


            }
            return gebruiker;
        }

        public ClubCloud_Gebruiker GetClubCloudGebruikerByBondsnummer(string bondsnummer, string bondsnummerGebruiker, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummerGebruiker));

                if (settings != null)
                {
                    if (settings.GebruikerId.HasValue)
                    {
                        gebruiker = model.ClubCloud_Gebruikers.Find(settings.GebruikerId.Value);
                    }
                    else
                    {
                        gebruiker = null;
                    }
                }

                if (gebruiker == null || refresh)
                {
                    settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            /*
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

                            GetPersoonsgegevensResponse persoonResponse = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = bondsnummerGebruiker });
                            if (persoonResponse != null && persoonResponse.Persoonsgegevens != null)
                            {
                                Persoonsgegevens persoon = persoonResponse.Persoonsgegevens;

                                gebruiker = new ClubCloud_Gebruiker
                                {
                                    Achternaam = persoon.Achternaam,
                                    DistrictNaam = persoon.DistrictNaam,
                                    Email = persoon.Email,
                                    Geboortedatum = persoon.Geboortedatum,
                                    Geboorteplaats = persoon.Geboorteplaats,
                                    Gemeente = persoon.Gemeente,
                                    Geslacht = persoon.Geslacht,
                                    Huisnummer = persoon.Huisnummer,
                                    Id = persoon.Id,
                                    IsLid = persoon.IsLid,
                                    Mobiel = persoon.Mobiel,
                                    NationaliteitId = persoon.NationaliteitId,
                                    OrganisatieNummer = persoon.OrganisatieNummer,
                                    Plaats = persoon.Plaats,
                                    Postcode = persoon.Postcode,
                                    RatingDubbel = persoon.RatingDubbel,
                                    RatingEnkel = persoon.RatingEnkel,
                                    Roepnaam = persoon.Roepnaam,
                                    SpeelsterkteDubbel = persoon.SpeelsterkteDubbel,
                                    SpeelsterkteEnkel = persoon.SpeelsterkteEnkel,
                                    Straat = persoon.Straat,
                                    TelefoonAvond = persoon.TelefoonAvond,
                                    TelefoonOverdag = persoon.TelefoonOverdag,
                                    Toevoeging = persoon.Toevoeging,
                                    Tussenvoegsel = persoon.Tussenvoegsel,
                                    VolledigeNaam = persoon.VolledigeNaam,
                                    Voorletters = persoon.Voorletters,
                                    Voornamen = persoon.Voornamen
                                };

                                model.ClubCloud_Gebruikers.Add(gebruiker);

                            }
                            */
                        }

                    }

                }

                model.SaveChanges();

                if (model.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }




            }
            return gebruiker;
        }

        public bool SetClubCloudGebruiker(string bondsnummer, ClubCloud_Gebruiker gebruiker, bool refresh)
        {
            try
            {
                CheckDatabase();

                ClubCloud_Gebruiker currentgebruiker = new ClubCloud_Gebruiker();

                using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                {
                    ClubCloud_Setting settings = GetSettings(bondsnummer);
                    currentgebruiker = model.ClubCloud_Gebruikers.Find(gebruiker.Id);

                    /*
					if (settings != null && currentgebruiker != null)
					{
						if (settings.GebruikerId.HasValue)
						{
							currentgebruiker = model.ClubCloud_Gebruikers.Find(gebruiker.Id);
							currentgebruiker.Achternaam = gebruiker.Achternaam;
							currentgebruiker.Email = gebruiker.Email;
							currentgebruiker.Geboortedatum = gebruiker.Geboortedatum;
							currentgebruiker.Geboorteplaats = gebruiker.Geboorteplaats;
							currentgebruiker.Gemeente = gebruiker.Gemeente;
							currentgebruiker.Geslacht = gebruiker.Geslacht;
							currentgebruiker.Huisnummer = gebruiker.Huisnummer;
							currentgebruiker.Mobiel = gebruiker.Mobiel;
							currentgebruiker.Plaats = gebruiker.Plaats;
							currentgebruiker.Postcode = gebruiker.Postcode;
							currentgebruiker.Roepnaam = gebruiker.Roepnaam;
							currentgebruiker.Straat = gebruiker.Straat;
							currentgebruiker.TelefoonAvond = gebruiker.TelefoonAvond;
							currentgebruiker.TelefoonOverdag = gebruiker.TelefoonOverdag;
							currentgebruiker.Toevoeging = gebruiker.Toevoeging;
							currentgebruiker.Tussenvoegsel = gebruiker.Tussenvoegsel;
							currentgebruiker.Voorletters = gebruiker.Voorletters;
							currentgebruiker.Voornamen = gebruiker.Voornamen;
							currentgebruiker.VolledigeNaam = string.Format("{0} {1}, {2}", gebruiker.Tussenvoegsel, gebruiker.Achternaam, gebruiker.Voorletters);
						}
						else
						{
							gebruiker.VolledigeNaam = string.Format("{0} {1}, {2}", gebruiker.Tussenvoegsel, gebruiker.Achternaam, gebruiker.Voorletters);
							model.ClubCloud_Gebruikers.Add(gebruiker);
						}
                          
					}
                    */
                    if (model.ChangeTracker.HasChanges())
                    {
                        UpdateMembershipuser(gebruiker);
                    }

                    model.SaveChanges();
                }
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

        public ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            gebruiker = GebruikerById(bondsnummer, gebruikerId, refresh);
            return gebruiker;
        }

        public ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            foto = FotoByGebruikerId(bondsnummer, gebruikerId, refresh);
            return foto;
        }

        #region Membership

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

        private bool UpdateMembershipuser(ClubCloud_Gebruiker gebruiker)
        {
            try
            {
                using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                {

                    ClubCloud_Setting updatesettings = model.ClubCloud_Settings.SingleOrDefault(g => g.GebruikerId == gebruiker.Id);
                    if (updatesettings != null)// && updatesettings.Id != null)
                    {
                        ZimbraMembershipUser zuser = Provider.GetZimbraUser(updatesettings.Id.ToString(), true);
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
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        /*
		public SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();

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
			CheckDatabase();

			ClubCloud_Tracking spelertracking = new ClubCloud_Tracking();// { Id = int.Parse(bondsnummer) };

			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = GetSettings(bondsnummer);

				if (settings != null && settings.mijnknltb_tracking)
				{
					spelertracking = model.ClubCloud_TrackingSet.SingleOrDefault(p => p.Id == settings.GebruikerId);

					if (spelertracking == null && settings.mijnknltb_tracking)
					{
						spelertracking = model.ClubCloud_TrackingSet.Create();
						spelertracking.Id = settings.GebruikerId.Value;
						model.ClubCloud_TrackingSet.Add(spelertracking);
						model.SaveChanges();
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
				model.SaveChanges();
			}
			return spelertracking;
		}
        */

        /*
		public List<ClubCloud_Gebruiker_Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();

			List<ClubCloud_Gebruiker_Vereniging> verenigingen = new List<ClubCloud_Gebruiker_Vereniging>();

			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = GetSettings(bondsnummer);

				if (settings != null && settings.GebruikerId.HasValue)
				{
					verenigingen = model.ClubCloud_Gebruiker_Verenigingen.Where(gv => gv.Id == settings.GebruikerId.Value).ToList<ClubCloud_Gebruiker_Vereniging>();

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
											model.ClubCloud_Gebruiker_Verenigingen.Add(gebruiker_vereniging);
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
				model.SaveChanges();
			}

			return verenigingen;
		}
        */

        /*
		//public List<ClubCloud_Abbonnement> GetAbonnementen(Guid persoonsId, bool refresh = false)
		public List<ClubCloud_Gebruiker_Abonement> GetAbonnementen(string bondsnummer, Guid persoonsId, bool refresh = false)
		{
			CheckDatabase();

			List<ClubCloud_Gebruiker_Abonement> abonnementen = new List<ClubCloud_Gebruiker_Abonement>();

			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = GetSettings(bondsnummer);

				if (settings != null)
				{
					abonnementen = model.ClubCloud_Gebruiker_Abonementen.Where(gv => gv.Id == settings.GebruikerId.Value).ToList<ClubCloud_Gebruiker_Abonement>();

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

				model.SaveChanges();
			}

			return abonnementen;
		}
        */

        /*
		public List<ClubCloud_District> GetDistricten(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();
			List<ClubCloud_District> districten = new List<ClubCloud_District>();
			using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			{
				districten = model.ClubCloud_Districten.Where(d => d.Id != null).ToList();

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
									ClubCloud_District cdistrict = model.ClubCloud_Districten.SingleOrDefault(d => d.Id == district.Id);

									if(cdistrict == null)
									{
										cdistrict = model.ClubCloud_Districten.Create();
										cdistrict.Id = district.Id;
										cdistrict.DistrictNaam = district.DistrictNaam;
										model.ClubCloud_Districten.Add(cdistrict);
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
				model.SaveChanges();
			}
			
				return districten;
		}
        */

        #endregion

        #region Club
        
        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            

            vereniging = VerenigingById(bondsnummer, verenigingId, refresh);

            return vereniging;
        }
        
        /*
        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.FirstOrDefault(v => v.Nummer == vereniginsnummer);
                //vereniging = model.ClubCloud_Verenigingen.Select<ClubCloud_Vereniging, ClubCloud_Vereniging>(v => v.Verenigingsnummer == vereniginsnummer).First<ClubCloud_Vereniging>();

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
            CheckDatabase();

            ClubCloud_Vereniging vereniging = null;

            string LatitudeCI = Latitude.ToString(CultureInfo.InvariantCulture);
            //double LatitudeCI = double.Parse(Latitude, CultureInfo.InvariantCulture);
            string LongitudeCI = Longitude.ToString(CultureInfo.InvariantCulture);
            //double LongitudeCI = double.Parse(Longitude, CultureInfo.InvariantCulture);

            string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);
            // 4326 is most common coordinate system used by GPS/Maps
            DbGeography Location = DbGeography.PointFromText(PointInText, 4326);

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Address address = (from u in model.ClubCloud_Addresses where u.GeoLocation != null
                                  orderby u.GeoLocation.Distance(Location)
                                  select u).FirstOrDefault(); 
                //address = model.ClubCloud_Addresses.FirstOrDefault(a => a.GeoLocation.Distance(Location) < 99999.0);

                if(address != null && address.ParentId.Value != null)
                {
                    ValidateBondsnummer(ref bondsnummer, address.ParentId.Value);
                    vereniging = VerenigingById(bondsnummer, address.ParentId.Value, refresh);
                }
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
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            List<ClubCloud_Baan> banen = BanenByVerenigingId(bondsnummer, verenigingId, refresh);

            if(banen != null && banen.Count > 0 || refresh)
            {
                using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                {

                    foreach (ClubCloud_Baan baan in banen)
                    {
                         List<ClubCloud_Baanschema> schemaperbaan = model.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id).ToList();
                         baanschema.AddRange(schemaperbaan);
                    }
                }
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
                using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                {

                    foreach (ClubCloud_Baan baan in banen)
                    {
                        List<ClubCloud_Baanschema> schemaperbaan = model.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id).ToList();
                        baanschema.AddRange(schemaperbaan);
                    }
                }
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

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Reservering reservering  = model.ClubCloud_Reserveringen.Find(reserveringId);

                if(reservering != null || refresh)
                {
                    ValidateBondsnummer(ref bondsnummer, verenigingId);
                    if(reservering.Gebruiker_Een != null && reservering.Gebruiker_Een.HasValue)
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
            }

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

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                List<ClubCloud_Baan> banen = model.ClubCloud_Banen.Where(b => b.AccomodatieId.Value == vereniging.AccomodatieId.Value).ToList();

                foreach (ClubCloud_Baan baan in banen)
                {
                    List<ClubCloud_Reservering> baanreserveringen = model.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baan.Id && r.Datum.Date == DateTime.Now.Date && r.Tijd.Hours >= DateTime.Now.Hour ).ToList();
                    reserveringen.AddRange(baanreserveringen);
                }
            }

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

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                reserveringen = model.ClubCloud_Reserveringen.Where(r => r.Gebruiker_Een.Value == gebruiker.Id || r.Gebruiker_Twee.Value == gebruiker.Id || r.Gebruiker_Drie.Value == gebruiker.Id || r.Gebruiker_Vier.Value == gebruiker.Id).ToList();
            }

            return reserveringen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="reserveringId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid reserveringId, bool refresh = false)
        {
            ClubCloud_Reservering reservering = null;

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                reservering = model.ClubCloud_Reserveringen.Find(reserveringId);
            }

            return reservering;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid baanId, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                reserveringen = model.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baanId && r.Datum.Date == DateTime.Now.Date && r.Tijd.Hours >= DateTime.Now.Hour).ToList();
            }

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
        public ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime tijd, bool final = false, bool push = false)
        {
            ClubCloud_Reservering reservering = new ClubCloud_Reservering();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Afhang afhangen = model.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId.Value == verenigingId);

                reservering = model.ClubCloud_Reserveringen.Create();
                reservering.Id = Guid.NewGuid();
                reservering.BaanId = baanId;
                reservering.Datum = tijd.Date;
                reservering.Tijd = tijd.TimeOfDay;
                reservering.Final = final;
                
                foreach (Guid gebruiker in gebruikers)
                {
                    if(!reservering.Gebruiker_Een.HasValue)
                    {
                        reservering.Gebruiker_Een = gebruiker;
                        reservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Een);
                        continue;
                    }

                    if (!reservering.Gebruiker_Twee.HasValue)
                    {
                        reservering.Gebruiker_Twee = gebruiker;
                        reservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Twee);
                        continue;
                    }

                    if (!reservering.Gebruiker_Drie.HasValue)
                    {
                        reservering.Gebruiker_Drie = gebruiker;
                        reservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Drie);
                        continue;
                    }

                    if (!reservering.Gebruiker_Vier.HasValue)
                    {
                        reservering.Gebruiker_Vier = gebruiker;
                        reservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Vier);
                        continue;
                    }
                }
                model.SaveChanges();
            }

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
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Afhang afhangen = model.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId.Value ==  verenigingId);

                ClubCloud_Reservering Ureservering = model.ClubCloud_Reserveringen.Find(reservering.Id);

                if (Ureservering != null)
                {

                    Ureservering.BaanId = reservering.BaanId;
                    Ureservering.Datum = reservering.Datum.Date;
                    Ureservering.Tijd = reservering.Tijd;
                    Ureservering.Final = final;

                    if (!reservering.Gebruiker_Een.HasValue)
                    {
                        Ureservering.Gebruiker_Een = reservering.Gebruiker_Een;
                        Ureservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Een);
                    }

                    if (!reservering.Gebruiker_Twee.HasValue)
                    {
                        Ureservering.Gebruiker_Twee = reservering.Gebruiker_Twee;
                        Ureservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Twee);
                    }

                    if (!reservering.Gebruiker_Drie.HasValue)
                    {
                        Ureservering.Gebruiker_Drie = reservering.Gebruiker_Drie;
                        Ureservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Drie);
                    }

                    if (!reservering.Gebruiker_Vier.HasValue)
                    {
                        Ureservering.Gebruiker_Vier = reservering.Gebruiker_Vier;
                        Ureservering.Duur = TimeSpan.FromMinutes(afhangen.Duur_Vier);
                    }
                }
                model.SaveChanges();
            }

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
                using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                {
                    ClubCloud_Reservering reservering = model.ClubCloud_Reserveringen.Find(reserveringId);
                    model.ClubCloud_Reserveringen.Remove(reservering);
                    model.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Beheer

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

            CheckDatabase();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                nationaliteiten = model.ClubCloud_Nationaliteiten.Where(n => n.Naam != string.Empty).ToList<ClubCloud_Nationaliteit>();

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
                                    ClubCloud_Nationaliteit nationaliteit = model.ClubCloud_Nationaliteiten.Find(entity.sgt_alg_nationaliteitid.Value);

                                    if (nationaliteit == null)
                                    {
                                        nationaliteit = model.ClubCloud_Nationaliteiten.Create();
                                        nationaliteit.Id = entity.sgt_alg_nationaliteitid.Value;
                                        nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                        nationaliteit.Code = entity.sgt_verkorte_code;
                                        model.ClubCloud_Nationaliteiten.Add(nationaliteit);
                                        nationaliteiten.Add(nationaliteit);
                                    }
                                    else
                                    {
                                        nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                        nationaliteit.Code = entity.sgt_verkorte_code;
                                        nationaliteiten.Add(nationaliteit);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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

            CheckDatabase();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                nationaliteit = model.ClubCloud_Nationaliteiten.Find(nationaliteitId);

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
                                    nationaliteit = model.ClubCloud_Nationaliteiten.Find(entity.sgt_alg_nationaliteitid.Value);

                                    if (nationaliteit == null)
                                    {
                                        nationaliteit = model.ClubCloud_Nationaliteiten.Create();
                                        nationaliteit.Id = entity.sgt_alg_nationaliteitid.Value;
                                        nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                        nationaliteit.Code = entity.sgt_verkorte_code;
                                        model.ClubCloud_Nationaliteiten.Add(nationaliteit);
                                    }
                                    else
                                    {
                                        nationaliteit.Naam = entity.sgt_alg_nationaliteit1;
                                        nationaliteit.Code = entity.sgt_verkorte_code;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            ClubCloud_District district = new ClubCloud_District();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                district = model.ClubCloud_Districten.Find(districtId);

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
                                    district = model.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (district == null)
                                    {
                                        district = model.ClubCloud_Districten.Create();
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
                                        model.ClubCloud_Districten.Add(district);

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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            ClubCloud_District district = new ClubCloud_District();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                district = model.ClubCloud_Districten.SingleOrDefault(d => d.RegioId == regioId);

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
                                    district = model.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (district == null)
                                    {
                                        district = model.ClubCloud_Districten.Create();
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
                                        model.ClubCloud_Districten.Add(district);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            List<ClubCloud_District> districten = new List<ClubCloud_District>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                districten = model.ClubCloud_Districten.ToList();

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
                                    ClubCloud_District district = model.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (district == null)
                                    {
                                        district = model.ClubCloud_Districten.Create();
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
                                        model.ClubCloud_Districten.Add(district);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return districten;
            //sgt_alg_functie
        }
        #endregion

        #region Regio

        private ClubCloud_Regio RegioById(string bondsnummer, Guid regioId, string naam = null, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Regio regio = new ClubCloud_Regio();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                regio = model.ClubCloud_Regios.Find(regioId);

                if (regio == null && naam != null)
                {
                    regio = model.ClubCloud_Regios.Create();
                    regio.Id = regioId;
                    regio.Naam = naam;
                    model.ClubCloud_Regios.Add(regio);
                }
                model.SaveChanges();
            }
            return regio;
        }

        private List<ClubCloud_Regio> Regios(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Regio> regios = new List<ClubCloud_Regio>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                regios = model.ClubCloud_Regios.ToList();

            }
            return regios;
        }

        #endregion

        #region Rechtsvorm

        private ClubCloud_Rechtsvorm RechtsvormById(string bondsnummer, Guid rechtsvormId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            CheckDatabase();

            ClubCloud_Rechtsvorm rechtsvorm = new ClubCloud_Rechtsvorm();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                rechtsvorm = model.ClubCloud_Rechtsvormen.Find(rechtsvormId);

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
                                    rechtsvorm = model.ClubCloud_Rechtsvormen.Find(entity.sgt_alg_rechtsvormid.Value);

                                    if (rechtsvorm == null)
                                    {
                                        rechtsvorm = model.ClubCloud_Rechtsvormen.Create();
                                        rechtsvorm.Id = entity.sgt_alg_rechtsvormid.Value;
                                        rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                        rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                        rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                        rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                        rechtsvorm.Code = entity.sgt_verkorte_code;
                                        rechtsvorm.Actief = entity.statuscode.name;
                                        model.ClubCloud_Rechtsvormen.Add(rechtsvorm);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return rechtsvorm;
            //sgt_alg_functie
        }

        private List<ClubCloud_Rechtsvorm> Rechtsvormen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            CheckDatabase();

            List<ClubCloud_Rechtsvorm> rechtsvormen = new List<ClubCloud_Rechtsvorm>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                rechtsvormen = model.ClubCloud_Rechtsvormen.ToList();

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
                                    ClubCloud_Rechtsvorm rechtsvorm = model.ClubCloud_Rechtsvormen.Find(entity.sgt_alg_rechtsvormid.Value);

                                    if (rechtsvorm == null)
                                    {
                                        rechtsvorm = model.ClubCloud_Rechtsvormen.Create();
                                        rechtsvorm.Id = entity.sgt_alg_rechtsvormid.Value;
                                        rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                        rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                        rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                        rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                        rechtsvorm.Code = entity.sgt_verkorte_code;
                                        rechtsvorm.Actief = entity.statuscode.name;
                                        model.ClubCloud_Rechtsvormen.Add(rechtsvorm);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();


            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.Find(verenigingId);

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
                                    vereniging = model.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                    vereniging = model.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                    if (vereniging == null)
                                    {
                                        vereniging = model.ClubCloud_Verenigingen.Create();
                                        vereniging.Id = entity.accountid.Value;

                                        entityToVereniging(entity, vereniging, bondsnummer,settings);

                                        model.ClubCloud_Verenigingen.Add(vereniging);

                                    }
                                    else
                                    {
                                        entityToVereniging(entity, vereniging, bondsnummer,settings);

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

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
            CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();


            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.SingleOrDefault(l => l.Nummer == verenigingNummer);

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
                                    vereniging = model.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                    if (vereniging == null)
                                    {
                                        vereniging = model.ClubCloud_Verenigingen.Create();
                                        vereniging.Id = entity.accountid.Value;

                                        entityToVereniging(entity, vereniging, bondsnummer,settings);

                                        model.ClubCloud_Verenigingen.Add(vereniging);

                                    }
                                    else
                                    {
                                        entityToVereniging(entity, vereniging, bondsnummer,settings);

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return vereniging;
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
                ClubCloud_District district = DistrictById(bondsnummer, entity.sgt_districtid.Value,false, settings);
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
                ClubCloud_Rechtsvorm recht = RechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value,false, settings);
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
                ClubCloud_Address bezoek = AdresById(bondsnummer, entity.address1_addressid.Value, false, settings);
                //vereniging.ClubCloud_Address.Add(bezoek);
            }
            if (entity.address2_addressid != null)
            {
                ClubCloud_Address post = AdresById(bondsnummer, entity.address2_addressid.Value, false,settings);
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

        }

        #endregion

        #region Adres

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="addressId"></param>
        /// <param name="refresh"></param>
        /// <returns>ClubCloud_Address</returns>
        private ClubCloud_Address AdresById(string bondsnummer, Guid addressId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            CheckDatabase();

            ClubCloud_Address address = new ClubCloud_Address();


            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                address = model.ClubCloud_Addresses.Find(addressId);

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
                                    address = model.ClubCloud_Addresses.Find(entity.customeraddressid.Value);

                                    if (address == null)
                                    {
                                        address = model.ClubCloud_Addresses.Create();
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
                                        model.ClubCloud_Addresses.Add(address);
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
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return address;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="parentId"></param>
        /// <param name="refresh"></param>
        /// <returns>List<ClubCloud_Address></returns>
        private List<ClubCloud_Address> AdresByParent(string bondsnummer, Guid parentId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            CheckDatabase();

            List<ClubCloud_Address> addresses = new List<ClubCloud_Address>();


            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                addresses = model.ClubCloud_Addresses.Where(a => a.ParentId == parentId).ToList();

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
                                    ClubCloud_Address address = model.ClubCloud_Addresses.Find(entity.customeraddressid.Value);

                                    if (addresses == null)
                                    {
                                        address = model.ClubCloud_Addresses.Create();
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
                                        model.ClubCloud_Addresses.Add(address);
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
                                        addresses.Add(address);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

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
            CheckDatabase();

            ClubCloud_Functie functie = new ClubCloud_Functie();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                functie = model.ClubCloud_Functies.Find(functieId);

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
                                    functie = model.ClubCloud_Functies.Find(entity.sgt_alg_functieid.Value);

                                    if (functie == null)
                                    {
                                        functie = model.ClubCloud_Functies.Create();
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
                                        model.ClubCloud_Functies.Add(functie);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return functie;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        private List<ClubCloud_Functie> Functies(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            CheckDatabase();

            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                functies = model.ClubCloud_Functies.ToList();
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
                                    ClubCloud_Functie functie = model.ClubCloud_Functies.Find(entity.sgt_alg_functieid.Value);

                                    if (functie == null)
                                    {
                                        functie = model.ClubCloud_Functies.Create();
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
                                        model.ClubCloud_Functies.Add(functie);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
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


                    model.ClubCloud_Functionarissen.Add(functionaris);
                }
            }

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
        private List<ClubCloud_Functionaris> FunctionarissenByFunctie(string bondsnummer, Guid VerenigingId, Guid FunctieId, bool refresh = false,ClubCloud_Setting settings = null)
        {
            CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.FunctieId == FunctieId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

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
                                    ClubCloud_Functionaris functionaris = model.ClubCloud_Functionarissen.SingleOrDefault(f => f.Id == entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = model.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;
                                        EntityToFunctionaris(entity, functionaris, bondsnummer);


                                        model.ClubCloud_Functionarissen.Add(functionaris);
                                        functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        EntityToFunctionaris(entity, functionaris, bondsnummer);
                                        functionarissen.Add(functionaris);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            return FunctionarissenByGebruiker(int.Parse(bondsnummer), gebruikerId, refresh,settings);
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
            CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

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

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum);

                                foreach (sgt_alg_functionaris entity in entities)
                                {
                                    ClubCloud_Functionaris functionaris = model.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = model.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;

                                        EntityToFunctionaris(entity, functionaris, bondsnummer,settings);

                                        model.ClubCloud_Functionarissen.Add(functionaris);
                                        functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        EntityToFunctionaris(entity, functionaris, bondsnummer,settings);
                                        functionarissen.Add(functionaris);

                                    }
                                }
                            }
                        }
                    }
                    model.SaveChanges();
                    //functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList();
                }
                model.SaveChanges();
            }
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
            CheckDatabase();
            ClubCloud_Functionaris updatable = functionaris;

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                updatable = model.ClubCloud_Functionarissen.Find(functionaris.Id);
                updatable.TermijnBegin = functionaris.TermijnBegin;
                updatable.TermijnEinde = functionaris.TermijnEinde;


                if (model.ChangeTracker.HasChanges())
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

                    model.SaveChanges();
                    updatable = model.ClubCloud_Functionarissen.Find(functionaris.Id);
                }
            }

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
                ClubCloud_Functie functie = FunctieById(bondsnummer, entity.sgt_functieid.Value,false,settings);
                //functionaris.ClubCloud_Functie = functie;
                functionaris.FunctieId = entity.sgt_functieid.Value;
            }

            if (entity.sgt_functionarisid != null)
            {
                ClubCloud_Gebruiker gebruiker = GebruikerById(bondsnummer, entity.sgt_functionarisid.Value,false,settings);
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
            CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                functionarissen = model.ClubCloud_Functionarissen.Where(f => f.GebruikerId == gebruikerId).ToList();// && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

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
                                    ClubCloud_Functionaris functionaris = model.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = model.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;

                                        EntityToFunctionaris(entity, functionaris, bondsnummer.ToString(),settings);

                                        model.ClubCloud_Functionarissen.Add(functionaris);
                                        functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        EntityToFunctionaris(entity, functionaris, bondsnummer.ToString(),settings);
                                        functionarissen.Add(functionaris);
                                    }
                                }
                            }
                        }
                    }
                    model.SaveChanges();
                    //functionarissen = model.ClubCloud_Functionarissen.Where(f => f.GebruikerId == gebruikerId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            ClubCloud_Bestuursorgaan bestuursorgaan = new ClubCloud_Bestuursorgaan();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(bestuursorgaanId);

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
                                    bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan == null)
                                    {
                                        bestuursorgaan = model.ClubCloud_Bestuursorganen.Create();
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
                                        model.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                bestuursorganen = model.ClubCloud_Bestuursorganen.Where(b => b.VerenigingId == verenigingId).ToList();

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
                                    ClubCloud_Bestuursorgaan bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan == null)
                                    {
                                        bestuursorgaan = model.ClubCloud_Bestuursorganen.Create();
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
                                        model.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                bestuursorganen = model.ClubCloud_Bestuursorganen.ToList();

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
                                    ClubCloud_Bestuursorgaan bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan == null)
                                    {
                                        bestuursorgaan = model.ClubCloud_Bestuursorganen.Create();
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
                                        model.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, verenigingId, refresh);

                if (vereniging != null)
                {
                    banen = model.ClubCloud_Banen.Where(b => b.AccomodatieId.Value == vereniging.AccomodatieId.Value).ToList();
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
                                            ClubCloud_Baan baan = model.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Buiten);

                                            if (baan == null)
                                            {
                                                baan = model.ClubCloud_Banen.Create();
                                                baan.Id = Guid.NewGuid();
                                                baan.AccomodatieId = accommodatie.Id;
                                                baan.Naam = "Baan " + i.ToString() + " (Buiten)";
                                                baan.Baansoort = BaanSoort.Buiten;
                                                baan.Nummer = i;
                                                model.ClubCloud_Banen.Add(baan);

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
                                            ClubCloud_Baan baan = model.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Binnen);

                                            if (baan == null)
                                            {
                                                baan = model.ClubCloud_Banen.Create();
                                                baan.Id = Guid.NewGuid();
                                                baan.AccomodatieId = accommodatie.Id;
                                                baan.Naam = "Baan " + i.ToString() + " (Binnen)";
                                                baan.Baansoort = BaanSoort.Binnen;
                                                baan.Nummer = i;
                                                model.ClubCloud_Banen.Add(baan);

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
                                            ClubCloud_Baan baan = model.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Blaashal);

                                            if (baan == null)
                                            {
                                                baan = model.ClubCloud_Banen.Create();
                                                baan.Id = Guid.NewGuid();
                                                baan.AccomodatieId = accommodatie.Id;
                                                baan.Naam = "Baan " + i.ToString() + " (Blaashal)";
                                                baan.Baansoort = BaanSoort.Blaashal;
                                                baan.Nummer = i;
                                                model.ClubCloud_Banen.Add(baan);

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
                                }
                            }

                        }
                    }
                }
                model.SaveChanges();
            }

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
            CheckDatabase();

            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                banen = model.ClubCloud_Banen.Where(b => b.AccomodatieId.Value == accommodatieid).ToList();

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
                                            ClubCloud_Baan baan = model.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Buiten);

                                            if (baan == null)
                                            {
                                                baan = model.ClubCloud_Banen.Create();
                                                baan.Id = Guid.NewGuid();
                                                baan.AccomodatieId = accommodatie.Id;
                                                baan.Naam = "Baan " + i.ToString() + " (Buiten)";
                                                baan.Baansoort = BaanSoort.Buiten;
                                                baan.Nummer = i;
                                                model.ClubCloud_Banen.Add(baan);

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
                                            ClubCloud_Baan baan = model.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Binnen);

                                            if (baan == null)
                                            {
                                                baan = model.ClubCloud_Banen.Create();
                                                baan.Id = Guid.NewGuid();
                                                baan.AccomodatieId = accommodatie.Id;
                                                baan.Naam = "Baan " + i.ToString() + " (Binnen)";
                                                baan.Baansoort = BaanSoort.Binnen;
                                                baan.Nummer = i;
                                                model.ClubCloud_Banen.Add(baan);

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
                                            ClubCloud_Baan baan = model.ClubCloud_Banen.FirstOrDefault(b => b.Nummer == i && b.Baansoort == BaanSoort.Blaashal);

                                            if (baan == null)
                                            {
                                                baan = model.ClubCloud_Banen.Create();
                                                baan.Id = Guid.NewGuid();
                                                baan.AccomodatieId = accommodatie.Id;
                                                baan.Naam = "Baan " + i.ToString() + " (Blaashal)";
                                                baan.Baansoort = BaanSoort.Blaashal;
                                                baan.Nummer = i;
                                                model.ClubCloud_Banen.Add(baan);

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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return banen;
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
            CheckDatabase();

            ClubCloud_Baansoort baansoort = new ClubCloud_Baansoort();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                baansoort = model.ClubCloud_Baansoorten.Find(baansoortId);

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
                                    baansoort = model.ClubCloud_Baansoorten.Find(entity.sgt_alg_baansoortid.Value);

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

                                        model.ClubCloud_Baansoorten.Add(baansoort);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

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
            CheckDatabase();

            List<ClubCloud_Baansoort> baansoorten = new List<ClubCloud_Baansoort>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                baansoorten = model.ClubCloud_Baansoorten.ToList();

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
                                    ClubCloud_Baansoort baansoort = model.ClubCloud_Baansoorten.Find(entity.sgt_alg_baansoortid.Value);

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

                                        model.ClubCloud_Baansoorten.Add(baansoort);
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
                                            BaantypeById(bondsnummer, entity.sgt_baantypeid.Value, entity.sgt_baantypeid.name,false);
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
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

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
            CheckDatabase();

            ClubCloud_Baantype baantype = new ClubCloud_Baantype();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                baantype = model.ClubCloud_Baantypes.Find(baantypeId);

                if (baantype == null && naam != null)
                {
                    baantype = model.ClubCloud_Baantypes.Create();
                    baantype.Id = baantypeId;
                    baantype.Naam = naam;
                    model.ClubCloud_Baantypes.Add(baantype);
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            List<ClubCloud_Baantype> baantypes = new List<ClubCloud_Baantype>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                baantypes = model.ClubCloud_Baantypes.ToList();

            }
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
            CheckDatabase();

            ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                accomodatie = model.ClubCloud_Accomodaties.Find(accomodatieId);

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
                                    accomodatie = model.ClubCloud_Accomodaties.Find(entity.sgt_alg_accommodatieid.Value);

                                    if (accomodatie == null)
                                    {
                                        accomodatie = model.ClubCloud_Accomodaties.Create();
                                        accomodatie.Id = entity.sgt_alg_accommodatieid.Value;
                                        EntityToAccomodatie(entity, accomodatie, model, bondsnummer, settings);
                                        model.ClubCloud_Accomodaties.Add(accomodatie);
                                    }
                                    else
                                    {
                                        EntityToAccomodatie(entity, accomodatie, model, bondsnummer,settings);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return accomodatie;
        }

        /// <summary>
        /// sgt_alg_accommodatie
        /// </summary>
        private ClubCloud_Accomodatie AccommodatieByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            CheckDatabase();

            ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                Guid accomodatieId = model.ClubCloud_Verenigingen.Find(verenigingId).AccomodatieId.Value;
                accomodatie = model.ClubCloud_Accomodaties.Find(accomodatieId);

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
                                    accomodatie = model.ClubCloud_Accomodaties.Find(entity.sgt_alg_accommodatieid.Value);

                                    if (accomodatie == null)
                                    {
                                        accomodatie = model.ClubCloud_Accomodaties.Create();
                                        accomodatie.Id = entity.sgt_alg_accommodatieid.Value;
                                        EntityToAccomodatie(entity, accomodatie, model, bondsnummer, settings);
                                        model.ClubCloud_Accomodaties.Add(accomodatie);
                                    }
                                    else
                                    {
                                        EntityToAccomodatie(entity, accomodatie, model, bondsnummer, settings);
                                    }
                                }
                            }
                        }
                    }
                }

                model.SaveChanges();
            }
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

            /*
            accomodatie.RolStoeltoegankelijk = entity.statuscode.name;            
            accomodatie.Speeltoestellen = entity.statuscode.name;
            accomodatie.Actief = entity.statuscode.name;
            */

            if (entity.sgt_alg_accommodatieid.Value != null)
            {
                List<ClubCloud_Address> addressen = AdresByParent(bondsnummer, entity.sgt_alg_accommodatieid.Value, false, settings);

                if (addressen.Count > 0)
                {
                    foreach (ClubCloud_Address addr in addressen)
                    {

                        ClubCloud_Address address = model.ClubCloud_Addresses.Find(addr.Id);

                        if (address.Naam.Equals("Bezoekadres", StringComparison.InvariantCultureIgnoreCase))
                        {
                            //address.Fax
                            address.Land = entity.sgt_bezoekadreslandcodeid.name;
                            //address.Latitude
                            //address.Longitude
                            address.Nummer = entity.sgt_bezoekadres_huisnummer;
                            address.ParentId = entity.sgt_alg_accommodatieid.Value;
                            //address.Postbus
                            address.Postcode = entity.sgt_bezoekadres_postcode;
                            address.Provincie = entity.sgt_bezoekadres_gemeente;
                            address.Stad = entity.sgt_bezoekadres_plaats;
                            address.Straat = entity.sgt_bezoekadres_straat;
                            //address.TelefoonPrimair
                            //address.TelefoonSecundair
                            //address.TelefoonTertiair
                            address.Toevoeging = entity.sgt_bezoekadres_toevoeging;
                            address.Actief = entity.statuscode.name;
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
                            address.Postcode = entity.sgt_postadres_postcode;
                            address.Provincie = entity.sgt_postadres_gemeente;
                            address.Stad = entity.sgt_postadres_plaats;
                            address.Straat = entity.sgt_postadres_straat;
                            //address.TelefoonPrimair
                            //address.TelefoonSecundair
                            //address.TelefoonTertiair
                            address.Toevoeging = entity.sgt_postadres_toevoeging;
                            address.Actief = entity.statuscode.name;
                        }

                    }
                }
                else
                {
                    ClubCloud_Address bezoek_address = model.ClubCloud_Addresses.Create();

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
                    bezoek_address.Postcode = entity.sgt_bezoekadres_postcode;
                    bezoek_address.Provincie = entity.sgt_bezoekadres_gemeente;
                    bezoek_address.Stad = entity.sgt_bezoekadres_plaats;
                    bezoek_address.Straat = entity.sgt_bezoekadres_straat;
                    //bezoek_address.TelefoonPrimair
                    //bezoek_address.TelefoonSecundair
                    //bezoek_address.TelefoonTertiair
                    bezoek_address.Toevoeging = entity.sgt_bezoekadres_toevoeging;
                    bezoek_address.Actief = entity.statuscode.name;

                    model.ClubCloud_Addresses.Add(bezoek_address);

                    ClubCloud_Address post_address = model.ClubCloud_Addresses.Create();

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
                    post_address.Postcode = entity.sgt_postadres_postcode;
                    post_address.Provincie = entity.sgt_postadres_gemeente;
                    post_address.Stad = entity.sgt_postadres_plaats;
                    post_address.Straat = entity.sgt_postadres_straat;
                    //post_address.TelefoonPrimair
                    //post_address.TelefoonSecundair
                    //post_address.TelefoonTertiair
                    post_address.Toevoeging = entity.sgt_postadres_toevoeging;
                    post_address.Actief = entity.statuscode.name;
                    model.ClubCloud_Addresses.Add(bezoek_address);

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
            CheckDatabase();

            ClubCloud_Lidmaatschap lidmaatschap = new ClubCloud_Lidmaatschap();


            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(lidmaatschapId);

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
                                    lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap == null)
                                    {
                                        lidmaatschap = model.ClubCloud_Lidmaatschappen.Create();
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer);
                                        model.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                    }
                                    else
                                    {
                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer);

                                    }

                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

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
            CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                lidmaatschappen = model.ClubCloud_Lidmaatschappen.Where(l => l.VerenigingId == verenigingId).ToList();

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
                                    ClubCloud_Lidmaatschap lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap == null)
                                    {
                                        lidmaatschap = model.ClubCloud_Lidmaatschappen.Create();
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer,settings);
                                        model.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                        lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer,settings);
                                        lidmaatschappen.Add(lidmaatschap);
                                    }

                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
            CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();


            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                lidmaatschappen = model.ClubCloud_Lidmaatschappen.Where(l => l.GebruikerId == gebruikerId).ToList();

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
                                    ClubCloud_Lidmaatschap lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap == null)
                                    {
                                        lidmaatschap = model.ClubCloud_Lidmaatschappen.Create();
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer,settings);
                                        model.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                        lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer,settings);
                                        lidmaatschappen.Add(lidmaatschap);
                                    }

                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

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
            CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                lidmaatschappen = model.ClubCloud_Lidmaatschappen.Where(f => f.VerenigingId == verenigingId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

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
                                    ClubCloud_Lidmaatschap lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap == null)
                                    {
                                        lidmaatschap = model.ClubCloud_Lidmaatschappen.Create();
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer,settings);

                                        model.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                        lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer,settings);
                                        lidmaatschappen.Add(lidmaatschap);
                                    }

                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
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
                lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                lidmaatschap.SoortId = entity.sgt_soort_lidmaatschapid.Value;
            }

            if (entity.sgt_verenigingid != null)
            {
                ClubCloud_Vereniging vereniging = VerenigingById(bondsnummer, entity.sgt_verenigingid.Value, false,settings);
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
        }

        #endregion

        //TODO
        #region Profielen

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Profiel SpelersProfielByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                profiel = model.ClubCloud_Profielen.SingleOrDefault(p => p.GebruikerId == gebruikerId);

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
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_naamid ", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
            } return profiel;
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
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();
            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                profiel = model.ClubCloud_Profielen.Find(profielId);

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
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
            }
            return profiel;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="nummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Profiel SpelersProfielByNummer(string bondsnummer, string nummer, bool refresh = false)
        {
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                profiel = model.ClubCloud_Profielen.SingleOrDefault(p => p.Bondsnummer == nummer);

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
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
            }
            return profiel;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> SpelersProfielen(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                profielen = model.ClubCloud_Profielen.Where(p => p.Id != null).ToList();

                if (profielen != null && profielen.Count == 0)
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
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
            }

            return profielen;
            //sgt_dss_spelersprofiel profiel = new sgt_dss_spelersprofiel();
            //profiel.sgt_aantal_partij_resultaten_dubbel.Value
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

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                gebruiker = model.ClubCloud_Gebruikers.Find(gebruikerId);

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
                                    gebruiker = model.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = model.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;

                                        ContactToGebruiker(entity, gebruiker, bondsnummer,settings);


                                        model.ClubCloud_Gebruikers.Add(gebruiker);
                                        UpdateMembershipuser(gebruiker);

                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, gebruiker, bondsnummer,settings);
                                        UpdateMembershipuser(gebruiker);

                                    }

                                    model.SaveChanges();

                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        List<ClubCloud_Functionaris> functies = FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value,false,settings);
                                        /*
                                        foreach (ClubCloud_Functionaris functie in functies)
                                        {
                                            gebruiker.ClubCloud_Functionaris.Add(functie);
                                        }
                                        */
                                    }
                                    model.SaveChanges();
                                }
                            }
                        }
                    }
                }

                if (model.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }

                model.SaveChanges();
            }
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

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                gebruiker = model.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);

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
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact entity in entities)
                                {
                                    gebruiker = model.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = model.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;

                                        ContactToGebruiker(entity, gebruiker, bondsnummer,settings);

                                        model.ClubCloud_Gebruikers.Add(gebruiker);
                                        UpdateMembershipuser(gebruiker);
                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, gebruiker, bondsnummer,settings);
                                        UpdateMembershipuser(gebruiker);

                                    }

                                    model.SaveChanges();

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
                                    model.SaveChanges();
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return gebruiker;
        }

        /// <summary>
        /// contact
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> Gebruikers(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                gebruikers = model.ClubCloud_Gebruikers.Where(f => f.VerenigingId == verenigingId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

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
                                    ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = model.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;

                                        ContactToGebruiker(entity, gebruiker, bondsnummer);

                                        model.ClubCloud_Gebruikers.Add(gebruiker);
                                        UpdateMembershipuser(gebruiker);
                                        gebruikers.Add(gebruiker);

                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, gebruiker, bondsnummer);
                                        UpdateMembershipuser(gebruiker);
                                        gebruikers.Add(gebruiker);

                                    }

                                    model.SaveChanges();

                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        List<ClubCloud_Functionaris> functies = FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                                        foreach (ClubCloud_Functionaris functie in functies)
                                        {
                                            gebruiker.ClubCloud_Functionaris.Add(functie);
                                        }
                                    }
                                    model.SaveChanges();
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return gebruikers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="gebruiker"></param>
        /// <param name="bondsnummer"></param>
        private void ContactToGebruiker(contact entity, ClubCloud_Gebruiker gebruiker, string bondsnummer, ClubCloud_Setting settings = null)
        {
            gebruiker.Bondsnummer = entity.sgt_bondsnummer;
            gebruiker.Beschrijving = entity.description;

            if (entity.parentcustomerid != null)
            {
                gebruiker.VerenigingId = entity.parentcustomerid.Value;
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

            if (String.IsNullOrWhiteSpace(entity.sgt_fotonummer) || String.IsNullOrEmpty(entity.sgt_fotonummer))
            {
                gebruiker.FotoId = int.Parse(entity.sgt_fotonummer);
            }

            if (entity.sgt_adres_geheim != null)
            {
                gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
            }

            ClubCloud_Address bezoek = AdresById(bondsnummer, entity.address1_addressid.Value, false, settings);
            //gebruiker.ClubCloud_Address..Add(bezoek);

            ClubCloud_Address post = AdresById(bondsnummer, entity.address2_addressid.Value, false, settings);
            //gebruiker.ClubCloud_Address.Add(post);

            gebruiker.Actief = entity.statuscode.name;

        }

        #endregion

        #region Foto

        private ClubCloud_Foto FotoByBondsnummer(string bondsnummer, string nummer, bool refresh = false)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);

                if (gebruiker != null)
                {
                    foto = model.ClubCloud_Foto.SingleOrDefault(f => f.FotoId == gebruiker.FotoId);
                }

                if (foto == null || refresh)
                {
                    ClubCloud_Setting settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.Media.KNLTBFoto KNLTBfoto = new KNLTB.Media.KNLTBFoto();
                            KNLTBfoto.RequestFoto(gebruiker.Bondsnummer, cc);
                            Image data = KNLTBfoto.Foto;

                            foto = model.ClubCloud_Foto.Create();
                            foto.Id = Guid.NewGuid();
                            foto.FotoId = gebruiker.FotoId;
                            foto.ContentType = KNLTBfoto.ContentType;
                            foto.ContentLength = KNLTBfoto.ContentLength;

                            MemoryStream ms = new MemoryStream();
                            data.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                            foto.ContentData = ms.ToArray();

                            // <asp:Image ID="Image1" runat="server" Visible = "false"/>
                            //byte[] bytes = (byte[])GetData("SELECT Data FROM tblFiles WHERE Id =" + id).Rows[0]["Data"];
                            //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                            //Image1.ImageUrl = "data:image/png;base64," + base64String;
                        }
                    }
                }
                model.SaveChanges();
            }
            return foto;
        }

        private ClubCloud_Foto FotoByGebruikerId(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            using (ClubCloud.Service.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(gebruikerId);

                if (gebruiker != null)
                {
                    foto = model.ClubCloud_Foto.SingleOrDefault(f => f.FotoId == gebruiker.FotoId);
                }

                if (foto == null || refresh)
                {
                    ClubCloud_Setting settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.Media.KNLTBFoto KNLTBfoto = new KNLTB.Media.KNLTBFoto())
                            {
                                KNLTBfoto.RequestFoto(gebruiker.Bondsnummer, cc);
                                Image data = KNLTBfoto.Foto;

                                foto = model.ClubCloud_Foto.Create();
                                foto.Id = Guid.NewGuid();
                                foto.FotoId = gebruiker.FotoId;
                                foto.ContentType = KNLTBfoto.ContentType;
                                foto.ContentLength = KNLTBfoto.ContentLength;

                                MemoryStream ms = new MemoryStream();
                                data.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                                foto.ContentData = ms.ToArray();

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
                }
                model.SaveChanges();
            }
            return foto;
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

                SPDatabaseParameters databaseParameters = null;
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

                        if (model.Database.CreateIfNotExists())
                        {
                            model.Database.Initialize(true);
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
                                    vereniging = model.ClubCloud_Verenigingen.Add(new ClubCloud_Vereniging { Nummer = verenigingsnummer, Naam = "S.V. Kampong", Id = new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") });
                                    model.SaveChanges();

                                    //vereniging = model.ClubCloud_Verenigingen.Find(int.Parse(verenigingsnummer));
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
