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
	public class SetStateSgt_alg_occ_enabled_entityRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_occ_enabled_entityState sgt_alg_occ_enabled_entityStateField;

		private int sgt_alg_occ_enabled_entityStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_occ_enabled_entityState Sgt_alg_occ_enabled_entityState
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityStateField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityStateField = value;
				base.RaisePropertyChanged("Sgt_alg_occ_enabled_entityState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_occ_enabled_entityStatus
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityStatusField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_occ_enabled_entityStatus");
			}
		}

		public SetStateSgt_alg_occ_enabled_entityRequest()
		{
		}
	}
}