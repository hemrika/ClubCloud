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
	public class SetStateSgt_alg_pb_mutatie_functionarissenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_mutatie_functionarissenState sgt_alg_pb_mutatie_functionarissenStateField;

		private int sgt_alg_pb_mutatie_functionarissenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_mutatie_functionarissenState Sgt_alg_pb_mutatie_functionarissenState
		{
			get
			{
				return this.sgt_alg_pb_mutatie_functionarissenStateField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_functionarissenStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_mutatie_functionarissenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pb_mutatie_functionarissenStatus
		{
			get
			{
				return this.sgt_alg_pb_mutatie_functionarissenStatusField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_functionarissenStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_mutatie_functionarissenStatus");
			}
		}

		public SetStateSgt_alg_pb_mutatie_functionarissenRequest()
		{
		}
	}
}