using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_record_lockRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_record_lockState sgt_alg_record_lockStateField;
		private int sgt_alg_record_lockStatusField;
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
		public Sgt_alg_record_lockState Sgt_alg_record_lockState
		{
			get
			{
				return this.sgt_alg_record_lockStateField;
			}
			set
			{
				this.sgt_alg_record_lockStateField = value;
			}
		}
		public int Sgt_alg_record_lockStatus
		{
			get
			{
				return this.sgt_alg_record_lockStatusField;
			}
			set
			{
				this.sgt_alg_record_lockStatusField = value;
			}
		}
	}
}
