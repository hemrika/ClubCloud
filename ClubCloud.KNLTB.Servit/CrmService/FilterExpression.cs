using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Query")]
	public class FilterExpression : INotifyPropertyChanged
	{
		private LogicalOperator filterOperatorField;

		private ConditionExpression[] conditionsField;

		private FilterExpression[] filtersField;

		[XmlArray] //[XmlArray(Order=1)]
		[XmlArrayItem("Condition", IsNullable=false)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlArray] //[XmlArray(Order=2)]
		[XmlArrayItem("Filter", IsNullable=false)]
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

		public FilterExpression()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}