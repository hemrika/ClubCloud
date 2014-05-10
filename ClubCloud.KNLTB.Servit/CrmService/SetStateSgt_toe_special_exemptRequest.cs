using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_special_exemptRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_special_exemptState sgt_toe_special_exemptStateField;
		private int sgt_toe_special_exemptStatusField;
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
		public Sgt_toe_special_exemptState Sgt_toe_special_exemptState
		{
			get
			{
				return this.sgt_toe_special_exemptStateField;
			}
			set
			{
				this.sgt_toe_special_exemptStateField = value;
			}
		}
		public int Sgt_toe_special_exemptStatus
		{
			get
			{
				return this.sgt_toe_special_exemptStatusField;
			}
			set
			{
				this.sgt_toe_special_exemptStatusField = value;
			}
		}
	}
}
