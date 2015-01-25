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
	public class BulkDeleteRequest : Request
	{
		private QueryBase[] querySetField;

		private string jobNameField;

		private bool sendEmailNotificationField;

		private Guid[] toRecipientsField;

		private Guid[] cCRecipientsField;

		private string recurrencePatternField;

		private CrmDateTime startDateTimeField;

		[XmlArray] //[XmlArray(Order=4)]
		public Guid[] CCRecipients
		{
			get
			{
				return this.cCRecipientsField;
			}
			set
			{
				this.cCRecipientsField = value;
				base.RaisePropertyChanged("CCRecipients");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string JobName
		{
			get
			{
				return this.jobNameField;
			}
			set
			{
				this.jobNameField = value;
				base.RaisePropertyChanged("JobName");
			}
		}

		[XmlArray] //[XmlArray(Order=0)]
		public QueryBase[] QuerySet
		{
			get
			{
				return this.querySetField;
			}
			set
			{
				this.querySetField = value;
				base.RaisePropertyChanged("QuerySet");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public string RecurrencePattern
		{
			get
			{
				return this.recurrencePatternField;
			}
			set
			{
				this.recurrencePatternField = value;
				base.RaisePropertyChanged("RecurrencePattern");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public bool SendEmailNotification
		{
			get
			{
				return this.sendEmailNotificationField;
			}
			set
			{
				this.sendEmailNotificationField = value;
				base.RaisePropertyChanged("SendEmailNotification");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmDateTime StartDateTime
		{
			get
			{
				return this.startDateTimeField;
			}
			set
			{
				this.startDateTimeField = value;
				base.RaisePropertyChanged("StartDateTime");
			}
		}

		[XmlArray] //[XmlArray(Order=3)]
		public Guid[] ToRecipients
		{
			get
			{
				return this.toRecipientsField;
			}
			set
			{
				this.toRecipientsField = value;
				base.RaisePropertyChanged("ToRecipients");
			}
		}

		public BulkDeleteRequest()
		{
		}
	}
}