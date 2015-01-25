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
	public class SetStateSgt_bo_opleidingsgroepRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_opleidingsgroepState sgt_bo_opleidingsgroepStateField;

		private int sgt_bo_opleidingsgroepStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_opleidingsgroepState Sgt_bo_opleidingsgroepState
		{
			get
			{
				return this.sgt_bo_opleidingsgroepStateField;
			}
			set
			{
				this.sgt_bo_opleidingsgroepStateField = value;
				base.RaisePropertyChanged("Sgt_bo_opleidingsgroepState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_opleidingsgroepStatus
		{
			get
			{
				return this.sgt_bo_opleidingsgroepStatusField;
			}
			set
			{
				this.sgt_bo_opleidingsgroepStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_opleidingsgroepStatus");
			}
		}

		public SetStateSgt_bo_opleidingsgroepRequest()
		{
		}
	}
}