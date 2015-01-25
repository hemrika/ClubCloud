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
	public class SetStateCampaignRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.CampaignState campaignStateField;

		private int campaignStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.CampaignState CampaignState
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		public SetStateCampaignRequest()
		{
		}
	}
}