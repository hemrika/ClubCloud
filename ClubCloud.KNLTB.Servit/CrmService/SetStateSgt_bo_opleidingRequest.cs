using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_opleidingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_opleidingState sgt_bo_opleidingStateField;
		private int sgt_bo_opleidingStatusField;
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
		public Sgt_bo_opleidingState Sgt_bo_opleidingState
		{
			get
			{
				return this.sgt_bo_opleidingStateField;
			}
			set
			{
				this.sgt_bo_opleidingStateField = value;
			}
		}
		public int Sgt_bo_opleidingStatus
		{
			get
			{
				return this.sgt_bo_opleidingStatusField;
			}
			set
			{
				this.sgt_bo_opleidingStatusField = value;
			}
		}
	}
}
