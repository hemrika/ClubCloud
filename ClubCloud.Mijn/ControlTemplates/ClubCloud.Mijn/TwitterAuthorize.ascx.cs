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
        private string userId = string.Empty;
        private ClubCloud_Setting settings;
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


        protected override void Render(HtmlTextWriter writer)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {

                if (settings.twitter_allow)
                {
                    TwitterOAuthClient client = new TwitterOAuthClient
                    {
                        ConsumerKey = ConsumerKey,
                        ConsumerSecret = ConsumerSecret,
                        Token = settings.twitter_oauth_token,
                        TokenSecret = settings.twitter_oauth_token_secret,
                        Callback = this.Page.Request.Url.AbsoluteUri
                    };

                    try
                    {
                        TwitterService service = TwitterService.CreateFromOAuthClient(client);
                        TwitterUser user = service.Account.VerifyCredentials();

                        if (user != null)
                        {
                            System.Web.UI.WebControls.Literal literal = new Literal();

                            literal.Text += "<pre><b>Id</b> " + user.Id + "</pre>";
                            literal.Text += "<pre><b>ScreenName</b> " + user.ScreenName + "</pre>";
                            literal.Text += "<pre><b>Name</b> " + user.Name + "</pre>";
                            literal.Text += "<pre><b>Avatar</b> " + user.ProfileImageUrlHttps + "</pre>";
                            literal.Text += "<pre><b>Url</b> " + user.Url + "</pre>";
                            literal.Text += "<pre><b>Description</b> " + user.Description + "</pre>";

                            literal.Text += "<img src=\"" + user.ProfileImageUrlHttps + "\" alt=\"\" />\n";

                            pnl_twitter.Controls.Add(literal);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        
            base.Render(writer);
        }

    }
}
