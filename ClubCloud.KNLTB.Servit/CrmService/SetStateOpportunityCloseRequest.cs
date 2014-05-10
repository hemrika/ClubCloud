using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateOpportunityCloseRequest : Request
	{
		private Guid entityIdField;
		private OpportunityCloseState opportunityCloseStateField;
		private int opportunityCloseStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public OpportunityCloseState OpportunityCloseState
		{
			get
			{
				return this.opportunityCloseStateField;
			}
			set
			{
				this.opportunityCloseStateField = value;
			}
		}
		public int OpportunityCloseStatus
		{
			get
			{
				return this.opportunityCloseStatusField;
			}
			set
			{
				this.opportunityCloseStatusField = value;
			}
		}
	}
}
