using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_occ_enabled_entityRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_occ_enabled_entityState sgt_alg_occ_enabled_entityStateField;
		private int sgt_alg_occ_enabled_entityStatusField;
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
		public Sgt_alg_occ_enabled_entityState Sgt_alg_occ_enabled_entityState
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityStateField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityStateField = value;
			}
		}
		public int Sgt_alg_occ_enabled_entityStatus
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityStatusField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityStatusField = value;
			}
		}
	}
}
