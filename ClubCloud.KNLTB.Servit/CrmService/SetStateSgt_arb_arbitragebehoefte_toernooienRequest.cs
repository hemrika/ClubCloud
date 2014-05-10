using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitragebehoefte_toernooienRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitragebehoefte_toernooienState sgt_arb_arbitragebehoefte_toernooienStateField;
		private int sgt_arb_arbitragebehoefte_toernooienStatusField;
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
		public Sgt_arb_arbitragebehoefte_toernooienState Sgt_arb_arbitragebehoefte_toernooienState
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooienStateField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooienStateField = value;
			}
		}
		public int Sgt_arb_arbitragebehoefte_toernooienStatus
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooienStatusField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooienStatusField = value;
			}
		}
	}
}
