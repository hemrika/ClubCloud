using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_arbitragebeschikbaarheid_toernooi : TargetUpdate
	{
		private sgt_arb_arbitragebeschikbaarheid_toernooi sgt_arb_arbitragebeschikbaarheid_toernooiField;
		public sgt_arb_arbitragebeschikbaarheid_toernooi Sgt_arb_arbitragebeschikbaarheid_toernooi
		{
			get
			{
				return this.sgt_arb_arbitragebeschikbaarheid_toernooiField;
			}
			set
			{
				this.sgt_arb_arbitragebeschikbaarheid_toernooiField = value;
			}
		}
	}
}
