using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_behoefte_per_competitiewedstrijd : TargetUpdate
	{
		private sgt_arb_behoefte_per_competitiewedstrijd sgt_arb_behoefte_per_competitiewedstrijdField;
		public sgt_arb_behoefte_per_competitiewedstrijd Sgt_arb_behoefte_per_competitiewedstrijd
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijdField;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijdField = value;
			}
		}
	}
}
