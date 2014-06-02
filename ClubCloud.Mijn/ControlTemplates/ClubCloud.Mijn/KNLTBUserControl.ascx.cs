using ClubCloud.Service.Model;
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
    

    public partial class KNLTBUserControl : ClubCloudUserControl
    {
        private ClubCloud_Setting settings;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {
                    userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                    settings = Client.GetClubCloudSettings(userId);
                    this.tbx_knltbid.Text = settings.Id.ToString();
                    this.cbx_knltb.Checked = settings.mijnknltb_allow;
                }
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
                    settings = new ClubCloud_Setting();
                    settings.Id = int.Parse(userId);

                    if(!string.IsNullOrWhiteSpace(password) && cbx_knltb.Checked)
                    {
                        settings.mijnknltb_allow = cbx_knltb.Checked;
                        settings.mijnknltb_password = password;
                        settings = Client.SetMijnKNLTB(settings);
                        lbl_knltbpw_result.Text = "Veranderingen opgeslagen";

                        Client.GetClubCloudGebruiker(userId, true);
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
