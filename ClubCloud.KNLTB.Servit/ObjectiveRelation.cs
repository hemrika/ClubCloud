using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ObjectiveRelation : INotifyPropertyChanged
	{
		private Guid resourceSpecIdField;
		private string objectiveExpressionField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
