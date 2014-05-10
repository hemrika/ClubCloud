using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_administratieve_overtr_beroepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_administratieve_overtr_beroepState sgt_toe_administratieve_overtr_beroepStateField;
		private int sgt_toe_administratieve_overtr_beroepStatusField;
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
		public Sgt_toe_administratieve_overtr_beroepState Sgt_toe_administratieve_overtr_beroepState
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroepStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroepStateField = value;
			}
		}
		public int Sgt_toe_administratieve_overtr_beroepStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroepStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroepStatusField = value;
			}
		}
	}
}
