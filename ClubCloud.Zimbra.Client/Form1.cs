using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Net;
using System.Collections.Specialized;
using ClubCloud.Zimbra.Account;
using ClubCloud.Zimbra.Global;
using ClubCloud.Zimbra.Administration;
using System.ServiceModel;
using System.Reflection;
using System.Collections;
using Microsoft.Web.Administration;
using System.Xml;
using System.Net.Cache;
using ClubCloud.KNLTB.Client;
using ClubCloud.KNLTB.ServIt;
using System.Web.Services.Protocols;
using ClubCloud.KNLTB.ServIt.CrmService;
using ClubCloud.KNLTB.ServIt.MetadataService;
using System.ServiceModel.Channels;
using ClubCloud.KNLTB.ServIt.UserService;
using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
using ClubCloud.KNLTB.ServIt.CompetitieService;
//using ClubCloud.KNLTB.ServIt.MetadataService;

namespace ClubCloud.Zimbra.Client
{
    public partial class Form1 : Form
    {
        private static ZimbraServer server;

        private List<string> _zimbraPasswordMaxLength;

        public List<string> zimbraPasswordMaxLength
        {
            get {
                if(_zimbraPasswordMaxLength == null)
                {
                    _zimbraPasswordMaxLength = new List<string>();
                }
                return _zimbraPasswordMaxLength; 
            }
            set { _zimbraPasswordMaxLength = value; }
        }

        private string _zimbraPasswordMinLength;

        public string zimbraPasswordMinLength
        {
            get { return _zimbraPasswordMinLength; }
            set { _zimbraPasswordMinLength = value; }
        }

        public Form1()
        {
            InitializeComponent();
            /*
            server = new ZimbraServer();
            //server = new ZimbraServer("mail.clubcloud.nl");
            server.PropertyChanged += server_PropertyChanged;
            try
            {
                server.Authenticate();
                //server.Authenticate("admin@clubcloud.nl", "rjm557308453!",true);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            */
        }


            private static XmlDocument GetWebConfig(string configFilePath)
            {
                var webConfig = new XmlDocument();
                webConfig.Load(configFilePath);
                webConfig.Save(configFilePath.ToLower().Replace("web.config", "web_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm") + "_Zimbra.config"));
                return webConfig;
            }

            private static void AppendSectionGroupZimbra(ref XmlDocument rootConfig)
            {
                string fullname = Assembly.GetExecutingAssembly().FullName;
                XmlNode configuration = rootConfig.SelectSingleNode("/configuration");

                //Section
                XmlNode configSections = rootConfig.SelectSingleNode("/configuration/configSections");
                XmlNode sectionGroup = rootConfig.CreateNode(XmlNodeType.Element, "sectionGroup","");
                XmlAttribute nameAttribute = rootConfig.CreateAttribute("name");
                nameAttribute.Value = "Zimbra";
                sectionGroup.Attributes.Append(nameAttribute);
                sectionGroup.InnerXml = string.Format("<section name=\"Configuration\" type=\"ClubCloud.Zimbra.Service.ZimbraConfigurationHandler,{0}\" />", fullname);
                configSections.AppendChild(sectionGroup);

                
                XmlNode ZimbraSection = rootConfig.CreateNode(XmlNodeType.Element, "Zimbra", "");
                ZimbraSection.InnerXml = "<Configuration><Server Name=\"ClubCloud\" ServerName=\"mail.clubcloud.nl\" UserName=\"admin@clubcloud.nl\" Password=\"rjm557308453!\" IsAdmin=\"true\" Encoded=\"false\" /><Binding MaxReceivedMessageSize=\"2147483647\" /></Configuration>";
                configuration.InsertAfter(ZimbraSection, configSections);
            }

        private static void AppendProviderZimbra(ref XmlDocument rootConfig)
            {
                string fullname = Assembly.GetExecutingAssembly().FullName;

                XmlNode PeoplePickerWildcards = rootConfig.SelectSingleNode("/configuration/SharePoint/PeoplePickerWildcards");
                //<add key="ZimbraMembershipProvider" value="%" />
                XmlNode peopleRolenode = rootConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute peopleRolekeyAttribute = rootConfig.CreateAttribute("key");
                peopleRolekeyAttribute.Value = "ZimbraRoleProvider";
                peopleRolenode.Attributes.Append(peopleRolekeyAttribute);
                XmlAttribute peopleRoleValueAttribute = rootConfig.CreateAttribute("value");
                peopleRoleValueAttribute.Value = "%";
                peopleRolenode.Attributes.Append(peopleRoleValueAttribute);
                PeoplePickerWildcards.AppendChild(peopleRolenode);

                //<add key="ZimbraRoleProvider" value="%" />
                XmlNode peopleMembernode = rootConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute peopleMemberkeyAttribute = rootConfig.CreateAttribute("key");
                peopleMemberkeyAttribute.Value = "ZimbramemberProvider";
                peopleMembernode.Attributes.Append(peopleMemberkeyAttribute);
                XmlAttribute peopleMemberValueAttribute = rootConfig.CreateAttribute("value");
                peopleMemberValueAttribute.Value = "%";
                peopleMembernode.Attributes.Append(peopleMemberValueAttribute);
                PeoplePickerWildcards.AppendChild(peopleMembernode);

                //<add name="ZimbraRoleProvider" type="ClubCloud.Provider.ZimbraRoleProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                XmlNode roleManager = rootConfig.SelectSingleNode("/configuration/system.web/roleManager/providers");
                XmlNode rolenode = rootConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute roleNameAttribute = rootConfig.CreateAttribute("name");
                roleNameAttribute.Value = "ZimbraRoleProvider";
                XmlAttribute roleTypeAttribute = rootConfig.CreateAttribute("type");
                roleTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraRoleProvider, {0}\" />", fullname);
                roleManager.AppendChild(rolenode);

