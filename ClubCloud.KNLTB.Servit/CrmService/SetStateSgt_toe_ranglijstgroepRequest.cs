using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijstgroepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijstgroepState sgt_toe_ranglijstgroepStateField;
		private int sgt_toe_ranglijstgroepStatusField;
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
		public Sgt_toe_ranglijstgroepState Sgt_toe_ranglijstgroepState
		{
			get
			{
				return this.sgt_toe_ranglijstgroepStateField;
			}
			set
			{
				this.sgt_toe_ranglijstgroepStateField = value;
			}
		}
		public int Sgt_toe_ranglijstgroepStatus
		{
			get
			{
				return this.sgt_toe_ranglijstgroepStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstgroepStatusField = value;
			}
		}
	}
}
