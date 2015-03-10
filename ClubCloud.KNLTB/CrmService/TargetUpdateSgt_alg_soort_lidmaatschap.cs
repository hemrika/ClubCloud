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
	public class TargetUpdateSgt_alg_soort_lidmaatschap : TargetUpdate
	{
		private sgt_alg_soort_lidmaatschap sgt_alg_soort_lidmaatschapField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_soort_lidmaatschap Sgt_alg_soort_lidmaatschap
		{
			get
			{
				return this.sgt_alg_soort_lidmaatschapField;
			}
			set
			{
				this.sgt_alg_soort_lidmaatschapField = value;
				base.RaisePropertyChanged("Sgt_alg_soort_lidmaatschap");
			}
		}

		public TargetUpdateSgt_alg_soort_lidmaatschap()
		{
		}
	}
}