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
	public class TargetCreateSalesOrderDetail : TargetCreate
	{
		private salesorderdetail salesOrderDetailField;

		[XmlElement] //[XmlElement(Order=0)]
		public salesorderdetail SalesOrderDetail
		{
			get
			{
				return this.salesOrderDetailField;
			}
			set
			{
				this.salesOrderDetailField = value;
				base.RaisePropertyChanged("SalesOrderDetail");
			}
		}

		public TargetCreateSalesOrderDetail()
		{
		}
	}
}