using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ronde_pouleRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ronde_pouleState sgt_toe_ronde_pouleStateField;
		private int sgt_toe_ronde_pouleStatusField;
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
		public Sgt_toe_ronde_pouleState Sgt_toe_ronde_pouleState
		{
			get
			{
				return this.sgt_toe_ronde_pouleStateField;
			}
			set
			{
				this.sgt_toe_ronde_pouleStateField = value;
			}
		}
		public int Sgt_toe_ronde_pouleStatus
		{
			get
			{
				return this.sgt_toe_ronde_pouleStatusField;
			}
			set
			{
				this.sgt_toe_ronde_pouleStatusField = value;
			}
		}
	}
}
