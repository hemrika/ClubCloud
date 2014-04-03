using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAllAccountsRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAllAccountsRequest : ZimbraMessage
    {

        private serverSelector _server;

        private domainSelector _domain;

        public GetAllAccountsRequest()
        {
            this._domain = new domainSelector();
            this._server = new serverSelector();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public serverSelector server
        {
            get
            {
                return this._server;
            }
            set
            {
                if (((this._server == null)
                            || (_server.Equals(value) != true)))
                {
                    this._server = value;
                    this.OnPropertyChanged("server");
                }
            }
        }

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
