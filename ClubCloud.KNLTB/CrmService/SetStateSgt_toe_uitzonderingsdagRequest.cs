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
	public class SetStateSgt_toe_uitzonderingsdagRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_uitzonderingsdagState sgt_toe_uitzonderingsdagStateField;

		private int sgt_toe_uitzonderingsdagStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_uitzonderingsdagState Sgt_toe_uitzonderingsdagState
		{
			get
			{
				return this.sgt_toe_uitzonderingsdagStateField;
			}
			set
			{
				this.sgt_toe_uitzonderingsdagStateField = value;
				base.RaisePropertyChanged("Sgt_toe_uitzonderingsdagState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_uitzonderingsdagStatus
		{
			get
			{
				return this.sgt_toe_uitzonderingsdagStatusField;
			}
			set
			{
				this.sgt_toe_uitzonderingsdagStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_uitzonderingsdagStatus");
			}
		}

		public SetStateSgt_toe_uitzonderingsdagRequest()
		{
		}
	}
}