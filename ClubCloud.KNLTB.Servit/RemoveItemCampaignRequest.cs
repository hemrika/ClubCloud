using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RemoveItemCampaignRequest : Request
	{
		private Guid campaignIdField;
		private Guid entityIdField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
	}
}
