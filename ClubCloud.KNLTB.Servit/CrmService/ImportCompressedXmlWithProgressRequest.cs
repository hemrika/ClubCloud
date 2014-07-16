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
	public class ImportCompressedXmlWithProgressRequest : Request
	{
		private string parameterXmlField;

		private byte[] compressedCustomizationXmlField;

		private Guid importJobIdField;

		[XmlElement(DataType="base64Binary")] //, Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		public ImportCompressedXmlWithProgressRequest()
		{
		}
	}
}