using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "CreateDistributionListRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class CreateDistributionListRequest : adminAttrsImpl
    {

        private string _name;

        private System.Nullable<bool> _dynamic;

        //[System.Xml.Serialization.XmlAttributeAttribute()]
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

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool dynamic
        {
            get
            {
                if (this._dynamic.HasValue)
                {
                    return this._dynamic.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_dynamic.Equals(value) != true))
                {
                    this._dynamic = value;
                    this.OnPropertyChanged("dynamic");
                }
            }
        }

        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool dynamicSpecified
        {
            get
            {
                return this._dynamic.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._dynamic = null;
                }
            }
        }
    }
}
