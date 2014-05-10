using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_circuit_deelgetalRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_circuit_deelgetalState sgt_toe_circuit_deelgetalStateField;
		private int sgt_toe_circuit_deelgetalStatusField;
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
		public Sgt_toe_circuit_deelgetalState Sgt_toe_circuit_deelgetalState
		{
			get
			{
				return this.sgt_toe_circuit_deelgetalStateField;
			}
			set
			{
				this.sgt_toe_circuit_deelgetalStateField = value;
			}
		}
		public int Sgt_toe_circuit_deelgetalStatus
		{
			get
			{
				return this.sgt_toe_circuit_deelgetalStatusField;
			}
			set
			{
				this.sgt_toe_circuit_deelgetalStatusField = value;
			}
		}
	}
}
