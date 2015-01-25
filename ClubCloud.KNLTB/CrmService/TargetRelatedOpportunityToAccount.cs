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
	public class TargetRelatedOpportunityToAccount : TargetRelated
	{
		private Guid opportunityIdField;

		private Guid accountIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid AccountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
				base.RaisePropertyChanged("AccountId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid OpportunityId
		{
			get
			{
				return this.opportunityIdField;
			}
			set
			{
				this.opportunityIdField = value;
				base.RaisePropertyChanged("OpportunityId");
			}
		}

		public TargetRelatedOpportunityToAccount()
		{
		}
	}
}