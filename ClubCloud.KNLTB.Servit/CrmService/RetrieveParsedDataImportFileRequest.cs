using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveParsedDataImportFileRequest : Request
	{
		private Guid importFileIdField;
		private PagingInfo pagingInfoField;
		public Guid ImportFileId
		{
			get
			{
				return this.importFileIdField;
			}
			set
			{
				this.importFileIdField = value;
			}
		}
		public PagingInfo PagingInfo
		{
			get
			{
				return this.pagingInfoField;
			}
			set
			{
				this.pagingInfoField = value;
			}
		}
	}
}
