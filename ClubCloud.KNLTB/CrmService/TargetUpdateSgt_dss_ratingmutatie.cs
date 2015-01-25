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
	public class TargetUpdateSgt_dss_ratingmutatie : TargetUpdate
	{
		private sgt_dss_ratingmutatie sgt_dss_ratingmutatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_ratingmutatie Sgt_dss_ratingmutatie
		{
			get
			{
				return this.sgt_dss_ratingmutatieField;
			}
			set
			{
				this.sgt_dss_ratingmutatieField = value;
				base.RaisePropertyChanged("Sgt_dss_ratingmutatie");
			}
		}

		public TargetUpdateSgt_dss_ratingmutatie()
		{
		}
	}
}