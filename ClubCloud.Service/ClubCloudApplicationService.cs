namespace ClubCloud.Service
{
    using ClubCloud.KNLTB.ServIt.CrmService;
    using ClubCloud.Model;
    using ClubCloud.Provider;
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
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Net;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Web.Security;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Transactions;
    using System.Data.Entity.Validation;

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

        private static ClubCloud.Model.BeheerContainer _beheerModel = null;

        public static ClubCloud.Model.BeheerContainer beheerModel
        {
            get
            {
                if (_beheerModel == null)
                {
                    _beheerModel = new BeheerContainer(GetConnectionString());
                    
                    _beheerModel.Database.Connection.StateChange += Connection_StateChange;
                    _beheerModel.Database.Connection.Disposed += Connection_Disposed;

                    _beheerModel.ObjectContext.SavingChanges += ObjectContext_SavingChanges;
                    //_beheerModel.ObjectContext.ObjectMaterialized += ObjectContext_ObjectMaterialized;

                }
                /*
                if (_beheerModel.Database.Connection.State == System.Data.ConnectionState.Broken)
                {
                    _beheerModel.Database.Connection.Close();
                }

                if (_beheerModel.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _beheerModel.Database.Connection.Open();
                }
                */

                return _beheerModel;
            }
            //set { ClubCloudApplicationService.beheerModel = value; }
        }

        static void ObjectContext_ObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
        }

        static void Connection_Disposed(object sender, EventArgs e)
        {
            //_beheerModel.Dispose();
            //_beheerModel = null;
        }

        static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            if(e.CurrentState == System.Data.ConnectionState.Broken)
            {
                _beheerModel.Database.Connection.Close();
            }

            if(e.CurrentState == System.Data.ConnectionState.Closed)
            {
                _beheerModel.Database.Connection.Open();
            }
        }

        static void ObjectContext_SavingChanges(object sender, EventArgs e)
        {
            IEnumerable<DbEntityValidationResult> errors = _beheerModel.GetValidationErrors();

            foreach (DbEntityValidationResult error in errors)
            {
                error.Entry.State = EntityState.Detached;
            }
        }

        private static ClubCloud.Model.BoekhoudingContainer _boekhoudingModel = null;

        public static ClubCloud.Model.BoekhoudingContainer boekhoudingModel
        {
            get
            {
                if (_boekhoudingModel == null)
                {
                    _boekhoudingModel = new BoekhoudingContainer(GetConnectionString());
                }

                if (_boekhoudingModel.Database.Connection.State == System.Data.ConnectionState.Broken)
                {
                    _boekhoudingModel.Database.Connection.Close();
                }

                if (_boekhoudingModel.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _boekhoudingModel.Database.Connection.Open();
                }

                return _boekhoudingModel;
            }
            //set { ClubCloudApplicationService.beheerModel = value; }
        }

        private static ClubCloud.Model.SignalRContainer _signalRModel = null;

        public static ClubCloud.Model.SignalRContainer signalRModel
        {
            get
            {
                if (_signalRModel == null)
                {
                    _signalRModel = new SignalRContainer(GetConnectionString());
                }

                if (_signalRModel.Database.Connection.State == System.Data.ConnectionState.Broken)
                {
                    _signalRModel.Database.Connection.Close();
                }

                if (_signalRModel.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _signalRModel.Database.Connection.Open();
                }

                return _signalRModel;
            }
            //set { ClubCloudApplicationService.beheerModel = value; }
        }

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
                using (ClubCloud.Model.BeheerContainer Beheermodel = new Model.BeheerContainer(GetConnectionString(catalog)))
                {
                    Beheermodel.Database.CreateIfNotExists();
                    Beheermodel.Database.Initialize(false);
                    Beheermodel.Database.CompatibleWithModel(false);
                }
                return;
            }

            if (catalog.StartsWith("ClubCloudService_Boekhouding", StringComparison.InvariantCultureIgnoreCase))
            {
                using (ClubCloud.Model.BoekhoudingContainer Boekhoudingmodel = new Model.BoekhoudingContainer(GetConnectionString(catalog)))
                {
                    Boekhoudingmodel.Database.CreateIfNotExists();
                    Boekhoudingmodel.Database.Initialize(false);
                    Boekhoudingmodel.Database.CompatibleWithModel(false);
                }
            }

            if (catalog.StartsWith("ClubCloudService_SignalR", StringComparison.InvariantCultureIgnoreCase))
            {
                using (ClubCloud.Model.SignalRContainer SignalRmodel = new Model.SignalRContainer(GetConnectionString(catalog)))
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

        #region KNLTB

        #region Service

        private static Dictionary<string, ClubCloud.KNLTB.ServIt.CrmService.CrmService> _crmServices;

        public Dictionary<string, ClubCloud.KNLTB.ServIt.CrmService.CrmService> CrmServices
        {
            get
            {
                if (_crmServices == null)
                    _crmServices = new Dictionary<string, CrmService>();

                return _crmServices;
            }
        }

        /*
        private static ClubCloud.KNLTB.ServIt.CrmService.CrmService _crmService = null;

        private static ClubCloud.KNLTB.ServIt.CrmService.CrmService CrmService
        {
            get
            {
                if (ClubCloudApplicationService._crmService == null)
                {
                    ClubCloudApplicationService._crmService = new CrmService();
                }                
                return ClubCloudApplicationService._crmService;
            }
            //set { ClubCloudApplicationService._crmService = value; }
        }
        */

        #endregion

        #region CookieContainer

        private static SortedList<string, CookieContainer> _containers;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="wachtwoord"></param>
        /// <returns></returns>
        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord, bool decrypt = true)
        {
            CookieContainer container = null;// new CookieContainer();

            if (_containers == null)
                _containers = new SortedList<string, CookieContainer>();

            if (_crmServices == null)
                _crmServices = new Dictionary<string, CrmService>();

            bool expired = false;
            if (_containers.Keys.Contains(bondsnummer))
            {
                container = _containers.FirstOrDefault(c => c.Key == bondsnummer).Value;

                CookieCollection cookies = container.GetCookies(new Uri("http://www.mijnknltb.nl"));
                cookies.Add(container.GetCookies(new Uri("http://servit.mijnknltb.nl")));
                cookies.Add(container.GetCookies(new Uri("http://mijnknltb.nl")));

                foreach (Cookie cookie in cookies)
                {
                    if (DateTime.Now.Subtract(cookie.TimeStamp).Minutes > 19)
                    //if (cookie.Expired)
                    {
                        cookie.Expired = true;
                        expired = cookie.Expired;
                        //break;
                    }
                }
            }

            if (container != null && container.Count > 0 && !expired)
            {
                return container;
            }
            else
            {
                if (_containers.Keys.Contains(bondsnummer))
                {
                    _containers.Remove(bondsnummer);
                }

                ClubCloud.KNLTB.Security.KNLTBContainer KNLTBContainer = new KNLTB.Security.KNLTBContainer();
                if (decrypt)
                {
                    ClubCloud_Setting settings = GetClubCloudSettings(bondsnummer);
                    string decrypted = BeheerEncryption.Decrypt(settings.Password, settings.VerenigingId.Value.ToString(), settings.GebruikerId.Value.ToString());
                    KNLTBContainer.MijnRequestAcces(bondsnummer, decrypted);
                }
                else
                {
                    KNLTBContainer.MijnRequestAcces(bondsnummer, wachtwoord);
                }

                Stopwatch s = new Stopwatch();
                s.Start();
                //TODO
                while (KNLTBContainer.Container == null && s.Elapsed < TimeSpan.FromSeconds(30)) { }
                s.Stop();

                _containers.Add(bondsnummer, KNLTBContainer.Container);

                if (_crmServices.ContainsKey(bondsnummer))
                {
                    _crmServices[bondsnummer].CrmCookieContainer = KNLTBContainer.Container;
                }
                else
                {
                    _crmServices.Add(bondsnummer, new CrmService(KNLTBContainer.Container));
                }

                return KNLTBContainer.Container;
            }
        }

        #endregion

        #region Retrieve

        /*
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
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="entityName"></param>
        /// <param name="moreRecords"></param>
        /// <param name="pageNum"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        private List<BusinessEntity> RetrieveMultiple(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, out bool moreRecords, ref int pageNum, FilterExpression filter = null, LinkEntity link = null)
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
            /*
            //Limit while debugging
#if DEBUG
            pageInfo.Count = 20;
#else
            pageInfo.Count = 50;
#endif
            */
            pageInfo.Count = 50;
            pageInfo.PageNumber = pageNum;
            QueryExpression query = new QueryExpression();

            query.EntityName = entityName;
            query.ColumnSet = new AllColumns();
            query.Criteria = expression;
            query.LinkEntities = new LinkEntity[] { link };
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
            /*
#if DEBUG
            moreRecords = false;
#endif
            */

            return entities;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private BusinessEntity RetrieveEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, TargetRetrieve target)
        {
            BusinessEntity entity = null;

            RetrieveResponse result = null;
            RetrieveRequest request = new RetrieveRequest();
            request.ColumnSet = new AllColumns();
            request.ReturnDynamicEntities = true;
            request.Target = target;

            try
            {
                result = (RetrieveResponse)service.Execute(request);

                if (result != null)
                {
                    entity = result.BusinessEntity;
                }
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
                throw ex;
            }
            return entity;
        }

        #endregion

        #region Update

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private bool UpdateEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, TargetUpdate target)
        {
            bool succes = true;
            UpdateResponse result = null;
            UpdateRequest request = new UpdateRequest();
            request.Target = target;

            try
            {
                result = (UpdateResponse)service.Execute(request);
            }
            catch (Exception ex)
            {
                succes = false;
                string exception = ex.ToString();
                throw ex;
            }
            return succes;
        }

        #endregion

        #region Create

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private Guid UpdateEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, TargetCreate target)
        {
            Guid newId = Guid.Empty;

            CreateResponse result = null;
            CreateRequest request = new CreateRequest();
            request.Target = target;

            try
            {
                result = (CreateResponse)service.Execute(request);
                newId = result.id;
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
                throw ex;
            }
            return newId;
        }

        #endregion

        #region Delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private bool DeleteEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, TargetDelete target)
        {
            bool succes = true;

            DeleteResponse result = null;
            DeleteRequest request = new DeleteRequest();
            request.Target = target;

            try
            {
                result = (DeleteResponse)service.Execute(request);
            }
            catch (Exception ex)
            {
                succes = false;
                string exception = ex.ToString();
                throw ex;
            }
            return succes;
        }

        #endregion

        #region State

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private bool StateEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, Request request)
        {
            bool succes = true;

            Response result = null;

            try
            {
                result = (Response)service.Execute(request);
            }
            catch (Exception ex)
            {
                succes = false;
                string exception = ex.ToString();
                throw ex;
            }
            return succes;
        }

        #endregion

        #endregion

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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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
#if DEBUG
                bondsnummer = "12073385";
#else
                bondsnummer = string.Empty;
