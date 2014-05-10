using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_examenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_examenState sgt_bo_examenStateField;
		private int sgt_bo_examenStatusField;
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
		public Sgt_bo_examenState Sgt_bo_examenState
		{
			get
			{
				return this.sgt_bo_examenStateField;
			}
			set
			{
				this.sgt_bo_examenStateField = value;
			}
		}
		public int Sgt_bo_examenStatus
		{
			get
			{
				return this.sgt_bo_examenStatusField;
			}
			set
			{
				this.sgt_bo_examenStatusField = value;
			}
		}
	}
}
