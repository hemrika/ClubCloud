using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class QueryByAttribute : QueryBase
	{
		private string[] attributesField;
		private object[] valuesField;
		private PagingInfo pageInfoField;
		private OrderExpression[] ordersField;
		[XmlArrayItem("Attribute", IsNullable = false)]
		public string[] Attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
			}
		}
		[XmlArrayItem("Value")]
		public object[] Values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
			}
		}
		public PagingInfo PageInfo
		{
			get
			{
				return this.pageInfoField;
			}
			set
			{
				this.pageInfoField = value;
			}
		}
		[XmlArrayItem("Order", IsNullable = false)]
		public OrderExpression[] Orders
		{
			get
			{
				return this.ordersField;
			}
			set
			{
				this.ordersField = value;
			}
		}
	}
}
