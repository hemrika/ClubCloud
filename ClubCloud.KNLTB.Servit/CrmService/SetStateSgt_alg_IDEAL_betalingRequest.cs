using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_IDEAL_betalingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_IDEAL_betalingState sgt_alg_IDEAL_betalingStateField;
		private int sgt_alg_IDEAL_betalingStatusField;
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
		public Sgt_alg_IDEAL_betalingState Sgt_alg_IDEAL_betalingState
		{
			get
			{
				return this.sgt_alg_IDEAL_betalingStateField;
			}
			set
			{
				this.sgt_alg_IDEAL_betalingStateField = value;
			}
		}
		public int Sgt_alg_IDEAL_betalingStatus
		{
			get
			{
				return this.sgt_alg_IDEAL_betalingStatusField;
			}
			set
			{
				this.sgt_alg_IDEAL_betalingStatusField = value;
			}
		}
	}
}