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
using ClubCloud.KNLTB.ServIt;
using System.Web.Services.Protocols;
using ClubCloud.KNLTB.ServIt.CrmService;
using ClubCloud.KNLTB.ServIt.MetadataService;
using System.ServiceModel.Channels;
using Microsoft.SharePoint;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Web.UI;
using ClubCloud.Service;
using ClubCloud.Model;
using System.Net.Mail;
using System.Threading;
using ClubCloud.Common.Mail;
using System.Xml.Linq;
using Microsoft.SharePoint.Administration;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Globalization;

namespace ClubCloud.Zimbra.Client
{
    public partial class Form1 : Form
    {
        //private static ZimbraServer server;

        private List<string> _zimbraPasswordMaxLength;

        public List<string> zimbraPasswordMaxLength
        {
            get
            {
                if (_zimbraPasswordMaxLength == null)
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
            XmlNode sectionGroup = rootConfig.CreateNode(XmlNodeType.Element, "sectionGroup", "");
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
                ColumnSetBase cols = new AllColumns();
                if (cc == null)
                {
                    ClubCloud.KNLTB.Security.KNLTBContainer container = new KNLTB.Security.KNLTBContainer();
                    container.MijnRequestAcces("12073385", "rjm557308453!");
                    //container.ServItRequestAcces("27908313", "rjm557308453!");

                    while (container.Container == null) { }
                    cc = container.Container;
                }

                ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);                
                GetUsersUsingExecute(service);

                /*
                ClubCloud.KNLTB.Media.KNLTBFoto foto = new KNLTB.Media.KNLTBFoto();

                Tuple<Image, string, long> result = Task.Run(async () => await foto.RequestFotoAsync("12073385", cc)).Result;
                pictureBox1.Image = result.Item1;
                pictureBox1.Height = pictureBox1.Image.Height;
                pictureBox1.Width = pictureBox1.Image.Width;
                MemoryStream ms = new MemoryStream();
                */

                //pictureBox1.Image = result.Item1;                
                //MemoryStream ms = new MemoryStream();
                //result.Item1.Save(ms,System.Drawing.Imaging.ImageFormat.Gif);
                //byte[] contentData =  ms.ToArray();

                /*
                pictureBox1.Image = Image.FromFile(@"C:\TempImageFiles\Rutger_Hemrika_Profiel.jpg");
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                byte[] contentData = ms.ToArray();

                foto.ServitUploadFoto("12073385", contentData, "image/jpeg", contentData.Length, cc);
                */

                /*
                ClubCloud.KNLTB.Media.KNLTBFoto foto = new KNLTB.Media.KNLTBFoto();
                string number = textBox1.Text;
                foto.RequestFoto(number, cc);
                Image data = foto.Foto;
                string contenttype = foto.ContentType;
                long contentlength = foto.ContentLength;
                pictureBox1.Image = data;
                pictureBox1.Height = pictureBox1.Image.Height;
                pictureBox1.Width = pictureBox1.Image.Width;
                MemoryStream ms = new MemoryStream();
                data.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                byte[] ContentData = ms.ToArray();
                Console.Write(ContentData.LongLength);
                */

                /*
                ClubCloud.KNLTB.ServIt.MetadataService.MetadataService service = new KNLTB.ServIt.MetadataService.MetadataService(cc);
                RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest();
                request.MetadataItems = MetadataItems.IncludeRelationships;
                //request.RetrieveAsIfPublished = true;
                RetrieveAllEntitiesResponse metadata = (RetrieveAllEntitiesResponse)service.Execute(request);
                WriteMetadata(metadata);
                */
                /*
                ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
                //service.ExecuteAsync(new WhoAmIRequest());
                //System.Threading.Thread.Sleep(5000);
                WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                Console.WriteLine(response.BusinessUnitId);
                Console.WriteLine(response.OrganizationId);
                Console.WriteLine(response.UserId);
                */

                //service.CallerOriginTokenValue = null; //new KNLTB.ServIt.CallerOriginToken{ CallerOrigin = new ClubCloud.KNLTB.ServIt.CallerOrigin{ }};
                //service.CorrelationTokenValue = null; //new KNLTB.ServIt.CorrelationToken{ CorrelationId = new Guid("00000000-0000-0000-0000-000000000000")};
                //service.CrmAuthenticationTokenValue = new KNLTB.ServIt.CrmService.CrmAuthenticationToken { AuthenticationType = 0, OrganizationName = "KNLTB", CrmTicket = string.Empty, CallerId = new Guid("00000000-0000-0000-0000-000000000000") };
                //service.CrmCookieContainer = cc;

                /*
                WhoAmIResponse whoAmIResponse = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;

                
                TargetRetrieveSgt_alg_lidmaatschap lidmaatschap = new TargetRetrieveSgt_alg_lidmaatschap{ EntityId = whoAmIResponse.OrganizationId };
                RetrieveRequest lidmaatschaprequest = new RetrieveRequest { Target = lidmaatschap, ColumnSet = new AllColumns(), ReturnDynamicEntities = true };
                Response response = service.Execute(lidmaatschaprequest);
                */
                /*
                sgt_dss_spelersprofiel profiel = new sgt_dss_spelersprofiel();

                TargetRetrieveSgt_dss_spelersprofiel profielRequest = new TargetRetrieveSgt_dss_spelersprofiel { };
                RetrieveRequest request = new RetrieveRequest { Target = profielRequest, ColumnSet = new AllColumns(), ReturnDynamicEntities = true };
                */

                //WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                //QueryBase query = new QueryBase{ EntityName = "Actieve Lidmaatschappen", ColumnSet = new AllColumns()};
                //service.RetrieveMultiple(new QueryBase { EntityName = "Actieve Lidmaatschappen", ColumnSet = new AllColumns() });

                //string ts = response.ToString();
                //Console.WriteLine(response.BusinessUnitId);
                //Console.WriteLine(response.OrganizationId);
                //Console.WriteLine(response.UserId);



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



            }
            catch (FaultException fex)
            {
                Console.Write(fex.Message);
            }
            catch (SoapException sex)
            {
                Console.WriteLine(sex.Detail);
            }
            catch (WebException wex)
            {
                WebExceptionStatus status = wex.Status;
                HttpWebResponse response = wex.Response as HttpWebResponse;
                HttpStatusCode code = response.StatusCode;

                Console.Write(wex.Message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            //Application.Exit();

        }

        private void FetchResult(CrmService service)
        {
            string fetchXml = "<fetch mapping=\"logical\" count=\"30\" version=\"1.0\"><entity name=\"sgt_alg_accommodatie\"><attribute name=\"sgt_aantal_minibanen\" /><attribute name=\"sgt_aantal_oefenmuren\" /><attribute name=\"sgt_aantal_playgrounds\" /><attribute name=\"sgt_alg_accommodatie\" /><attribute name=\"sgt_alg_accommodatieid\" /><attribute name=\"sgt_bezoekadres_gemeente\" /><attribute name=\"sgt_bezoekadres_huisnummer\" /><attribute name=\"sgt_bezoekadres_plaats\" /><attribute name=\"sgt_bezoekadres_postcode\" /><attribute name=\"sgt_bezoekadres_straat\" /><attribute name=\"sgt_bezoekadres_toevoeging\" /><attribute name=\"sgt_minibanen\" /><attribute name=\"sgt_oefenmuren\" /><attribute name=\"sgt_playgrounds\" /><attribute name=\"sgt_speeltoestellen\" /><attribute name=\"sgt_telefoon\" /><attribute name=\"sgt_tenniskids_huisstijl\" /><link-entity name=\"sgt_alg_soort_verlichting\" from=\"sgt_alg_soort_verlichtingid\" to=\"sgt_soortverlichtingid\" link-type=\"outer\"><attribute name=\"sgt_alg_soort_verlichting\" /></link-entity><link-entity name=\"sgt_alg_toplaag\" from=\"sgt_alg_toplaagid\" to=\"sgt_toplaag_minibanenid\" link-type=\"outer\"><attribute name=\"sgt_alg_toplaag\" /></link-entity><link-entity name=\"sgt_alg_toplaag\" from=\"sgt_alg_toplaagid\" to=\"sgt_toplaag_oefenmurenid\" link-type=\"outer\"><attribute name=\"sgt_alg_toplaag\" /></link-entity><link-entity name=\"sgt_alg_toplaag\" from=\"sgt_alg_toplaagid\" to=\"sgt_toplaag_playgroundid\" link-type=\"outer\"><attribute name=\"sgt_alg_toplaag\" /></link-entity><link-entity name=\"account\" from=\"sgt_hoofdaccomodatieid\" to=\"sgt_alg_accommodatieid\"><filter><condition attribute=\"accountid\" operator=\"eq\" value=\"{organisatieid}\" /><condition attribute=\"statecode\" operator=\"eq\" value=\"0\" /></filter></link-entity></entity></fetch>";
            ExecuteFetchRequest request = new ExecuteFetchRequest { FetchXml = fetchXml };
            ExecuteFetchResponse response = service.Execute(request) as ExecuteFetchResponse;
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
                //FilterExpression expression = new FilterExpression();

                //contact
                //sgt_bondsnummer
                //contactid
                //string bondnummer = "19949820";
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { bondnummer } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_baan_gereserveerd
                //sgt_accomodatieid
                //sgt_verenigingid
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accomodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029f99-522e-4fc4-a86d-694e003f8bb2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_baan_gereserveerd_vereniging
                //sgt_accommodatieid 11029f99-522e-4fc4-a86d-694e003f8bb2
                //sgt_verenigingid 02ada6c7-80f9-4671-91f9-898ea5da3ccd
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029f99-522e-4fc4-a86d-694e003f8bb2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_speciale_baan
                //sgt_accommodatieid
                //{118D1A88-00C9-461A-9ECB-7411D1AB0EA1}
                //{11029F99-522E-4FC4-A86D-694E003F8BB2}
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029F99-522E-4FC4-A86D-694E003F8BB2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //customeraddress
                //ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029F99-522E-4FC4-A86D-694E003F8BB2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_baanblok
                //Geen rechten
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029F99-522E-4FC4-A86D-694E003F8BB2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_dss_tussentijdse_rating
                //sgt_spelerid
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_spelerid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("3386b6cc-d942-47b1-af57-2acb607b6d5b") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_dss_spelersprofiel
                //sgt_dss_bondsnummer
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { "12073385" } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //account
                //ConditionExpression condition = new ConditionExpression { AttributeName = "accountnumber", Operator = ConditionOperator.Equal, Values = new object[1] { "82503" } };
                //ConditionExpression condition = new ConditionExpression { AttributeName = "accountid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //account               
                //ConditionExpression condition = new ConditionExpression { AttributeName = "accountid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_regio
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_regio", Operator = ConditionOperator.Equal, Values = new object[1] { true } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                    //customeraddress
                //customeraddressid
                //parentid 

                //Rutger Hemrika
                //ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("6f0df085-8b6c-414c-9a2e-27dc351b0c39") } };
                //Kampong Vereniging
                //ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") } };
                //Kampong Accommodatie
                //ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029f99-522e-4fc4-a86d-694e003f8bb2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_lidmaatschap
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_lidmaatschapid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("76760d7b-a9c9-e311-8e30-005056952140") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_pb_mutatie_leden
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_lidmaatschapid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("76760d7b-a9c9-e311-8e30-005056952140") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //<condition attribute="sgt_accommodatieid" operator="eq" uiname="ACLO" uitype="sgt_alg_accommodatie" value="{1881A451-1E89-41D4-9E6A-2E93BCF8C341}"/></filter>
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accommodatieid", Operator = ConditionOperator.Equal, uiname = "ACLO", uitype = "sgt_alg_accommodatie", Values = new object[1] { new Guid("1881A451-1E89-41D4-9E6A-2E93BCF8C341") } };
                //<filter type="and">
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                //<link-entity name="sgt_alg_accommodatie" from="sgt_alg_accommodatieid" to="sgt_accommodatieid" alias="aa">
                //LinkEntity link = new LinkEntity { LinkToEntityName = "sgt_alg_accommodatie", LinkFromAttributeName = "sgt_accommodatieid", LinkToAttributeName = "sgt_alg_accommodatieid", LinkCriteria = expression };
                //List<BusinessEntity> entities = RetrieveMultiple(CrmService, "sgt_alg_baanblok", out moreRecords, ref pageNum, null, link);

                //<condition attribute="sgt_alg_accommodatieid" operator="eq" uiname="Kampong" uitype="sgt_alg_accommodatie" value="{11029F99-522E-4FC4-A86D-694E003F8BB2}"/>
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, uiname = "Kampong", uitype = "sgt_alg_accommodatie", Values = new object[1] { new Guid("11029F99-522E-4FC4-A86D-694E003F8BB2") } };
                //<filter type="and">
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                //<link-entity name="sgt_alg_accommodatie" from="sgt_alg_accommodatieid" to="sgt_accommodatieid" alias="aa">
                //LinkEntity link = new LinkEntity { LinkToEntityName = "sgt_alg_accommodatie", LinkFromAttributeName = "sgt_accommodatieid", LinkToAttributeName = "sgt_alg_accommodatieid", LinkCriteria = expression };

                //Annotation
                //annotation anno = new annotation{ objectid}
                //ConditionExpression conditionid = new ConditionExpression { AttributeName = "objectid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("6f0df085-8b6c-414c-9a2e-27dc351b0c39") } };
                //ConditionExpression conditiontype = new ConditionExpression { AttributeName = "objecttypecode", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("6f0df085-8b6c-414c-9a2e-27dc351b0c39") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { conditionid } };

                //ConditionExpression condition = new ConditionExpression { AttributeName = "contactid", Operator = ConditionOperator.Equal, uitype = "contactid", Values = new object[1] { new Guid("6f0df085-8b6c-414c-9a2e-27dc351b0c39") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                //LinkEntity link = new LinkEntity { LinkToEntityName = "contact", LinkFromAttributeName = "sgt_functionarisid", LinkToAttributeName = "contactid", LinkCriteria = expression };
                //List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, null, link);

                //sgt_com_aantal_afdelingen
                //sgt_com_afdeling
                //sgt_com_baan_gereserveerd_competitie
                //sgt_com_beslissingswedstrijd
                //sgt_com_bezoek_consul
                //sgt_com_competitie                
                //sgt_com_competitie_afsluiting
                //sgt_com_competitie_districtsselectie
                //sgt_com_competitie_indeling
                //sgt_com_competitiegedelegeerde
                //sgt_com_competitieinschrijving
                //sgt_com_competitierecht
                //sgt_com_competitiesoort
                //sgt_com_competitietype
                //sgt_com_ingedeelde_ploeg
                //sgt_com_kalender
                //sgt_com_klasse
                //sgt_com_klassegroep
                //sgt_com_klassevolgorde
                //sgt_com_partij_uitslag
                //sgt_com_partij_uitslag_mutatie
                //sgt_com_piramide
                //sgt_com_ploeg
                //sgt_com_ploeginschrijving
                //sgt_com_ploeginschrijving_afhandeling
                //sgt_com_ploegsamenstelling
                //sgt_com_reeks_speeldatums
                //sgt_com_speelschema_standaard
                //sgt_com_speelschema_wedstrijd
                //sgt_com_wedstrijdgegevens
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { "12073385" } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };


