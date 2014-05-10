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
		public Guid EmailId
		{
			get
			{
				return this.emailIdField;
			}
			set
			{
				this.emailIdField = value;
			}
		}
		public string MessageId
		{
			get
			{
				return this.messageIdField;
			}
			set
			{
				this.messageIdField = value;
			}
		}
		public string Subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}
		public string From
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
			}
		}
		public string To
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
			}
		}
		public string Cc
		{
			get
			{
				return this.ccField;
			}
			set
			{
				this.ccField = value;
			}
		}
		public string Bcc
		{
			get
			{
				return this.bccField;
			}
			set
			{
				this.bccField = value;
			}
		}
		public CrmDateTime ReceivedOn
		{
			get
			{
				return this.receivedOnField;
			}
			set
			{
				this.receivedOnField = value;
			}
		}
		public string SubmittedBy
		{
			get
			{
				return this.submittedByField;
			}
			set
			{
				this.submittedByField = value;
			}
		}
		public string Importance
		{
			get
			{
				return this.importanceField;
			}
			set
			{
				this.importanceField = value;
			}
		}
		public string Body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
			}
		}
		public BusinessEntityCollection Attachments
		{
			get
			{
				return this.attachmentsField;
			}
			set
			{
				this.attachmentsField = value;
			}
		}
	}
}
