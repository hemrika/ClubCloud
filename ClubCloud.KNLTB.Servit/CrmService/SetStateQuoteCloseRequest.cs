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
	public class SetStateQuoteCloseRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.QuoteCloseState quoteCloseStateField;

		private int quoteCloseStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.QuoteCloseState QuoteCloseState
		{
			get
			{
				return this.quoteCloseStateField;
			}
			set
			{
				this.quoteCloseStateField = value;
				base.RaisePropertyChanged("QuoteCloseState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int QuoteCloseStatus
		{
			get
			{
				return this.quoteCloseStatusField;
			}
			set
			{
				this.quoteCloseStatusField = value;
				base.RaisePropertyChanged("QuoteCloseStatus");
			}
		}

		public SetStateQuoteCloseRequest()
		{
		}
	}
}