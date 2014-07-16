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
	public class SetStateSgt_alg_pasfoto_bulkimport_logboekRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pasfoto_bulkimport_logboekState sgt_alg_pasfoto_bulkimport_logboekStateField;

		private int sgt_alg_pasfoto_bulkimport_logboekStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pasfoto_bulkimport_logboekState Sgt_alg_pasfoto_bulkimport_logboekState
		{
			get
			{
				return this.sgt_alg_pasfoto_bulkimport_logboekStateField;
			}
			set
			{
				this.sgt_alg_pasfoto_bulkimport_logboekStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pasfoto_bulkimport_logboekState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pasfoto_bulkimport_logboekStatus
		{
			get
			{
				return this.sgt_alg_pasfoto_bulkimport_logboekStatusField;
			}
			set
			{
				this.sgt_alg_pasfoto_bulkimport_logboekStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pasfoto_bulkimport_logboekStatus");
			}
		}

		public SetStateSgt_alg_pasfoto_bulkimport_logboekRequest()
		{
		}
	}
}