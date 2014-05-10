using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_inschrijfformulier_testdagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_inschrijfformulier_testdagState sgt_bo_inschrijfformulier_testdagStateField;
		private int sgt_bo_inschrijfformulier_testdagStatusField;
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
		public Sgt_bo_inschrijfformulier_testdagState Sgt_bo_inschrijfformulier_testdagState
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdagStateField;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdagStateField = value;
			}
		}
		public int Sgt_bo_inschrijfformulier_testdagStatus
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdagStatusField;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdagStatusField = value;
			}
		}
	}
}