                //<add name="ZimbraMembershipProvider" type="ClubCloud.Provider.ZimbraMembershipProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                XmlNode membership = rootConfig.SelectSingleNode("/configuration/system.web/membership/providers");
                XmlNode membernode = rootConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute memberNameAttribute = rootConfig.CreateAttribute("name");
                memberNameAttribute.Value = "ZimbraRoleProvider";
                XmlAttribute memberTypeAttribute = rootConfig.CreateAttribute("type");
                memberTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraMembershipProvider, {0}\" />", fullname);
                membership.AppendChild(membernode);
                
            }

        private static void AppendModuleZimbra(ref XmlDocument rootConfig)
        {
            string fullname = Assembly.GetExecutingAssembly().FullName;
            XmlNode configuration = rootConfig.SelectSingleNode("/configuration");
        }

        CookieContainer cc = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cc == null)
                {
                    ClubCloud.KNLTB.Security.KNLTBContainer container = new KNLTB.Security.KNLTBContainer();
                    //container.MijnRequestAcces("12073385", "rjm557308453!");
                    container.ServItRequestAcces("27908313", "SfRMTu4");

                    while (container.Container == null) { }
                    cc = container.Container;
                }

                LedenadministratieServiceClient ledenadministratie = new LedenadministratieServiceClient(cc, "27908313");
                CompetitieServiceClient competitieService = new CompetitieServiceClient(cc, "27908313");
                //GetSpelersprofielResponse spelersprofiel = ledenadministratie.GetSpelersprofiel(new GetSpelersprofielRequest { Bondsnummer = "27908313" });
                //GetSpelersProfielDetailResponse spelersprofieldetail = ledenadministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = "27908313" });

                //GetUserDistrictResponse district = ledenadministratie.GetUserDistrict(new GetUserDistrictRequest { Bondsnummer = "27908313" });
                GetMijnVerenigingenResponse verenigingen = ledenadministratie.GetMijnVerenigingen(new GetMijnVerenigingenRequest { Bondsnummer = "27908313" });
                foreach (ClubCloud.KNLTB.ServIt.LedenAdministratieService.Vereniging vereniging in verenigingen.Verenigingen)
                {
                    //GetVerenigingResponse verenigingdetails = ledenadministratie.GetVereniging(new KNLTB.ServIt.LedenAdministratieService.GetVerenigingRequest { Bondsnummer = "27908313", VerenigingId = vereniging.Id });
                    GetCompetitiesForVerenigingResponse competities = ledenadministratie.GetCompetitiesForVereniging(new GetCompetitiesForVerenigingRequest { Bondsnummer = "27908313", VerenigingId = vereniging.Id });

                    foreach (ClubCloud.KNLTB.ServIt.LedenAdministratieService.CompetitieForVereniging competitie in competities.Competities)
                    {
                        //GetAfdelingenResponse afdelingen = competitieService.GetAfdelingen(new GetAfdelingenRequest { CompetitieId = competitie.Id, Filter = GetAfdelingenFilter.AfdelingenWithIngedeeldePloeg });
                        //foreach (Afdeling afdeling in afdelingen.Afdelingen)
                        //{
                            GetWedstrijdgegevensResponse wedstrijden = competitieService.GetWedstrijdgegevens(new GetWedstrijdgegevensRequest { CompetitieId = competitie.Id, AfdelingVerenigingWedstrijdgegevenId = vereniging.Id, Filter = GetWedstrijdgegevensFilter.WedstrijdgegevensForVereniging });

                            foreach (Wedstrijdgegevens wedstrijd in wedstrijden.Wedstrijdgegevens)
                            {
                                GetPartijresultatenResponse partijen = competitieService.GetPartijresultaten(new GetPartijresultatenRequest { WedstrijdgegevenId = wedstrijd.Id });
                                foreach (Partijresultaat partij in partijen.Partijresultaten)
                                {
                                    Console.WriteLine(partij.BondsnummerThuisspeler);
                                    Console.WriteLine(partij.BondsnummerUitspeler);
                                }
                            }
                        //}
                        /*
                        GetPloegenResponse ploegen = competitieService.GetPloegen(new GetPloegenRequest { CompetitieId = competitie.Id });
                        foreach (Ploeg ploeg in ploegen.Ploegen)
                        {
                            ploeg.
                            //partij.Partijresultaten[0].BondsnummerThuisspeler;
                            GetStandenResponse standen = competitieService.GetStanden(new GetStandenRequest { AfdelingVerenigingPloegId = ploegen.Ploegen[0].Id, CompetitieId = competitie.Id, Filter = GetStandenRequestFilter.GetStandenForCompetitieAndPloeg });

                            foreach (Stand stand in standen.Standen)
                            {

                                GetUitslagenAfdelingResponse uitslagen = competitieService.GetUitslagenAfdeling(new GetUitslagenAfdelingRequest { AfdelingId = stand.AfdelingId.Value, CompetitieId = competitie.Id, PiramideId = stand.PiramideId });
                            }
                        }
                        */

                        //Console.WriteLine(ploegen.Ploegen[0].Id);
                        
                        //competitieService.GetVerenigingen(new GetVerenigingenRequest { CompetitieId = competitie.Id, Filter = GetVerenigingenFilter.VerenigingenFromIngedeeldePloeg });
                        
                        Console.WriteLine(competitie.Id);
                        Console.WriteLine(competitie.AantalPloegen);
                        Console.WriteLine(competitie.Naam);
                    }
                }


                
                

                /*
                competitie.GetStanden(new GetStandenRequest { AfdelingVerenigingPloegId = new Guid(), CompetitieId = new Guid(), Filter = GetStandenRequestFilter.GetStandenForCompetitieAndAfdeling });
                competitie.GetPloegen(new GetPloegenRequest { CompetitieId = new Guid() });
                competitie.GetPartijresultaten(new GetPartijresultatenRequest { WedstrijdgegevenId = new Guid() });

                GetCompetitiesResponse comps = competitie.GetCompetities(new GetCompetitiesRequest { Filter = GetCompetitiesFilter.CompetitiesMijnKnltb });
                //competitie.GetStanden(new GetStandenRequest{ Filter = GetStandenRequestFilter.}.GetPloegen(new GetPloegenRequest{ })
                foreach (ClubCloud.KNLTB.ServIt.CompetitieService.Competitie comp in comps.Competities)
                {
                    Console.WriteLine(comp.Id);
                    Console.WriteLine(comp.Naam);
                    Console.WriteLine(comp.Omschrijving);
                }
                */
                /*
                UserServiceClient client = new UserServiceClient(cc);
                HasAccessToCrmResponse acces = client.HasAccessToCrm(new HasAccessToCrmRequest { UserName = "27908313" });

                Console.WriteLine(acces.AccessPermitted);
                */
                /*
                Uri serverUri = new Uri("https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Services/LedenAdministratieService.svc");

                ChannelFactory<ClubCloud.KNLTB.ServIt.LedenAdministratieService.ILedenadministratieService> factory = new ChannelFactory<ClubCloud.KNLTB.ServIt.LedenAdministratieService.ILedenadministratieService>(new BasicHttpsBinding() { AllowCookies = true, HostNameComparisonMode = HostNameComparisonMode.WeakWildcard }, new EndpointAddress(serverUri));
                ClubCloud.KNLTB.ServIt.LedenAdministratieService.ILedenadministratieService client = factory.CreateChannel();
                factory.GetProperty<IHttpCookieContainerManager>().CookieContainer = cc;

                //ClubCloud.KNLTB.ServIt.UserService.UserServiceClient client = channel as UserServiceClient;
                ClubCloud.KNLTB.ServIt.LedenAdministratieService.GetMijnVerenigingenResponse response = client.GetMijnVerenigingen(new KNLTB.ServIt.LedenAdministratieService.GetMijnVerenigingenRequest { Bondsnummer = "27908313" });
                GetPersoonsgegevensResponse persoon = client.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = "27908313" });

                GetUserDistrictResponse district = client.GetUserDistrict(new GetUserDistrictRequest { Bondsnummer = "27908313" });


                Console.WriteLine(persoon.Persoonsgegevens.Geboortedatum);
                foreach (KNLTB.ServIt.LedenAdministratieService.Vereniging vereniging in response.Verenigingen)
                {
                    Console.WriteLine(vereniging.Id);
                    Console.WriteLine(vereniging.Naam);

                    GetVerenigingResponse verenigingdetails = client.GetVereniging(new KNLTB.ServIt.LedenAdministratieService.GetVerenigingRequest { Bondsnummer = "27908313", VerenigingId = vereniging.Id });
                    Console.WriteLine(verenigingdetails.Verenigingsnummer);                    
                }

                ((IChannel)client).Close();
                factory.Close();
                */

                /*
                Uri serverUri = new Uri("https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Services/UserService.svc");

                ChannelFactory<ClubCloud.KNLTB.ServIt.UserService.IUserService> factory = new ChannelFactory<ClubCloud.KNLTB.ServIt.UserService.IUserService>(new BasicHttpsBinding() { AllowCookies = true, HostNameComparisonMode = HostNameComparisonMode.WeakWildcard }, new EndpointAddress(serverUri));
                ClubCloud.KNLTB.ServIt.UserService.IUserService client = factory.CreateChannel();
                factory.GetProperty<IHttpCookieContainerManager>().CookieContainer = cc;

                //ClubCloud.KNLTB.ServIt.UserService.UserServiceClient client = channel as UserServiceClient;
                ClubCloud.KNLTB.ServIt.UserService.HasAccessToCrmResponse response = client.HasAccessToCrm(new KNLTB.ServIt.UserService.HasAccessToCrmRequest { UserName = "27908313" });
                Console.WriteLine(response.AccessPermitted);
                Console.WriteLine(response.ExtensionData);

                ((IChannel)client).Close();
                factory.Close();
                */

                /*
                ClubCloud.KNLTB.ServIt.MetadataService.MetadataService service = new KNLTB.ServIt.MetadataService.MetadataService();
                service.CookieContainer = cc;
                service.CrmAuthenticationTokenValue = new KNLTB.ServIt.MetadataService.CrmAuthenticationToken { AuthenticationType = 0, OrganizationName = "KNLTB", CrmTicket = string.Empty, CallerId = new Guid("00000000-0000-0000-0000-000000000000") };

                RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest();
                request.MetadataItems = MetadataItems.IncludeRelationships;
                RetrieveAllEntitiesResponse metadata = (RetrieveAllEntitiesResponse)service.Execute(request);
                WriteMetadata(metadata);
                */

                /*
                ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService();
                service.CallerOriginTokenValue = null; //new KNLTB.ServIt.CallerOriginToken{ CallerOrigin = new ClubCloud.KNLTB.ServIt.CallerOrigin{ }};
                service.CorrelationTokenValue = null; //new KNLTB.ServIt.CorrelationToken{ CorrelationId = new Guid("00000000-0000-0000-0000-000000000000")};
                service.CrmAuthenticationTokenValue = new KNLTB.ServIt.CrmService.CrmAuthenticationToken { AuthenticationType = 0, OrganizationName = "KNLTB", CrmTicket = string.Empty, CallerId = new Guid("00000000-0000-0000-0000-000000000000") };
                service.CrmCookieContainer = cc;

                WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                
                Console.WriteLine(response.BusinessUnitId);
                Console.WriteLine(response.OrganizationId);
                Console.WriteLine(response.UserId);
                */
                //GetUsersUsingExecute(service);
                /*
                service.ExecuteCompleted += service_ExecuteCompleted;
                //BusinessUnitId = 3cea4b0b-595b-e311-a846-02bf0aead617
                //OrganizationId = b005c89b-8c65-e311-b057-005056951a68
                //UserId = da8ad842-6bd5-e311-8e30-005056952140
                //addressid{B02845E0-B3C7-407B-B36B-AE6606506DFC}
                TargetRetrieveSgt_alg_baan acc = new TargetRetrieveSgt_alg_baan {};// { EntityId = new Guid("da8ad842-6bd5-e311-8e30-005056952140") };
                ClubCloud.KNLTB.ServIt.CrmService.ColumnSetBase columns = new ClubCloud.KNLTB.ServIt.CrmService.AllColumns();
                //ClubCloud.KNLTB.ServIt.CrmService.systemuser systemuser = service.Retrieve(ClubCloud.KNLTB.ServIt.CrmService.EntityName.systemuser.ToString(), new Guid("da8ad842-6bd5-e311-8e30-005056952140"), columns) as ClubCloud.KNLTB.ServIt.CrmService.systemuser;
                BusinessEntity entity = service.Retrieve("Sgt_alg_baan", new Guid("3cea4b0b-595b-e311-a846-02bf0aead617"), columns);
                Console.WriteLine(entity.ToString());
                //service.ExecuteAsync(new WhoAmIRequest());
                //WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                //Console.WriteLine(response.BusinessUnitId);
                //Console.WriteLine(response.OrganizationId);
                //Console.WriteLine(response.UserId);
                */

                /*
                string postData = "curl=Z2F&flags=0&forcedownlevel=0&formdir=12&trusted=0&username=12073385&password=rjm557308453%21&SubmitCreds=%C2%A0";
                HttpWebRequest request = WebRequest.CreateHttp("https://www.mijnknltb.nl/CookieAuth.dll?Logon");
                request.Method = "POST";
                */
                //request.Accept = "text/html, application/xhtml+xml, */*";
                /*
                request.Referer = "https://www.mijnknltb.nl/CookieAuth.dll?GetLogon?curl=Z2F&reason=2&formdir=12";
                request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US");
                request.Headers.Set(HttpRequestHeader.CacheControl, "no-cache");
                byte[] data = Encoding.ASCII.GetBytes(postData);
                request.ContentLength = data.Length;
                request.KeepAlive = true;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)request.GetResponse();

                int headcount = myHttpWebResponse.Headers.Count;
                string header = myHttpWebResponse.GetResponseHeader("Set-Cookie");
                int number = myHttpWebResponse.Cookies.Count;

                Stream responseStream = myHttpWebResponse.GetResponseStream();

                StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

                string pageContent = myStreamReader.ReadToEnd();

                myStreamReader.Close();
                responseStream.Close();

                myHttpWebResponse.Close();

                string bogus = pageContent.ToString();
                */
                /*
                HttpWebResponse  response = null;
                string URLAuth = "https://" + "mail.clubcloud.nl" + ":7071/zimbraAdmin/";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URLAuth);
                request.AllowAutoRedirect = false;

                request.KeepAlive = true;
                */
                //request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                /*
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.17 (KHTML, like Gecko) Chrome/24.0.1312.57 Safari/537.17";

                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip,deflate,sdch");

                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");

                request.Headers.Set(HttpRequestHeader.AcceptCharset, "ISO-8859-1,utf-8;q=0.7,*;q=0.3");

                response = (HttpWebResponse)request.GetResponse();
                */
                //ServerManager manager = new ServerManager();
                //Site site = manager.Sites["SharePoint Web Services"];

                //if (site != null)
                //{
                //    Configuration configuration = site.GetWebConfiguration();

                //    //SectionGroupCollection sections = configuration.RootSectionGroup.SectionGroups;
                //    SectionGroup zimbra = configuration.RootSectionGroup.SectionGroups.SingleOrDefault(section => section.Name == "Zimbra");

                //    if(zimbra == null )
                //    {
                //        //XmlNode sectionGroupNode = ZimbrasectionGroup();
                //        Microsoft.Web.Administration.Application root = site.Applications.SingleOrDefault(app => app.ApplicationPoolName == "SharePoint Web Services Root");
                //        string rootPath = root.VirtualDirectories.SingleOrDefault().PhysicalPath;
                //        XmlDocument rootConfig = GetWebConfig(rootPath + @"\web.config");

                //        AppendSectionGroupZimbra(ref rootConfig);
                //        rootConfig.Save(rootPath + @"\web.config");


                //        //sections.AppendChild(ZimbrasectionGroup());

                //        Microsoft.Web.Administration.Application sts = site.Applications.SingleOrDefault(app => app.ApplicationPoolName == "SecurityTokenServiceApplicationPool");
                //        string stsPath = sts.VirtualDirectories.FirstOrDefault().PhysicalPath;
                //        XmlDocument stsConfig = GetWebConfig(rootPath + @"\web.config");
                //    }

                //    /*
                //    foreach (Microsoft.Web.Administration.Application app in apps)
                //    {
                //        //"SecurityTokenServiceApplicationPool"
                //        //"SharePoint Web Services Root"
                //        string name = app.ApplicationPoolName;
                //        VirtualDirectoryCollection directories = app.VirtualDirectories;
                //        foreach (VirtualDirectory directory in directories)
                //        {
                //            string path = directory.PhysicalPath;
                //        }
                //    }
                //    */
                //    /*
                //    ConfigurationSection ZimbraSection = null;
                //    try
                //    {
                //        SectionGroup effective = configuration.GetEffectiveSectionGroup();
                //        SectionGroupCollection sections = configuration.RootSectionGroup.SectionGroups;
                //        SectionGroup zimbra = sections.Single(section => Name == "Zimbra");


                //        //ZimbraSection = configuration.GetSection("Zimbra/Configuration");
                //    }
                //    catch { }

                //    if (ZimbraSection != null)
                //    {

                //        ConfigurationElementCollection elements = ZimbraSection.GetCollection();
                //        foreach (ConfigurationElement element in elements)
                //        {
                //            string name = element.Attributes["name"].Value.ToString();
                //        }
                //    }
                //    */
                //}

                /*
                GetAccountMembershipRequest request = new GetAccountMembershipRequest { account = new accountSelector { by = accountBy.Name, Value = "12073385@clubcloud.nl" } };
                GetAccountMembershipResponse response = server.Message(request) as GetAccountMembershipResponse;

                List<Global.dlInfo> dls = response.dl;
                foreach (Global.dlInfo dl in dls)
                {
                    string dl_id = dl.id;

                    GetDistributionListRequest dlrequest = new GetDistributionListRequest { dl = new Global.distributionListSelector { by = Global.distributionListBy.id, Value = dl_id }, };
                    GetDistributionListResponse dlresponse = server.Message(dlrequest) as GetDistributionListResponse;

                    List<string> members = dlresponse.dl.dlm;
                    int number = members.Count;

                    
                    List<Global.attrN> attributes = dlresponse.dl.a;
                    string displayName = dlresponse.dl.name;
                    foreach (Global.attrN attr in attributes)
                    {
                        if (attr.name == "displayName")
                        {
                            displayName = attr.Value;
                            break;
                        }
                    }
                    displayName = displayName.ToLower();
                    
                    string name = dl.name;

                }
                */
                /*
                StringBuilder returnUrl = new StringBuilder();
                string url = "http://www.clubcloud.nl/pages/default.aspx";
                Uri uri = new Uri(url);
                if (uri.HostNameType == UriHostNameType.Dns)
                {
                    string[] parts = uri.DnsSafeHost.Split(new char[] { '.' });
                    if (parts.Length > 0)
                    {
                        if (parts.Length == 2)
                        {
                            returnUrl.Append(parts[0] + "." + parts[1]);
                        }

                        if (parts.Length == 3)
                        {
                            if ((parts[1].ToLower() == "clubcloud") && (parts[0].ToLower() != "www"))
                            {
                                returnUrl.Append(parts[0] + "." + parts[2]);
                            }
                            else
                            {
                                returnUrl.Append(parts[1] + "." + parts[2]);
                            }
                        }
                    }

                }

                GetAllAccountsRequest request = new GetAllAccountsRequest { domain = new domainSelector { by = domainBy.name, Value = returnUrl.ToString() }, server = null };
                GetAllAccountsResponse response = server.Message(request) as GetAllAccountsResponse;

                if (response != null)
                {
                    List<accountInfo> accounts = response.account;
                }
                */
                /*
                List<string> users = new List<string>();

                SearchDirectoryRequest srequest = new SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = returnUrl.ToString(), limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                srequest.query = String.Format("(|(mail=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", textBox1.Text);

                SearchDirectoryResponse sresponse = server.Message(srequest) as SearchDirectoryResponse;
                List<accountInfo> accounts = sresponse.Items.ConvertAll<accountInfo>(delegate (object o){return o as accountInfo;});

                if (accounts.Count > 0)
                {
                    string dl_id = null;
                    Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = returnUrl.ToString() } };
                    Zimbra.Administration.GetAllDistributionListsResponse response = server.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                    if (response != null)
                    {
                        foreach (Zimbra.Global.distributionListInfo dl in response.dl)
                        {
                            if (dl.dynamic)
                            {
                                List<Zimbra.Global.attrN> attributes = dl.a;
                                string displayName = dl.id;
                                foreach (Zimbra.Global.attrN attr in attributes)
                                {
                                    if (attr.name == "displayName" && attr.Value == "Leden")
                                    {
                                        dl_id = dl.id;
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(dl_id))
                    {
                        Zimbra.Administration.GetDistributionListRequest dlrequest = new Zimbra.Administration.GetDistributionListRequest { dl = new Zimbra.Global.distributionListSelector { by = Zimbra.Global.distributionListBy.id, Value = dl_id } };
                        Zimbra.Administration.GetDistributionListResponse dlresponse = server.Message(dlrequest) as Zimbra.Administration.GetDistributionListResponse;

                        if (dlresponse != null)
                        {
                            foreach (string member in dlresponse.dl.dlm)
                            {
                                accountInfo account = accounts.Find(a => a.name.Equals(member));
                                if (account != null)
                                {
                                    users.Add(account.a.Single<attrN>(a => a.name == "displayName").Value);
                                }
                            }
                        }
                    }
                }

                int total = users.Count;
                */
                /*
                Zimbra.Administration.GetAllDistributionListsRequest request = new Zimbra.Administration.GetAllDistributionListsRequest { domain = new Zimbra.Global.domainSelector { by = Zimbra.Global.domainBy.name, Value = returnUrl.ToString() } };
                Zimbra.Administration.GetAllDistributionListsResponse response = server.Message(request) as Zimbra.Administration.GetAllDistributionListsResponse;

                foreach (ClubCloud.Zimbra.Global.distributionListInfo dl in response.dl)
                {
                    List<Global.attrN> attributes = dl.a;
                    List<string> members = dl.dlm;

                    string displayName = dl.name;
                    foreach (Global.attrN attr in attributes)
                    {
                        if (attr.name == "displayName")
                        {
                            displayName = attr.Value;
                            break;
                        }
                    }
                    displayName = displayName.ToLower();
                    string name = dl.name;
                    
                }
                */
                /*
                string zimbraId = null;

                Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "info@clubcloud.nl" } };
                Zimbra.Administration.GetAccountInfoResponse response = server.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
                if (response != null)
                {

                    foreach (var item in response.a)
                    {
                        if (item.name == "zimbraId")
                        {
                            zimbraId = item.Value;
                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(zimbraId))
                {
                    List<attrN> password = new List<attrN>();
                    password.Add(new attrN { name = "userPassword", Value = "rjm557308453!" });

                    Zimbra.Administration.ModifyAccountRequest modify = new Zimbra.Administration.ModifyAccountRequest { id = zimbraId, a = password };
                    Zimbra.Administration.ModifyAccountResponse modified = server.Message(modify) as Zimbra.Administration.ModifyAccountResponse;

                    string id = modified.account.id;
                }
                */

                //Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "12073385@clubcloud.nl" }, applyCos = true};//, attrs = "displayName" };
                //Zimbra.Administration.GetAccountResponse response = server.Message(request) as Zimbra.Administration.GetAccountResponse;
                //if (response != null)
                //{
                //    string name = response.account.a[0].Value;
                //}

                //Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "info@clubcloud.nl" } };
                //Zimbra.Administration.GetAccountInfoResponse response = server.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
                //if (response != null)
                //{
                //    string name = response.name;
                //}

                //zimbraPasswordMaxLength,zimbraPasswordMinLength,zimbraPasswordMinLowerCaseChars,zimbraPasswordMinAlphaChars,zimbraPasswordMinNumericChars,zimbraPasswordMinDigitsOrPuncs,zimbraPasswordMinPunctuationChars,zimbraPasswordMinUpperCaseChars,zimbraPasswordAllowedChars,zimbraPasswordAllowedPunctuationChars
                //zimbraPasswordLockoutDuration,zimbraPasswordLockoutEnabled,zimbraPasswordLockoutMaxFailures

                //GetCosRequest request = new GetCosRequest { cos = new cosSelector { by = cosBy.name, Value = "clubcloud" }, attrs = "zimbraPasswordMaxLength,zimbraPasswordMinLength" };
                //GetCosResponse response = server.Message(request) as GetCosResponse;

                //foreach (var item in response.cos.a)
                //{
                //    PropertyInfo propertyInfo = this.GetType().GetProperty(item.name);
                //    Type t = propertyInfo.PropertyType;

                //    if (propertyInfo.PropertyType == typeof(string))// || t == typeof(Array))
                //    {
                //        propertyInfo.SetValue(this, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                //    }
                //    else
                //    {
                //        IList attr = (IList)propertyInfo.GetValue(this);
                //        if (attr != null)
                //        {
                //            attr.Add("string");
                //            if (attr.Contains("string"))
                //            {
                //                Console.Write("string found");
                //            }

                //            propertyInfo.SetValue(this, attr);
                //            Console.Write(this.zimbraPasswordMaxLength);

                //        }
                //    }
                //    //propertyInfo.SetValue(this, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                //}

                //int z = zimbraPasswordMinLength;
                //string name = response.cos.name;

                /*
                Zimbra.Account.ChangePasswordRequest request = new Zimbra.Account.ChangePasswordRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username }, oldPassword = oldPassword, password = newPassword };
                Zimbra.Account.ChangePasswordResponse response = clientServer.Message(request) as Zimbra.Account.ChangePasswordResponse;
                string AuthToken = response.authToken;
                */

                /*
                CreateDomainRequest createdomain = new CreateDomainRequest { name = "centralweb.nl" };
                createdomain.a.Add(new attrN { name = "zimbraDomainType", Value = "alias" });
                createdomain.a.Add(new attrN { name = "zimbraDomainAliasTargetId", Value = "5e69fe13-6ba0-45df-9135-e079c64b4521" });
                createdomain.a.Add(new attrN { name = "description", Value = "domeinalias van clubcloud.nl" });
                createdomain.a.Add(new attrN { name = "zimbraMailCatchAllAddress", Value = "@centralweb.nl" });
                createdomain.a.Add(new attrN { name = "zimbraMailCatchAllForwardingAddress", Value = "@clubcloud.nl" });
                createdomain.a.Add(new attrN { name = "zimbraSkinLogoURL", Value = "http://www.centralweb.nl" });

                CreateDomainResponse createdomainresponse = server.Message(createdomain) as CreateDomainResponse;
                string name = createdomainresponse.domain.name;
                */
                /*
                Account.GetAccountInfoRequest message = new Account.GetAccountInfoRequest();
                //message.account = new Global.accountSelector { Value = "d0ec1768-02dd-4fd3-b302-1da0cd6e868a", by = accountBy.Id };
                message.account = new Global.accountSelector { Value = "info@clubcloud.nl", by = Global.accountBy.Name };

                Account.GetAccountInfoResponse response = server.Message(message) as Account.GetAccountInfoResponse;
                string publicURL = response.publicURL;
                */
                /*
                GetDomainRequest domainrequest = new GetDomainRequest { domain = new domainSelector { by = domainBy.name, Value = "clubcloud.nl" } };
                GetDomainResponse domainresponse = server.Message(domainrequest) as GetDomainResponse;

                domainInfo domain = domainresponse.domain;
                //string name = domain.name;
                */

                /*
                ModifyDomainRequest modifyDomainrequest = new ModifyDomainRequest { id = "5e69fe13-6ba0-45df-9135-e079c64b4521" };
                modifyDomainrequest.a.Add(new Global.attrN { name = "zimbraSkinLogoURL", Value = "http://www.clubcloud.nl" });
                ModifyDomainResponse modifyDomainresponse = server.Message(modifyDomainrequest) as ModifyDomainResponse;

                string name = modifyDomainresponse.domain.name;
                */

                /*
                GetAllDomainsRequest domainsrequest = new GetAllDomainsRequest { applyConfig = false };
                GetAllDomainsResponse domainsresponse = server.Message(domainsrequest) as GetAllDomainsResponse;

                List<domainInfo> domains = domainsresponse.Domains;

                foreach (domainInfo domain in domains)
                {
                    string id = domain.id;
                    string name = domain.name;
                    List<Global.attr> aa = domain.a;

                    foreach (Global.attr a in aa)
                    {
                        string a_name = a.name;
                        string a_value = a.Value;
                        bool a_pd = a.pd;
                    }
                }
                */
                /*
                GetInfoRequest info = new GetInfoRequest{ sections = infoSection.All.ToString() };
                GetInfoResponse inforesponse = server.Message(info) as GetInfoResponse;
                List<prop> props = inforesponse.props;
                */

            }
            catch (FaultException fex)
            {
                Console.Write(fex.Message);
            }
            catch (SoapException sex)
            {
                Console.WriteLine(sex.Detail);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            //Application.Exit();

        }

        private void GetUsersUsingExecute(ClubCloud.KNLTB.ServIt.CrmService.CrmService service)
        {
            RetrieveMultipleResponse results = null;
            int pageNum = 1;
            while (results == null || (results != null && results.BusinessEntityCollection.MoreRecords))
            {

                // specify the columns we want to return
                ColumnSetBase cols = new AllColumns();
                //cols.Attributes = new string[] { "domainname", "systemuserid" };

                // Create the FilterExpression.
                FilterExpression filter = new FilterExpression();

                PagingInfo pageInfo = new PagingInfo();
                pageInfo.Count = 100; // the number of rows in each batch
                pageInfo.PageNumber = pageNum;

                // Create the QueryExpression.
                QueryExpression query = new QueryExpression();

                // Set the properties of the QueryExpression.
                //sgt_alg_ledenpas_vereniging
                //organization
                //sgt_alg_kenmerk
                //sgt_alg_administratie
                //sgt_alg_bestuursorgaan
                //sgt_alg_functie
                //sgt_alg_functionaris
                //sgt_alg_gebeurtenis
                //sgt_alg_type_bestuursorgaan
                //sgt_alg_district
                //systemuser
                query.EntityName = "systemuser";//EntityName.systemuser.ToString();
                query.ColumnSet = cols;
                query.Criteria = filter;
                query.PageInfo = pageInfo;
                query.Distinct = true;

                // Create the request object.
                RetrieveMultipleRequest request = new RetrieveMultipleRequest();

                // Set the properties of the request object.
                request.Query = query;

                // Execute the request.
                results = (RetrieveMultipleResponse)service.Execute(request);


                List<BusinessEntity> entities = results.BusinessEntityCollection.BusinessEntities.ToList<BusinessEntity>();
                foreach (systemuser entity in entities)
                {
                    string sentity = SerializeObjectList<systemuser>(entity);
                    WriteToXmlFile<systemuser>(@"C:\systemuser.xml", entity, true);
                }
                
                /*
                foreach (sgt_alg_bestuursorgaan entity in entities)
                {
                    if (entity != null)
                    {
                        Console.WriteLine(entity.sgt_alg_bestuursorgaan1);
                        Console.WriteLine(entity.sgt_alg_bestuursorgaanid.Value);
                        Console.WriteLine(entity.sgt_basisorganisatieid.name + " | " + entity.sgt_basisorganisatieid.Value);
                        Console.WriteLine(entity.sgt_beschrijving);
                        Console.WriteLine(entity.sgt_typebestuursorgaanid.Value);
                        Console.WriteLine(entity.statecode.Value + " | " + entity.statecode.formattedvalue);
                        Console.WriteLine(entity.sgt_verkorte_code);
                    }
                }
                */
                /*
                foreach (systemuser user in users)
                {
                    Console.WriteLine(user.systemuserid.Value + " | " + user.domainname + " | " + user.sgt_persoonid + " | " + user.fullname + " | " + user.organizationid + " | " + user.businessunitid);
                }
                */

                pageNum++;
            } // end while

        }

        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            catch
            {
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static string SerializeObjectList<T>(T value)
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

        private void WriteMetadata(RetrieveAllEntitiesResponse metadata)
        {
            // Create an instance of StreamWriter to write text to a file.
            // The using statement also closes the StreamWriter.
            using (StreamWriter sw = new StreamWriter(@"C:\metadata.xml"))
            {
                // Create Xml Writer.
                XmlTextWriter metadataWriter = new XmlTextWriter(sw);

                // Start Xml File.
                metadataWriter.WriteStartDocument();

                // Metadata Xml Node.
                metadataWriter.WriteStartElement("Metadata");

                AttributeMetadata currentAttribute;// Declared outside of loop

                // Iterate through all entities and add their attributes and relationships to the file.
                foreach (EntityMetadata currentEntity in metadata.CrmMetadata)
                {
                    // Start Entity Node
                    metadataWriter.WriteStartElement("Entity");

                    // Write the Entity's Information.
                    metadataWriter.WriteElementString("Name", currentEntity.LogicalName);

                    if (currentEntity.DisplayName.UserLocLabel != null)
                    {
                        metadataWriter.WriteElementString("DisplayName", currentEntity.DisplayName.UserLocLabel.Label);
                    }
                    else
                    {
                        metadataWriter.WriteElementString("DisplayName", "[NONE]");
                    }

                    if (currentEntity.DisplayCollectionName.UserLocLabel != null)
                    {
                        metadataWriter.WriteElementString("DisplayCollectionName", currentEntity.DisplayCollectionName.UserLocLabel.Label);
                    }
                    else
                    {
                        metadataWriter.WriteElementString("DisplayCollectionName", "[NONE]");
                    }

                    metadataWriter.WriteElementString("IsCustomEntity", currentEntity.IsCustomEntity.ToString());
                    metadataWriter.WriteElementString("IsCustomizable", currentEntity.IsCustomizable.ToString());
                    metadataWriter.WriteElementString("ReportViewName", currentEntity.ReportViewName);
                    metadataWriter.WriteElementString("PrimaryField", currentEntity.PrimaryField);
                    metadataWriter.WriteElementString("PrimaryKey", currentEntity.PrimaryKey);

                    #region Attributes

                    // Write Entity's Attributes.
                    metadataWriter.WriteStartElement("Attributes");

                    for (int j = 0; j < currentEntity.Attributes.Length; j++)
                    {
                        // Get Current Attribute.
                        currentAttribute = currentEntity.Attributes[j];
                        // Start Attribute Node
                        metadataWriter.WriteStartElement("Attribute");

                        // Write Attribute's information.
                        metadataWriter.WriteElementString("Name", currentAttribute.LogicalName);
                        metadataWriter.WriteElementString("Type", currentAttribute.AttributeType.ToString());

                        if (currentAttribute.DisplayName.UserLocLabel != null)
                        {
                            metadataWriter.WriteElementString("DisplayName", currentAttribute.DisplayName.UserLocLabel.Label);
                        }
                        else
                        {
                            metadataWriter.WriteElementString("DisplayName", "[NONE]");
                        }

                        metadataWriter.WriteElementString("Description", currentAttribute.IsCustomField.ToString());
                        metadataWriter.WriteElementString("IsCustomField", currentAttribute.IsCustomField.ToString());
                        metadataWriter.WriteElementString("RequiredLevel", currentAttribute.RequiredLevel.ToString());
                        metadataWriter.WriteElementString("ValidForCreate", currentAttribute.ValidForCreate.ToString());
                        metadataWriter.WriteElementString("ValidForRead", currentAttribute.ValidForRead.ToString());
                        metadataWriter.WriteElementString("ValidForUpdate", currentAttribute.ValidForUpdate.ToString());

                        // Write the Default Value if it is set.
                        if (currentAttribute.DefaultValue != null)
                        {
                            metadataWriter.WriteElementString("DefualtValue", currentAttribute.DefaultValue.ToString());
                        }

                        // Write the Description if it is set.
                        if (currentAttribute.Description != null &&
                           currentAttribute.Description.UserLocLabel != null)
                        {
                            metadataWriter.WriteElementString("Description", currentAttribute.Description.UserLocLabel.Label);
                        }


                        // Write Type Specific Attribute Information using helper functions.

                        Type attributeType = currentAttribute.GetType();

                        if (attributeType == typeof(DecimalAttributeMetadata))
                        {
                            writeDecimalAttribute((DecimalAttributeMetadata)currentAttribute, metadataWriter);
                        }
                        else if (attributeType == typeof(FloatAttributeMetadata))
                        {
                            writeFloatAttribute((FloatAttributeMetadata)currentAttribute, metadataWriter);
                        }
                        else if (attributeType == typeof(IntegerAttributeMetadata))
                        {
                            writeIntegerAttribute((IntegerAttributeMetadata)currentAttribute, metadataWriter);
                        }
                        else if (attributeType == typeof(MoneyAttributeMetadata))
                        {
                            writeMoneyAttribute((MoneyAttributeMetadata)currentAttribute, metadataWriter);
                        }
                        else if (attributeType == typeof(PicklistAttributeMetadata))
                        {
                            writePicklistAttribute((PicklistAttributeMetadata)currentAttribute, metadataWriter);
                        }
                        else if (attributeType == typeof(StateAttributeMetadata))
                        {
                            writeStateAttribute((StateAttributeMetadata)currentAttribute, metadataWriter);
                        }
                        else if (attributeType == typeof(StatusAttributeMetadata))
                        {
                            writeStatusAttribute((StatusAttributeMetadata)currentAttribute, metadataWriter);
                        }
                        else if (attributeType == typeof(StringAttributeMetadata))
                        {
                            writeStringAttribute((StringAttributeMetadata)currentAttribute, metadataWriter);
                        }

                        // End Attribute Node
                        metadataWriter.WriteEndElement();

                    }
                    // End Attributes Node
                    metadataWriter.WriteEndElement();

                    #endregion

                    #region References From

                    metadataWriter.WriteStartElement("OneToMany");

                    // Get Current ReferencesFrom
                    foreach (OneToManyMetadata currentRelationship in currentEntity.OneToManyRelationships)
                    {
                        // Start ReferencesFrom Node
                        metadataWriter.WriteStartElement("From");
                        metadataWriter.WriteElementString("Name", currentRelationship.SchemaName);
                        metadataWriter.WriteElementString("IsCustomRelationship", currentRelationship.IsCustomRelationship.ToString());
                        metadataWriter.WriteElementString("ReferencedEntity", currentRelationship.ReferencedEntity);
                        metadataWriter.WriteElementString("ReferencingEntity", currentRelationship.ReferencingEntity);
                        metadataWriter.WriteElementString("ReferencedAttribute", currentRelationship.ReferencedAttribute);
                        metadataWriter.WriteElementString("ReferencingAttribute", currentRelationship.ReferencingAttribute);

                        // End ReferencesFrom Node
                        metadataWriter.WriteEndElement();
                    }

                    metadataWriter.WriteEndElement();

                    #endregion

                    #region References To

                    metadataWriter.WriteStartElement("ManyToOne");

                    foreach (OneToManyMetadata currentRelationship in currentEntity.ManyToOneRelationships)
                    {
                        // Start ReferencesFrom Node
                        metadataWriter.WriteStartElement("To");
                        metadataWriter.WriteElementString("Name", currentRelationship.SchemaName);
                        metadataWriter.WriteElementString("IsCustomRelationship", currentRelationship.IsCustomRelationship.ToString());
                        metadataWriter.WriteElementString("ReferencedEntity", currentRelationship.ReferencedEntity);
                        metadataWriter.WriteElementString("ReferencingEntity", currentRelationship.ReferencingEntity);
                        metadataWriter.WriteElementString("ReferencedAttribute", currentRelationship.ReferencedAttribute);
                        metadataWriter.WriteElementString("ReferencingAttribute", currentRelationship.ReferencingAttribute);

                        // End ReferencesFrom Node
                        metadataWriter.WriteEndElement();
                    }

                    metadataWriter.WriteEndElement();

                    #endregion

                    // End Entity Node
                    metadataWriter.WriteEndElement();
                }

                // End Metadata Xml Node
                metadataWriter.WriteEndElement();
                metadataWriter.WriteEndDocument();

                // Close xml writer.
                metadataWriter.Close();
            }

        }

        #region Specific Attribute Helper Functions

        // Writes the Decimal Specific Attributes
        private static void writeDecimalAttribute(DecimalAttributeMetadata attribute, XmlTextWriter writer)
        {
            writer.WriteElementString("MinValue", attribute.MinValue.ToString());
            writer.WriteElementString("MaxValue", attribute.MaxValue.ToString());
            writer.WriteElementString("Precision", attribute.Precision.ToString());
        }

        // Writes the Float Specific Attributes
        private static void writeFloatAttribute(FloatAttributeMetadata attribute, XmlTextWriter writer)
        {
            writer.WriteElementString("MinValue", attribute.MinValue.ToString());
            writer.WriteElementString("MaxValue", attribute.MaxValue.ToString());
            writer.WriteElementString("Precision", attribute.Precision.ToString());
        }

        // Writes the Integer Specific Attributes
        private static void writeIntegerAttribute(IntegerAttributeMetadata attribute, XmlTextWriter writer)
        {
            writer.WriteElementString("MinValue", attribute.MinValue.ToString());
            writer.WriteElementString("MaxValue", attribute.MaxValue.ToString());
        }

        // Writes the Money Specific Attributes
        private static void writeMoneyAttribute(MoneyAttributeMetadata attribute, XmlTextWriter writer)
        {
            writer.WriteElementString("MinValue", attribute.MinValue.ToString());
            writer.WriteElementString("MaxValue", attribute.MaxValue.ToString());
            writer.WriteElementString("Precision", attribute.Precision.ToString());
        }

        // Writes the Picklist Specific Attributes
        private static void writePicklistAttribute(PicklistAttributeMetadata attribute, XmlTextWriter writer)
        {
            // Writes the picklist's options
            writer.WriteStartElement("Options");

            // Writes the attributes of each picklist option
            for (int i = 0; i < attribute.Options.Length; i++)
            {
                writer.WriteStartElement("Option");
                writer.WriteElementString("OptionValue", attribute.Options[i].Value.ToString());
                writer.WriteElementString("Description", attribute.Options[i].Label.UserLocLabel.Label);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        // Writes the State Specific Attributes
        private static void writeStateAttribute(StateAttributeMetadata attribute, XmlTextWriter writer)
        {
            // Writes the state's options
            writer.WriteStartElement("Options");

            // Writes the attributes of each picklist option
            for (int i = 0; i < attribute.Options.Length; i++)
            {
                writer.WriteStartElement("Option");
                writer.WriteElementString("OptionValue", attribute.Options[i].Value.ToString());
                writer.WriteElementString("Description", attribute.Options[i].Label.UserLocLabel.Label);
                writer.WriteElementString("DefaultStatus", attribute.Options[i].DefaultStatus.ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        // Writes the Status Specific Attributes
        private static void writeStatusAttribute(StatusAttributeMetadata attribute, XmlTextWriter writer)
        {
            // Writes the status's options
            writer.WriteStartElement("Options");

            // Writes the attributes of each picklist option
            for (int i = 0; i < attribute.Options.Length; i++)
            {
                writer.WriteStartElement("Option");
                writer.WriteElementString("OptionValue", attribute.Options[i].Value.ToString());
                writer.WriteElementString("Description", attribute.Options[i].Label.UserLocLabel.Label);
                writer.WriteElementString("State", attribute.Options[i].State.ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        // Writes the String Specific Attributes
        private static void writeStringAttribute(StringAttributeMetadata attribute, XmlTextWriter writer)
        {
            writer.WriteElementString("MaxLength", attribute.MaxLength.ToString());
        }
        #endregion

        
        private void service_ExecuteCompleted(object sender, KNLTB.ServIt.CrmService.ExecuteCompletedEventArgs e)
        {
            ClubCloud.KNLTB.ServIt.CrmService.WhoAmIResponse response = e.Result as ClubCloud.KNLTB.ServIt.CrmService.WhoAmIResponse;
            Console.WriteLine(response.BusinessUnitId);
            Console.WriteLine(response.OrganizationId);
            Console.WriteLine(response.UserId);
        }

        void server_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.Write(server.Authenticated.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
