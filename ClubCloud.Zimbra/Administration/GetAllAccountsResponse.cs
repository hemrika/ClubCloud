using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAllAccountsResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAllAccountsResponse : ZimbraMessage
    {

        private List<accountInfo> _account;

        public GetAllAccountsResponse()
        {
            this._account = new List<accountInfo>();
        }

        [System.Xml.Serialization.XmlElementAttribute("account")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<accountInfo> account
        {
            get
            {
                return this._account;
            }
            set
            {
                if (((this._account == null)
                            || (_account.Equals(value) != true)))
                {
                    this._account = value;
                    this.OnPropertyChanged("account");
                }
            }
        }
    }
}
