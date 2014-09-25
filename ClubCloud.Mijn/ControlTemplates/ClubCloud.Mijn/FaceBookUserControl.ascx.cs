using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class FaceBookUserControl : ClubCloudUserControl
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                SetPageData();
            }
            else
            {
                this.pnl_facebook.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        internal override void SetPageData()
        {

        }
    }
}
