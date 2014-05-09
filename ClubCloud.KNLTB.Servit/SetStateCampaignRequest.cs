using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateCampaignRequest : Request
	{
		private Guid entityIdField;
		private CampaignState campaignStateField;
		private int campaignStatusField;
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
		public CampaignState CampaignState
		{
			get
			{
				return this.campaignStateField;
			}
			set
			{
				this.campaignStateField = value;
				base.RaisePropertyChanged("CampaignState");
			}
		}
		[XmlElement(Order = 2)]
		public int CampaignStatus
		{
			get
			{
				return this.campaignStatusField;
			}
			set
			{
				this.campaignStatusField = value;
				base.RaisePropertyChanged("CampaignStatus");
			}
		}
	}
}
