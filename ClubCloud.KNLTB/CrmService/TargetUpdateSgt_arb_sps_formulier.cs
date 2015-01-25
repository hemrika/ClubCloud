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
	public class TargetUpdateSgt_arb_sps_formulier : TargetUpdate
	{
		private sgt_arb_sps_formulier sgt_arb_sps_formulierField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_arb_sps_formulier Sgt_arb_sps_formulier
		{
			get
			{
				return this.sgt_arb_sps_formulierField;
			}
			set
			{
				this.sgt_arb_sps_formulierField = value;
				base.RaisePropertyChanged("Sgt_arb_sps_formulier");
			}
		}

		public TargetUpdateSgt_arb_sps_formulier()
		{
		}
	}
}