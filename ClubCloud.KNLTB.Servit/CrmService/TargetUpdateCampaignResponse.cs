using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateCampaignResponse : TargetUpdate
	{
		private campaignresponse campaignResponseField;
		public campaignresponse CampaignResponse
		{
			get
			{
				return this.campaignResponseField;
			}
			set
			{
				this.campaignResponseField = value;
			}
		}
	}
}
