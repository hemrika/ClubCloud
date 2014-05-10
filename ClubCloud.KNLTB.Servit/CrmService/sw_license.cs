using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sw_license : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Sw_licenseStateInfo statecodeField;
		private Status statuscodeField;
		private string sw_applicationidField;
		private Key sw_licenseidField;
		private Lookup sw_licensemanageridField;
		private string sw_licensexmlField;
		private string sw_nameField;
		private string sw_servernameField;
		private CrmNumber sw_userlicensesField;
		private CrmDateTime sw_validtoField;
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
		public Sw_licenseStateInfo statecode
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
		public Key sw_licenseid
		{
			get
			{
				return this.sw_licenseidField;
			}
			set
			{
				this.sw_licenseidField = value;
			}
		}
		public Lookup sw_licensemanagerid
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
		public string sw_licensexml
		{
			get
			{
				return this.sw_licensexmlField;
			}
			set
			{
				this.sw_licensexmlField = value;
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
		public string sw_servername
		{
			get
			{
				return this.sw_servernameField;
			}
			set
			{
				this.sw_servernameField = value;
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
		public CrmDateTime sw_validto
		{
			get
			{
				return this.sw_validtoField;
			}
			set
			{
				this.sw_validtoField = value;
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
