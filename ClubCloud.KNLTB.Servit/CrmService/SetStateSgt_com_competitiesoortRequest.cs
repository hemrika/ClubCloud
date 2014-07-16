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
	public class SetStateSgt_com_competitiesoortRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitiesoortState sgt_com_competitiesoortStateField;

		private int sgt_com_competitiesoortStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitiesoortState Sgt_com_competitiesoortState
		{
			get
			{
				return this.sgt_com_competitiesoortStateField;
			}
			set
			{
				this.sgt_com_competitiesoortStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitiesoortState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitiesoortStatus
		{
			get
			{
				return this.sgt_com_competitiesoortStatusField;
			}
			set
			{
				this.sgt_com_competitiesoortStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitiesoortStatus");
			}
		}

		public SetStateSgt_com_competitiesoortRequest()
		{
		}
	}
}