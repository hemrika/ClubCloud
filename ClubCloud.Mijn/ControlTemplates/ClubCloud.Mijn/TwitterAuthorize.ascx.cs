using ClubCloud.Social.Twitter;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class TwitterAuthorize : UserControl
    {
        private ClubCloud.Service.ClubCloudServiceClient _client = null;
        private TwitterConnect _twitterConnect;

        public TwitterConnect twitterConnect
        {
            get {
                if(_twitterConnect == null)
                {
                    _twitterConnect = new TwitterConnect();
                }
                return _twitterConnect; }
            set { _twitterConnect = value; }
        }

        public ClubCloud.Service.ClubCloudServiceClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new Service.ClubCloudServiceClient(SPServiceContext.Current);
                }
                return _client;
            }
        }

        public TwitterAuthorize()
        {
            TwitterConnect.API_Key = "xKESVN9CwdlWGA1ve7qWdPPzU";
            TwitterConnect.API_Secret = "szoyhGCcw4fp7fDlt8pit0o3HwwdvFd3BUbBEDTfkU08ToJyNS";
            //twitterConnect.CallBackUrl = this.Page.Request.Url.AbsoluteUri;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                if (!TwitterConnect.IsAuthorized)// || !TwitterConnect.IsDenied)
                {
                    twitterConnect.Authorize(this.Page.Request.Url.AbsoluteUri);
                }
                else
                {
                    string token = twitterConnect.OAuthToken;
                    string secret = twitterConnect.OAuthTokenSecret;
                }
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
