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
	public class SetStateSgt_com_ploegopgaveRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegopgaveState sgt_com_ploegopgaveStateField;

		private int sgt_com_ploegopgaveStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegopgaveState Sgt_com_ploegopgaveState
		{
			get
			{
				return this.sgt_com_ploegopgaveStateField;
			}
			set
			{
				this.sgt_com_ploegopgaveStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploegopgaveState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_ploegopgaveStatus
		{
			get
			{
				return this.sgt_com_ploegopgaveStatusField;
			}
			set
			{
				this.sgt_com_ploegopgaveStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploegopgaveStatus");
			}
		}

		public SetStateSgt_com_ploegopgaveRequest()
		{
		}
	}
}