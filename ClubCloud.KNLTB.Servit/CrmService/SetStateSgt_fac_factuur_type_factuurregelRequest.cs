using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_factuur_type_factuurregelRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_factuur_type_factuurregelState sgt_fac_factuur_type_factuurregelStateField;
		private int sgt_fac_factuur_type_factuurregelStatusField;
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
		public Sgt_fac_factuur_type_factuurregelState Sgt_fac_factuur_type_factuurregelState
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelStateField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelStateField = value;
			}
		}
		public int Sgt_fac_factuur_type_factuurregelStatus
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelStatusField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelStatusField = value;
			}
		}
	}
}
