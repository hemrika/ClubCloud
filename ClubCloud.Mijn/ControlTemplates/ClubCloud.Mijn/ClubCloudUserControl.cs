using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class ClubCloudUserControl : UserControl, IWebPart
    {

        internal static string userId = string.Empty;
        //internal ClubCloud_Setting settings;

        internal ClubCloud_Setting Settings
        {
            get
            {
                try
                {
                    return Page.Session["ClubCloud_Setting"] as ClubCloud_Setting;

                }
                catch { return null; }

            }
            set 
            {
                if (value == null)
                {
                    Page.Session.Remove("ClubCloud_Setting");
                }
                else
                {

                    Page.Session["ClubCloud_Setting"] = value;
                }
            }
        }

        internal bool SettingsLoading
        {
            get
            {
                bool loading = false;
                try
                {
                    bool.TryParse(Page.Session["ClubCloud_Setting_Loading"].ToString(), out loading);
                }
                catch
                {
                    loading = false;
                }
                return loading;
            }
            set 
            {
                Page.Session["ClubCloud_Setting_Loading"] = value;
            }
        }

        internal void LoadClubCloudSettings()
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                userId = SPContext.Current.Web.CurrentUser.UserId.NameId;

                //if (!IsPostBack)
                //{
                    if (Settings != null && Settings.Id != int.Parse(userId))
                    {
                        Settings = null;
                    }

                    if (Settings == null &&  !SettingsLoading)
                    {
                        try
                        {
                            SettingsLoading = true;
                            userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                            Settings = Client.GetClubCloudSettings(userId);
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message;
                        }
                        finally
                        {
                            SettingsLoading = false;
                        }
                        
                        //Settings = Client.GetClubCloudSettingsAsync(userId);
                        
                    }
                //}
            }
            else
            {
                if (Settings != null)
                {
                    Settings = null;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //EnsureVisitor();
            //LoadClubCloudSettings();
        }

        internal virtual void SetPageData()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            EnsureVisitor();
            LoadClubCloudSettings();
        }

        internal async Task EnsureVisitor()
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                Guid id = SPContext.Current.Site.ID;
                SPUser user = SPContext.Current.Web.CurrentUser;
                await Task.Run(() => SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                        using (SPSite site = new SPSite(id))
                        {
                            using (SPWeb web = site.RootWeb)
                            {
                                try
                                {
                                    if (user.Groups.GetByID(web.SiteGroups.Web.AssociatedVisitorGroup.ID) == null)
                                    {
                                        web.AllowUnsafeUpdates = true;
                                        SPGroup group = web.SiteGroups.Web.AssociatedVisitorGroup;
                                        group.AddUser(user);
                                        web.Update();
                                        web.AllowUnsafeUpdates = false;
                                    }
                                }
                                catch { }
                            }
                        }
                }));
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.EnsureVisitor();
            //this.EnsureScriptManager();
            this.EnsureUpdatePanelFixups();
            //this.ExtendScript();

        }

        /*
        private void ExtendScript()
        {
            if (Page.ClientScript != null)
            {
                StringBuilder script = new StringBuilder();
                script.AppendLine("<script type=\"text/javascript\">");
                script.AppendLine("function HideLabel(labelID, duration) {");
                script.AppendLine("    setTimeout(\"HideLabelHelper('\" + labelID + \"');\", duration);}");
                script.AppendLine("function HideLabelHelper(labelID) {");
                script.AppendLine("    document.getElementById(labelID).style.display = \"none\";}");
                script.AppendLine("</script>");
                if (!SPPageContentManager.IsClientScriptBlockRegistered(Page,"HideLabelScript"))
                {
                    SPPageContentManager.RegisterStartupScript(Page,
                    //Page.ClientScript.RegisterClientScriptBlock(
                        GetType(), "HideLabelScript", script.ToString());
                }
            }
        }

        internal void HideLabel(string ClientID, int duration)
        {
            if (Page.ClientScript != null)
            {

                //prevent duplicate script
                if (!SPPageContentManager.IsStartupScriptRegistered(Page, "HideLabel"))
                {
                    SPPageContentManager.RegisterStartupScript(Page,
                    //Page.ClientScript.RegisterStartupScript(
                    this.GetType(), "HideLabel",
                    "<script type='text/javascript'>HideLabel('" + ClientID + "," + duration + "')</script>");
                }
            }
        } 
        */

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

        /*
        /// <summary>
        /// Ensures that the scriptmanager exists
        /// </summary>
        private void EnsureScriptManager()
        {
            ScriptManager scriptManager = ScriptManager.GetCurrent(this.Page);

            if (scriptManager == null)
            {
                scriptManager = new ScriptManager();
                scriptManager.EnablePartialRendering = true;

                if (Page.Form != null)
                {
                    Page.Form.Controls.AddAt(0, scriptManager);
                }
            }
        }
        */

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
    }
}
