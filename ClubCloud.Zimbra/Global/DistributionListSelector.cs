using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class DistributionListSelector
    {

        private System.Nullable<DistributionListBy> _by;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, Name = "by", EmitDefaultValue = false)]
        public DistributionListBy by
        {
            get
            {
                if (this._by.HasValue)
                {
                    return this._by.Value;
                }
                else
                {
                    return default(DistributionListBy);
                }
            }
            set
            {
                if ((_by.Equals(value) != true))
                {
                    this._by = value;
                    //this.OnPropertyChanged("by");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
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
                    //this.OnPropertyChanged("Value");
                }
            }
        }
    }
}
