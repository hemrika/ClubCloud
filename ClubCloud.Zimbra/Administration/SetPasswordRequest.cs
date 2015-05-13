using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "SetPasswordRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class SetPasswordRequest : ZimbraMessage
    {

        private string _id;

        private string _newPassword;

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (((this._id == null)
                            || (_id.Equals(value) != true)))
                {
                    this._id = value;
                    this.OnPropertyChanged("id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string newPassword
        {
            get
            {
                return this._newPassword;
            }
            set
            {
                if (((this._newPassword == null)
                            || (_newPassword.Equals(value) != true)))
                {
                    this._newPassword = value;
                    this.OnPropertyChanged("newPassword");
                }
            }
        }

        /*
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        */
    }
}
