using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportXmlWithProgressRequest : Request
	{
		private string parameterXmlField;
		private string customizationXmlField;
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
		[XmlElement(Order = 1)]
		public string CustomizationXml
		{
			get
			{
				return this.customizationXmlField;
			}
			set
			{
				this.customizationXmlField = value;
				base.RaisePropertyChanged("CustomizationXml");
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
