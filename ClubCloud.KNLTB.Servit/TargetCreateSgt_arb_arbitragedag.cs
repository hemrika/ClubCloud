using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_arb_arbitragedag : TargetCreate
	{
		private sgt_arb_arbitragedag sgt_arb_arbitragedagField;
		[XmlElement(Order = 0)]
		public sgt_arb_arbitragedag Sgt_arb_arbitragedag
		{
			get
			{
				return this.sgt_arb_arbitragedagField;
			}
			set
			{
				this.sgt_arb_arbitragedagField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragedag");
			}
		}
	}
}
