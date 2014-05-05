using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class FaceBookUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
            }
            else
            {
                this.pnl_facebook.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }
    }
}
