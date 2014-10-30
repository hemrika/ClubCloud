using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAllDistributionListsRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAllDistributionListsRequest : ZimbraMessage
    {

        private domainSelector _domain;

        public GetAllDistributionListsRequest()
        {
            this._domain = new domainSelector();
        }

        //[System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public domainSelector domain
        {
            get
            {
                return this._domain;
            }
            set
            {
                if (((this._domain == null)
                            || (_domain.Equals(value) != true)))
                {
                    this._domain = value;
                    this.OnPropertyChanged("domain");
                }
            }
        }
    }
}
