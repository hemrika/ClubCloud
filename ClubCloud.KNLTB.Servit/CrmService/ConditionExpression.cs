using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class ConditionExpression
	{
		private string attributeNameField;
		private ConditionOperator operatorField;
		private object[] valuesField;
		public string AttributeName
		{
			get
			{
				return this.attributeNameField;
			}
			set
			{
				this.attributeNameField = value;
			}
		}
		public ConditionOperator Operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.operatorField = value;
			}
		}
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
			}
		}
	}
}
