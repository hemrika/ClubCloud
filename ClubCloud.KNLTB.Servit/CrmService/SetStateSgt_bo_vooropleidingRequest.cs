using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_vooropleidingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_vooropleidingState sgt_bo_vooropleidingStateField;
		private int sgt_bo_vooropleidingStatusField;
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
		public Sgt_bo_vooropleidingState Sgt_bo_vooropleidingState
		{
			get
			{
				return this.sgt_bo_vooropleidingStateField;
			}
			set
			{
				this.sgt_bo_vooropleidingStateField = value;
			}
		}
		public int Sgt_bo_vooropleidingStatus
		{
			get
			{
				return this.sgt_bo_vooropleidingStatusField;
			}
			set
			{
				this.sgt_bo_vooropleidingStatusField = value;
			}
		}
	}
}
