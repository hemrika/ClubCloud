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
	public class TargetUpdateSgt_dss_tussentijdse_rating_logboek : TargetUpdate
	{
		private sgt_dss_tussentijdse_rating_logboek sgt_dss_tussentijdse_rating_logboekField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_tussentijdse_rating_logboek Sgt_dss_tussentijdse_rating_logboek
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_logboekField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_logboekField = value;
				base.RaisePropertyChanged("Sgt_dss_tussentijdse_rating_logboek");
			}
		}

		public TargetUpdateSgt_dss_tussentijdse_rating_logboek()
		{
		}
	}
}