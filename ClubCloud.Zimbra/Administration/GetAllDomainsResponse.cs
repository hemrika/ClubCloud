using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAllDomainsResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAllDomainsResponse : ZimbraMessage
    {

        private List<domainInfo> _domain;

        public GetAllDomainsResponse()
        {
            this._domain = new List<domainInfo>();
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "domain", Namespace = "urn:zimbraAdmin")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<domainInfo> Domains
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
