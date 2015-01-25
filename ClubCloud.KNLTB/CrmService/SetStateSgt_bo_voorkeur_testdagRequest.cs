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
	public class SetStateSgt_bo_voorkeur_testdagRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_voorkeur_testdagState sgt_bo_voorkeur_testdagStateField;

		private int sgt_bo_voorkeur_testdagStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_voorkeur_testdagState Sgt_bo_voorkeur_testdagState
		{
			get
			{
				return this.sgt_bo_voorkeur_testdagStateField;
			}
			set
			{
				this.sgt_bo_voorkeur_testdagStateField = value;
				base.RaisePropertyChanged("Sgt_bo_voorkeur_testdagState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_voorkeur_testdagStatus
		{
			get
			{
				return this.sgt_bo_voorkeur_testdagStatusField;
			}
			set
			{
				this.sgt_bo_voorkeur_testdagStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_voorkeur_testdagStatus");
			}
		}

		public SetStateSgt_bo_voorkeur_testdagRequest()
		{
		}
	}
}