using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetDistributionListResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetDistributionListResponse : ZimbraMessage
    {

        private distributionListInfo _dl;

        private System.Nullable<bool> _more;

        private System.Nullable<int> _total;

        public GetDistributionListResponse()
        {
            this._dl = new distributionListInfo();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public distributionListInfo dl
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int total
        {
            get
            {
                if (this._total.HasValue)
                {
                    return this._total.Value;
                }
                else
                {
                    return default(int);
                }
            }
            set
            {
                if ((_total.Equals(value) != true))
                {
                    this._total = value;
                    this.OnPropertyChanged("total");
                }
            }
        }
    }
}
