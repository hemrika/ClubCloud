using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public Guid ListId
		{
			get
			{
				return this.listIdField;
			}
			set
			{
				this.listIdField = value;
			}
		}
		public string FriendlyName
		{
			get
			{
				return this.friendlyNameField;
			}
			set
			{
				this.friendlyNameField = value;
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
		public Moniker Owner
		{
			get
			{
				return this.ownerField;
			}
			set
			{
				this.ownerField = value;
			}
		}
		public bool sendEmail
		{
			get
			{
				return this.sendEmailField;
			}
			set
			{
				this.sendEmailField = value;
			}
		}
	}
}
