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
	public class SetStateSgt_bo_licentie_logboekRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_licentie_logboekState sgt_bo_licentie_logboekStateField;

		private int sgt_bo_licentie_logboekStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_licentie_logboekState Sgt_bo_licentie_logboekState
		{
			get
			{
				return this.sgt_bo_licentie_logboekStateField;
			}
			set
			{
				this.sgt_bo_licentie_logboekStateField = value;
				base.RaisePropertyChanged("Sgt_bo_licentie_logboekState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_licentie_logboekStatus
		{
			get
			{
				return this.sgt_bo_licentie_logboekStatusField;
			}
			set
			{
				this.sgt_bo_licentie_logboekStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_licentie_logboekStatus");
			}
		}

		public SetStateSgt_bo_licentie_logboekRequest()
		{
		}
	}
}