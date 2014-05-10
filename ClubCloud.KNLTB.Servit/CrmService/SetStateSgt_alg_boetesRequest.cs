using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_boetesRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_boetesState sgt_alg_boetesStateField;
		private int sgt_alg_boetesStatusField;
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
		public Sgt_alg_boetesState Sgt_alg_boetesState
		{
			get
			{
				return this.sgt_alg_boetesStateField;
			}
			set
			{
				this.sgt_alg_boetesStateField = value;
			}
		}
		public int Sgt_alg_boetesStatus
		{
			get
			{
				return this.sgt_alg_boetesStatusField;
			}
			set
			{
				this.sgt_alg_boetesStatusField = value;
			}
		}
	}
}
