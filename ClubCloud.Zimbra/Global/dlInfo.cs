using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class dlInfo : adminObjectInfo
    {

        private System.Nullable<bool> _dynamic;

        private string _via;

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string via
        {
            get
            {
                return this._via;
            }
            set
            {
                if (((this._via == null)
                            || (_via.Equals(value) != true)))
                {
                    this._via = value;
                    this.OnPropertyChanged("via");
                }
            }
        }
    }
}
