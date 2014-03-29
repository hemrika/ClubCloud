using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class cosSelector : ZimbraMessage
    {

        private System.Nullable<cosBy> _by;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public cosBy by
        {
            get
            {
                if (this._by.HasValue)
                {
                    return this._by.Value;
                }
                else
                {
                    return default(cosBy);
                }
            }
            set
            {
                if ((_by.Equals(value) != true))
                {
                    this._by = value;
                    this.OnPropertyChanged("by");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bySpecified
        {
            get
            {
                return this._by.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._by = null;
                }
            }
        }
        */
        [System.Xml.Serialization.XmlTextAttribute()]
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
    }
}
