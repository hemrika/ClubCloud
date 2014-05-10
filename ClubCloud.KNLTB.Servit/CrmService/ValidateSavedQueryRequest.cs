using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ValidateSavedQueryRequest : Request
	{
		private string fetchXmlField;
		private int queryTypeField;
		public string FetchXml
		{
			get
			{
				return this.fetchXmlField;
			}
			set
			{
				this.fetchXmlField = value;
			}
		}
		public int QueryType
		{
			get
			{
				return this.queryTypeField;
			}
			set
			{
				this.queryTypeField = value;
			}
		}
	}
}
