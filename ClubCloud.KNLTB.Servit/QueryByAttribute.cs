using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class QueryByAttribute : QueryBase
	{
		private string[] attributesField;
		private object[] valuesField;
		private PagingInfo pageInfoField;
		private OrderExpression[] ordersField;
		[XmlArray(Order = 0), XmlArrayItem("Attribute", IsNullable = false)]
		public string[] Attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
				base.RaisePropertyChanged("Attributes");
			}
		}
		[XmlArray(Order = 1), XmlArrayItem("Value")]
		public object[] Values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
				base.RaisePropertyChanged("Values");
			}
		}
		[XmlElement(Order = 2)]
		public PagingInfo PageInfo
		{
			get
			{
				return this.pageInfoField;
			}
			set
			{
				this.pageInfoField = value;
				base.RaisePropertyChanged("PageInfo");
			}
		}
		[XmlArray(Order = 3), XmlArrayItem("Order", IsNullable = false)]
		public OrderExpression[] Orders
		{
			get
			{
				return this.ordersField;
			}
			set
			{
				this.ordersField = value;
				base.RaisePropertyChanged("Orders");
			}
		}
	}
}
