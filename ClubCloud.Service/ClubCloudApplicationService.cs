//-----------------------------------------------------------------------
// <copyright file="HelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using System;
    using System.Linq;
    using System.Data;
    using System.Data.SqlClient;
    using System.ServiceModel;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Client.Services;
    using System.ServiceModel.Activation;
    using System.Data.Entity.Core.Objects;
    using ClubCloud.Service.Model;
    using System.Data.Entity;
    using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
    using System.Net;
    using Microsoft.SharePoint;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;
    using System.Xml;
    using System.Text;
    using System.IO;
    using System.Security;

    /// <summary>
    /// The WCF Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Runtime.InteropServices.Guid("e00d1eca-a977-4ba9-a357-5fd35dfc0f63")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    internal class ClubCloudApplicationService : IClubCloudApplicationService
    {
        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord)
        {
            ClubCloud.KNLTB.Security.KNLTBContainer container = new KNLTB.Security.KNLTBContainer();
            container.MijnRequestAcces(bondsnummer, wachtwoord);
            Stopwatch s = new Stopwatch();
            s.Start();
            while (container.Container == null || s.Elapsed < TimeSpan.FromSeconds(30)) { }
            s.Stop();
            return container.Container;
        }

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

        private static void CheckDatabase(string catalog = null)
        {
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString(catalog)))
            {

                if (model.Database.CreateIfNotExists())
                {
                    model.Database.Initialize(true);
                }
            }
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

        #region Methods

        public void CheckDatabaseExists()
        {
            CheckDatabase();
        }

        #region Gebruikers

        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                //TODO Privacy
            }

            currentsettings.mijnknltb_password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);

                currentsettings.mijnknltb_allow = settings.mijnknltb_allow;
                if (currentsettings.mijnknltb_allow && (currentsettings.mijnknltb_password != settings.mijnknltb_password))
                {
                    currentsettings.mijnknltb_password = settings.mijnknltb_password;
                }
                model.SaveChanges();
            }

            currentsettings.mijnknltb_password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                currentsettings.twitter_allow = settings.twitter_allow;
                currentsettings.twitter_oauth_token = settings.twitter_oauth_token;
                currentsettings.twitter_oauth_token_secret = settings.twitter_oauth_token_secret;
                currentsettings.twitter_setting = settings.twitter_setting;
                model.SaveChanges();
            }

            currentsettings.mijnknltb_password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                //TODO FacceBook
            }

            currentsettings.mijnknltb_password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                //TODO Financieel
            }

            currentsettings.mijnknltb_password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                currentsettings.mijnknltb_tracking = settings.mijnknltb_tracking;
            }

            currentsettings.mijnknltb_password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                if(currentsettings == null)
                {
                    currentsettings = new ClubCloud_Setting { Id = int.Parse(bondsnummer) };
                    model.ClubCloud_Settings.Add(currentsettings);
                    bool haschanges = model.ChangeTracker.HasChanges();
                    model.SaveChanges();
                    currentsettings.Id = int.Parse(bondsnummer);
                    model.SaveChanges();
                }
            }
            currentsettings.mijnknltb_password = string.Empty;
            return currentsettings;
        }


        public ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                if(settings.mijnknltb_Id.HasValue)
                {
                    gebruiker = model.ClubCloud_Gebruikers.Find(settings.mijnknltb_Id.Value);
                }

                if ((refresh || gebruiker == null) && settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);

                        GetPersoonsgegevensResponse persoonResponse = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = settings.Id.ToString() });
                        if (persoonResponse != null && persoonResponse.Persoonsgegevens != null)
                        {
                            Persoonsgegevens persoon = persoonResponse.Persoonsgegevens;
                            bool isnew = false;
                            if(gebruiker == null)
                            {
                                gebruiker = new ClubCloud_Gebruiker();
                                isnew = true;
                            }

                            gebruiker.Achternaam = persoon.Achternaam;
                            gebruiker.DistrictNaam = persoon.DistrictNaam;
                            gebruiker.Email = persoon.Email;
                            gebruiker.Geboortedatum = persoon.Geboortedatum;
                            gebruiker.Geboorteplaats = persoon.Geboorteplaats;
                            gebruiker.Gemeente = persoon.Gemeente;
                            gebruiker.Geslacht = persoon.Geslacht;
                            gebruiker.Huisnummer = persoon.Huisnummer;
                            gebruiker.Id = persoon.Id;
                            gebruiker.IsLid = persoon.IsLid;
                            gebruiker.Mobiel = persoon.Mobiel;
                            gebruiker.NationaliteitId = persoon.NationaliteitId;
                            gebruiker.OrganisatieNummer = persoon.OrganisatieNummer;
                            gebruiker.Plaats = persoon.Plaats;
                            gebruiker.Postcode = persoon.Postcode;
                            gebruiker.RatingDubbel = persoon.RatingDubbel;
                            gebruiker.RatingEnkel = persoon.RatingEnkel;
                            gebruiker.Roepnaam = persoon.Roepnaam;
                            gebruiker.SpeelsterkteDubbel = persoon.SpeelsterkteDubbel;
                            gebruiker.SpeelsterkteEnkel = persoon.SpeelsterkteEnkel;
                            gebruiker.Straat = persoon.Straat;
                            gebruiker.TelefoonAvond = persoon.TelefoonAvond;
                            gebruiker.TelefoonOverdag = persoon.TelefoonOverdag;
                            gebruiker.Toevoeging = persoon.Toevoeging;
                            gebruiker.Tussenvoegsel = persoon.Tussenvoegsel;
                            gebruiker.VolledigeNaam = persoon.VolledigeNaam;
                            gebruiker.Voorletters = persoon.Voorletters;
                            gebruiker.Voornamen = persoon.Voornamen;
                            
                            if(isnew)
                            {
                                model.ClubCloud_Gebruikers.Add(gebruiker);
                            }

                            if(!settings.mijnknltb_Id.HasValue)
                            {
                                settings.mijnknltb_Id = persoon.Id;
                            }
                        }
                    }
                    model.SaveChanges();
                }
            }

            return gebruiker;
        }

        public SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            SpelersProfiel profiel = new SpelersProfiel();


            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);

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

        public SpelerTracking GetTracking(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            SpelerTracking spelertracking = new SpelerTracking { Id = int.Parse(bondsnummer) };

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                if (settings.mijnknltb_tracking)
                {
                    ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(settings.mijnknltb_Id);
                    ClubCloud_Tracking cctracking = model.ClubCloud_TrackingSet.Find(settings.mijnknltb_Id);

                    if (cctracking != null && string.IsNullOrWhiteSpace(cctracking.Data))
                    {
                        spelertracking.Data = (List<SpelersProfiel>)DeserializeObjectList<SpelersProfiel>(cctracking.Data, "SpelersProfiel");
                    }

                    if (refresh && gebruiker != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);

                            GetSpelersProfielDetailResponse profielResponse = LedenAdministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = settings.Id.ToString() });
                            if (profielResponse != null)
                            {
                                SpelersProfiel profiel = (SpelersProfiel)profielResponse;
                                if (profiel != null)
                                {
                                    spelertracking.Data.Add(profiel);
                                }

                                cctracking.Data = SerializeObjectList(spelertracking.Data);
                                model.SaveChanges();
                            }
                        }
                    }
                }
            }
            return spelertracking;
        }

        public List<Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<Vereniging> verenigingen = new List<Vereniging>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                if (refresh && settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);
                        GetMijnVerenigingenResponse verenigingenResponse = LedenAdministratie.GetMijnVerenigingen(new GetMijnVerenigingenRequest());
                        if (verenigingenResponse != null && verenigingenResponse.Verenigingen != null)
                        {
                            verenigingen.AddRange(verenigingenResponse.Verenigingen);
                        }
                    }
                }
            }

            return verenigingen;
        }

        public List<District> GetDistricten(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            throw new NotImplementedException();
        }


        #endregion

        #region Club

        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.Find(verenigingId);

                if ((refresh && vereniging != null) || vereniging == null)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);
                            GetVerenigingResponse verenigingenResponse = LedenAdministratie.GetVereniging(new GetVerenigingRequest { Bondsnummer = settings.Id.ToString(), VerenigingId = verenigingId });
                            
                            if (verenigingenResponse != null)
                            {
                                vereniging.BanknummerPlaats = verenigingenResponse.BanknummerPlaats;
                                vereniging.Bezoekadres = verenigingenResponse.Bezoekadres;
                                vereniging.BezoekadresGemeente = verenigingenResponse.BezoekadresGemeente;
                                vereniging.BezoekadresPlaats = verenigingenResponse.BezoekadresPlaats;
                                vereniging.BezoekadresPostcode = verenigingenResponse.BezoekadresPostcode;
                                vereniging.DatumOpgericht = verenigingenResponse.DatumOpgericht;
                                vereniging.District = verenigingenResponse.District;
                                vereniging.Emailadres = verenigingenResponse.Emailadres;
                                vereniging.IbanCode = verenigingenResponse.IbanCode;
                                vereniging.KvKnummer = verenigingenResponse.KvKnummer;
                                vereniging.KvKplaats = verenigingenResponse.KvKplaats;
                                vereniging.Naam = verenigingenResponse.Naam;
                                vereniging.Postadres = verenigingenResponse.Postadres;
                                vereniging.PostadresGemeente = verenigingenResponse.PostadresGemeente;
                                vereniging.PostadresPlaats = verenigingenResponse.PostadresPlaats;
                                vereniging.PostadresPostcode = verenigingenResponse.PostadresPostcode;
                                vereniging.Regio = verenigingenResponse.Regio;
                                vereniging.TelefoonnummerAvond = verenigingenResponse.TelefoonnummerAvond;
                                vereniging.TelefoonnummerOverdag = verenigingenResponse.TelefoonnummerOverdag;
                                vereniging.Verenigingsnummer = verenigingenResponse.Verenigingsnummer;
                                vereniging.Website = verenigingenResponse.Website;
                            }
                        }
                    }
                    model.SaveChanges();
                }
            }

            return vereniging;
        }

        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);

                        ZoekVerenigingenResponse verenigingenResponse = LedenAdministratie.ZoekVerenigingen(new ZoekVerenigingenRequest { VerenigingsNummer = vereniginsnummer });
                        if (verenigingenResponse != null && verenigingenResponse.GevondenVerenigingen != null)
                        {
                            GevondenVerenigingen gevonden = verenigingenResponse.GevondenVerenigingen.SingleOrDefault(v => v.VerenigingsNummer == vereniginsnummer);

                            if(gevonden.Id.Value != null)
                            {
                                vereniging = GetVerenigingById(bondsnummer, gevonden.Id.Value, refresh);
                            }
                        }
                    }
                }
            }

            return vereniging;
        }

        #endregion
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

                    using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(builder.ConnectionString))
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
                                using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(builder.ConnectionString))
                                {
                                    vereniging = model.ClubCloud_Verenigingen.Add(new ClubCloud_Vereniging { Verenigingsnummer = verenigingsnummer, Naam = "S.V. Kampong", Id = new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") });
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

        public string GetPostcode(string postcode, int huisnummer)
        {
            throw new NotImplementedException();
        }
    }
}
