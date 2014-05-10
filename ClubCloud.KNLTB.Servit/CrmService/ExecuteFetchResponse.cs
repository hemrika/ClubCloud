using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ExecuteFetchResponse : Response
	{
		private string fetchXmlResultField;
		public string FetchXmlResult
		{
			get
			{
				return this.fetchXmlResultField;
			}
			set
			{
				this.fetchXmlResultField = value;
			}
		}
	}
}
