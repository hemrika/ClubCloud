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
	public class SetStateSgt_toe_reden_dispensatie_toernooibijdrageRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_reden_dispensatie_toernooibijdrageState sgt_toe_reden_dispensatie_toernooibijdrageStateField;

		private int sgt_toe_reden_dispensatie_toernooibijdrageStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_reden_dispensatie_toernooibijdrageState Sgt_toe_reden_dispensatie_toernooibijdrageState
		{
			get
			{
				return this.sgt_toe_reden_dispensatie_toernooibijdrageStateField;
			}
			set
			{
				this.sgt_toe_reden_dispensatie_toernooibijdrageStateField = value;
				base.RaisePropertyChanged("Sgt_toe_reden_dispensatie_toernooibijdrageState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_reden_dispensatie_toernooibijdrageStatus
		{
			get
			{
				return this.sgt_toe_reden_dispensatie_toernooibijdrageStatusField;
			}
			set
			{
				this.sgt_toe_reden_dispensatie_toernooibijdrageStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_reden_dispensatie_toernooibijdrageStatus");
			}
		}

		public SetStateSgt_toe_reden_dispensatie_toernooibijdrageRequest()
		{
		}
	}
}