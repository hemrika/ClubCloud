using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(TargetRelatedSalesLiteratureToCompetitor)), XmlInclude(typeof(TargetRelatedSalesOrderToContact)), XmlInclude(typeof(TargetRelatedSalesLiteratureToProduct)), XmlInclude(typeof(TargetRelatedOpportunityToAccount)), XmlInclude(typeof(TargetRelatedQuoteToContact)), XmlInclude(typeof(TargetRelatedProductToLead)), XmlInclude(typeof(TargetRelatedProductToCompetitor)), XmlInclude(typeof(TargetRelatedOpportunityToContact)), XmlInclude(typeof(TargetRelatedOpportunityToCompetitor)), XmlInclude(typeof(TargetRelatedInvoiceToContact)), XmlInclude(typeof(TargetRelatedLeadToContact)), XmlInclude(typeof(TargetRelatedLeadToAccount)), XmlInclude(typeof(TargetRelatedDynamic)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class TargetRelated : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
