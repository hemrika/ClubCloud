using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateUserQueryRequest : Request
	{
		private Guid entityIdField;
		private UserQueryState userQueryStateField;
		private int userQueryStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public UserQueryState UserQueryState
		{
			get
			{
				return this.userQueryStateField;
			}
			set
			{
				this.userQueryStateField = value;
			}
		}
		public int UserQueryStatus
		{
			get
			{
				return this.userQueryStatusField;
			}
			set
			{
				this.userQueryStatusField = value;
			}
		}
	}
}
