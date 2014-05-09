using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_arbitragedagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_arbitragedagState sgt_arb_arbitragedagStateField;
		private int sgt_arb_arbitragedagStatusField;
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
		public Sgt_arb_arbitragedagState Sgt_arb_arbitragedagState
		{
			get
			{
				return this.sgt_arb_arbitragedagStateField;
			}
			set
			{
				this.sgt_arb_arbitragedagStateField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragedagState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_arb_arbitragedagStatus
		{
			get
			{
				return this.sgt_arb_arbitragedagStatusField;
			}
			set
			{
				this.sgt_arb_arbitragedagStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragedagStatus");
			}
		}
	}
}
