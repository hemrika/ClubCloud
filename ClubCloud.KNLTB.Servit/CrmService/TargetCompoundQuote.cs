using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCompoundQuote : TargetCompound
	{
		private quote quoteField;
		private quotedetail[] quoteDetailsField;
		public quote Quote
		{
			get
			{
				return this.quoteField;
			}
			set
			{
				this.quoteField = value;
			}
		}
		[XmlArrayItem(IsNullable = false)]
		public quotedetail[] QuoteDetails
		{
			get
			{
				return this.quoteDetailsField;
			}
			set
			{
				this.quoteDetailsField = value;
			}
		}
	}
}
