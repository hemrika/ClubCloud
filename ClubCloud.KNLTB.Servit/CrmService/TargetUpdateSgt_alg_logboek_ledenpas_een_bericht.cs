using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_logboek_ledenpas_een_bericht : TargetUpdate
	{
		private sgt_alg_logboek_ledenpas_een_bericht sgt_alg_logboek_ledenpas_een_berichtField;
		public sgt_alg_logboek_ledenpas_een_bericht Sgt_alg_logboek_ledenpas_een_bericht
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_een_berichtField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_een_berichtField = value;
			}
		}
	}
}
