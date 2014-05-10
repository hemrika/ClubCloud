using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_bouwaardRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_bouwaardState sgt_alg_bouwaardStateField;
		private int sgt_alg_bouwaardStatusField;
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
		public Sgt_alg_bouwaardState Sgt_alg_bouwaardState
		{
			get
			{
				return this.sgt_alg_bouwaardStateField;
			}
			set
			{
				this.sgt_alg_bouwaardStateField = value;
			}
		}
		public int Sgt_alg_bouwaardStatus
		{
			get
			{
				return this.sgt_alg_bouwaardStatusField;
			}
			set
			{
				this.sgt_alg_bouwaardStatusField = value;
			}
		}
	}
}
