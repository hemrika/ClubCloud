using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class AddItemCampaignActivityRequest : Request
	{
		private Guid campaignActivityIdField;
		private Guid itemIdField;
		private EntityName entityNameField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
		public EntityName EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
				base.RaisePropertyChanged("EntityName");
			}
		}
	}
}
