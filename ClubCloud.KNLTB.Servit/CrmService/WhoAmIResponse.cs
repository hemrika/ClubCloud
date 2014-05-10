using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class WhoAmIResponse : Response
	{
		private Guid userIdField;
		private Guid businessUnitIdField;
		private Guid organizationIdField;
		public Guid UserId
		{
			get
			{
				return this.userIdField;
			}
			set
			{
				this.userIdField = value;
			}
		}
		public Guid BusinessUnitId
		{
			get
			{
				return this.businessUnitIdField;
			}
			set
			{
				this.businessUnitIdField = value;
			}
		}
		public Guid OrganizationId
		{
			get
			{
				return this.organizationIdField;
			}
			set
			{
				this.organizationIdField = value;
			}
		}
	}
}
