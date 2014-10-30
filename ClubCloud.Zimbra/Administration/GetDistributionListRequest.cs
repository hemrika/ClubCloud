using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetDistributionListRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetDistributionListRequest : adminAttrsImpl
    {

        private DistributionListSelector _dl;

        private System.Nullable<int> _limit;

        private System.Nullable<int> _offset;

        private System.Nullable<bool> _sortAscending;

        public GetDistributionListRequest()
        {
            this._dl = new DistributionListSelector();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
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
        public int limit
        {
            get
            {
                if (this._limit.HasValue)
                {
                    return this._limit.Value;
                }
                else
                {
                    return default(int);
                }
            }
            set
            {
                if ((_limit.Equals(value) != true))
                {
                    this._limit = value;
                    this.OnPropertyChanged("limit");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int offset
        {
            get
            {
                if (this._offset.HasValue)
                {
                    return this._offset.Value;
                }
                else
                {
                    return default(int);
                }
            }
            set
            {
                if ((_offset.Equals(value) != true))
                {
                    this._offset = value;
                    this.OnPropertyChanged("offset");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool sortAscending
        {
            get
            {
                if (this._sortAscending.HasValue)
                {
                    return this._sortAscending.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_sortAscending.Equals(value) != true))
                {
                    this._sortAscending = value;
                    this.OnPropertyChanged("sortAscending");
                }
            }
        }
    }
}
