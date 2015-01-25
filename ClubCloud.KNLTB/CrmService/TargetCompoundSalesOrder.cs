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
	public class TargetCompoundSalesOrder : TargetCompound
	{
		private salesorder salesOrderField;

		private salesorderdetail[] salesOrderDetailsField;

		[XmlElement] //[XmlElement(Order=0)]
		public salesorder SalesOrder
		{
			get
			{
				return this.salesOrderField;
			}
			set
			{
				this.salesOrderField = value;
				base.RaisePropertyChanged("SalesOrder");
			}
		}

		[XmlArray] //[XmlArray(Order=1)]
		[XmlArrayItem(IsNullable=false)]
		public salesorderdetail[] SalesOrderDetails
		{
			get
			{
				return this.salesOrderDetailsField;
			}
			set
			{
				this.salesOrderDetailsField = value;
				base.RaisePropertyChanged("SalesOrderDetails");
			}
		}

		public TargetCompoundSalesOrder()
		{
		}
	}
}