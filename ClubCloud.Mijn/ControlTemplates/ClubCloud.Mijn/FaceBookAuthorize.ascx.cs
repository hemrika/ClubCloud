using ClubCloud.Service.Model;
using ClubCloud.Social.Facebook;
using ClubCloud.Social.Facebook.OAuth;
using ClubCloud.Social.Facebook.Responses;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class FaceBookAuthorize : ClubCloudUserControl
    {
        private string AppId = "554213928032357";
        private string AppSecret = "77fcabfeb52728726784ebc0b552f0c9";

        public string AuthCode
        {
            get { return Request.QueryString["code"]; }
        }

        public string AuthState
        {
            get { return Request.QueryString["state"]; }
        }

        public string AuthErrorReason
        {
            get { return Request.QueryString["error_reason"]; }
        }

        public string AuthError
        {
            get { return Request.QueryString["error"]; }
        }

        public string AuthErrorDescription
        {
            get { return Request.QueryString["error_description"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (Settings != null)
                {
                    byte[] BinaryId = SPContext.Current.Web.CurrentUser.GetBinaryId();
                    string BinaryJoin = string.Join("|", BinaryId);

                    FacebookOAuthClient client = new FacebookOAuthClient
                    {
                        AppId = AppId,
                        AppSecret = AppSecret,
                        ReturnUri = this.Page.Request.Url.AbsoluteUri
                    };

                    if ((AuthCode == null) && (!Settings.facebook_allow && string.IsNullOrWhiteSpace(Settings.facebook_access_token)))
                    {
                        FacebookScopeCollection scope = new FacebookScopeCollection();
                        scope.Add(FacebookScope.PublishStream);
                        scope.Add(FacebookScope.PublishActions);
                        scope.Add(FacebookScope.Email);
                        scope.Add(FacebookScope.Birthday);


                        Response.Redirect(client.GetAuthorizationUrl(BinaryJoin, scope));

                    }
                    else
                    {
                        if (AuthCode != null)
                        {
                            try
                            {
                                string userAccessToken = client.GetAccessTokenFromAuthCode(AuthCode);
                                Settings.facebook_access_token = userAccessToken;
                                Settings.facebook_allow = true;
                                Client.SetFaceBook(Settings);
                            }
                            catch (Exception ex)
                            {
                                string emssage = ex.Message;
                            }
                        }
                    }
                }
            }
            else
            {
                this.pnl_facebook.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }

        protected override void Render(HtmlTextWriter writer)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (Settings != null)
                {
                    if (Settings.facebook_allow)
                    {
                        FacebookOAuthClient client = new FacebookOAuthClient
                        {
                            AppId = AppId,
                            AppSecret = AppSecret,
                            ReturnUri = this.Page.Request.Url.AbsoluteUri
                        };

                        try
                        {

                            // Initialize the Facebook service (no calls are made here)
                            FacebookService service = FacebookService.CreateFromAccessToken(Settings.facebook_access_token);

                            // Make a call to the Facebook API to get information about the user
                            FacebookMeResponse user = service.Methods.Me();

                            if (user != null)
                            {
                                System.Web.UI.WebControls.Literal literal = new Literal();

                                literal.Text += "<pre><b>Id</b> " + user.Id + "</pre>";
                                literal.Text += "<pre><b>UserName</b> " + user.UserName + "</pre>";
                                literal.Text += "<pre><b>Name</b> " + user.Name + "</pre>";
                                literal.Text += "<pre><b>Url</b> " + user.Link + "</pre>";
                                literal.Text += "<pre><b>Description</b> " + user.Locale + "</pre>\n";

                                pnl_facebook.Controls.Add(literal);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                }
            }

            base.Render(writer);
        }
    }
}
