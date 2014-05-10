using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class AppointmentProposal
	{
		private CrmDateTime startField;
		private CrmDateTime endField;
		private Guid siteIdField;
		private string siteNameField;
		private ProposalParty[] proposalPartiesField;
		public CrmDateTime Start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}
		public CrmDateTime End
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
			}
		}
		public Guid SiteId
		{
			get
			{
				return this.siteIdField;
			}
			set
			{
				this.siteIdField = value;
			}
		}
		public string SiteName
		{
			get
			{
				return this.siteNameField;
			}
			set
			{
				this.siteNameField = value;
			}
		}
		public ProposalParty[] ProposalParties
		{
			get
			{
				return this.proposalPartiesField;
			}
			set
			{
				this.proposalPartiesField = value;
			}
		}
	}
}
