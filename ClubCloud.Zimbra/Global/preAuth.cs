using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class preAuth : System.ComponentModel.INotifyPropertyChanged
    {

        private long _timestamp;

        private System.Nullable<long> _expiresTimestamp;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "timestamp", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = true)]
        public long timestamp
        {
            get
            {
                return this._timestamp;
            }
            set
            {
                if ((_timestamp.Equals(value) != true))
                {
                    this._timestamp = value;
                    this.OnPropertyChanged("timestamp");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "expiresTimestamp", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        public long expiresTimestamp
        {
            get
            {
                if (this._expiresTimestamp.HasValue)
                {
                    return this._expiresTimestamp.Value;
                }
                else
                {
                    return default(long);
                }
            }
            set
            {
                if ((_expiresTimestamp.Equals(value) != true))
                {
                    this._expiresTimestamp = value;
                    this.OnPropertyChanged("expiresTimestamp");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool expiresTimestampSpecified
        {
            get
            {
                return this._expiresTimestamp.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._expiresTimestamp = null;
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
