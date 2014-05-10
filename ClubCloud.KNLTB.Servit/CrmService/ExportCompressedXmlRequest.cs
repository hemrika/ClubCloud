using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ExportCompressedXmlRequest : Request
	{
		private string parameterXmlField;
		private string embeddedFileNameField;
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
		public string EmbeddedFileName
		{
			get
			{
				return this.embeddedFileNameField;
			}
			set
			{
				this.embeddedFileNameField = value;
			}
		}
	}
}
