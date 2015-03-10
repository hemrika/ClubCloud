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
	public class SetStateSgt_alg_soort_abonnementRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_soort_abonnementState sgt_alg_soort_abonnementStateField;

		private int sgt_alg_soort_abonnementStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_soort_abonnementState Sgt_alg_soort_abonnementState
		{
			get
			{
				return this.sgt_alg_soort_abonnementStateField;
			}
			set
			{
				this.sgt_alg_soort_abonnementStateField = value;
				base.RaisePropertyChanged("Sgt_alg_soort_abonnementState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_soort_abonnementStatus
		{
			get
			{
				return this.sgt_alg_soort_abonnementStatusField;
			}
			set
			{
				this.sgt_alg_soort_abonnementStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_soort_abonnementStatus");
			}
		}

		public SetStateSgt_alg_soort_abonnementRequest()
		{
		}
	}
}