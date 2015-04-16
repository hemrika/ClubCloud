using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Media
{
    public class KNLTBFoto : IDisposable
    {
        private static string FotoGetUrl = "https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/OphalenPasfoto/ImageRenderer.aspx?Id={0}";
        //private static string FotoSetUrl = "https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/UploadPasfoto/PasfotoUpload.aspx?orgname=KNLTB";
        private System.Drawing.Image _Foto;
        private String _ContentType;
        private long _ContentLength;
        private CookieContainer _Container;

        IAsyncResult result;

        public KNLTBFoto() { }
        
        public CookieContainer Container
        {
            get
            {
                while (result == null || !result.IsCompleted ) { };
                return _Container;
            }
            set { _Container = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Drawing.Image Foto
        {
            get
            {
                while (result == null || !result.IsCompleted ) { };
                return _Foto;
            }
            set { _Foto = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public String ContentType
        {
            get
            {
                while (result == null || !result.IsCompleted) { };
                return _ContentType;
            }
            set { _ContentType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public long ContentLength
        {
            get { return _ContentLength; }
            set { _ContentLength = value; }
        }

        //public void RequestFoto(string bondsnummer, CookieContainer cookiecontainer)
        //{
        //    string formatted = string.Format(FotoUrl, bondsnummer);
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(formatted);
        //    request.CookieContainer = cookiecontainer;
        //    request.AllowWriteStreamBuffering = true;
        //    request.Method = "GET";
        //    request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, */*";
        //    request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
        //    request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko";
        //    request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
        //    request.Host = "servit.mijnknltb.nl";
        //    request.KeepAlive = true;
        //    request.BeginGetResponse(ResponseCallback, request);
        //}
        
        //private void ResponseCallback(IAsyncResult ar)
        //{
        //    HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
        //    WebResponse response = request.EndGetResponse(ar);
        //    _ContentType = response.ContentType;
        //    _ContentLength = response.ContentLength;
        //    Stream responseStream = response.GetResponseStream();
        //    if (_ContentLength > 0 && _ContentType == "image/jpeg")
        //    {
        //        _Foto = System.Drawing.Image.FromStream(responseStream);
        //    }
        //    result = ar;
        //}

         

        public async Task<Tuple<System.Drawing.Image,string,long>> RequestFotoAsync(string bondsnummer, CookieContainer cookiecontainer)
        {
            string formatted = string.Format(FotoGetUrl, bondsnummer);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(formatted);
            request.CookieContainer = cookiecontainer;
            request.AllowWriteStreamBuffering = true;
            request.Method = "GET";
            request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, */*";
            request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko";
            request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
            request.Host = "servit.mijnknltb.nl";
            request.KeepAlive = true;

            using (WebResponse response = await request.GetResponseAsync())
            {
                _ContentType = response.ContentType;
                _ContentLength = response.ContentLength;
                Stream responseStream = response.GetResponseStream();
                if (_ContentLength > 0 && _ContentType == "image/jpeg")
                {
                    _Foto = System.Drawing.Image.FromStream(responseStream);
                }
                return new Tuple<System.Drawing.Image, string, long>(_Foto, _ContentType, _ContentLength);
            }
            
        }

        public void Dispose()
        {
            result = null;
            _ContentType = null;
            _ContentLength = 0;
            _Foto = null;
        }
    }
}
