using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_logboek_fact_export_facturen : TargetCreate
	{
		private sgt_alg_logboek_fact_export_facturen sgt_alg_logboek_fact_export_facturenField;
		public sgt_alg_logboek_fact_export_facturen Sgt_alg_logboek_fact_export_facturen
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_facturenField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_facturenField = value;
			}
		}
	}
}