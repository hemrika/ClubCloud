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
	public class SendTemplateRequest : Request
	{
		private Guid templateIdField;

		private Moniker senderField;

		private string recipientTypeField;

		private Guid[] recipientIdsField;

		private string regardingTypeField;

		private Guid regardingIdField;

		[XmlArray] //[XmlArray(Order=3)]
		public Guid[] RecipientIds
		{
			get
			{
				return this.recipientIdsField;
			}
			set
			{
				this.recipientIdsField = value;
				base.RaisePropertyChanged("RecipientIds");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string RecipientType
		{
			get
			{
				return this.recipientTypeField;
			}
			set
			{
				this.recipientTypeField = value;
				base.RaisePropertyChanged("RecipientType");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Guid RegardingId
		{
			get
			{
				return this.regardingIdField;
			}
			set
			{
				this.regardingIdField = value;
				base.RaisePropertyChanged("RegardingId");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string RegardingType
		{
			get
			{
				return this.regardingTypeField;
			}
			set
			{
				this.regardingTypeField = value;
				base.RaisePropertyChanged("RegardingType");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Moniker Sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
				base.RaisePropertyChanged("Sender");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
				base.RaisePropertyChanged("TemplateId");
			}
		}

		public SendTemplateRequest()
		{
		}
	}
}