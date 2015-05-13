using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "AuthRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class AuthRequest : ZimbraMessage
    {

        private string _authToken;

        private accountSelector _account;

        private string _virtualHost;

        private System.Nullable<bool> _persistAuthTokenCookie;

        private string _name;

        private string _password;

        public AuthRequest()
        {
            this._account = new accountSelector();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]

        public string authToken
        {
            get
            {
                return this._authToken;
            }
            set
            {
                if (((this._authToken == null)
                            || (_authToken.Equals(value) != true)))
                {
                    this._authToken = value;
                    this.OnPropertyChanged("authToken");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "account", Namespace = "urn:zimbraAdmin")]
        [MessageBodyMember]
        public accountSelector account
        {
            get
            {
                return this._account;
            }
            set
            {
                if (((this._account == null)
                            || (_account.Equals(value) != true)))
                {
                    this._account = value;
                    this.OnPropertyChanged("account");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string virtualHost
        {
            get
            {
                return this._virtualHost;
            }
            set
            {
                if (((this._virtualHost == null)
                            || (_virtualHost.Equals(value) != true)))
                {
                    this._virtualHost = value;
                    this.OnPropertyChanged("virtualHost");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool persistAuthTokenCookie
        {
            get
            {
                if (this._persistAuthTokenCookie.HasValue)
                {
                    return this._persistAuthTokenCookie.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_persistAuthTokenCookie.Equals(value) != true))
                {
                    this._persistAuthTokenCookie = value;
                    this.OnPropertyChanged("persistAuthTokenCookie");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool persistAuthTokenCookieSpecified
        {
            get
            {
                return this._persistAuthTokenCookie.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._persistAuthTokenCookie = null;
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
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

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "password", Namespace = "urn:zimbraAdmin")]
        [MessageBodyMember]
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (((this._password == null)
                            || (_password.Equals(value) != true)))
                {
                    this._password = value;
                    this.OnPropertyChanged("password");
                }
            }
        }
    }
}
