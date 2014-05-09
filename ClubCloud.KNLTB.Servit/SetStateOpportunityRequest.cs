using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateOpportunityRequest : Request
	{
		private Guid entityIdField;
		private OpportunityState opportunityStateField;
		private int opportunityStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public OpportunityState OpportunityState
		{
			get
			{
				return this.opportunityStateField;
			}
			set
			{
				this.opportunityStateField = value;
				base.RaisePropertyChanged("OpportunityState");
			}
		}
		[XmlElement(Order = 2)]
		public int OpportunityStatus
		{
			get
			{
				return this.opportunityStatusField;
			}
			set
			{
				this.opportunityStatusField = value;
				base.RaisePropertyChanged("OpportunityStatus");
			}
		}
	}
}
