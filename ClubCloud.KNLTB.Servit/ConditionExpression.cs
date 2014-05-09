using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class ConditionExpression : INotifyPropertyChanged
	{
		private string attributeNameField;
		private ConditionOperator operatorField;
		private object[] valuesField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public string AttributeName
		{
			get
			{
				return this.attributeNameField;
			}
			set
			{
				this.attributeNameField = value;
				this.RaisePropertyChanged("AttributeName");
			}
		}
		[XmlElement(Order = 1)]
		public ConditionOperator Operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.operatorField = value;
				this.RaisePropertyChanged("Operator");
			}
		}
		[XmlArray(Order = 2), XmlArrayItem("Value")]
		public object[] Values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
				this.RaisePropertyChanged("Values");
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
