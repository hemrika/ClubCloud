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
	public class SetStateSgt_toe_toernooicircuitRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooicircuitState sgt_toe_toernooicircuitStateField;

		private int sgt_toe_toernooicircuitStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooicircuitState Sgt_toe_toernooicircuitState
		{
			get
			{
				return this.sgt_toe_toernooicircuitStateField;
			}
			set
			{
				this.sgt_toe_toernooicircuitStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooicircuitState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooicircuitStatus
		{
			get
			{
				return this.sgt_toe_toernooicircuitStatusField;
			}
			set
			{
				this.sgt_toe_toernooicircuitStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooicircuitStatus");
			}
		}

		public SetStateSgt_toe_toernooicircuitRequest()
		{
		}
	}
}