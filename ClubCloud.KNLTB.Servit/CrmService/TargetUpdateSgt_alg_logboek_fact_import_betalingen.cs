using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_logboek_fact_import_betalingen : TargetUpdate
	{
		private sgt_alg_logboek_fact_import_betalingen sgt_alg_logboek_fact_import_betalingenField;
		public sgt_alg_logboek_fact_import_betalingen Sgt_alg_logboek_fact_import_betalingen
		{
			get
			{
				return this.sgt_alg_logboek_fact_import_betalingenField;
			}
			set
			{
				this.sgt_alg_logboek_fact_import_betalingenField = value;
			}
		}
	}
}