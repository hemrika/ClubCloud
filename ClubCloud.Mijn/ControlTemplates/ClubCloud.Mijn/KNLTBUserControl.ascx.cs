using Microsoft.SharePoint;
using System;
using System.IO;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class KNLTBUserControl : UserControl
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if(SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                this.tbx_knltbid.Text = userId;
            }
            else
            {
                this.pnl_knltb.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        private string password = string.Empty;
        private string userId = string.Empty;

        protected void btn_knltbpw_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbx_knltbpw.Text))
            {
                password = tbx_knltbpw.Text.Trim();
                if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
                {
                    userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                    ClubCloud.Service.Model.ClubCloud_Gebruiker user = Client.GetClubCloudUser(userId);
                    if(password != user.mijnknltb_password || string.IsNullOrWhiteSpace(user.mijnknltb_password))
                    {
                        lbl_knltbpw_result.Text = "Wachtwoord gewijzigd";
                    }
                    else
                    {
                        lbl_knltbpw_result.Text = "Geen veranderingen gedaan";
                    }
                }
            }

        }

        protected void tbx_knltbpw_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbx_knltbid.Text) && !string.IsNullOrWhiteSpace(tbx_knltbpw.Text))
            {
                btn_knltbpw.Enabled = true;
            }
        }
    }
}
