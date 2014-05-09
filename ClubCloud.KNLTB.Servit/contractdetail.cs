using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class contractdetail : BusinessEntity
	{
		private CrmDateTime activeonField;
		private CrmNumber allotmentsremainingField;
		private CrmNumber allotmentsusedField;
		private Key contractdetailidField;
		private Lookup contractidField;
		private Picklist contractstatecodeField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private CrmMoney discountField;
		private CrmMoney discount_baseField;
		private CrmDecimal discountpercentageField;
		private string effectivitycalendarField;
		private CrmDecimal exchangerateField;
		private CrmDateTime expiresonField;
		private CrmNumber importsequencenumberField;
		private CrmNumber initialquantityField;
		private CrmNumber lineitemorderField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmMoney netField;
		private CrmMoney net_baseField;
		private CrmDateTime overriddencreatedonField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private CrmMoney priceField;
		private CrmMoney price_baseField;
		private Lookup productidField;
		private string productserialnumberField;
		private CrmMoney rateField;
		private CrmMoney rate_baseField;
		private Lookup serviceaddressField;
		private Picklist servicecontractunitscodeField;
		private ContractDetailStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private string titleField;
		private CrmNumber totalallotmentsField;
		private Lookup transactioncurrencyidField;
		private Lookup uomidField;
		private Lookup uomscheduleidField;
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
		public CrmNumber allotmentsremaining
		{
			get
			{
				return this.allotmentsremainingField;
			}
			set
			{
				this.allotmentsremainingField = value;
				base.RaisePropertyChanged("allotmentsremaining");
			}
		}
		[XmlElement(Order = 2)]
		public CrmNumber allotmentsused
		{
			get
			{
				return this.allotmentsusedField;
			}
			set
			{
				this.allotmentsusedField = value;
				base.RaisePropertyChanged("allotmentsused");
			}
		}
		[XmlElement(Order = 3)]
		public Key contractdetailid
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
		public Picklist contractstatecode
		{
			get
			{
				return this.contractstatecodeField;
			}
			set
			{
				this.contractstatecodeField = value;
				base.RaisePropertyChanged("contractstatecode");
			}
		}
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public CrmMoney discount
		{
			get
			{
				return this.discountField;
			}
			set
			{
				this.discountField = value;
				base.RaisePropertyChanged("discount");
			}
		}
		[XmlElement(Order = 10)]
		public CrmMoney discount_base
		{
			get
			{
				return this.discount_baseField;
			}
			set
			{
				this.discount_baseField = value;
				base.RaisePropertyChanged("discount_base");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDecimal discountpercentage
		{
			get
			{
				return this.discountpercentageField;
			}
			set
			{
				this.discountpercentageField = value;
				base.RaisePropertyChanged("discountpercentage");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public CrmNumber initialquantity
		{
			get
			{
				return this.initialquantityField;
			}
			set
			{
				this.initialquantityField = value;
				base.RaisePropertyChanged("initialquantity");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber lineitemorder
		{
			get
			{
				return this.lineitemorderField;
			}
			set
			{
				this.lineitemorderField = value;
				base.RaisePropertyChanged("lineitemorder");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public CrmMoney net
		{
			get
			{
				return this.netField;
			}
			set
			{
				this.netField = value;
				base.RaisePropertyChanged("net");
			}
		}
		[XmlElement(Order = 21)]
		public CrmMoney net_base
		{
			get
			{
				return this.net_baseField;
			}
			set
			{
				this.net_baseField = value;
				base.RaisePropertyChanged("net_base");
			}
		}
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
		public UniqueIdentifier owningbusinessunit
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
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
				base.RaisePropertyChanged("owninguser");
			}
		}
		[XmlElement(Order = 25)]
		public CrmMoney price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
				base.RaisePropertyChanged("price");
			}
		}
		[XmlElement(Order = 26)]
		public CrmMoney price_base
		{
			get
			{
				return this.price_baseField;
			}
			set
			{
				this.price_baseField = value;
				base.RaisePropertyChanged("price_base");
			}
		}
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
		public CrmMoney rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.rateField = value;
				base.RaisePropertyChanged("rate");
			}
		}
		[XmlElement(Order = 30)]
		public CrmMoney rate_base
		{
			get
			{
				return this.rate_baseField;
			}
			set
			{
				this.rate_baseField = value;
				base.RaisePropertyChanged("rate_base");
			}
		}
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
		public Picklist servicecontractunitscode
		{
			get
			{
				return this.servicecontractunitscodeField;
			}
			set
			{
				this.servicecontractunitscodeField = value;
				base.RaisePropertyChanged("servicecontractunitscode");
			}
		}
		[XmlElement(Order = 33)]
		public ContractDetailStateInfo statecode
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
		[XmlElement(Order = 34)]
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
		public CrmNumber totalallotments
		{
			get
			{
				return this.totalallotmentsField;
			}
			set
			{
				this.totalallotmentsField = value;
				base.RaisePropertyChanged("totalallotments");
			}
		}
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
		public Lookup uomid
		{
			get
			{
				return this.uomidField;
			}
			set
			{
				this.uomidField = value;
				base.RaisePropertyChanged("uomid");
			}
		}
		[XmlElement(Order = 40)]
		public Lookup uomscheduleid
		{
			get
			{
				return this.uomscheduleidField;
			}
			set
			{
				this.uomscheduleidField = value;
				base.RaisePropertyChanged("uomscheduleid");
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
