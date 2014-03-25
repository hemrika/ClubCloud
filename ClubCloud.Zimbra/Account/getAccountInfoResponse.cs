using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "GetAccountInfoResponse", WrapperNamespace = "urn:zimbraAccount")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraAccount")]
    [System.Xml.Serialization.XmlRootAttribute("GetAccountInfoResponse", Namespace = "urn:zimbraAccount", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "getAccountInfoResponse", Namespace = "urn:zimbraAccount")]
    public partial class GetAccountInfoResponse : ZimbraMessage
    {

        private string _name;

        private List<namedValue> _attr;

        private string _soapURL;

        private string _publicURL;

        private string _changePasswordURL;

        public GetAccountInfoResponse()
        {
            this._attr = new List<namedValue>();
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Namespace = "urn:zimbraAccount")]
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

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "attr", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<namedValue> attr
        {
            get
            {
                return this._attr;
            }
            set
            {
                if (((this._attr == null)
                            || (_attr.Equals(value) != true)))
                {
                    this._attr = value;
                    this.OnPropertyChanged("attr");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "soapURL", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string soapURL
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

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "publicURL", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string publicURL
        {
            get
            {
                return this._publicURL;
            }
            set
            {
                if (((this._publicURL == null)
                            || (_publicURL.Equals(value) != true)))
                {
                    this._publicURL = value;
                    this.OnPropertyChanged("publicURL");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "changePasswordURL", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string changePasswordURL
        {
            get
            {
                return this._changePasswordURL;
            }
            set
            {
                if (((this._changePasswordURL == null)
                            || (_changePasswordURL.Equals(value) != true)))
                {
                    this._changePasswordURL = value;
                    this.OnPropertyChanged("changePasswordURL");
                }
            }
        }
    }
}
