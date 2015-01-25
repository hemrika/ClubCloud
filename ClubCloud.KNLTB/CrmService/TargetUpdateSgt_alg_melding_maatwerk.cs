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
	public class TargetUpdateSgt_alg_melding_maatwerk : TargetUpdate
	{
		private sgt_alg_melding_maatwerk sgt_alg_melding_maatwerkField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_melding_maatwerk Sgt_alg_melding_maatwerk
		{
			get
			{
				return this.sgt_alg_melding_maatwerkField;
			}
			set
			{
				this.sgt_alg_melding_maatwerkField = value;
				base.RaisePropertyChanged("Sgt_alg_melding_maatwerk");
			}
		}

		public TargetUpdateSgt_alg_melding_maatwerk()
		{
		}
	}
}