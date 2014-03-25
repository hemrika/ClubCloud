using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetDomainRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetDomainRequest : attributeSelectorImpl
    {

        private domainSelector _domain;

        private System.Nullable<bool> _applyConfig;

        public GetDomainRequest()
        {
            this._domain = new domainSelector();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool applyConfig
        {
            get
            {
                if (this._applyConfig.HasValue)
                {
                    return this._applyConfig.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_applyConfig.Equals(value) != true))
                {
                    this._applyConfig = value;
                    this.OnPropertyChanged("applyConfig");
                }
            }
        }
    }
}
