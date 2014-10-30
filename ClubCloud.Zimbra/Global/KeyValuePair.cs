using ClubCloud.Zimbra.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(contactAttr))]
    public partial class KeyValuePair : System.ComponentModel.INotifyPropertyChanged
    {

        private string _n;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string n
        {
            get
            {
                return this._n;
            }
            set
            {
                if (((this._n == null)
                            || (_n.Equals(value) != true)))
                {
                    this._n = value;
                    this.OnPropertyChanged("n");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
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
