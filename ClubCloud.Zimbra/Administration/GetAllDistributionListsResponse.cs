using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAllDistributionListsResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAllDistributionListsResponse : ZimbraMessage
    {

        private List<distributionListInfo> _dl;

        public GetAllDistributionListsResponse()
        {
            this._dl = new List<distributionListInfo>();
        }

        [System.Xml.Serialization.XmlElementAttribute("dl")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<distributionListInfo> dl
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
