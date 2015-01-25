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
	public class SetStateSgt_toe_toernooionderdeelgeneratorRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooionderdeelgeneratorState sgt_toe_toernooionderdeelgeneratorStateField;

		private int sgt_toe_toernooionderdeelgeneratorStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooionderdeelgeneratorState Sgt_toe_toernooionderdeelgeneratorState
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgeneratorStateField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgeneratorStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooionderdeelgeneratorState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooionderdeelgeneratorStatus
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgeneratorStatusField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgeneratorStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooionderdeelgeneratorStatus");
			}
		}

		public SetStateSgt_toe_toernooionderdeelgeneratorRequest()
		{
		}
	}
}