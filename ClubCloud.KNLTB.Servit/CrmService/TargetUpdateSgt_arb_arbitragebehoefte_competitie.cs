using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_arbitragebehoefte_competitie : TargetUpdate
	{
		private sgt_arb_arbitragebehoefte_competitie sgt_arb_arbitragebehoefte_competitieField;
		public sgt_arb_arbitragebehoefte_competitie Sgt_arb_arbitragebehoefte_competitie
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_competitieField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_competitieField = value;
			}
		}
	}
}
