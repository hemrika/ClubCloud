using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportCompressedTranslationsXmlWithProgressRequest : Request
	{
		private byte[] compressedTranslationsXmlField;
		private Guid importJobIdField;
		[XmlElement(DataType = "base64Binary", Order = 0)]
		public byte[] CompressedTranslationsXml
		{
			get
			{
				return this.compressedTranslationsXmlField;
			}
			set
			{
				this.compressedTranslationsXmlField = value;
				base.RaisePropertyChanged("CompressedTranslationsXml");
			}
		}
		[XmlElement(Order = 1)]
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
	}
}
