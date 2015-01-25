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
	public class ImportTranslationsXmlWithProgressRequest : Request
	{
		private string importXmlField;

		private Guid importJobIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ImportJobId
		{
			get
			{
				return this.importJobIdField;
			}
			set
			{
				this.importJobIdField = value;
				base.RaisePropertyChanged("ImportJobId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public string ImportXml
		{
			get
			{
				return this.importXmlField;
			}
			set
			{
				this.importXmlField = value;
				base.RaisePropertyChanged("ImportXml");
			}
		}

		public ImportTranslationsXmlWithProgressRequest()
		{
		}
	}
}