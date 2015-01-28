using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.Script.Services;
using System.ComponentModel;
using System.Reflection;

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
            tmr_loader_aanmelden.Enabled = false;
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
            FormViewRow row = fvw_aanmelden.Row;
            TextBox tbx_naam = (TextBox)fvw_aanmelden.FindControl("Naam");
            string naam = tbx_naam.Text;

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
            bool complete = false;

            if (lookup.IndexOf('-') > 0)
            {
                number = lookup.Split('-')[0].Trim();
                complete = true;
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
                fvw_aanmelden.DataSourceID = "VerenigingDataSource";
            }
            else
            {
                //AanmeldenDataSource.ViewName = this.ViewName;

                //AanmeldenDataSource.Assembly = typeof(AanmeldenView).Assembly; //Assembly.GetCallingAssembly();
                fvw_aanmelden.DataSourceID = string.Empty;
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
