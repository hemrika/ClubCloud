using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAccountMembershipResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAccountMembershipResponse : ZimbraMessage
    {

        private List<dlInfo> _dl;

        public GetAccountMembershipResponse()
        {
            this._dl = new List<dlInfo>();
        }

        [System.Xml.Serialization.XmlElementAttribute("dl")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<dlInfo> dl
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
