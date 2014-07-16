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
	public class RetrieveParsedDataImportFileRequest : Request
	{
		private Guid importFileIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.PagingInfo pagingInfoField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.PagingInfo PagingInfo
		{
			get
			{
				return this.pagingInfoField;
			}
			set
			{
				this.pagingInfoField = value;
				base.RaisePropertyChanged("PagingInfo");
			}
		}

		public RetrieveParsedDataImportFileRequest()
		{
		}
	}
}