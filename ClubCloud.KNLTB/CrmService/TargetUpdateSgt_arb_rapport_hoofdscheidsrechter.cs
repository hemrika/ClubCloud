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
	public class TargetUpdateSgt_arb_rapport_hoofdscheidsrechter : TargetUpdate
	{
		private sgt_arb_rapport_hoofdscheidsrechter sgt_arb_rapport_hoofdscheidsrechterField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_arb_rapport_hoofdscheidsrechter Sgt_arb_rapport_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechterField = value;
				base.RaisePropertyChanged("Sgt_arb_rapport_hoofdscheidsrechter");
			}
		}

		public TargetUpdateSgt_arb_rapport_hoofdscheidsrechter()
		{
		}
	}
}