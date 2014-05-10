using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SendFaxRequest : Request
	{
		private Guid faxIdField;
		private bool issueSendField;
		public Guid FaxId
		{
			get
			{
				return this.faxIdField;
			}
			set
			{
				this.faxIdField = value;
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
	}
}
