using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class authToken : System.ComponentModel.INotifyPropertyChanged
    {

        private System.Nullable<bool> _verifyAccount;

        private string _value;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [MessageBodyMember]
        public bool verifyAccount
        {
            get
            {
                if (this._verifyAccount.HasValue)
                {
                    return this._verifyAccount.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_verifyAccount.Equals(value) != true))
                {
                    this._verifyAccount = value;
                    this.OnPropertyChanged("verifyAccount");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool verifyAccountSpecified
        {
            get
            {
                return this._verifyAccount.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._verifyAccount = null;
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [MessageBodyMember]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if (((this._value == null)
                            || (_value.Equals(value) != true)))
                {
                    this._value = value;
                    this.OnPropertyChanged("Value");
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
