using ClubCloud.Common.Controls;
using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Administration;
using System.Xml.Linq;
using System.IO;
using System.Collections;
using System.Xml;
using ClubCloud.Common.Mail;
using System.Web.UI;
using ClubCloud.Service;
using ClubCloud.Model;
using System.Net.Mail;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Globalization;
using System.Threading;
using ClubCloud.Zimbra.Service;
using System.Configuration;
using System.Web;
using System.Web.Hosting;

namespace ClubCloud.Internet
{
    [System.ComponentModel.DataObject(true)]
    public partial class Mailing_View : ClubCloudDataSourceView
    {
        private static ZimbraConfigurationSection zimbraconfiguration = null;

        internal ZimbraConfigurationSection ZimbraConfiguration
        {
            get
            {
                try
                {
                    zimbraconfiguration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                    string messsage = ex.Message;
                }

                if (zimbraconfiguration == null)
                {
                    zimbraconfiguration = new ZimbraConfigurationSection();
                }
                return zimbraconfiguration;
            }
        }

        public Mailing_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
        private ClubCloud.Service.ClubCloudServiceClient _client = null;
    
        public ClubCloud.Service.ClubCloudServiceClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new Service.ClubCloudServiceClient(SPServiceContext.Current);
                }
                return _client;
            }
        }
    
        public override bool CanRetrieveTotalRowCount
        {
            get
            {
                return true;
            }
        }
    
        public override bool CanPage
        {
            get
            {
                return true;
            }
        }
    
        public override bool CanSort
        {
            get
            {
                return true;
            }
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public int SelectOnlineVersions()
        {
            int result = -1;

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    using (SPSite currentSite = new SPSite(SPContext.Current.Site.ID, SPUrlZone.Internet))
                    {
                        using (SPWeb web = currentSite.OpenWeb(SPContext.Current.Web.ID))
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

                            SPQuery query = new SPQuery();
                            query.Query = @"<Where><IsNotNull><FieldRef Name=""Title"" /></IsNotNull></Where>";
                            query.ViewFields = @"<FieldRef Name=""Title"" />";
                            query.ViewAttributes = @"Scope=""Recursive""";
                            result = pages.GetItems(query).Count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                    result = -1;
                }
            });
            return result;

        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<DictionaryEntry> SelectTemplates()
        {
            List<DictionaryEntry> result = new List<DictionaryEntry>();

            using (new SPMonitoredScope("Mailing SelectTemplates"))
            {

                if (SPContext.Current.Web.CurrentUser != null)
                {
                    
                    SPSecurity.RunWithElevatedPrivileges(delegate()
                    {
                        try
                        {
                            using (SPSite currentSite = new SPSite(SPContext.Current.Site.ID, SPUrlZone.Internet))
                            {
                                using (SPWeb web = currentSite.OpenWeb(SPContext.Current.Web.ID))
                                {
                                    SPDocumentLibrary SiteAssets = null;
                                    SPFolder Templates = null;
                                    SPFile Aanmelden = null;

                                    XElement template = null;

                                    SPList assets = web.Lists.TryGetList("SiteAssets");

                                    if (assets == null)
                                        assets = web.Lists.TryGetList("Siteactiva");

                                    if (assets != null)
                                        SiteAssets = (SPDocumentLibrary)assets;

                                    if (SiteAssets != null)
                                        Templates = SiteAssets.RootFolder.SubFolders["Templates"];

                                    if (Templates != null && Templates.Exists)
                                        Aanmelden = Templates.Files["template.xsl"];

                                    if (Aanmelden != null && Aanmelden.Exists)
                                        template = XElement.Load(Aanmelden.OpenBinaryStream());

                                    if (template == null)
                                        throw new FileNotFoundException("Template not Found", Aanmelden.Url);

                                    IQueryable<string> names = template.Elements("{http://www.w3.org/1999/XSL/Transform}template").Where(temp => temp.Attribute("match") != null && temp.Attribute("match").Value != "/").Select(temp => temp.Attribute("match").Value).AsQueryable();

                                    foreach (string name in names)
                                    {
                                        result.Add(new DictionaryEntry(name, name));
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                        }
                    });
                    return result.AsQueryable<DictionaryEntry>();
                }
            }

            return null;
        }

        

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public int SendMail()
    	{
            int processed = 0;

            using (SPLongOperation operation = new SPLongOperation(this.Parent))
            {
                operation.Begin();

                using (new SPMonitoredScope("Mailing SendMail"))
                {
                    if (SPContext.Current.Web.CurrentUser != null)
                    {
                        try
                        {
                            if (ZimbraConfiguration == null)
                                return 0;

                            SmtpClient client = new SmtpClient(ZimbraConfiguration.Server.SendMailHost, zimbraconfiguration.Server.SendMailPort);
                            client.Credentials = new System.Net.NetworkCredential(ZimbraConfiguration.Server.SendMailUserName, ZimbraConfiguration.Server.SendMailPassword);
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.DeliveryFormat = SmtpDeliveryFormat.International;
                            //client.SendCompleted += client_SendCompleted;

                            bool more = true;
                            int startRowIndex = SelectOnlineVersions() - 10;
                            int maximumRows = 200;
                            int totalrows = 0;

                            List<Parameter> collection = new List<Parameter>();
                            ClubCloud_Vereniging_View queryresult = null;

                            while (more)
                            {
                                try
                                {

                                    queryresult = Client.GetVerenigingenByQuery("00000000", Guid.NewGuid(), new DataSourceSelectArguments { MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = "" }, collection);                                    

                                    if (queryresult != null && queryresult.ClubCloud_Vereniging != null)
                                    {
                                        totalrows = queryresult.TotalRowCount;

                                        foreach (ClubCloud_Vereniging vereniging in queryresult.ClubCloud_Vereniging)
                                        {
                                            if (vereniging.Nummer == "09399" || vereniging.Nummer == "61424")
                                                continue;

                                            try
                                            {
                                                int nummer;
                                                if (int.TryParse(vereniging.Nummer, out nummer))
                                                {

                                                    MailMessage message = BuidMailMessage(vereniging);

                                                    if (message == null)
                                                        continue;

                                                    List<string> emails = new List<string>();

                                                    if (!string.IsNullOrWhiteSpace(vereniging.EmailKNLTB))
                                                        emails.Add(vereniging.EmailKNLTB);

                                                    if (!string.IsNullOrWhiteSpace(vereniging.EmailOverig))
                                                        emails.Add(vereniging.EmailKNLTB);

                                                    if (!string.IsNullOrWhiteSpace(vereniging.EmailWebSite))
                                                        emails.Add(vereniging.EmailWebSite);

                                                    foreach (string email in emails.Distinct())
                                                    {
                                                        try
                                                        {
                                                            //message.To.Add(new MailAddress("rutger@hemrika.nl","Rutger Hemrika", Encoding.UTF8));
                                                            message.To.Add(new MailAddress(email.ToLower(), vereniging.Naam, Encoding.UTF8));
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                                                        }
                                                    }

                                                    message.CC.Add(new MailAddress("info@clubcloud.nl", "ClubCloud"));
                                                    message.From = new MailAddress("info@clubcloud.nl", "ClubCloud");
                                                    message.Sender = new MailAddress("info@clubcloud.nl", "ClubCloud");
                                                    message.ReplyToList.Add(new MailAddress("info@clubcloud.nl", "ClubCloud"));
                                                    message.Priority = MailPriority.Normal;
                                                    message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure | DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.Delay;

                                                    message.Subject = string.Format("ClubCloud : De slimme keuze voor {0}", vereniging.Naam);

                                                    try
                                                    {
                                                        HostingEnvironment.QueueBackgroundWorkItem(ct => Email.SendAsync(message, client));
                                                        //Email.Send(message, client);
                                                        Thread.Sleep(100);
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                                                    }
                                                    finally
                                                    {
                                                        //message.Dispose();
                                                    }

                                                    Thread.Sleep(200);

                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                                            }
                                        }
                                    }

                                    processed += maximumRows;
                                    startRowIndex += maximumRows;

                                    if (processed >= totalrows || (queryresult != null && queryresult.ClubCloud_Vereniging.Count == 0))
                                        more = false;

                                    //more = false;
                                }
                                catch (Exception ex)
                                {
                                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                                }
                                //selectArgs = new DataSourceSelectArguments { MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = false, SortExpression = "" };
                                //queryresult = Client.GetVerenigingenByQuery("00000000", Guid.NewGuid(), new DataSourceSelectArguments { MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = false, SortExpression = "" }, collection);
                            }

                        }
                        catch (Exception ex)
                        {
                            Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                        }
                    }
                }
                operation.End(this.Parent.Request.Url.AbsolutePath);
            }
            return processed;

    	}


        static void client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                //TaskCompletionSource< source = (TaskCompletionSource)e.UserState;

                MailMessage message = (MailMessage)e.UserState;

                if (e.Cancelled)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, "ClubCLoud.Common.Mail", message.Subject);
                }
                if (e.Error != null)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, e.Error.Source, e.Error.Message);
                }

                message.Dispose();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
            }
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
                    using (SPSite currentSite = new SPSite(SPContext.Current.Site.ID, SPUrlZone.Internet))
                    {
                        using (SPWeb web = currentSite.OpenWeb(SPContext.Current.Web.ID))
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

                            SPQuery query = new SPQuery();
                            query.Query = string.Format("<Where><Eq><FieldRef Name=\"Title\" /><Value Type=\"Text\">ClubCloud : De slimme keuze voor {0}</Value></Eq></Where>", vereniging.Naam);
                            query.RowLimit = 1;
                            query.ViewFields = @"<FieldRef Name=""Title"" />";
                            query.ViewAttributes = @"Scope=""Recursive""";
                            SPListItemCollection items = pages.GetItems(query);

                            if (items.Count > 0)
                                throw new SPDuplicateObjectException("Club already mailed", new Exception("Club already mailed"));

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
                    message = null;
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
