using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateQuoteCloseRequest : Request
	{
		private Guid entityIdField;
		private QuoteCloseState quoteCloseStateField;
		private int quoteCloseStatusField;
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
		public QuoteCloseState QuoteCloseState
		{
			get
			{
				return this.quoteCloseStateField;
			}
			set
			{
				this.quoteCloseStateField = value;
			}
		}
		public int QuoteCloseStatus
		{
			get
			{
				return this.quoteCloseStatusField;
			}
			set
			{
				this.quoteCloseStatusField = value;
			}
		}
	}
}
