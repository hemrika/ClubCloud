using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetAccountRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetAccountRequest : attributeSelectorImpl
    {

        private accountSelector _account;

        private System.Nullable<bool> _applyCos;

        public GetAccountRequest()
        {
            this._account = new accountSelector();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
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

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public bool applyCos
        {
            get
            {
                if (this._applyCos.HasValue)
                {
                    return this._applyCos.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_applyCos.Equals(value) != true))
                {
                    this._applyCos = value;
                    this.OnPropertyChanged("applyCos");
                }
            }
        }
    }
}
