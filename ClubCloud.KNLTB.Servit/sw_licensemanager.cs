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
		[XmlElement(Order = 0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 5)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 6)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}
		[XmlElement(Order = 7)]
		public Sw_licensemanagerStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 8)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 9)]
		public string sw_applicationid
		{
			get
			{
				return this.sw_applicationidField;
			}
			set
			{
				this.sw_applicationidField = value;
				base.RaisePropertyChanged("sw_applicationid");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sw_defaultlabelsid
		{
			get
			{
				return this.sw_defaultlabelsidField;
			}
			set
			{
				this.sw_defaultlabelsidField = value;
				base.RaisePropertyChanged("sw_defaultlabelsid");
			}
		}
		[XmlElement(Order = 11)]
		public string sw_extendedsettings
		{
			get
			{
				return this.sw_extendedsettingsField;
			}
			set
			{
				this.sw_extendedsettingsField = value;
				base.RaisePropertyChanged("sw_extendedsettings");
			}
		}
		[XmlElement(Order = 12)]
		public Key sw_licensemanagerid
		{
			get
			{
				return this.sw_licensemanageridField;
			}
			set
			{
				this.sw_licensemanageridField = value;
				base.RaisePropertyChanged("sw_licensemanagerid");
			}
		}
		[XmlElement(Order = 13)]
		public string sw_name
		{
			get
			{
				return this.sw_nameField;
			}
			set
			{
				this.sw_nameField = value;
				base.RaisePropertyChanged("sw_name");
			}
		}
		[XmlElement(Order = 14)]
		public CrmNumber sw_serverlicenses
		{
			get
			{
				return this.sw_serverlicensesField;
			}
			set
			{
				this.sw_serverlicensesField = value;
				base.RaisePropertyChanged("sw_serverlicenses");
			}
		}
		[XmlElement(Order = 15)]
		public Picklist sw_tracing
		{
			get
			{
				return this.sw_tracingField;
			}
			set
			{
				this.sw_tracingField = value;
				base.RaisePropertyChanged("sw_tracing");
			}
		}
		[XmlElement(Order = 16)]
		public CrmNumber sw_userlicenses
		{
			get
			{
				return this.sw_userlicensesField;
			}
			set
			{
				this.sw_userlicensesField = value;
				base.RaisePropertyChanged("sw_userlicenses");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}
	}
}
