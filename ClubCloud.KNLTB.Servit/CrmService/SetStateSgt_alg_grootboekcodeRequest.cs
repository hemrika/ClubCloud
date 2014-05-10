using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_grootboekcodeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_grootboekcodeState sgt_alg_grootboekcodeStateField;
		private int sgt_alg_grootboekcodeStatusField;
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
		public Sgt_alg_grootboekcodeState Sgt_alg_grootboekcodeState
		{
			get
			{
				return this.sgt_alg_grootboekcodeStateField;
			}
			set
			{
				this.sgt_alg_grootboekcodeStateField = value;
			}
		}
		public int Sgt_alg_grootboekcodeStatus
		{
			get
			{
				return this.sgt_alg_grootboekcodeStatusField;
			}
			set
			{
				this.sgt_alg_grootboekcodeStatusField = value;
			}
		}
	}
}
