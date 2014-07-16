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
	public class SetStateSgt_arb_arbitrage_functionarisRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitrage_functionarisState sgt_arb_arbitrage_functionarisStateField;

		private int sgt_arb_arbitrage_functionarisStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitrage_functionarisState Sgt_arb_arbitrage_functionarisState
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisStateField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisStateField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_functionarisState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_arbitrage_functionarisStatus
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisStatusField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_functionarisStatus");
			}
		}

		public SetStateSgt_arb_arbitrage_functionarisRequest()
		{
		}
	}
}