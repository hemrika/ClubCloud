using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_arbitrage_functionaris : TargetUpdate
	{
		private sgt_arb_arbitrage_functionaris sgt_arb_arbitrage_functionarisField;
		public sgt_arb_arbitrage_functionaris Sgt_arb_arbitrage_functionaris
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisField = value;
			}
		}
	}
}
