using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_mutatie_functionarissenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_mutatie_functionarissenState sgt_alg_pb_mutatie_functionarissenStateField;
		private int sgt_alg_pb_mutatie_functionarissenStatusField;
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
		public Sgt_alg_pb_mutatie_functionarissenState Sgt_alg_pb_mutatie_functionarissenState
		{
			get
			{
				return this.sgt_alg_pb_mutatie_functionarissenStateField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_functionarissenStateField = value;
			}
		}
		public int Sgt_alg_pb_mutatie_functionarissenStatus
		{
			get
			{
				return this.sgt_alg_pb_mutatie_functionarissenStatusField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_functionarissenStatusField = value;
			}
		}
	}
}