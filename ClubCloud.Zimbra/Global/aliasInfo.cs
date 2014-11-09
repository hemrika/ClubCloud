using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class aliasInfo : adminObjectInfo
    {

        private string _targetName;

        private System.Nullable<TargetType> _type;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string targetName
        {
            get
            {
                return this._targetName;
            }
            set
            {
                if (((this._targetName == null)
                            || (_targetName.Equals(value) != true)))
                {
                    this._targetName = value;
                    this.OnPropertyChanged("targetName");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TargetType type
        {
            get
            {
                if (this._type.HasValue)
                {
                    return this._type.Value;
                }
                else
                {
                    return default(TargetType);
                }
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this._type.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._type = null;
                }
            }
        }
    }
}
