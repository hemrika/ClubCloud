using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateQuoteRequest : Request
	{
		private Guid entityIdField;
		private QuoteState quoteStateField;
		private int quoteStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public QuoteState QuoteState
		{
			get
			{
				return this.quoteStateField;
			}
			set
			{
				this.quoteStateField = value;
			}
		}
		public int QuoteStatus
		{
			get
			{
				return this.quoteStatusField;
			}
			set
			{
				this.quoteStatusField = value;
			}
		}
	}
}
