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
	public class SetStateSgt_alg_logboek_fact_export_facturenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_fact_export_facturenState sgt_alg_logboek_fact_export_facturenStateField;

		private int sgt_alg_logboek_fact_export_facturenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_fact_export_facturenState Sgt_alg_logboek_fact_export_facturenState
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_facturenStateField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_facturenStateField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_fact_export_facturenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_logboek_fact_export_facturenStatus
		{
			get
			{
				return this.sgt_alg_logboek_fact_export_facturenStatusField;
			}
			set
			{
				this.sgt_alg_logboek_fact_export_facturenStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_fact_export_facturenStatus");
			}
		}

		public SetStateSgt_alg_logboek_fact_export_facturenRequest()
		{
		}
	}
}