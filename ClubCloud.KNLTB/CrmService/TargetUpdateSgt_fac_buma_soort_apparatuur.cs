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
	public class TargetUpdateSgt_fac_buma_soort_apparatuur : TargetUpdate
	{
		private sgt_fac_buma_soort_apparatuur sgt_fac_buma_soort_apparatuurField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_fac_buma_soort_apparatuur Sgt_fac_buma_soort_apparatuur
		{
			get
			{
				return this.sgt_fac_buma_soort_apparatuurField;
			}
			set
			{
				this.sgt_fac_buma_soort_apparatuurField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_soort_apparatuur");
			}
		}

		public TargetUpdateSgt_fac_buma_soort_apparatuur()
		{
		}
	}
}