using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CloseQuoteRequest : Request
	{
		private BusinessEntity quoteCloseField;
		private int statusField;
		[XmlElement(Order = 0)]
		public BusinessEntity QuoteClose
		{
			get
			{
				return this.quoteCloseField;
			}
			set
			{
				this.quoteCloseField = value;
				base.RaisePropertyChanged("QuoteClose");
			}
		}
		[XmlElement(Order = 1)]
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				base.RaisePropertyChanged("Status");
			}
		}
	}
}
