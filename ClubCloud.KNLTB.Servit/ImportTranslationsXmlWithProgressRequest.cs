using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ImportTranslationsXmlWithProgressRequest : Request
	{
		private string importXmlField;
		private Guid importJobIdField;
		[XmlElement(Order = 0)]
		public string ImportXml
		{
			get
			{
				return this.importXmlField;
			}
			set
			{
				this.importXmlField = value;
				base.RaisePropertyChanged("ImportXml");
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
