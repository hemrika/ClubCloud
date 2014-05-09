using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GetQuoteProductsFromOpportunityRequest : Request
	{
		private Guid opportunityIdField;
		private Guid quoteIdField;
		[XmlElement(Order = 0)]
		public Guid OpportunityId
		{
			get
			{
				return this.opportunityIdField;
			}
			set
			{
				this.opportunityIdField = value;
				base.RaisePropertyChanged("OpportunityId");
			}
		}
		[XmlElement(Order = 1)]
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
	}
}
