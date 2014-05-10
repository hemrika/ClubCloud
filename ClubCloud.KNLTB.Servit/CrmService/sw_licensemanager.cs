using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sw_licensemanager : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Sw_licensemanagerStateInfo statecodeField;
		private Status statuscodeField;
		private string sw_applicationidField;
		private Lookup sw_defaultlabelsidField;
		private string sw_extendedsettingsField;
		private Key sw_licensemanageridField;
		private string sw_nameField;
		private CrmNumber sw_serverlicensesField;
		private Picklist sw_tracingField;
		private CrmNumber sw_userlicensesField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
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
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
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
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Sw_licensemanagerStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public string sw_applicationid
		{
			get
			{
				return this.sw_applicationidField;
			}
			set
			{
				this.sw_applicationidField = value;
			}
		}
		public Lookup sw_defaultlabelsid
		{
			get
			{
				return this.sw_defaultlabelsidField;
			}
			set
			{
				this.sw_defaultlabelsidField = value;
			}
		}
		public string sw_extendedsettings
		{
			get
			{
				return this.sw_extendedsettingsField;
			}
			set
			{
				this.sw_extendedsettingsField = value;
			}
		}
		public Key sw_licensemanagerid
		{
			get
			{
				return this.sw_licensemanageridField;
			}
			set
			{
				this.sw_licensemanageridField = value;
			}
		}
		public string sw_name
		{
			get
			{
				return this.sw_nameField;
			}
			set
			{
				this.sw_nameField = value;
			}
		}
		public CrmNumber sw_serverlicenses
		{
			get
			{
				return this.sw_serverlicensesField;
			}
			set
			{
				this.sw_serverlicensesField = value;
			}
		}
		public Picklist sw_tracing
		{
			get
			{
				return this.sw_tracingField;
			}
			set
			{
				this.sw_tracingField = value;
			}
		}
		public CrmNumber sw_userlicenses
		{
			get
			{
				return this.sw_userlicensesField;
			}
			set
			{
				this.sw_userlicensesField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
