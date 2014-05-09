using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		public Sw_licenseStateInfo statecode
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
		public Key sw_licenseid
		{
			get
			{
				return this.sw_licenseidField;
			}
			set
			{
				this.sw_licenseidField = value;
				base.RaisePropertyChanged("sw_licenseid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sw_licensemanagerid
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
		[XmlElement(Order = 12)]
		public string sw_licensexml
		{
			get
			{
				return this.sw_licensexmlField;
			}
			set
			{
				this.sw_licensexmlField = value;
				base.RaisePropertyChanged("sw_licensexml");
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
		public string sw_servername
		{
			get
			{
				return this.sw_servernameField;
			}
			set
			{
				this.sw_servernameField = value;
				base.RaisePropertyChanged("sw_servername");
			}
		}
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public CrmDateTime sw_validto
		{
			get
			{
				return this.sw_validtoField;
			}
			set
			{
				this.sw_validtoField = value;
				base.RaisePropertyChanged("sw_validto");
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
