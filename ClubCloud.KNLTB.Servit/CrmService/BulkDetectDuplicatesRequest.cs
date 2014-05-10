using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class BulkDetectDuplicatesRequest : Request
	{
		private QueryBase queryField;
		private string jobNameField;
		private bool sendEmailNotificationField;
		private Guid templateIdField;
		private Guid[] toRecipientsField;
		private Guid[] cCRecipientsField;
		private string recurrencePatternField;
		private CrmDateTime recurrenceStartTimeField;
		public QueryBase Query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
			}
		}
		public string JobName
		{
			get
			{
				return this.jobNameField;
			}
			set
			{
				this.jobNameField = value;
			}
		}
		public bool SendEmailNotification
		{
			get
			{
				return this.sendEmailNotificationField;
			}
			set
			{
				this.sendEmailNotificationField = value;
			}
		}
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
			}
		}
		public Guid[] ToRecipients
		{
			get
			{
				return this.toRecipientsField;
			}
			set
			{
				this.toRecipientsField = value;
			}
		}
		public Guid[] CCRecipients
		{
			get
			{
				return this.cCRecipientsField;
			}
			set
			{
				this.cCRecipientsField = value;
			}
		}
		public string RecurrencePattern
		{
			get
			{
				return this.recurrencePatternField;
			}
			set
			{
				this.recurrencePatternField = value;
			}
		}
		public CrmDateTime RecurrenceStartTime
		{
			get
			{
				return this.recurrenceStartTimeField;
			}
			set
			{
				this.recurrenceStartTimeField = value;
			}
		}
	}
}
