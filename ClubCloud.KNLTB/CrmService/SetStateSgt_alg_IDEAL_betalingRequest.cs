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
	public class SetStateSgt_alg_IDEAL_betalingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_IDEAL_betalingState sgt_alg_IDEAL_betalingStateField;

		private int sgt_alg_IDEAL_betalingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_IDEAL_betalingState Sgt_alg_IDEAL_betalingState
		{
			get
			{
				return this.sgt_alg_IDEAL_betalingStateField;
			}
			set
			{
				this.sgt_alg_IDEAL_betalingStateField = value;
				base.RaisePropertyChanged("Sgt_alg_IDEAL_betalingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_IDEAL_betalingStatus
		{
			get
			{
				return this.sgt_alg_IDEAL_betalingStatusField;
			}
			set
			{
				this.sgt_alg_IDEAL_betalingStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_IDEAL_betalingStatus");
			}
		}

		public SetStateSgt_alg_IDEAL_betalingRequest()
		{
		}
	}
}