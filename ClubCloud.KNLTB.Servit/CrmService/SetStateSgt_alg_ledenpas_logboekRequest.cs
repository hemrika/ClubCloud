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
	public class SetStateSgt_alg_ledenpas_logboekRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_ledenpas_logboekState sgt_alg_ledenpas_logboekStateField;

		private int sgt_alg_ledenpas_logboekStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_ledenpas_logboekState Sgt_alg_ledenpas_logboekState
		{
			get
			{
				return this.sgt_alg_ledenpas_logboekStateField;
			}
			set
			{
				this.sgt_alg_ledenpas_logboekStateField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_logboekState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_ledenpas_logboekStatus
		{
			get
			{
				return this.sgt_alg_ledenpas_logboekStatusField;
			}
			set
			{
				this.sgt_alg_ledenpas_logboekStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_logboekStatus");
			}
		}

		public SetStateSgt_alg_ledenpas_logboekRequest()
		{
		}
	}
}