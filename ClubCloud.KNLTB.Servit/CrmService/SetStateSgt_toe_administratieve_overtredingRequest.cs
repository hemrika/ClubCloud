using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_administratieve_overtredingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_administratieve_overtredingState sgt_toe_administratieve_overtredingStateField;
		private int sgt_toe_administratieve_overtredingStatusField;
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
		public Sgt_toe_administratieve_overtredingState Sgt_toe_administratieve_overtredingState
		{
			get
			{
				return this.sgt_toe_administratieve_overtredingStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtredingStateField = value;
			}
		}
		public int Sgt_toe_administratieve_overtredingStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtredingStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtredingStatusField = value;
			}
		}
	}
}
