using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_nummerreeks_uitgaveRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_nummerreeks_uitgaveState sgt_alg_nummerreeks_uitgaveStateField;
		private int sgt_alg_nummerreeks_uitgaveStatusField;
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
		public Sgt_alg_nummerreeks_uitgaveState Sgt_alg_nummerreeks_uitgaveState
		{
			get
			{
				return this.sgt_alg_nummerreeks_uitgaveStateField;
			}
			set
			{
				this.sgt_alg_nummerreeks_uitgaveStateField = value;
			}
		}
		public int Sgt_alg_nummerreeks_uitgaveStatus
		{
			get
			{
				return this.sgt_alg_nummerreeks_uitgaveStatusField;
			}
			set
			{
				this.sgt_alg_nummerreeks_uitgaveStatusField = value;
			}
		}
	}
}