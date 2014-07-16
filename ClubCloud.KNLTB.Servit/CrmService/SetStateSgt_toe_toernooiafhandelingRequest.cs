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
	public class SetStateSgt_toe_toernooiafhandelingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooiafhandelingState sgt_toe_toernooiafhandelingStateField;

		private int sgt_toe_toernooiafhandelingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooiafhandelingState Sgt_toe_toernooiafhandelingState
		{
			get
			{
				return this.sgt_toe_toernooiafhandelingStateField;
			}
			set
			{
				this.sgt_toe_toernooiafhandelingStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooiafhandelingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooiafhandelingStatus
		{
			get
			{
				return this.sgt_toe_toernooiafhandelingStatusField;
			}
			set
			{
				this.sgt_toe_toernooiafhandelingStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooiafhandelingStatus");
			}
		}

		public SetStateSgt_toe_toernooiafhandelingRequest()
		{
		}
	}
}