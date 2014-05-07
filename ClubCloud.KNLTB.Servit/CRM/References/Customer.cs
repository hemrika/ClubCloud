using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.Servit.CRM.References
{
    [XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
    [Serializable]
    public class Customer : CrmReference
    {
    }
}
