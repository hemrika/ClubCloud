using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_logboek_fact_import_betalingenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_logboek_fact_import_betalingenState sgt_alg_logboek_fact_import_betalingenStateField;
		private int sgt_alg_logboek_fact_import_betalingenStatusField;
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
		public Sgt_alg_logboek_fact_import_betalingenState Sgt_alg_logboek_fact_import_betalingenState
		{
			get
			{
				return this.sgt_alg_logboek_fact_import_betalingenStateField;
			}
			set
			{
				this.sgt_alg_logboek_fact_import_betalingenStateField = value;
			}
		}
		public int Sgt_alg_logboek_fact_import_betalingenStatus
		{
			get
			{
				return this.sgt_alg_logboek_fact_import_betalingenStatusField;
			}
			set
			{
				this.sgt_alg_logboek_fact_import_betalingenStatusField = value;
			}
		}
	}
}
