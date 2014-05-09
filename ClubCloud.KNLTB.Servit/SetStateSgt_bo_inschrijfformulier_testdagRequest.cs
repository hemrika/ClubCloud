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
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public Sgt_bo_inschrijfformulier_testdagState Sgt_bo_inschrijfformulier_testdagState
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdagStateField;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdagStateField = value;
				base.RaisePropertyChanged("Sgt_bo_inschrijfformulier_testdagState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_bo_inschrijfformulier_testdagStatus
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdagStatusField;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdagStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_inschrijfformulier_testdagStatus");
			}
		}
	}
}
