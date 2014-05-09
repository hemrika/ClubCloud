using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_arb_arbitrage_indeling_toernooi : TargetCreate
	{
		private sgt_arb_arbitrage_indeling_toernooi sgt_arb_arbitrage_indeling_toernooiField;
		[XmlElement(Order = 0)]
		public sgt_arb_arbitrage_indeling_toernooi Sgt_arb_arbitrage_indeling_toernooi
		{
			get
			{
				return this.sgt_arb_arbitrage_indeling_toernooiField;
			}
			set
			{
				this.sgt_arb_arbitrage_indeling_toernooiField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitrage_indeling_toernooi");
			}
		}
	}
}
