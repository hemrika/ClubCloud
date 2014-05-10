using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ObjectiveRelation
	{
		private Guid resourceSpecIdField;
		private string objectiveExpressionField;
		public Guid ResourceSpecId
		{
			get
			{
				return this.resourceSpecIdField;
			}
			set
			{
				this.resourceSpecIdField = value;
			}
		}
		public string ObjectiveExpression
		{
			get
			{
				return this.objectiveExpressionField;
			}
			set
			{
				this.objectiveExpressionField = value;
			}
		}
	}
}
