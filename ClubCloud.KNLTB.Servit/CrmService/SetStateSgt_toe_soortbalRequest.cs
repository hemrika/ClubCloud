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
	public class SetStateSgt_toe_soortbalRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_soortbalState sgt_toe_soortbalStateField;

		private int sgt_toe_soortbalStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_soortbalState Sgt_toe_soortbalState
		{
			get
			{
				return this.sgt_toe_soortbalStateField;
			}
			set
			{
				this.sgt_toe_soortbalStateField = value;
				base.RaisePropertyChanged("Sgt_toe_soortbalState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_soortbalStatus
		{
			get
			{
				return this.sgt_toe_soortbalStatusField;
			}
			set
			{
				this.sgt_toe_soortbalStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_soortbalStatus");
			}
		}

		public SetStateSgt_toe_soortbalRequest()
		{
		}
	}
}