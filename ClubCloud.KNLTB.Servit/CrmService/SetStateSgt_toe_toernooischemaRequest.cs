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
	public class SetStateSgt_toe_toernooischemaRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooischemaState sgt_toe_toernooischemaStateField;

		private int sgt_toe_toernooischemaStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooischemaState Sgt_toe_toernooischemaState
		{
			get
			{
				return this.sgt_toe_toernooischemaStateField;
			}
			set
			{
				this.sgt_toe_toernooischemaStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooischemaState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooischemaStatus
		{
			get
			{
				return this.sgt_toe_toernooischemaStatusField;
			}
			set
			{
				this.sgt_toe_toernooischemaStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooischemaStatus");
			}
		}

		public SetStateSgt_toe_toernooischemaRequest()
		{
		}
	}
}