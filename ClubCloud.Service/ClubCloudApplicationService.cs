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
    using ClubCloud.Provider;
    using System.Web;
    using System.Web.Security;
    using System.Runtime.InteropServices;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

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
        #region Global

        private static SortedList<string, CookieContainer> containers;

        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord)
        {
            CookieContainer container = new CookieContainer();
            if(containers == null)
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
                    if(cookie.Expired)
                    {
                        expired = cookie.Expired;
                        break;
                    }
                }
            }

            if (container != null && container.Count > 0  && !expired)
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
                model.Database.Initialize(true);
                model.Database.CreateIfNotExists();
                model.Database.CompatibleWithModel(false);
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

        

        public void CheckDatabaseExists()
        {
            CheckDatabase();
        }

        #endregion

        #region Methods

        #region Gebruikers

        #region Settings

        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
            CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                currentsettings = model.ClubCloud_Settings.Find(settings.Id);
                currentsettings.privacy = settings.privacy;
                model.SaveChanges();
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
                currentsettings.facebook_allow = settings.facebook_allow;
                currentsettings.facebook_access_token = settings.facebook_access_token;
                currentsettings.facebook_setting = settings.facebook_setting;
                model.SaveChanges();
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
                currentsettings.financieel = settings.financieel;
                model.SaveChanges();
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
                model.SaveChanges();
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
                try
                {
                currentsettings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                }
                catch
                {

                    currentsettings = null;
                }

                if(currentsettings == null)// || !currentsettings.mijnknltb_Id.HasValue)
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
        #endregion

        public ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                if (settings != null)
                {
                    if (settings.mijnknltb_Id.HasValue)
                    {
                        gebruiker = model.ClubCloud_Gebruikers.Find(settings.mijnknltb_Id.Value);
                    }
                    else
                    {
                        gebruiker = null;
                    }

                    if (gebruiker == null || refresh)
                    {
                        if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                        {
                            CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                            if (cc != null)
                            {
                                LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

                                GetPersoonsgegevensResponse persoonResponse = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = bondsnummer });
                                if (persoonResponse != null && persoonResponse.Persoonsgegevens != null)
                                {
                                    Persoonsgegevens persoon = persoonResponse.Persoonsgegevens;

                                    if (gebruiker == null)
                                    {
                                        if (!settings.mijnknltb_Id.HasValue)
                                        {
                                            settings.mijnknltb_Id = persoon.Id;
                                        }

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
                                    else
                                    {
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
                                    }
                                }
                            }
                            
                        }
                    }
                }
                
                if(model.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }
                model.SaveChanges();

                
            }
            return gebruiker;
        }

        public bool SetClubCloudGebruiker(string bondsnummer, ClubCloud_Gebruiker gebruiker, bool refresh)
        {
            try
            {
                CheckDatabase();

                ClubCloud_Gebruiker currentgebruiker = new ClubCloud_Gebruiker();

                using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    currentgebruiker = model.ClubCloud_Gebruikers.Find(gebruiker.Id);
                    //ClubCloud_Gebruiker oldgebruiker = model.ClubCloud_Gebruikers.SingleOrDefault(g => g.Id == gebruiker.Id);

                    if (settings != null && currentgebruiker != null)
                    {
                        if (settings.mijnknltb_Id.HasValue)
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

        private bool UpdateMembershipuser(ClubCloud_Gebruiker gebruiker)
        {
            try
            {
                using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
                {

                    ClubCloud_Setting updatesettings = model.ClubCloud_Settings.SingleOrDefault(g => g.mijnknltb_Id == gebruiker.Id);
                    if (updatesettings != null)// && updatesettings.Id != null)
                    {
                        ZimbraMembershipUser zuser = Provider.GetZimbraUser(updatesettings.Id.ToString(), true);

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
                    }
                }

                return true;
            }
            catch (Exception ex)
            { 
                return false; 
            }
        }

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
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

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

        public List<ClubCloud_Gebruiker_Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Gebruiker_Vereniging> verenigingen = new List<ClubCloud_Gebruiker_Vereniging>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                if (settings != null && settings.mijnknltb_Id.HasValue)
                {
                    verenigingen = model.ClubCloud_Gebruiker_Verenigingen.Where(gv => gv.Id == settings.mijnknltb_Id.Value).ToList<ClubCloud_Gebruiker_Vereniging>();

                    if (verenigingen == null || verenigingen.Count == 0 || refresh)
                    {

                        if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                        {
                            CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                            if (cc != null)
                            {
                                LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
                                GetMijnVerenigingenResponse verenigingenResponse = LedenAdministratie.GetMijnVerenigingen(new GetMijnVerenigingenRequest { Bondsnummer = bondsnummer });
                                if (verenigingenResponse != null && verenigingenResponse.Verenigingen != null && verenigingenResponse.Verenigingen.Length > 0)
                                {
                                    foreach (Vereniging vereniging in verenigingenResponse.Verenigingen)
                                    {
                                        ClubCloud_Gebruiker_Vereniging gebruiker_vereniging = verenigingen.SingleOrDefault(v => v.VerenigingId == vereniging.Id);// && vereniging.Id == settings.mijnknltb_Id.Value);

                                        if (gebruiker_vereniging == null)// || gebruiker_vereniging.VerenigingId == null || gebruiker_vereniging.VerenigingId == Guid.Empty)
                                        {
                                            gebruiker_vereniging = new ClubCloud_Gebruiker_Vereniging
                                            {
                                                Id = settings.mijnknltb_Id.Value,
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

        //public List<ClubCloud_Abbonnement> GetAbonnementen(Guid persoonsId, bool refresh = false)
        public void GetAbonnementen(string bondsnummer, Guid persoonsId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Gebruiker_Abonement> abonnementen = new List<ClubCloud_Gebruiker_Abonement>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                if (settings != null)
                {
                    abonnementen = model.ClubCloud_Gebruiker_Abonementen.Where(gv => gv.Id == settings.mijnknltb_Id.Value).ToList<ClubCloud_Gebruiker_Abonement>();

                    if (abonnementen != null && abonnementen.Count == 0 || refresh)
                    {
                        if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                        {
                            CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

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
            }
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
            CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.Find(verenigingId);

                if ( vereniging == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));                    

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
                            GetVerenigingResponse verenigingenResponse = LedenAdministratie.GetVereniging(new GetVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId });
                            
                            if (verenigingenResponse != null)
                            {
                                if (vereniging == null)
                                {
                                    vereniging = new ClubCloud_Vereniging
                                    {
                                        Id = verenigingId,
                                        BanknummerPlaats = verenigingenResponse.BanknummerPlaats,
                                        Bezoekadres = verenigingenResponse.Bezoekadres,
                                        BezoekadresGemeente = verenigingenResponse.BezoekadresGemeente,
                                        BezoekadresPlaats = verenigingenResponse.BezoekadresPlaats,
                                        BezoekadresPostcode = verenigingenResponse.BezoekadresPostcode,
                                        DatumOpgericht = verenigingenResponse.DatumOpgericht,
                                        District = verenigingenResponse.District,
                                        Emailadres = verenigingenResponse.Emailadres,
                                        IbanCode = verenigingenResponse.IbanCode,
                                        KvKnummer = verenigingenResponse.KvKnummer,
                                        KvKplaats = verenigingenResponse.KvKplaats,
                                        Naam = verenigingenResponse.Naam,
                                        Postadres = verenigingenResponse.Postadres,
                                        PostadresGemeente = verenigingenResponse.PostadresGemeente,
                                        PostadresPlaats = verenigingenResponse.PostadresPlaats,
                                        PostadresPostcode = verenigingenResponse.PostadresPostcode,
                                        Regio = verenigingenResponse.Regio,
                                        TelefoonnummerAvond = verenigingenResponse.TelefoonnummerAvond,
                                        TelefoonnummerOverdag = verenigingenResponse.TelefoonnummerOverdag,
                                        Verenigingsnummer = verenigingenResponse.Verenigingsnummer,
                                        Website = verenigingenResponse.Website
                                    };

                                    model.ClubCloud_Verenigingen.Add(vereniging);
                                }
                                else
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
                    }
                    
                }
                model.SaveChanges();
            }

            return vereniging;
        }

        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {              
                vereniging = model.ClubCloud_Verenigingen.FirstOrDefault(v => v.Verenigingsnummer == vereniginsnummer);
                //vereniging = model.ClubCloud_Verenigingen.Select<ClubCloud_Vereniging, ClubCloud_Vereniging>(v => v.Verenigingsnummer == vereniginsnummer).First<ClubCloud_Vereniging>();

                if (vereniging == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

                            ZoekVerenigingenResponse verenigingenResponse = LedenAdministratie.ZoekVerenigingen(new ZoekVerenigingenRequest { VerenigingsNummer = vereniginsnummer });
                            if (verenigingenResponse != null && verenigingenResponse.GevondenVerenigingen != null)
                            {
                                GevondenVerenigingen gevonden = verenigingenResponse.GevondenVerenigingen.SingleOrDefault(v => v.VerenigingsNummer == vereniginsnummer);

                                if (gevonden.Id.Value != null)
                                {
                                    vereniging = GetVerenigingById(bondsnummer, gevonden.Id.Value, refresh);
                                }
                            }
                        }
                    }
                }
            }

            return vereniging;
        }

        public ClubCloud_Vereniging_Accomodatie GetAccommodatieForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Vereniging_Accomodatie accomodatie = new ClubCloud_Vereniging_Accomodatie();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                accomodatie = model.ClubCloud_Vereniging_Accomodaties.SingleOrDefault(gv => gv.Id == verenigingId);

                if (settings != null && accomodatie == null || refresh)
                {
                    if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

                            GetAccommodatieForVerenigingResponse accomodatieResponse = LedenAdministratie.GetAccommodatieForVereniging(new GetAccommodatieForVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId });
                            if (accomodatieResponse != null)
                            {
                                if (accomodatie == null)
                                {
                                    accomodatie = new ClubCloud_Vereniging_Accomodatie
                                    {
                                        Id = verenigingId,
                                        AccommodatieNaam = accomodatieResponse.AccommodatieNaam,
                                        BezoekAdres = new Model.Adres{ Gemeente = accomodatieResponse.BezoekAdres.Gemeente, Huisnummer = accomodatieResponse.BezoekAdres.Huisnummer,Plaats = accomodatieResponse.BezoekAdres.Plaats,Postcode = accomodatieResponse.BezoekAdres.Postcode,Straat = accomodatieResponse.BezoekAdres.Straat, Toevoeging = accomodatieResponse.BezoekAdres.Toevoeging },
                                        Minibanen = accomodatieResponse.Minibanen,
                                        Oefenmuren = accomodatieResponse.Oefenmuren,
                                        Ondergrond = accomodatieResponse.Ondergrond,
                                        Playgrounds = accomodatieResponse.Playgrounds,
                                        PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging },
                                        Speeltoestellen = accomodatieResponse.Speeltoestellen,
                                        TelefoonNummer = accomodatieResponse.TelefoonNummer

                                    };
                                    
                                    model.ClubCloud_Vereniging_Accomodaties.Add(accomodatie);
                                }
                                else
                                {
                                        accomodatie.AccommodatieNaam = accomodatieResponse.AccommodatieNaam;
                                        accomodatie.BezoekAdres = new Model.Adres { Gemeente = accomodatieResponse.BezoekAdres.Gemeente, Huisnummer = accomodatieResponse.BezoekAdres.Huisnummer, Plaats = accomodatieResponse.BezoekAdres.Plaats, Postcode = accomodatieResponse.BezoekAdres.Postcode, Straat = accomodatieResponse.BezoekAdres.Straat, Toevoeging = accomodatieResponse.BezoekAdres.Toevoeging };
                                        accomodatie.Minibanen = accomodatieResponse.Minibanen;
                                        accomodatie.Oefenmuren = accomodatieResponse.Oefenmuren;
                                        accomodatie.Ondergrond = accomodatieResponse.Ondergrond;
                                        accomodatie.Playgrounds = accomodatieResponse.Playgrounds;
                                        accomodatie.PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging };
                                        accomodatie.Speeltoestellen = accomodatieResponse.Speeltoestellen;
                                        accomodatie.TelefoonNummer = accomodatieResponse.TelefoonNummer;
                                }
                            }
                        }
                    }
                }

                model.SaveChanges();
            }

            return accomodatie;
        }

        public ClubCloud_Accomodatie GetAccommodatie(string bondsnummer, Guid accommodatieId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                accomodatie = model.ClubCloud_Accomodaties.Find(accommodatieId);

                if (accomodatie == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

                            GetAccommodatieResponse accomodatieResponse = LedenAdministratie.GetAccommodatie(new GetAccommodatieRequest { Bondsnummer = bondsnummer, AccommodatieId = accommodatieId });
                            if (accomodatieResponse != null)
                            {
                                if (accomodatie == null)
                                {
                                    accomodatie = new ClubCloud_Accomodatie
                                    {
                                        AantalBinnenBanen = accomodatieResponse.AantalBinnenBanen,
                                        AantalBuitenBanen = accomodatieResponse.AantalBuitenBanen,
                                        AccommodatieAdres = new Model.Adres { Gemeente = accomodatieResponse.AccommodatieAdres.Gemeente, Huisnummer = accomodatieResponse.AccommodatieAdres.Huisnummer, Plaats = accomodatieResponse.AccommodatieAdres.Plaats, Postcode = accomodatieResponse.AccommodatieAdres.Postcode, Straat = accomodatieResponse.AccommodatieAdres.Straat, Toevoeging = accomodatieResponse.AccommodatieAdres.Toevoeging },
                                        Blaashal = accomodatieResponse.Blaashal,
                                        BouwjaarClubhuis = accomodatieResponse.BouwjaarClubhuis,
                                        DatumKeuring = accomodatieResponse.DatumKeuring,
                                        DistrictNaam = accomodatieResponse.DistrictNaam,
                                        Email = accomodatieResponse.Email,
                                        Faxnummer = accomodatieResponse.Faxnummer,
                                        GekeurdDoor = accomodatieResponse.GekeurdDoor,
                                        HalAanwezig = accomodatieResponse.HalAanwezig,
                                        Id = accommodatieId,
                                        KleedruimteClubhuisAanwezig = accomodatieResponse.KleedruimteClubhuisAanwezig,
                                        MetOVBereikbaar = accomodatieResponse.MetOVBereikbaar,
                                        MinderValideParkeerplaatsen = accomodatieResponse.MinderValideParkeerplaatsen,
                                        Minibanen = accomodatieResponse.Minibanen,
                                        Naam = accomodatieResponse.Naam,
                                        Oefenmuren = accomodatieResponse.Oefenmuren,
                                        Ondergrond = accomodatieResponse.Ondergrond,
                                        OppervlakteClubhuis = accomodatieResponse.OppervlakteClubhuis,
                                        Overkapping = accomodatieResponse.Overkapping,
                                        Playgrounds = accomodatieResponse.Playgrounds,
                                        PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging },
                                        RegioNaam = accomodatieResponse.RegioNaam,
                                        Resultaatkeuring = accomodatieResponse.Resultaatkeuring,
                                        RolStoeltoegankelijk = accomodatieResponse.RolStoeltoegankelijk,
                                        SoortClubhuis = accomodatieResponse.SoortClubhuis,
                                        Speeltoestellen = accomodatieResponse.Speeltoestellen,
                                        Telefoonnummer = accomodatieResponse.Telefoonnummer,
                                        TotaalAantalWasKleedruimte = accomodatieResponse.TotaalAantalWasKleedruimte,
                                        ValideParkeerplaatsen = accomodatieResponse.ValideParkeerplaatsen,
                                        WasruimteClubhuisAanwezig = accomodatieResponse.WasruimteClubhuisAanwezig,
                                        Website = accomodatieResponse.Website

                                    };

                                    model.ClubCloud_Accomodaties.Add(accomodatie);
                                }
                                else
                                {
                                    accomodatie.AantalBinnenBanen = accomodatieResponse.AantalBinnenBanen;
                                    accomodatie.AantalBuitenBanen = accomodatieResponse.AantalBuitenBanen;
                                    accomodatie.AccommodatieAdres = new Model.Adres { Gemeente = accomodatieResponse.AccommodatieAdres.Gemeente, Huisnummer = accomodatieResponse.AccommodatieAdres.Huisnummer, Plaats = accomodatieResponse.AccommodatieAdres.Plaats, Postcode = accomodatieResponse.AccommodatieAdres.Postcode, Straat = accomodatieResponse.AccommodatieAdres.Straat, Toevoeging = accomodatieResponse.AccommodatieAdres.Toevoeging };
                                    accomodatie.Blaashal = accomodatieResponse.Blaashal;
                                    accomodatie.BouwjaarClubhuis = accomodatieResponse.BouwjaarClubhuis;
                                    accomodatie.DatumKeuring = accomodatieResponse.DatumKeuring;
                                    accomodatie.DistrictNaam = accomodatieResponse.DistrictNaam;
                                    accomodatie.Email = accomodatieResponse.Email;
                                    accomodatie.Faxnummer = accomodatieResponse.Faxnummer;
                                    accomodatie.GekeurdDoor = accomodatieResponse.GekeurdDoor;
                                    accomodatie.HalAanwezig = accomodatieResponse.HalAanwezig;
                                    accomodatie.KleedruimteClubhuisAanwezig = accomodatieResponse.KleedruimteClubhuisAanwezig;
                                    accomodatie.MetOVBereikbaar = accomodatieResponse.MetOVBereikbaar;
                                    accomodatie.MinderValideParkeerplaatsen = accomodatieResponse.MinderValideParkeerplaatsen;
                                    accomodatie.Minibanen = accomodatieResponse.Minibanen;
                                    accomodatie.Naam = accomodatieResponse.Naam;
                                    accomodatie.Oefenmuren = accomodatieResponse.Oefenmuren;
                                    accomodatie.Ondergrond = accomodatieResponse.Ondergrond;
                                    accomodatie.OppervlakteClubhuis = accomodatieResponse.OppervlakteClubhuis;
                                    accomodatie.Overkapping = accomodatieResponse.Overkapping;
                                    accomodatie.Playgrounds = accomodatieResponse.Playgrounds;
                                    accomodatie.PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging };
                                    accomodatie.RegioNaam = accomodatieResponse.RegioNaam;
                                    accomodatie.Resultaatkeuring = accomodatieResponse.Resultaatkeuring;
                                    accomodatie.RolStoeltoegankelijk = accomodatieResponse.RolStoeltoegankelijk;
                                    accomodatie.SoortClubhuis = accomodatieResponse.SoortClubhuis;
                                    accomodatie.Speeltoestellen = accomodatieResponse.Speeltoestellen;
                                    accomodatie.Telefoonnummer = accomodatieResponse.Telefoonnummer;
                                    accomodatie.TotaalAantalWasKleedruimte = accomodatieResponse.TotaalAantalWasKleedruimte;
                                    accomodatie.ValideParkeerplaatsen = accomodatieResponse.ValideParkeerplaatsen;
                                    accomodatie.WasruimteClubhuisAanwezig = accomodatieResponse.WasruimteClubhuisAanwezig;
                                    accomodatie.Website = accomodatieResponse.Website;
                                }

                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return accomodatie;
        }

        #endregion


        //GetBestuursorganenForVerenigingRequest
        public List<ClubCloud_Vereniging_BestuursLid> GetBestuurForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Vereniging_BestuursLid> bestuursorgaan = new List<ClubCloud_Vereniging_BestuursLid>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {

                bestuursorgaan = model.ClubCloud_Vereniging_BestuursLeden.Where(gv => gv.Id == verenigingId).ToList<ClubCloud_Vereniging_BestuursLid>();

                if (bestuursorgaan == null || bestuursorgaan.Count == 0 || refresh)
                {
                    if (refresh)
                    {
                        try
                        {
                            model.ClubCloud_Vereniging_BestuursLeden.RemoveRange(bestuursorgaan);
                            model.SaveChanges();
                        }
                        catch { }
                    }

                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
                            GetBestuursorganenForVerenigingResponse bestuursorganenResponse = LedenAdministratie.GetBestuursorganenForVereniging(new GetBestuursorganenForVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId, Username="*" });

                            if (bestuursorganenResponse != null && bestuursorganenResponse.Bestuursorganen.Length > 0)
                            {

                                foreach (BestuursorgaanForVereniging orgaan in bestuursorganenResponse.Bestuursorganen)
                                {
                                    ClubCloud_Vereniging_BestuursLid bestuur = bestuursorgaan.SingleOrDefault(b => b.VerenigingId == verenigingId && b.Functie == orgaan.Functie && b.Orgaan == orgaan.Orgaan && b.VolledigeNaam == orgaan.VolledigeNaam && b.Emailadres == orgaan.Emailadres);

                                    if (bestuur == null)
                                    {
                                        bestuur = model.ClubCloud_Vereniging_BestuursLeden.Create();

                                        bestuur.Emailadres = orgaan.Emailadres;
                                        bestuur.Functie = orgaan.Functie;
                                        bestuur.Orgaan = orgaan.Orgaan;
                                        bestuur.Telefoon = orgaan.Telefoon;
                                        bestuur.VolledigeNaam = orgaan.VolledigeNaam;
                                        bestuur.VerenigingId = verenigingId;
                                        /*
                                        bestuur = new ClubCloud_Vereniging_BestuursLid
                                        {
                                            Emailadres = orgaan.Emailadres,
                                            Functie = orgaan.Functie,
                                            VerenigingId = verenigingId,
                                            Orgaan = orgaan.Orgaan,
                                            Telefoon = orgaan.Telefoon,
                                            VolledigeNaam = orgaan.VolledigeNaam
                                        };
                                        */
                                        model.ClubCloud_Vereniging_BestuursLeden.Add(bestuur);
                                        
                                        bestuursorgaan.Add(bestuur);
                                    }
                                    else
                                    {
                                        bestuur.VerenigingId = verenigingId;
                                        bestuur.Emailadres = orgaan.Emailadres;
                                        bestuur.Functie = orgaan.Functie;
                                        bestuur.Orgaan = orgaan.Orgaan;
                                        bestuur.Telefoon = orgaan.Telefoon;
                                        bestuur.VolledigeNaam = orgaan.VolledigeNaam;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return bestuursorgaan;
        }

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
