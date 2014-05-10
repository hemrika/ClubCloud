using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportCompressedXmlWithProgressRequest : Request
	{
		private string parameterXmlField;
		private byte[] compressedCustomizationXmlField;
		private Guid importJobIdField;
		public string ParameterXml
		{
			get
			{
				return this.parameterXmlField;
			}
			set
			{
				this.parameterXmlField = value;
			}
		}
		[XmlElement(DataType = "base64Binary")]
		public byte[] CompressedCustomizationXml
		{
			get
			{
				return this.compressedCustomizationXmlField;
			}
			set
			{
				this.compressedCustomizationXmlField = value;
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
