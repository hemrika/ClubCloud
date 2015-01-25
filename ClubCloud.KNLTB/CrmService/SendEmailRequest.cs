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
	public class SendEmailRequest : Request
	{
		private Guid emailIdField;

		private bool issueSendField;

		private string trackingTokenField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public bool IssueSend
		{
			get
			{
				return this.issueSendField;
			}
			set
			{
				this.issueSendField = value;
				base.RaisePropertyChanged("IssueSend");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string TrackingToken
		{
			get
			{
				return this.trackingTokenField;
			}
			set
			{
				this.trackingTokenField = value;
				base.RaisePropertyChanged("TrackingToken");
			}
		}

		public SendEmailRequest()
		{
		}
	}
}