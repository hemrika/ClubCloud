using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RemoveItemCampaignActivityRequest : Request
	{
		private Guid campaignActivityIdField;
		private Guid itemIdField;
		public Guid CampaignActivityId
		{
			get
			{
				return this.campaignActivityIdField;
			}
			set
			{
				this.campaignActivityIdField = value;
			}
		}
		public Guid ItemId
		{
			get
			{
				return this.itemIdField;
			}
			set
			{
				this.itemIdField = value;
			}
		}
	}
}
