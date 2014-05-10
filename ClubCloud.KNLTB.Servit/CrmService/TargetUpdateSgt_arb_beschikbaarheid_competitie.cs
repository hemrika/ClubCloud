using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_beschikbaarheid_competitie : TargetUpdate
	{
		private sgt_arb_beschikbaarheid_competitie sgt_arb_beschikbaarheid_competitieField;
		public sgt_arb_beschikbaarheid_competitie Sgt_arb_beschikbaarheid_competitie
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_competitieField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_competitieField = value;
			}
		}
	}
}
