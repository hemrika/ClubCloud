using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetParentSystemUserRequest : Request
	{
		private Guid userIdField;
		private Guid parentIdField;
		private bool keepChildUsersField;
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
		public Guid ParentId
		{
			get
			{
				return this.parentIdField;
			}
			set
			{
				this.parentIdField = value;
			}
		}
		public bool KeepChildUsers
		{
			get
			{
				return this.keepChildUsersField;
			}
			set
			{
				this.keepChildUsersField = value;
			}
		}
	}
}
