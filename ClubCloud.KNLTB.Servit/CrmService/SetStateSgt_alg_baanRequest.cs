using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_baanRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_baanState sgt_alg_baanStateField;
		private int sgt_alg_baanStatusField;
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
		public Sgt_alg_baanState Sgt_alg_baanState
		{
			get
			{
				return this.sgt_alg_baanStateField;
			}
			set
			{
				this.sgt_alg_baanStateField = value;
			}
		}
		public int Sgt_alg_baanStatus
		{
			get
			{
				return this.sgt_alg_baanStatusField;
			}
			set
			{
				this.sgt_alg_baanStatusField = value;
			}
		}
	}
}
