using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAllDomainsRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAllDomainsRequest : ZimbraMessage
    {

        private System.Nullable<bool> _applyConfig;

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
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
