using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ExecuteCampaignActivityRequest : Request
	{
		private Guid campaignActivityIdField;
		private bool propagateField;
		private BusinessEntity activityField;
		private Guid templateIdField;
		private PropagationOwnershipOptions ownershipOptionsField;
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
		public bool Propagate
		{
			get
			{
				return this.propagateField;
			}
			set
			{
				this.propagateField = value;
			}
		}
		public BusinessEntity Activity
		{
			get
			{
				return this.activityField;
			}
			set
			{
				this.activityField = value;
			}
		}
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
			}
		}
		public PropagationOwnershipOptions OwnershipOptions
		{
			get
			{
				return this.ownershipOptionsField;
			}
			set
			{
				this.ownershipOptionsField = value;
			}
		}
	}
}
