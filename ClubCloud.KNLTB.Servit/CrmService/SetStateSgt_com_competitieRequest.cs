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
	public class SetStateSgt_com_competitieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitieState sgt_com_competitieStateField;

		private int sgt_com_competitieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitieState Sgt_com_competitieState
		{
			get
			{
				return this.sgt_com_competitieStateField;
			}
			set
			{
				this.sgt_com_competitieStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitieStatus
		{
			get
			{
				return this.sgt_com_competitieStatusField;
			}
			set
			{
				this.sgt_com_competitieStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitieStatus");
			}
		}

		public SetStateSgt_com_competitieRequest()
		{
		}
	}
}