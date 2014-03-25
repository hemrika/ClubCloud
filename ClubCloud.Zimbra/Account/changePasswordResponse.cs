using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "ChangePasswordResponse", WrapperNamespace = "urn:zimbraAccount")]

    public partial class ChangePasswordResponse : ZimbraMessage
    {

        private string _authToken;

        private long _lifetime;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string authToken
        {
            get
            {
                return this._authToken;
            }
            set
            {
                if (((this._authToken == null)
                            || (_authToken.Equals(value) != true)))
                {
                    this._authToken = value;
                    this.OnPropertyChanged("authToken");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long lifetime
        {
            get
            {
                return this._lifetime;
            }
            set
            {
                if ((_lifetime.Equals(value) != true))
                {
                    this._lifetime = value;
                    this.OnPropertyChanged("lifetime");
                }
            }
        }
    }
}
