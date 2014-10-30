using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class DistributionListInfo : adminObjectInfoN
    {
        private List<string> _dlm;

        private List<GranteeInfo> _owners;

        private System.Nullable<bool> _dynamic;

        public DistributionListInfo()
        {
            this._owners = new List<GranteeInfo>();
            this._dlm = new List<string>();
        }

        [System.Xml.Serialization.XmlElementAttribute("dlm")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> dlm
        {
            get
            {
                return this._dlm;
            }
            set
            {
                if (((this._dlm == null)
                            || (_dlm.Equals(value) != true)))
                {
                    this._dlm = value;
                    this.OnPropertyChanged("dlm");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("owner", IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<GranteeInfo> owners
        {
            get
            {
                return this._owners;
            }
            set
            {
                if (((this._owners == null)
                            || (_owners.Equals(value) != true)))
                {
                    this._owners = value;
                    this.OnPropertyChanged("owners");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool dynamic
        {
            get
            {
                if (this._dynamic.HasValue)
                {
                    return this._dynamic.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_dynamic.Equals(value) != true))
                {
                    this._dynamic = value;
                    this.OnPropertyChanged("dynamic");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool dynamicSpecified
        {
            get
            {
                return this._dynamic.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._dynamic = null;
                }
            }
        }
        */
    }
}
