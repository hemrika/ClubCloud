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
	public class CheckIncomingEmailRequest : Request
	{
		private string messageIdField;

		private string subjectField;

		private string fromField;

		private string toField;

		private string ccField;

		private string bccField;

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		public CheckIncomingEmailRequest()
		{
		}
	}
}