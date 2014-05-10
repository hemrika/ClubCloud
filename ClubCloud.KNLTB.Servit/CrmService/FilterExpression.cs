using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class FilterExpression
	{
		private LogicalOperator filterOperatorField;
		private ConditionExpression[] conditionsField;
		private FilterExpression[] filtersField;
		public LogicalOperator FilterOperator
		{
			get
			{
				return this.filterOperatorField;
			}
			set
			{
				this.filterOperatorField = value;
			}
		}
		[XmlArrayItem("Condition", IsNullable = false)]
		public ConditionExpression[] Conditions
		{
			get
			{
				return this.conditionsField;
			}
			set
			{
				this.conditionsField = value;
			}
		}
		[XmlArrayItem("Filter", IsNullable = false)]
		public FilterExpression[] Filters
		{
			get
			{
				return this.filtersField;
			}
			set
			{
				this.filtersField = value;
			}
		}
	}
}
