using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_beoordeling_arbitragefunctionarisRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_beoordeling_arbitragefunctionarisState sgt_arb_beoordeling_arbitragefunctionarisStateField;
		private int sgt_arb_beoordeling_arbitragefunctionarisStatusField;
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
		public Sgt_arb_beoordeling_arbitragefunctionarisState Sgt_arb_beoordeling_arbitragefunctionarisState
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
		[XmlElement(Order = 2)]
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
	}
}
