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
	public class incident : BusinessEntity
	{
		private CrmNumber actualserviceunitsField;

		private CrmNumber billedserviceunitsField;

		private Picklist caseorigincodeField;

		private Picklist casetypecodeField;

		private Lookup contractdetailidField;

		private Lookup contractidField;

		private Picklist contractservicelevelcodeField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Customer customeridField;

		private Picklist customersatisfactioncodeField;

		private string descriptionField;

		private CrmDateTime followupbyField;

		private CrmNumber importsequencenumberField;

		private Key incidentidField;

		private Picklist incidentstagecodeField;

		private CrmBoolean isdecrementingField;

		private Lookup kbarticleidField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Picklist prioritycodeField;

		private Lookup productidField;

		private string productserialnumberField;

		private Lookup responsiblecontactidField;

		private Picklist severitycodeField;

		private IncidentStateInfo statecodeField;

		private Status statuscodeField;

		private Lookup subjectidField;

		private string ticketnumberField;

		private CrmNumber timezoneruleversionnumberField;

		private string titleField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmNumber actualserviceunits
		{
			get
			{
				return this.actualserviceunitsField;
			}
			set
			{
				this.actualserviceunitsField = value;
				base.RaisePropertyChanged("actualserviceunits");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmNumber billedserviceunits
		{
			get
			{
				return this.billedserviceunitsField;
			}
			set
			{
				this.billedserviceunitsField = value;
				base.RaisePropertyChanged("billedserviceunits");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public Picklist caseorigincode
		{
			get
			{
				return this.caseorigincodeField;
			}
			set
			{
				this.caseorigincodeField = value;
				base.RaisePropertyChanged("caseorigincode");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Picklist casetypecode
		{
			get
			{
				return this.casetypecodeField;
			}
			set
			{
				this.casetypecodeField = value;
				base.RaisePropertyChanged("casetypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Lookup contractdetailid
		{
			get
			{
				return this.contractdetailidField;
			}
			set
			{
				this.contractdetailidField = value;
				base.RaisePropertyChanged("contractdetailid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Lookup contractid
		{
			get
			{
				return this.contractidField;
			}
			set
			{
				this.contractidField = value;
				base.RaisePropertyChanged("contractid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Picklist contractservicelevelcode
		{
			get
			{
				return this.contractservicelevelcodeField;
			}
			set
			{
				this.contractservicelevelcodeField = value;
				base.RaisePropertyChanged("contractservicelevelcode");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Customer customerid
		{
			get
			{
				return this.customeridField;
			}
			set
			{
				this.customeridField = value;
				base.RaisePropertyChanged("customerid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist customersatisfactioncode
		{
			get
			{
				return this.customersatisfactioncodeField;
			}
			set
			{
				this.customersatisfactioncodeField = value;
				base.RaisePropertyChanged("customersatisfactioncode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime followupby
		{
			get
			{
				return this.followupbyField;
			}
			set
			{
				this.followupbyField = value;
				base.RaisePropertyChanged("followupby");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public Key incidentid
		{
			get
			{
				return this.incidentidField;
			}
			set
			{
				this.incidentidField = value;
				base.RaisePropertyChanged("incidentid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist incidentstagecode
		{
			get
			{
				return this.incidentstagecodeField;
			}
			set
			{
				this.incidentstagecodeField = value;
				base.RaisePropertyChanged("incidentstagecode");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean isdecrementing
		{
			get
			{
				return this.isdecrementingField;
			}
			set
			{
				this.isdecrementingField = value;
				base.RaisePropertyChanged("isdecrementing");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup kbarticleid
		{
			get
			{
				return this.kbarticleidField;
			}
			set
			{
				this.kbarticleidField = value;
				base.RaisePropertyChanged("kbarticleid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Picklist prioritycode
		{
			get
			{
				return this.prioritycodeField;
			}
			set
			{
				this.prioritycodeField = value;
				base.RaisePropertyChanged("prioritycode");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup productid
		{
			get
			{
				return this.productidField;
			}
			set
			{
				this.productidField = value;
				base.RaisePropertyChanged("productid");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string productserialnumber
		{
			get
			{
				return this.productserialnumberField;
			}
			set
			{
				this.productserialnumberField = value;
				base.RaisePropertyChanged("productserialnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Lookup responsiblecontactid
		{
			get
			{
				return this.responsiblecontactidField;
			}
			set
			{
				this.responsiblecontactidField = value;
				base.RaisePropertyChanged("responsiblecontactid");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public Picklist severitycode
		{
			get
			{
				return this.severitycodeField;
			}
			set
			{
				this.severitycodeField = value;
				base.RaisePropertyChanged("severitycode");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public IncidentStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
				base.RaisePropertyChanged("subjectid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string ticketnumber
		{
			get
			{
				return this.ticketnumberField;
			}
			set
			{
				this.ticketnumberField = value;
				base.RaisePropertyChanged("ticketnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				base.RaisePropertyChanged("title");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
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

		public incident()
		{
		}
	}
}