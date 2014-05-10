using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_beoordeling_arbitragefunctionaris : TargetUpdate
	{
		private sgt_arb_beoordeling_arbitragefunctionaris sgt_arb_beoordeling_arbitragefunctionarisField;
		public sgt_arb_beoordeling_arbitragefunctionaris Sgt_arb_beoordeling_arbitragefunctionaris
		{
			get
			{
				return this.sgt_arb_beoordeling_arbitragefunctionarisField;
			}
			set
			{
				this.sgt_arb_beoordeling_arbitragefunctionarisField = value;
			}
		}
	}
}
