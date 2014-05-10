using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class opportunity : BusinessEntity
	{
		private CrmDateTime actualclosedateField;
		private CrmMoney actualvalueField;
		private CrmMoney actualvalue_baseField;
		private Lookup campaignidField;
		private CrmNumber closeprobabilityField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private string descriptionField;
		private CrmDateTime estimatedclosedateField;
		private CrmMoney estimatedvalueField;
		private CrmMoney estimatedvalue_baseField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isrevenuesystemcalculatedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Key opportunityidField;
		private Picklist opportunityratingcodeField;
		private Lookup originatingleadidField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean participatesinworkflowField;
		private Lookup pricelevelidField;
		private Picklist pricingerrorcodeField;
		private Picklist prioritycodeField;
		private Picklist salesstagecodeField;
		private OpportunityStateInfo statecodeField;
		private Status statuscodeField;
		private UniqueIdentifier stepidField;
		private string stepnameField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmDateTime actualclosedate
		{
			get
			{
				return this.actualclosedateField;
			}
			set
			{
				this.actualclosedateField = value;
			}
		}
		public CrmMoney actualvalue
		{
			get
			{
				return this.actualvalueField;
			}
			set
			{
				this.actualvalueField = value;
			}
		}
		public CrmMoney actualvalue_base
		{
			get
			{
				return this.actualvalue_baseField;
			}
			set
			{
				this.actualvalue_baseField = value;
			}
		}
		public Lookup campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
			}
		}
		public CrmNumber closeprobability
		{
			get
			{
				return this.closeprobabilityField;
			}
			set
			{
				this.closeprobabilityField = value;
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
		public CrmDateTime estimatedclosedate
		{
			get
			{
				return this.estimatedclosedateField;
			}
			set
			{
				this.estimatedclosedateField = value;
			}
		}
		public CrmMoney estimatedvalue
		{
			get
			{
				return this.estimatedvalueField;
			}
			set
			{
				this.estimatedvalueField = value;
			}
		}
		public CrmMoney estimatedvalue_base
		{
			get
			{
				return this.estimatedvalue_baseField;
			}
			set
			{
				this.estimatedvalue_baseField = value;
			}
		}
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
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
		public CrmBoolean isrevenuesystemcalculated
		{
			get
			{
				return this.isrevenuesystemcalculatedField;
			}
			set
			{
				this.isrevenuesystemcalculatedField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public Key opportunityid
		{
			get
			{
				return this.opportunityidField;
			}
			set
			{
				this.opportunityidField = value;
			}
		}
		public Picklist opportunityratingcode
		{
			get
			{
				return this.opportunityratingcodeField;
			}
			set
			{
				this.opportunityratingcodeField = value;
			}
		}
		public Lookup originatingleadid
		{
			get
			{
				return this.originatingleadidField;
			}
			set
			{
				this.originatingleadidField = value;
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
		public CrmBoolean participatesinworkflow
		{
			get
			{
				return this.participatesinworkflowField;
			}
			set
			{
				this.participatesinworkflowField = value;
			}
		}
		public Lookup pricelevelid
		{
			get
			{
				return this.pricelevelidField;
			}
			set
			{
				this.pricelevelidField = value;
			}
		}
		public Picklist pricingerrorcode
		{
			get
			{
				return this.pricingerrorcodeField;
			}
			set
			{
				this.pricingerrorcodeField = value;
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
		public Picklist salesstagecode
		{
			get
			{
				return this.salesstagecodeField;
			}
			set
			{
				this.salesstagecodeField = value;
			}
		}
		public OpportunityStateInfo statecode
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
		public UniqueIdentifier stepid
		{
			get
			{
				return this.stepidField;
			}
			set
			{
				this.stepidField = value;
			}
		}
		public string stepname
		{
			get
			{
				return this.stepnameField;
			}
			set
			{
				this.stepnameField = value;
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
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
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
