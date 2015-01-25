using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlInclude(typeof(TargetRelatedDynamic))]
	[XmlInclude(typeof(TargetRelatedInvoiceToContact))]
	[XmlInclude(typeof(TargetRelatedLeadToAccount))]
	[XmlInclude(typeof(TargetRelatedLeadToContact))]
	[XmlInclude(typeof(TargetRelatedOpportunityToAccount))]
	[XmlInclude(typeof(TargetRelatedOpportunityToCompetitor))]
	[XmlInclude(typeof(TargetRelatedOpportunityToContact))]
	[XmlInclude(typeof(TargetRelatedProductToCompetitor))]
	[XmlInclude(typeof(TargetRelatedProductToLead))]
	[XmlInclude(typeof(TargetRelatedQuoteToContact))]
	[XmlInclude(typeof(TargetRelatedSalesLiteratureToCompetitor))]
	[XmlInclude(typeof(TargetRelatedSalesLiteratureToProduct))]
	[XmlInclude(typeof(TargetRelatedSalesOrderToContact))]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public abstract class TargetRelated : INotifyPropertyChanged
	{
		protected TargetRelated()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}