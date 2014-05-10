using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SendEmailRequest : Request
	{
		private Guid emailIdField;
		private bool issueSendField;
		private string trackingTokenField;
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
		public bool IssueSend
		{
			get
			{
				return this.issueSendField;
			}
			set
			{
				this.issueSendField = value;
			}
		}
		public string TrackingToken
		{
			get
			{
				return this.trackingTokenField;
			}
			set
			{
				this.trackingTokenField = value;
			}
		}
	}
}
