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
	public class SetStateSgt_com_ploeginschrijvingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploeginschrijvingState sgt_com_ploeginschrijvingStateField;

		private int sgt_com_ploeginschrijvingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploeginschrijvingState Sgt_com_ploeginschrijvingState
		{
			get
			{
				return this.sgt_com_ploeginschrijvingStateField;
			}
			set
			{
				this.sgt_com_ploeginschrijvingStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploeginschrijvingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_ploeginschrijvingStatus
		{
			get
			{
				return this.sgt_com_ploeginschrijvingStatusField;
			}
			set
			{
				this.sgt_com_ploeginschrijvingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploeginschrijvingStatus");
			}
		}

		public SetStateSgt_com_ploeginschrijvingRequest()
		{
		}
	}
}