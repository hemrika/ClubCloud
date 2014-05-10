using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_autorisatie_uitgifteRequest : Request
	{
		private Guid entityIdField;
		private Sgt_autorisatie_uitgifteState sgt_autorisatie_uitgifteStateField;
		private int sgt_autorisatie_uitgifteStatusField;
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
		public Sgt_autorisatie_uitgifteState Sgt_autorisatie_uitgifteState
		{
			get
			{
				return this.sgt_autorisatie_uitgifteStateField;
			}
			set
			{
				this.sgt_autorisatie_uitgifteStateField = value;
			}
		}
		public int Sgt_autorisatie_uitgifteStatus
		{
			get
			{
				return this.sgt_autorisatie_uitgifteStatusField;
			}
			set
			{
				this.sgt_autorisatie_uitgifteStatusField = value;
			}
		}
	}
}
