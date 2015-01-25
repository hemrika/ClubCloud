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
	public class SetStateTransactionCurrencyRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.TransactionCurrencyState transactionCurrencyStateField;

		private int transactionCurrencyStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.TransactionCurrencyState TransactionCurrencyState
		{
			get
			{
				return this.transactionCurrencyStateField;
			}
			set
			{
				this.transactionCurrencyStateField = value;
				base.RaisePropertyChanged("TransactionCurrencyState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int TransactionCurrencyStatus
		{
			get
			{
				return this.transactionCurrencyStatusField;
			}
			set
			{
				this.transactionCurrencyStatusField = value;
				base.RaisePropertyChanged("TransactionCurrencyStatus");
			}
		}

		public SetStateTransactionCurrencyRequest()
		{
		}
	}
}