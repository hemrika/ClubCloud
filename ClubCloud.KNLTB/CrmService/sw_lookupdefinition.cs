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
	public class sw_lookupdefinition : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Sw_lookupdefinitionStateInfo statecodeField;

		private Status statuscodeField;

		private string sw_classField;

		private string sw_descriptionField;

		private string sw_displaynameField;

		private string sw_entitytypeField;

		private Key sw_lookupdefinitionidField;

		private Lookup sw_queryidField;

		private string sw_searchfieldsField;

		private Picklist sw_tracingField;

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
		public Sw_lookupdefinitionStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=10)]
		public string sw_description
		{
			get
			{
				return this.sw_descriptionField;
			}
			set
			{
				this.sw_descriptionField = value;
				base.RaisePropertyChanged("sw_description");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sw_displayname
		{
			get
			{
				return this.sw_displaynameField;
			}
			set
			{
				this.sw_displaynameField = value;
				base.RaisePropertyChanged("sw_displayname");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sw_entitytype
		{
			get
			{
				return this.sw_entitytypeField;
			}
			set
			{
				this.sw_entitytypeField = value;
				base.RaisePropertyChanged("sw_entitytype");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Key sw_lookupdefinitionid
		{
			get
			{
				return this.sw_lookupdefinitionidField;
			}
			set
			{
				this.sw_lookupdefinitionidField = value;
				base.RaisePropertyChanged("sw_lookupdefinitionid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sw_queryid
		{
			get
			{
				return this.sw_queryidField;
			}
			set
			{
				this.sw_queryidField = value;
				base.RaisePropertyChanged("sw_queryid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sw_searchfields
		{
			get
			{
				return this.sw_searchfieldsField;
			}
			set
			{
				this.sw_searchfieldsField = value;
				base.RaisePropertyChanged("sw_searchfields");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		public sw_lookupdefinition()
		{
		}
	}
}