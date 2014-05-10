using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SendTemplateRequest : Request
	{
		private Guid templateIdField;
		private Moniker senderField;
		private string recipientTypeField;
		private Guid[] recipientIdsField;
		private string regardingTypeField;
		private Guid regardingIdField;
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
			}
		}
		public Moniker Sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
			}
		}
		public string RecipientType
		{
			get
			{
				return this.recipientTypeField;
			}
			set
			{
				this.recipientTypeField = value;
			}
		}
		public Guid[] RecipientIds
		{
			get
			{
				return this.recipientIdsField;
			}
			set
			{
				this.recipientIdsField = value;
			}
		}
		public string RegardingType
		{
			get
			{
				return this.regardingTypeField;
			}
			set
			{
				this.regardingTypeField = value;
			}
		}
		public Guid RegardingId
		{
			get
			{
				return this.regardingIdField;
			}
			set
			{
				this.regardingIdField = value;
			}
		}
	}
}
