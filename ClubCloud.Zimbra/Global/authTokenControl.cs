using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class authTokenControl : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Nullable<bool> _voidOnExpired;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool voidOnExpired
        {
            get
            {
                if (this._voidOnExpired.HasValue)
                {
                    return this._voidOnExpired.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_voidOnExpired.Equals(value) != true))
                {
                    this._voidOnExpired = value;
                    this.OnPropertyChanged("needExp");
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
