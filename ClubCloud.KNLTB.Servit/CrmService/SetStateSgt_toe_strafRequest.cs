using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_strafRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_strafState sgt_toe_strafStateField;
		private int sgt_toe_strafStatusField;
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
		public Sgt_toe_strafState Sgt_toe_strafState
		{
			get
			{
				return this.sgt_toe_strafStateField;
			}
			set
			{
				this.sgt_toe_strafStateField = value;
			}
		}
		public int Sgt_toe_strafStatus
		{
			get
			{
				return this.sgt_toe_strafStatusField;
			}
			set
			{
				this.sgt_toe_strafStatusField = value;
			}
		}
	}
}
