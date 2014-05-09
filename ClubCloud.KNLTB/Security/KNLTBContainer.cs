using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Security
{
    public class KNLTBContainer
    {
        private static string logonUrl = "https://www.mijnknltb.nl/CookieAuth.dll?Logon";
        private CookieContainer _Container;
        IAsyncResult result;

        public KNLTBContainer() { }
        public CookieContainer Container
        {
            get
            {
                while (result == null || !result.IsCompleted ) { };
                return _Container;
            }
            set { _Container = value; }
        }

        private String _Username;
        private String _Password;

        public void RequestAcces(string username, string password)
        {
                _Username = username;
                _Password = password;
                Container = new CookieContainer();

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(logonUrl);
                request.CookieContainer = _Container;
                bool support = request.SupportsCookieContainer;
                request.Method = "POST";
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko";
                request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                request.Host = "www.mijnknltb.nl";
                request.KeepAlive = true;
                request.BeginGetRequestStream(RequestCallback, request);
        }

        private void RequestCallback(IAsyncResult ar)
        {

            var postData = string.Format("curl=Z2F&flags=0&forcedownlevel=0&formdir=12&trusted=0&username={0}&password={1}&SubmitCreds=%C2%A0", System.Uri.EscapeDataString(_Username), System.Uri.EscapeDataString(_Password));
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
            result = ar;
        }
    }
}
