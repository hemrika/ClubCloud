using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class DistributionListRightInfo : System.ComponentModel.INotifyPropertyChanged
    {

        private List<DistributionListGranteeInfo> _grantee;

        private string _right;

        public DistributionListRightInfo()
        {
            this._grantee = new List<DistributionListGranteeInfo>();
        }

        [System.Xml.Serialization.XmlElementAttribute("grantee")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DistributionListGranteeInfo> grantee
        {
            get
            {
                return this._grantee;
            }
            set
            {
                if (((this._grantee == null)
                            || (_grantee.Equals(value) != true)))
                {
                    this._grantee = value;
                    this.OnPropertyChanged("grantee");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string right
        {
            get
            {
                return this._right;
            }
            set
            {
                if (((this._right == null)
                            || (_right.Equals(value) != true)))
                {
                    this._right = value;
                    this.OnPropertyChanged("right");
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
