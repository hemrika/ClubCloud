using ClubCloud.Zimbra.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(calendarResourceInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionListAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateDistributionListRequest))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(AccountCustomMetadata))]
    public partial class AccountKeyValuePairs : System.ComponentModel.INotifyPropertyChanged
    {

        private List<KeyValuePair> _a;

        public AccountKeyValuePairs()
        {
            this._a = new List<KeyValuePair>();
        }

        [System.Xml.Serialization.XmlElementAttribute("a")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<KeyValuePair> a
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
