using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_factuur_typeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_factuur_typeState sgt_fac_factuur_typeStateField;
		private int sgt_fac_factuur_typeStatusField;
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
		public Sgt_fac_factuur_typeState Sgt_fac_factuur_typeState
		{
			get
			{
				return this.sgt_fac_factuur_typeStateField;
			}
			set
			{
				this.sgt_fac_factuur_typeStateField = value;
			}
		}
		public int Sgt_fac_factuur_typeStatus
		{
			get
			{
				return this.sgt_fac_factuur_typeStatusField;
			}
			set
			{
				this.sgt_fac_factuur_typeStatusField = value;
			}
		}
	}
}
