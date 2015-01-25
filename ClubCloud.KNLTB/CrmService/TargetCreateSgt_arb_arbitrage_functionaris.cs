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
	public class TargetCreateSgt_arb_arbitrage_functionaris : TargetCreate
	{
		private sgt_arb_arbitrage_functionaris sgt_arb_arbitrage_functionarisField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_arb_arbitrage_functionaris Sgt_arb_arbitrage_functionaris
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_functionaris");
			}
		}

		public TargetCreateSgt_arb_arbitrage_functionaris()
		{
		}
	}
}