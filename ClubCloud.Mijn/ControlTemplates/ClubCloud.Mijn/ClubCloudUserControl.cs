using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace ClubCloud.Mijn.ControlTemplates
{
    public class ClubCloudUserControl : UserControl
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.EnsureVisitor();
            this.EnsureScriptManager();
            this.EnsureUpdatePanelFixups();

        }

        private void EnsureVisitor()
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                Guid id = SPContext.Current.Site.ID;
                SPUser user = SPContext.Current.Web.CurrentUser;
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                        using (SPSite site = new SPSite(id))
                        {
                            using (SPWeb web = site.RootWeb)
                            {
                                try
                                {
                                    if (user.Groups.GetByID(web.SiteGroups.Web.AssociatedVisitorGroup.ID) == null)
                                    web.AllowUnsafeUpdates = true;
                                    SPGroup group = web.SiteGroups.Web.AssociatedVisitorGroup;
                                    group.AddUser(user);
                                    web.Update();
                                    web.AllowUnsafeUpdates = false;
                                }
                                catch { }
                            }
                        }
                });
            }
        }

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
    }
}
