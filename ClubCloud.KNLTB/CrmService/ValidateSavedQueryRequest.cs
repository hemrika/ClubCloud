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
	public class ValidateSavedQueryRequest : Request
	{
		private string fetchXmlField;

		private int queryTypeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		public ValidateSavedQueryRequest()
		{
		}
	}
}