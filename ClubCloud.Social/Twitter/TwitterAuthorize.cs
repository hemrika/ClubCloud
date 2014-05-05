using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Web;

namespace ClubCloud.Social.Twitter
{
    internal class TwitterAuthorize : TwitterBase
    {
        public const string RequestToken = "https://api.twitter.com/oauth/request_token";

        public const string Authorize = "https://api.twitter.com/oauth/authorize";

        public const string AccessToken = "https://api.twitter.com/oauth/access_token";

        private string consumerKey = string.Empty;

        private string consumerSecret = string.Empty;

        private string token = string.Empty;

        private string tokenSecret = string.Empty;

        private string screenName = string.Empty;

        private string twitterId = string.Empty;

        private string callBackUrl = "oob";

        private string oauthVerifier = string.Empty;

        public string CallBackUrl
        {
            get
            {
                return this.callBackUrl;
            }
            set
            {
                this.callBackUrl = value;
            }
        }

        public string ConsumerKey
        {
            get
            {
                return this.consumerKey;
            }
            set
            {
                this.consumerKey = value;
            }
        }

        public string ConsumerSecret
        {
            get
            {
                return this.consumerSecret;
            }
            set
            {
                this.consumerSecret = value;
            }
        }

        public string OAuthVerifier
        {
            get
            {
                return this.oauthVerifier;
            }
            set
            {
                this.oauthVerifier = value;
            }
        }

        public string ScreenName
        {
            get
            {
                return this.screenName;
            }
            set
            {
                this.screenName = value;
            }
        }

        public string Token
        {
            get
            {
                return this.token;
            }
            set
            {
                this.token = value;
            }
        }

        public string TokenSecret
        {
            get
            {
                return this.tokenSecret;
            }
            set
            {
                this.tokenSecret = value;
            }
        }

        public string TwitterId
        {
            get
            {
                return this.twitterId;
            }
            set
            {
                this.twitterId = value;
            }
        }

        internal TwitterAuthorize(string key, string secret, string callBackUrl)
        {
            this.ConsumerKey = key;
            this.ConsumerSecret = secret;
            this.CallBackUrl = callBackUrl;
        }

        public void AccessTokenGet(string authToken, string oauthVerifier)
        {
            this.Token = authToken;
            this.OAuthVerifier = oauthVerifier;
            string str = this.OAuthWebRequest(TwitterAuthorize.Method.GET, "https://api.twitter.com/oauth/access_token", string.Empty);
            if (str.Length > 0)
            {
                NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(str);
                if (nameValueCollection["oauth_token"] != null)
                {
                    this.Token = nameValueCollection["oauth_token"];
                }
                if (nameValueCollection["oauth_token_secret"] != null)
                {
                    this.TokenSecret = nameValueCollection["oauth_token_secret"];
                }
                if (nameValueCollection["screen_name"] != null)
                {
                    this.ScreenName = nameValueCollection["screen_name"];
                }
                if (nameValueCollection["user_id"] != null)
                {
                    this.TwitterId = nameValueCollection["user_id"];
                }
            }
        }

        public string AuthorizationLinkGet()
        {
            string str = null;
            string str1 = this.OAuthWebRequest(TwitterAuthorize.Method.GET, "https://api.twitter.com/oauth/request_token", string.Empty);
            if (str1.Length > 0)
            {
                NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(str1);
                if (nameValueCollection["oauth_callback_confirmed"] != null)
                {
                    if (nameValueCollection["oauth_callback_confirmed"] != "true")
                    {
                        throw new Exception("OAuth callback not confirmed.");
                    }
                }
                if (nameValueCollection["oauth_token"] != null)
                {
                    str = string.Concat("https://api.twitter.com/oauth/authorize?oauth_token=", nameValueCollection["oauth_token"]);
                }
            }
            return str;
        }

        public string OAuthWebRequest(TwitterAuthorize.Method method, string url, string postData)
        {
            string empty = string.Empty;
            string str = string.Empty;
            string empty1 = string.Empty;
            if ((method == TwitterAuthorize.Method.POST || method == TwitterAuthorize.Method.DELETE ? true : method == TwitterAuthorize.Method.GET))
            {
                if (postData.Length > 0)
                {
                    NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(postData);
                    postData = string.Empty;
                    string[] allKeys = nameValueCollection.AllKeys;
                    for (int i = 0; i < (int)allKeys.Length; i++)
                    {
                        string str1 = allKeys[i];
                        if (postData.Length > 0)
                        {
                            postData = string.Concat(postData, "&");
                        }
                        nameValueCollection[str1] = HttpUtility.UrlDecode(nameValueCollection[str1]);
                        nameValueCollection[str1] = TwitterBase.UrlEncode(nameValueCollection[str1]);
                        postData = string.Concat(postData, str1, "=", nameValueCollection[str1]);
                    }
                    if (url.IndexOf("?") <= 0)
                    {
                        url = string.Concat(url, "?");
                    }
                    else
                    {
                        url = string.Concat(url, "&");
                    }
                    url = string.Concat(url, postData);
                }
            }
            Uri uri = new Uri(url);
            string str2 = this.GenerateNonce();
            string str3 = this.GenerateTimeStamp();
            string str4 = base.GenerateSignature(uri, this.ConsumerKey, this.ConsumerSecret, this.Token, this.TokenSecret, this.CallBackUrl, this.OAuthVerifier, method.ToString(), str3, str2, out empty, out str);
            str = string.Concat(str, "&oauth_signature=", TwitterBase.UrlEncode(str4));
            if ((method == TwitterAuthorize.Method.POST ? true : method == TwitterAuthorize.Method.DELETE))
            {
                postData = str;
                str = string.Empty;
            }
            if (str.Length > 0)
            {
                empty = string.Concat(empty, "?");
            }
            empty1 = this.WebRequest(method, string.Concat(empty, str), postData);
            return empty1;
        }

        public string WebRequest(TwitterAuthorize.Method method, string url, string postData)
        {
            HttpWebRequest str = null;
            StreamWriter streamWriter = null;
            string empty = string.Empty;
            str = System.Net.WebRequest.Create(url) as HttpWebRequest;
            str.Method = method.ToString();
            str.ServicePoint.Expect100Continue = false;
            if ((method == TwitterAuthorize.Method.POST ? true : method == TwitterAuthorize.Method.DELETE))
            {
                str.ContentType = "application/x-www-form-urlencoded";
                streamWriter = new StreamWriter(str.GetRequestStream());
                try
                {
                    try
                    {
                        streamWriter.Write(postData);
                    }
                    catch
                    {
                        throw;
                    }
                }
                finally
                {
                    streamWriter.Close();
                    streamWriter = null;
                }
            }
            empty = this.WebResponseGet(str);
            str = null;
            return empty;
        }

        public string WebResponseGet(HttpWebRequest webRequest)
        {
            StreamReader streamReader = null;
            string empty = string.Empty;
            try
            {
                try
                {
                    streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                    empty = streamReader.ReadToEnd();
                }
                catch
                {
                    throw;
                }
            }
            finally
            {
                webRequest.GetResponse().GetResponseStream().Close();
                streamReader.Close();
                streamReader = null;
            }
            return empty;
        }

        public enum Method
        {
            GET,
            POST,
            DELETE
        }
    }
}