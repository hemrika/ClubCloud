using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ReplacePrivilegesRoleRequest : Request
	{
		private Guid roleIdField;
		private RolePrivilege[] privilegesField;
		[XmlElement(Order = 0)]
		public Guid RoleId
		{
			get
			{
				return this.roleIdField;
			}
			set
			{
				this.roleIdField = value;
				base.RaisePropertyChanged("RoleId");
			}
		}
		[XmlArray(Order = 1)]
		public RolePrivilege[] Privileges
		{
			get
			{
				return this.privilegesField;
			}
			set
			{
				this.privilegesField = value;
				base.RaisePropertyChanged("Privileges");
			}
		}
	}
}
