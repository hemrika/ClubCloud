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
		public CrmNumber allotmentsremaining
		{
			get
			{
				return this.allotmentsremainingField;
			}
			set
			{
				this.allotmentsremainingField = value;
			}
		}
		public CrmNumber allotmentsused
		{
			get
			{
				return this.allotmentsusedField;
			}
			set
			{
				this.allotmentsusedField = value;
			}
		}
		public Key contractdetailid
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
		public Picklist contractstatecode
		{
			get
			{
				return this.contractstatecodeField;
			}
			set
			{
				this.contractstatecodeField = value;
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
		public CrmMoney discount
		{
			get
			{
				return this.discountField;
			}
			set
			{
				this.discountField = value;
			}
		}
		public CrmMoney discount_base
		{
			get
			{
				return this.discount_baseField;
			}
			set
			{
				this.discount_baseField = value;
			}
		}
		public CrmDecimal discountpercentage
		{
			get
			{
				return this.discountpercentageField;
			}
			set
			{
				this.discountpercentageField = value;
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
		public CrmNumber initialquantity
		{
			get
			{
				return this.initialquantityField;
			}
			set
			{
				this.initialquantityField = value;
			}
		}
		public CrmNumber lineitemorder
		{
			get
			{
				return this.lineitemorderField;
			}
			set
			{
				this.lineitemorderField = value;
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
		public CrmMoney net
		{
			get
			{
				return this.netField;
			}
			set
			{
				this.netField = value;
			}
		}
		public CrmMoney net_base
		{
			get
			{
				return this.net_baseField;
			}
			set
			{
				this.net_baseField = value;
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
		public UniqueIdentifier owningbusinessunit
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
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
		public CrmMoney price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}
		public CrmMoney price_base
		{
			get
			{
				return this.price_baseField;
			}
			set
			{
				this.price_baseField = value;
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
		public CrmMoney rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.rateField = value;
			}
		}
		public CrmMoney rate_base
		{
			get
			{
				return this.rate_baseField;
			}
			set
			{
				this.rate_baseField = value;
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
		public Picklist servicecontractunitscode
		{
			get
			{
				return this.servicecontractunitscodeField;
			}
			set
			{
				this.servicecontractunitscodeField = value;
			}
		}
		public ContractDetailStateInfo statecode
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
		public CrmNumber totalallotments
		{
			get
			{
				return this.totalallotmentsField;
			}
			set
			{
				this.totalallotmentsField = value;
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
		public Lookup uomid
		{
			get
			{
				return this.uomidField;
			}
			set
			{
				this.uomidField = value;
			}
		}
		public Lookup uomscheduleid
		{
			get
			{
				return this.uomscheduleidField;
			}
			set
			{
				this.uomscheduleidField = value;
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
