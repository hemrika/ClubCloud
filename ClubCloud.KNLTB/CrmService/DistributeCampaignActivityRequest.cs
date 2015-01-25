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
	public class DistributeCampaignActivityRequest : Request
	{
		private Guid campaignActivityIdField;

		private bool propagateField;

		private BusinessEntity activityField;

		private Guid templateIdField;

		private PropagationOwnershipOptions ownershipOptionsField;

		private Moniker ownerField;

		private bool sendEmailField;

		[XmlElement] //[XmlElement(Order=2)]
		public BusinessEntity Activity
		{
			get
			{
				return this.activityField;
			}
			set
			{
				this.activityField = value;
				base.RaisePropertyChanged("Activity");
			}
		}

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

		[XmlElement] //[XmlElement(Order=5)]
		public Moniker Owner
		{
			get
			{
				return this.ownerField;
			}
			set
			{
				this.ownerField = value;
				base.RaisePropertyChanged("Owner");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public PropagationOwnershipOptions OwnershipOptions
		{
			get
			{
				return this.ownershipOptionsField;
			}
			set
			{
				this.ownershipOptionsField = value;
				base.RaisePropertyChanged("OwnershipOptions");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public bool Propagate
		{
			get
			{
				return this.propagateField;
			}
			set
			{
				this.propagateField = value;
				base.RaisePropertyChanged("Propagate");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public bool SendEmail
		{
			get
			{
				return this.sendEmailField;
			}
			set
			{
				this.sendEmailField = value;
				base.RaisePropertyChanged("SendEmail");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
				base.RaisePropertyChanged("TemplateId");
			}
		}

		public DistributeCampaignActivityRequest()
		{
		}
	}
}