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
	public class SetStateOpportunityCloseRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.OpportunityCloseState opportunityCloseStateField;

		private int opportunityCloseStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.OpportunityCloseState OpportunityCloseState
		{
			get
			{
				return this.opportunityCloseStateField;
			}
			set
			{
				this.opportunityCloseStateField = value;
				base.RaisePropertyChanged("OpportunityCloseState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int OpportunityCloseStatus
		{
			get
			{
				return this.opportunityCloseStatusField;
			}
			set
			{
				this.opportunityCloseStatusField = value;
				base.RaisePropertyChanged("OpportunityCloseStatus");
			}
		}

		public SetStateOpportunityCloseRequest()
		{
		}
	}
}