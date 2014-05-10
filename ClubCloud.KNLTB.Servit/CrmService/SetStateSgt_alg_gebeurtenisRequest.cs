using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_gebeurtenisRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_gebeurtenisState sgt_alg_gebeurtenisStateField;
		private int sgt_alg_gebeurtenisStatusField;
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
		public Sgt_alg_gebeurtenisState Sgt_alg_gebeurtenisState
		{
			get
			{
				return this.sgt_alg_gebeurtenisStateField;
			}
			set
			{
				this.sgt_alg_gebeurtenisStateField = value;
			}
		}
		public int Sgt_alg_gebeurtenisStatus
		{
			get
			{
				return this.sgt_alg_gebeurtenisStatusField;
			}
			set
			{
				this.sgt_alg_gebeurtenisStatusField = value;
			}
		}
	}
}
