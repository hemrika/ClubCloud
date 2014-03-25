using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "GetInfoResponse", WrapperNamespace = "urn:zimbraAccount")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraAccount")]
    [System.Xml.Serialization.XmlRootAttribute("GetInfoResponse", Namespace = "urn:zimbraAccount", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "GetInfoResponse", Namespace = "urn:zimbraAccount")]

    public partial class GetInfoResponse : ZimbraMessage
    {

        private string _version;

        private string _id;

        private string _name;

        private string _crumb;

        private long _lifetime;

        private System.Nullable<bool> _adminDelegated;

        private string _rest;

        private System.Nullable<long> _used;

        private System.Nullable<long> _prevSession;

        private System.Nullable<long> _accessed;

        private System.Nullable<int> _recent;

        private cos _cos;

        private List<pref> _prefs;

        private List<attr> _attrs;

        private List<accountZimletInfo> _zimlets;

        private List<prop> _props;

        private List<identity> _identities;

        private List<signature> _signatures;

        private GetInfoResponseDataSources _dataSources;

        private List<childAccount> _childAccounts;

        private List<discoverRightsInfo> _rights;

        private string _soapURL;

        private string _publicURL;

        private string _changePasswordURL;

        private licenseInfo _license;

        private System.Nullable<long> _attSizeLimit;

        private System.Nullable<long> _docSizeLimit;

        public GetInfoResponse()
        {
            this._license = new licenseInfo();
            this._rights = new List<discoverRightsInfo>();
            this._childAccounts = new List<childAccount>();
            this._dataSources = new GetInfoResponseDataSources();
            this._signatures = new List<signature>();
            this._identities = new List<identity>();
            this._props = new List<prop>();
            this._zimlets = new List<accountZimletInfo>();
            this._attrs = new List<attr>();
            this._prefs = new List<pref>();
            this._cos = new cos();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string version
        {
            get
            {
                return this._version;
            }
            set
            {
                if (((this._version == null)
                            || (_version.Equals(value) != true)))
                {
                    this._version = value;
                    this.OnPropertyChanged("version");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (((this._id == null)
                            || (_id.Equals(value) != true)))
                {
                    this._id = value;
                    this.OnPropertyChanged("id");
                }
            }
        }

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

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string crumb
        {
            get
            {
                return this._crumb;
            }
            set
            {
                if (((this._crumb == null)
                            || (_crumb.Equals(value) != true)))
                {
                    this._crumb = value;
                    this.OnPropertyChanged("crumb");
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
        public bool adminDelegated
        {
            get
            {
                if (this._adminDelegated.HasValue)
                {
                    return this._adminDelegated.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_adminDelegated.Equals(value) != true))
                {
                    this._adminDelegated = value;
                    this.OnPropertyChanged("adminDelegated");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public bool adminDelegatedSpecified
        {
            get
            {
                return this._adminDelegated.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._adminDelegated = null;
                }
            }
        }
        */

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string rest
        {
            get
            {
                return this._rest;
            }
            set
            {
                if (((this._rest == null)
                            || (_rest.Equals(value) != true)))
                {
                    this._rest = value;
                    this.OnPropertyChanged("rest");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public long used
        {
            get
            {
                if (this._used.HasValue)
                {
                    return this._used.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_used.Equals(value) != true))
                {
                    this._used = value;
                    this.OnPropertyChanged("used");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool usedSpecified
        {
            get
            {
                return this._used.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._used = null;
                }
            }
        }
        */

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public long prevSession
        {
            get
            {
                if (this._prevSession.HasValue)
                {
                    return this._prevSession.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_prevSession.Equals(value) != true))
                {
                    this._prevSession = value;
                    this.OnPropertyChanged("prevSession");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool prevSessionSpecified
        {
            get
            {
                return this._prevSession.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._prevSession = null;
                }
            }
        }
        */

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public long accessed
        {
            get
            {
                if (this._accessed.HasValue)
                {
                    return this._accessed.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_accessed.Equals(value) != true))
                {
                    this._accessed = value;
                    this.OnPropertyChanged("accessed");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool accessedSpecified
        {
            get
            {
                return this._accessed.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._accessed = null;
                }
            }
        }
        */

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public int recent
        {
            get
            {
                if (this._recent.HasValue)
                {
                    return this._recent.Value;
                }
                else
                {
                    return default(int);
                }
            }
            set
            {
                if ((_recent.Equals(value) != true))
                {
                    this._recent = value;
                    this.OnPropertyChanged("recent");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool recentSpecified
        {
            get
            {
                return this._recent.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._recent = null;
                }
            }
        }
        */

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public cos cos
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

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
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
        [MessageBodyMember]
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

        [System.Xml.Serialization.XmlArrayItemAttribute("zimlet", IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<accountZimletInfo> zimlets
        {
            get
            {
                return this._zimlets;
            }
            set
            {
                if (((this._zimlets == null)
                            || (_zimlets.Equals(value) != true)))
                {
                    this._zimlets = value;
                    this.OnPropertyChanged("zimlets");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<prop> props
        {
            get
            {
                return this._props;
            }
            set
            {
                if (((this._props == null)
                            || (_props.Equals(value) != true)))
                {
                    this._props = value;
                    this.OnPropertyChanged("props");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<identity> identities
        {
            get
            {
                return this._identities;
            }
            set
            {
                if (((this._identities == null)
                            || (_identities.Equals(value) != true)))
                {
                    this._identities = value;
                    this.OnPropertyChanged("identities");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<signature> signatures
        {
            get
            {
                return this._signatures;
            }
            set
            {
                if (((this._signatures == null)
                            || (_signatures.Equals(value) != true)))
                {
                    this._signatures = value;
                    this.OnPropertyChanged("signatures");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public GetInfoResponseDataSources dataSources
        {
            get
            {
                return this._dataSources;
            }
            set
            {
                if (((this._dataSources == null)
                            || (_dataSources.Equals(value) != true)))
                {
                    this._dataSources = value;
                    this.OnPropertyChanged("dataSources");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<childAccount> childAccounts
        {
            get
            {
                return this._childAccounts;
            }
            set
            {
                if (((this._childAccounts == null)
                            || (_childAccounts.Equals(value) != true)))
                {
                    this._childAccounts = value;
                    this.OnPropertyChanged("childAccounts");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("targets", IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<discoverRightsInfo> rights
        {
            get
            {
                return this._rights;
            }
            set
            {
                if (((this._rights == null)
                            || (_rights.Equals(value) != true)))
                {
                    this._rights = value;
                    this.OnPropertyChanged("rights");
                }
            }
        }

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

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public licenseInfo license
        {
            get
            {
                return this._license;
            }
            set
            {
                if (((this._license == null)
                            || (_license.Equals(value) != true)))
                {
                    this._license = value;
                    this.OnPropertyChanged("license");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        //[MessageBodyMember]
        public long attSizeLimit
        {
            get
            {
                if (this._attSizeLimit.HasValue)
                {
                    return this._attSizeLimit.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_attSizeLimit.Equals(value) != true))
                {
                    this._attSizeLimit = value;
                    this.OnPropertyChanged("attSizeLimit");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool attSizeLimitSpecified
        {
            get
            {
                return this._attSizeLimit.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._attSizeLimit = null;
                }
            }
        }
        */

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        //[MessageBodyMember]
        public long docSizeLimit
        {
            get
            {
                if (this._docSizeLimit.HasValue)
                {
                    return this._docSizeLimit.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_docSizeLimit.Equals(value) != true))
                {
                    this._docSizeLimit = value;
                    this.OnPropertyChanged("docSizeLimit");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool docSizeLimitSpecified
        {
            get
            {
                return this._docSizeLimit.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._docSizeLimit = null;
                }
            }
        }
        */
    }
}
