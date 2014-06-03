using ClubCloud.Service.Model;
using ClubCloud.Social.OAuth;
using ClubCloud.Social.Twitter;
using ClubCloud.Social.Twitter.OAuth;
using ClubCloud.Social.Twitter.Objects;
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
        private string ConsumerKey = "xKESVN9CwdlWGA1ve7qWdPPzU";
        private string ConsumerSecret = "szoyhGCcw4fp7fDlt8pit0o3HwwdvFd3BUbBEDTfkU08ToJyNS";

        public string OAuthToken
        {
            get { return Request.QueryString["oauth_token"]; }
        }

        public string OAuthVerifier
        {
            get { return Request.QueryString["oauth_verifier"]; }
        }

        public string DeniedToken
        {
            get { return Request.QueryString["denied"]; }
        }

        public bool HasUserDenied
        {
            get { return !String.IsNullOrEmpty(DeniedToken); }
        }

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

                TwitterOAuthClient client = new TwitterOAuthClient
                {
                    ConsumerKey = ConsumerKey,
                    ConsumerSecret = ConsumerSecret,
                    Callback = this.Page.Request.Url.AbsoluteUri
                };

                OAuthRequestToken token;

                if ((OAuthToken == null) && (!settings.twitter_allow && string.IsNullOrWhiteSpace(settings.twitter_oauth_token) && string.IsNullOrWhiteSpace(settings.twitter_oauth_token_secret)))
                {
                    token = client.GetRequestToken();
                    settings.twitter_oauth_token = token.Token;
                    settings.twitter_oauth_token_secret = token.TokenSecret;
                    Client.SetTwitter(settings);

                    Response.Redirect(token.AuthorizeUrl);
                }
                else
                {
                    client.Token = settings.twitter_oauth_token;
                    client.TokenSecret = settings.twitter_oauth_token_secret;

                    if (!settings.twitter_allow)
                    {
                        try
                        {
                            OAuthAccessToken accessToken = client.GetAccessToken(OAuthVerifier);
                            client.Token = accessToken.Token;
                            client.TokenSecret = accessToken.TokenSecret;
                            settings.twitter_oauth_token = accessToken.Token;
                            settings.twitter_oauth_token_secret = accessToken.TokenSecret;
                            settings.twitter_allow = true;
                        }
                        catch (Exception)
                        {
                            settings.twitter_allow = false;

                        }

                        Client.SetTwitter(settings);
                        string finished = "finished";
                    }

                    if(settings.twitter_allow)
                    {

                        try
                        {
                            TwitterService service = TwitterService.CreateFromOAuthClient(client);
                            TwitterUser user = service.Account.VerifyCredentials();

                            long Id = user.Id;
                            string ScreenName = user.ScreenName;
                            string ProfileImageUrlHttps = user.ProfileImageUrlHttps;
                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }

                    }
                }
                /*
                    if(settings.twitter_allow)
                    {
                        //TwitterAccessInformation information = new TwitterAccessInformation 
                        //twitterConnect.OAuthToken = settings.twitter_oauth_token;
                        //twitterConnect.OAuthTokenSecret = settings.twitter_oauth_token_secret;

                        //twitterConnect.Tweet("integration test");
                        //DataTable data = twitterConnect.FetchProfile("MijnClubCloud");
                        //int count = data.Rows.Count;
                    }
                 */
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
