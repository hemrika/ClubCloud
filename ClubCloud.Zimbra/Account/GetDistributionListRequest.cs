using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [System.Runtime.Serialization.DataContractAttribute(Name = "GetDistributionListRequest", Namespace = "urn:zimbraAccount")]
    public partial class GetDistributionListRequest : attrsImpl
    {

        private DistributionListSelector _dl;

        private System.Nullable<bool> _needOwners;

        private string _needRights;

        public GetDistributionListRequest()
        {
            this._dl = new DistributionListSelector();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListSelector dl
        {
            get
            {
                return this._dl;
            }
            set
            {
                if (((this._dl == null)
                            || (_dl.Equals(value) != true)))
                {
                    this._dl = value;
                    this.OnPropertyChanged("dl");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool needOwners
        {
            get
            {
                if (this._needOwners.HasValue)
                {
                    return this._needOwners.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_needOwners.Equals(value) != true))
                {
                    this._needOwners = value;
                    this.OnPropertyChanged("needOwners");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool needOwnersSpecified
        {
            get
            {
                return this._needOwners.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._needOwners = null;
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string needRights
        {
            get
            {
                return this._needRights;
            }
            set
            {
                if (((this._needRights == null)
                            || (_needRights.Equals(value) != true)))
                {
                    this._needRights = value;
                    this.OnPropertyChanged("needRights");
                }
            }
        }
    }
}
