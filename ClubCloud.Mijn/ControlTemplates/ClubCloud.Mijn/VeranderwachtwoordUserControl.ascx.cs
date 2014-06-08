using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class VeranderwachtwoordUserControl : ClubCloudUserControl
    {
        private string userId = string.Empty;
        private ClubCloud_Setting settings;

        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Web.Security.Membership.Provider.ChangePassword()
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {

                    userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                    settings = Client.GetClubCloudSettings(userId);

                    if (settings != null)
                    {
                    }
                }
            }
            else
            {
                this.pnl_password.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }
    }
}
