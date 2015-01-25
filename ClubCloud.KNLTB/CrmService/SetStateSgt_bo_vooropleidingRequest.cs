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
	public class SetStateSgt_bo_vooropleidingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_vooropleidingState sgt_bo_vooropleidingStateField;

		private int sgt_bo_vooropleidingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_vooropleidingState Sgt_bo_vooropleidingState
		{
			get
			{
				return this.sgt_bo_vooropleidingStateField;
			}
			set
			{
				this.sgt_bo_vooropleidingStateField = value;
				base.RaisePropertyChanged("Sgt_bo_vooropleidingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_vooropleidingStatus
		{
			get
			{
				return this.sgt_bo_vooropleidingStatusField;
			}
			set
			{
				this.sgt_bo_vooropleidingStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_vooropleidingStatus");
			}
		}

		public SetStateSgt_bo_vooropleidingRequest()
		{
		}
	}
}