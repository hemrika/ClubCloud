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
	public class SetStateSgt_arb_sps_strafRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_sps_strafState sgt_arb_sps_strafStateField;

		private int sgt_arb_sps_strafStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_sps_strafState Sgt_arb_sps_strafState
		{
			get
			{
				return this.sgt_arb_sps_strafStateField;
			}
			set
			{
				this.sgt_arb_sps_strafStateField = value;
				base.RaisePropertyChanged("Sgt_arb_sps_strafState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_sps_strafStatus
		{
			get
			{
				return this.sgt_arb_sps_strafStatusField;
			}
			set
			{
				this.sgt_arb_sps_strafStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_sps_strafStatus");
			}
		}

		public SetStateSgt_arb_sps_strafRequest()
		{
		}
	}
}