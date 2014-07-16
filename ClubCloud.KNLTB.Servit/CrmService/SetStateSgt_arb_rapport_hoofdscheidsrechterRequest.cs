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
	public class SetStateSgt_arb_rapport_hoofdscheidsrechterRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_rapport_hoofdscheidsrechterState sgt_arb_rapport_hoofdscheidsrechterStateField;

		private int sgt_arb_rapport_hoofdscheidsrechterStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_rapport_hoofdscheidsrechterState Sgt_arb_rapport_hoofdscheidsrechterState
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechterStateField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechterStateField = value;
				base.RaisePropertyChanged("Sgt_arb_rapport_hoofdscheidsrechterState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_rapport_hoofdscheidsrechterStatus
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechterStatusField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechterStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_rapport_hoofdscheidsrechterStatus");
			}
		}

		public SetStateSgt_arb_rapport_hoofdscheidsrechterRequest()
		{
		}
	}
}