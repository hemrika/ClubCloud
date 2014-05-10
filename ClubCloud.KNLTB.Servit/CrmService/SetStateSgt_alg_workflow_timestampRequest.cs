using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_workflow_timestampRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_workflow_timestampState sgt_alg_workflow_timestampStateField;
		private int sgt_alg_workflow_timestampStatusField;
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
		public Sgt_alg_workflow_timestampState Sgt_alg_workflow_timestampState
		{
			get
			{
				return this.sgt_alg_workflow_timestampStateField;
			}
			set
			{
				this.sgt_alg_workflow_timestampStateField = value;
			}
		}
		public int Sgt_alg_workflow_timestampStatus
		{
			get
			{
				return this.sgt_alg_workflow_timestampStatusField;
			}
			set
			{
				this.sgt_alg_workflow_timestampStatusField = value;
			}
		}
	}
}
