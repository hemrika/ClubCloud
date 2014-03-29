using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class cosInfo : System.ComponentModel.INotifyPropertyChanged
    {

        private List<cosInfoAttr> _a;

        private string _id;

        private string _name;

        private System.Nullable<bool> _isDefaultCos;

        public cosInfo()
        {
            this._a = new List<cosInfoAttr>();
        }

        [System.Xml.Serialization.XmlElementAttribute("a")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<cosInfoAttr> a
        {
            get
            {
                return this._a;
            }
            set
            {
                if (((this._a == null)
                            || (_a.Equals(value) != true)))
                {
                    this._a = value;
                    this.OnPropertyChanged("a");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (((this._id == null)
                            || (_id.Equals(value) != true)))
                {
                    this._id = value;
                    this.OnPropertyChanged("id");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isDefaultCos
        {
            get
            {
                if (this._isDefaultCos.HasValue)
                {
                    return this._isDefaultCos.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_isDefaultCos.Equals(value) != true))
                {
                    this._isDefaultCos = value;
                    this.OnPropertyChanged("isDefaultCos");
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
