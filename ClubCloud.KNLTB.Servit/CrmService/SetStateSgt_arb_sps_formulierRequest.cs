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
	public class SetStateSgt_arb_sps_formulierRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_sps_formulierState sgt_arb_sps_formulierStateField;

		private int sgt_arb_sps_formulierStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_sps_formulierState Sgt_arb_sps_formulierState
		{
			get
			{
				return this.sgt_arb_sps_formulierStateField;
			}
			set
			{
				this.sgt_arb_sps_formulierStateField = value;
				base.RaisePropertyChanged("Sgt_arb_sps_formulierState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_sps_formulierStatus
		{
			get
			{
				return this.sgt_arb_sps_formulierStatusField;
			}
			set
			{
				this.sgt_arb_sps_formulierStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_sps_formulierStatus");
			}
		}

		public SetStateSgt_arb_sps_formulierRequest()
		{
		}
	}
}