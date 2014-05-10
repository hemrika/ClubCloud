using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class BulkDeleteRequest : Request
	{
		private QueryBase[] querySetField;
		private string jobNameField;
		private bool sendEmailNotificationField;
		private Guid[] toRecipientsField;
		private Guid[] cCRecipientsField;
		private string recurrencePatternField;
		private CrmDateTime startDateTimeField;
		public QueryBase[] QuerySet
		{
			get
			{
				return this.querySetField;
			}
			set
			{
				this.querySetField = value;
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
		public CrmDateTime StartDateTime
		{
			get
			{
				return this.startDateTimeField;
			}
			set
			{
				this.startDateTimeField = value;
			}
		}
	}
}
