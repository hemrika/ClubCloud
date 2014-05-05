using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace ClubCloud.Social.LinkedIn
{
    internal class LinkedInActions
    {
        public Dictionary<string, object> InputVars;

        public string Url = LinkedInUtils.Convert("");

        public string Method = LinkedInUtils.Convert("tU??");

        public string FormName = LinkedInUtils.Convert("cu???");

        public LinkedInActions()
        {
            this.InputVars = new Dictionary<string, object>();
        }

        public void Add(string u003f7u003f, object u003f5u003f)
        {
            this.InputVars.Add(u003f7u003f, u003f5u003f);
        }

        public void Post()
        {
            HttpContext.Current.Response.Clear();
            //HttpContext.Current.Response.ContentEncoding = Encoding.GetEncoding(_13._14("CS????????"));
            //HttpContext.Current.Response.HeaderEncoding = Encoding.GetEncoding(_13._14("CS????????"));
            //HttpContext.Current.Response.Charset = _13._14("CS????????");
            //HttpContext.Current.Response.Write(_13._14("0t??????????"));
            //HttpContext.Current.Response.Write(string.Format(_13._14("\u0010A???????????????????????????????????+??????"), this.FormName));
            //HttpContext.Current.Response.Write(string.Format(_13._14("\u0010o??????????????????????????????8?=?????????"), this.FormName, this.Method, this.Url));
            Dictionary<string, object>.KeyCollection.Enumerator enumerator = this.InputVars.Keys.GetEnumerator();
            try
            {
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    string current = enumerator.Current;
                    //HttpContext.Current.Response.Write(string.Format(_13._14("\u0010l??????????????????????????????????????????"), current, this.InputVars[current].ToString().Replace(_13._14("&"), _13._14("a"))));
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            //HttpContext.Current.Response.Write(_13._14(";i?????"));
            //HttpContext.Current.Response.Write(_13._14("2G????????????"));
            HttpContext.Current.Response.End();
        }

        public string WebRemoteGet()
        {
            string str;
            string empty = string.Empty;
            Dictionary<string, object>.KeyCollection.Enumerator enumerator = this.InputVars.Keys.GetEnumerator();
            try
            {
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    string current = enumerator.Current;
                    empty = string.Concat(empty, string.Format(LinkedInUtils.Convert("sk??????"), current, this.InputVars[current]));
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            empty = empty.Substring(0, empty.Length - 1);
            LinkedInActions _u003f3u003f = this;
            _u003f3u003f.Url = string.Concat(_u003f3u003f.Url, LinkedInUtils.Convert(">"), empty);
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.Url);
            //httpWebRequest.Method = _13._14("DN?");
            //httpWebRequest.UserAgent = _13._14("'C?"??????????????????????????????=???????????????????????????????????????????????????????????????????????");
            WebResponse response = httpWebRequest.GetResponse();
            string statusDescription = ((HttpWebResponse)response).StatusDescription;
            Stream responseStream = response.GetResponseStream();
            try
            {
                StreamReader streamReader = new StreamReader(responseStream);
                try
                {
                    string end = streamReader.ReadToEnd();
                    streamReader.Close();
                    responseStream.Close();
                    response.Close();
                    str = end;
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
            return str;
        }

        public string WebRemotePost()
        {
            string str;
            string empty = string.Empty;
            Dictionary<string, object>.KeyCollection.Enumerator enumerator = this.InputVars.Keys.GetEnumerator();
            try
            {
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    string current = enumerator.Current;
                    empty = string.Concat(empty, string.Format(LinkedInUtils.Convert("sk??????"), current, this.InputVars[current]));
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            empty = empty.Substring(0, empty.Length - 1);
            byte[] bytes = Encoding.UTF8.GetBytes(empty);
            HttpWebRequest length = (HttpWebRequest)WebRequest.Create(this.Url);
            //length.Method = _13._14("TO??");
            length.AllowAutoRedirect = true;
            //length.UserAgent = _13._14("'C?"??????????????????????????????=???????????????????????????????????????????????????????????????????????");
            //length.ContentType = _13._14("@O???????????????????????????????");
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
            WebResponse response = length.GetResponse();
            string statusDescription = ((HttpWebResponse)response).StatusDescription;
            Stream responseStream = response.GetResponseStream();
            try
            {
                StreamReader streamReader = new StreamReader(responseStream);
                try
                {
                    string end = streamReader.ReadToEnd();
                    streamReader.Close();
                    responseStream.Close();
                    response.Close();
                    str = end;
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
            return str;
        }
    }
}