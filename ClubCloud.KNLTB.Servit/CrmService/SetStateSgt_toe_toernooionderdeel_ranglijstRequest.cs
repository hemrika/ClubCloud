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
	public class SetStateSgt_toe_toernooionderdeel_ranglijstRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooionderdeel_ranglijstState sgt_toe_toernooionderdeel_ranglijstStateField;

		private int sgt_toe_toernooionderdeel_ranglijstStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooionderdeel_ranglijstState Sgt_toe_toernooionderdeel_ranglijstState
		{
			get
			{
				return this.sgt_toe_toernooionderdeel_ranglijstStateField;
			}
			set
			{
				this.sgt_toe_toernooionderdeel_ranglijstStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooionderdeel_ranglijstState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooionderdeel_ranglijstStatus
		{
			get
			{
				return this.sgt_toe_toernooionderdeel_ranglijstStatusField;
			}
			set
			{
				this.sgt_toe_toernooionderdeel_ranglijstStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooionderdeel_ranglijstStatus");
			}
		}

		public SetStateSgt_toe_toernooionderdeel_ranglijstRequest()
		{
		}
	}
}