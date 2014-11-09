using ClubCloud.Zimbra.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class attrA : System.ComponentModel.INotifyPropertyChanged
    {

        private string _name;

        private System.Nullable<bool> _pd;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "a")]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, Name = "a", EmitDefaultValue = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((this._name == null)
                            || (_name.Equals(value) != true)))
                {
                    this._name = value;
                    this.OnPropertyChanged("name");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        public bool pd
        {
            get
            {
                if (this._pd.HasValue)
                {
                    return this._pd.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_pd.Equals(value) != true))
                {
                    this._pd = value;
                    this.OnPropertyChanged("pd");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
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
