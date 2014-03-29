using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAccountInfoResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAccountInfoResponse : ZimbraMessage
    {

        private string _name;

        private List<attrN> _a;

        private cosInfo _cos;

        private List<string> _soapURL;

        private string _adminSoapURL;

        private string _publicMailURL;

        public GetAccountInfoResponse()
        {
            this._soapURL = new List<string>();
            this._cos = new cosInfo();
            this._a = new List<attrN>();
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Namespace = "urn:zimbraAdmin")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((this._name == null)
                            || (_name.Equals(value) != true)))
                {
                    this._name = value;
                    this.OnPropertyChanged("name");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("a")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<attrN> a
        {
            get
            {
                return this._a;
            }
            set
            {
                if (((this._a == null)
                            || (_a.Equals(value) != true)))
                {
                    this._a = value;
                    this.OnPropertyChanged("a");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public cosInfo cos
        {
            get
            {
                return this._cos;
            }
            set
            {
                if (((this._cos == null)
                            || (_cos.Equals(value) != true)))
                {
                    this._cos = value;
                    this.OnPropertyChanged("cos");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "soapURL", Namespace = "urn:zimbraAdmin")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<string> soapURL
        {
            get
            {
                return this._soapURL;
            }
            set
            {
                if (((this._soapURL == null)
                            || (_soapURL.Equals(value) != true)))
                {
                    this._soapURL = value;
                    this.OnPropertyChanged("soapURL");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "adminSoapURL", Namespace = "urn:zimbraAdmin")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string adminSoapURL
        {
            get
            {
                return this._adminSoapURL;
            }
            set
            {
                if (((this._adminSoapURL == null)
                            || (_adminSoapURL.Equals(value) != true)))
                {
                    this._adminSoapURL = value;
                    this.OnPropertyChanged("adminSoapURL");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "publicMailURL", Namespace = "urn:zimbraAdmin")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string publicMailURL
        {
            get
            {
                return this._publicMailURL;
            }
            set
            {
                if (((this._publicMailURL == null)
                            || (_publicMailURL.Equals(value) != true)))
                {
                    this._publicMailURL = value;
                    this.OnPropertyChanged("publicMailURL");
                }
            }
        }
    }
}
