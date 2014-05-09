using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class QueryExpression : QueryBase
	{
		private bool distinctField;
		private PagingInfo pageInfoField;
		private LinkEntity[] linkEntitiesField;
		private FilterExpression criteriaField;
		private OrderExpression[] ordersField;
		[XmlElement(Order = 0)]
		public bool Distinct
		{
			get
			{
				return this.distinctField;
			}
			set
			{
				this.distinctField = value;
				base.RaisePropertyChanged("Distinct");
			}
		}
		[XmlElement(Order = 1)]
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
		[XmlArray(Order = 2), XmlArrayItem(IsNullable = false)]
		public LinkEntity[] LinkEntities
		{
			get
			{
				return this.linkEntitiesField;
			}
			set
			{
				this.linkEntitiesField = value;
				base.RaisePropertyChanged("LinkEntities");
			}
		}
		[XmlElement(Order = 3)]
		public FilterExpression Criteria
		{
			get
			{
				return this.criteriaField;
			}
			set
			{
				this.criteriaField = value;
				base.RaisePropertyChanged("Criteria");
			}
		}
		[XmlArray(Order = 4), XmlArrayItem("Order", IsNullable = false)]
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
