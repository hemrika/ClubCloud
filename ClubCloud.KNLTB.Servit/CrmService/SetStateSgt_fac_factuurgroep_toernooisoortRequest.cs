using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_factuurgroep_toernooisoortRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_factuurgroep_toernooisoortState sgt_fac_factuurgroep_toernooisoortStateField;
		private int sgt_fac_factuurgroep_toernooisoortStatusField;
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
		public Sgt_fac_factuurgroep_toernooisoortState Sgt_fac_factuurgroep_toernooisoortState
		{
			get
			{
				return this.sgt_fac_factuurgroep_toernooisoortStateField;
			}
			set
			{
				this.sgt_fac_factuurgroep_toernooisoortStateField = value;
			}
		}
		public int Sgt_fac_factuurgroep_toernooisoortStatus
		{
			get
			{
				return this.sgt_fac_factuurgroep_toernooisoortStatusField;
			}
			set
			{
				this.sgt_fac_factuurgroep_toernooisoortStatusField = value;
			}
		}
	}
}
