using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_logboek_ledenpas_bericht_per_verRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_logboek_ledenpas_bericht_per_verState sgt_alg_logboek_ledenpas_bericht_per_verStateField;
		private int sgt_alg_logboek_ledenpas_bericht_per_verStatusField;
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
		public Sgt_alg_logboek_ledenpas_bericht_per_verState Sgt_alg_logboek_ledenpas_bericht_per_verState
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_bericht_per_verStateField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_bericht_per_verStateField = value;
			}
		}
		public int Sgt_alg_logboek_ledenpas_bericht_per_verStatus
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_bericht_per_verStatusField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_bericht_per_verStatusField = value;
			}
		}
	}
}