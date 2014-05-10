using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateCampaignActivityRequest : Request
	{
		private Guid entityIdField;
		private CampaignActivityState campaignActivityStateField;
		private int campaignActivityStatusField;
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
		public CampaignActivityState CampaignActivityState
		{
			get
			{
				return this.campaignActivityStateField;
			}
			set
			{
				this.campaignActivityStateField = value;
			}
		}
		public int CampaignActivityStatus
		{
			get
			{
				return this.campaignActivityStatusField;
			}
			set
			{
				this.campaignActivityStatusField = value;
			}
		}
	}
}
