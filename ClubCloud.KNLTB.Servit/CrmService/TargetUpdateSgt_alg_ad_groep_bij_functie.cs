using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_ad_groep_bij_functie : TargetUpdate
	{
		private sgt_alg_ad_groep_bij_functie sgt_alg_ad_groep_bij_functieField;
		public sgt_alg_ad_groep_bij_functie Sgt_alg_ad_groep_bij_functie
		{
			get
			{
				return this.sgt_alg_ad_groep_bij_functieField;
			}
			set
			{
				this.sgt_alg_ad_groep_bij_functieField = value;
			}
		}
	}
}
