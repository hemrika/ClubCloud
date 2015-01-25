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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Query")]
	public class QueryByAttribute : QueryBase
	{
		private string[] attributesField;

		private object[] valuesField;

		private PagingInfo pageInfoField;

		private OrderExpression[] ordersField;

		[XmlArray] //[XmlArray(Order=0)]
		[XmlArrayItem("Attribute", IsNullable=false)]
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

		[XmlArray] //[XmlArray(Order=3)]
		[XmlArrayItem("Order", IsNullable=false)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlArray] //[XmlArray(Order=1)]
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
				base.RaisePropertyChanged("Values");
			}
		}

		public QueryByAttribute()
		{
		}
	}
}