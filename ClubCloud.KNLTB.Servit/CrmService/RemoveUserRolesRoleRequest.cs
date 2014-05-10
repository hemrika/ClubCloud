using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RemoveUserRolesRoleRequest : Request
	{
		private Guid userIdField;
		private Guid[] roleIdsField;
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
		public Guid[] RoleIds
		{
			get
			{
				return this.roleIdsField;
			}
			set
			{
				this.roleIdsField = value;
			}
		}
	}
}
