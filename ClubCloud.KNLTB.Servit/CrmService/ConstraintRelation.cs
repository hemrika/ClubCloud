using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ConstraintRelation
	{
		private Guid objectIdField;
		private string constraintTypeField;
		private string constraintsField;
		public Guid ObjectId
		{
			get
			{
				return this.objectIdField;
			}
			set
			{
				this.objectIdField = value;
			}
		}
		public string ConstraintType
		{
			get
			{
				return this.constraintTypeField;
			}
			set
			{
				this.constraintTypeField = value;
			}
		}
		public string Constraints
		{
			get
			{
				return this.constraintsField;
			}
			set
			{
				this.constraintsField = value;
			}
		}
	}
}
