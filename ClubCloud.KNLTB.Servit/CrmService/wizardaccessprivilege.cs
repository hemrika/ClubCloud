using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class wizardaccessprivilege : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string entitynameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string privilegenameField;
		private Lookup webwizardidField;
		private Key wizardaccessprivilegeidField;
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
		public string entityname
		{
			get
			{
				return this.entitynameField;
			}
			set
			{
				this.entitynameField = value;
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
		public string privilegename
		{
			get
			{
				return this.privilegenameField;
			}
			set
			{
				this.privilegenameField = value;
			}
		}
		public Lookup webwizardid
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
		public Key wizardaccessprivilegeid
		{
			get
			{
				return this.wizardaccessprivilegeidField;
			}
			set
			{
				this.wizardaccessprivilegeidField = value;
			}
		}
	}
}
