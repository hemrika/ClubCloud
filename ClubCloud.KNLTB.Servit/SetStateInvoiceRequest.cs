using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateInvoiceRequest : Request
	{
		private Guid entityIdField;
		private InvoiceState invoiceStateField;
		private int invoiceStatusField;
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public InvoiceState InvoiceState
		{
			get
			{
				return this.invoiceStateField;
			}
			set
			{
				this.invoiceStateField = value;
				base.RaisePropertyChanged("InvoiceState");
			}
		}
		[XmlElement(Order = 2)]
		public int InvoiceStatus
		{
			get
			{
				return this.invoiceStatusField;
			}
			set
			{
				this.invoiceStatusField = value;
				base.RaisePropertyChanged("InvoiceStatus");
			}
		}
	}
}
