using ClubCloud.Model;
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
        protected new void Page_Load(object sender, EventArgs e)
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
                this.cbx_knltb.Checked = Settings.Agree;
            }

        }

        private string password = string.Empty;
        //private string userId = string.Empty;

        protected void btn_knltbpw_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbx_knltbpw.Text))
            {
                password = tbx_knltbpw.Text.Trim();
                if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
                {
                    userId = SPContext.Current.Web.CurrentUser.UserId.NameId;

                    if(!string.IsNullOrWhiteSpace(password) && cbx_knltb.Checked && Settings != null)
                    {
                        Settings.Agree = cbx_knltb.Checked;
                        Settings.Password = password;
                        Settings = Client.SetMijnKNLTB(Settings);

                        string pw = Settings.Password;

                        //vds_knltb.Summary = "Veranderingen opgeslagen";

                        //ClubCloud_Gebruiker gebruiker = Client.GetGebruikerByNummer(userId, Settings.VerenigingId.Value, userId, true);
                    }
                    else
                    {
                        //vds_knltb.Text = "Geen veranderingen gedaan";
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
