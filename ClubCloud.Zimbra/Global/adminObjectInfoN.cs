using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aliasInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(dlInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(zimletInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ucServiceInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(serverInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(domainInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionListInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(calendarResourceInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(accountInfo))]
    public partial class adminObjectInfoN : System.ComponentModel.INotifyPropertyChanged
    {

        private List<attrN> _a;

        private string _name;

        private string _id;

        public adminObjectInfoN()
        {
            this._a = new List<attrN>();
        }

        [System.Xml.Serialization.XmlElementAttribute("a")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<attrN> a
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
