using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_logboek_fact_export_debiteurenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_logboek_fact_export_debiteurenState sgt_alg_logboek_fact_export_debiteurenStateField;
		private int sgt_alg_logboek_fact_export_debiteurenStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_alg_logboek_fact_export_debiteurenState Sgt_alg_logboek_fact_export_debiteurenState
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_debiteurenStateField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_debiteurenStateField = value;
			}
		}
		public int Sgt_alg_logboek_fact_export_debiteurenStatus
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_debiteurenStatusField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_debiteurenStatusField = value;
			}
		}
	}
}
