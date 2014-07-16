using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SearchByTitleKbArticleRequest : Request
	{
		private string searchTextField;

		private Guid subjectIdField;

		private ColumnSetBase columnSetField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		public SearchByTitleKbArticleRequest()
		{
		}
	}
}