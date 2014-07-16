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
	public class RetrieveAvailableLanguagesResponse : Response
	{
		private int[] localeIdsField;

		[XmlArray] //[XmlArray(Order=0)]
		public int[] LocaleIds
		{
			get
			{
				return this.localeIdsField;
			}
			set
			{
				this.localeIdsField = value;
				base.RaisePropertyChanged("LocaleIds");
			}
		}

		public RetrieveAvailableLanguagesResponse()
		{
		}
	}
}