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
	public class SetStateSgt_alg_bouwaardRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_bouwaardState sgt_alg_bouwaardStateField;

		private int sgt_alg_bouwaardStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_bouwaardState Sgt_alg_bouwaardState
		{
			get
			{
				return this.sgt_alg_bouwaardStateField;
			}
			set
			{
				this.sgt_alg_bouwaardStateField = value;
				base.RaisePropertyChanged("Sgt_alg_bouwaardState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_bouwaardStatus
		{
			get
			{
				return this.sgt_alg_bouwaardStatusField;
			}
			set
			{
				this.sgt_alg_bouwaardStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_bouwaardStatus");
			}
		}

		public SetStateSgt_alg_bouwaardRequest()
		{
		}
	}
}