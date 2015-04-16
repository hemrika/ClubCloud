using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Mail
{
    [MessageContract(WrapperName = "SendMsgResponse", WrapperNamespace = "urn:zimbraMail")]
    public partial class SendMsgResponse : ZimbraMessage
    {

        private id _m;

        public SendMsgResponse()
        {
            this._m = new id();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public id m
        {
            get
            {
                return this._m;
            }
            set
            {
                if (((this._m == null)
                            || (_m.Equals(value) != true)))
                {
                    this._m = value;
                    this.OnPropertyChanged("m");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
