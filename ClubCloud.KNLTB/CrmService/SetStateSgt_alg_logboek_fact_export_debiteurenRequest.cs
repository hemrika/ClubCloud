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
	public class SetStateSgt_alg_logboek_fact_export_debiteurenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_fact_export_debiteurenState sgt_alg_logboek_fact_export_debiteurenStateField;

		private int sgt_alg_logboek_fact_export_debiteurenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_fact_export_debiteurenState Sgt_alg_logboek_fact_export_debiteurenState
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_debiteurenStateField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_debiteurenStateField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_fact_export_debiteurenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_logboek_fact_export_debiteurenStatus
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_debiteurenStatusField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_debiteurenStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_fact_export_debiteurenStatus");
			}
		}

		public SetStateSgt_alg_logboek_fact_export_debiteurenRequest()
		{
		}
	}
}