#endif

                //bondsnummer = string.Empty;
            }
        }

        #endregion

        #region Security

        private ClubCloud_Setting GetSettings(int bondsnummer, ClubCloud_Functie functie = null)
        {
            ClubCloud_Setting settings = null;
            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

            if (functie != null)
            {
                functies.Add(functie);
            }
            else
            {
                ClubCloud_Functie ledenadministratie = beheerModel.ClubCloud_Functies.Find(new Guid("C91FB5B2-E6CB-4B34-B9DC-BEBDFD6D35C7"));
                if (ledenadministratie != null)
                    functies.Add(ledenadministratie);

                ClubCloud_Functie gedelegeerd_gedenadministratie = beheerModel.ClubCloud_Functies.Find(new Guid("516B73DD-61B8-4B5F-BD15-78232C2D071C"));
                if (gedelegeerd_gedenadministratie != null)
                    functies.Add(gedelegeerd_gedenadministratie);
            }

            ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(bondsnummer);

            bool heeftFunctie = false;

            if (usersettings != null && usersettings.Access && !string.IsNullOrEmpty(usersettings.Password) && usersettings.GebruikerId.HasValue)
            {
                //TODO Loop for getsettings
                List<ClubCloud_Functionaris> functionarissen = GetFunctionarissenByGebruiker(bondsnummer, usersettings.GebruikerId.Value, false, usersettings);

                foreach (ClubCloud_Functionaris functionaris in functionarissen)
                {
                    //ClubCloud_Functie afunctie = FunctieById(bondsnummer, functionaris.FunctieId.Value, false, usersettings);
                    //if (afunctie != null && functies.Contains(afunctie))
                    //if (functies.Contains(functionaris.ClubCloud_Functie))                    
                    if (functies.Any(f => f.Id == functionaris.FunctieId))
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
                    List<ClubCloud_Functionaris> functionarissen = GetFunctionarissenByVereniging(bondsnummer, usersettings.VerenigingId.Value, false, settings);

                    foreach (ClubCloud_Functionaris functionaris in functionarissen)
                    {
                        //ClubCloud_Functie afunctie = FunctieById(bondsnummer, functionaris.FunctieId.Value, false, usersettings);
                        //if (afunctie != null && functies.Contains(afunctie))
                        //if (functies.Contains( f => f.id == functioniris.FinctieIdfunctionaris.ClubCloud_Functie))
                        if (functies.Any(f => f.Id == functionaris.FunctieId))
                        {
                            usersettings = beheerModel.ClubCloud_Settings.FirstOrDefault(g => g.GebruikerId == functionaris.GebruikerId);// .Find(functionaris.ClubCloud_Gebruiker.Bondsnummer);
                            if (usersettings != null && usersettings.Access && !string.IsNullOrEmpty(usersettings.Password))
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
            int nummer;
            if(int.TryParse(bondsnummer,out nummer))
                return GetSettings(nummer);

            return null;
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

        private async Task<bool> CreateOrUpdateMembershipGebruiker(ClubCloud_Gebruiker gebruiker, ClubCloud_Setting settings = null)
        {
            try
            {
                if (settings == null)
                {
                    settings = GetClubCloudSettings(gebruiker.Bondsnummer);// beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.GebruikerId == gebruiker.Id);
                }
                //ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.GebruikerId == gebruiker.Id);
                if (settings != null)// && updatesettings.Id != null)
                {
                    ZimbraMembershipUser zuser = await Provider.GetZimbraUserAsync(gebruiker.Bondsnummer, false);

                    MembershipCreateStatus status = MembershipCreateStatus.Success;

                    if (zuser == null)
                    {
                        string nummer = "00000";
                        ClubCloud_Vereniging vereniging = null;
                        try
                        {
                            vereniging = GetVerenigingById(gebruiker.Bondsnummer, gebruiker.VerenigingId.Value, false);
                        }
                        catch { }

                        if (vereniging != null)
                            nummer = vereniging.Nummer;

                        string password = gebruiker.Achternaam[0] + gebruiker.Bondsnummer + '!';
                        string email = string.IsNullOrEmpty(gebruiker.EmailKNLTB) ? gebruiker.Bondsnummer + "@clubcloud.nl" : gebruiker.EmailKNLTB;

                        Tuple<MembershipCreateStatus, MembershipUser> result = await Provider.CreateUserAsync(gebruiker.Bondsnummer + "@clubcloud.nl", password, email, "Wat uw verenigingsnummer?", nummer, true, null);

                        if (result.Item1 == MembershipCreateStatus.Success)
                        {
                            status = result.Item1;
                            zuser = result.Item2 as ZimbraMembershipUser;
                        }
                    }

                    if (status == MembershipCreateStatus.Success)
                    {
                        List<ClubCloud_Address> adressen = GetAddressByGebruikerId(gebruiker.Bondsnummer, gebruiker.VerenigingId.Value, gebruiker.Id, false);

                        ClubCloud_Address home = new ClubCloud_Address();
                        ClubCloud_Address post = new ClubCloud_Address();
                        if (adressen != null && adressen.Count > 0)
                        {
                            home = adressen.First();
                            post = adressen.Last();
                        }
                        ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(gebruiker.Bondsnummer, gebruiker.NationaliteitId.Value, false, settings);
                        ClubCloud_Vereniging vereniging = GetVerenigingById(gebruiker.Bondsnummer, gebruiker.VerenigingId.Value, false);
                        ClubCloud_District district = GetDistrictById(gebruiker.Bondsnummer, vereniging.DistrictId.Value, false, settings);

                        if (gebruiker != null)
                        {
                            zuser.cn = gebruiker.Volledigenaam;
                            zuser.sn = gebruiker.Achternaam;
                            zuser.displayName = gebruiker.Volledigenaam;
                            zuser.employeeNumber = gebruiker.Id.ToString();
                            zuser.givenName = gebruiker.Voornamen;
                            zuser.initials = gebruiker.Voorletters;
                            zuser.telephoneNumber = gebruiker.Mobiel;
                            zuser.zimbraPrefMailForwardingAddress = gebruiker.EmailKNLTB;
                            zuser.homePhone = gebruiker.TelefoonAvond;
                            zuser.mobile = gebruiker.Mobiel;
                        }

                        if (nationaliteit != null)
                            zuser.co = nationaliteit.Naam;

                        if (vereniging != null)
                        {
                            zuser.o = vereniging.Nummer;
                            zuser.company = vereniging.Nummer;
                        }

                        if (district != null)
                            zuser.departmentNumber = district.Naam;



                        if (home != null)
                        {
                            zuser.homePostalAddress = home.Straat + " " + home.Nummer + " " + home.Toevoeging + " " + Environment.NewLine + home.Postcode + "," + home.Stad + " " + Environment.NewLine + home.Gemeente + "," + home.Provincie;
                            zuser.l = home.Stad;
                            zuser.postalCode = home.Postcode;
                            zuser.st = home.Gemeente;
                            zuser.street = home.Straat + " " + home.Nummer + " " + home.Toevoeging;
                        }

                        if (post != null)
                        {
                            zuser.postalAddress = post.Straat + " " + post.Nummer + " " + post.Toevoeging + " " + Environment.NewLine + post.Postcode + "," + post.Stad + " " + Environment.NewLine + post.Gemeente + "," + post.Provincie;
                        }
                    }

                    if (zuser != null && status == MembershipCreateStatus.Success)
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

        private async Task<bool> CreateOrUpdateMembershipVereniging(ClubCloud_Vereniging vereniging, ClubCloud_Setting settings = null)
        {
            try
            {
                if (settings == null)
                {
                    settings = beheerModel.ClubCloud_Settings.SingleOrDefault(g => g.VerenigingId == vereniging.Id);
                }

                if (settings != null)
                {
                    ZimbraMembershipUser zuser = await Provider.GetZimbraUserAsync(vereniging.Nummer, false);
                    MembershipCreateStatus status = MembershipCreateStatus.Success;

                    if (zuser == null)
                    {

                        string password = vereniging.Naam[0] + vereniging.Nummer + '!';
                        string email = string.IsNullOrEmpty(vereniging.EmailKNLTB) ? vereniging.Nummer + "@clubcloud.nl" : vereniging.EmailKNLTB;
                        Tuple<MembershipCreateStatus, MembershipUser> result = await Provider.CreateUserAsync(vereniging.Nummer + "@clubcloud.nl", password, email, "Wat uw verenigingsnummer?", vereniging.Nummer, true, null);

                        if (result.Item1 == MembershipCreateStatus.Success)
                        {
                            status = result.Item1;
                            zuser = result.Item2 as ZimbraMembershipUser;
                        }
                    }

                    if (status == MembershipCreateStatus.Success)
                    {
                        List<ClubCloud_Address> adressen = GetAddressByParent(vereniging.Nummer, vereniging.Id, false, settings);
                        ClubCloud_Address home = new ClubCloud_Address();
                        ClubCloud_Address post = new ClubCloud_Address();
                        if (adressen != null && adressen.Count > 0)
                        {
                            home = adressen.First();
                            post = adressen.Last();
                        }

                        //ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(vereniging.Nummer, vereniging.NationaliteitId.Value, false, settings);

                        if (vereniging != null)
                        {
                            zuser.cn = vereniging.Naam;
                            zuser.sn = vereniging.Naam;
                            zuser.company = vereniging.Nummer;
                            zuser.displayName = vereniging.Naam;
                            zuser.employeeNumber = vereniging.Id.ToString();
                            zuser.givenName = vereniging.Naam;
                            zuser.homePhone = vereniging.TelefoonOverdag;
                            zuser.mobile = vereniging.TelefoonOverig;
                            zuser.o = vereniging.Nummer;
                            zuser.telephoneNumber = vereniging.TelefoonAvond;
                            zuser.zimbraPrefMailForwardingAddress = vereniging.EmailKNLTB;
                            //zuser.co = gebruiker.NationaliteitId.ToString();
                            //zuser.initials = gebruiker.Voorletters;
                        }

                        ClubCloud_District district = null;
                        if (vereniging.DistrictId != null)
                            district = GetDistrictById(vereniging.Nummer, vereniging.DistrictId.Value, false, settings);

                        if (district != null)
                            zuser.departmentNumber = district.Naam;

                        if (home != null)
                        {
                            zuser.homePostalAddress = home.Straat + " " + home.Nummer + " " + home.Toevoeging + " " + Environment.NewLine + home.Postcode + "," + home.Stad + " " + Environment.NewLine + home.Gemeente + "," + home.Provincie;
                            zuser.l = home.Stad;
                            zuser.postalCode = home.Postcode;
                            zuser.st = home.Gemeente;
                            zuser.street = home.Straat + " " + home.Nummer + " " + home.Toevoeging;
                        }

                        if (post != null)
                        {
                            zuser.postalAddress = post.Straat + " " + post.Nummer + " " + post.Toevoeging + " " + Environment.NewLine + post.Postcode + "," + post.Stad + " " + Environment.NewLine + post.Gemeente + "," + post.Provincie;
                        }
                    }


                    if (zuser != null && status == MembershipCreateStatus.Success)
                        await Provider.UpdateZimbraUserAsync(zuser);
                }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <returns></returns>
        public ClubCloud_Setting GetClubCloudSettings(int bondsnummer)
        {
            return GetClubCloudSettings(bondsnummer.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <returns></returns>
        public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            int nummer;

            if (!int.TryParse(bondsnummer, out nummer))
            {
                return currentsettings;
            }

            try
            {
                currentsettings = beheerModel.ClubCloud_Settings.Find(nummer);
                beheerModel.ObjectContext.Refresh(RefreshMode.StoreWins, currentsettings);
            }
            catch
            {

                currentsettings = null;
            }

            if (currentsettings == null)
            {
                currentsettings = beheerModel.ClubCloud_Settings.Create();
                currentsettings.Id = nummer;

                ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Where(g => g.Bondsnummer == nummer.ToString()).FirstOrDefault();
                ClubCloud_Vereniging vereniging = null;

                if (gebruiker != null)
                {
                    currentsettings.GebruikerId = gebruiker.Id;
                    currentsettings.ClubCloud_Gebruiker = gebruiker;
                }

                if (gebruiker.VerenigingId.HasValue)
                    vereniging = beheerModel.ClubCloud_Verenigingen.Find(gebruiker.VerenigingId.Value);

                if (vereniging != null)
                {
                    currentsettings.VerenigingId = vereniging.Id;
                    currentsettings.ClubCloud_Vereniging = vereniging;
                }

                currentsettings.Gewijzigd = DateTime.Now;
                beheerModel.ClubCloud_Settings.Add(currentsettings);
                beheerModel.SaveChanges();
            }
            /*
            else
            {
                vereniging = beheerModel.ClubCloud_Verenigingen.Where(v => v.Nummer == nummer.ToString()).FirstOrDefault();

                if (vereniging != null)
                {
                    currentsettings.VerenigingId = vereniging.Id;
                    currentsettings.ClubCloud_Vereniging = vereniging;
                }
            }
            */

            currentsettings = beheerModel.ClubCloud_Settings.Find(nummer);
            if (currentsettings != null)
                beheerModel.ObjectContext.Refresh(RefreshMode.StoreWins, currentsettings);

            return currentsettings;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public ClubCloud_Setting SetClubCloudSettings(ClubCloud_Setting settings)
        {
            ClubCloud_Setting tobeupdated = beheerModel.ClubCloud_Settings.Find(settings.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(settings);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Settings.Find(settings.Id);
            beheerModel.ObjectContext.Refresh(RefreshMode.StoreWins, tobeupdated);

            return tobeupdated;
        }

        /*
        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = GetClubCloudSettings(settings.Id);
            //currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);

            bool parse = false;
            if (settings.Agree && (currentsettings.Password != settings.Password))
            {
                currentsettings.Agree = settings.Agree;
                currentsettings.Password = settings.Password;
                currentsettings.Gewijzigd = DateTime.Now;
                beheerModel.SaveChanges();
                parse = true;
            }

            if (parse)
            {
                CookieContainer cc = RequestContainer(currentsettings.Id.ToString(), currentsettings.Password, false);

                if (cc != null)
                {
                    using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                    {
                        //CrmService.CrmCookieContainer = cc;//
                        //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        try
                        {
                            WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;

                            currentsettings.Access = true;
                            currentsettings.Gewijzigd = DateTime.Now;
                            beheerModel.SaveChanges();

                            ClubCloud_Gebruiker gebruiker = GebruikerByNummer(currentsettings.Id.ToString(), currentsettings.Id.ToString(), true, currentsettings, false);

                            if (gebruiker != null)
                            {
                                currentsettings.GebruikerId = gebruiker.Id;
                                currentsettings.ClubCloud_Gebruiker = gebruiker;
                                if (gebruiker.VerenigingId.HasValue)
                                {
                                    ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(gebruiker.VerenigingId.Value);
                                    currentsettings.VerenigingId = gebruiker.VerenigingId.Value;
                                    currentsettings.ClubCloud_Vereniging = vereniging;
                                    beheerModel.SaveChanges();
                                }

                                if (currentsettings.Access && currentsettings.VerenigingId.HasValue && currentsettings.GebruikerId.HasValue)
                                {
                                    string encrypted = BeheerEncryption.Encrypt(currentsettings.Password, currentsettings.VerenigingId.Value.ToString(), currentsettings.GebruikerId.Value.ToString());

                                    currentsettings.Password = encrypted;
                                    currentsettings.Gewijzigd = DateTime.Now;
                                    beheerModel.SaveChanges();
                                }

                                List<ClubCloud_Lidmaatschap> lidmaatschappen = GetLidmaatschappenByGebruiker(currentsettings.Id.ToString(), gebruiker.Id);
                            }
                        }
                        catch (WebException wex)
                        {
                            HttpWebResponse response = wex.Response as HttpWebResponse;
                            if (response.StatusCode == HttpStatusCode.Forbidden)
                            {
                                currentsettings.Access = false;
                                currentsettings.Gewijzigd = DateTime.Now;
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }


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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

                //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
                //{

                ClubCloud_Setting settings = beheerModel.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
                ClubCloud_Gebruiker currentgebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruiker.Id);

                if (currentgebruiker != null)
                {
                    if (settings != null)
                    {
                        if (!settings.GebruikerId.HasValue)
                        {
                            settings.ClubCloud_Gebruiker = currentgebruiker;
                            settings.GebruikerId = gebruiker.Id;
                            beheerModel.SaveChanges();
                        }

                        if (!settings.VerenigingId.HasValue)
                        {
                            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(settings.VerenigingId.Value);
                            settings.ClubCloud_Vereniging = vereniging;
                            settings.VerenigingId = gebruiker.VerenigingId.Value;
                            beheerModel.SaveChanges();
                        }
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
                        //UpdateMembershipuser(gebruiker);
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

        public ClubCloud_Foto UpdateFoto(string bondsnummer, Guid verenigingId, ClubCloud_Foto foto)
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
            addressen = GetAddressByParent(bondsnummer, gebruikerId, refresh);
            return addressen;
        }

        public List<ClubCloud_Lidmaatschap> GetLidmaatschapByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            lidmaatschappen = GetLidmaatschappenByGebruiker(bondsnummer, gebruikerId, refresh);
            return lidmaatschappen;
        }


        /*
		public SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false)
		{
			//CheckDatabase();

			SpelersProfiel profiel = new SpelersProfiel();


			using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

			using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

			using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

			using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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
			using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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


            vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh, null);

            return vereniging;
        }

        /*
        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

        public ClubCloud_Accommodatie GetAccommodatieById(string bondsnummer, Guid accommodatieId, bool refresh)
        {
            return GetAccommodatieById(bondsnummer, accommodatieId, refresh, null);
        }

        #endregion

        #region Afhangen

        #region Vereniging

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
                    return GetVerenigingById(bondsnummer, address.ParentId.Value, refresh);
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
            vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh);
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
                afhang.BaanBegin = TimeSpan.FromHours(8);
                afhang.BaanEinde = TimeSpan.FromHours(23);
                afhang.VerenigingId = verenigingId;
                 ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, verenigingId, false);
                if(vereniging != null)
                    afhang.ClubCloud_Vereniging = vereniging;

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

        #endregion

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

            ClubCloud_Reservering reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);

            if (reservering != null || refresh)
            {
                ValidateBondsnummer(ref bondsnummer, verenigingId);
                if (reservering.Gebruiker_Een != null && reservering.Gebruiker_Een.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Een = GebruikerById(bondsnummer, reservering.Gebruiker_Een.Value, false);
                    gebruikers.Add(Gebruiker_Een);
                }

                if (reservering.Gebruiker_Twee != null && reservering.Gebruiker_Twee.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Twee = GebruikerById(bondsnummer, reservering.Gebruiker_Twee.Value, false);
                    gebruikers.Add(Gebruiker_Twee);
                }

                if (reservering.Gebruiker_Drie != null && reservering.Gebruiker_Drie.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Drie = GebruikerById(bondsnummer, reservering.Gebruiker_Drie.Value, false);
                    gebruikers.Add(Gebruiker_Drie);
                }

                if (reservering.Gebruiker_Vier != null && reservering.Gebruiker_Vier.HasValue)
                {
                    ClubCloud_Gebruiker Gebruiker_Vier = GebruikerById(bondsnummer, reservering.Gebruiker_Vier.Value, false);
                    gebruikers.Add(Gebruiker_Vier);
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

            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh, null);

            List<ClubCloud_Baan> banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId == vereniging.AccommodatieId.Value).ToList();

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

            DateTime today = DateTime.Today;
            DateTime tomorrow = DateTime.Today.AddDays(1);
            reserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => (r.Gebruiker_Een.Value == gebruiker.Id || r.Gebruiker_Twee.Value == gebruiker.Id || r.Gebruiker_Drie.Value == gebruiker.Id || r.Gebruiker_Vier.Value == gebruiker.Id) && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
            return reserveringen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="date"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Reservering> GetReserveringenByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            DateTime today = date;
            DateTime tomorrow = today.AddDays(1);
            reserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
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

            reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);

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

            reserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baanId && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();

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
                ClubCloud_Reservering reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);
                beheerModel.ClubCloud_Reserveringen.Remove(reservering);
                beheerModel.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        #region Banen

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh);

            if (vereniging != null)
            {
                banen = GetBanenByAccommodatieId(bondsnummer, vereniging.AccommodatieId.Value, refresh);
                /*
                banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId == vereniging.AccommodatieId.Value).ToList();

                if (banen == null || banen.Count == 0 || refresh)
                {
                    
                    //banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId.Value == vereniging.AccommodatieId.Value).ToList();
                }
                */
            }
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
            banen = GetBanenByAccommodatieId(bondsnummer, accommodatieId, refresh);
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
            baan = GetBaanById(bondsnummer, baanId, refresh);
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
            return GetBaanSchemaByDate(bondsnummer, verenigingId, DateTime.Now, refresh);
            /*
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            List<ClubCloud_Baan> banen = GetBanenByVerenigingId(bondsnummer, verenigingId, refresh);

            if (banen != null && banen.Count > 0 || refresh)
            {
                Month maand = (Month) Enum.Parse(typeof(Model.Month), DateTime.Now.Month.ToString());
                foreach (ClubCloud_Baan baan in banen)
                {
                    List<ClubCloud_Baanschema> schemaperbaan = beheerModel.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id && b.VerenigingId == verenigingId && b.Beschikbaar == true && b.MaandBegin <= maand && b.MaandEinde >= maand).ToList();
                    if(schemaperbaan != null && schemaperbaan.Count > 0)
                        baanschema.AddRange(schemaperbaan);
                }
            }

            return baanschema;
            */
        }

        public List<ClubCloud_Baanschema> GetBaanSchemaByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false)
        {
            if (date == null)
                date = DateTime.Now;

            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            List<ClubCloud_Baan> banen = GetBanenByVerenigingId(bondsnummer, verenigingId, refresh);

            if (banen != null && banen.Count > 0 || refresh)
            {
                Month maand = (Month)Enum.Parse(typeof(Model.Month), date.Month.ToString());
                foreach (ClubCloud_Baan baan in banen)
                {
                    List<ClubCloud_Baanschema> schemaperbaan = beheerModel.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id && b.VerenigingId == verenigingId && b.Beschikbaar == true && b.MaandBegin <= maand && b.MaandEinde >= maand).ToList();
                    if (schemaperbaan != null && schemaperbaan.Count > 0)
                        baanschema.AddRange(schemaperbaan);
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
            List<ClubCloud_Baan> banen = GetBanenByAccommodatieId(bondsnummer, accommodatieId, refresh);

            if (banen != null && banen.Count > 0 || refresh)
            {

                //if (beheerModel == null)
                //{
                //    beheerModel = new Model.BeheerContainer(GetConnectionString());
                //}

                //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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
        public List<ClubCloud_Baanblok> GetBaanblokkenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh)
        {
            List<ClubCloud_Baanblok> baanblokken = new List<ClubCloud_Baanblok>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            baanblokken = GetBaanblokkenByAccommodatieId(bondsnummer, accommodatieId, refresh);

            return baanblokken;
        }

        public ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baansoortId, bool refresh)
        {
            ClubCloud_Baansoort baansoort = new ClubCloud_Baansoort();
            ValidateBondsnummer(ref bondsnummer, verenigingId);

            baansoort = GetBaansoortById(bondsnummer, baansoortId, refresh);

            return baansoort;
        }

        public ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baantypeId, bool refresh)
        {
            ClubCloud_Baantype baantype = new ClubCloud_Baantype();
            ValidateBondsnummer(ref bondsnummer, verenigingId);

            baantype = GetBaantypeById(bondsnummer, baantypeId, refresh);

            return baantype;
        }

        #endregion

        public List<ClubCloud_Gebruiker> GetGebruikersBySearch(string bondsnummer, string prefixText, int count, bool refresh = false)
        {
            string fts = BeheerFullTextInterceptor.Fts(prefixText);


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            nationaliteiten = beheerModel.ClubCloud_Nationaliteiten.Where(n => n.Naam != string.Empty).ToList<ClubCloud_Nationaliteit>();

            if (nationaliteiten == null && nationaliteiten.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                nationaliteiten = beheerModel.ClubCloud_Nationaliteiten.Where(n => n.Naam != string.Empty).ToList<ClubCloud_Nationaliteit>();
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


            nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Find(nationaliteitId);

            if (nationaliteit == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Find(nationaliteitId);
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
        private ClubCloud_District GetDistrictById(string bondsnummer, Guid districtId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_District district = new ClubCloud_District();

            district = beheerModel.ClubCloud_Districten.Find(districtId);

            if (district == null || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                            ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false);
                                            district.ClubCloud_Regio = regio;
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
                                            ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false);
                                            district.ClubCloud_Regio = regio;
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
                district = beheerModel.ClubCloud_Districten.Find(districtId);
            }
            return district;
        }

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="regioId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictByRegio(string bondsnummer, Guid regioId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_District district = new ClubCloud_District();

            district = beheerModel.ClubCloud_Districten.SingleOrDefault(d => d.RegioId == regioId);

            if (district == null || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                            ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false);
                                            district.ClubCloud_Regio = regio;
                                            district.RegioId = entity.sgt_regioid.Value;
                                        }

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
                                            ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false);
                                            district.ClubCloud_Regio = regio;
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
                district = beheerModel.ClubCloud_Districten.SingleOrDefault(d => d.RegioId == regioId);
            }
            return district;
        }

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_District> GetDistricten(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_District> districten = new List<ClubCloud_District>();

            districten = beheerModel.ClubCloud_Districten.ToList();

            if (districten == null && districten.Count == 0 || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                            ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false);
                                            district.ClubCloud_Regio = regio;
                                            district.RegioId = entity.sgt_regioid.Value;
                                        }

                                        district.Actief = entity.statuscode.name;
                                        beheerModel.ClubCloud_Districten.Add(district);
                                        //districten.Add(district);
                                    }
                                    else
                                    {
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.Naam = entity.sgt_alg_district1;
                                        district.Omschrijving = entity.sgt_omschrijving;
                                        district.Beschrijving = entity.sgt_beschrijving;

                                        if (entity.sgt_regioid != null)
                                        {
                                            ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false);
                                            district.ClubCloud_Regio = regio;
                                            district.RegioId = entity.sgt_regioid.Value;
                                        }

                                        district.Actief = entity.statuscode.name;
                                        //districten.Add(district);
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                districten = beheerModel.ClubCloud_Districten.ToList();
            }
            return districten;
        }

        #endregion

        #region Regio

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="regioId"></param>
        /// <param name="naam"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioById(string bondsnummer, Guid regioId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Regio regio = new ClubCloud_Regio();

            regio = beheerModel.ClubCloud_Regios.Find(regioId);

            if (regio == null && refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "accountid", Operator = ConditionOperator.Equal, Values = new object[1] { regioId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                                foreach (account entity in entities)
                                {
                                    regio = beheerModel.ClubCloud_Regios.Find(entity.accountid.Value);

                                    if (regio == null)
                                    {
                                        regio = beheerModel.ClubCloud_Regios.Create();
                                        regio.Id = entity.accountid.Value;
                                        regio.Naam = string.IsNullOrWhiteSpace(entity.name) ? "" : entity.name; //entity.name;
                                        regio.EmailKNLTB = string.IsNullOrWhiteSpace(entity.emailaddress1) ? "" : entity.emailaddress1; //entity.emailaddress1;
                                        regio.TelefoonOverdag = string.IsNullOrWhiteSpace(entity.telephone1) ? "" : entity.telephone1; //entity.telephone1;
                                        regio.TelefoonAvond = string.IsNullOrWhiteSpace(entity.telephone2) ? "" : entity.telephone2; //entity.telephone2;
                                        regio.Fax = string.IsNullOrWhiteSpace(entity.fax) ? "" : entity.fax; //entity.fax;

                                        if (entity.address1_addressid != null)
                                        {
                                            ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(bezoek);
                                            //vereniging.ClubCloud_Address.Add(bezoek);
                                        }
                                        if (entity.address2_addressid != null)
                                        {
                                            ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(post);
                                            //vereniging.ClubCloud_Address.Add(post);
                                        }
                                        
                                        regio.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Regios.Add(regio);

                                    }
                                    else
                                    {
                                        regio.Naam = string.IsNullOrWhiteSpace(entity.name) ? "" : entity.name; //entity.name;
                                        regio.EmailKNLTB = string.IsNullOrWhiteSpace(entity.emailaddress1) ? "" : entity.emailaddress1; //entity.emailaddress1;
                                        regio.TelefoonOverdag = string.IsNullOrWhiteSpace(entity.telephone1) ? "" : entity.telephone1; //entity.telephone1;
                                        regio.TelefoonAvond = string.IsNullOrWhiteSpace(entity.telephone2) ? "" : entity.telephone2; //entity.telephone2;
                                        regio.Fax = string.IsNullOrWhiteSpace(entity.fax) ? "" : entity.fax; //entity.fax;

                                        if (entity.address1_addressid != null)
                                        {
                                            ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(bezoek);
                                            //vereniging.ClubCloud_Address.Add(bezoek);
                                        }
                                        if (entity.address2_addressid != null)
                                        {
                                            ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(post);
                                            //vereniging.ClubCloud_Address.Add(post);
                                        }

                                        regio.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();

                                    /*
                                    if (entity.address1_addressid != null)
                                    {
                                        ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                                        regio.ClubCloud_Address.Add(bezoek);
                                        //vereniging.ClubCloud_Address.Add(bezoek);
                                    }
                                    if (entity.address2_addressid != null)
                                    {
                                        ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                                        regio.ClubCloud_Address.Add(post);
                                        //vereniging.ClubCloud_Address.Add(post);
                                    }
                                    beheerModel.SaveChanges();
                                    */
                                }
                            }
                        }
                    }

                }
                regio = beheerModel.ClubCloud_Regios.Find(regioId);
            }
            return regio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Regio> GetRegios(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Regio> regios = new List<ClubCloud_Regio>();

            regios = beheerModel.ClubCloud_Regios.ToList();

            if (regios == null || regios.Count == 0 || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_regio", Operator = ConditionOperator.Equal, Values = new object[1] { true } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                                foreach (account entity in entities)
                                {
                                    ClubCloud_Regio regio = beheerModel.ClubCloud_Regios.Find(entity.accountid.Value);

                                    if (regio == null)
                                    {
                                        regio = beheerModel.ClubCloud_Regios.Create();
                                        regio.Id = entity.accountid.Value;
                                        regio.Naam = string.IsNullOrWhiteSpace(entity.name) ? "" : entity.name; //entity.name;
                                        regio.EmailKNLTB = string.IsNullOrWhiteSpace(entity.emailaddress1) ? "" : entity.emailaddress1; //entity.emailaddress1;
                                        regio.TelefoonOverdag = string.IsNullOrWhiteSpace(entity.telephone1) ? "" : entity.telephone1; //entity.telephone1;
                                        regio.TelefoonAvond = string.IsNullOrWhiteSpace(entity.telephone2) ? "" : entity.telephone2; //entity.telephone2;
                                        regio.Fax = string.IsNullOrWhiteSpace(entity.fax) ? "" : entity.fax; //entity.fax;

                                        if (entity.address1_addressid != null)
                                        {
                                            ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(bezoek);
                                            //vereniging.ClubCloud_Address.Add(bezoek);
                                        }
                                        if (entity.address2_addressid != null)
                                        {
                                            ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(post);
                                            //vereniging.ClubCloud_Address.Add(post);
                                        }
                                        
                                        regio.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Regios.Add(regio);
                                    }
                                    else
                                    {
                                        regio.Naam = string.IsNullOrWhiteSpace(entity.name) ? "" : entity.name; //entity.name;
                                        regio.EmailKNLTB = string.IsNullOrWhiteSpace(entity.emailaddress1) ? "" : entity.emailaddress1; //entity.emailaddress1;
                                        regio.TelefoonOverdag = string.IsNullOrWhiteSpace(entity.telephone1) ? "" : entity.telephone1; //entity.telephone1;
                                        regio.TelefoonAvond = string.IsNullOrWhiteSpace(entity.telephone2) ? "" : entity.telephone2; //entity.telephone2;
                                        regio.Fax = string.IsNullOrWhiteSpace(entity.fax) ? "" : entity.fax; //entity.fax;
                                        
                                        if (entity.address1_addressid != null)
                                        {
                                            ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(bezoek);
                                            //vereniging.ClubCloud_Address.Add(bezoek);
                                        }
                                        if (entity.address2_addressid != null)
                                        {
                                            ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                                            regio.ClubCloud_Address.Add(post);
                                            //vereniging.ClubCloud_Address.Add(post);
                                        }
                                        
                                        regio.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();
                                    /*
                                    if (entity.address1_addressid != null)
                                    {
                                        ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                                        regio.ClubCloud_Address.Add(bezoek);
                                        //vereniging.ClubCloud_Address.Add(bezoek);
                                    }
                                    if (entity.address2_addressid != null)
                                    {
                                        ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                                        regio.ClubCloud_Address.Add(post);
                                        //vereniging.ClubCloud_Address.Add(post);
                                    }
                                    beheerModel.SaveChanges();
                                    */
                                }
                            }
                        }
                    }
                }
                regios = beheerModel.ClubCloud_Regios.ToList();
            }
            return regios;
        }

        #endregion

        #region Rechtsvorm

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="rechtsvormId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Rechtsvorm GetRechtsvormById(string bondsnummer, Guid rechtsvormId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Rechtsvorm rechtsvorm = new ClubCloud_Rechtsvorm();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                rechtsvorm = beheerModel.ClubCloud_Rechtsvormen.Find(rechtsvormId);
            }
            return rechtsvorm;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Rechtsvorm> GetRechtsvormen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Rechtsvorm> rechtsvormen = new List<ClubCloud_Rechtsvorm>();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //rechtsvormen.Add(rechtsvorm);
                                    }
                                    else
                                    {
                                        rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                        rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                        rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                        rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                        rechtsvorm.Code = entity.sgt_verkorte_code;
                                        rechtsvorm.Actief = entity.statuscode.name;
                                        //rechtsvormen.Add(rechtsvorm);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                rechtsvormen = beheerModel.ClubCloud_Rechtsvormen.ToList();
            }
            return rechtsvormen;
        }

        #endregion

        #region Functie

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functieId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Functie GetFunctieById(int bondsnummer, Guid functieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return GetFunctieById(bondsnummer.ToString(), functieId, false, settings);
        }
        */

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Functie GetFunctieById(string bondsnummer, Guid functieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Functie functie = new ClubCloud_Functie();

            functie = beheerModel.ClubCloud_Functies.Find(functieId);

            if (functie == null || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                functie = beheerModel.ClubCloud_Functies.Find(functieId);
            }
            return functie;
        }

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        private List<ClubCloud_Functie> GetFuncties(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

            functies = beheerModel.ClubCloud_Functies.ToList();

            if (functies != null && functies.Count == 0 || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //functies.Add(functie);
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
                                        //functies.Add(functie);
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                functies = beheerModel.ClubCloud_Functies.ToList();
            }
            return functies;
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
        private ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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

                                    //GetClubCloudSettings(vereniging.Nummer);
                                }
                            }
                        }
                    }
                }
                vereniging = beheerModel.ClubCloud_Verenigingen.Find(verenigingId);
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
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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

                                    beheerModel.SaveChanges();

                                    //GetClubCloudSettings(vereniging.Nummer);
                                }
                            }
                        }
                    }
                }
                vereniging = beheerModel.ClubCloud_Verenigingen.SingleOrDefault(l => l.Nummer == verenigingNummer);
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
                ClubCloud_District district = GetDistrictById(bondsnummer, entity.sgt_districtid.Value, false, settings);
                vereniging.ClubCloud_District = district;
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
                ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value, false, settings);
                vereniging.ClubCloud_Rechtsvorm = rechtsvorm;
                vereniging.RechtsvormId = entity.sgt_rechtsvormid.Value;
            }

            if (entity.sgt_hoofdaccomodatieid != null)
            {
                ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_hoofdaccomodatieid.Value, false, settings);
                vereniging.ClubCloud_Accommodatie = Accommodatie;
                vereniging.AccommodatieId = entity.sgt_hoofdaccomodatieid.Value;
            }

            if (entity.address1_addressid != null)
            {
                ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                vereniging.ClubCloud_Address.Add(bezoek);
            }
            if (entity.address2_addressid != null)
            {
                ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                vereniging.ClubCloud_Address.Add(post);
            }

            if (entity.parentaccountid != null)
            {
                ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.parentaccountid.Value, false, settings);
                vereniging.ClubCloud_Regio = regio;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="addressId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private async Task GetAddressByIdAsync(string bondsnummer, Guid addressId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            GetAddressById(bondsnummer, addressId, false, settings);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="addressId"></param>
        /// <param name="refresh"></param>
        /// <returns>ClubCloud_Address</returns>
        private ClubCloud_Address GetAddressById(string bondsnummer, Guid addressId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Address address = new ClubCloud_Address();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                address = beheerModel.ClubCloud_Addresses.Find(addressId);
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
        private List<ClubCloud_Address> GetAddressByParent(string bondsnummer, Guid parentId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Address> addresses = new List<ClubCloud_Address>();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //addresses.Add(address);

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
                                        //addresses.Add(address);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                addresses = beheerModel.ClubCloud_Addresses.Where(a => a.ParentId == parentId).ToList();
            }

            return addresses;
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
        private List<ClubCloud_Functionaris> GetFunctionarissenByFunctie(string bondsnummer, Guid VerenigingId, Guid FunctieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        //ClubCloud_Functionaris tobeupdated = new ClubCloud_Functionaris();
                                        EntityToFunctionaris(entity, functionaris, bondsnummer, settings);
                                        //beheerModel.Entry(functionaris).CurrentValues.SetValues(tobeupdated);                                    

                                        //EntityToFunctionaris(entity, functionaris, bondsnummer);
                                        //functionarissen.Add(functionaris);
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.FunctieId == FunctieId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
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

        private async Task GetFunctionarissenByGebruikerAsync(string bondsnummer, List<BusinessEntity> entities)
        {
            foreach (contact entity in entities)
            {
                if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                {
                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                    List<ClubCloud_Functionaris> functionarissen = GetFunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                    foreach (ClubCloud_Functionaris functionaris in functionarissen)
                    {
                        gebruiker.ClubCloud_Functionaris.Add(functionaris);
                    }
                }
            }
        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return GetFunctionarissenByGebruiker(int.Parse(bondsnummer), gebruikerId, refresh, settings);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByVereniging(int bondsnummer, Guid VerenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return GetFunctionarissenByVereniging(bondsnummer.ToString(), VerenigingId, refresh, settings);
        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByVereniging(string bondsnummer, Guid VerenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //functionaris = beheerModel.ClubCloud_Functionarissen.Create();
                                        //functionaris.Id = entity.sgt_alg_functionarisid.Value;
                                        functionaris = new ClubCloud_Functionaris();
                                        EntityToFunctionaris(entity, functionaris, bondsnummer, settings);

                                        //beheerModel.ClubCloud_Functionarissen.Add(functionaris);
                                    }
                                    else
                                    {
                                        EntityToFunctionaris(entity, functionaris, bondsnummer, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
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
            //CheckDatabase();
            ClubCloud_Functionaris updatable = functionaris;


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                ClubCloud_Functie functie = GetFunctieById(bondsnummer, entity.sgt_functieid.Value, false, settings);
                functionaris.ClubCloud_Functie = functie;
                functionaris.FunctieId = entity.sgt_functieid.Value;
            }

            if (entity.sgt_functionarisid != null)
            {
                ClubCloud_Gebruiker gebruiker = GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, false, settings);
                functionaris.ClubCloud_Gebruiker = gebruiker;
                functionaris.GebruikerId = entity.sgt_functionarisid.Value;
            }

            ClubCloud_Vereniging vereniging = null;
            if (entity.sgt_basisorganisatieid != null)
            {
                vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                functionaris.ClubCloud_Vereniging = vereniging;
                functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;
            }

            if (entity.sgt_bestuursorgaanid != null)
            {
                ClubCloud_Bestuursorgaan orgaan = GetBestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, false, settings);
                functionaris.ClubCloud_Bestuursorgaan = orgaan;
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
        private List<ClubCloud_Functionaris> GetFunctionarissenByGebruiker(int bondsnummer, Guid gebruikerId, bool refresh, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        EntityToFunctionaris(entity, functionaris, bondsnummer.ToString(), settings);
                                        //functionarissen.Add(functionaris);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.GebruikerId == gebruikerId).ToList();// && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
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
        private ClubCloud_Bestuursorgaan GetBestuursOrgaanById(string bondsnummer, Guid bestuursorgaanId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Bestuursorgaan bestuursorgaan = new ClubCloud_Bestuursorgaan();

            bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(bestuursorgaanId);

            if (bestuursorgaan == null || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        bestuursorgaan.Beschrijving = string.IsNullOrWhiteSpace(entity.sgt_beschrijving) ? "" : entity.sgt_beschrijving;

                                        if (entity.sgt_basisorganisatieid != null)
                                        {
                                            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                            if (vereniging != null)
                                                bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                            bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        }

                                        if (entity.sgt_typebestuursorgaanid != null)
                                        {
                                            bestuursorgaan.Groep = string.IsNullOrWhiteSpace(entity.sgt_typebestuursorgaanid.name) ? "" : entity.sgt_typebestuursorgaanid.name;
                                        }
                                        else
                                        {
                                            bestuursorgaan.Groep = "";
                                        }
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                        beheerModel.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                    }
                                    else
                                    {
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = string.IsNullOrWhiteSpace(entity.sgt_beschrijving) ? "" : entity.sgt_beschrijving;

                                        if (entity.sgt_basisorganisatieid != null)
                                        {
                                            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                            if (vereniging != null)
                                                bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                            bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        }

                                        if (entity.sgt_typebestuursorgaanid != null)
                                        {
                                            bestuursorgaan.Groep = string.IsNullOrWhiteSpace(entity.sgt_typebestuursorgaanid.name) ? "" : entity.sgt_typebestuursorgaanid.name;
                                        }
                                        else
                                        {
                                            bestuursorgaan.Groep = "";
                                        }
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(bestuursorgaanId);
            }
            return bestuursorgaan;
        }

        /// <summary>
        /// sgt_alg_bestuursorgaan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> GetBestuursOrgaanByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.Where(b => b.VerenigingId == verenigingId).ToList();

            if (bestuursorganen != null && bestuursorganen.Count == 0 || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        bestuursorgaan.Beschrijving = string.IsNullOrWhiteSpace(entity.sgt_beschrijving) ? "" : entity.sgt_beschrijving;

                                        if (entity.sgt_basisorganisatieid != null)
                                        {
                                            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                            if (vereniging != null)
                                                bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                            bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        }

                                        if (entity.sgt_typebestuursorgaanid != null)
                                        {
                                            bestuursorgaan.Groep = string.IsNullOrWhiteSpace(entity.sgt_typebestuursorgaanid.name) ? "" : entity.sgt_typebestuursorgaanid.name;
                                        }
                                        else
                                        {
                                            bestuursorgaan.Groep = "";
                                        }
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                        beheerModel.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                        //bestuursorganen.Add(bestuursorgaan);
                                    }
                                    else
                                    {
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = string.IsNullOrWhiteSpace(entity.sgt_beschrijving) ? "" : entity.sgt_beschrijving;

                                        if (entity.sgt_basisorganisatieid != null)
                                        {
                                            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                            if (vereniging != null)
                                                bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                            bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        }

                                        if (entity.sgt_typebestuursorgaanid != null)
                                        {
                                            bestuursorgaan.Groep = string.IsNullOrWhiteSpace(entity.sgt_typebestuursorgaanid.name) ? "" : entity.sgt_typebestuursorgaanid.name;
                                        }
                                        else
                                        {
                                            bestuursorgaan.Groep = "";
                                        }
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }

                }
                bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.Where(b => b.VerenigingId == verenigingId).ToList();
            }

            return bestuursorganen;
        }

        /// <summary>
        /// sgt_alg_bestuursorgaan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> GetBestuursOrganen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.ToList();

            if (bestuursorganen != null && bestuursorganen.Count == 0 || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        bestuursorgaan.Beschrijving = string.IsNullOrWhiteSpace(entity.sgt_beschrijving) ? "" : entity.sgt_beschrijving;

                                        if (entity.sgt_basisorganisatieid != null)
                                        {
                                            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                            if (vereniging != null)
                                                bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                            bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        }

                                        if (entity.sgt_typebestuursorgaanid != null)
                                        {
                                            bestuursorgaan.Groep = string.IsNullOrWhiteSpace(entity.sgt_typebestuursorgaanid.name) ? "" : entity.sgt_typebestuursorgaanid.name;
                                        }
                                        else
                                        {
                                            bestuursorgaan.Groep = "";
                                        }

                                        //bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                        beheerModel.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                        //bestuursorganen.Add(bestuursorgaan);
                                    }
                                    else
                                    {
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = string.IsNullOrWhiteSpace(entity.sgt_beschrijving) ? "" : entity.sgt_beschrijving;

                                        if (entity.sgt_basisorganisatieid != null)
                                        {
                                            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                            if (vereniging != null)
                                                bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                            bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        }

                                        if (entity.sgt_typebestuursorgaanid != null)
                                        {
                                            bestuursorgaan.Groep = string.IsNullOrWhiteSpace(entity.sgt_typebestuursorgaanid.name) ? "" : entity.sgt_typebestuursorgaanid.name;
                                        }
                                        else
                                        {
                                            bestuursorgaan.Groep = "";
                                        }
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.ToList();
            }
            return bestuursorganen;
        }

        #endregion

        #region Baan

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            banen = beheerModel.ClubCloud_Banen.ToList();

            if (banen == null || banen.Count == 0 || refresh)
            {
                banen = new List<ClubCloud_Baan>();

                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);


                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan", out moreRecords, ref pageNum);

                                foreach (sgt_alg_baan entity in entities)
                                {
                                    ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.Find(entity.sgt_alg_baanid.Value);

                                    if (baan == null)
                                    {
                                        baan = beheerModel.ClubCloud_Banen.Create();
                                        baan.Id = entity.sgt_alg_baanid.Value;
                                        baan.Naam = entity.sgt_alg_baan1;

                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if(accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if(baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }

                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Banen.Add(baan);
                                    }
                                    else
                                    {
                                        baan.Naam = entity.sgt_alg_baan1;
                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }

                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                banen = beheerModel.ClubCloud_Banen.ToList();
            }
            return banen;
        }

        //TODO update banenaantal accommodaatie als ze niet gelijk zijn
        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baansoortId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, accommodatieId);

            banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId.Value == accommodatieId).ToList();

            if (banen == null || banen.Count == 0 || banen.Count != accommodatie.BanenAantal || refresh)
            {
                banen = new List<ClubCloud_Baan>();
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            ClubCloud_Accommodatie Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(accommodatieId);
                            bool moreRecords = true;
                            int pageNum = 1;
                            int banen_totaal = 0;

                            while (moreRecords)
                            {
                                //<condition attribute="sgt_alg_accommodatieid" operator="eq" uiname="Kampong" uitype="sgt_alg_accommodatie" value="{11029F99-522E-4FC4-A86D-694E003F8BB2}"/>
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, uiname = Accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { Accommodatie.Id } };
                                //<filter type="and">
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                                //<link-entity name="sgt_alg_accommodatie" from="sgt_alg_accommodatieid" to="sgt_accommodatieid" alias="aa">
                                LinkEntity link = new LinkEntity { LinkToEntityName = "sgt_alg_accommodatie", LinkFromAttributeName = "sgt_accommodatieid", LinkToAttributeName = "sgt_alg_accommodatieid", LinkCriteria = expression };
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan", out moreRecords, ref pageNum, null, link);

                                foreach (sgt_alg_baan entity in entities)
                                {
                                    banen_totaal++;

                                    ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.Find(entity.sgt_alg_baanid.Value);

                                    if (baan == null)
                                    {
                                        baan = beheerModel.ClubCloud_Banen.Create();
                                        baan.Id = entity.sgt_alg_baanid.Value;
                                        baan.Naam = entity.sgt_alg_baan1;
                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }


                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Banen.Add(baan);
                                    }
                                    else
                                    {
                                        baan.Naam = entity.sgt_alg_baan1;
                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }

                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                    }
                                    beheerModel.SaveChanges();
                                }
                            }

                            Accommodatie.BanenAantal = banen_totaal;
                            beheerModel.SaveChanges();
                        }
                    }
                }
                banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId.Value == accommodatieId).ToList();
            }
            return banen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Baan GetBaanById(string bondsnummer, Guid baanId, bool refresh = false)
        {
            ClubCloud_Baan baan = new ClubCloud_Baan();
            baan = beheerModel.ClubCloud_Banen.Find(baanId);

            if (baan == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_baanid", Operator = ConditionOperator.Equal, Values = new object[1] { baanId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_baan entity in entities)
                                {
                                    baan = beheerModel.ClubCloud_Banen.Find(entity.sgt_alg_baanid.Value);

                                    if (baan == null)
                                    {
                                        baan = beheerModel.ClubCloud_Banen.Create();
                                        baan.Id = entity.sgt_alg_baanid.Value;
                                        baan.Naam = entity.sgt_alg_baan1;
                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }

                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Banen.Add(baan);
                                    }
                                    else
                                    {
                                        baan.Naam = entity.sgt_alg_baan1;
                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }

                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baan = beheerModel.ClubCloud_Banen.Find(baanId);
            }
            return baan;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanBlokken(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baanblok> baanblokken = new List<ClubCloud_Baanblok>();

            baanblokken = beheerModel.ClubCloud_Baanblokken.ToList();

            if (baanblokken == null || baanblokken.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baanblok", out moreRecords, ref pageNum);

                                foreach (sgt_alg_baanblok entity in entities)
                                {
                                    ClubCloud_Baanblok baanblok = beheerModel.ClubCloud_Baanblokken.Find(entity.sgt_alg_baanblokid.Value);

                                    if (baanblok == null)
                                    {
                                        baanblok = beheerModel.ClubCloud_Baanblokken.Create();
                                        baanblok.Id = entity.sgt_alg_baanblokid.Value;
                                        baanblok.Naam = entity.sgt_alg_baanblok1;

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baanblok.ClubCloud_Accommodatie = accommodatie;
                                            baanblok.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baansoortid != null)
                                        {
                                            ClubCloud_Baansoort baansoort = GetBaansoortById(bondsnummer, entity.sgt_baansoortid.Value, false);
                                            if(baansoort != null)
                                                baanblok.ClubCloud_Baansoort = baansoort;
                                            baanblok.BaansoortId = entity.sgt_baansoortid.Value;
                                        }

                                        if (entity.sgt_baantypeid != null)
                                        {
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            if(baantype != null)
                                                baanblok.ClubCloud_Baantype = baantype;
                                            baanblok.BaantypeId = entity.sgt_baantypeid.Value;
                                        }

                                        if (entity.sgt_verlichting != null)
                                        {
                                            baanblok.Verlichting = entity.sgt_verlichting.Value;
                                        }

                                        if (entity.sgt_locatie_bb != null)
                                        {
                                            baanblok.Locatie = entity.sgt_locatie_bb.name; ;
                                        }

                                        baanblok.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Baanblokken.Add(baanblok);
                                    }
                                    else
                                    {
                                        baanblok.Naam = entity.sgt_alg_baanblok1;

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baanblok.ClubCloud_Accommodatie = accommodatie;
                                            baanblok.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baansoortid != null)
                                        {
                                            ClubCloud_Baansoort baansoort = GetBaansoortById(bondsnummer, entity.sgt_baansoortid.Value, false);
                                            if (baansoort != null)
                                                baanblok.ClubCloud_Baansoort = baansoort;
                                            baanblok.BaansoortId = entity.sgt_baansoortid.Value;
                                        }

                                        if (entity.sgt_baantypeid != null)
                                        {
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            if (baantype != null)
                                                baanblok.ClubCloud_Baantype = baantype;
                                            baanblok.BaantypeId = entity.sgt_baantypeid.Value;
                                        }

                                        if (entity.sgt_verlichting != null)
                                        {
                                            baanblok.Verlichting = entity.sgt_verlichting.Value;
                                        }

                                        if (entity.sgt_locatie_bb != null)
                                        {
                                            baanblok.Locatie = entity.sgt_locatie_bb.name; ;
                                        }

                                        baanblok.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baanblokken = beheerModel.ClubCloud_Baanblokken.ToList();
            }

            return baanblokken;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baanblokId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Baanblok GetBaanblokById(string bondsnummer, Guid baanblokId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Baanblok baanblok = new ClubCloud_Baanblok();

            baanblok = beheerModel.ClubCloud_Baanblokken.Find(baanblokId);

            if (baanblok == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_baanblokid", Operator = ConditionOperator.Equal, Values = new object[1] { baanblokId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baanblok", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_baanblok entity in entities)
                                {
                                    baanblok = beheerModel.ClubCloud_Baanblokken.Find(entity.sgt_alg_baanblokid.Value);

                                    if (baanblok == null)
                                    {
                                        baanblok = beheerModel.ClubCloud_Baanblokken.Create();
                                        baanblok.Id = entity.sgt_alg_baanblokid.Value;
                                        baanblok.Naam = entity.sgt_alg_baanblok1;

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baanblok.ClubCloud_Accommodatie = accommodatie;
                                            baanblok.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baansoortid != null)
                                        {
                                            ClubCloud_Baansoort baansoort = GetBaansoortById(bondsnummer, entity.sgt_baansoortid.Value, false);
                                            if (baansoort != null)
                                                baanblok.ClubCloud_Baansoort = baansoort;
                                            baanblok.BaansoortId = entity.sgt_baansoortid.Value;
                                        }

                                        if (entity.sgt_baantypeid != null)
                                        {
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            if (baantype != null)
                                                baanblok.ClubCloud_Baantype = baantype;
                                            baanblok.BaantypeId = entity.sgt_baantypeid.Value;
                                        }

                                        if (entity.sgt_verlichting != null)
                                        {
                                            baanblok.Verlichting = entity.sgt_verlichting.Value;
                                        }

                                        if (entity.sgt_locatie_bb != null)
                                        {
                                            baanblok.Locatie = entity.sgt_locatie_bb.name; ;
                                        }

                                        baanblok.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Baanblokken.Add(baanblok);
                                    }
                                    else
                                    {
                                        baanblok.Naam = entity.sgt_alg_baanblok1;

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baanblok.ClubCloud_Accommodatie = accommodatie;
                                            baanblok.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baansoortid != null)
                                        {
                                            ClubCloud_Baansoort baansoort = GetBaansoortById(bondsnummer, entity.sgt_baansoortid.Value, false);
                                            if (baansoort != null)
                                                baanblok.ClubCloud_Baansoort = baansoort;
                                            baanblok.BaansoortId = entity.sgt_baansoortid.Value;
                                        }

                                        if (entity.sgt_baantypeid != null)
                                        {
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            if (baantype != null)
                                                baanblok.ClubCloud_Baantype = baantype;
                                            baanblok.BaantypeId = entity.sgt_baantypeid.Value;
                                        }

                                        if (entity.sgt_verlichting != null)
                                        {
                                            baanblok.Verlichting = entity.sgt_verlichting.Value;
                                        }

                                        if (entity.sgt_locatie_bb != null)
                                        {
                                            baanblok.Locatie = entity.sgt_locatie_bb.name; ;
                                        }

                                        baanblok.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baanblok = beheerModel.ClubCloud_Baanblokken.Find(baanblokId);
            }

            return baanblok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="accommodatieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokkenByAccommodatieId(string bondsnummer, Guid accommodatieId, bool refresh)
        {
            List<ClubCloud_Baanblok> baanblokken = new List<ClubCloud_Baanblok>();

            baanblokken = beheerModel.ClubCloud_Baanblokken.Where(b => b.AccommodatieId.Value == accommodatieId).ToList();

            if (baanblokken == null || baanblokken.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
                            ClubCloud_Accommodatie Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(accommodatieId);
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accommodatieid", Operator = ConditionOperator.Equal, uiname = Accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { Accommodatie.Id } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baanblok", out moreRecords, ref pageNum, expression);


                                foreach (sgt_alg_baanblok entity in entities)
                                {
                                    ClubCloud_Baanblok baanblok = beheerModel.ClubCloud_Baanblokken.Find(entity.sgt_alg_baanblokid.Value);

                                    if (baanblok == null)
                                    {
                                        baanblok = beheerModel.ClubCloud_Baanblokken.Create();
                                        baanblok.Id = entity.sgt_alg_baanblokid.Value;
                                        baanblok.Naam = entity.sgt_alg_baanblok1;

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false);
                                            baanblok.ClubCloud_Accommodatie = accommodatie;
                                            baanblok.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baansoortid != null)
                                        {
                                            ClubCloud_Baansoort baansoort = GetBaansoortById(bondsnummer, entity.sgt_baansoortid.Value, false);
                                            baanblok.ClubCloud_Baansoort = baansoort;
                                            baanblok.BaansoortId = entity.sgt_baansoortid.Value;
                                        }

                                        if (entity.sgt_baantypeid != null)
                                        {
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            baanblok.ClubCloud_Baantype = baantype;
                                            baanblok.BaantypeId = entity.sgt_baantypeid.Value;
                                        }

                                        if (entity.sgt_verlichting != null)
                                        {
                                            baanblok.Verlichting = entity.sgt_verlichting.Value;
                                        }

                                        if (entity.sgt_locatie_bb != null)
                                        {
                                            baanblok.Locatie = entity.sgt_locatie_bb.name; ;
                                        }

                                        baanblok.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Baanblokken.Add(baanblok);
                                    }
                                    else
                                    {
                                        baanblok.Naam = entity.sgt_alg_baanblok1;

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false);
                                            baanblok.ClubCloud_Accommodatie = accommodatie;
                                            baanblok.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baansoortid != null)
                                        {
                                            ClubCloud_Baansoort baansoort = GetBaansoortById(bondsnummer, entity.sgt_baansoortid.Value, false);
                                            baanblok.ClubCloud_Baansoort = baansoort;
                                            baanblok.BaansoortId = entity.sgt_baansoortid.Value;
                                        }

                                        if (entity.sgt_baantypeid != null)
                                        {
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            baanblok.ClubCloud_Baantype = baantype;
                                            baanblok.BaantypeId = entity.sgt_baantypeid.Value;
                                        }

                                        if (entity.sgt_verlichting != null)
                                        {
                                            baanblok.Verlichting = entity.sgt_verlichting.Value;
                                        }

                                        if (entity.sgt_locatie_bb != null)
                                        {
                                            baanblok.Locatie = entity.sgt_locatie_bb.name; ;
                                        }

                                        baanblok.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baanblokken = beheerModel.ClubCloud_Baanblokken.Where(b => b.AccommodatieId.Value == accommodatieId).ToList();
            }

            return baanblokken;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baansoortId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid baansoortId, bool refresh = false)
        {
            ClubCloud_Baansoort baansoort = new ClubCloud_Baansoort();

            baansoort = beheerModel.ClubCloud_Baansoorten.Find(baansoortId);

            if (baansoort == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            baansoort.ClubCloud_Baantype = baantype;
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
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            baansoort.ClubCloud_Baantype = baantype;
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
        private List<ClubCloud_Baansoort> GetBaansoorten(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baansoort> baansoorten = new List<ClubCloud_Baansoort>();

            baansoorten = beheerModel.ClubCloud_Baansoorten.ToList();

            if (baansoorten == null || baansoorten.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        baansoort = beheerModel.ClubCloud_Baansoorten.Create();
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
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            baansoort.ClubCloud_Baantype = baantype;
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
                                            ClubCloud_Baantype baantype = GetBaantypeById(bondsnummer, entity.sgt_baantypeid.Value, false);
                                            baansoort.ClubCloud_Baantype = baantype;
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
                baansoorten = beheerModel.ClubCloud_Baansoorten.ToList();
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
        private ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid baantypeId, bool refresh = false)
        {
            ClubCloud_Baantype baantype = new ClubCloud_Baantype();

            baantype = beheerModel.ClubCloud_Baantypes.Find(baantypeId);

            if (baantype == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_baantypeid", Operator = ConditionOperator.Equal, Values = new object[1] { baantypeId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baantype", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_baantype entity in entities)
                                {
                                    baantype = beheerModel.ClubCloud_Baantypes.Find(entity.sgt_alg_baantypeid.Value);

                                    if (baantype == null)
                                    {
                                        baantype = beheerModel.ClubCloud_Baantypes.Create();
                                        baantype.Id = entity.sgt_alg_baantypeid.Value;
                                        baantype.Naam = entity.sgt_alg_baantype1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantype.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantype.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantype.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantype.Meervoud = entity.sgt_meervoudsnaam;
                                        }

                                        baantype.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Baantypes.Add(baantype);
                                    }
                                    else
                                    {
                                        baantype.Naam = entity.sgt_alg_baantype1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantype.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantype.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantype.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantype.Meervoud = entity.sgt_meervoudsnaam;
                                        }

                                        baantype.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baantype = beheerModel.ClubCloud_Baantypes.Find(baantypeId);
            }
            return baantype;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baantype> GetBaantypes(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baantype> baantypes = new List<ClubCloud_Baantype>();

            baantypes = beheerModel.ClubCloud_Baantypes.ToList();

            if (baantypes == null || baantypes.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baantype", out moreRecords, ref pageNum);

                                foreach (sgt_alg_baantype entity in entities)
                                {
                                    ClubCloud_Baantype baantype = beheerModel.ClubCloud_Baantypes.Find(entity.sgt_alg_baantypeid.Value);

                                    if (baantype == null)
                                    {
                                        baantype = beheerModel.ClubCloud_Baantypes.Create();
                                        baantype.Id = entity.sgt_alg_baantypeid.Value;
                                        baantype.Naam = entity.sgt_alg_baantype1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantype.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantype.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantype.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantype.Meervoud = entity.sgt_meervoudsnaam;
                                        }

                                        baantype.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Baantypes.Add(baantype);
                                    }
                                    else
                                    {
                                        baantype.Naam = entity.sgt_alg_baantype1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantype.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantype.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantype.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantype.Meervoud = entity.sgt_meervoudsnaam;
                                        }

                                        baantype.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baantypes = beheerModel.ClubCloud_Baantypes.ToList();
            }

            return baantypes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baantypeId"></param>
        /// <param name="naam"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_BaanSpeciaal GetBaanspeciaalById(string bondsnummer, Guid baanspeciaalId, bool refresh = false)
        {
            ClubCloud_BaanSpeciaal baanspeciaal = new ClubCloud_BaanSpeciaal();

            baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Find(baanspeciaalId);

            if (baanspeciaal == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_speciale_baanid", Operator = ConditionOperator.Equal, Values = new object[1] { baanspeciaalId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_speciale_baan", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_speciale_baan entity in entities)
                                {
                                    baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.sgt_alg_speciale_baanid.Value);

                                    if (baanspeciaal == null)
                                    {
                                        baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Create();
                                        baanspeciaal.Id = entity.sgt_alg_speciale_baanid.Value;
                                        baanspeciaal.Naam = entity.sgt_name;

                                        if (entity.sgt_accomodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accomodatieid.Value, false);
                                            baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                            baanspeciaal.AccommodatieId = entity.sgt_accomodatieid.Value;
                                        }

                                        if (entity.sgt_soort_baan != null)
                                        {
                                            baanspeciaal.Baansoort = entity.sgt_soort_baan.name;
                                        }

                                        if (entity.sgt_toplaagid != null)
                                        {
                                            ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, entity.sgt_toplaagid.Value, false);
                                            baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                            baanspeciaal.BaantoplaagId = entity.sgt_toplaagid.Value;
                                        }

                                        baanspeciaal.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_BanenSpeciaal.Add(baanspeciaal);
                                    }
                                    else
                                    {
                                        baanspeciaal.Naam = entity.sgt_name;

                                        if (entity.sgt_accomodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accomodatieid.Value, false);
                                            baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                            baanspeciaal.AccommodatieId = entity.sgt_accomodatieid.Value;
                                        }

                                        if (entity.sgt_soort_baan != null)
                                        {
                                            baanspeciaal.Baansoort = entity.sgt_soort_baan.name;
                                        }

                                        if (entity.sgt_toplaagid != null)
                                        {
                                            ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, entity.sgt_toplaagid.Value, false);
                                            baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                            baanspeciaal.BaantoplaagId = entity.sgt_toplaagid.Value;
                                        }

                                        baanspeciaal.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Find(baanspeciaalId);
            }
            return baanspeciaal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baantypeId"></param>
        /// <param name="naam"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> GetBanenspeciaalByAccommodatieId(string bondsnummer, Guid accommodatieid, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banenspeciaal = new List<ClubCloud_BaanSpeciaal>();

            banenspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Where(b => b.AccommodatieId == accommodatieid).ToList();

            if (banenspeciaal == null || banenspeciaal.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
                            ClubCloud_Accommodatie Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(accommodatieid);
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                //<condition attribute="sgt_alg_accommodatieid" operator="eq" uiname="Kampong" uitype="sgt_alg_accommodatie" value="{11029F99-522E-4FC4-A86D-694E003F8BB2}"/>
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, uiname = Accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { Accommodatie.Id } };
                                //<filter type="and">
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                                //<link-entity name="sgt_alg_accommodatie" from="sgt_alg_accommodatieid" to="sgt_accommodatieid" alias="aa">
                                LinkEntity link = new LinkEntity { LinkToEntityName = "sgt_alg_accommodatie", LinkFromAttributeName = "sgt_accommodatieid", LinkToAttributeName = "sgt_alg_accommodatieid", LinkCriteria = expression };
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_speciale_baan", out moreRecords, ref pageNum, null, link);

                                foreach (sgt_alg_speciale_baan entity in entities)
                                {
                                    ClubCloud_BaanSpeciaal baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.sgt_alg_speciale_baanid.Value);

                                    if (baanspeciaal == null)
                                    {
                                        baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Create();
                                        baanspeciaal.Id = entity.sgt_alg_speciale_baanid.Value;
                                        baanspeciaal.Naam = entity.sgt_name;

                                        if (entity.sgt_accomodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accomodatieid.Value, false);
                                            baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                            baanspeciaal.AccommodatieId = entity.sgt_accomodatieid.Value;
                                        }

                                        if (entity.sgt_soort_baan != null)
                                        {
                                            baanspeciaal.Baansoort = entity.sgt_soort_baan.name;
                                        }

                                        if (entity.sgt_toplaagid != null)
                                        {
                                            ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, entity.sgt_toplaagid.Value, false);
                                            baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                            baanspeciaal.BaantoplaagId = entity.sgt_toplaagid.Value;
                                        }

                                        baanspeciaal.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_BanenSpeciaal.Add(baanspeciaal);
                                    }
                                    else
                                    {
                                        baanspeciaal.Naam = entity.sgt_name;

                                        if (entity.sgt_accomodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accomodatieid.Value, false);
                                            baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                            baanspeciaal.AccommodatieId = entity.sgt_accomodatieid.Value;
                                        }

                                        if (entity.sgt_soort_baan != null)
                                        {
                                            baanspeciaal.Baansoort = entity.sgt_soort_baan.name;
                                        }

                                        if (entity.sgt_toplaagid != null)
                                        {
                                            ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, entity.sgt_toplaagid.Value, false);
                                            baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                            baanspeciaal.BaantoplaagId = entity.sgt_toplaagid.Value;
                                        }

                                        baanspeciaal.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                banenspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Where(b => b.AccommodatieId == accommodatieid).ToList();
            }
            return banenspeciaal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> GetBanenSpeciaal(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_BaanSpeciaal> banenspeciaal = new List<ClubCloud_BaanSpeciaal>();

            banenspeciaal = beheerModel.ClubCloud_BanenSpeciaal.ToList();

            if (banenspeciaal == null || banenspeciaal.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_speciale_baan", out moreRecords, ref pageNum);

                                foreach (sgt_alg_speciale_baan entity in entities)
                                {
                                    ClubCloud_BaanSpeciaal baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.sgt_alg_speciale_baanid.Value);

                                    if (baanspeciaal == null)
                                    {
                                        baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Create();
                                        baanspeciaal.Id = entity.sgt_alg_speciale_baanid.Value;

                                        baanspeciaal.Naam = entity.sgt_name;

                                        if (entity.sgt_accomodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accomodatieid.Value, false);
                                            baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                            baanspeciaal.AccommodatieId = entity.sgt_accomodatieid.Value;
                                        }

                                        if (entity.sgt_soort_baan != null)
                                        {
                                            baanspeciaal.Baansoort = entity.sgt_soort_baan.name;
                                        }

                                        if (entity.sgt_toplaagid != null)
                                        {
                                            ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, entity.sgt_toplaagid.Value, false);
                                            baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                            baanspeciaal.BaantoplaagId = entity.sgt_toplaagid.Value;
                                        }

                                        baanspeciaal.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_BanenSpeciaal.Add(baanspeciaal);
                                    }
                                    else
                                    {
                                        baanspeciaal.Naam = entity.sgt_name;

                                        if (entity.sgt_accomodatieid != null)
                                        {
                                            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accomodatieid.Value, false);
                                            baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                            baanspeciaal.AccommodatieId = entity.sgt_accomodatieid.Value;
                                        }

                                        if (entity.sgt_soort_baan != null)
                                        {
                                            baanspeciaal.Baansoort = entity.sgt_soort_baan.name;
                                        }

                                        if (entity.sgt_toplaagid != null)
                                        {
                                            ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, entity.sgt_toplaagid.Value, false);
                                            baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                            baanspeciaal.BaantoplaagId = entity.sgt_toplaagid.Value;
                                        }

                                        baanspeciaal.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                banenspeciaal = beheerModel.ClubCloud_BanenSpeciaal.ToList();
            }

            return banenspeciaal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="toplaagId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Baantoplaag GetBaanToplaagById(string bondsnummer, Guid toplaagId, bool refresh = false)
        {

            ClubCloud_Baantoplaag baantoplaag = new ClubCloud_Baantoplaag();

            baantoplaag = beheerModel.ClubCloud_Baantoplagen.Find(toplaagId);

            if (baantoplaag == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_toplaagid", Operator = ConditionOperator.Equal, Values = new object[1] { toplaagId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_toplaag", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_toplaag entity in entities)
                                {
                                    baantoplaag = beheerModel.ClubCloud_Baantoplagen.Find(entity.sgt_alg_toplaagid.Value);

                                    if (baantoplaag == null)
                                    {
                                        baantoplaag = beheerModel.ClubCloud_Baantoplagen.Create();
                                        baantoplaag.Id = entity.sgt_alg_toplaagid.Value;
                                        baantoplaag.Naam = entity.sgt_alg_toplaag1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantoplaag.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantoplaag.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantoplaag.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantoplaag.Meervoud = entity.sgt_meervoudsnaam;
                                        }

                                        baantoplaag.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Baantoplagen.Add(baantoplaag);

                                    }
                                    else
                                    {
                                        baantoplaag.Naam = entity.sgt_alg_toplaag1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantoplaag.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantoplaag.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantoplaag.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantoplaag.Meervoud = entity.sgt_meervoudsnaam;
                                        }

                                        baantoplaag.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baantoplaag = beheerModel.ClubCloud_Baantoplagen.Find(toplaagId);
            }
            return baantoplaag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baantoplaag> GetBaantoplagen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {

            List<ClubCloud_Baantoplaag> baantoplagen = new List<ClubCloud_Baantoplaag>();

            baantoplagen = beheerModel.ClubCloud_Baantoplagen.ToList();

            if (baantoplagen == null || baantoplagen.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_toplaag", out moreRecords, ref pageNum);

                                foreach (sgt_alg_toplaag entity in entities)
                                {
                                    ClubCloud_Baantoplaag baantoplaag = beheerModel.ClubCloud_Baantoplagen.Find(entity.sgt_alg_toplaagid.Value);

                                    if (baantoplaag == null)
                                    {
                                        baantoplaag = beheerModel.ClubCloud_Baantoplagen.Create();
                                        baantoplaag.Id = entity.sgt_alg_toplaagid.Value;
                                        baantoplaag.Naam = entity.sgt_alg_toplaag1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantoplaag.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantoplaag.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantoplaag.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantoplaag.Meervoud = entity.sgt_meervoudsnaam;
                                        }

                                        baantoplaag.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Baantoplagen.Add(baantoplaag);
                                    }
                                    else
                                    {
                                        baantoplaag.Naam = entity.sgt_alg_toplaag1;

                                        if (entity.sgt_beschrijving != null)
                                        {
                                            baantoplaag.Beschrijving = entity.sgt_beschrijving;
                                        }

                                        if (entity.sgt_omschrijving != null)
                                        {
                                            baantoplaag.Omschrijving = entity.sgt_omschrijving;
                                        }

                                        if (entity.sgt_verkorte_code != null)
                                        {
                                            baantoplaag.Code = entity.sgt_verkorte_code;
                                        }

                                        if (entity.sgt_meervoudsnaam != null)
                                        {
                                            baantoplaag.Meervoud = entity.sgt_meervoudsnaam;
                                        }
                                        baantoplaag.Actief = entity.statuscode.name;
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                baantoplagen = beheerModel.ClubCloud_Baantoplagen.ToList();
            }

            return baantoplagen;
        }

        #endregion

        #region Accommodatie

        /// <summary>
        /// sgt_alg_accommodatie
        /// </summary>
        private ClubCloud_Accommodatie GetAccommodatieById(string bondsnummer, Guid AccommodatieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Accommodatie Accommodatie = new ClubCloud_Accommodatie();

            Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(AccommodatieId);

            if (Accommodatie == null)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { AccommodatieId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_accommodatie", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_accommodatie entity in entities)
                                {
                                    Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(entity.sgt_alg_accommodatieid.Value);

                                    if (Accommodatie == null)
                                    {
                                        Accommodatie = beheerModel.ClubCloud_Accommodaties.Create();
                                        Accommodatie.Id = entity.sgt_alg_accommodatieid.Value;
                                        EntityToAccommodatie(entity, Accommodatie, beheerModel, bondsnummer, settings);
                                        beheerModel.ClubCloud_Accommodaties.Add(Accommodatie);
                                    }
                                    else
                                    {
                                        EntityToAccommodatie(entity, Accommodatie, beheerModel, bondsnummer, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(AccommodatieId);
            }

            return Accommodatie;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Accommodatie Accommodatie = new ClubCloud_Accommodatie();

            Guid AccommodatieId = beheerModel.ClubCloud_Verenigingen.Find(verenigingId).AccommodatieId.Value;
            Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(AccommodatieId);

            if (Accommodatie == null || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { AccommodatieId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_accommodatie", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_accommodatie entity in entities)
                                {
                                    Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(entity.sgt_alg_accommodatieid.Value);

                                    if (Accommodatie == null)
                                    {
                                        Accommodatie = beheerModel.ClubCloud_Accommodaties.Create();
                                        Accommodatie.Id = entity.sgt_alg_accommodatieid.Value;
                                        EntityToAccommodatie(entity, Accommodatie, beheerModel, bondsnummer, settings);
                                        beheerModel.ClubCloud_Accommodaties.Add(Accommodatie);
                                    }
                                    else
                                    {
                                        EntityToAccommodatie(entity, Accommodatie, beheerModel, bondsnummer, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(AccommodatieId);
            }
            return Accommodatie;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="Accommodatie"></param>
        /// <param name="model"></param>
        /// <param name="bondsnummer"></param>
        /// <param name="settings"></param>
        private void EntityToAccommodatie(sgt_alg_accommodatie entity, ClubCloud_Accommodatie Accommodatie, BeheerContainer model, string bondsnummer, ClubCloud_Setting settings = null)
        {
            Accommodatie.Naam = entity.sgt_alg_accommodatie1;

            if (entity.sgt_totaal_aantal_banen != null)
            {
                Accommodatie.BanenAantal = entity.sgt_totaal_aantal_banen.Value;
            }

            if (entity.sgt_aantal_banen_binnen != null)
            {
                Accommodatie.BanenAantalBinnen = entity.sgt_aantal_banen_binnen.Value;
            }

            if (entity.sgt_aantal_banen_buiten != null)
            {
                Accommodatie.BanenAantalBuiten = entity.sgt_aantal_banen_buiten.Value;
            }

            if (entity.sgt_blaashal != null)
            {
                Accommodatie.Blaashal = entity.sgt_blaashal.Value;
            }

            if (entity.sgt_soort_blaashal != null)
            {
                Accommodatie.BlaashalSoort = entity.sgt_soort_blaashal.name;
            }

            if (entity.sgt_baan_blaashal != null)
            {
                Accommodatie.BlaashalAantalBanen = entity.sgt_baan_blaashal.Value;
            }

            if (entity.sgt_playgrounds != null)
            {
                Accommodatie.Playgrounds = entity.sgt_playgrounds.Value;
            }

            if (entity.sgt_aantal_playgrounds != null)
            {
                Accommodatie.PlaygroundsAantal = entity.sgt_aantal_playgrounds.Value;
            }

            if (entity.sgt_oefenmuren != null)
            {
                Accommodatie.Oefenmuren = entity.sgt_oefenmuren.Value;
            }

            if (entity.sgt_aantal_oefenmuren != null)
            {
                Accommodatie.OefenmurenAantal = entity.sgt_aantal_oefenmuren.Value;
            }

            if (entity.sgt_minibanen != null)
            {
                Accommodatie.Minibanen = entity.sgt_minibanen.Value;
            }

            if (entity.sgt_aantal_minibanen != null)
            {
                Accommodatie.MinibanenAantal = entity.sgt_aantal_minibanen.Value;
            }

            if (entity.sgt_overkapping != null)
            {
                Accommodatie.Overkapping = entity.sgt_overkapping.Value;
            }

            if (entity.sgt_soort_overkapping != null)
            {
                Accommodatie.OverkappingSoort = entity.sgt_soort_overkapping.name;
            }

            if (entity.sgt_aantal_parkeerplaatsen != null)
            {
                Accommodatie.AantalParkeerplaatsen = entity.sgt_aantal_parkeerplaatsen.Value;
            }

            if (entity.sgt_aantal_mv_parkeerplaatsen != null)
            {
                Accommodatie.AantalParkeerplaatsenMindervalide = entity.sgt_aantal_mv_parkeerplaatsen.Value;
            }

            if (entity.sgt_ov_bereikbaar != null)
            {
                Accommodatie.MetOVBereikbaar = entity.sgt_ov_bereikbaar.Value;
            }

            if (entity.sgt_email != null)
            {
                Accommodatie.Email = entity.sgt_email;
            }

            if (entity.sgt_telefoon != null)
            {
                Accommodatie.Telefoon = entity.sgt_telefoon;
            }

            if (entity.sgt_website != null)
            {
                Accommodatie.Website = entity.sgt_website;
            }

            if (entity.sgt_status_clubhuis != null)
            {
                Accommodatie.ClubhuisStatus = entity.sgt_status_clubhuis.name;
            }

            if (entity.sgt_bouwjaar_clubhuis != null)
            {
                Accommodatie.ClubhuisBouwjaar = entity.sgt_bouwjaar_clubhuis;
            }

            if (entity.sgt_bouwaardid != null)
            {
                Accommodatie.ClubhuisBouwaard = entity.sgt_bouwaardid.name;
            }

            if (entity.sgt_m2_clubhuis != null)
            {
                Accommodatie.ClubhuisOppervlakte = entity.sgt_m2_clubhuis.Value;
            }

            if (entity.sgt_liggingid != null)
            {
                Accommodatie.ClubhuisLigging = entity.sgt_liggingid.name;
            }

            if (entity.sgt_beveiliging != null)
            {
                Accommodatie.ClubhuisBeveiliging = entity.sgt_beveiliging.name;
            }

            if (entity.sgt_status_hal != null)
            {
                Accommodatie.HalStatus = entity.sgt_status_hal.name;
            }

            if (entity.sgt_bouwjaar_hal != null)
            {
                Accommodatie.HalBouwjaar = entity.sgt_bouwjaar_hal;
            }

            if (entity.sgt_klasse_hal != null)
            {
                Accommodatie.HalBouwaard = entity.sgt_klasse_hal.name;
            }

            if (entity.sgt_m2_hal != null)
            {
                Accommodatie.HalOppervlakte = entity.sgt_m2_hal.Value;
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
                ClubCloud_District district = GetDistrictById(bondsnummer, entity.sgt_districtid.Value, false, settings);
                Accommodatie.ClubCloud_District = district;
                Accommodatie.DistrictId = entity.sgt_districtid.Value;
            }

            if (entity.sgt_regioid != null)
            {
                ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false, settings);
                Accommodatie.ClubCloud_Regio = regio;
                Accommodatie.RegioId = entity.sgt_regioid.Value;
            }

            Accommodatie.Gewijzigd = DateTime.Now;
            /*
            Accommodatie.RolStoeltoegankelijk = entity.statuscode.name;            
            Accommodatie.Speeltoestellen = entity.statuscode.name;
            Accommodatie.Actief = entity.statuscode.name;
            */

            if (entity.sgt_alg_accommodatieid.Value != null)
            {
                List<ClubCloud_Address> addressen = GetAddressByParent(bondsnummer, entity.sgt_alg_accommodatieid.Value, false, settings);

                if (addressen.Count > 0)
                {
                    foreach (ClubCloud_Address addr in addressen)
                    {

                        ClubCloud_Address address = beheerModel.ClubCloud_Addresses.Find(addr.Id);

                        if (address.Naam.Equals("Bezoekadres", StringComparison.InvariantCultureIgnoreCase))
                        {
                            //address.Fax
                            if (entity.sgt_bezoekadreslandcodeid != null)
                                address.Land = entity.sgt_bezoekadreslandcodeid.name;
                            //address.Latitude
                            //address.Longitude
                            address.Nummer = entity.sgt_bezoekadres_huisnummer;
                            if (entity.sgt_alg_accommodatieid != null)
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
                            if (entity.sgt_bezoekadreslandcodeid != null)
                                address.Land = entity.sgt_postadreslandcodeid.name;
                            //address.Latitude
                            //address.Longitude
                            address.Nummer = entity.sgt_postadres_huisnummer;
                            if (entity.sgt_alg_accommodatieid != null)
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
                    if (entity.sgt_bezoekadreslandcodeid != null)
                        bezoek_address.Land = entity.sgt_bezoekadreslandcodeid.name;
                    //bezoek_address.Latitude
                    //bezoek_address.Longitude
                    bezoek_address.Nummer = entity.sgt_bezoekadres_huisnummer;
                    if (entity.sgt_alg_accommodatieid != null)
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

                    Accommodatie.ClubCloud_Address.Add(bezoek_address);

                    ClubCloud_Address post_address = beheerModel.ClubCloud_Addresses.Create();

                    post_address.Id = Guid.NewGuid();
                    post_address.ParentId = entity.sgt_alg_accommodatieid.Value;
                    post_address.Naam = "Postadres";
                    //post_address.Fax
                    if (entity.sgt_postadreslandcodeid != null)
                        post_address.Land = entity.sgt_postadreslandcodeid.name;
                    //post_address.Latitude
                    //post_address.Longitude
                    post_address.Nummer = entity.sgt_postadres_huisnummer;
                    if (entity.sgt_alg_accommodatieid != null)
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

                    Accommodatie.ClubCloud_Address.Add(post_address);
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
        private ClubCloud_Lidmaatschap GetLidmaatschapById(string bondsnummer, Guid lidmaatschapId, bool refresh = false)
        {
            ClubCloud_Lidmaatschap lidmaatschap = new ClubCloud_Lidmaatschap();

            lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschapId);

            if (lidmaatschap == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                    /*
                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                    */

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschapId);
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
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappen(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.VerenigingId == verenigingId).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                        //lidmaatschappen.Add(lidmaatschap);
                                    }
                                    /*
                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                    */
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.VerenigingId == verenigingId).ToList();
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
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.GebruikerId == gebruikerId).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                        //lidmaatschappen.Add(lidmaatschap);
                                    }

                                    beheerModel.SaveChanges();
                                    /*
                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                    */
                                }
                            }
                        }
                    }
                }
                lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.GebruikerId == gebruikerId).ToList();
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
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                        //lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        EntityToLidmaatschap(entity, lidmaatschap, bondsnummer, settings);
                                        //lidmaatschappen.Add(lidmaatschap);
                                    }

                                    beheerModel.SaveChanges();
                                    /*
                                    if (entity.sgt_lidid != null)
                                    {
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value);
                                    }
                                    */
                                }
                            }
                        }
                    }
                }
                lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(f => f.VerenigingId == verenigingId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
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
                lidmaatschap.ClubCloud_Gebruiker = gebruiker;
                lidmaatschap.GebruikerId = entity.sgt_lidid.Value;
            }

            lidmaatschap.Bondsnummer = entity.sgt_alg_bondsnummer;
            lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

            if (entity.sgt_soort_lidmaatschapid != null)
            {
                ClubCloud_Lidmaatschapsoort soort = GetLidmaatschapSoortById(bondsnummer, entity.sgt_soort_lidmaatschapid.Value, false, settings);
                //lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                lidmaatschap.ClubCloud_Lidmaatschapsoort = soort;
                lidmaatschap.SoortId = soort.Id;//entity.sgt_soort_lidmaatschapid.Value;
            }

            if (entity.sgt_verenigingid != null)
            {
                ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_verenigingid.Value, false, settings);
                lidmaatschap.ClubCloud_Vereniging = vereniging;
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

        private ClubCloud_Lidmaatschapsoort GetLidmaatschapSoortById(string bondsnummer, Guid lidmaatschapsoortId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Lidmaatschapsoort lidmaatschapsoort = new ClubCloud_Lidmaatschapsoort();

            lidmaatschapsoort = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(lidmaatschapsoortId);

            if (lidmaatschapsoort == null || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_soort_lidmaatschapid", Operator = ConditionOperator.Equal, Values = new object[1] { lidmaatschapsoortId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_soort_lidmaatschap", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_soort_lidmaatschap entity in entities)
                                {
                                    lidmaatschapsoort = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(entity.sgt_alg_soort_lidmaatschapid.Value);

                                    if (lidmaatschapsoort == null)
                                    {
                                        lidmaatschapsoort = beheerModel.ClubCloud_Lidmaatschapsoorten.Create();
                                        lidmaatschapsoort.Id = entity.sgt_alg_soort_lidmaatschapid.Value;
                                        lidmaatschapsoort.Naam = entity.sgt_alg_soort_lidmaatschap1;
                                        lidmaatschapsoort.Beschrijving = entity.sgt_beschrijving;
                                        lidmaatschapsoort.Contributie = entity.sgt_contributie.Value;
                                        lidmaatschapsoort.Omschrijving = entity.sgt_omschrijving;
                                        lidmaatschapsoort.Code = entity.sgt_verkorte_code;
                                        lidmaatschapsoort.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Lidmaatschapsoorten.Add(lidmaatschapsoort);

                                    }
                                    else
                                    {
                                        lidmaatschapsoort.Naam = entity.sgt_alg_soort_lidmaatschap1;
                                        lidmaatschapsoort.Beschrijving = entity.sgt_beschrijving;
                                        lidmaatschapsoort.Contributie = entity.sgt_contributie.Value;
                                        lidmaatschapsoort.Omschrijving = entity.sgt_omschrijving;
                                        lidmaatschapsoort.Code = entity.sgt_verkorte_code;
                                        lidmaatschapsoort.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                lidmaatschapsoort = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(lidmaatschapsoortId);
            }

            return lidmaatschapsoort;
        }

        private List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapSoorten(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Lidmaatschapsoort> lidmaatschapsoorten = new List<ClubCloud_Lidmaatschapsoort>();
            lidmaatschapsoorten = beheerModel.ClubCloud_Lidmaatschapsoorten.ToList();

            if (lidmaatschapsoorten == null || lidmaatschapsoorten.Count == 0 || refresh)
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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_soort_lidmaatschap", out moreRecords, ref pageNum);

                                foreach (sgt_alg_soort_lidmaatschap entity in entities)
                                {
                                    ClubCloud_Lidmaatschapsoort lidmaatschapsoort = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(entity.sgt_alg_soort_lidmaatschapid.Value);

                                    if (lidmaatschapsoort == null)
                                    {
                                        lidmaatschapsoort = beheerModel.ClubCloud_Lidmaatschapsoorten.Create();
                                        lidmaatschapsoort.Id = entity.sgt_alg_soort_lidmaatschapid.Value;
                                        lidmaatschapsoort.Naam = entity.sgt_alg_soort_lidmaatschap1;
                                        lidmaatschapsoort.Beschrijving = entity.sgt_beschrijving;
                                        lidmaatschapsoort.Contributie = entity.sgt_contributie.Value;
                                        lidmaatschapsoort.Omschrijving = entity.sgt_omschrijving;
                                        lidmaatschapsoort.Code = entity.sgt_verkorte_code;
                                        lidmaatschapsoort.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Lidmaatschapsoorten.Add(lidmaatschapsoort);
                                    }
                                    else
                                    {
                                        lidmaatschapsoort.Naam = entity.sgt_alg_soort_lidmaatschap1;
                                        lidmaatschapsoort.Beschrijving = entity.sgt_beschrijving;
                                        lidmaatschapsoort.Contributie = entity.sgt_contributie.Value;
                                        lidmaatschapsoort.Omschrijving = entity.sgt_omschrijving;
                                        lidmaatschapsoort.Code = entity.sgt_verkorte_code;
                                        lidmaatschapsoort.Actief = entity.statuscode.name;
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                lidmaatschapsoorten = beheerModel.ClubCloud_Lidmaatschapsoorten.ToList();
            }
            return lidmaatschapsoorten;
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
        private List<ClubCloud_Profiel> GetSpelersProfielByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            profielen = beheerModel.ClubCloud_Profielen.Where(p => p.GebruikerId == gebruikerId).ToList();

            if (profielen == null || profielen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_naamid ", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    ClubCloud_Profiel profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_dss.Value));

                                    if (profiel == null)
                                    {
                                        profiel = beheerModel.ClubCloud_Profielen.Create();
                                        profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                        beheerModel.ClubCloud_Profielen.Add(profiel);
                                    }
                                    else
                                    {
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                profielen = beheerModel.ClubCloud_Profielen.Where(p => p.GebruikerId == gebruikerId).ToList();
            }
            return profielen;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="profielId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Profiel GetSpelersProfielById(string bondsnummer, Guid profielId, bool refresh = false)
        {
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();

            profiel = beheerModel.ClubCloud_Profielen.SingleOrDefault(p => p.Id == profielId);

            if (profiel == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_spelersprofielid", Operator = ConditionOperator.Equal, Values = new object[1] { profielId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_dss.Value));

                                    if (profiel == null)
                                    {
                                        profiel = beheerModel.ClubCloud_Profielen.Create();
                                        profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                        beheerModel.ClubCloud_Profielen.Add(profiel);
                                    }
                                    else
                                    {
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                profiel = beheerModel.ClubCloud_Profielen.SingleOrDefault(p => p.Id == profielId);
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
        private List<ClubCloud_Profiel> GetSpelersProfielByNummer(string bondsnummer, string nummer, bool refresh = false)
        {
            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            profielen = beheerModel.ClubCloud_Profielen.Where(p => p.Bondsnummer == nummer).ToList();

            if (profielen == null || profielen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    ClubCloud_Profiel profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_dss.Value));

                                    if (profiel == null)
                                    {
                                        profiel = beheerModel.ClubCloud_Profielen.Create();
                                        profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                        beheerModel.ClubCloud_Profielen.Add(profiel);
                                    }
                                    else
                                    {
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                profielen = beheerModel.ClubCloud_Profielen.Where(p => p.Bondsnummer == nummer).ToList();
            }
            return profielen;
        }

        private void EntityToProfiel(sgt_dss_spelersprofiel entity, ClubCloud_Profiel profiel, string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            profiel.Bondsnummer = entity.sgt_dss_bondsnummer;

            if (entity.sgt_naamid != null && settings != null)
            {
                ClubCloud_Gebruiker gebruiker = GetGebruikerById(bondsnummer, settings.VerenigingId.Value, entity.sgt_naamid.Value, false);
                profiel.GebruikerId = gebruiker.Id;
                profiel.ClubCloud_Gebruiker = gebruiker;
            }

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

            if (entity.sgt_datum_dss != null)
                profiel.Datum = DateTime.Parse(entity.sgt_datum_dss.Value);

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
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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

                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);
                                    }

                                    beheerModel.SaveChanges();

                                    CreateOrUpdateMembershipGebruiker(gebruiker, settings);

                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        GetFunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, false, settings);
                                    }
                                }
                            }
                        }
                    }
                }
                gebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruikerId);
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
        private ClubCloud_Gebruiker GebruikerByNummer(string bondsnummer, string nummer, bool refresh = false, ClubCloud_Setting settings = null, bool decrypt = true)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            gebruiker = beheerModel.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);

            if (gebruiker == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password, decrypt);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);
                                    }

                                    beheerModel.SaveChanges();

                                    CreateOrUpdateMembershipGebruiker(gebruiker, settings);
                                    /*
                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        GetFunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                                    }
                                    */
                                }
                            }
                        }
                    }
                }
                gebruiker = beheerModel.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);
            }
            return gebruiker;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GetGebruikersByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            gebruikers = beheerModel.ClubCloud_Gebruikers.Where(f => f.VerenigingId == verenigingId && f.Actief.Equals("Actief", StringComparison.CurrentCultureIgnoreCase)).ToList();

            if (gebruikers != null && gebruikers.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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
                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, verenigingId, gebruiker, bondsnummer);
                                    }

                                    beheerModel.SaveChanges();

                                    CreateOrUpdateMembershipGebruiker(gebruiker, settings);

                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        GetFunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                                    }

                                }
                            }
                        }
                    }
                }
                gebruikers = beheerModel.ClubCloud_Gebruikers.Where(f => f.VerenigingId == verenigingId && f.Actief.Equals("Actief", StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
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

            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, gebruiker.VerenigingId.Value, false, settings);
            gebruiker.ClubCloud_Vereniging = vereniging;

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
                ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(bondsnummer, entity.sgt_nationaliteitid.Value, false, settings);
                gebruiker.ClubCloud_Nationaliteit = nationaliteit;
                gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;

            }
            /*
            if (entity.sgt_2e_nationaliteitid != null)
            {
                gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;
            }
            */
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

            if (!String.IsNullOrWhiteSpace(entity.sgt_fotonummer))
            {
                gebruiker.FotoId = int.Parse(entity.sgt_fotonummer);
            }

            if (entity.sgt_adres_geheim != null)
            {
                gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
            }

            //GetAddressByIdAsync(bondsnummer, entity.address1_addressid.Value, false, settings);
            ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
            gebruiker.ClubCloud_Address.Add(bezoek);
            //GetAddressByIdAsync(bondsnummer, entity.address2_addressid.Value, false, settings);
            ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
            gebruiker.ClubCloud_Address.Add(post);

            gebruiker.Actief = entity.statuscode.name;
            gebruiker.Gewijzigd = DateTime.Now;

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

            using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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
                //beheerModel.SaveChanges();
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

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
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
                //beheerModel.SaveChanges();
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

                        if (data != null)
                        {
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
                        }
                        else
                        {
                            return null;
                        }
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

        #region Administrator

        public void TriggerMetaData(string bondsnummer, bool refresh)
        {
            beheerModel.Database.Initialize(refresh);
            ClubCloud_Setting settings = GetSettings(bondsnummer);

            CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

            if (cc != null)
            {
                using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                {

                    //CrmService.CrmCookieContainer = cc;
                    //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                    WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                }
            }
        }

        public void NationaliteitenUpdate(string bondsnummer, bool refresh)
        {
            GetNationaliteiten(bondsnummer, true, null);
        }

        public void DistrictenUpdate(string bondsnummer, bool refresh)
        {
            GetDistricten(bondsnummer, true, null);
        }

        public void RechtsvormenUpdate(string bondsnummer, bool refresh)
        {
            GetRechtsvormen(bondsnummer, true, null);
        }

        public void FunctiesUpdate(string bondsnummer, bool refresh)
        {
            GetFuncties(bondsnummer, true, null);
        }

        public void BestuursOrganenUpdate(string bondsnummer, bool refresh)
        {
            GetBestuursOrganen(bondsnummer, true, null);
        }

        public void LidmaatschapSoortenUpdate(string bondsnummer, bool refresh)
        {
            GetLidmaatschapSoorten(bondsnummer, true, null);
        }

        public void RegiosUpdate(string bondsnummer, bool refresh)
        {
            GetRegios(bondsnummer, true, null);
        }

        public void ToplagenUpdate(string bondsnummer, bool refresh)
        {
            GetBaantoplagen(bondsnummer, true, null);
        }

        public void BaansoortenUpdate(string bondsnummer, bool refresh)
        {
            GetBaansoorten(bondsnummer, true, null);
        }

        public void BaantypesUpdate(string bondsnummer, bool refresh)
        {
            GetBaantypes(bondsnummer, true, null);
        }

        public void BanenSpeciaalUpdate(string bondsnummer, bool refresh)
        {
            GetBanenSpeciaal(bondsnummer, true, null);
        }

        public void BaanBlokkenUpdate(string bondsnummer, bool refresh)
        {
            GetBaanBlokken(bondsnummer, true, null);
        }

        public void BanenUpdate(string bondsnummer, bool refresh)
        {
            GetBanen(bondsnummer, true, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingNummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        public bool VerenigingenUpdate(string bondsnummer, int pageNum = 1, bool refresh = false)
        {
            bool moreRecords = true;

            ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
            {
                CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                if (cc != null)
                {
                    using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                    {

                        //CrmService.CrmCookieContainer = cc;
                        //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        //int pageNum = 1;
                        //while (moreRecords)
                        //{
                        ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_vereniging", Operator = ConditionOperator.Equal, Values = new object[1] { true } };
                        FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                        List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                        //using (var transaction = new TransactionScope())
                        //{
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

                            //CreateOrUpdateMembershipVereniging(vereniging, settings);

                            //GetBestuursOrgaanByVereniging(bondsnummer, vereniging.Id, true, settings);
                            //GetFunctionarissenByVereniging(bondsnummer, vereniging.Id, true, settings);
                        }
                        //}
                        //}
                    }
                }
            }
            return moreRecords;
        }


        public void LidmaatschappenUpdate(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            GetLidmaatschappenByVereniging(bondsnummer, verenigingId, refresh, null);
        }

        public void VerenigingZimbra(string bondsnummer, ClubCloud_Vereniging vereniging)
        {
            ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
            {
                CreateOrUpdateMembershipVereniging(vereniging, settings);
            }
        }

        public void GebruikerZimbra(string bondsnummer, ClubCloud_Gebruiker gebruiker)
        {
            ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
            {
                CreateOrUpdateMembershipGebruiker(gebruiker, settings);
            }
        }

        public List<ClubCloud_Functionaris> GetFunctionarissen()
        {
            return beheerModel.ClubCloud_Functionarissen.Where(f => f.Actief != string.Empty).ToList();
        }

        public List<ClubCloud_Vereniging> GetVerenigingen()
        {
            return beheerModel.ClubCloud_Verenigingen.Where(f => f.Actief != string.Empty).ToList();
        }

        public List<ClubCloud_Accommodatie> GetAccommodaties()
        {
            return beheerModel.ClubCloud_Accommodaties.Where(f => f.Actief != string.Empty).ToList();
        }

        public ClubCloud_Gebruiker CreateGebruiker(ClubCloud_Gebruiker gebruiker)
        {
            ClubCloud_Setting settings = GetClubCloudSettings(gebruiker.Bondsnummer);
            CreateOrUpdateMembershipGebruiker(gebruiker, settings);
            return gebruiker;
        }

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

                    using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(builder.ConnectionString))
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
                                using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(builder.ConnectionString))
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