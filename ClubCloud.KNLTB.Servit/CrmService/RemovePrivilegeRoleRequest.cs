using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RemovePrivilegeRoleRequest : Request
	{
		private Guid roleIdField;
		private Guid privilegeIdField;
		public Guid RoleId
		{
			get
			{
				return this.roleIdField;
			}
			set
			{
				this.roleIdField = value;
			}
		}
		public Guid PrivilegeId
		{
			get
			{
				return this.privilegeIdField;
			}
			set
			{
				this.privilegeIdField = value;
			}
		}
	}
}