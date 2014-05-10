using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_testdagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_testdagState sgt_bo_testdagStateField;
		private int sgt_bo_testdagStatusField;
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
		public Sgt_bo_testdagState Sgt_bo_testdagState
		{
			get
			{
				return this.sgt_bo_testdagStateField;
			}
			set
			{
				this.sgt_bo_testdagStateField = value;
			}
		}
		public int Sgt_bo_testdagStatus
		{
			get
			{
				return this.sgt_bo_testdagStatusField;
			}
			set
			{
				this.sgt_bo_testdagStatusField = value;
			}
		}
	}
}
