using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateCampaignRequest : Request
	{
		private Guid entityIdField;
		private CampaignState campaignStateField;
		private int campaignStatusField;
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
		public CampaignState CampaignState
		{
			get
			{
				return this.campaignStateField;
			}
			set
			{
				this.campaignStateField = value;
			}
		}
		public int CampaignStatus
		{
			get
			{
				return this.campaignStatusField;
			}
			set
			{
				this.campaignStatusField = value;
			}
		}
	}
}
