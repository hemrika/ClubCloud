using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_logboek_vnt_meldingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_logboek_vnt_meldingState sgt_bo_logboek_vnt_meldingStateField;
		private int sgt_bo_logboek_vnt_meldingStatusField;
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
		public Sgt_bo_logboek_vnt_meldingState Sgt_bo_logboek_vnt_meldingState
		{
			get
			{
				return this.sgt_bo_logboek_vnt_meldingStateField;
			}
			set
			{
				this.sgt_bo_logboek_vnt_meldingStateField = value;
			}
		}
		public int Sgt_bo_logboek_vnt_meldingStatus
		{
			get
			{
				return this.sgt_bo_logboek_vnt_meldingStatusField;
			}
			set
			{
				this.sgt_bo_logboek_vnt_meldingStatusField = value;
			}
		}
	}
}
