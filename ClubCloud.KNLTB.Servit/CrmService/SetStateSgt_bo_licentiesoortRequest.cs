using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_licentiesoortRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_licentiesoortState sgt_bo_licentiesoortStateField;
		private int sgt_bo_licentiesoortStatusField;
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
		public Sgt_bo_licentiesoortState Sgt_bo_licentiesoortState
		{
			get
			{
				return this.sgt_bo_licentiesoortStateField;
			}
			set
			{
				this.sgt_bo_licentiesoortStateField = value;
			}
		}
		public int Sgt_bo_licentiesoortStatus
		{
			get
			{
				return this.sgt_bo_licentiesoortStatusField;
			}
			set
			{
				this.sgt_bo_licentiesoortStatusField = value;
			}
		}
	}
}
