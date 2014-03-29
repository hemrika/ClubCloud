using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAccountInfoRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAccountInfoRequest : ZimbraMessage
    {

        private accountSelector _account;

        public GetAccountInfoRequest()
        {
            this._account = new accountSelector();
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "account", Namespace = "urn:zimbraAdmin")]
        [MessageBodyMember]
        public accountSelector account
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
