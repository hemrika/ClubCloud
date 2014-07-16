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
	public class TargetUpdateSgt_dss_ratinglogboek : TargetUpdate
	{
		private sgt_dss_ratinglogboek sgt_dss_ratinglogboekField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_ratinglogboek Sgt_dss_ratinglogboek
		{
			get
			{
				return this.sgt_dss_ratinglogboekField;
			}
			set
			{
				this.sgt_dss_ratinglogboekField = value;
				base.RaisePropertyChanged("Sgt_dss_ratinglogboek");
			}
		}

		public TargetUpdateSgt_dss_ratinglogboek()
		{
		}
	}
}