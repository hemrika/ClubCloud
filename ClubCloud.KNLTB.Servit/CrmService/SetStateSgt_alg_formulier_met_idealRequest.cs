using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_formulier_met_idealRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_formulier_met_idealState sgt_alg_formulier_met_idealStateField;
		private int sgt_alg_formulier_met_idealStatusField;
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
		public Sgt_alg_formulier_met_idealState Sgt_alg_formulier_met_idealState
		{
			get
			{
				return this.sgt_alg_formulier_met_idealStateField;
			}
			set
			{
				this.sgt_alg_formulier_met_idealStateField = value;
			}
		}
		public int Sgt_alg_formulier_met_idealStatus
		{
			get
			{
				return this.sgt_alg_formulier_met_idealStatusField;
			}
			set
			{
				this.sgt_alg_formulier_met_idealStatusField = value;
			}
		}
	}
}
