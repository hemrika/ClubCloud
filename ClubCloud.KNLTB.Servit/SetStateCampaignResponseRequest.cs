using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateCampaignResponseRequest : Request
	{
		private Guid entityIdField;
		private CampaignResponseState campaignResponseStateField;
		private int campaignResponseStatusField;
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
		public CampaignResponseState CampaignResponseState
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
		[XmlElement(Order = 2)]
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
	}
}
