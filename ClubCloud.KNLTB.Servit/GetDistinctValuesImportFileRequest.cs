using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GetDistinctValuesImportFileRequest : Request
	{
		private Guid importFileIdField;
		private int columnNumberField;
		private int pageNumberField;
		private int recordsPerPageField;
		[XmlElement(Order = 0)]
		public Guid ImportFileId
		{
			get
			{
				return this.importFileIdField;
			}
			set
			{
				this.importFileIdField = value;
				base.RaisePropertyChanged("ImportFileId");
			}
		}
		[XmlElement(Order = 1)]
		public int columnNumber
		{
			get
			{
				return this.columnNumberField;
			}
			set
			{
				this.columnNumberField = value;
				base.RaisePropertyChanged("columnNumber");
			}
		}
		[XmlElement(Order = 2)]
		public int pageNumber
		{
			get
			{
				return this.pageNumberField;
			}
			set
			{
				this.pageNumberField = value;
				base.RaisePropertyChanged("pageNumber");
			}
		}
		[XmlElement(Order = 3)]
		public int recordsPerPage
		{
			get
			{
				return this.recordsPerPageField;
			}
			set
			{
				this.recordsPerPageField = value;
				base.RaisePropertyChanged("recordsPerPage");
			}
		}
	}
}
