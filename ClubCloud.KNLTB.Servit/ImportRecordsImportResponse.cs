using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportRecordsImportResponse : Response
	{
		private Guid asyncOperationIdField;
		[XmlElement(Order = 0)]
		public Guid AsyncOperationId
		{
			get
			{
				return this.asyncOperationIdField;
			}
			set
			{
				this.asyncOperationIdField = value;
				base.RaisePropertyChanged("AsyncOperationId");
			}
		}
	}
}
