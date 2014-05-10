using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCompoundInvoice : TargetCompound
	{
		private invoice invoiceField;
		private invoicedetail[] invoiceDetailsField;
		public invoice Invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		[XmlArrayItem(IsNullable = false)]
		public invoicedetail[] InvoiceDetails
		{
			get
			{
				return this.invoiceDetailsField;
			}
			set
			{
				this.invoiceDetailsField = value;
			}
		}
	}
}
