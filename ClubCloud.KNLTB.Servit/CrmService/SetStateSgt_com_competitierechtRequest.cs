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
	public class SetStateSgt_com_competitierechtRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitierechtState sgt_com_competitierechtStateField;

		private int sgt_com_competitierechtStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitierechtState Sgt_com_competitierechtState
		{
			get
			{
				return this.sgt_com_competitierechtStateField;
			}
			set
			{
				this.sgt_com_competitierechtStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitierechtState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitierechtStatus
		{
			get
			{
				return this.sgt_com_competitierechtStatusField;
			}
			set
			{
				this.sgt_com_competitierechtStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitierechtStatus");
			}
		}

		public SetStateSgt_com_competitierechtRequest()
		{
		}
	}
}