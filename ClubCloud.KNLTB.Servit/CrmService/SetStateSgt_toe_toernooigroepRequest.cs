using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooigroepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooigroepState sgt_toe_toernooigroepStateField;
		private int sgt_toe_toernooigroepStatusField;
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
		public Sgt_toe_toernooigroepState Sgt_toe_toernooigroepState
		{
			get
			{
				return this.sgt_toe_toernooigroepStateField;
			}
			set
			{
				this.sgt_toe_toernooigroepStateField = value;
			}
		}
		public int Sgt_toe_toernooigroepStatus
		{
			get
			{
				return this.sgt_toe_toernooigroepStatusField;
			}
			set
			{
				this.sgt_toe_toernooigroepStatusField = value;
			}
		}
	}
}
