using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "SetPasswordResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class SetPasswordResponse : ZimbraMessage //System.ComponentModel.INotifyPropertyChanged
    {

        private string _message;

        //[System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string message
        {
            get
            {
                return this._message;
            }
            set
            {
                if (((this._message == null)
                            || (_message.Equals(value) != true)))
                {
                    this._message = value;
                    this.OnPropertyChanged("message");
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
