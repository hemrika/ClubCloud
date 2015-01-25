using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateSgt_bo_inschrijfformulier_testdagRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_inschrijfformulier_testdagState sgt_bo_inschrijfformulier_testdagStateField;

		private int sgt_bo_inschrijfformulier_testdagStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_inschrijfformulier_testdagState Sgt_bo_inschrijfformulier_testdagState
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

		[XmlElement] //[XmlElement(Order=2)]
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

		public SetStateSgt_bo_inschrijfformulier_testdagRequest()
		{
		}
	}
}