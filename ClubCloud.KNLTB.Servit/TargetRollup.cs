using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(TargetRollupAnnotationByOpportunity)), XmlInclude(typeof(TargetRollupDynamic)), XmlInclude(typeof(TargetRollupContractByContact)), XmlInclude(typeof(TargetRollupSalesOrderByContact)), XmlInclude(typeof(TargetRollupSalesOrderByAccount)), XmlInclude(typeof(TargetRollupQuoteByContact)), XmlInclude(typeof(TargetRollupQuoteByAccount)), XmlInclude(typeof(TargetRollupOpportunityByContact)), XmlInclude(typeof(TargetRollupOpportunityByAccount)), XmlInclude(typeof(TargetRollupInvoiceByContact)), XmlInclude(typeof(TargetRollupInvoiceByAccount)), XmlInclude(typeof(TargetRollupIncidentByContact)), XmlInclude(typeof(TargetRollupIncidentByAccount)), XmlInclude(typeof(TargetRollupContractByAccount)), XmlInclude(typeof(TargetRollupAnnotationByContact)), XmlInclude(typeof(TargetRollupAnnotationByAccount)), XmlInclude(typeof(TargetRollupActivityPointerByOpportunity)), XmlInclude(typeof(TargetRollupActivityPointerByContact)), XmlInclude(typeof(TargetRollupActivityPointerByAccount)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class TargetRollup : INotifyPropertyChanged
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
