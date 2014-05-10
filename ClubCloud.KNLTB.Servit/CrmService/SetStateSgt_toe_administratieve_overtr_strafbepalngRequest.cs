using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_administratieve_overtr_strafbepalngRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_administratieve_overtr_strafbepalngState sgt_toe_administratieve_overtr_strafbepalngStateField;
		private int sgt_toe_administratieve_overtr_strafbepalngStatusField;
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
		public Sgt_toe_administratieve_overtr_strafbepalngState Sgt_toe_administratieve_overtr_strafbepalngState
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafbepalngStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafbepalngStateField = value;
			}
		}
		public int Sgt_toe_administratieve_overtr_strafbepalngStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafbepalngStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafbepalngStatusField = value;
			}
		}
	}
}
