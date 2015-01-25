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
	public class SetStateSgt_com_competitie_afsluitingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitie_afsluitingState sgt_com_competitie_afsluitingStateField;

		private int sgt_com_competitie_afsluitingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitie_afsluitingState Sgt_com_competitie_afsluitingState
		{
			get
			{
				return this.sgt_com_competitie_afsluitingStateField;
			}
			set
			{
				this.sgt_com_competitie_afsluitingStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitie_afsluitingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitie_afsluitingStatus
		{
			get
			{
				return this.sgt_com_competitie_afsluitingStatusField;
			}
			set
			{
				this.sgt_com_competitie_afsluitingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitie_afsluitingStatus");
			}
		}

		public SetStateSgt_com_competitie_afsluitingRequest()
		{
		}
	}
}