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
	public class SetStateSgt_bo_opleidingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_opleidingState sgt_bo_opleidingStateField;

		private int sgt_bo_opleidingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_opleidingState Sgt_bo_opleidingState
		{
			get
			{
				return this.sgt_bo_opleidingStateField;
			}
			set
			{
				this.sgt_bo_opleidingStateField = value;
				base.RaisePropertyChanged("Sgt_bo_opleidingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_opleidingStatus
		{
			get
			{
				return this.sgt_bo_opleidingStatusField;
			}
			set
			{
				this.sgt_bo_opleidingStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_opleidingStatus");
			}
		}

		public SetStateSgt_bo_opleidingRequest()
		{
		}
	}
}