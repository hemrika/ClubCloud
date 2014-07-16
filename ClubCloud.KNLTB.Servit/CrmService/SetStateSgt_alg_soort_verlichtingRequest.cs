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
	public class SetStateSgt_alg_soort_verlichtingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_soort_verlichtingState sgt_alg_soort_verlichtingStateField;

		private int sgt_alg_soort_verlichtingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_soort_verlichtingState Sgt_alg_soort_verlichtingState
		{
			get
			{
				return this.sgt_alg_soort_verlichtingStateField;
			}
			set
			{
				this.sgt_alg_soort_verlichtingStateField = value;
				base.RaisePropertyChanged("Sgt_alg_soort_verlichtingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_soort_verlichtingStatus
		{
			get
			{
				return this.sgt_alg_soort_verlichtingStatusField;
			}
			set
			{
				this.sgt_alg_soort_verlichtingStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_soort_verlichtingStatus");
			}
		}

		public SetStateSgt_alg_soort_verlichtingRequest()
		{
		}
	}
}