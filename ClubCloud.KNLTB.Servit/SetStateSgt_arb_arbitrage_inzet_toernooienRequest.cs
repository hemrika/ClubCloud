using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitrage_inzet_toernooienRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitrage_inzet_toernooienState sgt_arb_arbitrage_inzet_toernooienStateField;
		private int sgt_arb_arbitrage_inzet_toernooienStatusField;
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
		public Sgt_arb_arbitrage_inzet_toernooienState Sgt_arb_arbitrage_inzet_toernooienState
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_toernooienStateField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_toernooienStateField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_inzet_toernooienState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_arb_arbitrage_inzet_toernooienStatus
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_toernooienStatusField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_toernooienStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_inzet_toernooienStatus");
			}
		}
	}
}
