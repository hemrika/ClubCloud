using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_logboek_ecampus_resultaten_meldingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_logboek_ecampus_resultaten_meldingState sgt_logboek_ecampus_resultaten_meldingStateField;
		private int sgt_logboek_ecampus_resultaten_meldingStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_logboek_ecampus_resultaten_meldingState Sgt_logboek_ecampus_resultaten_meldingState
		{
			get
			{
				return this.sgt_logboek_ecampus_resultaten_meldingStateField;
			}
			set
			{
				this.sgt_logboek_ecampus_resultaten_meldingStateField = value;
			}
		}
		public int Sgt_logboek_ecampus_resultaten_meldingStatus
		{
			get
			{
				return this.sgt_logboek_ecampus_resultaten_meldingStatusField;
			}
			set
			{
				this.sgt_logboek_ecampus_resultaten_meldingStatusField = value;
			}
		}
	}
}