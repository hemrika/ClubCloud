using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ClubCloud.Model;
using ClubCloud.Common.Mail;
using Microsoft.SharePoint;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.Script.Services;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Globalization;
using System.Net.Mail;
using ClubCloud.Zimbra.Service;
using System.Configuration;
using System.Net;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;

namespace ClubCloud.Internet
{
    public partial class AanmeldenUserControl : UserControl, IWebPart
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

        [Browsable(true)]
        public string ViewName { get; set; }


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

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.EnsureUpdatePanelFixups();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack || !Page.IsCallback)
            {

                VerenigingDataSource.ViewName = "VerenigingView";// this.ViewName;
                VerenigingDataSource.Assembly = typeof(AanmeldenUserControl).Assembly;
                VerenigingDataSource.View.WhereParameters = new ParameterCollection();
                VerenigingDataSource.View.Parent = this.Page;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        /// <summary>
        /// Fixups for update panel
        /// </summary>
        private void EnsureUpdatePanelFixups()
        {
            if (this.Page.Form != null)
            {
                string formOnSubmitAtt = this.Page.Form.Attributes["onsubmit"];
                if (formOnSubmitAtt == "return _spFormOnSubmitWrapper();")
                {
                    this.Page.Form.Attributes["onsubmit"] = "_spFormOnSubmitWrapper();";
                }
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdatePanelFixup", "_spOriginalFormAction = document.forms[0].action; _spSuppressFormOnSubmitWrapper=true;", true);
        }

        protected void tmr_loader_aanmelden_Tick(object sender, EventArgs e)
        {
            //tmr_loader_aanmelden.Enabled = false;
            pnl_vereniging.Visible = true;
            VerenigingDataSource.View.WhereParameters.Clear();
            udp_progress.Visible = false;
        }

        protected void wzd_aanmelden_PreRender(object sender, EventArgs e)
        {
            Repeater SideBarList = wzd_aanmelden.FindControl("HeaderContainer").FindControl("SideBarList") as Repeater;
            IEnumerable<WizardStep> steps = wzd_aanmelden.WizardSteps.Cast<WizardStep>().Where(w => w.StepType != WizardStepType.Complete);
            SideBarList.DataSource = steps;// wzd_aanmelden.WizardSteps;
            SideBarList.DataBind();
        }

        protected void wzd_aanmelden_Load(object sender, EventArgs e)
        {
            //wzd_aanmelden.ActiveStep.
        }


        protected void SideBarList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            wzd_aanmelden.ActiveStepIndex = e.Item.ItemIndex;
        }

        protected void wzd_aanmelden_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            using (SPLongOperation operation = new SPLongOperation(this.Page))
            {
                operation.Begin();

                using (new SPMonitoredScope("Mailing SendMail"))
                {

                    try
                    {
                        XDocument xmlInputData = new XDocument(new XElement("Properties"));

                        XElement elements = new XElement("Elements",
                        new object[]{
                        new XElement("HEADER"),
                        new XElement("FEATURED_AREA"),
                        new XElement("VERENIGING"),
                        new XElement("GEBRUIKER"),
                        new XElement("OPMERKINGEN"),
                        new XElement("BOTTOM_CALL_TO_ACTION"),
                        new XElement("FOOTER")
                        });
                        xmlInputData.Root.Add(elements);

                        ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

                        string verenigingsnummer = tbx_verenigingsnummer.Text;

                        string number = string.Empty;
                        int parsed = 0;

                        if (verenigingsnummer.IndexOf('-') > 0)
                        {
                            number = verenigingsnummer.Split('-')[0].Trim();
                        }
                        else
                        {
                            number = verenigingsnummer;
                        }

                        if (int.TryParse(number, out parsed))
                        {
                            try
                            {
                                vereniging = Client.GetVerenigingByNummer("00000000", parsed.ToString(), false);
                            }
                            catch (Exception ex)
                            {
                                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                            }
                        }

                        if (vereniging == null)
                            vereniging = new ClubCloud_Vereniging();

                        if (vereniging.Nummer != number)
                            vereniging.Nummer = number;

                        TextBox vereniging_naam = (TextBox)fvw_vereniging.FindControl("Naam");
                        string verenigingnaam = vereniging_naam.Text;
                        if (vereniging.Naam != vereniging_naam.Text && !string.IsNullOrWhiteSpace(vereniging_naam.Text))
                            vereniging.Naam = vereniging_naam.Text;

                        TextBox vereniging_KvKNummer = (TextBox)fvw_vereniging.FindControl("KvKNummer");
                        string verenigingkvknummer = vereniging_KvKNummer.Text;
                        if (vereniging.KvKnummer != vereniging_KvKNummer.Text && !string.IsNullOrWhiteSpace(vereniging_KvKNummer.Text))
                            vereniging.KvKnummer = vereniging_KvKNummer.Text;

                        TextBox vereniging_KvKPlaats = (TextBox)fvw_vereniging.FindControl("KvKPlaats");
                        string verenigingkvkplaats = vereniging_KvKPlaats.Text;
                        if (vereniging.KvKplaats != vereniging_KvKPlaats.Text && !string.IsNullOrWhiteSpace(vereniging_KvKPlaats.Text))
                            vereniging.KvKplaats = vereniging_KvKPlaats.Text;

                        TextBox vereniging_BankNummer = (TextBox)fvw_vereniging.FindControl("BankNummer");
                        string verenigingbanknummer = vereniging_BankNummer.Text;
                        if (vereniging.BankNummer != vereniging_BankNummer.Text && !string.IsNullOrWhiteSpace(vereniging_BankNummer.Text))
                            vereniging.BankNummer = vereniging_BankNummer.Text;

                        TextBox vereniging_BankIban = (TextBox)fvw_vereniging.FindControl("BankIban");
                        string verenigingbankiban = vereniging_BankIban.Text;
                        if (vereniging.BankIban != vereniging_BankIban.Text && !string.IsNullOrWhiteSpace(vereniging_BankIban.Text))
                            vereniging.BankIban = vereniging_BankIban.Text;

                        TextBox vereniging_BankPlaats = (TextBox)fvw_vereniging.FindControl("BankPlaats");
                        string verenigingbankplaats = vereniging_BankPlaats.Text;
                        if (vereniging.BankPlaats != vereniging_BankPlaats.Text && !string.IsNullOrWhiteSpace(vereniging_BankPlaats.Text))
                            vereniging.BankPlaats = vereniging_BankPlaats.Text;

                        TextBox vereniging_TelefoonOverdag = (TextBox)fvw_vereniging.FindControl("TelefoonOverdag");
                        string verenigingtelefoonoverdag = vereniging_TelefoonOverdag.Text;
                        if (vereniging.TelefoonOverdag != vereniging_TelefoonOverdag.Text && !string.IsNullOrWhiteSpace(vereniging_TelefoonOverdag.Text))
                            vereniging.TelefoonOverdag = vereniging_TelefoonOverdag.Text;

                        TextBox vereniging_TelefoonAvond = (TextBox)fvw_vereniging.FindControl("TelefoonAvond");
                        string verenigingtelefoonavond = vereniging_TelefoonAvond.Text;
                        if (vereniging.TelefoonAvond != vereniging_TelefoonAvond.Text && !string.IsNullOrWhiteSpace(vereniging_TelefoonAvond.Text))
                            vereniging.TelefoonAvond = vereniging_TelefoonAvond.Text;

                        TextBox vereniging_Email = (TextBox)fvw_vereniging.FindControl("Email");
                        string verenigingemail = vereniging_Email.Text;
                        if (vereniging.EmailKNLTB != vereniging_Email.Text && !string.IsNullOrWhiteSpace(vereniging_Email.Text))
                            vereniging.EmailKNLTB = vereniging_Email.Text;

                        xmlInputData.Root.Add(vereniging.ToXElement<ClubCloud_Vereniging>());

                        ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

                        TextBox persoon_knltb = (TextBox)fvw_persoon.FindControl("KNLTBNummer");
                        string persoonknltb = persoon_knltb.Text;

                        string lm = string.Empty;
                        parsed = 0;

                        if (int.TryParse(persoonknltb, out parsed))
                            lm = "luckyme";
                        /*
                        {
                            try
                            {
                                gebruiker = Client.GetGebruikerByNummer("00000000", vereniging.Id, parsed.ToString(), false);
                            }
                            catch (Exception ex)
                            {
                                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                            }
                        }
                        */

                        if (gebruiker == null)
                            gebruiker = new ClubCloud_Gebruiker();

                        if (gebruiker.Bondsnummer != parsed.ToString())
                            gebruiker.Bondsnummer = parsed.ToString();

                        TextBox persoon_naam = (TextBox)fvw_persoon.FindControl("Naam");
                        string persoonnaam = persoon_naam.Text;
                        if (gebruiker.Volledigenaam != persoon_naam.Text && !string.IsNullOrWhiteSpace(persoon_naam.Text))
                            gebruiker.Volledigenaam = persoon_naam.Text;

                        TextBox persoon_TelefoonOverdag = (TextBox)fvw_persoon.FindControl("TelefoonOverdag");
                        string persoontelefoonoverdag = persoon_TelefoonOverdag.Text;
                        if (gebruiker.TelefoonOverdag != persoon_TelefoonOverdag.Text && !string.IsNullOrWhiteSpace(persoon_TelefoonOverdag.Text))
                            gebruiker.TelefoonOverdag = persoon_TelefoonOverdag.Text;

                        TextBox persoon_TelefoonAvond = (TextBox)fvw_persoon.FindControl("TelefoonAvond");
                        string persoontelefoonavond = persoon_TelefoonAvond.Text;
                        if (gebruiker.TelefoonAvond != persoon_TelefoonAvond.Text && !string.IsNullOrWhiteSpace(persoon_TelefoonAvond.Text))
                            gebruiker.TelefoonAvond = persoon_TelefoonAvond.Text;

                        TextBox persoon_Email = (TextBox)fvw_persoon.FindControl("Email");
                        string persoonemail = persoon_Email.Text;
                        if (gebruiker.EmailKNLTB != persoon_Email.Text && !string.IsNullOrWhiteSpace(persoon_Email.Text))
                            gebruiker.EmailKNLTB = persoon_Email.Text;

                        xmlInputData.Root.Add(gebruiker.ToXElement<ClubCloud_Gebruiker>());

                        XElement aanmelden = new XElement("Aanmelden",
                        new object[]{
                        new XElement("Opmerkingen", opmerkingen.Text),
                        new XElement("Akkoord", akkoord.Checked),
                        new XElement("Datum", DateTime.Now.ToString()),
                        new XElement("IP",GetIPAddress())
                        });
                        xmlInputData.Root.Add(aanmelden);

                        EmailTracking tracking = new EmailTracking
                        {
                            CampaignName = "Aanmelden",
                            CampaignSource = "WebSite",
                            ClientId = vereniging.Id,
                            RecipientId = vereniging.Nummer,
                            TrackingId = "UA-9934149-20",
                            CampagneContent = "aanmelden",
                            CampagneMedium = "email",
                            CampagneTerm = "aanmelden"
                        };

                        xmlInputData.Root.Add(tracking.ToXElement<EmailTracking>());

                        XElement content = new XElement("Content",
                            new XElement("Subject", string.Format("Aanmelden bij ClubCloud voor {0} ({1})", vereniging.Naam, vereniging.Nummer)));
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

                                        if (pages != null)
                                            SitePages = (SPDocumentLibrary)pages;

                                        if (SitePages != null)
                                            Online = SitePages.RootFolder.SubFolders["Online"];

                                        if (Templates != null && Templates.Exists)
                                            Aanmelden = Templates.Files["aanmelden.xsl"];

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
                                            WebversionItem["Title"] = string.Format("Aanmelden bij ClubCloud voor {0} ({1})", vereniging.Naam, vereniging.Nummer);
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

                                        MailMessage message = Email.CreateMailMessage(body);

                                        MailAddress tovereniging = new MailAddress(vereniging.EmailKNLTB, vereniging.Naam, Encoding.UTF8);
                                        message.To.Add(tovereniging);

                                        MailAddress topersoon = new MailAddress(gebruiker.EmailKNLTB, gebruiker.Volledigenaam, Encoding.UTF8);
                                        message.To.Add(topersoon);

                                        message.CC.Add(new MailAddress("aanmelden@clubcloud.nl", "Aanmelden bij ClubCloud"));
                                        message.From = new MailAddress("aanmelden@clubcloud.nl", "Aanmelden bij ClubCloud");
                                        message.Subject = string.Format("Aanmelden bij ClubCloud voor {0}({1})", vereniging.Naam, vereniging.Nummer);
                                        message.Priority = MailPriority.Normal;
                                        message.ReplyToList.Add(new MailAddress("aanmelden@clubcloud.nl", "Aanmelden bij ClubCloud"));
                                        message.Sender = new MailAddress("aanmelden@clubcloud.nl", "Aanmelden bij ClubCloud");

                                        SmtpClient client = new SmtpClient(ZimbraConfiguration.Server.SendMailHost, zimbraconfiguration.Server.SendMailPort);
                                        client.Credentials = new System.Net.NetworkCredential(ZimbraConfiguration.Server.SendMailUserName, ZimbraConfiguration.Server.SendMailPassword);
                                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                        message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure | DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.Delay;
                                        Email.Send(message, client);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                    }
                }
                operation.End("bedankt.aspx");
            }
        }

        public static string GenerateEmailBody(XmlReader template, XNode xmlInputData)
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

        protected string GetIPAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
        protected void wzd_aanmelden_ActiveStepChanged(object sender, EventArgs e)
        {

        }

        protected void wzd_aanmelden_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {

        }

        protected string GetClassForWizardStep(object wizardStep)
        {
            WizardStep step = wizardStep as WizardStep;

            if (step == null)
            {
                return "";
            }
            int stepIndex = wzd_aanmelden.WizardSteps.IndexOf(step);

            if (stepIndex < wzd_aanmelden.ActiveStepIndex)
            {
                return "prevStep";
            }
            else if (stepIndex > wzd_aanmelden.ActiveStepIndex)
            {
                return "nextStep";
            }
            else
            {
                return "currentStep";
            }
        }

        protected void tbx_verenigingsnummer_TextChanged(object sender, EventArgs e)
        {
            string lookup = tbx_verenigingsnummer.Text;
            string number = string.Empty;
            //bool complete = false;

            if (lookup.IndexOf('-') > 0)
            {
                number = lookup.Split('-')[0].Trim();
                //complete = true;
            }
            else
            {
                number = lookup;
            }

            if (!string.IsNullOrWhiteSpace(number))
            {
                //AanmeldenDataSource.ViewName = this.ViewName;

                //AanmeldenDataSource.Assembly = typeof(AanmeldenView).Assembly; //Assembly.GetCallingAssembly();

                VerenigingDataSource.View.WhereParameters.Clear();

                VerenigingDataSource.View.WhereParameters.Add(new Parameter { Name = "nummer", DefaultValue = number, DbType = System.Data.DbType.String });
                fvw_vereniging.DataSourceID = "VerenigingDataSource";
            }
            else
            {
                //AanmeldenDataSource.ViewName = this.ViewName;

                //AanmeldenDataSource.Assembly = typeof(AanmeldenView).Assembly; //Assembly.GetCallingAssembly();
                fvw_vereniging.DataSourceID = string.Empty;
                VerenigingDataSource.View.WhereParameters.Clear();
            }

            //this.AanmeldenDataSource.RaiseViewChanged();
            //AanmeldenDataSource.DataBind();

            //fvw_aanmelden.DataSourceID = "AanmeldenDataSource";
            //fvw_aanmelden.DataBind();
            //udp_aanmelden.Update();
            //this.AanmeldenDataSource.DataBind();

            /*
            //TextBox verenigingsnummer = (TextBox)fvw_vereniging.FindControl("tbx_verenigingsnummer");
            ClubCloud_Vereniging vereniging = Client.GetVerenigingByNummer("00000000", number, false);
            //vereniging.Nummer
            try
            {
                if (vereniging != null)
                {
                    if (!complete)
                    {
                        tbx_verenigingsnummer.Text = string.Format("{0} - {1}", vereniging.Nummer, vereniging.Naam);
                    }

                    int count = this.AanmeldenDataSource.View.WhereParameters.Count;
                    fvw_aanmelden.DataSource = new List<ClubCloud_Vereniging> { vereniging };
                    fvw_aanmelden.DataBind();
                    //fvw_vereniging.DataSource = new List<ClubCloud_Vereniging> { vereniging };
                    //fvw_vereniging.DataBind();

                    //Label label = (Label)fvw_vereniging.FindControl("lbl_verenigingsnummer");
                    //lbl_verenigingsnummer.Text = vereniging.Nummer;
                    //lbl_verenigingsnaam.Text = vereniging.Naam;

                    wzd_aanmelden.ActiveStep.Visible = true;
                }
                else
                {
                    fvw_aanmelden.DataSource = null;
                    fvw_aanmelden.DataBind();
                }
            }
            catch (Exception ex)
            {
                lbl_result.Text += ex.Message + Environment.NewLine;
            }
            */

        }

        #region IWebpart

        protected string _title = "[Generic Title]";
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        //  Subtitle
        protected string _subTitle = "";
        public string Subtitle
        {
            get { return _subTitle; }
            set { _subTitle = value; }
        }
        //  Caption
        protected string _caption = "[Generic Caption]";
        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }
        //  Description
        private string _description = "[Generic Description]";
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        //  TitleUrl
        private string _titleUrl = "";
        public string TitleUrl
        {
            get { return _titleUrl; }
            set { _titleUrl = value; }
        }
        //  TitleIconImageUrl
        private string _titleIconImageUrl = "~/App_Themes/portal/img/tools.gif";
        public string TitleIconImageUrl
        {
            get { return _titleIconImageUrl; }
            set { _titleIconImageUrl = value; }
        }
        //  CatalogIconImageUrl
        private string _catalogIconImageUrl = "~/App_Themes/portal/img/tools.gif";
        public string CatalogIconImageUrl
        {
            get { return _catalogIconImageUrl; }
            set { _catalogIconImageUrl = value; }
        }

        #endregion



    }
}
