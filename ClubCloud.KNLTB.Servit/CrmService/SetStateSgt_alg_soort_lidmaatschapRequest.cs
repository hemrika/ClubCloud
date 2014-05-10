using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_soort_lidmaatschapRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_soort_lidmaatschapState sgt_alg_soort_lidmaatschapStateField;
		private int sgt_alg_soort_lidmaatschapStatusField;
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
		public Sgt_alg_soort_lidmaatschapState Sgt_alg_soort_lidmaatschapState
		{
			get
			{
				return this.sgt_alg_soort_lidmaatschapStateField;
			}
			set
			{
				this.sgt_alg_soort_lidmaatschapStateField = value;
			}
		}
		public int Sgt_alg_soort_lidmaatschapStatus
		{
			get
			{
				return this.sgt_alg_soort_lidmaatschapStatusField;
			}
			set
			{
				this.sgt_alg_soort_lidmaatschapStatusField = value;
			}
		}
	}
}
