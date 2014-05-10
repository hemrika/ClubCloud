using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_post_inRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_post_inState sgt_toe_post_inStateField;
		private int sgt_toe_post_inStatusField;
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
		public Sgt_toe_post_inState Sgt_toe_post_inState
		{
			get
			{
				return this.sgt_toe_post_inStateField;
			}
			set
			{
				this.sgt_toe_post_inStateField = value;
			}
		}
		public int Sgt_toe_post_inStatus
		{
			get
			{
				return this.sgt_toe_post_inStatusField;
			}
			set
			{
				this.sgt_toe_post_inStatusField = value;
			}
		}
	}
}
