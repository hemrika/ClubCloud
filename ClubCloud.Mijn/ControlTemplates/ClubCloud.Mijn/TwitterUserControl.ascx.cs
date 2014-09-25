using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class TwitterUserControl : ClubCloudUserControl
    {
        //private string userId = string.Empty;
        //private ClubCloud_Setting settings;

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
                this.pnl_twitter.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        internal override void SetPageData()
        {
            if (Settings != null )
            {
                twitter_allow.Checked = Settings.twitter_allow;
                twitter_updates.Checked = Settings.twitter_setting.HasFlag(Twitter.Tweet);
                twitter_winning.Checked = Settings.twitter_setting.HasFlag(Twitter.Succes);
                twitter_competitie.Checked = Settings.twitter_setting.HasFlag(Twitter.Competitie);
                twitter_toernament.Checked = Settings.twitter_setting.HasFlag(Twitter.Toernooi);

                if (!Settings.twitter_allow) //&& string.IsNullOrWhiteSpace(Settings.twitter_oauth_token) && string.IsNullOrWhiteSpace(Settings.twitter_oauth_token_secret))
                {
                    lbn_aanvragen.OnClientClick = "window.open(\"../twitter.aspx\",\"Twitter\",\"width=550,height=170,left=150,top=200,toolbar=0,status=0,\");";  //"location.href='../twitter.aspx'";
                }

            }

        }

        protected void twitter_save_Click(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                try
                {
                    Settings = new ClubCloud_Setting();

                    Settings.Id = int.Parse(SPContext.Current.Web.CurrentUser.UserId.NameId);
                    Settings.twitter_allow = twitter_allow.Checked;
                    Settings.twitter_setting = Twitter.None;

                    /*
                    if (twitter_updates.Checked)
                    {
                        Settings.twitter_setting |= Twitter.Tweet;
                    }
                    */
                    if (twitter_winning.Checked)
                    {
                        Settings.twitter_setting |= Twitter.Succes;
                    }

                    if (twitter_competitie.Checked)
                    {
                        Settings.twitter_setting |= Twitter.Competitie;
                    }

                    if (twitter_toernament.Checked)
                    {
                        Settings.twitter_setting |= Twitter.Toernooi;
                    }

                    Settings = Client.SetTwitter(Settings);

                    lbl_result.Text = "Wijzigingen opgeslagen.";
                    lbl_result.ForeColor = Color.Green;

                }
                catch
                {
                    lbl_result.Text = "Wijzigingen niet opgeslagen.";
                    lbl_result.ForeColor = Color.Red;

                }
                //HideLabel(lbl_result.ClientID, 6000);
            }            
        }
    }
}
