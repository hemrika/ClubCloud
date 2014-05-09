using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetRelatedOpportunityToCompetitor : TargetRelated
	{
		private Guid opportunityIdField;
		private Guid competitorIdField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Guid CompetitorId
		{
			get
			{
				return this.competitorIdField;
			}
			set
			{
				this.competitorIdField = value;
				base.RaisePropertyChanged("CompetitorId");
			}
		}
	}
}
