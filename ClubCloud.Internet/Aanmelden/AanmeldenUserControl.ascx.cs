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

namespace ClubCloud.Internet
{
    public partial class AanmeldenUserControl : UserControl, IWebPart
    {
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

            XDocument xmlData = new XDocument(new XElement("Properties"));

            XElement content = new XElement("Content",
                        new XElement("Subject", "Aanmelden bij ClubCloud"));
            xmlData.Root.Add(content);

            XElement message = new XElement("Message",
            new object[]{
                        new XElement("HEADER"),
                        new XElement("FEATURED_AREA"),
                        new XElement("FULL_WIDTH_COLUMN"),
                        new XElement("INTRO"),
                        new XElement("HALF_COLUMN_FEATURES"),
                        new XElement("HALF_COLUMN_TOP_IMAGE"),
                        new XElement("BOTTOM_CALL_TO_ACTION"),
                        new XElement("FOOTER")
                        });
            xmlData.Root.Add(message);

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

            //if (!string.IsNullOrWhiteSpace(number))
            if (int.TryParse(number, out parsed))
            {
                vereniging = Client.GetVerenigingByNummer("00000000", parsed.ToString(), false);
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

            xmlData.Add(vereniging.ToXElement<ClubCloud_Vereniging>());

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            TextBox persoon_knltb = (TextBox)fvw_persoon.FindControl("KNLTBNummer");
            string persoonknltb = persoon_knltb.Text;

            number = string.Empty;
            parsed = 0;

            if (int.TryParse(persoonknltb, out parsed))
            {
                gebruiker = Client.GetGebruikerByNummer("00000000", vereniging.Id, parsed.ToString(), false);
            }
            if (gebruiker == null)
                gebruiker = new ClubCloud_Gebruiker();

            if (gebruiker.Bondsnummer != number)
                gebruiker.Bondsnummer = number;

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
            if (gebruiker.TelefoonOverdag != persoon_TelefoonAvond.Text && !string.IsNullOrWhiteSpace(persoon_TelefoonAvond.Text))
                gebruiker.TelefoonOverdag = persoon_TelefoonAvond.Text;

            TextBox persoon_Email = (TextBox)fvw_persoon.FindControl("Email");
            string persoonemail = persoon_Email.Text;
            if (gebruiker.EmailKNLTB != persoon_Email.Text && !string.IsNullOrWhiteSpace(persoon_Email.Text))
                gebruiker.EmailKNLTB = persoon_Email.Text;

            xmlData.Add(gebruiker.ToXElement<ClubCloud_Gebruiker>());

            XElement aanmelden = new XElement("Aanmelden",
            new object[]{
                        new XElement("Opmerkingen", opmerkingen.Text),
                        new XElement("Akkoord", akkoord.Checked)
                        });
            xmlData.Root.Add(aanmelden);

            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    using (SPSite currentSite = new SPSite(SPContext.Current.Site.ID))
                    {
                        using (SPWeb web = currentSite.OpenWeb(SPContext.Current.Web.ID))
                        {
                            SPFolder folder = web.Folders["SiteAssets"].SubFolders["Templates"];

                            string url = folder.Url + "/template.xsl";
                            SPFile tempFile = web.GetFile(url);
                            byte[] obj = (byte[])tempFile.OpenBinary();
                        }
                    }
                });

            EmailTracking tracking = new EmailTracking { CampaignName = "Aanmelden", CampaignSource = "WebSite", ClientId = vereniging.Nummer, RecipientId = gebruiker.Bondsnummer, TrackingId = "UA-9934149-20" };
            xmlData.Add(tracking.ToXElement<EmailTracking>());

            //ClubCloud.Common.Mail.Mailing.
        }

        public static string GenerateEmailBody(string templatePath, XNode xmlInputData)
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
                xslCompiledTransform.Load(templatePath, setting, null);

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
