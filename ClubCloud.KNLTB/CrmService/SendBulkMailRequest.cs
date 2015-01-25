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
	public class SendBulkMailRequest : Request
	{
		private Moniker senderField;

		private Guid templateIdField;

		private string regardingTypeField;

		private Guid regardingIdField;

		private QueryBase queryField;

		[XmlElement] //[XmlElement(Order=4)]
		public QueryBase Query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
				base.RaisePropertyChanged("Query");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		public SendBulkMailRequest()
		{
		}
	}
}