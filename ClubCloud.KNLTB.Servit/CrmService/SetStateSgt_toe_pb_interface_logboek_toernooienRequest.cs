using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_interface_logboek_toernooienRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_interface_logboek_toernooienState sgt_toe_pb_interface_logboek_toernooienStateField;
		private int sgt_toe_pb_interface_logboek_toernooienStatusField;
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
		public Sgt_toe_pb_interface_logboek_toernooienState Sgt_toe_pb_interface_logboek_toernooienState
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooienStateField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooienStateField = value;
			}
		}
		public int Sgt_toe_pb_interface_logboek_toernooienStatus
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooienStatusField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooienStatusField = value;
			}
		}
	}
}
