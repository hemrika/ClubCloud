using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAccountResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAccountResponse : ZimbraMessage
    {

        private accountInfo _account;

        public GetAccountResponse()
        {
            this._account = new accountInfo();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public accountInfo account
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
