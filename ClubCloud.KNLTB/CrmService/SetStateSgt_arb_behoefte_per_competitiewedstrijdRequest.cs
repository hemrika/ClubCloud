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
	public class SetStateSgt_arb_behoefte_per_competitiewedstrijdRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_behoefte_per_competitiewedstrijdState sgt_arb_behoefte_per_competitiewedstrijdStateField;

		private int sgt_arb_behoefte_per_competitiewedstrijdStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_behoefte_per_competitiewedstrijdState Sgt_arb_behoefte_per_competitiewedstrijdState
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijdStateField;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijdStateField = value;
				base.RaisePropertyChanged("Sgt_arb_behoefte_per_competitiewedstrijdState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_behoefte_per_competitiewedstrijdStatus
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijdStatusField;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijdStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_behoefte_per_competitiewedstrijdStatus");
			}
		}

		public SetStateSgt_arb_behoefte_per_competitiewedstrijdRequest()
		{
		}
	}
}