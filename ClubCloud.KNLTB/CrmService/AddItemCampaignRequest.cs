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
	public class AddItemCampaignRequest : Request
	{
		private Guid campaignIdField;

		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.EntityName entityNameField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid CampaignId
		{
			get
			{
				return this.campaignIdField;
			}
			set
			{
				this.campaignIdField = value;
				base.RaisePropertyChanged("CampaignId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
		public ClubCloud.KNLTB.ServIt.CrmService.EntityName EntityName
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

		public AddItemCampaignRequest()
		{
		}
	}
}