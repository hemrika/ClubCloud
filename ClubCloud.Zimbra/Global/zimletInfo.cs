using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class zimletInfo : adminObjectInfo
    {

        private string _hasKeyword;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hasKeyword
        {
            get
            {
                return this._hasKeyword;
            }
            set
            {
                if (((this._hasKeyword == null)
                            || (_hasKeyword.Equals(value) != true)))
                {
                    this._hasKeyword = value;
                    this.OnPropertyChanged("hasKeyword");
                }
            }
        }
    }
}
