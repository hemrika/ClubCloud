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
	public class SetStateSgt_arb_beoordeling_arbitragefunctionarisRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_beoordeling_arbitragefunctionarisState sgt_arb_beoordeling_arbitragefunctionarisStateField;

		private int sgt_arb_beoordeling_arbitragefunctionarisStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_beoordeling_arbitragefunctionarisState Sgt_arb_beoordeling_arbitragefunctionarisState
		{
			get
			{
				return this.sgt_arb_beoordeling_arbitragefunctionarisStateField;
			}
			set
			{
				this.sgt_arb_beoordeling_arbitragefunctionarisStateField = value;
				base.RaisePropertyChanged("Sgt_arb_beoordeling_arbitragefunctionarisState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_beoordeling_arbitragefunctionarisStatus
		{
			get
			{
				return this.sgt_arb_beoordeling_arbitragefunctionarisStatusField;
			}
			set
			{
				this.sgt_arb_beoordeling_arbitragefunctionarisStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_beoordeling_arbitragefunctionarisStatus");
			}
		}

		public SetStateSgt_arb_beoordeling_arbitragefunctionarisRequest()
		{
		}
	}
}