using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitrage_indeling_toernooiRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitrage_indeling_toernooiState sgt_arb_arbitrage_indeling_toernooiStateField;
		private int sgt_arb_arbitrage_indeling_toernooiStatusField;
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
		public Sgt_arb_arbitrage_indeling_toernooiState Sgt_arb_arbitrage_indeling_toernooiState
		{
			get
			{
				return this.sgt_arb_arbitrage_indeling_toernooiStateField;
			}
			set
			{
				this.sgt_arb_arbitrage_indeling_toernooiStateField = value;
			}
		}
		public int Sgt_arb_arbitrage_indeling_toernooiStatus
		{
			get
			{
				return this.sgt_arb_arbitrage_indeling_toernooiStatusField;
			}
			set
			{
				this.sgt_arb_arbitrage_indeling_toernooiStatusField = value;
			}
		}
	}
}
