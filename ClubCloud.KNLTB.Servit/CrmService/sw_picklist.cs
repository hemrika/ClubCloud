using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class sw_picklist : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Sw_picklistStateInfo statecodeField;

		private Status statuscodeField;

		private CrmBoolean sw_addemptyoptionField;

		private string sw_classField;

		private string sw_delimiterField;

		private CrmNumber sw_languageField;

		private string sw_nameField;

		private string sw_optionsField;

		private Key sw_picklistidField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Sw_picklistStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sw_addemptyoption
		{
			get
			{
				return this.sw_addemptyoptionField;
			}
			set
			{
				this.sw_addemptyoptionField = value;
				base.RaisePropertyChanged("sw_addemptyoption");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sw_class
		{
			get
			{
				return this.sw_classField;
			}
			set
			{
				this.sw_classField = value;
				base.RaisePropertyChanged("sw_class");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sw_delimiter
		{
			get
			{
				return this.sw_delimiterField;
			}
			set
			{
				this.sw_delimiterField = value;
				base.RaisePropertyChanged("sw_delimiter");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sw_language
		{
			get
			{
				return this.sw_languageField;
			}
			set
			{
				this.sw_languageField = value;
				base.RaisePropertyChanged("sw_language");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public string sw_options
		{
			get
			{
				return this.sw_optionsField;
			}
			set
			{
				this.sw_optionsField = value;
				base.RaisePropertyChanged("sw_options");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sw_picklistid
		{
			get
			{
				return this.sw_picklistidField;
			}
			set
			{
				this.sw_picklistidField = value;
				base.RaisePropertyChanged("sw_picklistid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public sw_picklist()
		{
		}
	}
}