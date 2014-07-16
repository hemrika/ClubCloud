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
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslagRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_pb_mutatie_toernooiuitslagState sgt_toe_pb_mutatie_toernooiuitslagStateField;

		private int sgt_toe_pb_mutatie_toernooiuitslagStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_pb_mutatie_toernooiuitslagState Sgt_toe_pb_mutatie_toernooiuitslagState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslagStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslagStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslagState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_pb_mutatie_toernooiuitslagStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslagStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslagStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslagStatus");
			}
		}

		public SetStateSgt_toe_pb_mutatie_toernooiuitslagRequest()
		{
		}
	}
}