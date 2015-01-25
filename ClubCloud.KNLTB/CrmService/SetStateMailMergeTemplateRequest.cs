using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateMailMergeTemplateRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.MailMergeTemplateState mailMergeTemplateStateField;

		private int mailMergeTemplateStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.MailMergeTemplateState MailMergeTemplateState
		{
			get
			{
				return this.mailMergeTemplateStateField;
			}
			set
			{
				this.mailMergeTemplateStateField = value;
				base.RaisePropertyChanged("MailMergeTemplateState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int MailMergeTemplateStatus
		{
			get
			{
				return this.mailMergeTemplateStatusField;
			}
			set
			{
				this.mailMergeTemplateStatusField = value;
				base.RaisePropertyChanged("MailMergeTemplateStatus");
			}
		}

		public SetStateMailMergeTemplateRequest()
		{
		}
	}
}