using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class TwitterUserControl : ClubCloudUserControl
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
                            twitter_allow.Checked = settings.twitter_allow;
                            twitter_updates.Checked = settings.twitter_setting.HasFlag(Twitter.Tweet);
                            twitter_winning.Checked = settings.twitter_setting.HasFlag(Twitter.Succes);
                            twitter_competitie.Checked = settings.twitter_setting.HasFlag(Twitter.Competitie);
                            twitter_toernament.Checked = settings.twitter_setting.HasFlag(Twitter.Toernooi);
                        }
                    }
                }
                else
                {
                    this.pnl_twitter.Visible = false;
                    this.pnl_secure.Visible = true;
                }
        }

        protected void twitter_save_Click(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                settings = new ClubCloud_Setting();

                settings.Id = int.Parse(SPContext.Current.Web.CurrentUser.UserId.NameId);
                settings.twitter_allow = twitter_allow.Checked;
                settings.twitter_setting = Twitter.None;

                if(twitter_updates.Checked)
                {
                    settings.twitter_setting |= Twitter.Tweet;
                }

                if (twitter_winning.Checked)
                {
                    settings.twitter_setting |= Twitter.Succes;
                }

                if (twitter_competitie.Checked)
                {
                    settings.twitter_setting |= Twitter.Competitie;
                }

                if (twitter_toernament.Checked)
                {
                    settings.twitter_setting |= Twitter.Toernooi;
                }

                settings = Client.SetTwitter(settings);
            }            
        }
    }
}
