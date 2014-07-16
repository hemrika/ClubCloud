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
	public class ReviseQuoteRequest : Request
	{
		private Guid quoteIdField;

		private ColumnSetBase columnSetField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=1)]
		public ColumnSetBase ColumnSet
		{
			get
			{
				return this.columnSetField;
			}
			set
			{
				this.columnSetField = value;
				base.RaisePropertyChanged("ColumnSet");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid QuoteId
		{
			get
			{
				return this.quoteIdField;
			}
			set
			{
				this.quoteIdField = value;
				base.RaisePropertyChanged("QuoteId");
			}
		}

		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}

		public ReviseQuoteRequest()
		{
		}
	}
}