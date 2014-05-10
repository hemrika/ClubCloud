using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/CoreTypes")]
	[Serializable]
	public class RolePrivilege
	{
		private PrivilegeDepth depthField;
		private Guid privilegeIdField;
		public PrivilegeDepth Depth
		{
			get
			{
				return this.depthField;
			}
			set
			{
				this.depthField = value;
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
