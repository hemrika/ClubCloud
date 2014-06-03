using ClubCloud.Service.Model;
using ClubCloud.Social.Twitter;
using ClubCloud.Social.Twitter.OAuth;
using Microsoft.SharePoint;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class TwitterAuthorize : ClubCloudUserControl
    {
        private ClubCloud_Setting settings;
        /*
        private ClubCloud.Social.Twitter.TwitterService _twitterService;
        

        public TwitterService twitterService
        {
            get {
                if (_twitterService == null)
                {
                    _twitterService = new TwitterService();
                }
                return _twitterService;
            }
            set { _twitterService = value; }
        }
        */

        public TwitterAuthorize()
        {

            //TwitterConnect.API_Key = "xKESVN9CwdlWGA1ve7qWdPPzU";
            //TwitterConnect.API_Secret = "szoyhGCcw4fp7fDlt8pit0o3HwwdvFd3BUbBEDTfkU08ToJyNS";
            //twitterConnect.CallBackUrl = this.Page.Request.Url.AbsoluteUri;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                settings = Client.GetClubCloudSettings(userId);
                TwitterOAuthClient twitterOAuth = new TwitterOAuthClient();

                /*
                if (!TwitterConnect.IsAuthorized && (!settings.twitter_allow && string.IsNullOrWhiteSpace(settings.twitter_oauth_token) && string.IsNullOrWhiteSpace(settings.twitter_oauth_token_secret)) )
                {
                    twitterConnect.Authorize(this.Page.Request.Url.AbsoluteUri);
                }
                else
                {
                */
                    if (Page.Request.QueryString.HasKeys())
                    {
                        System.Collections.Specialized.NameValueCollection query = Page.Request.QueryString;

                        if (query.HasKeys())
                        {
                            foreach (string key in query.Keys)
                            {
                                if (key == "oauth_token")
                                {
                                    string value = query[key];
                                    //twitterConnect.OAuthToken = value;
                                    settings.twitter_oauth_token = value;
                                }

                                if (key == "oauth_verifier")
                                {
                                    string value = query[key];
                                    //twitterConnect.OAuthTokenSecret = value;
                                    settings.twitter_oauth_token_secret = value;
                                }

                                if (key == "denied")
                                {
                                    settings.twitter_allow = false;
                                    settings.twitter_oauth_token_secret = null;
                                    settings.twitter_oauth_token = null;
                                }

                            }

                            if(!string.IsNullOrWhiteSpace(settings.twitter_oauth_token) && !string.IsNullOrWhiteSpace(settings.twitter_oauth_token_secret))
                            {
                                settings.twitter_allow = true;
                                
                            }

                            Client.SetTwitter(settings);
                        }
                    }

                    if(settings.twitter_allow)
                    {
                        //TwitterAccessInformation information = new TwitterAccessInformation 
                        //twitterConnect.OAuthToken = settings.twitter_oauth_token;
                        //twitterConnect.OAuthTokenSecret = settings.twitter_oauth_token_secret;

                        //twitterConnect.Tweet("integration test");
                        //DataTable data = twitterConnect.FetchProfile("MijnClubCloud");
                        //int count = data.Rows.Count;
                    }
                //}
            }
            else
            {
                this.pnl_twitter.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }

        private string userId = string.Empty;

    }
}
