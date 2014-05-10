using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitrage_functionarisRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitrage_functionarisState sgt_arb_arbitrage_functionarisStateField;
		private int sgt_arb_arbitrage_functionarisStatusField;
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
		public Sgt_arb_arbitrage_functionarisState Sgt_arb_arbitrage_functionarisState
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisStateField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisStateField = value;
			}
		}
		public int Sgt_arb_arbitrage_functionarisStatus
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisStatusField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisStatusField = value;
			}
		}
	}
}
