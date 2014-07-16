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
	public class SetStateSgt_alg_pb_mutatie_ledenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_mutatie_ledenState sgt_alg_pb_mutatie_ledenStateField;

		private int sgt_alg_pb_mutatie_ledenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_mutatie_ledenState Sgt_alg_pb_mutatie_ledenState
		{
			get
			{
				return this.sgt_alg_pb_mutatie_ledenStateField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_ledenStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_mutatie_ledenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pb_mutatie_ledenStatus
		{
			get
			{
				return this.sgt_alg_pb_mutatie_ledenStatusField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_ledenStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_mutatie_ledenStatus");
			}
		}

		public SetStateSgt_alg_pb_mutatie_ledenRequest()
		{
		}
	}
}