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
	public class SetStateSgt_arb_arbitragebeschikbaarheid_toernooiRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitragebeschikbaarheid_toernooiState sgt_arb_arbitragebeschikbaarheid_toernooiStateField;

		private int sgt_arb_arbitragebeschikbaarheid_toernooiStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitragebeschikbaarheid_toernooiState Sgt_arb_arbitragebeschikbaarheid_toernooiState
		{
			get
			{
				return this.sgt_arb_arbitragebeschikbaarheid_toernooiStateField;
			}
			set
			{
				this.sgt_arb_arbitragebeschikbaarheid_toernooiStateField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebeschikbaarheid_toernooiState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_arbitragebeschikbaarheid_toernooiStatus
		{
			get
			{
				return this.sgt_arb_arbitragebeschikbaarheid_toernooiStatusField;
			}
			set
			{
				this.sgt_arb_arbitragebeschikbaarheid_toernooiStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebeschikbaarheid_toernooiStatus");
			}
		}

		public SetStateSgt_arb_arbitragebeschikbaarheid_toernooiRequest()
		{
		}
	}
}