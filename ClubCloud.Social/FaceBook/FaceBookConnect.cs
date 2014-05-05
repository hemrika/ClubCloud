using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace ClubCloud.Social.FaceBook
{
    public class FaceBookConnect
    {
        public static string AccessToken
        {
            get
            {
                if (HttpContext.Current.Session[FaceBookUtils.Convert("Ju?????????")] == null)
                {
                    return string.Empty;
                }
                return HttpContext.Current.Session[FaceBookUtils.Convert("Ju?????????")].ToString();
            }
            set
            {
                HttpContext.Current.Session[FaceBookUtils.Convert("Ju?????????")] = value;
            }
        }

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

        public static string Code
        {
            get
            {
                if (HttpContext.Current.Session[FaceBookUtils.Convert("GU??")] == null)
                {
                    return string.Empty;
                }
                return HttpContext.Current.Session[FaceBookUtils.Convert("GU??")].ToString();
            }
            set
            {
                HttpContext.Current.Session[FaceBookUtils.Convert("GU??")] = value;
            }
        }

        private static string Redirect_Url
        {
            get;
            set;
        }

        public FaceBookConnect()
        {
        }

        private static string _1(string u003f12u003f)
        {
            string end;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(u003f12u003f);
            StreamReader streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
            try
            {
                end = streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                {
                    ((IDisposable)streamReader).Dispose();
                }
            }
            return end;
        }

        private static void _2(string u003f12u003f, Dictionary<string, string> u003f9u003f)
        {
            Encoding uTF8Encoding = new UTF8Encoding(true, true);
            string empty = string.Empty;
            Dictionary<string, string>.KeyCollection.Enumerator enumerator = u003f9u003f.Keys.GetEnumerator();
            try
            {
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    string current = enumerator.Current;
                    string str = empty;
                    string[] strArrays = new string[] { str, current, FaceBookUtils.Convert("<"), u003f9u003f[current], FaceBookUtils.Convert("'") };
                    empty = string.Concat(strArrays);
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            empty = empty.Substring(0, empty.Length - 1);
            byte[] bytes = uTF8Encoding.GetBytes(empty);
            HttpWebRequest length = (HttpWebRequest)WebRequest.Create(u003f12u003f);
            //length.Method = _18._19("TO??");
            //length.ContentType = _18._19("@O???????????????????????????????");
            length.ContentLength = (long)((int)bytes.Length);
            Stream requestStream = length.GetRequestStream();
            try
            {
                requestStream.Write(bytes, 0, (int)bytes.Length);
                requestStream.Close();
            }
            finally
            {
                if (requestStream != null)
                {
                    ((IDisposable)requestStream).Dispose();
                }
            }
        }

        private static bool _3(string u003f12u003f)
        {
            bool flag;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(u003f12u003f);
            //httpWebRequest.Method = _18._19("B?????");
            try
            {
                StreamReader streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
                try
                {
                    flag = true;
                }
                finally
                {
                    if (streamReader != null)
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public static void Authorize(string u003f5u003f, string u003f6u003f)
        {
            FaceBookConnect.Redirect_Url = u003f6u003f;
            //HttpContext.Current.Response.Redirect(string.Format(_18._19(";H??????????????????????????????“??????????????????????????????????????????????????"), FaceBookConnect.API_Key, HttpContext.Current.Server.UrlEncode(u003f6u003f), u003f5u003f));
        }

        public static string Fetch(string u003f7u003f, string u003f8u003f)
        {
            if (!string.IsNullOrEmpty(u003f7u003f))
            {
                FaceBookConnect.Code = u003f7u003f;
            }
            if (string.IsNullOrEmpty(FaceBookConnect.AccessToken))
            {
                if (u003f7u003f == FaceBookConnect.Code)
                {
                    string str = FaceBookUtils.Convert("\u000fE?????????????????????????????????????????????????????????????????????????????????????????????????????");
                    object[] aPIKey = new object[] { FaceBookConnect.API_Key, HttpContext.Current.Server.UrlEncode(FaceBookConnect.Redirect_Url), FaceBookConnect.API_Secret, u003f7u003f };
                    FaceBookConnect.AccessToken = FaceBookConnect._1(string.Format(str, aPIKey));
                }
            }
            string str1 = FaceBookConnect._1(string.Format(FaceBookUtils.Convert("Jr??????????????????????????????'?"), FaceBookConnect.AccessToken, u003f8u003f));
            return str1;
        }

        public static void Logout(string u003f7u003f)
        {
            if (!string.IsNullOrEmpty(u003f7u003f))
            {
                FaceBookConnect.Code = u003f7u003f;
            }
            if (string.IsNullOrEmpty(FaceBookConnect.AccessToken))
            {
                if (u003f7u003f == FaceBookConnect.Code)
                {
                    string str = FaceBookUtils.Convert("\u000fE?????????????????????????????????????????????????????????????????????????????????????????????????????");
                    object[] aPIKey = new object[] { FaceBookConnect.API_Key, HttpContext.Current.Server.UrlEncode(FaceBookConnect.Redirect_Url), FaceBookConnect.API_Secret, u003f7u003f };
                    FaceBookConnect.AccessToken = FaceBookConnect._1(string.Format(str, aPIKey));
                }
            }
            string accessToken = FaceBookConnect.AccessToken;
            FaceBookConnect.AccessToken = null;
            FaceBookConnect.Code = null;
            HttpContext.Current.Response.Redirect(string.Format(FaceBookUtils.Convert("Xs??????????????????????????????????????????????"), HttpContext.Current.Server.UrlEncode(string.Concat(FaceBookConnect.Redirect_Url, FaceBookUtils.Convert("3t??????????"))), accessToken));
        }

        public static void Post(string u003f7u003f, string u003f8u003f, Dictionary<string, string> u003f9u003f)
        {
            if (!string.IsNullOrEmpty(u003f7u003f))
            {
                FaceBookConnect.Code = u003f7u003f;
            }
            if (string.IsNullOrEmpty(FaceBookConnect.AccessToken))
            {
                if (u003f7u003f == FaceBookConnect.Code)
                {
                    string str = FaceBookUtils.Convert("\u000fE?????????????????????????????????????????????????????????????????????????????????????????????????????");
                    object[] aPIKey = new object[] { FaceBookConnect.API_Key, HttpContext.Current.Server.UrlEncode(FaceBookConnect.Redirect_Url), FaceBookConnect.API_Secret, u003f7u003f };
                    FaceBookConnect.AccessToken = FaceBookConnect._1(string.Format(str, aPIKey));
                }
            }
            FaceBookConnect._2(string.Format(FaceBookUtils.Convert("Jr??????????????????????????????'?"), FaceBookConnect.AccessToken, u003f8u003f), u003f9u003f);
        }

        public static void PostFile(string u003f7u003f, string u003f8u003f, HttpPostedFile u003f10u003f, string u003f11u003f)
        {
            if (!string.IsNullOrEmpty(u003f7u003f))
            {
                FaceBookConnect.Code = u003f7u003f;
            }
            if (string.IsNullOrEmpty(FaceBookConnect.AccessToken))
            {
                if (u003f7u003f == FaceBookConnect.Code)
                {
                    string str = FaceBookUtils.Convert("\u000fE?????????????????????????????????????????????????????????????????????????????????????????????????????");
                    object[] aPIKey = new object[] { FaceBookConnect.API_Key, HttpContext.Current.Server.UrlEncode(FaceBookConnect.Redirect_Url), FaceBookConnect.API_Secret, u003f7u003f };
                    FaceBookConnect.AccessToken = FaceBookConnect._1(string.Format(str, aPIKey));
                }
            }
            byte[] numArray = null;
            BinaryReader binaryReader = new BinaryReader(u003f10u003f.InputStream);
            try
            {
                numArray = binaryReader.ReadBytes(u003f10u003f.ContentLength);
            }
            finally
            {
                if (binaryReader != null)
                {
                    ((IDisposable)binaryReader).Dispose();
                }
            }
            NameValueCollection nameValueCollection = new NameValueCollection()
            {
                { FaceBookUtils.Convert("jt?????"), u003f11u003f }
            };
            FaceBookConnect.WebPostFile(string.Format(FaceBookUtils.Convert("Jr??????????????????????????????'?"), FaceBookConnect.AccessToken, u003f8u003f), numArray, nameValueCollection);
        }

        public static void WebPostFile(string u003f12u003f, byte[] u003f13u003f, NameValueCollection u003f14u003f)
        {
            string str = FaceBookUtils.Convert("1K??????????????????????????");
            long ticks = DateTime.Now.Ticks;
            string str1 = string.Concat(str, ticks.ToString(FaceBookUtils.Convert("y")));
            HttpWebRequest defaultCredentials = (HttpWebRequest)WebRequest.Create(u003f12u003f);
            defaultCredentials.ContentType = string.Concat(FaceBookUtils.Convert("sU????????????????????????????"), str1);
            defaultCredentials.Method = FaceBookUtils.Convert("TO??");
            defaultCredentials.KeepAlive = true;
            defaultCredentials.Credentials = CredentialCache.DefaultCredentials;
            Stream memoryStream = new MemoryStream();
            try
            {
                byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(FaceBookUtils.Convert("\tc??"), str1, FaceBookUtils.Convert("\u000fc")));
                string str2 = string.Concat(FaceBookUtils.Convert("\tc??"), str1, FaceBookUtils.Convert("9L??????????????????????????????\u202fM???+??????????????"));
                IEnumerator enumerator = u003f14u003f.Keys.GetEnumerator();
                try
                {
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        string current = (string)enumerator.Current;
                        string str3 = string.Format(str2, current, u003f14u003f[current]);
                        byte[] numArray = Encoding.UTF8.GetBytes(str3);
                        memoryStream.Write(numArray, 0, (int)numArray.Length);
                    }
                }
                finally
                {
                    IDisposable disposable = enumerator as IDisposable;
                    if (disposable != null)
                    {
                        disposable.Dispose();
                    }
                }
                memoryStream.Write(bytes, 0, (int)bytes.Length);
                string str4 = FaceBookUtils.Convert("$c??????????????????????????????\u2029??)?¦?????????????????????????????????????????????????????????????????");
                string str5 = string.Format(str4, FaceBookUtils.Convert("uU????"), FaceBookUtils.Convert("uU????"));
                byte[] bytes1 = Encoding.UTF8.GetBytes(str5);
                memoryStream.Write(bytes1, 0, (int)bytes1.Length);
                memoryStream.Write(u003f13u003f, 0, (int)u003f13u003f.Length);
                memoryStream.Write(bytes, 0, (int)bytes.Length);
                defaultCredentials.ContentLength = memoryStream.Length;
                Stream requestStream = defaultCredentials.GetRequestStream();
                try
                {
                    memoryStream.Position = (long)0;
                    byte[] numArray1 = new byte[checked(memoryStream.Length)];
                    memoryStream.Read(numArray1, 0, (int)numArray1.Length);
                    memoryStream.Close();
                    requestStream.Write(numArray1, 0, (int)numArray1.Length);
                    requestStream.Close();
                }
                finally
                {
                    if (requestStream != null)
                    {
                        ((IDisposable)requestStream).Dispose();
                    }
                }
                WebResponse response = defaultCredentials.GetResponse();
                try
                {
                    Stream responseStream = response.GetResponseStream();
                    try
                    {
                        StreamReader streamReader = new StreamReader(responseStream);
                        try
                        {
                            response.Close();
                        }
                        finally
                        {
                            if (streamReader != null)
                            {
                                ((IDisposable)streamReader).Dispose();
                            }
                        }
                    }
                    finally
                    {
                        if (responseStream != null)
                        {
                            ((IDisposable)responseStream).Dispose();
                        }
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        ((IDisposable)response).Dispose();
                    }
                }
            }
            finally
            {
                if (memoryStream != null)
                {
                    ((IDisposable)memoryStream).Dispose();
                }
            }
        }
    }
}