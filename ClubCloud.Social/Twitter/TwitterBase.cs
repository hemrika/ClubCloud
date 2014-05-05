using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ClubCloud.Social.Twitter
{
    internal class TwitterBase
    {
        protected const string OAuthVersion = "1.0";

        protected const string OAuthParameterPrefix = "oauth_";

        protected const string OAuthConsumerKeyKey = "oauth_consumer_key";

        protected const string OAuthCallbackKey = "oauth_callback";

        protected const string OAuthVersionKey = "oauth_version";

        protected const string OAuthSignatureMethodKey = "oauth_signature_method";

        protected const string OAuthSignatureKey = "oauth_signature";

        protected const string OAuthTimestampKey = "oauth_timestamp";

        protected const string OAuthNonceKey = "oauth_nonce";

        protected const string OAuthTokenKey = "oauth_token";

        protected const string OAuthTokenSecretKey = "oauth_token_secret";

        protected const string OAuthVerifierKey = "oauth_verifier";

        protected const string HMACSHA1SignatureType = "HMAC-SHA1";

        protected const string PlainTextSignatureType = "PLAINTEXT";

        protected const string RSASHA1SignatureType = "RSA-SHA1";

        protected Random random = new Random();

        protected static string unreservedChars;

        static TwitterBase()
        {
            TwitterBase.unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";
        }

        public TwitterBase()
        {
        }

        private string ComputeHash(HashAlgorithm hashAlgorithm, string data)
        {
            if (hashAlgorithm == null)
            {
                throw new ArgumentNullException("hashAlgorithm");
            }
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("data");
            }
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            return Convert.ToBase64String(hashAlgorithm.ComputeHash(bytes));
        }

        public virtual string GenerateNonce()
        {
            return this.random.Next(123400, 9999999).ToString();
        }

        public string GenerateSignature(Uri url, string consumerKey, string consumerSecret, string token, string tokenSecret, string callBackUrl, string oauthVerifier, string httpMethod, string timeStamp, string nonce, out string normalizedUrl, out string normalizedRequestParameters)
        {
            string str = this.GenerateSignature(url, consumerKey, consumerSecret, token, tokenSecret, callBackUrl, oauthVerifier, httpMethod, timeStamp, nonce, TwitterBase.SignatureTypes.HMACSHA1, out normalizedUrl, out normalizedRequestParameters);
            return str;
        }

        public string GenerateSignature(Uri url, string consumerKey, string consumerSecret, string token, string tokenSecret, string callBackUrl, string oauthVerifier, string httpMethod, string timeStamp, string nonce, TwitterBase.SignatureTypes signatureType, out string normalizedUrl, out string normalizedRequestParameters)
        {
            string str;
            normalizedUrl = null;
            normalizedRequestParameters = null;
            switch (signatureType)
            {
                case TwitterBase.SignatureTypes.HMACSHA1:
                    {
                        string str1 = this.GenerateSignatureBase(url, consumerKey, token, tokenSecret, callBackUrl, oauthVerifier, httpMethod, timeStamp, nonce, "HMAC-SHA1", out normalizedUrl, out normalizedRequestParameters);
                        HMACSHA1 hMACSHA1 = new HMACSHA1()
                        {
                            Key = Encoding.ASCII.GetBytes(string.Format("{0}&{1}", TwitterBase.UrlEncode(consumerSecret), (string.IsNullOrEmpty(tokenSecret) ? string.Empty : TwitterBase.UrlEncode(tokenSecret))))
                        };
                        str = this.GenerateSignatureUsingHash(str1, hMACSHA1);
                        break;
                    }
                case TwitterBase.SignatureTypes.PLAINTEXT:
                    {
                        str = HttpUtility.UrlEncode(string.Format("{0}&{1}", consumerSecret, tokenSecret));
                        break;
                    }
                case TwitterBase.SignatureTypes.RSASHA1:
                    {
                        throw new NotImplementedException();
                    }
                default:
                    {
                        throw new ArgumentException("Unknown signature type", "signatureType");
                    }
            }
            return str;
        }

        public string GenerateSignatureBase(Uri url, string consumerKey, string token, string tokenSecret, string callBackUrl, string oauthVerifier, string httpMethod, string timeStamp, string nonce, string signatureType, out string normalizedUrl, out string normalizedRequestParameters)
        {
            bool flag;
            if (token == null)
            {
                token = string.Empty;
            }
            if (tokenSecret == null)
            {
                tokenSecret = string.Empty;
            }
            if (string.IsNullOrEmpty(consumerKey))
            {
                throw new ArgumentNullException("consumerKey");
            }
            if (string.IsNullOrEmpty(httpMethod))
            {
                throw new ArgumentNullException("httpMethod");
            }
            if (string.IsNullOrEmpty(signatureType))
            {
                throw new ArgumentNullException("signatureType");
            }
            normalizedUrl = null;
            normalizedRequestParameters = null;
            List<TwitterBase.QueryParameter> queryParameters = this.GetQueryParameters(url.Query);
            queryParameters.Add(new TwitterBase.QueryParameter("oauth_version", "1.0"));
            queryParameters.Add(new TwitterBase.QueryParameter("oauth_nonce", nonce));
            queryParameters.Add(new TwitterBase.QueryParameter("oauth_timestamp", timeStamp));
            queryParameters.Add(new TwitterBase.QueryParameter("oauth_signature_method", signatureType));
            queryParameters.Add(new TwitterBase.QueryParameter("oauth_consumer_key", consumerKey));
            if (!string.IsNullOrEmpty(callBackUrl))
            {
                queryParameters.Add(new TwitterBase.QueryParameter("oauth_callback", TwitterBase.UrlEncode(callBackUrl)));
            }
            if (!string.IsNullOrEmpty(oauthVerifier))
            {
                queryParameters.Add(new TwitterBase.QueryParameter("oauth_verifier", oauthVerifier));
            }
            if (!string.IsNullOrEmpty(token))
            {
                queryParameters.Add(new TwitterBase.QueryParameter("oauth_token", token));
            }
            queryParameters.Sort(new TwitterBase.QueryParameterComparer());
            normalizedUrl = string.Format("{0}://{1}", url.Scheme, url.Host);
            if (!(url.Scheme == "http") || url.Port != 80)
            {
                flag = (url.Scheme != "https" ? false : url.Port == 443);
            }
            else
            {
                flag = true;
            }
            if (!flag)
            {
                normalizedUrl = string.Concat(normalizedUrl, ":", url.Port);
            }
            normalizedUrl = string.Concat(normalizedUrl, url.AbsolutePath);
            normalizedRequestParameters = this.NormalizeRequestParameters(queryParameters);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}&", httpMethod.ToUpper());
            stringBuilder.AppendFormat("{0}&", TwitterBase.UrlEncode(normalizedUrl));
            stringBuilder.AppendFormat("{0}", TwitterBase.UrlEncode(normalizedRequestParameters));
            return stringBuilder.ToString();
        }

        public string GenerateSignatureUsingHash(string signatureBase, HashAlgorithm hash)
        {
            return this.ComputeHash(hash, signatureBase);
        }

        public virtual string GenerateTimeStamp()
        {
            TimeSpan utcNow = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(utcNow.TotalSeconds).ToString();
        }

        private List<TwitterBase.QueryParameter> GetQueryParameters(string parameters)
        {
            if (parameters.StartsWith("?"))
            {
                parameters = parameters.Remove(0, 1);
            }
            List<TwitterBase.QueryParameter> queryParameters = new List<TwitterBase.QueryParameter>();
            if (!string.IsNullOrEmpty(parameters))
            {
                char[] chrArray = new char[] { '&' };
                string[] strArrays = parameters.Split(chrArray);
                for (int i = 0; i < (int)strArrays.Length; i++)
                {
                    string str = strArrays[i];
                    if ((string.IsNullOrEmpty(str) ? false : !str.StartsWith("oauth_")))
                    {
                        if (str.IndexOf('=') <= -1)
                        {
                            queryParameters.Add(new TwitterBase.QueryParameter(str, string.Empty));
                        }
                        else
                        {
                            chrArray = new char[] { '=' };
                            string[] strArrays1 = str.Split(chrArray);
                            queryParameters.Add(new TwitterBase.QueryParameter(strArrays1[0], strArrays1[1]));
                        }
                    }
                }
            }
            return queryParameters;
        }

        protected string NormalizeRequestParameters(IList<TwitterBase.QueryParameter> parameters)
        {
            StringBuilder stringBuilder = new StringBuilder();
            TwitterBase.QueryParameter item = null;
            for (int i = 0; i < parameters.Count; i++)
            {
                item = parameters[i];
                stringBuilder.AppendFormat("{0}={1}", item.Name, item.Value);
                if (i < parameters.Count - 1)
                {
                    stringBuilder.Append("&");
                }
            }
            return stringBuilder.ToString();
        }

        public static string UrlEncode(string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string str = value;
            for (int i = 0; i < str.Length; i++)
            {
                char chr = str[i];
                if (TwitterBase.unreservedChars.IndexOf(chr) == -1)
                {
                    stringBuilder.Append(string.Concat('%', string.Format("{0:X2}", (int)chr)));
                }
                else
                {
                    stringBuilder.Append(chr);
                }
            }
            return stringBuilder.ToString();
        }

        protected class QueryParameter
        {
            private string name;

            private string @value;

            public string Name
            {
                get
                {
                    return this.name;
                }
            }

            public string Value
            {
                get
                {
                    return this.@value;
                }
            }

            public QueryParameter(string name, string value)
            {
                this.name = name;
                this.@value = value;
            }
        }

        protected class QueryParameterComparer : IComparer<TwitterBase.QueryParameter>
        {
            public QueryParameterComparer()
            {
            }

            public int Compare(TwitterBase.QueryParameter x, TwitterBase.QueryParameter y)
            {
                int num;
                num = (!(x.Name == y.Name) ? string.Compare(x.Name, y.Name) : string.Compare(x.Value, y.Value));
                return num;
            }
        }

        public enum SignatureTypes
        {
            HMACSHA1,
            PLAINTEXT,
            RSASHA1
        }
    }
}