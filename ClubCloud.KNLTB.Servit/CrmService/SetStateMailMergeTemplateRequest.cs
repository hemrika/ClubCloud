using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateMailMergeTemplateRequest : Request
	{
		private Guid entityIdField;
		private MailMergeTemplateState mailMergeTemplateStateField;
		private int mailMergeTemplateStatusField;
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
		public MailMergeTemplateState MailMergeTemplateState
		{
			get
			{
				return this.mailMergeTemplateStateField;
			}
			set
			{
				this.mailMergeTemplateStateField = value;
			}
		}
		public int MailMergeTemplateStatus
		{
			get
			{
				return this.mailMergeTemplateStatusField;
			}
			set
			{
				this.mailMergeTemplateStatusField = value;
			}
		}
	}
}
