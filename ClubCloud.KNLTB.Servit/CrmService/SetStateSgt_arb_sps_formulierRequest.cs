using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_sps_formulierRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_sps_formulierState sgt_arb_sps_formulierStateField;
		private int sgt_arb_sps_formulierStatusField;
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
		public Sgt_arb_sps_formulierState Sgt_arb_sps_formulierState
		{
			get
			{
				return this.sgt_arb_sps_formulierStateField;
			}
			set
			{
				this.sgt_arb_sps_formulierStateField = value;
			}
		}
		public int Sgt_arb_sps_formulierStatus
		{
			get
			{
				return this.sgt_arb_sps_formulierStatusField;
			}
			set
			{
				this.sgt_arb_sps_formulierStatusField = value;
			}
		}
	}
}
