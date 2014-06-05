using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class PrivacyUserControl : ClubCloudUserControl
    {
        private string userId = string.Empty;
        private ClubCloud_Setting settings;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {

                    userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                    settings = Client.GetClubCloudSettings(userId);

                    if (settings != null)
                    {
                        privacy_leden_club.Checked = settings.privacy.HasFlag(Privacy.leden_club);
                        privacy_leden_clubcloud.Checked = settings.privacy.HasFlag(Privacy.leden_clubcloud);
                        privacy_competitie_club.Checked = settings.privacy.HasFlag(Privacy.competitie_club);
                        privacy_competitie_leden.Checked = settings.privacy.HasFlag(Privacy.competitie_leden);
                        privacy_toernooi_club.Checked = settings.privacy.HasFlag(Privacy.toernooi_club);
                        privacy_toernooi_leden.Checked = settings.privacy.HasFlag(Privacy.toernooi_leden);
                    }
                }
            }
            else
            {
                this.pnl_privacy.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        protected void privacy_save_Click(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                settings = new ClubCloud_Setting();

                settings.Id = int.Parse(SPContext.Current.Web.CurrentUser.UserId.NameId);
                settings.privacy = Privacy.None;

                if (privacy_leden_club.Checked)
                {
                    settings.privacy |= Privacy.leden_club;
                }

                if (privacy_leden_clubcloud.Checked)
                {
                    settings.privacy |= Privacy.leden_clubcloud;
                }

                if (privacy_competitie_club.Checked)
                {
                    settings.privacy |= Privacy.competitie_club;
                }

                if (privacy_competitie_leden.Checked)
                {
                    settings.privacy |= Privacy.competitie_leden;
                }

                if (privacy_toernooi_club.Checked)
                {
                    settings.privacy |= Privacy.toernooi_club;
                }

                if (privacy_toernooi_leden.Checked)
                {
                    settings.privacy |= Privacy.toernooi_leden;
                }

                settings = Client.SetPrivacy(settings);
            }     
        }
    }
}
