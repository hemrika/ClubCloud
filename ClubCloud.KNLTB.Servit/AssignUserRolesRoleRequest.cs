using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class AssignUserRolesRoleRequest : Request
	{
		private Guid userIdField;
		private Guid[] roleIdsField;
		[XmlElement(Order = 0)]
		public Guid UserId
		{
			get
			{
				return this.userIdField;
			}
			set
			{
				this.userIdField = value;
				base.RaisePropertyChanged("UserId");
			}
		}
		[XmlArray(Order = 1)]
		public Guid[] RoleIds
		{
			get
			{
				return this.roleIdsField;
			}
			set
			{
				this.roleIdsField = value;
				base.RaisePropertyChanged("RoleIds");
			}
		}
	}
}
