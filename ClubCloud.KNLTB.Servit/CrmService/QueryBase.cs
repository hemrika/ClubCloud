using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(QueryByAttribute)), XmlInclude(typeof(QueryExpression)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public abstract class QueryBase
	{
		private string entityNameField;
		private ColumnSetBase columnSetField;
		public string EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
			}
		}
		public ColumnSetBase ColumnSet
		{
			get
			{
				return this.columnSetField;
			}
			set
			{
				this.columnSetField = value;
			}
		}
	}
}
