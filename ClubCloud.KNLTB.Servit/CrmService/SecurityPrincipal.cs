using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/CoreTypes")]
	[Serializable]
	public class SecurityPrincipal
	{
		private Guid principalIdField;
		private SecurityPrincipalType typeField;
		public Guid PrincipalId
		{
			get
			{
				return this.principalIdField;
			}
			set
			{
				this.principalIdField = value;
			}
		}
		public SecurityPrincipalType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
	}
}
