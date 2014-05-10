using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_logboek_fact_export_facturenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_logboek_fact_export_facturenState sgt_alg_logboek_fact_export_facturenStateField;
		private int sgt_alg_logboek_fact_export_facturenStatusField;
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
		public Sgt_alg_logboek_fact_export_facturenState Sgt_alg_logboek_fact_export_facturenState
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_facturenStateField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_facturenStateField = value;
			}
		}
		public int Sgt_alg_logboek_fact_export_facturenStatus
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_facturenStatusField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_facturenStatusField = value;
			}
		}
	}
}
