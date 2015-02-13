using ClubCloud.Model;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class MijnResultatenUserControl : ClubCloudUserControl
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.EnsureChildControls();
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }

        internal override void SetPageData()
        {
            if (Settings != null)//&& Settings.mijnknltb_allow)
            {
                //Client.GetDistricten
            }
            else
            {
                pnl_authorize.Visible = true;
            }
        }

        protected void tmr_loader_resultaten_Tick(object sender, EventArgs e)
        {
            tmr_loader_resultaten.Enabled = false;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                SetPageData();
            }
            else
            {
                this.pnl_resultaten.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }
    }
}
