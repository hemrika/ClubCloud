using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class DistributionListSubscribeReq : System.ComponentModel.INotifyPropertyChanged
    {

        private DistributionListSubscribeOp _op;

        private System.Nullable<bool> _bccOwners;

        private string _value;

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListSubscribeOp op
        {
            get
            {
                return this._op;
            }
            set
            {
                if ((_op.Equals(value) != true))
                {
                    this._op = value;
                    this.OnPropertyChanged("op");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bccOwners
        {
            get
            {
                if (this._bccOwners.HasValue)
                {
                    return this._bccOwners.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_bccOwners.Equals(value) != true))
                {
                    this._bccOwners = value;
                    this.OnPropertyChanged("bccOwners");
                }
            }
        }

        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bccOwnersSpecified
        {
            get
            {
                return this._bccOwners.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._bccOwners = null;
                }
            }
        }

        //[System.Xml.Serialization.XmlTextAttribute()]
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
