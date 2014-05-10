using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportXmlWithProgressRequest : Request
	{
		private string parameterXmlField;
		private string customizationXmlField;
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
		public string CustomizationXml
		{
			get
			{
				return this.customizationXmlField;
			}
			set
			{
				this.customizationXmlField = value;
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
