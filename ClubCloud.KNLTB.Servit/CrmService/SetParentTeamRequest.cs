using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetParentTeamRequest : Request
	{
		private Guid teamIdField;
		private Guid businessIdField;
		public Guid TeamId
		{
			get
			{
				return this.teamIdField;
			}
			set
			{
				this.teamIdField = value;
			}
		}
		public Guid BusinessId
		{
			get
			{
				return this.businessIdField;
			}
			set
			{
				this.businessIdField = value;
			}
		}
	}
}