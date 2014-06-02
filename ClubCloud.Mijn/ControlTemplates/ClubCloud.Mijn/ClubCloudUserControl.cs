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

            this.EnsureScriptManager();
            this.EnsureUpdatePanelFixups();

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
