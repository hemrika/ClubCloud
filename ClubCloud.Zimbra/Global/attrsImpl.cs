using ClubCloud.Zimbra.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(GetDistributionListRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionListActionRequest))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Identity))]
    [MessageContract]
    public abstract partial class attrsImpl : ZimbraMessage
    {

        private List<attrA> _a;

        public attrsImpl()
        {
            this._a = new List<attrA>();
        }

        [System.Xml.Serialization.XmlElementAttribute("a")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<attrA> a
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
