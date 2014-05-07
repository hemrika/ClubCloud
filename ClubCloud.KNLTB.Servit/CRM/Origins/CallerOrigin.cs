using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.Servit.CRM.Origins

{
    [XmlInclude(typeof(AsyncServiceOrigin)), XmlInclude(typeof(WebServiceApiOrigin)), XmlInclude(typeof(OfflineOrigin)), XmlInclude(typeof(ApplicationOrigin)), XmlInclude(typeof(WebServiceApiOrigin)), XmlInclude(typeof(ApplicationOrigin)), XmlInclude(typeof(OfflineOrigin)), XmlInclude(typeof(AsyncServiceOrigin)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
    [Serializable]
    public abstract class CallerOrigin
    {
    }
}
