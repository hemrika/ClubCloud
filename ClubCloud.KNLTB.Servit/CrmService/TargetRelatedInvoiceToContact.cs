using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetRelatedInvoiceToContact : TargetRelated
	{
		private Guid invoiceIdField;
		private Guid contactIdField;
		public Guid InvoiceId
		{
			get
			{
				return this.invoiceIdField;
			}
			set
			{
				this.invoiceIdField = value;
			}
		}
		public Guid ContactId
		{
			get
			{
				return this.contactIdField;
			}
			set
			{
				this.contactIdField = value;
			}
		}
	}
}
