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
	public class TargetCreateSgt_arb_arbitrage_inzet_competitie : TargetCreate
	{
		private sgt_arb_arbitrage_inzet_competitie sgt_arb_arbitrage_inzet_competitieField;

		[XmlElement] //[XmlElement(Order=0)]
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

		public TargetCreateSgt_arb_arbitrage_inzet_competitie()
		{
		}
	}
}