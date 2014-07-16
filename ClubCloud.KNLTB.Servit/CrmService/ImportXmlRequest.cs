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
	public class ImportXmlRequest : Request
	{
		private string parameterXmlField;

		private string customizationXmlField;

		[XmlElement] //[XmlElement(Order=1)]
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

		public ImportXmlRequest()
		{
		}
	}
}