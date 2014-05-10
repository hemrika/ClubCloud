using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateTransactionCurrencyRequest : Request
	{
		private Guid entityIdField;
		private TransactionCurrencyState transactionCurrencyStateField;
		private int transactionCurrencyStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public TransactionCurrencyState TransactionCurrencyState
		{
			get
			{
				return this.transactionCurrencyStateField;
			}
			set
			{
				this.transactionCurrencyStateField = value;
			}
		}
		public int TransactionCurrencyStatus
		{
			get
			{
				return this.transactionCurrencyStatusField;
			}
			set
			{
				this.transactionCurrencyStatusField = value;
			}
		}
	}
}
