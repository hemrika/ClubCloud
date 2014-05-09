using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class DeliverPromoteEmailRequest : Request
	{
		private Guid emailIdField;
		private string messageIdField;
		private string subjectField;
		private string fromField;
		private string toField;
		private string ccField;
		private string bccField;
		private CrmDateTime receivedOnField;
		private string submittedByField;
		private string importanceField;
		private string bodyField;
		private BusinessEntityCollection attachmentsField;
		[XmlElement(Order = 0)]
		public Guid EmailId
		{
			get
			{
				return this.emailIdField;
			}
			set
			{
				this.emailIdField = value;
				base.RaisePropertyChanged("EmailId");
			}
		}
		[XmlElement(Order = 1)]
		public string MessageId
		{
			get
			{
				return this.messageIdField;
			}
			set
			{
				this.messageIdField = value;
				base.RaisePropertyChanged("MessageId");
			}
		}
		[XmlElement(Order = 2)]
		public string Subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
				base.RaisePropertyChanged("Subject");
			}
		}
		[XmlElement(Order = 3)]
		public string From
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
				base.RaisePropertyChanged("From");
			}
		}
		[XmlElement(Order = 4)]
		public string To
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
				base.RaisePropertyChanged("To");
			}
		}
		[XmlElement(Order = 5)]
		public string Cc
		{
			get
			{
				return this.ccField;
			}
			set
			{
				this.ccField = value;
				base.RaisePropertyChanged("Cc");
			}
		}
		[XmlElement(Order = 6)]
		public string Bcc
		{
			get
			{
				return this.bccField;
			}
			set
			{
				this.bccField = value;
				base.RaisePropertyChanged("Bcc");
			}
		}
		[XmlElement(Order = 7)]
		public CrmDateTime ReceivedOn
		{
			get
			{
				return this.receivedOnField;
			}
			set
			{
				this.receivedOnField = value;
				base.RaisePropertyChanged("ReceivedOn");
			}
		}
		[XmlElement(Order = 8)]
		public string SubmittedBy
		{
			get
			{
				return this.submittedByField;
			}
			set
			{
				this.submittedByField = value;
				base.RaisePropertyChanged("SubmittedBy");
			}
		}
		[XmlElement(Order = 9)]
		public string Importance
		{
			get
			{
				return this.importanceField;
			}
			set
			{
				this.importanceField = value;
				base.RaisePropertyChanged("Importance");
			}
		}
		[XmlElement(Order = 10)]
		public string Body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
				base.RaisePropertyChanged("Body");
			}
		}
		[XmlElement(Order = 11)]
		public BusinessEntityCollection Attachments
		{
			get
			{
				return this.attachmentsField;
			}
			set
			{
				this.attachmentsField = value;
				base.RaisePropertyChanged("Attachments");
			}
		}
	}
}
