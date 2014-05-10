using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_schorsingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_schorsingState sgt_alg_schorsingStateField;
		private int sgt_alg_schorsingStatusField;
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
		public Sgt_alg_schorsingState Sgt_alg_schorsingState
		{
			get
			{
				return this.sgt_alg_schorsingStateField;
			}
			set
			{
				this.sgt_alg_schorsingStateField = value;
			}
		}
		public int Sgt_alg_schorsingStatus
		{
			get
			{
				return this.sgt_alg_schorsingStatusField;
			}
			set
			{
				this.sgt_alg_schorsingStatusField = value;
			}
		}
	}
}
