using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SearchByKeywordsKbArticleRequest : Request
	{
		private string searchTextField;
		private Guid subjectIdField;
		private ColumnSetBase columnSetField;
		private bool returnDynamicEntitiesField;
		[XmlElement(Order = 0)]
		public string SearchText
		{
			get
			{
				return this.searchTextField;
			}
			set
			{
				this.searchTextField = value;
				base.RaisePropertyChanged("SearchText");
			}
		}
		[XmlElement(Order = 1)]
		public Guid SubjectId
		{
			get
			{
				return this.subjectIdField;
			}
			set
			{
				this.subjectIdField = value;
				base.RaisePropertyChanged("SubjectId");
			}
		}
		[XmlElement(Order = 2)]
		public ColumnSetBase ColumnSet
		{
			get
			{
				return this.columnSetField;
			}
			set
			{
				this.columnSetField = value;
				base.RaisePropertyChanged("ColumnSet");
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
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}
	}
}
