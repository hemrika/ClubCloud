using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_logboek_ledenpas_een_berichtRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_logboek_ledenpas_een_berichtState sgt_alg_logboek_ledenpas_een_berichtStateField;
		private int sgt_alg_logboek_ledenpas_een_berichtStatusField;
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
		public Sgt_alg_logboek_ledenpas_een_berichtState Sgt_alg_logboek_ledenpas_een_berichtState
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_een_berichtStateField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_een_berichtStateField = value;
			}
		}
		public int Sgt_alg_logboek_ledenpas_een_berichtStatus
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_een_berichtStatusField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_een_berichtStatusField = value;
			}
		}
	}
}
