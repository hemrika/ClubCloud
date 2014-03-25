using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "GetInfoRequest", WrapperNamespace = "urn:zimbraAccount")]
    public partial class GetInfoRequest : ZimbraMessage
    {

        private string _rights;

        private infoSection _sections;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "rights", Namespace = "urn:zimbraAccount")]
        [MessageBodyMember]
        public string rights
        {
            get
            {
                return this._rights;
            }
            set
            {
                if (((this._rights == null)
                            || (_rights.Equals(value) != true)))
                {
                    this._rights = value;
                    this.OnPropertyChanged("rights");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "sections", Namespace = "urn:zimbraAccount")]
        [MessageBodyMember]
        //public System.Nullable<infoSection> sections
        public string sections
        {
            get
            {
                if(_sections == infoSection.All)
                {
                    return null;
                }
                return this._sections.ToString();
            }
            set
            {
                if ((_sections.Equals(value) != true))
                {
                    this._sections = (infoSection)Enum.Parse(typeof(infoSection), value);
                    this.OnPropertyChanged("sections");
                }
            }
        }
    }
}
