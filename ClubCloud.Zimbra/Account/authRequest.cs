using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Account
{
    /// <summary>
    /// Authenticate for an account.
    /// </summary>
    [MessageContract(WrapperName = "AuthRequest", WrapperNamespace = "urn:zimbraAccount")]
    public partial class AuthRequest : ZimbraMessage // System.ComponentModel.INotifyPropertyChanged
    {

        private accountSelector _account;

        private string _password;

        private preAuth _preauth;

        private authToken _authToken;

        private string _virtualHost;

        private List<pref> _prefs;

        private List<attr> _attrs;

        private string _requestedSkin;

        private System.Nullable<bool> _persistAuthTokenCookie;

        public AuthRequest()
        {
            this._attrs = new List<attr>();
            this._prefs = new List<pref>();
            this._authToken = new authToken();
            this._preauth = new preAuth();
            this._account = new accountSelector();
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "account", Namespace = "urn:zimbraAccount")]
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

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "password", Namespace = "urn:zimbraAccount")]
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

        //[System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        //[System.Xml.Serialization.XmlElement(ElementName = "preAuth", Namespace = "urn:zimbraAccount")]
        //[MessageBodyMember(Name= "preAuth", Namespace="urn:zimbraAccount")]
        public preAuth preauth
        {
            get
            {
                return this._preauth;
            }
            set
            {
                if (((this._preauth == null)
                            || (_preauth.Equals(value) != true)))
                {
                    this._preauth = value;
                    this.OnPropertyChanged("preauth");
                }
            }
        }

        //[System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        //[System.Xml.Serialization.XmlElement(ElementName = "authToken", Namespace = "urn:zimbraAccount")]
        //[MessageBodyMember(Name = "authToken", Namespace = "urn:zimbraAccount")]
        public authToken authToken
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
        [System.Xml.Serialization.XmlElement(ElementName = "virtualHost", Namespace = "urn:zimbraAccount")]
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

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false, ElementName = "prefs", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = true)]
        public List<pref> prefs
        {
            get
            {
                return this._prefs;
            }
            set
            {
                if (((this._prefs == null)
                            || (_prefs.Equals(value) != true)))
                {
                    this._prefs = value;
                    this.OnPropertyChanged("prefs");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(ElementName = "attrs", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = true)]
        public List<attr> attrs
        {
            get
            {
                return this._attrs;
            }
            set
            {
                if (((this._attrs == null)
                            || (_attrs.Equals(value) != true)))
                {
                    this._attrs = value;
                    this.OnPropertyChanged("attrs");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "requestedSkin", Namespace = "urn:zimbraAccount")]
        public string requestedSkin
        {
            get
            {
                return this._requestedSkin;
            }
            set
            {
                if (((this._requestedSkin == null)
                            || (_requestedSkin.Equals(value) != true)))
                {
                    this._requestedSkin = value;
                    this.OnPropertyChanged("requestedSkin");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "persistAuthTokenCookie", Namespace = "urn:zimbraAccount")]
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
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "persistAuthTokenCookieSpecified", Namespace = "urn:zimbraAccount")]
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

        /*
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        */
        /*
        public string Serialize()
        {
            StringBuilder ser = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            XmlWriter writer = XmlWriter.Create(ser, settings);

            XmlSerializer mySerializer = new XmlSerializer(MethodBase.GetCurrentMethod().ReflectedType);
            XmlSerializerNamespaces myNamespaces = new XmlSerializerNamespaces();

            XmlTypeAttribute xmlAttribute = (XmlTypeAttribute)Attribute.GetCustomAttribute(MethodBase.GetCurrentMethod().ReflectedType, typeof(XmlTypeAttribute));
            myNamespaces.Add("", xmlAttribute.Namespace);

            try
            {
                mySerializer.Serialize(writer, this, myNamespaces);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                throw;
            }
            finally
            {
                writer.Close();
            }
            return ser.ToString();
        }

        public static object DeSerialize(string data)
        {
            StringReader txt = new StringReader(data);
            XmlReader reader = XmlReader.Create(txt);
            XmlSerializer mySerializer = new XmlSerializer(MethodBase.GetCurrentMethod().ReflectedType);
            return mySerializer.Deserialize(reader);

            //XmlSerializer mySerializer = new XmlSerializer(typeof(AuthRequest));
            //return (AuthRequest)mySerializer.Deserialize(reader);
        }
        */
    }
}
