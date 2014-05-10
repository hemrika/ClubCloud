using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_factuurgroepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_factuurgroepState sgt_fac_factuurgroepStateField;
		private int sgt_fac_factuurgroepStatusField;
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
		public Sgt_fac_factuurgroepState Sgt_fac_factuurgroepState
		{
			get
			{
				return this.sgt_fac_factuurgroepStateField;
			}
			set
			{
				this.sgt_fac_factuurgroepStateField = value;
			}
		}
		public int Sgt_fac_factuurgroepStatus
		{
			get
			{
				return this.sgt_fac_factuurgroepStatusField;
			}
			set
			{
				this.sgt_fac_factuurgroepStatusField = value;
			}
		}
	}
}
