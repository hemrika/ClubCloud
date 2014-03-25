using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "ChangePasswordRequest", WrapperNamespace = "urn:zimbraAccount")]
    public partial class ChangePasswordRequest : ZimbraMessage
    {

        private accountSelector _account;

        private string _oldPassword;

        private string _password;

        private string _virtualHost;

        public ChangePasswordRequest()
        {
            this._account = new accountSelector();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
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

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string oldPassword
        {
            get
            {
                return this._oldPassword;
            }
            set
            {
                if (((this._oldPassword == null)
                            || (_oldPassword.Equals(value) != true)))
                {
                    this._oldPassword = value;
                    this.OnPropertyChanged("oldPassword");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (((this._password == null)
                            || (_password.Equals(value) != true)))
                {
                    this._password = value;
                    this.OnPropertyChanged("password");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string virtualHost
        {
            get
            {
                return this._virtualHost;
            }
            set
            {
                if (((this._virtualHost == null)
                            || (_virtualHost.Equals(value) != true)))
                {
                    this._virtualHost = value;
                    this.OnPropertyChanged("virtualHost");
                }
            }
        }
    }
}
