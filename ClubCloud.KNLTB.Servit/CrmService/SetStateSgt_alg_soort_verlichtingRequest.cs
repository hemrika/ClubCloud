using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_soort_verlichtingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_soort_verlichtingState sgt_alg_soort_verlichtingStateField;
		private int sgt_alg_soort_verlichtingStatusField;
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
		public Sgt_alg_soort_verlichtingState Sgt_alg_soort_verlichtingState
		{
			get
			{
				return this.sgt_alg_soort_verlichtingStateField;
			}
			set
			{
				this.sgt_alg_soort_verlichtingStateField = value;
			}
		}
		public int Sgt_alg_soort_verlichtingStatus
		{
			get
			{
				return this.sgt_alg_soort_verlichtingStatusField;
			}
			set
			{
				this.sgt_alg_soort_verlichtingStatusField = value;
			}
		}
	}
}
