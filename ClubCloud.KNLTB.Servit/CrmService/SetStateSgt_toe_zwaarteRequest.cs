using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_zwaarteRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_zwaarteState sgt_toe_zwaarteStateField;
		private int sgt_toe_zwaarteStatusField;
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
		public Sgt_toe_zwaarteState Sgt_toe_zwaarteState
		{
			get
			{
				return this.sgt_toe_zwaarteStateField;
			}
			set
			{
				this.sgt_toe_zwaarteStateField = value;
			}
		}
		public int Sgt_toe_zwaarteStatus
		{
			get
			{
				return this.sgt_toe_zwaarteStatusField;
			}
			set
			{
				this.sgt_toe_zwaarteStatusField = value;
			}
		}
	}
}
