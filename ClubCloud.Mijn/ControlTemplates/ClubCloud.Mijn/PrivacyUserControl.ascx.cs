using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class PrivacyUserControl : ClubCloudUserControl
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
                this.pnl_privacy.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        internal override void SetPageData()
        {
            if (Settings != null)
            {
                privacy_leden_club.Checked = Settings.privacy.HasFlag(Privacy.leden_club);
                privacy_leden_clubcloud.Checked = Settings.privacy.HasFlag(Privacy.leden_clubcloud);
                privacy_competitie_club.Checked = Settings.privacy.HasFlag(Privacy.competitie_club);
                privacy_competitie_leden.Checked = Settings.privacy.HasFlag(Privacy.competitie_leden);
                privacy_toernooi_club.Checked = Settings.privacy.HasFlag(Privacy.toernooi_club);
                privacy_toernooi_leden.Checked = Settings.privacy.HasFlag(Privacy.toernooi_leden);

            }

        }

        protected void privacy_save_Click(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                //Settings = new ClubCloud_Setting();

                //Settings.Id = int.Parse(SPContext.Current.Web.CurrentUser.UserId.NameId);
                Settings.privacy = Privacy.None;

                if (privacy_leden_club.Checked)
                {
                    Settings.privacy |= Privacy.leden_club;
                }

                if (privacy_leden_clubcloud.Checked)
                {
                    Settings.privacy |= Privacy.leden_clubcloud;
                }

                if (privacy_competitie_club.Checked)
                {
                    Settings.privacy |= Privacy.competitie_club;
                }

                if (privacy_competitie_leden.Checked)
                {
                    Settings.privacy |= Privacy.competitie_leden;
                }

                if (privacy_toernooi_club.Checked)
                {
                    Settings.privacy |= Privacy.toernooi_club;
                }

                if (privacy_toernooi_leden.Checked)
                {
                    Settings.privacy |= Privacy.toernooi_leden;
                }

                Settings = Client.SetClubCloudSettings(Settings);
            }     
        }
    }
}
