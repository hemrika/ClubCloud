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
	public class SetStateSgt_toe_niet_knltb_ledenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_niet_knltb_ledenState sgt_toe_niet_knltb_ledenStateField;

		private int sgt_toe_niet_knltb_ledenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_niet_knltb_ledenState Sgt_toe_niet_knltb_ledenState
		{
			get
			{
				return this.sgt_toe_niet_knltb_ledenStateField;
			}
			set
			{
				this.sgt_toe_niet_knltb_ledenStateField = value;
				base.RaisePropertyChanged("Sgt_toe_niet_knltb_ledenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_niet_knltb_ledenStatus
		{
			get
			{
				return this.sgt_toe_niet_knltb_ledenStatusField;
			}
			set
			{
				this.sgt_toe_niet_knltb_ledenStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_niet_knltb_ledenStatus");
			}
		}

		public SetStateSgt_toe_niet_knltb_ledenRequest()
		{
		}
	}
}