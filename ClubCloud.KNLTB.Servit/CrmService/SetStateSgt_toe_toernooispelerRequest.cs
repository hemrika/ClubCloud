using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooispelerRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooispelerState sgt_toe_toernooispelerStateField;
		private int sgt_toe_toernooispelerStatusField;
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
		public Sgt_toe_toernooispelerState Sgt_toe_toernooispelerState
		{
			get
			{
				return this.sgt_toe_toernooispelerStateField;
			}
			set
			{
				this.sgt_toe_toernooispelerStateField = value;
			}
		}
		public int Sgt_toe_toernooispelerStatus
		{
			get
			{
				return this.sgt_toe_toernooispelerStatusField;
			}
			set
			{
				this.sgt_toe_toernooispelerStatusField = value;
			}
		}
	}
}
