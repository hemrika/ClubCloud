using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SearchByKeywordsKbArticleRequest : Request
	{
		private string searchTextField;
		private Guid subjectIdField;
		private ColumnSetBase columnSetField;
		private bool returnDynamicEntitiesField;
		public string SearchText
		{
			get
			{
				return this.searchTextField;
			}
			set
			{
				this.searchTextField = value;
			}
		}
		public Guid SubjectId
		{
			get
			{
				return this.subjectIdField;
			}
			set
			{
				this.subjectIdField = value;
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
		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
			}
		}
	}
}
