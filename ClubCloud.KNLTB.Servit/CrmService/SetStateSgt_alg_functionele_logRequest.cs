using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_functionele_logRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_functionele_logState sgt_alg_functionele_logStateField;
		private int sgt_alg_functionele_logStatusField;
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
		public Sgt_alg_functionele_logState Sgt_alg_functionele_logState
		{
			get
			{
				return this.sgt_alg_functionele_logStateField;
			}
			set
			{
				this.sgt_alg_functionele_logStateField = value;
			}
		}
		public int Sgt_alg_functionele_logStatus
		{
			get
			{
				return this.sgt_alg_functionele_logStatusField;
			}
			set
			{
				this.sgt_alg_functionele_logStatusField = value;
			}
		}
	}
}
