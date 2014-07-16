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
	public class SetStateCampaignActivityRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.CampaignActivityState campaignActivityStateField;

		private int campaignActivityStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.CampaignActivityState CampaignActivityState
		{
			get
			{
				return this.campaignActivityStateField;
			}
			set
			{
				this.campaignActivityStateField = value;
				base.RaisePropertyChanged("CampaignActivityState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int CampaignActivityStatus
		{
			get
			{
				return this.campaignActivityStatusField;
			}
			set
			{
				this.campaignActivityStatusField = value;
				base.RaisePropertyChanged("CampaignActivityStatus");
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

		public SetStateCampaignActivityRequest()
		{
		}
	}
}