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
	public class SetStateSgt_toe_toernooionderdeelRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooionderdeelState sgt_toe_toernooionderdeelStateField;

		private int sgt_toe_toernooionderdeelStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooionderdeelState Sgt_toe_toernooionderdeelState
		{
			get
			{
				return this.sgt_toe_toernooionderdeelStateField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooionderdeelState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooionderdeelStatus
		{
			get
			{
				return this.sgt_toe_toernooionderdeelStatusField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooionderdeelStatus");
			}
		}

		public SetStateSgt_toe_toernooionderdeelRequest()
		{
		}
	}
}