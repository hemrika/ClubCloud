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
	public class SetStateSgt_com_aantal_afdelingenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_aantal_afdelingenState sgt_com_aantal_afdelingenStateField;

		private int sgt_com_aantal_afdelingenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_aantal_afdelingenState Sgt_com_aantal_afdelingenState
		{
			get
			{
				return this.sgt_com_aantal_afdelingenStateField;
			}
			set
			{
				this.sgt_com_aantal_afdelingenStateField = value;
				base.RaisePropertyChanged("Sgt_com_aantal_afdelingenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_aantal_afdelingenStatus
		{
			get
			{
				return this.sgt_com_aantal_afdelingenStatusField;
			}
			set
			{
				this.sgt_com_aantal_afdelingenStatusField = value;
				base.RaisePropertyChanged("Sgt_com_aantal_afdelingenStatus");
			}
		}

		public SetStateSgt_com_aantal_afdelingenRequest()
		{
		}
	}
}