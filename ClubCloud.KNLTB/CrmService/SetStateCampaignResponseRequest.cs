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
	public class SetStateCampaignResponseRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.CampaignResponseState campaignResponseStateField;

		private int campaignResponseStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.CampaignResponseState CampaignResponseState
		{
			get
			{
				return this.campaignResponseStateField;
			}
			set
			{
				this.campaignResponseStateField = value;
				base.RaisePropertyChanged("CampaignResponseState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int CampaignResponseStatus
		{
			get
			{
				return this.campaignResponseStatusField;
			}
			set
			{
				this.campaignResponseStatusField = value;
				base.RaisePropertyChanged("CampaignResponseStatus");
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

		public SetStateCampaignResponseRequest()
		{
		}
	}
}