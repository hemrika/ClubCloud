using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_arb_arbitrage_inzet_competitie : TargetCreate
	{
		private sgt_arb_arbitrage_inzet_competitie sgt_arb_arbitrage_inzet_competitieField;
		[XmlElement(Order = 0)]
		public sgt_arb_arbitrage_inzet_competitie Sgt_arb_arbitrage_inzet_competitie
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitieField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitieField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_inzet_competitie");
			}
		}
	}
}
