using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateSgt_toe_circuit_deelgetalRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_circuit_deelgetalState sgt_toe_circuit_deelgetalStateField;

		private int sgt_toe_circuit_deelgetalStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_circuit_deelgetalState Sgt_toe_circuit_deelgetalState
		{
			get
			{
				return this.sgt_toe_circuit_deelgetalStateField;
			}
			set
			{
				this.sgt_toe_circuit_deelgetalStateField = value;
				base.RaisePropertyChanged("Sgt_toe_circuit_deelgetalState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_circuit_deelgetalStatus
		{
			get
			{
				return this.sgt_toe_circuit_deelgetalStatusField;
			}
			set
			{
				this.sgt_toe_circuit_deelgetalStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_circuit_deelgetalStatus");
			}
		}

		public SetStateSgt_toe_circuit_deelgetalRequest()
		{
		}
	}
}