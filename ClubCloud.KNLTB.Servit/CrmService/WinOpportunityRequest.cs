using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class WinOpportunityRequest : Request
	{
		private BusinessEntity opportunityCloseField;
		private int statusField;
		public BusinessEntity OpportunityClose
		{
			get
			{
				return this.opportunityCloseField;
			}
			set
			{
				this.opportunityCloseField = value;
			}
		}
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
	}
}