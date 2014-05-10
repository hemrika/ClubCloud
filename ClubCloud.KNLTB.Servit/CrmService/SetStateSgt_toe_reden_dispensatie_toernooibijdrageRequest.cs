using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_reden_dispensatie_toernooibijdrageRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_reden_dispensatie_toernooibijdrageState sgt_toe_reden_dispensatie_toernooibijdrageStateField;
		private int sgt_toe_reden_dispensatie_toernooibijdrageStatusField;
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
		public Sgt_toe_reden_dispensatie_toernooibijdrageState Sgt_toe_reden_dispensatie_toernooibijdrageState
		{
			get
			{
				return this.sgt_toe_reden_dispensatie_toernooibijdrageStateField;
			}
			set
			{
				this.sgt_toe_reden_dispensatie_toernooibijdrageStateField = value;
			}
		}
		public int Sgt_toe_reden_dispensatie_toernooibijdrageStatus
		{
			get
			{
				return this.sgt_toe_reden_dispensatie_toernooibijdrageStatusField;
			}
			set
			{
				this.sgt_toe_reden_dispensatie_toernooibijdrageStatusField = value;
			}
		}
	}
}