                PagingInfo pageInfo = new PagingInfo();
                pageInfo.Count = 50; // the number of rows in each batch
                pageInfo.PageNumber = pageNum;

                // Create the QueryExpression.
                QueryExpression query = new QueryExpression();

                query.EntityName = "sgt_alg_functionaris";
                query.ColumnSet = cols;
                //query.Criteria = expression;
                //query.LinkEntities = new LinkEntity[] { link };
                query.PageInfo = pageInfo;
                query.Distinct = true;

                // Create the request object.
                RetrieveMultipleRequest request = new RetrieveMultipleRequest();
                //request.ReturnDynamicEntities = true;
                // Set the properties of the request object.
                request.Query = query;

                try
                {

                    // Execute the request.
                    results = (RetrieveMultipleResponse)service.Execute(request);

                    List<BusinessEntity> entities = results.BusinessEntityCollection.BusinessEntities.ToList<BusinessEntity>();
                    foreach (sgt_alg_functionaris entity in entities)
                    {
                        //entity.sgt_spelerid
                        string sentity = SerializeObjectList<sgt_alg_functionaris>(entity);
                        WriteToXmlFile<sgt_alg_functionaris>(@"C:\sgt_alg_functionaris.xml", entity, true);
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    throw;
                }

                //sgt_alg_landcode item = new sgt_alg_landcode {  }
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
                //XmlTextWriter metadataWriter = new XmlTextWriter(sw);

                // Start Xml File.
                //metadataWriter.WriteStartDocument();

                // Metadata Xml Node.
                //metadataWriter.WriteStartElement("Metadata");

               // AttributeMetadata currentAttribute;// Declared outside of loop

                // Iterate through all entities and add their attributes and relationships to the file.
                foreach (EntityMetadata currentEntity in metadata.CrmMetadata)
                {
                    string sentity =  SerializeObjectList<EntityMetadata>(currentEntity);

                    WriteToXmlFile<EntityMetadata>(@"C:\EntityMetadata.xml", currentEntity, true);
                    /*
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
                    */ 
                }

                // End Metadata Xml Node
                //metadataWriter.WriteEndElement();
                //metadataWriter.WriteEndDocument();

                // Close xml writer.
                //metadataWriter.Close();
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
            //Console.Write(server.Authenticated.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string nummer = textBox1.Text.Trim();

            string found = Regex.Match(nummer, @"\d+").Value;
            Console.WriteLine(nummer);
            */
            try
            {
                using (SPSite site = new SPSite("https://development.clubcloud.nl/"))
                {
                    SPServiceContext context = SPServiceContext.GetContext(site);

                    ClubCloud.Service.ClubCloudServiceClient Client = new ClubCloud.Service.ClubCloudServiceClient(context);

                    bool more = true;
                    int startRowIndex = 0;
                    int maximumRows = 50;
                    int totalrows = 0;
                    int processed = 0;

                    List<Parameter> collection = new List<Parameter>();
                    DataSourceSelectArguments selectArgs = new DataSourceSelectArguments { MaximumRows = 50, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = "" };
                    ClubCloud_Vereniging_View queryresult = Client.GetVerenigingenByQuery("00000000", Guid.NewGuid(), new DataSourceSelectArguments { MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = "" }, collection);

                    totalrows = queryresult.TotalRowCount;

                    while (more)
                    {
                        foreach (ClubCloud_Vereniging vereniging in queryresult.ClubCloud_Vereniging)
                        {
                            int nummer;
                            if (!int.TryParse(vereniging.Nummer, out nummer))
                                break;

                            MailMessage message = BuidMailMessage(vereniging);

                            if (message == null)
                                break;

                            List<string> emails = new List<string>();

                            if (!string.IsNullOrWhiteSpace(vereniging.EmailKNLTB))
                                emails.Add(vereniging.EmailKNLTB);

                            if (!string.IsNullOrWhiteSpace(vereniging.EmailOverig))
                                emails.Add(vereniging.EmailKNLTB);

                            if (!string.IsNullOrWhiteSpace(vereniging.EmailWebSite))
                                emails.Add(vereniging.EmailWebSite);

                            foreach (string email in emails.Distinct())
                            {
                                message.To.Add(new MailAddress(email, vereniging.Naam, Encoding.UTF8));
                            }

                            message.CC.Add(new MailAddress("info@clubcloud.nl", "ClubCloud"));
                            message.From = new MailAddress("info@clubcloud.nl", "ClubCloud");
                            message.Sender = new MailAddress("info@clubcloud.nl", "ClubCloud");
                            message.ReplyToList.Add(new MailAddress("info@clubcloud.nl", "ClubCloud"));
                            message.Priority = MailPriority.Normal;
                            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure | DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.Delay;

                            message.Subject = string.Format("ClubCloud : De slimme keuze voor {0}", vereniging.Naam);
                            Thread.Sleep(500);
                        }

                        processed += maximumRows;

                        if (processed == totalrows || processed > totalrows || queryresult.ClubCloud_Vereniging.Count == 0)
                            more = false;

                        startRowIndex += maximumRows;
                        selectArgs = new DataSourceSelectArguments { MaximumRows = 50, StartRowIndex = startRowIndex, RetrieveTotalRowCount = false, SortExpression = "" };
                        queryresult = Client.GetVerenigingenByQuery("00000000", Guid.NewGuid(), new DataSourceSelectArguments { MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = "" }, collection);
                    }

                    int result = processed;

                    //Model.ClubCloud_Setting settings = new Model.ClubCloud_Setting { Id = 12073385, VerenigingId = new Guid("02ADA6C7-80F9-4671-91F9-898EA5DA3CCD") };
                    //ClubCloud.Model.ClubCloud_Vereniging vereniging = client.GetVerenigingById(new Guid("02ADA6C7-80F9-4671-91F9-898EA5DA3CCD"), false, settings);
                    //List<Model.ClubCloud_Bouwaard> bouwaarden = client.GetBouwaarden(false, settings);
                    //List<Model.ClubCloud_Functie> functies = client.GetFuncties(true, settings);
                    //int count = functies.Count;
                    //ClubCloud.Model.ClubCloud_Vereniging vereniging = client.GetVerenigingByNummer("12073385", "82503", false);
                    //ClubCloud.Model.ClubCloud_Functie functie =  client.GetFunctieById(Guid.Parse("FD9FE656-31BC-E411-9299-0050569F0030"), false, new Model.ClubCloud_Setting { Id = 12073385, VerenigingId = vereniging.Id });
                    //functie.Meervoud = "Beschermheren";
                    //functie = client.SetFunctie(functie, new Model.ClubCloud_Setting { Id = 12073385, VerenigingId = vereniging.Id });

                    //functie = new Model.ClubCloud_Functie { Actief = "Actief", Beschrijving = "Lorem Ipsum", Code = "LI", Meervoud = "lorem ipsums", Naam = "lorem ipsum", Omschrijving = "lorem ipsums", Toegang = false };
                    //functie = client.SetFunctie(functie, new Model.ClubCloud_Setting { Id = 12073385, VerenigingId = vereniging.Id });
                    //Guid id = functie.Id;
                    //List<ClubCloud.Model.ClubCloud_Functionaris> functionarissen= client.GetFunctionarissenForVereniging(vereniging,false, new Model.ClubCloud_Setting { Id = 12073385, VerenigingId = vereniging.Id });
                    //ClubCloud.Model.ClubCloud_Accommodatie accommodatie = client.GetAccommodatieForVereniging(vereniging, false, new Model.ClubCloud_Setting { Id = 12073385, VerenigingId = vereniging.Id });
                    //List<ClubCloud.Model.ClubCloud_Baan> banen = client.GetBanenForAccommodatie(accommodatie, false, new Model.ClubCloud_Setting { Id = 12073385, VerenigingId = vereniging.Id });
                    //int aantal = banen.Count;
                    //ClubCloud.Model.ClubCloud_Gebruiker gebruiker = client.GetGebruikerByNummer("12073385", vereniging.Id, nummer, false);
                    //client.LidmaatschappenUpdate("12073385", vereniging.Id, true);
                    //client.VerenigingenUpdate("12073385", true);
                    //client.VerenigingZimbra("12073385", vereniging);
                    //client.GebruikerZimbra("12073385", gebruiker);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        
            /*
            contact contact= new KNLTB.ServIt.CrmService.contact{ };
            TargetCreateContact ccontact = new TargetCreateContact { Contact = contact };

            sgt_alg_lidmaatschap lidmaatschap = new sgt_alg_lidmaatschap { };
            TargetCreateSgt_alg_lidmaatschap clidmaatschap = new TargetCreateSgt_alg_lidmaatschap{ Sgt_alg_lidmaatschap = lidmaatschap };

            if (cc == null)
            {
                ClubCloud.KNLTB.Security.KNLTBContainer container = new KNLTB.Security.KNLTBContainer();
                container.MijnRequestAcces("12073385", "rjm557308453!");
                //container.ServItRequestAcces("27908313", "rjm557308453!");

                while (container.Container == null) { }
                cc = container.Container;
            }

            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
            CreateRequest request = new CreateRequest{ Target = ccontact};
            CreateResponse response = service.Execute(request) as CreateResponse;
            Guid id = response.id;
            */


            /*
            string serviceUrl = "https://mijn.clubcloud.nl/_vti_bin/ClubCloud.Mobiel/Mobiel.svc/GetVerenigingByNummer/12073385/82503/false";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(serviceUrl));
            // include this otherwise you'll get 401 UNAUTHORIZED
            request.UseDefaultCredentials = true;
            request.ContentType = "application/json;odata=verbose";
            request.Method = "GET";

            var response = request.GetResponse();
            string responseText = string.Empty;
            // create a stream reader
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                // get the response text
                responseText = reader.ReadToEnd();
            }
            int l = responseText.Length;

            //WebClient client = new WebClient();
            //client.UseDefaultCredentials = true;
            //client.Headers["Content-type"] = "application/json;odata=verbose";
            //client.Encoding = Encoding.UTF8;
            //string response = response = client.DownloadString(serviceUrl);

            //int l = response.Length;
            */
        }

        private MailMessage BuidMailMessage(ClubCloud_Vereniging vereniging)
        {
            MailMessage message = null;

            XDocument xmlInputData = new XDocument(new XElement("Properties"));

            XElement elements = new XElement("Elements",
                        new object[]{
                        new XElement("HEADER"),
                        new XElement("FEATURED_AREA"),
                        new XElement("FULL_WIDTH_COLUMN"),
                        new XElement("INTRO"),
                        new XElement("HALF_COLUMN_FEATURES"),
                        new XElement("HALF_COLUMN_TOP_IMAGE"),
                        new XElement("ONE_THIRD_TWO_THIRD_COLUMN_LEFT_IMAGE"),
                        new XElement("TWO_THIRD_ONE_THIRD_COLUMN_RIGHT_IMAGE"),
                        new XElement("CENTRECOURT"),
                        new XElement("BOTTOM_CALL_TO_ACTION"),
                        new XElement("FOOTER")
                        });
            xmlInputData.Root.Add(elements);

            xmlInputData.Root.Add(vereniging.ToXElement<ClubCloud_Vereniging>());

            EmailTracking track = new EmailTracking
            {
                CampaignName = "Introductie",
                CampaignSource = "Nieuwsbrief",
                CampagneMedium = "email",
                ClientId = vereniging.Id,
                RecipientId = vereniging.Nummer,
                TrackingId = "UA-9934149-20",
                CampagneContent = "Introductie",
                CampagneTerm = "Introductie"
            };

            xmlInputData.Root.Add(track.ToXElement<EmailTracking>());

            XElement content = new XElement("Content",
                new XElement("Subject", string.Format("ClubCloud : De slimme keuze voor {0}", vereniging.Naam)));
            xmlInputData.Root.Add(content);

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    using (SPSite currentSite = new SPSite("https://development.clubcloud.nl/"))
                    {
                        using (SPWeb web = currentSite.OpenWeb(currentSite.RootWeb.ID))
                        {
                            SPDocumentLibrary SiteAssets = null;
                            SPDocumentLibrary SitePages = null;
                            SPFolder Templates = null;
                            SPFolder Online = null;
                            SPFile Aanmelden = null;
                            SPFile Webversion = null;
                            SPItem WebversionItem = null;

                            XmlReader template = null;

                            SPList assets = web.Lists.TryGetList("SiteAssets");

                            if (assets == null)
                                assets = web.Lists.TryGetList("Siteactiva");

                            if (assets != null)
                                SiteAssets = (SPDocumentLibrary)assets;

                            if (SiteAssets != null)
                                Templates = SiteAssets.RootFolder.SubFolders["Templates"];

                            SPList pages = web.Lists.TryGetList("SitePages");

                            if (pages == null)
                                pages = web.Lists.TryGetList("Sitepagina's");

                            if (pages != null)
                                SitePages = (SPDocumentLibrary)pages;

                            if (SitePages != null)
                                Online = SitePages.RootFolder.SubFolders["Online"];

                            if (Templates != null && Templates.Exists)
                                Aanmelden = Templates.Files["template.xsl"];

                            if (Aanmelden != null && Aanmelden.Exists)
                                template = XmlReader.Create(Aanmelden.OpenBinaryStream());

                            if (template == null)
                                throw new FileNotFoundException("Template not Found", Aanmelden.Url);

                            string body = GenerateEmailBody(template, xmlInputData);

                            web.AllowUnsafeUpdates = true;

                            if (Online != null && Online.Exists)
                            {
                                Webversion = Online.Files.Add(Guid.NewGuid() + ".aspx", System.Text.Encoding.UTF8.GetBytes(body), true);
                                WebversionItem = pages.GetItemByUniqueId(Webversion.UniqueId);
                                WebversionItem["Title"] = string.Format("ClubCloud : De slimme keuze voor {0}", vereniging.Naam);
                                WebversionItem.Update();
                            }

                            if (Webversion != null && Webversion.Exists)
                            {
                                XElement online = new XElement("Online",
                                    new object[]{
                                            new XElement("WebVersion", string.Format("{0}/{1}", currentSite.Url,Webversion.Url))
                                    });
                                xmlInputData.Root.Add(online);
                            }

                            if (Aanmelden != null && Aanmelden.Exists)
                                template = XmlReader.Create(Aanmelden.OpenBinaryStream());

                            body = GenerateEmailBody(template, xmlInputData);

                            web.AllowUnsafeUpdates = false;

                            message = Email.CreateMailMessage(body);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                }
            });

            return message;
        }

        private static string GenerateEmailBody(XmlReader template, XNode xmlInputData)
        {
            string strHtml = string.Empty;
            MemoryStream memoryStream = new MemoryStream();
            StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8);
            XmlTextWriter htmlWriter = new XmlTextWriter(writer);
            StreamReader streamReader = new StreamReader(memoryStream);

            try
            {
                // Load the style sheet.
                XsltSettings setting = new XsltSettings { EnableScript = true, EnableDocumentFunction = true };
                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                xslCompiledTransform.Load(template, setting, null);

                xslCompiledTransform.Transform(
                    xmlInputData.CreateNavigator(),
                    null,
                    htmlWriter);

                memoryStream.Position = 0;
                strHtml = streamReader.ReadToEnd();
            }
            catch (XsltException xsltException)
            {
                strHtml = string.Format(CultureInfo.InvariantCulture, "Error: {0}\n\tFileName: {1}\n\tLine Number: {2} - Position: {3}", new object[] { xsltException.Message, xsltException.SourceUri, xsltException.LineNumber, xsltException.LinePosition });
            }
            catch (Exception ex)
            {
                strHtml = string.Format(CultureInfo.InvariantCulture, "Error: {0}", ex.Message);
            }
            finally
            {
                streamReader.Close();
                memoryStream.Close();
            }

            return strHtml;
        }
    }
}
