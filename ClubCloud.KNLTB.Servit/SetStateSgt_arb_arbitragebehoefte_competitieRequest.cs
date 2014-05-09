using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitragebehoefte_competitieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitragebehoefte_competitieState sgt_arb_arbitragebehoefte_competitieStateField;
		private int sgt_arb_arbitragebehoefte_competitieStatusField;
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
		public Sgt_arb_arbitragebehoefte_competitieState Sgt_arb_arbitragebehoefte_competitieState
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_competitieStateField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_competitieStateField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebehoefte_competitieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_arb_arbitragebehoefte_competitieStatus
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_competitieStatusField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_competitieStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebehoefte_competitieStatus");
			}
		}
	}
}
