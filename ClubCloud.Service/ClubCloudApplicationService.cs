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
            while (container.Container == null || s.Elapsed < TimeSpan.FromSeconds(300)) { }
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

        #region Gebruikers

        public ClubCloud_Gebruiker GetClubCloudUser(string user)
        {
            ClubCloud_Gebruiker gebruiker = null;

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {

                if (model.Database.CreateIfNotExists())
                {
                    model.Database.Initialize(true);
                }
            }

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                gebruiker = model.ClubCloud_Gebruikers.Find(int.Parse(user));

                //if (gebruiker != null && !string.IsNullOrWhiteSpace(gebruiker.mijnknltb_password))
                //{
                //    CookieContainer cc = RequestContainer(gebruiker.Id.ToString(), gebruiker.mijnknltb_password);

                //    LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);
                //    GetPersoonsgegevensResponse persoon = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = gebruiker.Id.ToString() });
                //    Persoonsgegevens persoonsgegevens = persoon.Persoonsgegevens;
                //    gebruiker.FirstName = persoonsgegevens.Voornamen;
                //    gebruiker.MiddleName = persoonsgegevens.Tussenvoegsel;
                //    gebruiker.LastName = persoonsgegevens.Achternaam;
                //    model.SaveChanges();
                //}
            }
            return gebruiker;
        }


        public Persoonsgegevens GetPersoonsgegevens(string bondsnummer, bool refresh = false)
        {
            Persoonsgegevens persoon = new Persoonsgegevens();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(int.Parse(bondsnummer));

                persoon = new Persoonsgegevens { Achternaam = gebruiker.LastName };

                if (refresh && gebruiker != null && !string.IsNullOrWhiteSpace(gebruiker.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(gebruiker.Id.ToString(), gebruiker.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);

                        GetPersoonsgegevensResponse persoonResponse = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = gebruiker.Id.ToString() });
                        if (persoonResponse != null && persoonResponse.Persoonsgegevens != null)
                        {
                            persoon = persoonResponse.Persoonsgegevens;
                        }
                    }
                    //TODO Update
                    //gebruiker.LastName = persoon.Achternaam;
                    //model.SaveChanges();
                }
            }

            return persoon;
        }

        public SpelersProfiel GetPersoonsprofiel(string bondsnummer)
        {
            SpelersProfiel profiel = new SpelersProfiel();


            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(int.Parse(bondsnummer));

                if (gebruiker != null && !string.IsNullOrWhiteSpace(gebruiker.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(gebruiker.Id.ToString(), gebruiker.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);

                        GetSpelersProfielDetailResponse profielResponse = LedenAdministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = gebruiker.Id.ToString() });
                        if (profielResponse != null)
                        {
                            profiel = (SpelersProfiel)profielResponse;
                        }
                    }
                }
            }

            return profiel;
        }

        public SpelerTracking GetTracking(string bondsnummer, bool update = false)
        {
            SpelerTracking spelertracking = new SpelerTracking { Id = int.Parse(bondsnummer) };

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(int.Parse(bondsnummer));
                ClubCloud_Tracking cctracking = model.ClubCloud_TrackingSet.Find(int.Parse(bondsnummer));

                if (cctracking != null && string.IsNullOrWhiteSpace(cctracking.Data))
                {
                    spelertracking.Data = (List<SpelersProfiel>)DeserializeObjectList<SpelersProfiel>(cctracking.Data, "SpelersProfiel");
                }

                if (update && gebruiker != null && !string.IsNullOrWhiteSpace(gebruiker.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(gebruiker.Id.ToString(), gebruiker.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);

                        GetSpelersProfielDetailResponse profielResponse = LedenAdministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = gebruiker.Id.ToString() });
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
            return spelertracking;
        }

        public List<Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
        {
            List<Vereniging> verenigingen = new List<Vereniging>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(int.Parse(bondsnummer));

                if (refresh && gebruiker != null && !string.IsNullOrWhiteSpace(gebruiker.mijnknltb_password))
                {
                    CookieContainer cc = RequestContainer(gebruiker.Id.ToString(), gebruiker.mijnknltb_password);

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
            throw new NotImplementedException();
        }


        #endregion

        #region Club

        public ClubCloud_Vereniging GetVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.Find(verenigingId);

                if ((refresh && vereniging != null) || vereniging == null )
                {
                    ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(int.Parse(bondsnummer));
                    if(gebruiker != null && !string.IsNullOrWhiteSpace(gebruiker.mijnknltb_password))
                    {
                    CookieContainer cc = RequestContainer(gebruiker.Id.ToString(), gebruiker.mijnknltb_password);

                    if (cc != null)
                    {
                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);
                        GetVerenigingResponse verenigingenResponse = LedenAdministratie.GetVereniging(new GetVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId });
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

        public ClubCloud_Vereniging GetVereniging(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {

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
                                    vereniging = model.ClubCloud_Verenigingen.Add(new ClubCloud_Vereniging { Id = int.Parse(verenigingsnummer), Name = "S.V. Kampong", mijnknltb_id = new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") });
                                    model.SaveChanges();

                                    //vereniging = model.ClubCloud_Verenigingen.Find(int.Parse(verenigingsnummer));
                                }

                                if (vereniging != null)
                                {

                                    string url = string.Format("http://{0}.clubcloud.nl", verenigingsnummer);
                                    SPSite createdSite = webApp.Sites.Add(url, vereniging.Name, vereniging.Name, 1043, "STS#1", @"12073385",
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
