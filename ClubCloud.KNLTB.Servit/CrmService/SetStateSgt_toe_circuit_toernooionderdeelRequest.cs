using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_circuit_toernooionderdeelRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_circuit_toernooionderdeelState sgt_toe_circuit_toernooionderdeelStateField;
		private int sgt_toe_circuit_toernooionderdeelStatusField;
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
		public Sgt_toe_circuit_toernooionderdeelState Sgt_toe_circuit_toernooionderdeelState
		{
			get
			{
				return this.sgt_toe_circuit_toernooionderdeelStateField;
			}
			set
			{
				this.sgt_toe_circuit_toernooionderdeelStateField = value;
			}
		}
		public int Sgt_toe_circuit_toernooionderdeelStatus
		{
			get
			{
				return this.sgt_toe_circuit_toernooionderdeelStatusField;
			}
			set
			{
				this.sgt_toe_circuit_toernooionderdeelStatusField = value;
			}
		}
	}
}