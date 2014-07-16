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
	public class SetStateSgt_alg_boetesRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_boetesState sgt_alg_boetesStateField;

		private int sgt_alg_boetesStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_boetesState Sgt_alg_boetesState
		{
			get
			{
				return this.sgt_alg_boetesStateField;
			}
			set
			{
				this.sgt_alg_boetesStateField = value;
				base.RaisePropertyChanged("Sgt_alg_boetesState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_boetesStatus
		{
			get
			{
				return this.sgt_alg_boetesStatusField;
			}
			set
			{
				this.sgt_alg_boetesStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_boetesStatus");
			}
		}

		public SetStateSgt_alg_boetesRequest()
		{
		}
	}
}