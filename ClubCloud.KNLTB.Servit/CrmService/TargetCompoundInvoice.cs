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
	public class TargetCompoundInvoice : TargetCompound
	{
		private invoice invoiceField;

		private invoicedetail[] invoiceDetailsField;

		[XmlElement] //[XmlElement(Order=0)]
		public invoice Invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
				base.RaisePropertyChanged("Invoice");
			}
		}

		[XmlArray] //[XmlArray(Order=1)]
		[XmlArrayItem(IsNullable=false)]
		public invoicedetail[] InvoiceDetails
		{
			get
			{
				return this.invoiceDetailsField;
			}
			set
			{
				this.invoiceDetailsField = value;
				base.RaisePropertyChanged("InvoiceDetails");
			}
		}

		public TargetCompoundInvoice()
		{
		}
	}
}