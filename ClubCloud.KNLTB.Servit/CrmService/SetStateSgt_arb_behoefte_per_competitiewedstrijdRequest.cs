using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_behoefte_per_competitiewedstrijdRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_behoefte_per_competitiewedstrijdState sgt_arb_behoefte_per_competitiewedstrijdStateField;
		private int sgt_arb_behoefte_per_competitiewedstrijdStatusField;
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
		public Sgt_arb_behoefte_per_competitiewedstrijdState Sgt_arb_behoefte_per_competitiewedstrijdState
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijdStateField;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijdStateField = value;
			}
		}
		public int Sgt_arb_behoefte_per_competitiewedstrijdStatus
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijdStatusField;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijdStatusField = value;
			}
		}
	}
}
