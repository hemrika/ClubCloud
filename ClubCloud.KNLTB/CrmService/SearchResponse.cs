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
	public class SearchResponse : Response
	{
		private ClubCloud.KNLTB.ServIt.CrmService.SearchResults searchResultsField;

		[XmlElement] //[XmlElement(Order=0)]
		public ClubCloud.KNLTB.ServIt.CrmService.SearchResults SearchResults
		{
			get
			{
				return this.searchResultsField;
			}
			set
			{
				this.searchResultsField = value;
				base.RaisePropertyChanged("SearchResults");
			}
		}

		public SearchResponse()
		{
		}
	}
}