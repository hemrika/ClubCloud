using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmNumber actualserviceunits
		{
			get
			{
				return this.actualserviceunitsField;
			}
			set
			{
				this.actualserviceunitsField = value;
			}
		}
		public CrmNumber billedserviceunits
		{
			get
			{
				return this.billedserviceunitsField;
			}
			set
			{
				this.billedserviceunitsField = value;
			}
		}
		public Picklist caseorigincode
		{
			get
			{
				return this.caseorigincodeField;
			}
			set
			{
				this.caseorigincodeField = value;
			}
		}
		public Picklist casetypecode
		{
			get
			{
				return this.casetypecodeField;
			}
			set
			{
				this.casetypecodeField = value;
			}
		}
		public Lookup contractdetailid
		{
			get
			{
				return this.contractdetailidField;
			}
			set
			{
				this.contractdetailidField = value;
			}
		}
		public Lookup contractid
		{
			get
			{
				return this.contractidField;
			}
			set
			{
				this.contractidField = value;
			}
		}
		public Picklist contractservicelevelcode
		{
			get
			{
				return this.contractservicelevelcodeField;
			}
			set
			{
				this.contractservicelevelcodeField = value;
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
		public Customer customerid
		{
			get
			{
				return this.customeridField;
			}
			set
			{
				this.customeridField = value;
			}
		}
		public Picklist customersatisfactioncode
		{
			get
			{
				return this.customersatisfactioncodeField;
			}
			set
			{
				this.customersatisfactioncodeField = value;
			}
		}
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public CrmDateTime followupby
		{
			get
			{
				return this.followupbyField;
			}
			set
			{
				this.followupbyField = value;
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
		public Key incidentid
		{
			get
			{
				return this.incidentidField;
			}
			set
			{
				this.incidentidField = value;
			}
		}
		public Picklist incidentstagecode
		{
			get
			{
				return this.incidentstagecodeField;
			}
			set
			{
				this.incidentstagecodeField = value;
			}
		}
		public CrmBoolean isdecrementing
		{
			get
			{
				return this.isdecrementingField;
			}
			set
			{
				this.isdecrementingField = value;
			}
		}
		public Lookup kbarticleid
		{
			get
			{
				return this.kbarticleidField;
			}
			set
			{
				this.kbarticleidField = value;
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
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public Picklist prioritycode
		{
			get
			{
				return this.prioritycodeField;
			}
			set
			{
				this.prioritycodeField = value;
			}
		}
		public Lookup productid
		{
			get
			{
				return this.productidField;
			}
			set
			{
				this.productidField = value;
			}
		}
		public string productserialnumber
		{
			get
			{
				return this.productserialnumberField;
			}
			set
			{
				this.productserialnumberField = value;
			}
		}
		public Lookup responsiblecontactid
		{
			get
			{
				return this.responsiblecontactidField;
			}
			set
			{
				this.responsiblecontactidField = value;
			}
		}
		public Picklist severitycode
		{
			get
			{
				return this.severitycodeField;
			}
			set
			{
				this.severitycodeField = value;
			}
		}
		public IncidentStateInfo statecode
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
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
			}
		}
		public string ticketnumber
		{
			get
			{
				return this.ticketnumberField;
			}
			set
			{
				this.ticketnumberField = value;
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
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
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
