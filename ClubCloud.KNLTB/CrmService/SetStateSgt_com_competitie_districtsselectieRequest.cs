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
	public class SetStateSgt_com_competitie_districtsselectieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitie_districtsselectieState sgt_com_competitie_districtsselectieStateField;

		private int sgt_com_competitie_districtsselectieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitie_districtsselectieState Sgt_com_competitie_districtsselectieState
		{
			get
			{
				return this.sgt_com_competitie_districtsselectieStateField;
			}
			set
			{
				this.sgt_com_competitie_districtsselectieStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitie_districtsselectieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitie_districtsselectieStatus
		{
			get
			{
				return this.sgt_com_competitie_districtsselectieStatusField;
			}
			set
			{
				this.sgt_com_competitie_districtsselectieStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitie_districtsselectieStatus");
			}
		}

		public SetStateSgt_com_competitie_districtsselectieRequest()
		{
		}
	}
}