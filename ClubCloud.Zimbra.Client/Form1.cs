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
                    container.MijnRequestAcces("12073385", "rjm557308453!");
                    //container.ServItRequestAcces("27908313", "rjm557308453!");

                    while (container.Container == null) { }
                    cc = container.Container;
                }

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
                ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
                GetUsersUsingExecute(service);
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
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { "12073385" } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_baan_gereserveerd
                //sgt_accomodatieid
                //sgt_verenigingid
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accomodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029f99-522e-4fc4-a86d-694e003f8bb2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_baan_gereserveerd_vereniging
                //sgt_accommodatieid 11029f99-522e-4fc4-a86d-694e003f8bb2
                //sgt_verenigingid 02ada6c7-80f9-4671-91f9-898ea5da3ccd
                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029f99-522e-4fc4-a86d-694e003f8bb2") } };
                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

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

                //customeraddress
                //customeraddressid
                //parentid 
                
                //ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") } };
                //ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("11029f99-522e-4fc4-a86d-694e003f8bb2") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                //sgt_alg_lidmaatschap
                //ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_lidmaatschapid", Operator = ConditionOperator.Equal, Values = new object[1] { new Guid("76760d7b-a9c9-e311-8e30-005056952140") } };
                //FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                PagingInfo pageInfo = new PagingInfo();
                pageInfo.Count = 50; // the number of rows in each batch
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
                //FilterExpression expression = new FilterExpression();
                query.EntityName = "sgt_alg_baanblok";
                query.ColumnSet = cols;
                query.Criteria = expression;
                query.PageInfo = pageInfo;
                query.Distinct = true;

                // Create the request object.
                RetrieveMultipleRequest request = new RetrieveMultipleRequest();

                // Set the properties of the request object.
                request.Query = query;

                try
                {

                    // Execute the request.
                    results = (RetrieveMultipleResponse)service.Execute(request);



                    List<BusinessEntity> entities = results.BusinessEntityCollection.BusinessEntities.ToList<BusinessEntity>();
                    foreach (sgt_alg_baanblok entity in entities)
                    {
                        //entity.sgt_spelerid
                        string sentity = SerializeObjectList<sgt_alg_baanblok>(entity);
                        WriteToXmlFile<sgt_alg_baanblok>(@"C:\sgt_alg_baanblok.xml", entity, true);
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    throw;
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
            Guid id = Guid.NewGuid();
            MessageBox.Show(id.ToString());
        }
    }
}
