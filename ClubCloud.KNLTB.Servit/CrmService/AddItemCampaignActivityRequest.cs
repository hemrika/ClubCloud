using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class AddItemCampaignActivityRequest : Request
	{
		private Guid campaignActivityIdField;
		private Guid itemIdField;
		private EntityName entityNameField;
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
		public EntityName EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
			}
		}
	}
}
