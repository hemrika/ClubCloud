using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateOpportunityProduct : TargetUpdate
	{
		private opportunityproduct opportunityProductField;
		public opportunityproduct OpportunityProduct
		{
			get
			{
				return this.opportunityProductField;
			}
			set
			{
				this.opportunityProductField = value;
			}
		}
	}
}
