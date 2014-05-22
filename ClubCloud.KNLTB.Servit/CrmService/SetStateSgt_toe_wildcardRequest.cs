using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_wildcardRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_wildcardState sgt_toe_wildcardStateField;
		private int sgt_toe_wildcardStatusField;
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
		public Sgt_toe_wildcardState Sgt_toe_wildcardState
		{
			get
			{
				return this.sgt_toe_wildcardStateField;
			}
			set
			{
				this.sgt_toe_wildcardStateField = value;
			}
		}
		public int Sgt_toe_wildcardStatus
		{
			get
			{
				return this.sgt_toe_wildcardStatusField;
			}
			set
			{
				this.sgt_toe_wildcardStatusField = value;
			}
		}
	}
}