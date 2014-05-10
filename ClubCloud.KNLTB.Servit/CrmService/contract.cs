using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class contract : BusinessEntity
	{
		private CrmDateTime activeonField;
		private Picklist allotmenttypecodeField;
		private Customer billingcustomeridField;
		private CrmDateTime billingendonField;
		private Picklist billingfrequencycodeField;
		private CrmDateTime billingstartonField;
		private Lookup billtoaddressField;
		private CrmDateTime cancelonField;
		private Key contractidField;
		private string contractlanguageField;
		private string contractnumberField;
		private Picklist contractservicelevelcodeField;
		private string contracttemplateabbreviationField;
		private Lookup contracttemplateidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private CrmNumber durationField;
		private string effectivitycalendarField;
		private CrmDecimal exchangerateField;
		private CrmDateTime expiresonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmMoney netpriceField;
		private CrmMoney netprice_baseField;
		private Lookup originatingcontractField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup serviceaddressField;
		private ContractStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private string titleField;
		private CrmMoney totaldiscountField;
		private CrmMoney totaldiscount_baseField;
		private CrmMoney totalpriceField;
		private CrmMoney totalprice_baseField;
		private Lookup transactioncurrencyidField;
		private CrmBoolean usediscountaspercentageField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmDateTime activeon
		{
			get
			{
				return this.activeonField;
			}
			set
			{
				this.activeonField = value;
			}
		}
		public Picklist allotmenttypecode
		{
			get
			{
				return this.allotmenttypecodeField;
			}
			set
			{
				this.allotmenttypecodeField = value;
			}
		}
		public Customer billingcustomerid
		{
			get
			{
				return this.billingcustomeridField;
			}
			set
			{
				this.billingcustomeridField = value;
			}
		}
		public CrmDateTime billingendon
		{
			get
			{
				return this.billingendonField;
			}
			set
			{
				this.billingendonField = value;
			}
		}
		public Picklist billingfrequencycode
		{
			get
			{
				return this.billingfrequencycodeField;
			}
			set
			{
				this.billingfrequencycodeField = value;
			}
		}
		public CrmDateTime billingstarton
		{
			get
			{
				return this.billingstartonField;
			}
			set
			{
				this.billingstartonField = value;
			}
		}
		public Lookup billtoaddress
		{
			get
			{
				return this.billtoaddressField;
			}
			set
			{
				this.billtoaddressField = value;
			}
		}
		public CrmDateTime cancelon
		{
			get
			{
				return this.cancelonField;
			}
			set
			{
				this.cancelonField = value;
			}
		}
		public Key contractid
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
		public string contractlanguage
		{
			get
			{
				return this.contractlanguageField;
			}
			set
			{
				this.contractlanguageField = value;
			}
		}
		public string contractnumber
		{
			get
			{
				return this.contractnumberField;
			}
			set
			{
				this.contractnumberField = value;
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
		public string contracttemplateabbreviation
		{
			get
			{
				return this.contracttemplateabbreviationField;
			}
			set
			{
				this.contracttemplateabbreviationField = value;
			}
		}
		public Lookup contracttemplateid
		{
			get
			{
				return this.contracttemplateidField;
			}
			set
			{
				this.contracttemplateidField = value;
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
		public CrmNumber duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
			}
		}
		public string effectivitycalendar
		{
			get
			{
				return this.effectivitycalendarField;
			}
			set
			{
				this.effectivitycalendarField = value;
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
		public CrmDateTime expireson
		{
			get
			{
				return this.expiresonField;
			}
			set
			{
				this.expiresonField = value;
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
		public CrmMoney netprice
		{
			get
			{
				return this.netpriceField;
			}
			set
			{
				this.netpriceField = value;
			}
		}
		public CrmMoney netprice_base
		{
			get
			{
				return this.netprice_baseField;
			}
			set
			{
				this.netprice_baseField = value;
			}
		}
		public Lookup originatingcontract
		{
			get
			{
				return this.originatingcontractField;
			}
			set
			{
				this.originatingcontractField = value;
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
		public Lookup serviceaddress
		{
			get
			{
				return this.serviceaddressField;
			}
			set
			{
				this.serviceaddressField = value;
			}
		}
		public ContractStateInfo statecode
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
		public CrmMoney totaldiscount
		{
			get
			{
				return this.totaldiscountField;
			}
			set
			{
				this.totaldiscountField = value;
			}
		}
		public CrmMoney totaldiscount_base
		{
			get
			{
				return this.totaldiscount_baseField;
			}
			set
			{
				this.totaldiscount_baseField = value;
			}
		}
		public CrmMoney totalprice
		{
			get
			{
				return this.totalpriceField;
			}
			set
			{
				this.totalpriceField = value;
			}
		}
		public CrmMoney totalprice_base
		{
			get
			{
				return this.totalprice_baseField;
			}
			set
			{
				this.totalprice_baseField = value;
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
		public CrmBoolean usediscountaspercentage
		{
			get
			{
				return this.usediscountaspercentageField;
			}
			set
			{
				this.usediscountaspercentageField = value;
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
