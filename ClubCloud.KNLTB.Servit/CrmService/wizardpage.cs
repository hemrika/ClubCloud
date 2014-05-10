using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class wizardpage : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string pagedatatopostField;
		private CrmNumber pagesequencenumberField;
		private string pageurlField;
		private Lookup webwizardidField;
		private Key wizardpageidField;
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
		public string pagedatatopost
		{
			get
			{
				return this.pagedatatopostField;
			}
			set
			{
				this.pagedatatopostField = value;
			}
		}
		public CrmNumber pagesequencenumber
		{
			get
			{
				return this.pagesequencenumberField;
			}
			set
			{
				this.pagesequencenumberField = value;
			}
		}
		public string pageurl
		{
			get
			{
				return this.pageurlField;
			}
			set
			{
				this.pageurlField = value;
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
		public Key wizardpageid
		{
			get
			{
				return this.wizardpageidField;
			}
			set
			{
				this.wizardpageidField = value;
			}
		}
	}
}
