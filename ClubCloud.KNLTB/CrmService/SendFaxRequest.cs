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
	public class SendFaxRequest : Request
	{
		private Guid faxIdField;

		private bool issueSendField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid FaxId
		{
			get
			{
				return this.faxIdField;
			}
			set
			{
				this.faxIdField = value;
				base.RaisePropertyChanged("FaxId");
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

		public SendFaxRequest()
		{
		}
	}
}