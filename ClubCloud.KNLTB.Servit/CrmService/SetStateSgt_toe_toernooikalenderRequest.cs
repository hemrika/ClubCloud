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
	public class SetStateSgt_toe_toernooikalenderRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooikalenderState sgt_toe_toernooikalenderStateField;

		private int sgt_toe_toernooikalenderStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooikalenderState Sgt_toe_toernooikalenderState
		{
			get
			{
				return this.sgt_toe_toernooikalenderStateField;
			}
			set
			{
				this.sgt_toe_toernooikalenderStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooikalenderState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooikalenderStatus
		{
			get
			{
				return this.sgt_toe_toernooikalenderStatusField;
			}
			set
			{
				this.sgt_toe_toernooikalenderStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooikalenderStatus");
			}
		}

		public SetStateSgt_toe_toernooikalenderRequest()
		{
		}
	}
}