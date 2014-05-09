using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ValidateSavedQueryRequest : Request
	{
		private string fetchXmlField;
		private int queryTypeField;
		[XmlElement(Order = 0)]
		public string FetchXml
		{
			get
			{
				return this.fetchXmlField;
			}
			set
			{
				this.fetchXmlField = value;
				base.RaisePropertyChanged("FetchXml");
			}
		}
		[XmlElement(Order = 1)]
		public int QueryType
		{
			get
			{
				return this.queryTypeField;
			}
			set
			{
				this.queryTypeField = value;
				base.RaisePropertyChanged("QueryType");
			}
		}
	}
}
