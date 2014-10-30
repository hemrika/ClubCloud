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
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "AuthResponse", WrapperNamespace = "urn:zimbraAccount")]
    public partial class AuthResponse : ZimbraMessage //System.ComponentModel.INotifyPropertyChanged
    {

        private string _authToken;

        private long _lifetime;

        private session _session;

        private string _refer;

        private string _skin;

        private List<pref> _prefs;

        private List<attr> _attrs;

        public AuthResponse()
        {
            this._attrs = new List<attr>();
            this._prefs = new List<pref>();
            this._session = new session();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
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

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public long lifetime
        {
            get
            {
                return this._lifetime;
            }
            set
            {
                if ((_lifetime.Equals(value) != true))
                {
                    this._lifetime = value;
                    this.OnPropertyChanged("lifetime");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public session session
        {
            get
            {
                return this._session;
            }
            set
            {
                if (((this._session == null)
                            || (_session.Equals(value) != true)))
                {
                    this._session = value;
                    this.OnPropertyChanged("session");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string refer
        {
            get
            {
                return this._refer;
            }
            set
            {
                if (((this._refer == null)
                            || (_refer.Equals(value) != true)))
                {
                    this._refer = value;
                    this.OnPropertyChanged("refer");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string skin
        {
            get
            {
                return this._skin;
            }
            set
            {
                if (((this._skin == null)
                            || (_skin.Equals(value) != true)))
                {
                    this._skin = value;
                    this.OnPropertyChanged("skin");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
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

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
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
