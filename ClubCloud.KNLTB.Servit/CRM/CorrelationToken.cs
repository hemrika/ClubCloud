using ClubCloud.KNLTB.Servit.CRM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.Servit.CRM
{
    [XmlRoot(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsNullable = true), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
    [Serializable]
    public class CorrelationToken : SoapHeader
    {
        private Guid correlationIdField;
        private CrmDateTime correlationUpdatedTimeField;
        private int depthField;
        public Guid CorrelationId
        {
            get
            {
                return this.correlationIdField;
            }
            set
            {
                this.correlationIdField = value;
            }
        }
        public CrmDateTime CorrelationUpdatedTime
        {
            get
            {
                return this.correlationUpdatedTimeField;
            }
            set
            {
                this.correlationUpdatedTimeField = value;
            }
        }
        public int Depth
        {
            get
            {
                return this.depthField;
            }
            set
            {
                this.depthField = value;
            }
        }
    }
}
