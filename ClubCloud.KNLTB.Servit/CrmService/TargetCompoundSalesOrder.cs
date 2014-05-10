using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCompoundSalesOrder : TargetCompound
	{
		private salesorder salesOrderField;
		private salesorderdetail[] salesOrderDetailsField;
		public salesorder SalesOrder
		{
			get
			{
				return this.salesOrderField;
			}
			set
			{
				this.salesOrderField = value;
			}
		}
		[XmlArrayItem(IsNullable = false)]
		public salesorderdetail[] SalesOrderDetails
		{
			get
			{
				return this.salesOrderDetailsField;
			}
			set
			{
				this.salesOrderDetailsField = value;
			}
		}
	}
}
