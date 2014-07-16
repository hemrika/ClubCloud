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
	public class TargetUpdateSgt_alg_soort_verlichting : TargetUpdate
	{
		private sgt_alg_soort_verlichting sgt_alg_soort_verlichtingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_soort_verlichting Sgt_alg_soort_verlichting
		{
			get
			{
				return this.sgt_alg_soort_verlichtingField;
			}
			set
			{
				this.sgt_alg_soort_verlichtingField = value;
				base.RaisePropertyChanged("Sgt_alg_soort_verlichting");
			}
		}

		public TargetUpdateSgt_alg_soort_verlichting()
		{
		}
	}
}