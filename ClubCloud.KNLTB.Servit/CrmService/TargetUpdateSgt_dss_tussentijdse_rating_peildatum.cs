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
	public class TargetUpdateSgt_dss_tussentijdse_rating_peildatum : TargetUpdate
	{
		private sgt_dss_tussentijdse_rating_peildatum sgt_dss_tussentijdse_rating_peildatumField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_tussentijdse_rating_peildatum Sgt_dss_tussentijdse_rating_peildatum
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_peildatumField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_peildatumField = value;
				base.RaisePropertyChanged("Sgt_dss_tussentijdse_rating_peildatum");
			}
		}

		public TargetUpdateSgt_dss_tussentijdse_rating_peildatum()
		{
		}
	}
}