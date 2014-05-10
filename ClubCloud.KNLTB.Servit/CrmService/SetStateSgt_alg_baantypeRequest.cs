using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_baantypeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_baantypeState sgt_alg_baantypeStateField;
		private int sgt_alg_baantypeStatusField;
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
		public Sgt_alg_baantypeState Sgt_alg_baantypeState
		{
			get
			{
				return this.sgt_alg_baantypeStateField;
			}
			set
			{
				this.sgt_alg_baantypeStateField = value;
			}
		}
		public int Sgt_alg_baantypeStatus
		{
			get
			{
				return this.sgt_alg_baantypeStatusField;
			}
			set
			{
				this.sgt_alg_baantypeStatusField = value;
			}
		}
	}
}
