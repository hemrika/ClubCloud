using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_dss_tussentijdse_rating_peildatum : TargetUpdate
	{
		private sgt_dss_tussentijdse_rating_peildatum sgt_dss_tussentijdse_rating_peildatumField;
		public sgt_dss_tussentijdse_rating_peildatum Sgt_dss_tussentijdse_rating_peildatum
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_peildatumField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_peildatumField = value;
			}
		}
	}
}
