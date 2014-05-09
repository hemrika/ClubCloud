using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_logboek_fact_export_debiteuren : TargetUpdate
	{
		private sgt_alg_logboek_fact_export_debiteuren sgt_alg_logboek_fact_export_debiteurenField;
		[XmlElement(Order = 0)]
		public sgt_alg_logboek_fact_export_debiteuren Sgt_alg_logboek_fact_export_debiteuren
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_debiteurenField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_debiteurenField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_fact_export_debiteuren");
			}
		}
	}
}
