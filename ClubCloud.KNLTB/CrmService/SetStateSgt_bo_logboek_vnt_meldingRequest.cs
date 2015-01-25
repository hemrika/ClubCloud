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
	public class SetStateSgt_bo_logboek_vnt_meldingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_logboek_vnt_meldingState sgt_bo_logboek_vnt_meldingStateField;

		private int sgt_bo_logboek_vnt_meldingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_logboek_vnt_meldingState Sgt_bo_logboek_vnt_meldingState
		{
			get
			{
				return this.sgt_bo_logboek_vnt_meldingStateField;
			}
			set
			{
				this.sgt_bo_logboek_vnt_meldingStateField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_vnt_meldingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_logboek_vnt_meldingStatus
		{
			get
			{
				return this.sgt_bo_logboek_vnt_meldingStatusField;
			}
			set
			{
				this.sgt_bo_logboek_vnt_meldingStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_vnt_meldingStatus");
			}
		}

		public SetStateSgt_bo_logboek_vnt_meldingRequest()
		{
		}
	}
}