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
	public class TargetRelatedQuoteToContact : TargetRelated
	{
		private Guid quoteIdField;

		private Guid contactIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ContactId
		{
			get
			{
				return this.contactIdField;
			}
			set
			{
				this.contactIdField = value;
				base.RaisePropertyChanged("ContactId");
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

		public TargetRelatedQuoteToContact()
		{
		}
	}
}