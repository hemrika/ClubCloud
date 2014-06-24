using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    

    public partial class KNLTBUserControl : ClubCloudUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {
                    SetPageData();
                }
            }
            else
            {
                this.pnl_knltb.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        internal override void SetPageData()
        {
            if (Settings != null)
            {
                this.tbx_knltbid.Text = Settings.Id.ToString();
                this.cbx_knltb.Checked = Settings.mijnknltb_allow;
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
                    Settings = new ClubCloud_Setting();
                    Settings.Id = int.Parse(userId);

                    if(!string.IsNullOrWhiteSpace(password) && cbx_knltb.Checked)
                    {
                        Settings.mijnknltb_allow = cbx_knltb.Checked;
                        Settings.mijnknltb_password = password;
                        Settings = Client.SetMijnKNLTB(Settings);
                        //vds_knltb.Text = "Veranderingen opgeslagen";

                        Client.GetClubCloudGebruiker(userId, true);
                    }
                    else
                    {
                        //vds_betalingen.Text = "Geen veranderingen gedaan";
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
