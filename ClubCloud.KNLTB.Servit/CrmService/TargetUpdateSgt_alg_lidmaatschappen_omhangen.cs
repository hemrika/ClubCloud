using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_lidmaatschappen_omhangen : TargetUpdate
	{
		private sgt_alg_lidmaatschappen_omhangen sgt_alg_lidmaatschappen_omhangenField;
		public sgt_alg_lidmaatschappen_omhangen Sgt_alg_lidmaatschappen_omhangen
		{
			get
			{
				return this.sgt_alg_lidmaatschappen_omhangenField;
			}
			set
			{
				this.sgt_alg_lidmaatschappen_omhangenField = value;
			}
		}
	}
}