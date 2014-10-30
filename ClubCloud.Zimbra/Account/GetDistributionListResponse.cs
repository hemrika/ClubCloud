using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [System.Runtime.Serialization.DataContractAttribute(Name = "GetDistributionListResponse", Namespace = "urn:zimbraAccount")]
    public partial class GetDistributionListResponse : ZimbraMessage
    {

        private DistributionListInfo _dl;

        public GetDistributionListResponse()
        {
            this._dl = new DistributionListInfo();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListInfo dl
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
    }
}
