using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlRoot(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsNullable = true), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
	[Serializable]
	public class CrmAuthenticationToken : SoapHeader
	{
		private int authenticationTypeField;
		private string crmTicketField;
		private string organizationNameField;
		private Guid callerIdField;
		public int AuthenticationType
		{
			get
			{
				return this.authenticationTypeField;
			}
			set
			{
				this.authenticationTypeField = value;
			}
		}
		public string CrmTicket
		{
			get
			{
				return this.crmTicketField;
			}
			set
			{
				this.crmTicketField = value;
			}
		}
		public string OrganizationName
		{
			get
			{
				return this.organizationNameField;
			}
			set
			{
				this.organizationNameField = value;
			}
		}
		public Guid CallerId
		{
			get
			{
				return this.callerIdField;
			}
			set
			{
				this.callerIdField = value;
			}
		}
	}
}
