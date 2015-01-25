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
	public class ExportXmlResponse : Response
	{
		private string exportXmlField;

		[XmlElement] //[XmlElement(Order=0)]
		public string ExportXml
		{
			get
			{
				return this.exportXmlField;
			}
			set
			{
				this.exportXmlField = value;
				base.RaisePropertyChanged("ExportXml");
			}
		}

		public ExportXmlResponse()
		{
		}
	}
}