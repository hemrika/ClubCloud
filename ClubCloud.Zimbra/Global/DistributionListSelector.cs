using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class DistributionListSelector : System.ComponentModel.INotifyPropertyChanged
    {

        private System.Nullable<DistributionListBy> _by;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListBy by
        {
            get
            {
                if (this._by.HasValue)
                {
                    return this._by.Value;
                }
                else
                {
                    return default(DistributionListBy);
                }
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bySpecified
        {
            get
            {
                return this._by.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._by = null;
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
