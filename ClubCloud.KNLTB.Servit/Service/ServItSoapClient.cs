using ClubCloud.KNLTB.Servit.CRM;
using ClubCloud.KNLTB.Servit.CRM.Entities;
using ClubCloud.KNLTB.Servit.CRM.Properties;
using ClubCloud.KNLTB.Servit.CRM.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.Servit
{
    [WebServiceBinding(Name = "CrmServiceSoap", Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlInclude(typeof(Property[])), XmlInclude(typeof(activityparty[])), XmlInclude(typeof(CrmReference))]
    public class ServItSoapClient : SoapHttpClientProtocol //System.ServiceModel.ClientBase<ServItSoap>, ServItSoap
    {
        private CrmAuthenticationToken crmAuthenticationTokenValueField;
        private CallerOriginToken callerOriginTokenValueField;
        private CorrelationToken correlationTokenValueField;

        public CrmAuthenticationToken CrmAuthenticationTokenValue
        {
            get
            {
                return this.crmAuthenticationTokenValueField;
            }
            set
            {
                this.crmAuthenticationTokenValueField = value;
            }
        }
    }
}
