using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_soort_lidmaatschap : TargetUpdate
	{
		private sgt_alg_soort_lidmaatschap sgt_alg_soort_lidmaatschapField;
		public sgt_alg_soort_lidmaatschap Sgt_alg_soort_lidmaatschap
		{
			get
			{
				return this.sgt_alg_soort_lidmaatschapField;
			}
			set
			{
				this.sgt_alg_soort_lidmaatschapField = value;
			}
		}
	}
}