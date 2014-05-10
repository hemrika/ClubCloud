using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class queue : BusinessEntity
	{
		private CrmBoolean allowemailcredentialsField;
		private Lookup businessunitidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private string emailaddressField;
		private string emailpasswordField;
		private string emailusernameField;
		private CrmBoolean ignoreunsolicitedemailField;
		private Picklist incomingemaildeliverymethodField;
		private Picklist incomingemailfilteringmethodField;
		private CrmBoolean isfaxqueueField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private Picklist outgoingemaildeliverymethodField;
		private Lookup primaryuseridField;
		private Key queueidField;
		private CrmNumber queuesemanticsField;
		private Picklist queuetypecodeField;
		public CrmBoolean allowemailcredentials
		{
			get
			{
				return this.allowemailcredentialsField;
			}
			set
			{
				this.allowemailcredentialsField = value;
			}
		}
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
			}
		}
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public string emailaddress
		{
			get
			{
				return this.emailaddressField;
			}
			set
			{
				this.emailaddressField = value;
			}
		}
		public string emailpassword
		{
			get
			{
				return this.emailpasswordField;
			}
			set
			{
				this.emailpasswordField = value;
			}
		}
		public string emailusername
		{
			get
			{
				return this.emailusernameField;
			}
			set
			{
				this.emailusernameField = value;
			}
		}
		public CrmBoolean ignoreunsolicitedemail
		{
			get
			{
				return this.ignoreunsolicitedemailField;
			}
			set
			{
				this.ignoreunsolicitedemailField = value;
			}
		}
		public Picklist incomingemaildeliverymethod
		{
			get
			{
				return this.incomingemaildeliverymethodField;
			}
			set
			{
				this.incomingemaildeliverymethodField = value;
			}
		}
		public Picklist incomingemailfilteringmethod
		{
			get
			{
				return this.incomingemailfilteringmethodField;
			}
			set
			{
				this.incomingemailfilteringmethodField = value;
			}
		}
		public CrmBoolean isfaxqueue
		{
			get
			{
				return this.isfaxqueueField;
			}
			set
			{
				this.isfaxqueueField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
		public Picklist outgoingemaildeliverymethod
		{
			get
			{
				return this.outgoingemaildeliverymethodField;
			}
			set
			{
				this.outgoingemaildeliverymethodField = value;
			}
		}
		public Lookup primaryuserid
		{
			get
			{
				return this.primaryuseridField;
			}
			set
			{
				this.primaryuseridField = value;
			}
		}
		public Key queueid
		{
			get
			{
				return this.queueidField;
			}
			set
			{
				this.queueidField = value;
			}
		}
		public CrmNumber queuesemantics
		{
			get
			{
				return this.queuesemanticsField;
			}
			set
			{
				this.queuesemanticsField = value;
			}
		}
		public Picklist queuetypecode
		{
			get
			{
				return this.queuetypecodeField;
			}
			set
			{
				this.queuetypecodeField = value;
			}
		}
	}
}
