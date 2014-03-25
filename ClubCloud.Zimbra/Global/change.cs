using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class change : System.ComponentModel.INotifyPropertyChanged
    {

        private changeType _type;

        private string _token;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public changeType type
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
        public string token
        {
            get
            {
                return this._token;
            }
            set
            {
                if (((this._token == null)
                            || (_token.Equals(value) != true)))
                {
                    this._token = value;
                    this.OnPropertyChanged("token");
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
