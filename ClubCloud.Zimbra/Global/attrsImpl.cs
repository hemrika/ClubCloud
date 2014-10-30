using ClubCloud.Zimbra.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetDistributionListRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionListActionRequest))]
    public abstract partial class attrsImpl : ZimbraMessage
    {

        private List<attr> _a;

        public attrsImpl()
        {
            this._a = new List<attr>();
        }

        [System.Xml.Serialization.XmlElementAttribute("a")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<attr> a
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
    }
}
