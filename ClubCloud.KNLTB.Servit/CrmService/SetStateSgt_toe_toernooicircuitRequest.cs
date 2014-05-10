using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooicircuitRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooicircuitState sgt_toe_toernooicircuitStateField;
		private int sgt_toe_toernooicircuitStatusField;
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
		public Sgt_toe_toernooicircuitState Sgt_toe_toernooicircuitState
		{
			get
			{
				return this.sgt_toe_toernooicircuitStateField;
			}
			set
			{
				this.sgt_toe_toernooicircuitStateField = value;
			}
		}
		public int Sgt_toe_toernooicircuitStatus
		{
			get
			{
				return this.sgt_toe_toernooicircuitStatusField;
			}
			set
			{
				this.sgt_toe_toernooicircuitStatusField = value;
			}
		}
	}
}
