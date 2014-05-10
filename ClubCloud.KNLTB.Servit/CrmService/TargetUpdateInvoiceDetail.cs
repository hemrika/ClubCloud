using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateInvoiceDetail : TargetUpdate
	{
		private invoicedetail invoiceDetailField;
		public invoicedetail InvoiceDetail
		{
			get
			{
				return this.invoiceDetailField;
			}
			set
			{
				this.invoiceDetailField = value;
			}
		}
	}
}
