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
	public class SetStateSgt_arb_arbitrage_inzet_competitieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitrage_inzet_competitieState sgt_arb_arbitrage_inzet_competitieStateField;

		private int sgt_arb_arbitrage_inzet_competitieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitrage_inzet_competitieState Sgt_arb_arbitrage_inzet_competitieState
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitieStateField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitieStateField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_inzet_competitieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_arbitrage_inzet_competitieStatus
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitieStatusField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitieStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_inzet_competitieStatus");
			}
		}

		public SetStateSgt_arb_arbitrage_inzet_competitieRequest()
		{
		}
	}
}