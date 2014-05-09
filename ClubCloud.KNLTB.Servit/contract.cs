using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public CrmDateTime activeon
		{
			get
			{
				return this.activeonField;
			}
			set
			{
				this.activeonField = value;
				base.RaisePropertyChanged("activeon");
			}
		}
		[XmlElement(Order = 1)]
		public Picklist allotmenttypecode
		{
			get
			{
				return this.allotmenttypecodeField;
			}
			set
			{
				this.allotmenttypecodeField = value;
				base.RaisePropertyChanged("allotmenttypecode");
			}
		}
		[XmlElement(Order = 2)]
		public Customer billingcustomerid
		{
			get
			{
				return this.billingcustomeridField;
			}
			set
			{
				this.billingcustomeridField = value;
				base.RaisePropertyChanged("billingcustomerid");
			}
		}
		[XmlElement(Order = 3)]
		public CrmDateTime billingendon
		{
			get
			{
				return this.billingendonField;
			}
			set
			{
				this.billingendonField = value;
				base.RaisePropertyChanged("billingendon");
			}
		}
		[XmlElement(Order = 4)]
		public Picklist billingfrequencycode
		{
			get
			{
				return this.billingfrequencycodeField;
			}
			set
			{
				this.billingfrequencycodeField = value;
				base.RaisePropertyChanged("billingfrequencycode");
			}
		}
		[XmlElement(Order = 5)]
		public CrmDateTime billingstarton
		{
			get
			{
				return this.billingstartonField;
			}
			set
			{
				this.billingstartonField = value;
				base.RaisePropertyChanged("billingstarton");
			}
		}
		[XmlElement(Order = 6)]
		public Lookup billtoaddress
		{
			get
			{
				return this.billtoaddressField;
			}
			set
			{
				this.billtoaddressField = value;
				base.RaisePropertyChanged("billtoaddress");
			}
		}
		[XmlElement(Order = 7)]
		public CrmDateTime cancelon
		{
			get
			{
				return this.cancelonField;
			}
			set
			{
				this.cancelonField = value;
				base.RaisePropertyChanged("cancelon");
			}
		}
		[XmlElement(Order = 8)]
		public Key contractid
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
		[XmlElement(Order = 9)]
		public string contractlanguage
		{
			get
			{
				return this.contractlanguageField;
			}
			set
			{
				this.contractlanguageField = value;
				base.RaisePropertyChanged("contractlanguage");
			}
		}
		[XmlElement(Order = 10)]
		public string contractnumber
		{
			get
			{
				return this.contractnumberField;
			}
			set
			{
				this.contractnumberField = value;
				base.RaisePropertyChanged("contractnumber");
			}
		}
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
		public string contracttemplateabbreviation
		{
			get
			{
				return this.contracttemplateabbreviationField;
			}
			set
			{
				this.contracttemplateabbreviationField = value;
				base.RaisePropertyChanged("contracttemplateabbreviation");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup contracttemplateid
		{
			get
			{
				return this.contracttemplateidField;
			}
			set
			{
				this.contracttemplateidField = value;
				base.RaisePropertyChanged("contracttemplateid");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
		public CrmNumber duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				base.RaisePropertyChanged("duration");
			}
		}
		[XmlElement(Order = 18)]
		public string effectivitycalendar
		{
			get
			{
				return this.effectivitycalendarField;
			}
			set
			{
				this.effectivitycalendarField = value;
				base.RaisePropertyChanged("effectivitycalendar");
			}
		}
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public CrmDateTime expireson
		{
			get
			{
				return this.expiresonField;
			}
			set
			{
				this.expiresonField = value;
				base.RaisePropertyChanged("expireson");
			}
		}
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
		public CrmMoney netprice
		{
			get
			{
				return this.netpriceField;
			}
			set
			{
				this.netpriceField = value;
				base.RaisePropertyChanged("netprice");
			}
		}
		[XmlElement(Order = 25)]
		public CrmMoney netprice_base
		{
			get
			{
				return this.netprice_baseField;
			}
			set
			{
				this.netprice_baseField = value;
				base.RaisePropertyChanged("netprice_base");
			}
		}
		[XmlElement(Order = 26)]
		public Lookup originatingcontract
		{
			get
			{
				return this.originatingcontractField;
			}
			set
			{
				this.originatingcontractField = value;
				base.RaisePropertyChanged("originatingcontract");
			}
		}
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
		public Lookup serviceaddress
		{
			get
			{
				return this.serviceaddressField;
			}
			set
			{
				this.serviceaddressField = value;
				base.RaisePropertyChanged("serviceaddress");
			}
		}
		[XmlElement(Order = 31)]
		public ContractStateInfo statecode
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 35)]
		public CrmMoney totaldiscount
		{
			get
			{
				return this.totaldiscountField;
			}
			set
			{
				this.totaldiscountField = value;
				base.RaisePropertyChanged("totaldiscount");
			}
		}
		[XmlElement(Order = 36)]
		public CrmMoney totaldiscount_base
		{
			get
			{
				return this.totaldiscount_baseField;
			}
			set
			{
				this.totaldiscount_baseField = value;
				base.RaisePropertyChanged("totaldiscount_base");
			}
		}
		[XmlElement(Order = 37)]
		public CrmMoney totalprice
		{
			get
			{
				return this.totalpriceField;
			}
			set
			{
				this.totalpriceField = value;
				base.RaisePropertyChanged("totalprice");
			}
		}
		[XmlElement(Order = 38)]
		public CrmMoney totalprice_base
		{
			get
			{
				return this.totalprice_baseField;
			}
			set
			{
				this.totalprice_baseField = value;
				base.RaisePropertyChanged("totalprice_base");
			}
		}
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
		public CrmBoolean usediscountaspercentage
		{
			get
			{
				return this.usediscountaspercentageField;
			}
			set
			{
				this.usediscountaspercentageField = value;
				base.RaisePropertyChanged("usediscountaspercentage");
			}
		}
		[XmlElement(Order = 41)]
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
