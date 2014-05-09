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
		[XmlElement(Order = 0)]
		public CrmDateTime actualclosedate
		{
			get
			{
				return this.actualclosedateField;
			}
			set
			{
				this.actualclosedateField = value;
				base.RaisePropertyChanged("actualclosedate");
			}
		}
		[XmlElement(Order = 1)]
		public CrmMoney actualvalue
		{
			get
			{
				return this.actualvalueField;
			}
			set
			{
				this.actualvalueField = value;
				base.RaisePropertyChanged("actualvalue");
			}
		}
		[XmlElement(Order = 2)]
		public CrmMoney actualvalue_base
		{
			get
			{
				return this.actualvalue_baseField;
			}
			set
			{
				this.actualvalue_baseField = value;
				base.RaisePropertyChanged("actualvalue_base");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
				base.RaisePropertyChanged("campaignid");
			}
		}
		[XmlElement(Order = 4)]
		public CrmNumber closeprobability
		{
			get
			{
				return this.closeprobabilityField;
			}
			set
			{
				this.closeprobabilityField = value;
				base.RaisePropertyChanged("closeprobability");
			}
		}
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public CrmDateTime estimatedclosedate
		{
			get
			{
				return this.estimatedclosedateField;
			}
			set
			{
				this.estimatedclosedateField = value;
				base.RaisePropertyChanged("estimatedclosedate");
			}
		}
		[XmlElement(Order = 10)]
		public CrmMoney estimatedvalue
		{
			get
			{
				return this.estimatedvalueField;
			}
			set
			{
				this.estimatedvalueField = value;
				base.RaisePropertyChanged("estimatedvalue");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney estimatedvalue_base
		{
			get
			{
				return this.estimatedvalue_baseField;
			}
			set
			{
				this.estimatedvalue_baseField = value;
				base.RaisePropertyChanged("estimatedvalue_base");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public CrmBoolean isrevenuesystemcalculated
		{
			get
			{
				return this.isrevenuesystemcalculatedField;
			}
			set
			{
				this.isrevenuesystemcalculatedField = value;
				base.RaisePropertyChanged("isrevenuesystemcalculated");
			}
		}
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}
		[XmlElement(Order = 18)]
		public Key opportunityid
		{
			get
			{
				return this.opportunityidField;
			}
			set
			{
				this.opportunityidField = value;
				base.RaisePropertyChanged("opportunityid");
			}
		}
		[XmlElement(Order = 19)]
		public Picklist opportunityratingcode
		{
			get
			{
				return this.opportunityratingcodeField;
			}
			set
			{
				this.opportunityratingcodeField = value;
				base.RaisePropertyChanged("opportunityratingcode");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup originatingleadid
		{
			get
			{
				return this.originatingleadidField;
			}
			set
			{
				this.originatingleadidField = value;
				base.RaisePropertyChanged("originatingleadid");
			}
		}
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
		public CrmBoolean participatesinworkflow
		{
			get
			{
				return this.participatesinworkflowField;
			}
			set
			{
				this.participatesinworkflowField = value;
				base.RaisePropertyChanged("participatesinworkflow");
			}
		}
		[XmlElement(Order = 25)]
		public Lookup pricelevelid
		{
			get
			{
				return this.pricelevelidField;
			}
			set
			{
				this.pricelevelidField = value;
				base.RaisePropertyChanged("pricelevelid");
			}
		}
		[XmlElement(Order = 26)]
		public Picklist pricingerrorcode
		{
			get
			{
				return this.pricingerrorcodeField;
			}
			set
			{
				this.pricingerrorcodeField = value;
				base.RaisePropertyChanged("pricingerrorcode");
			}
		}
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
		public Picklist salesstagecode
		{
			get
			{
				return this.salesstagecodeField;
			}
			set
			{
				this.salesstagecodeField = value;
				base.RaisePropertyChanged("salesstagecode");
			}
		}
		[XmlElement(Order = 29)]
		public OpportunityStateInfo statecode
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
		public UniqueIdentifier stepid
		{
			get
			{
				return this.stepidField;
			}
			set
			{
				this.stepidField = value;
				base.RaisePropertyChanged("stepid");
			}
		}
		[XmlElement(Order = 32)]
		public string stepname
		{
			get
			{
				return this.stepnameField;
			}
			set
			{
				this.stepnameField = value;
				base.RaisePropertyChanged("stepname");
			}
		}
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}
		[XmlElement(Order = 35)]
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
