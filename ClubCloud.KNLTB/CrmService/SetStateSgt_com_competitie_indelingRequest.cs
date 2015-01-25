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
	public class SetStateSgt_com_competitie_indelingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitie_indelingState sgt_com_competitie_indelingStateField;

		private int sgt_com_competitie_indelingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitie_indelingState Sgt_com_competitie_indelingState
		{
			get
			{
				return this.sgt_com_competitie_indelingStateField;
			}
			set
			{
				this.sgt_com_competitie_indelingStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitie_indelingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitie_indelingStatus
		{
			get
			{
				return this.sgt_com_competitie_indelingStatusField;
			}
			set
			{
				this.sgt_com_competitie_indelingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitie_indelingStatus");
			}
		}

		public SetStateSgt_com_competitie_indelingRequest()
		{
		}
	}
}