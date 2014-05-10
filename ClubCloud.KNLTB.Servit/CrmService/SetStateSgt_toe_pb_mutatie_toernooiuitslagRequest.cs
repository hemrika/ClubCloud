using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooiuitslagState sgt_toe_pb_mutatie_toernooiuitslagStateField;
		private int sgt_toe_pb_mutatie_toernooiuitslagStatusField;
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
		public Sgt_toe_pb_mutatie_toernooiuitslagState Sgt_toe_pb_mutatie_toernooiuitslagState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslagStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslagStateField = value;
			}
		}
		public int Sgt_toe_pb_mutatie_toernooiuitslagStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslagStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslagStatusField = value;
			}
		}
	}
}
