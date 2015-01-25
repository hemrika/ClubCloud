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
	public class SetStateSgt_com_competitieinschrijvingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitieinschrijvingState sgt_com_competitieinschrijvingStateField;

		private int sgt_com_competitieinschrijvingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitieinschrijvingState Sgt_com_competitieinschrijvingState
		{
			get
			{
				return this.sgt_com_competitieinschrijvingStateField;
			}
			set
			{
				this.sgt_com_competitieinschrijvingStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitieinschrijvingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitieinschrijvingStatus
		{
			get
			{
				return this.sgt_com_competitieinschrijvingStatusField;
			}
			set
			{
				this.sgt_com_competitieinschrijvingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitieinschrijvingStatus");
			}
		}

		public SetStateSgt_com_competitieinschrijvingRequest()
		{
		}
	}
}