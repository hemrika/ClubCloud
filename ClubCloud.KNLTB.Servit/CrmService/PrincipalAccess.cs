using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/CoreTypes")]
	[Serializable]
	public class PrincipalAccess
	{
		private SecurityPrincipal principalField;
		private AccessRights accessMaskField;
		public SecurityPrincipal Principal
		{
			get
			{
				return this.principalField;
			}
			set
			{
				this.principalField = value;
			}
		}
		public AccessRights AccessMask
		{
			get
			{
				return this.accessMaskField;
			}
			set
			{
				this.accessMaskField = value;
			}
		}
	}
}
