using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class userAgent : System.ComponentModel.INotifyPropertyChanged
    {
        private string _name = null;

        private string _version = null;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue= false, IsRequired= false, Name="name")]
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
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, IsRequired = false, Name = "version")]
        public string version
        {
            get
            {
                return this._version;
            }
            set
            {
                if (((this._version == null)
                            || (_version.Equals(value) != true)))
                {
                    this._version = value;
                    this.OnPropertyChanged("version");
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
