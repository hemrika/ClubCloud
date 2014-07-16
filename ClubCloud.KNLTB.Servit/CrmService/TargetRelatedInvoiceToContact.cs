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
	public class TargetRelatedInvoiceToContact : TargetRelated
	{
		private Guid invoiceIdField;

		private Guid contactIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ContactId
		{
			get
			{
				return this.contactIdField;
			}
			set
			{
				this.contactIdField = value;
				base.RaisePropertyChanged("ContactId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid InvoiceId
		{
			get
			{
				return this.invoiceIdField;
			}
			set
			{
				this.invoiceIdField = value;
				base.RaisePropertyChanged("InvoiceId");
			}
		}

		public TargetRelatedInvoiceToContact()
		{
		}
	}
}