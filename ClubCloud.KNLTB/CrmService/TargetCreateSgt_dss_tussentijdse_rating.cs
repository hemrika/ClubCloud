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
	public class TargetCreateSgt_dss_tussentijdse_rating : TargetCreate
	{
		private sgt_dss_tussentijdse_rating sgt_dss_tussentijdse_ratingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_tussentijdse_rating Sgt_dss_tussentijdse_rating
		{
			get
			{
				return this.sgt_dss_tussentijdse_ratingField;
			}
			set
			{
				this.sgt_dss_tussentijdse_ratingField = value;
				base.RaisePropertyChanged("Sgt_dss_tussentijdse_rating");
			}
		}

		public TargetCreateSgt_dss_tussentijdse_rating()
		{
		}
	}
}