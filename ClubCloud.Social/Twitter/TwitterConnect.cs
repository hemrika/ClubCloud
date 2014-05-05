using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.SessionState;

namespace ClubCloud.Social.Twitter
{
    public class TwitterConnect
    {
        public static string API_Key
        {
            get;
            set;
        }

        public static string API_Secret
        {
            get;
            set;
        }

        public string CallBackUrl
        {
            get
            {
                string str;
                if (HttpContext.Current.Session["CallBackUrl"] == null)
                {
                    str = null;
                }
                else
                {
                    str = HttpContext.Current.Session["CallBackUrl"].ToString();
                }
                return str;
            }
            set
            {
                HttpContext.Current.Session["CallBackUrl"] = value;
            }
        }

        public static bool IsAuthorized
        {
            get
            {
                bool flag = !HttpContext.Current.Request.QueryString["oauth_token"].IsEmpty();
                return flag;
            }
        }

        public static bool IsDenied
        {
            get
            {
                bool flag = !HttpContext.Current.Request.QueryString["denied"].IsEmpty();
                return flag;
            }
        }

        public string OAuthToken
        {
            get
            {
                string str;
                if (HttpContext.Current.Session["OAuthToken"] == null)
                {
                    str = null;
                }
                else
                {
                    str = HttpContext.Current.Session["OAuthToken"].ToString();
                }
                return str;
            }
            set
            {
                HttpContext.Current.Session["OAuthToken"] = value;
            }
        }

        public string OAuthTokenSecret
        {
            get
            {
                string str;
                if (HttpContext.Current.Session["OAuthTokenSecret"] == null)
                {
                    str = null;
                }
                else
                {
                    str = HttpContext.Current.Session["OAuthTokenSecret"].ToString();
                }
                return str;
            }
            set
            {
                HttpContext.Current.Session["OAuthTokenSecret"] = value;
            }
        }

        public TwitterConnect()
        {
        }

        public void Authorize(string callBackUrl)
        {
            this.OAuthToken = null;
            this.OAuthTokenSecret = null;
            this.CallBackUrl = callBackUrl;
            TwitterAuthorize twitterAuth = new TwitterAuthorize(TwitterConnect.API_Key, TwitterConnect.API_Secret, this.CallBackUrl);
            HttpContext.Current.Response.Redirect(twitterAuth.AuthorizationLinkGet());
        }

        public DataTable FetchProfile(string screenName)
        {
            return this.FetchTwitterProfile(screenName);
        }

        public DataTable FetchProfile()
        {
            return this.FetchTwitterProfile(null);
        }

        private DataTable FetchTwitterProfile(string screenName)
        {
            DataTable dataTable;
            string empty = string.Empty;
            string str = string.Empty;
            TwitterAuthorize twitterAuth = new TwitterAuthorize(TwitterConnect.API_Key, TwitterConnect.API_Secret, this.CallBackUrl);
            if ((this.OAuthToken == null ? false : this.OAuthTokenSecret != null))
            {
                twitterAuth.TokenSecret = this.OAuthToken;
                twitterAuth.Token = this.OAuthTokenSecret;
                twitterAuth.OAuthVerifier = HttpContext.Current.Request.QueryString["oauth_verifier"];
            }
            else
            {
                twitterAuth.AccessTokenGet(HttpContext.Current.Request.QueryString["oauth_token"], HttpContext.Current.Request.QueryString["oauth_verifier"]);
                this.OAuthToken = twitterAuth.TokenSecret;
                this.OAuthTokenSecret = twitterAuth.Token;
            }
            if (twitterAuth.TokenSecret.Length <= 0)
            {
                throw new Exception("Invalid Twitter token.");
            }
            empty = "https://api.twitter.com/1.1/users/show.json";
            if (screenName == null)
            {
                screenName = twitterAuth.ScreenName;
            }
            str = twitterAuth.OAuthWebRequest(TwitterAuthorize.Method.GET, empty, string.Format("screen_name={0}", screenName));
            try
            {
                DataSet dataSet = new DataSet();
                try
                {
                    string str1 = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><twitter>";
                    string[] strArrays = new string[] { ",\"" };
                    string[] strArrays1 = str.Split(strArrays, StringSplitOptions.None);
                    for (int i = 0; i < (int)strArrays1.Length; i++)
                    {
                        string str2 = strArrays1[i];
                        strArrays = new string[] { "\":" };
                        string str3 = str2.Split(strArrays, StringSplitOptions.None)[0].Replace("\"", string.Empty).Replace("{", string.Empty);
                        strArrays = new string[] { "\":" };
                        string str4 = str2.Split(strArrays, StringSplitOptions.None)[1].Replace("\"", string.Empty).Replace("}", string.Empty).Replace("\\", string.Empty);
                        if ((str4.StartsWith("{") ? false : !str4.StartsWith("[")))
                        {
                            str4 = str4.Replace("null", string.Empty).Replace("[]", string.Empty);
                            str1 = string.Concat(str1, string.Format("<{0}>{1}</{0}>", str3, str4));
                        }
                    }
                    str1 = string.Concat(str1, "</twitter>");
                    StringReader stringReader = new StringReader(str1);
                    try
                    {
                        dataSet.ReadXml(stringReader);
                    }
                    finally
                    {
                        if (stringReader != null)
                        {
                            ((IDisposable)stringReader).Dispose();
                        }
                    }
                    DataTable dataTable1 = dataSet.Tables["twitter"].Copy();
                    foreach (DataTable table in dataSet.Tables)
                    {
                        if (table.TableName != "twitter")
                        {
                            string str5 = table.Rows[0][0].ToString();
                            if ((str5.Contains("{") ? false : !str5.Contains("}")))
                            {
                                dataTable1.Columns.Add(table.TableName);
                                dataTable1.Rows[0][table.TableName] = str5;
                            }
                        }
                    }
                    dataTable1.PrimaryKey = null;
                    if (dataTable1.Columns.IndexOf("twitter_id") != -1)
                    {
                        dataTable1.Columns.Remove(dataTable1.Columns["twitter_id"]);
                    }
                    dataTable1.Columns["id"].SetOrdinal(0);
                    dataTable = dataTable1;
                }
                finally
                {
                    if (dataSet != null)
                    {
                        ((IDisposable)dataSet).Dispose();
                    }
                }
            }
            catch
            {
                throw new Exception("An error occured while parsing the Twitter response.");
            }
            return dataTable;
        }

        public void Tweet(string content)
        {
            string empty = string.Empty;
            string str = string.Empty;
            TwitterAuthorize twitterAuth = new TwitterAuthorize(TwitterConnect.API_Key, TwitterConnect.API_Secret, this.CallBackUrl);
            if ((this.OAuthToken == null ? false : this.OAuthTokenSecret != null))
            {
                twitterAuth.TokenSecret = this.OAuthToken;
                twitterAuth.Token = this.OAuthTokenSecret;
                twitterAuth.OAuthVerifier = HttpContext.Current.Request.QueryString["oauth_verifier"];
            }
            else
            {
                twitterAuth.AccessTokenGet(HttpContext.Current.Request.QueryString["oauth_token"], HttpContext.Current.Request.QueryString["oauth_verifier"]);
                this.OAuthToken = twitterAuth.TokenSecret;
                this.OAuthTokenSecret = twitterAuth.Token;
            }
            if (twitterAuth.TokenSecret.Length > 0)
            {
                empty = "https://api.twitter.com/1.1/statuses/update.json";
                str = twitterAuth.OAuthWebRequest(TwitterAuthorize.Method.POST, empty, string.Concat("status=", TwitterBase.UrlEncode(content)));
            }
        }
    }
}