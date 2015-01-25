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
	public class RemoveItemCampaignActivityRequest : Request
	{
		private Guid campaignActivityIdField;

		private Guid itemIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid CampaignActivityId
		{
			get
			{
				return this.campaignActivityIdField;
			}
			set
			{
				this.campaignActivityIdField = value;
				base.RaisePropertyChanged("CampaignActivityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ItemId
		{
			get
			{
				return this.itemIdField;
			}
			set
			{
				this.itemIdField = value;
				base.RaisePropertyChanged("ItemId");
			}
		}

		public RemoveItemCampaignActivityRequest()
		{
		}
	}
}