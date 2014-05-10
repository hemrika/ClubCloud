using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_arbitrage_inzet_toernooien : TargetUpdate
	{
		private sgt_arb_arbitrage_inzet_toernooien sgt_arb_arbitrage_inzet_toernooienField;
		public sgt_arb_arbitrage_inzet_toernooien Sgt_arb_arbitrage_inzet_toernooien
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_toernooienField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_toernooienField = value;
			}
		}
	}
}
