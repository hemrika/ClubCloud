using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pasfoto_bulkimport_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pasfoto_bulkimport_logboekState sgt_alg_pasfoto_bulkimport_logboekStateField;
		private int sgt_alg_pasfoto_bulkimport_logboekStatusField;
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
		public Sgt_alg_pasfoto_bulkimport_logboekState Sgt_alg_pasfoto_bulkimport_logboekState
		{
			get
			{
				return this.sgt_alg_pasfoto_bulkimport_logboekStateField;
			}
			set
			{
				this.sgt_alg_pasfoto_bulkimport_logboekStateField = value;
			}
		}
		public int Sgt_alg_pasfoto_bulkimport_logboekStatus
		{
			get
			{
				return this.sgt_alg_pasfoto_bulkimport_logboekStatusField;
			}
			set
			{
				this.sgt_alg_pasfoto_bulkimport_logboekStatusField = value;
			}
		}
	}
}
