using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class cosInfoAttr : attrN
    {

        private System.Nullable<bool> _c;

        private System.Nullable<bool> _pd;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool c
        {
            get
            {
                if (this._c.HasValue)
                {
                    return this._c.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_c.Equals(value) != true))
                {
                    this._c = value;
                    this.OnPropertyChanged("c");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool cSpecified
        {
            get
            {
                return this._c.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._c = null;
                }
            }
        }
        */

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public new bool pd
        {
            get
            {
                if (this._pd.HasValue)
                {
                    return this._pd.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_pd.Equals(value) != true))
                {
                    this._pd = value;
                    this.OnPropertyChanged("pd");
                }
            }
        }

        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool pdSpecified
        {
            get
            {
                return this._pd.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._pd = null;
                }
            }
        }
        */
    }
}
