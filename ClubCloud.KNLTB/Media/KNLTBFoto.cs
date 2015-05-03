using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClubCloud.KNLTB.Media
{
    public class KNLTBFoto : IDisposable
    {
        private static string FotoGetUrl = "https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/OphalenPasfoto/ImageRenderer.aspx?Id={0}";
        private static string FotoSetUrl = "https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/UploadPasfoto/PasfotoUpload.aspx?orgname=KNLTB&userlcid=1043&orglcid=1043";

        private System.Drawing.Image _Foto;
        private String _ContentType;
        private long _ContentLength;
        private byte[] _ContentData;
        private string _Viewstate;
        private string _Eventvalidation;
        private string _Boundry;
        private string _Bondsnummer;

        public string Bondsnummer
        {
            get { return _Bondsnummer; }
            set { _Bondsnummer = value; }
        }

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

        public byte[] ContentData
        {
            get { return _ContentData; }
            set { _ContentData = value; }
        }

        public string Viewstate
        {
            get { return _Viewstate; }
            set { _Viewstate = value; }
        }

        public string Eventvalidation
        {
            get { return _Eventvalidation; }
            set { _Eventvalidation = value; }
        }

        public string Boundry
        {
            get { return _Boundry; }
            set { _Boundry = value; }
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
            Uri requestUri = new Uri(formatted);

            ServicePointManager.Expect100Continue = false;

            if (requestUri.Scheme == "https")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, err) => true;
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);

            request.CookieContainer = cookiecontainer;
            request.AllowWriteStreamBuffering = true;
            request.Method = "GET";
            request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, */*";
            request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; WOW64; Trident/7.0)";
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

        /*
        public async Task UploadFotoAsync(string bondsnummer, byte[] ContentData, string ContentType,double ContentLength, CookieContainer cookiecontainer)
        {
            Uri requestUri = new Uri(FotoSetUrl);

            ServicePointManager.Expect100Continue = false;

            if (requestUri.Scheme == "https")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, err) => true;
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.CookieContainer = cookiecontainer;

            request.Method = "POST";

            string boundary = "----------" + DateTime.Now.Ticks.ToString("x", CultureInfo.InvariantCulture);

            request.ContentType = "multipart/form-data; boundary=" + boundary;

        }
        */

        public void Dispose()
        {
            result = null;
            _ContentType = null;
            _ContentLength = 0;
            _Foto = null;
        }

        public void ServitUploadFoto(string bondsnummer, byte[] contentData, string contentType, long contentLength, CookieContainer cookiecontainer)
        {
            try
            {
                Bondsnummer = bondsnummer;
                ContentData = contentData;
                Container = cookiecontainer;
                ContentType = contentType;
                ContentLength = contentLength;

                ServicePointManager.Expect100Continue = false;

                Uri requestUri = new Uri(FotoSetUrl + string.Format("&BondsnummerTextBox_TextBox={0}&ShowOldFotoButton=Button", System.Uri.EscapeDataString(Bondsnummer)));

                if (requestUri.Scheme == "https")
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                    ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, err) => true;
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);

                //request.Accept = "text/html, application/xhtml+xml, */*";
                request.Accept = "application/x-www-form-urlencoded";
                //request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, */*";
                request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; WOW64; Trident/7.0)";
                request.Headers.Add("DNT", "1");
                request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");                
                request.Host = "servit.mijnknltb.nl";
                request.CookieContainer = _Container;
                request.KeepAlive = true;
                request.Headers.Add(HttpRequestHeader.CacheControl, "no-cache");
                //POST
                request.Method = "POST";
                request.BeginGetRequestStream(PasfotoUploadCallback, request);
                //GET
                //request.Method = "GET";
                //request.BeginGetResponse(PasfotoUploadCallback, request);

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }

        private void PasfotoUploadCallback(IAsyncResult ar)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                Stream stream = request.EndGetRequestStream(ar);

                /*
                var postData = string.Format("BondsnummerTextBox_TextBox={0}&ShowOldFotoButton=Button", System.Uri.EscapeDataString(Bondsnummer));

                using (var sw = new StreamWriter(stream))
                {
                    sw.Write(postData);
                }
                */

                request.BeginGetResponse(ShowOldFotoCallback, request);

                /*
                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                WebResponse response = request.EndGetResponse(ar);
                Stream stream = response.GetResponseStream();

                string xml = string.Empty;
                using (GZipStream gzip = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress))

                using (XmlSanitizingStream sr = new XmlSanitizingStream(gzip))
                {
                    xml = sr.ReadToEnd();

                    int start = xml.IndexOf("__VIEWSTATE\" value=\"", 0) + 20;
                    int end = xml.IndexOf("\" />", start);
                    Viewstate = xml.Substring(start, (end - start));

                    start = xml.IndexOf("__EVENTVALIDATION\" value=\"", 0) + 26;
                    end = xml.IndexOf("\" />", start);
                    Eventvalidation = xml.Substring(start, (end - start));

                }

                ServicePointManager.Expect100Continue = false;

                Uri requestUri = new Uri(FotoSetUrl);// + "?BondsnummerTextBox_TextBox=" + Bondsnummer + "&ShowOldFotoButton=Button");  

                if (requestUri.Scheme == "https")
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                    ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, err) => true;
                }

                request = (HttpWebRequest)WebRequest.Create(requestUri);
                Boundry = "-----------------------------" + DateTime.Now.Ticks.ToString("x", CultureInfo.InvariantCulture);
                
                request.Method = "POST";
                */
                //request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, */*";
                /*
                request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; WOW64; Trident/7.0)";
                request.ContentType = "multipart/form-data; boundary=" + Boundry;
                request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                request.Host = "servit.mijnknltb.nl";
                request.Headers.Add("DNT", "1");
                request.KeepAlive = true;
                request.Headers.Add(HttpRequestHeader.CacheControl, "no-cache");
                request.CookieContainer = _Container;                

                StringBuilder sbHeader = new StringBuilder();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTTARGET\"")
                        .AppendLine()
                        .AppendLine();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTARGUMENT\"")
                        .AppendLine()
                        .AppendLine();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__VIEWSTATE\"")
                        .AppendLine()
                        .AppendLine(Viewstate);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTVALIDATION\"")
                        .AppendLine()
                        .AppendLine(Eventvalidation);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl1$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Bondsnummer:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"BondsnummerTextBox$TextBox\"")
                        .AppendLine()
                        .AppendLine(Bondsnummer);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"ShowOldFotoButton\"")
                        .AppendLine()
                        .AppendLine("Button");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl2$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Naam:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl4$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Adres:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl5$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Woonplaats:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl3$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Fotobestand:");

                //WriteState bytes
                StringBuilder sbFooter = new StringBuilder();
                sbFooter.AppendLine();

                sbFooter.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControlHelpText$HiddenField\"")
                        .AppendLine()
                        .AppendLine("De getoonde foto zal overeenkomen met de foto op de pas.");
                sbFooter.AppendLine(Boundry + "--");

                byte[] header = Encoding.UTF8.GetBytes(sbHeader.ToString());
                byte[] footer = Encoding.UTF8.GetBytes(sbFooter.ToString());
                long contentLength = header.Length + footer.Length;

                request.ContentLength = contentLength;

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(header, 0, header.Length);
                    requestStream.Write(footer, 0, footer.Length);
                }

                request.BeginGetRequestStream(ShowOldFotoCallback, request);
                */
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }

        private void ShowOldFotoCallback(IAsyncResult ar)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();

                /*
                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                WebResponse response = request.EndGetResponse(ar);                
                Stream stream = response.GetResponseStream();
                */

                string xml = string.Empty;
                using (GZipStream gzip = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress))

                using (XmlSanitizingStream sr = new XmlSanitizingStream(gzip))
                {
                    xml = sr.ReadToEnd();

                    int start = xml.IndexOf("__VIEWSTATE\" value=\"", 0)+20;
                    int end = xml.IndexOf("\" />", start);
                    Viewstate = xml.Substring(start, (end - start));

                    start = xml.IndexOf("__EVENTVALIDATION\" value=\"", 0)+26;
                    end = xml.IndexOf("\" />", start);
                    Eventvalidation = xml.Substring(start, (end - start));

                }

                ServicePointManager.Expect100Continue = false;

                Uri requestUri = new Uri(FotoSetUrl);

                if (requestUri.Scheme == "https")
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                    ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, err) => true;
                }

                request = (HttpWebRequest)WebRequest.Create(requestUri);

                request.CookieContainer = _Container;
                request.Method = "POST";
                request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, */*";
                request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; WOW64; Trident/7.0)";
                request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                request.Headers.Add("DNT", "1");
                request.Host = "servit.mijnknltb.nl";
                request.KeepAlive = true;
                request.Headers.Add(HttpRequestHeader.CacheControl, "no-cache");
                request.ContentType = "multipart/form-data; boundary=" + Boundry;

                StringBuilder sbHeader = new StringBuilder();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTTARGET\"")
                        .AppendLine()
                        .AppendLine();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTARGUMENT\"")
                        .AppendLine()
                        .AppendLine();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__VIEWSTATE\"")
                        .AppendLine()
                        .AppendLine(Viewstate);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTVALIDATION\"")
                        .AppendLine()
                        .AppendLine(Eventvalidation);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl1$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Bondsnummer:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"BondsnummerTextBox$TextBox\"")
                        .AppendLine()
                        .AppendLine(Bondsnummer);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl2$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Naam:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl4$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Adres:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl5$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Woonplaats:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl3$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Fotobestand:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine(string.Format("Content-Disposition: form-data; name=\"FileUploadControl\" filename=\"{0}.png\"", Bondsnummer))
                        .AppendLine("Content-Type: image/x-png")
                        .AppendLine();

                //WriteState bytes
                StringBuilder sbFooter = new StringBuilder();
                sbFooter.AppendLine();

                sbFooter.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"ShowNewFotoButton\"")
                        .AppendLine()
                        .AppendLine("Button");
                sbFooter.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControlHelpText$HiddenField\"")
                        .AppendLine()
                        .AppendLine("De getoonde foto zal overeenkomen met de foto op de pas.");
                sbFooter.AppendLine(Boundry + "--");

                byte[] header = Encoding.UTF8.GetBytes(sbHeader.ToString());
                byte[] footer = Encoding.UTF8.GetBytes(sbFooter.ToString());
                long contentLength = header.Length + ContentData.Length + footer.Length;

                request.ContentLength = contentLength;

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(header, 0, header.Length);
                    requestStream.Write(ContentData, 0, ContentData.Length);
                    requestStream.Write(footer, 0, footer.Length);
                }

                request.BeginGetRequestStream(ShowNewFotoCallback, request);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }


        private void ShowNewFotoCallback(IAsyncResult ar)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                //Stream stream = request.GetResponse();
               
                //Stream stream = request.EndGetRequestStream(ar);

                string xml = string.Empty;
                using (GZipStream gzip = new GZipStream(stream, CompressionMode.Decompress))

                using (XmlSanitizingStream sr = new XmlSanitizingStream(gzip))
                {
                    xml = sr.ReadToEnd();

                    int start = xml.IndexOf("__VIEWSTATE\" value=\"", 0) + 20;
                    int end = xml.IndexOf("\" />", start);
                    Viewstate = xml.Substring(start, (end - start));

                    start = xml.IndexOf("__EVENTVALIDATION\" value=\"", 0) + 26;
                    end = xml.IndexOf("\" />", start);
                    Eventvalidation = xml.Substring(start, (end - start));

                }

                ServicePointManager.Expect100Continue = false;

                Uri requestUri = new Uri(FotoSetUrl);

                if (requestUri.Scheme == "https")
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                    ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, err) => true;
                }

                request = (HttpWebRequest)WebRequest.Create(requestUri);

                request.CookieContainer = _Container;
                request.Method = "POST";
                request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, */*";
                request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nl-NL,nl;q=0.8,en-US;q=0.6,en-GB;q=0.4,en;q=0.2");
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; WOW64; Trident/7.0)";
                request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                request.Headers.Add("DNT", "1");
                request.Host = "servit.mijnknltb.nl";
                request.KeepAlive = true;
                request.Headers.Add(HttpRequestHeader.CacheControl, "no-cache");
                request.ContentType = "multipart/form-data; boundary=" + Boundry;

                StringBuilder sbHeader = new StringBuilder();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTTARGET\"")
                        .AppendLine()
                        .AppendLine("UploadButton");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTARGUMENT\"")
                        .AppendLine()
                        .AppendLine();
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__VIEWSTATE\"")
                        .AppendLine()
                        .AppendLine(Viewstate);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"__EVENTVALIDATION\"")
                        .AppendLine()
                        .AppendLine(Eventvalidation);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl1$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Bondsnummer:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"BondsnummerTextBox$TextBox\"")
                        .AppendLine()
                        .AppendLine(Bondsnummer);
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl2$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Naam:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl4$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Adres:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl5$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Woonplaats:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControl3$HiddenField\"")
                        .AppendLine()
                        .AppendLine("Fotobestand:");
                sbHeader.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"FileUploadControl\"; filename=\"\"")
                        .AppendLine("Content-Type: application/octet-stream")
                        .AppendLine();

                StringBuilder sbFooter = new StringBuilder();
                sbFooter.AppendLine();

                sbFooter.AppendLine(Boundry)
                        .AppendLine("Content-Disposition: form-data; name=\"LabelCrmControlHelpText$HiddenField\"")
                        .AppendLine()
                        .AppendLine("De getoonde foto zal overeenkomen met de foto op de pas.");
                sbFooter.AppendLine(Boundry + "--");


                byte[] header = Encoding.UTF8.GetBytes(sbHeader.ToString());
                byte[] footer = Encoding.UTF8.GetBytes(sbFooter.ToString());
                long contentLength = header.Length + footer.Length;

                request.ContentLength = contentLength;

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(header, 0, header.Length);
                    requestStream.Write(footer, 0, footer.Length);
                }

                request.BeginGetRequestStream(UploadCallback, request);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }

        private void UploadCallback(IAsyncResult ar)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();

                string xml = string.Empty;
                using (GZipStream gzip = new GZipStream(stream, CompressionMode.Decompress))

                using (XmlSanitizingStream sr = new XmlSanitizingStream(gzip))
                {
                    xml = sr.ReadToEnd();
                }

                result = ar;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }

    }

    #region demo

    public static class Upload
    {
        private const string FileFieldNameDefault = "fileContent";

        public static WebResponse PostFile
            (Uri requestUri, NameValueCollection postData, Stream fileData, string fileName,
             string fileContentType, string fileFieldName, CookieContainer cookies,
             NameValueCollection headers)
        {
            ServicePointManager.Expect100Continue = false;

            if (requestUri.Scheme == "https")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, err) => true;
            }

            var webRequest = (HttpWebRequest)WebRequest.Create(requestUri);

            webRequest.Method = "POST";

            string boundary = "----------" + DateTime.Now.Ticks.ToString("x", CultureInfo.InvariantCulture);

            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;

            string ctype;
            /*
            if (string.IsNullOrEmpty(fileContentType))
                fileContentType = TryGetContentType(fileName, out ctype)
                                    ? ctype
                                    : "application/octet-stream";
            */
            fileFieldName = string.IsNullOrEmpty(fileFieldName) ? FileFieldNameDefault : fileFieldName;

            if (headers != null)
                foreach (string key in headers.AllKeys)
                {
                    var values = headers.GetValues(key);
                    if (values != null)
                        foreach (var value in values)
                            webRequest.Headers.Add(key, value);
                }

            if (cookies != null)
                webRequest.CookieContainer = cookies;

            var sbHeader = new StringBuilder();

            if (fileData != null)
            {
                var fileNameValue = string.Empty;

                if (string.IsNullOrEmpty(fileName) == false)
                    fileNameValue = string.Format(CultureInfo.InvariantCulture, "filename=\"{0}\"", Path.GetFileName(fileName));

                sbHeader
                    .AppendFormat("--{0}", boundary)
                    .AppendLine()
                    .AppendFormat("Content-Disposition: form-data; name=\"{0}\"; {1}", fileFieldName, fileNameValue)
                    .AppendLine()
                    .AppendFormat("Content-Type: {0}", fileContentType)
                    .AppendLine()
                    .AppendLine();
            }

            var sbFooter = new StringBuilder();
            sbFooter.AppendLine();

            if (postData != null)
                foreach (var key in postData.AllKeys)
                {
                    var values = postData.GetValues(key);
                    if (values != null)
                        foreach (var value in values)
                            sbFooter
                                .AppendFormat("--{0}", boundary)
                                .AppendLine()
                                .AppendFormat("Content-Disposition: form-data; name=\"{0}\"", key)
                                .AppendLine()
                                .AppendLine()
                                .Append(value)
                                .AppendLine();
                }

            sbFooter.AppendFormat("--{0}--\r\n", boundary);

            byte[] header = Encoding.UTF8.GetBytes(sbHeader.ToString());
            byte[] footer = Encoding.UTF8.GetBytes(sbFooter.ToString());
            long contentLength = header.Length + (fileData != null ? fileData.Length : 0) + footer.Length;

            webRequest.ContentLength = contentLength;

            using (var requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(header, 0, header.Length);

                if (fileData != null)
                {
                    var buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = fileData.Read(buffer, 0, buffer.Length)) != 0)
                        requestStream.Write(buffer, 0, bytesRead);
                }

                requestStream.Write(footer, 0, footer.Length);

                return webRequest.GetResponse();
            }
        }

        /*
        public static WebResponse PostFile
            (Uri requestUri, NameValueCollection postData, string fileName,
             string fileContentType, string fileFieldName, CookieContainer cookies,
             NameValueCollection headers)
        {
            using (var fileData = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                return PostFile(requestUri, postData, fileData,
                                fileName, fileContentType, fileFieldName, cookies,
                                headers);
        }
        */

        /*
        private static bool TryGetContentType(string fileName, out string contentType)
        {
            try
            {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type");

                if (key != null)
                {
                    foreach (string keyName in from keyName in key.GetSubKeyNames()
                                               let subKey = key.OpenSubKey(keyName)
                                               where subKey != null
                                               let subKeyValue = (string)subKey.GetValue("Extension")
                                               where string.IsNullOrEmpty(subKeyValue) == false
                                               where string.Compare(Path.GetExtension(fileName), subKeyValue, StringComparison.OrdinalIgnoreCase) == 0
                                               select keyName)
                    {
                        contentType = keyName;
                        return true;
                    }
                }
            }
            catch
            {
                // fail silently
                // TODO: rethrow registry access denied errors
            }
            contentType = string.Empty;
            return false;
        }
        */

    #endregion

    }
}
