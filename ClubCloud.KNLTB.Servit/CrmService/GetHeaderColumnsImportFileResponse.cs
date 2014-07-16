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
	public class GetHeaderColumnsImportFileResponse : Response
	{
		private string[] columnsField;

		[XmlArray] //[XmlArray(Order=0)]
		public string[] Columns
		{
			get
			{
				return this.columnsField;
			}
			set
			{
				this.columnsField = value;
				base.RaisePropertyChanged("Columns");
			}
		}

		public GetHeaderColumnsImportFileResponse()
		{
		}
	}
}