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
	public class SetStateSgt_toe_toernooischema_spelerRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooischema_spelerState sgt_toe_toernooischema_spelerStateField;

		private int sgt_toe_toernooischema_spelerStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooischema_spelerState Sgt_toe_toernooischema_spelerState
		{
			get
			{
				return this.sgt_toe_toernooischema_spelerStateField;
			}
			set
			{
				this.sgt_toe_toernooischema_spelerStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooischema_spelerState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooischema_spelerStatus
		{
			get
			{
				return this.sgt_toe_toernooischema_spelerStatusField;
			}
			set
			{
				this.sgt_toe_toernooischema_spelerStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooischema_spelerStatus");
			}
		}

		public SetStateSgt_toe_toernooischema_spelerRequest()
		{
		}
	}
}