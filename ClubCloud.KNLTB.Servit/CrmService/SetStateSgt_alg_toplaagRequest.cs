using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_toplaagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_toplaagState sgt_alg_toplaagStateField;
		private int sgt_alg_toplaagStatusField;
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
		public Sgt_alg_toplaagState Sgt_alg_toplaagState
		{
			get
			{
				return this.sgt_alg_toplaagStateField;
			}
			set
			{
				this.sgt_alg_toplaagStateField = value;
			}
		}
		public int Sgt_alg_toplaagStatus
		{
			get
			{
				return this.sgt_alg_toplaagStatusField;
			}
			set
			{
				this.sgt_alg_toplaagStatusField = value;
			}
		}
	}
}
