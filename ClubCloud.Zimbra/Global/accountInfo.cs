using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class accountInfo : adminObjectInfo
    {

        private System.Nullable<bool> _isExternal;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isExternal
        {
            get
            {
                if (this._isExternal.HasValue)
                {
                    return this._isExternal.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_isExternal.Equals(value) != true))
                {
                    this._isExternal = value;
                    this.OnPropertyChanged("isExternal");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isExternalSpecified
        {
            get
            {
                return this._isExternal.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._isExternal = null;
                }
            }
        }
    }
}
