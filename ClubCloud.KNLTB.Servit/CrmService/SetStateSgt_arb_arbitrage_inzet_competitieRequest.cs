using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitrage_inzet_competitieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitrage_inzet_competitieState sgt_arb_arbitrage_inzet_competitieStateField;
		private int sgt_arb_arbitrage_inzet_competitieStatusField;
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
		public Sgt_arb_arbitrage_inzet_competitieState Sgt_arb_arbitrage_inzet_competitieState
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitieStateField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitieStateField = value;
			}
		}
		public int Sgt_arb_arbitrage_inzet_competitieStatus
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitieStatusField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitieStatusField = value;
			}
		}
	}
}