using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CreateActivitiesListRequest : Request
	{
		private Guid listIdField;
		private string friendlyNameField;
		private BusinessEntity activityField;
		private Guid templateIdField;
		private bool propagateField;
		private PropagationOwnershipOptions ownershipOptionsField;
		private Moniker ownerField;
		private bool sendEmailField;
		[XmlElement(Order = 0)]
		public Guid ListId
		{
			get
			{
				return this.listIdField;
			}
			set
			{
				this.listIdField = value;
				base.RaisePropertyChanged("ListId");
			}
		}
		[XmlElement(Order = 1)]
		public string FriendlyName
		{
			get
			{
				return this.friendlyNameField;
			}
			set
			{
				this.friendlyNameField = value;
				base.RaisePropertyChanged("FriendlyName");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public bool sendEmail
		{
			get
			{
				return this.sendEmailField;
			}
			set
			{
				this.sendEmailField = value;
				base.RaisePropertyChanged("sendEmail");
			}
		}
	}
}
