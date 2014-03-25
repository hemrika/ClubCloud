using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "ModifyDomainResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class ModifyDomainResponse : ZimbraMessage
    {

        private domainInfo _domain;

        public ModifyDomainResponse()
        {
            this._domain = new domainInfo();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public domainInfo domain
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
