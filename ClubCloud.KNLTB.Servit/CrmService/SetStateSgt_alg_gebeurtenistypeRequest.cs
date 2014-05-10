using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_gebeurtenistypeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_gebeurtenistypeState sgt_alg_gebeurtenistypeStateField;
		private int sgt_alg_gebeurtenistypeStatusField;
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
		public Sgt_alg_gebeurtenistypeState Sgt_alg_gebeurtenistypeState
		{
			get
			{
				return this.sgt_alg_gebeurtenistypeStateField;
			}
			set
			{
				this.sgt_alg_gebeurtenistypeStateField = value;
			}
		}
		public int Sgt_alg_gebeurtenistypeStatus
		{
			get
			{
				return this.sgt_alg_gebeurtenistypeStatusField;
			}
			set
			{
				this.sgt_alg_gebeurtenistypeStatusField = value;
			}
		}
	}
}
