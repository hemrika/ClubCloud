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
	public class RetrieveFormXmlResponse : Response
	{
		private string formXmlField;

		private int customizationLevelField;

		[XmlElement] //[XmlElement(Order=1)]
		public int CustomizationLevel
		{
			get
			{
				return this.customizationLevelField;
			}
			set
			{
				this.customizationLevelField = value;
				base.RaisePropertyChanged("CustomizationLevel");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public string FormXml
		{
			get
			{
				return this.formXmlField;
			}
			set
			{
				this.formXmlField = value;
				base.RaisePropertyChanged("FormXml");
			}
		}

		public RetrieveFormXmlResponse()
		{
		}
	}
}