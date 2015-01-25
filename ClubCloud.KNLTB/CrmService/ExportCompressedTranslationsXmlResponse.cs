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
	public class ExportCompressedTranslationsXmlResponse : Response
	{
		private byte[] exportCompressedXmlField;

		[XmlElement(DataType="base64Binary")] //, Order=0)]
		public byte[] ExportCompressedXml
		{
			get
			{
				return this.exportCompressedXmlField;
			}
			set
			{
				this.exportCompressedXmlField = value;
				base.RaisePropertyChanged("ExportCompressedXml");
			}
		}

		public ExportCompressedTranslationsXmlResponse()
		{
		}
	}
}