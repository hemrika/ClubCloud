using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_cursistRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_cursistState sgt_bo_cursistStateField;
		private int sgt_bo_cursistStatusField;
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
		public Sgt_bo_cursistState Sgt_bo_cursistState
		{
			get
			{
				return this.sgt_bo_cursistStateField;
			}
			set
			{
				this.sgt_bo_cursistStateField = value;
			}
		}
		public int Sgt_bo_cursistStatus
		{
			get
			{
				return this.sgt_bo_cursistStatusField;
			}
			set
			{
				this.sgt_bo_cursistStatusField = value;
			}
		}
	}
}
