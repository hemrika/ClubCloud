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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Scheduling")]
	public class ObjectiveRelation : INotifyPropertyChanged
	{
		private Guid resourceSpecIdField;

		private string objectiveExpressionField;

		[XmlElement] //[XmlElement(Order=1)]
		public string ObjectiveExpression
		{
			get
			{
				return this.objectiveExpressionField;
			}
			set
			{
				this.objectiveExpressionField = value;
				this.RaisePropertyChanged("ObjectiveExpression");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid ResourceSpecId
		{
			get
			{
				return this.resourceSpecIdField;
			}
			set
			{
				this.resourceSpecIdField = value;
				this.RaisePropertyChanged("ResourceSpecId");
			}
		}

		public ObjectiveRelation()
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