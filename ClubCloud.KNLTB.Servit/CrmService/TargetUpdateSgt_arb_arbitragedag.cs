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
	public class TargetUpdateSgt_arb_arbitragedag : TargetUpdate
	{
		private sgt_arb_arbitragedag sgt_arb_arbitragedagField;

		[XmlElement] //[XmlElement(Order=0)]
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

		public TargetUpdateSgt_arb_arbitragedag()
		{
		}
	}
}