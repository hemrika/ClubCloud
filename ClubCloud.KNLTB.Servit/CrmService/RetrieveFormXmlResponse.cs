using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveFormXmlResponse : Response
	{
		private string formXmlField;
		private int customizationLevelField;
		public string FormXml
		{
			get
			{
				return this.formXmlField;
			}
			set
			{
				this.formXmlField = value;
			}
		}
		public int CustomizationLevel
		{
			get
			{
				return this.customizationLevelField;
			}
			set
			{
				this.customizationLevelField = value;
			}
		}
	}
}
