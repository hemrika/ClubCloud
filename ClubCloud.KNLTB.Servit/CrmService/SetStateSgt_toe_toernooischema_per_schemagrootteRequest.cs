using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooischema_per_schemagrootteRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooischema_per_schemagrootteState sgt_toe_toernooischema_per_schemagrootteStateField;
		private int sgt_toe_toernooischema_per_schemagrootteStatusField;
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
		public Sgt_toe_toernooischema_per_schemagrootteState Sgt_toe_toernooischema_per_schemagrootteState
		{
			get
			{
				return this.sgt_toe_toernooischema_per_schemagrootteStateField;
			}
			set
			{
				this.sgt_toe_toernooischema_per_schemagrootteStateField = value;
			}
		}
		public int Sgt_toe_toernooischema_per_schemagrootteStatus
		{
			get
			{
				return this.sgt_toe_toernooischema_per_schemagrootteStatusField;
			}
			set
			{
				this.sgt_toe_toernooischema_per_schemagrootteStatusField = value;
			}
		}
	}
}
