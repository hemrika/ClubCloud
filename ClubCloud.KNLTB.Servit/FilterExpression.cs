using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class FilterExpression : INotifyPropertyChanged
	{
		private LogicalOperator filterOperatorField;
		private ConditionExpression[] conditionsField;
		private FilterExpression[] filtersField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public LogicalOperator FilterOperator
		{
			get
			{
				return this.filterOperatorField;
			}
			set
			{
				this.filterOperatorField = value;
				this.RaisePropertyChanged("FilterOperator");
			}
		}
		[XmlArray(Order = 1), XmlArrayItem("Condition", IsNullable = false)]
		public ConditionExpression[] Conditions
		{
			get
			{
				return this.conditionsField;
			}
			set
			{
				this.conditionsField = value;
				this.RaisePropertyChanged("Conditions");
			}
		}
		[XmlArray(Order = 2), XmlArrayItem("Filter", IsNullable = false)]
		public FilterExpression[] Filters
		{
			get
			{
				return this.filtersField;
			}
			set
			{
				this.filtersField = value;
				this.RaisePropertyChanged("Filters");
			}
		}
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
