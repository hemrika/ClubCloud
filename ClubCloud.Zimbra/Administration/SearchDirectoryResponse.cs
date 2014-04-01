using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "SearchDirectoryResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class SearchDirectoryResponse : ZimbraMessage
    {

        private List<object> _items;

        private System.Nullable<long> _num;

        private System.Nullable<bool> _more;

        private System.Nullable<long> _searchTotal;

        public SearchDirectoryResponse()
        {
            this._items = new List<object>();
        }

        [System.Xml.Serialization.XmlElementAttribute("account", typeof(accountInfo))]
        [System.Xml.Serialization.XmlElementAttribute("alias", typeof(aliasInfo))]
        [System.Xml.Serialization.XmlElementAttribute("calresource", typeof(calendarResourceInfo))]
        [System.Xml.Serialization.XmlElementAttribute("cos", typeof(cosInfo))]
        [System.Xml.Serialization.XmlElementAttribute("dl", typeof(distributionListInfo))]
        [System.Xml.Serialization.XmlElementAttribute("domain", typeof(domainInfo))]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                if (((this._items == null)
                            || (_items.Equals(value) != true)))
                {
                    this._items = value;
                    this.OnPropertyChanged("Items");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public long num
        {
            get
            {
                if (this._num.HasValue)
                {
                    return this._num.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_num.Equals(value) != true))
                {
                    this._num = value;
                    this.OnPropertyChanged("num");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public bool more
        {
            get
            {
                if (this._more.HasValue)
                {
                    return this._more.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_more.Equals(value) != true))
                {
                    this._more = value;
                    this.OnPropertyChanged("more");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public long searchTotal
        {
            get
            {
                if (this._searchTotal.HasValue)
                {
                    return this._searchTotal.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_searchTotal.Equals(value) != true))
                {
                    this._searchTotal = value;
                    this.OnPropertyChanged("searchTotal");
                }
            }
        }
    }
}
