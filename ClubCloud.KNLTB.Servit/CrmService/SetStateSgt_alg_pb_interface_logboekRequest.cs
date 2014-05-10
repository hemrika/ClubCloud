using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_interface_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_interface_logboekState sgt_alg_pb_interface_logboekStateField;
		private int sgt_alg_pb_interface_logboekStatusField;
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
		public Sgt_alg_pb_interface_logboekState Sgt_alg_pb_interface_logboekState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboekStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboekStateField = value;
			}
		}
		public int Sgt_alg_pb_interface_logboekStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboekStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboekStatusField = value;
			}
		}
	}
}
