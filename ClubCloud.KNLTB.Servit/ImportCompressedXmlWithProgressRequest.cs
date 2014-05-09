using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportCompressedXmlWithProgressRequest : Request
	{
		private string parameterXmlField;
		private byte[] compressedCustomizationXmlField;
		private Guid importJobIdField;
		[XmlElement(Order = 0)]
		public string ParameterXml
		{
			get
			{
				return this.parameterXmlField;
			}
			set
			{
				this.parameterXmlField = value;
				base.RaisePropertyChanged("ParameterXml");
			}
		}
		[XmlElement(DataType = "base64Binary", Order = 1)]
		public byte[] CompressedCustomizationXml
		{
			get
			{
				return this.compressedCustomizationXmlField;
			}
			set
			{
				this.compressedCustomizationXmlField = value;
				base.RaisePropertyChanged("CompressedCustomizationXml");
			}
		}
		[XmlElement(Order = 2)]
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
