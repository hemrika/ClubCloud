using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_logboek_ledenpas_bericht_per_ver : TargetUpdate
	{
		private sgt_alg_logboek_ledenpas_bericht_per_ver sgt_alg_logboek_ledenpas_bericht_per_verField;
		public sgt_alg_logboek_ledenpas_bericht_per_ver Sgt_alg_logboek_ledenpas_bericht_per_ver
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_bericht_per_verField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_bericht_per_verField = value;
			}
		}
	}
}