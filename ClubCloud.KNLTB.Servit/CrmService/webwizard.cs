using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class webwizard : BusinessEntity
	{
		private string accessprivilegesField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmBoolean isstaticpagesequenceField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private CrmNumber startpagesequencenumberField;
		private string titleresourcestringField;
		private Key webwizardidField;
		private CrmNumber wizardpageheightField;
		private CrmNumber wizardpagewidthField;
		public string accessprivileges
		{
			get
			{
				return this.accessprivilegesField;
			}
			set
			{
				this.accessprivilegesField = value;
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
		public CrmBoolean isstaticpagesequence
		{
			get
			{
				return this.isstaticpagesequenceField;
			}
			set
			{
				this.isstaticpagesequenceField = value;
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
		public CrmNumber startpagesequencenumber
		{
			get
			{
				return this.startpagesequencenumberField;
			}
			set
			{
				this.startpagesequencenumberField = value;
			}
		}
		public string titleresourcestring
		{
			get
			{
				return this.titleresourcestringField;
			}
			set
			{
				this.titleresourcestringField = value;
			}
		}
		public Key webwizardid
		{
			get
			{
				return this.webwizardidField;
			}
			set
			{
				this.webwizardidField = value;
			}
		}
		public CrmNumber wizardpageheight
		{
			get
			{
				return this.wizardpageheightField;
			}
			set
			{
				this.wizardpageheightField = value;
			}
		}
		public CrmNumber wizardpagewidth
		{
			get
			{
				return this.wizardpagewidthField;
			}
			set
			{
				this.wizardpagewidthField = value;
			}
		}
	}
}
