using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_beoordeling_arbitragefunctionarisRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_beoordeling_arbitragefunctionarisState sgt_arb_beoordeling_arbitragefunctionarisStateField;
		private int sgt_arb_beoordeling_arbitragefunctionarisStatusField;
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
		public Sgt_arb_beoordeling_arbitragefunctionarisState Sgt_arb_beoordeling_arbitragefunctionarisState
		{
			get
			{
				return this.sgt_arb_beoordeling_arbitragefunctionarisStateField;
			}
			set
			{
				this.sgt_arb_beoordeling_arbitragefunctionarisStateField = value;
			}
		}
		public int Sgt_arb_beoordeling_arbitragefunctionarisStatus
		{
			get
			{
				return this.sgt_arb_beoordeling_arbitragefunctionarisStatusField;
			}
			set
			{
				this.sgt_arb_beoordeling_arbitragefunctionarisStatusField = value;
			}
		}
	}
}
