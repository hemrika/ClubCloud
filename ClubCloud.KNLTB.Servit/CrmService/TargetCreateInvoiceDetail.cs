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
	public class TargetCreateInvoiceDetail : TargetCreate
	{
		private invoicedetail invoiceDetailField;

		[XmlElement] //[XmlElement(Order=0)]
		public invoicedetail InvoiceDetail
		{
			get
			{
				return this.invoiceDetailField;
			}
			set
			{
				this.invoiceDetailField = value;
				base.RaisePropertyChanged("InvoiceDetail");
			}
		}

		public TargetCreateInvoiceDetail()
		{
		}
	}
}