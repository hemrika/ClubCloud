using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_formulier_antwoordRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_formulier_antwoordState sgt_alg_formulier_antwoordStateField;
		private int sgt_alg_formulier_antwoordStatusField;
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
		public Sgt_alg_formulier_antwoordState Sgt_alg_formulier_antwoordState
		{
			get
			{
				return this.sgt_alg_formulier_antwoordStateField;
			}
			set
			{
				this.sgt_alg_formulier_antwoordStateField = value;
			}
		}
		public int Sgt_alg_formulier_antwoordStatus
		{
			get
			{
				return this.sgt_alg_formulier_antwoordStatusField;
			}
			set
			{
				this.sgt_alg_formulier_antwoordStatusField = value;
			}
		}
	}
}
