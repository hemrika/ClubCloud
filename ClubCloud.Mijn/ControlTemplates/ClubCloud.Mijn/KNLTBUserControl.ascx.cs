using Microsoft.SharePoint;
using System;
using System.IO;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class KNLTBUserControl : UserControl
    {
        private CookieContainer _CookieContainer;

        public CookieContainer cookieContainer
        {
            get { return _CookieContainer; }
            set { _CookieContainer = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                this.tbx_knltbid.Text = userId;
            }
            else
            {
                this.pnl_knltb.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        private string password = string.Empty;
        private string userId = string.Empty;

        protected void btn_knltbpw_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbx_knltbpw.Text))
            {
                password = tbx_knltbpw.Text.Trim();
                if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
                {
                    userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                    //KNLTBLogin();
                }
            }

        }

        public void GetCookieContainer()
        {

            System.Web.HttpCookieCollection wcookies = Page.Request.Cookies;
            CookieCollection cookies = null;

            if (wcookies.Count == 0)
            {
                return;
            }
            else
            {
                try
                {
                    cookies = cookieContainer.GetCookies(new Uri("https://www.mijnknltb.nl"));
                }
                catch { }
                if (cookieContainer == null)
                {
                    cookieContainer = new CookieContainer();
                }
            }

            foreach (string scookie in wcookies)
            {
                HttpCookie wcookie = wcookies[scookie];
                bool update = false;
                Cookie cookie = null;

                try
                {
                    cookie = cookies[wcookie.Name];
                    if (cookie != null && cookie.Name == wcookie.Name)
                    {
                        update = true;
                    }

                }
                catch { cookie = new Cookie(); }
                
                try
                {

                    cookie.Domain = (!string.IsNullOrWhiteSpace(wcookie.Domain)) ? wcookie.Domain : "mijnknltb.nl";
                    cookie.Expires = wcookie.Expires;
                    cookie.HttpOnly = wcookie.HttpOnly;
                    cookie.Name = wcookie.Name;
                    cookie.Path = wcookie.Path;
                    cookie.Secure = wcookie.Secure;
                    cookie.Value = wcookie.Value;
                    cookieContainer.Add(cookie);
                }
                catch { }

            }
        }

        public void SetCookieContainer()
        {
            if (cookieContainer == null)
            {
                cookieContainer = new CookieContainer();
            }

            CookieCollection cookies = cookieContainer.GetCookies(new Uri("https://www.mijnknltb.nl"));

            if (cookies.Count == 0)
            {
                return;
            }

            foreach (Cookie cookie in cookies)
            {
                bool update = false;
                HttpCookie wcookie = null;
                try
                {

                    wcookie = Page.Response.Cookies[cookie.Name];
                    if (wcookie != null && wcookie.Name == cookie.Name)
                    {
                        update = true;
                    }
                }
                catch
                {
                    wcookie = new HttpCookie(cookie.Name);
                }

                try
                {
                    wcookie.Domain = (!string.IsNullOrWhiteSpace(cookie.Domain)) ? cookie.Domain : "mijnknltb.nl";
                    wcookie.Expires = cookie.Expires;
                    wcookie.HttpOnly = cookie.HttpOnly;
                    wcookie.Name = cookie.Name;
                    wcookie.Path = cookie.Path;
                    wcookie.Secure = cookie.Secure;
                    wcookie.Value = cookie.Value;

                    if (update)
                    {
                        Page.Response.Cookies.Set(wcookie);
                    }
                    else
                    {
                        Page.Response.Cookies.Add(wcookie);
                    }
                }
                catch { }
            }
        }

        private void KNLTBLogin()
        {
            string logonUrl = "https://www.mijnknltb.nl/CookieAuth.dll?Logon";

            GetCookieContainer();
            var request = (HttpWebRequest)WebRequest.Create(logonUrl);
            request.CookieContainer = cookieContainer;
            bool support = request.SupportsCookieContainer;
            request.Method = "POST";
            request.Accept = "text/html, application/xhtml+xml, */*";
            //request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
            //request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko";
            request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
            request.Host = "www.mijnknltb.nl";
            request.KeepAlive = true;

            request.BeginGetRequestStream(RequestCallback, request);

        }

        private void RequestCallback(IAsyncResult ar)
        {
            //string password = tbx_knltbpw.Text;
            var postData = string.Format("curl=Z2F&flags=0&forcedownlevel=0&formdir=12&trusted=0&username={0}&password={1}&SubmitCreds=%C2%A0", System.Uri.EscapeDataString(userId), System.Uri.EscapeDataString(password));
            var request = (HttpWebRequest)ar.AsyncState;
            var stream = request.EndGetRequestStream(ar);

            using (var sw = new StreamWriter(stream))
            {
                sw.Write(postData);
            }

            request.BeginGetResponse(ResponseCallback, request);
        }

        private void ResponseCallback(IAsyncResult ar)
        {
            var request = (HttpWebRequest)ar.AsyncState;
            var response = request.EndGetResponse(ar);
            SetCookieContainer();
        }

        protected void tbx_knltbpw_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbx_knltbid.Text) && string.IsNullOrWhiteSpace(tbx_knltbpw.Text))
            {
                btn_knltbpw.Enabled = true;
            }
        }
    }
}
