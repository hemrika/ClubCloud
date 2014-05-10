using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateEmailRequest : Request
	{
		private Guid entityIdField;
		private EmailState emailStateField;
		private int emailStatusField;
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
		public EmailState EmailState
		{
			get
			{
				return this.emailStateField;
			}
			set
			{
				this.emailStateField = value;
			}
		}
		public int EmailStatus
		{
			get
			{
				return this.emailStatusField;
			}
			set
			{
				this.emailStatusField = value;
			}
		}
	}
}
