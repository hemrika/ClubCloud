using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportCompressedTranslationsXmlWithProgressRequest : Request
	{
		private byte[] compressedTranslationsXmlField;
		private Guid importJobIdField;
		[XmlElement(DataType = "base64Binary")]
		public byte[] CompressedTranslationsXml
		{
			get
			{
				return this.compressedTranslationsXmlField;
			}
			set
			{
				this.compressedTranslationsXmlField = value;
			}
		}
		public Guid ImportJobId
		{
			get
			{
				return this.importJobIdField;
			}
			set
			{
				this.importJobIdField = value;
			}
		}
	}
}