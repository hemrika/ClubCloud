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
	public class SetStateSgt_top_begeleidingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_begeleidingState sgt_top_begeleidingStateField;

		private int sgt_top_begeleidingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_begeleidingState Sgt_top_begeleidingState
		{
			get
			{
				return this.sgt_top_begeleidingStateField;
			}
			set
			{
				this.sgt_top_begeleidingStateField = value;
				base.RaisePropertyChanged("Sgt_top_begeleidingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_top_begeleidingStatus
		{
			get
			{
				return this.sgt_top_begeleidingStatusField;
			}
			set
			{
				this.sgt_top_begeleidingStatusField = value;
				base.RaisePropertyChanged("Sgt_top_begeleidingStatus");
			}
		}

		public SetStateSgt_top_begeleidingRequest()
		{
		}
	}
}