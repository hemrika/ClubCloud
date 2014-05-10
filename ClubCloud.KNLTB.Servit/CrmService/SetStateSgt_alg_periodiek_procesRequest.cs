using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_periodiek_procesRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_periodiek_procesState sgt_alg_periodiek_procesStateField;
		private int sgt_alg_periodiek_procesStatusField;
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
		public Sgt_alg_periodiek_procesState Sgt_alg_periodiek_procesState
		{
			get
			{
				return this.sgt_alg_periodiek_procesStateField;
			}
			set
			{
				this.sgt_alg_periodiek_procesStateField = value;
			}
		}
		public int Sgt_alg_periodiek_procesStatus
		{
			get
			{
				return this.sgt_alg_periodiek_procesStatusField;
			}
			set
			{
				this.sgt_alg_periodiek_procesStatusField = value;
			}
		}
	}
}
