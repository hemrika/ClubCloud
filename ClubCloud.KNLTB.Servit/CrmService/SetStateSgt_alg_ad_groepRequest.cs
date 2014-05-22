using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_ad_groepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_ad_groepState sgt_alg_ad_groepStateField;
		private int sgt_alg_ad_groepStatusField;
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
		public Sgt_alg_ad_groepState Sgt_alg_ad_groepState
		{
			get
			{
				return this.sgt_alg_ad_groepStateField;
			}
			set
			{
				this.sgt_alg_ad_groepStateField = value;
			}
		}
		public int Sgt_alg_ad_groepStatus
		{
			get
			{
				return this.sgt_alg_ad_groepStatusField;
			}
			set
			{
				this.sgt_alg_ad_groepStatusField = value;
			}
		}
	}
}