using ClubCloud.KNLTB.Servit.CRM.Origins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.Servit.CRM
{
    [XmlRoot(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsNullable = false), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
    [Serializable]
    public class CallerOriginToken : SoapHeader
    {
        private CallerOrigin callerOriginField;
        private XmlAttribute[] anyAttrField;
        public CallerOrigin CallerOrigin
        {
            get
            {
                return this.callerOriginField;
            }
            set
            {
                this.callerOriginField = value;
            }
        }
        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }
}
