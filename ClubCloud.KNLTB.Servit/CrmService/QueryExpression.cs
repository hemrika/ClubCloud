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
		public bool Distinct
		{
			get
			{
				return this.distinctField;
			}
			set
			{
				this.distinctField = value;
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
		[XmlArrayItem(IsNullable = false)]
		public LinkEntity[] LinkEntities
		{
			get
			{
				return this.linkEntitiesField;
			}
			set
			{
				this.linkEntitiesField = value;
			}
		}
		public FilterExpression Criteria
		{
			get
			{
				return this.criteriaField;
			}
			set
			{
				this.criteriaField = value;
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
