
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class DistributionListGranteeSelector : System.ComponentModel.INotifyPropertyChanged
    {

        private GranteeType _type;

        private DistributionListGranteeBy _by;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GranteeType type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((_type.Equals(value) != true))
                {
                    this._type = value;
                    this.OnPropertyChanged("type");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListGranteeBy by
        {
            get
            {
                return this._by;
            }
            set
            {
                if ((_by.Equals(value) != true))
                {
                    this._by = value;
                    this.OnPropertyChanged("by");
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
