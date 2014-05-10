using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitragebeschikbaarheid_toernooiRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitragebeschikbaarheid_toernooiState sgt_arb_arbitragebeschikbaarheid_toernooiStateField;
		private int sgt_arb_arbitragebeschikbaarheid_toernooiStatusField;
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
		public Sgt_arb_arbitragebeschikbaarheid_toernooiState Sgt_arb_arbitragebeschikbaarheid_toernooiState
		{
			get
			{
				return this.sgt_arb_arbitragebeschikbaarheid_toernooiStateField;
			}
			set
			{
				this.sgt_arb_arbitragebeschikbaarheid_toernooiStateField = value;
			}
		}
		public int Sgt_arb_arbitragebeschikbaarheid_toernooiStatus
		{
			get
			{
				return this.sgt_arb_arbitragebeschikbaarheid_toernooiStatusField;
			}
			set
			{
				this.sgt_arb_arbitragebeschikbaarheid_toernooiStatusField = value;
			}
		}
	}
}
