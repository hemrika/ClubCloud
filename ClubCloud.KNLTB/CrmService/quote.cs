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
	public class quote : BusinessEntity
	{
		private UniqueIdentifier billto_addressidField;

		private string billto_cityField;

		private string billto_contactnameField;

		private string billto_countryField;

		private string billto_faxField;

		private string billto_line1Field;

		private string billto_line2Field;

		private string billto_line3Field;

		private string billto_nameField;

		private string billto_postalcodeField;

		private string billto_stateorprovinceField;

		private string billto_telephoneField;

		private Lookup campaignidField;

		private CrmDateTime closedonField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Customer customeridField;

		private string descriptionField;

		private CrmMoney discountamountField;

		private CrmMoney discountamount_baseField;

		private CrmDecimal discountpercentageField;

		private CrmDateTime effectivefromField;

		private CrmDateTime effectivetoField;

		private CrmDecimal exchangerateField;

		private CrmDateTime expiresonField;

		private CrmMoney freightamountField;

		private CrmMoney freightamount_baseField;

		private Picklist freighttermscodeField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Lookup opportunityidField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Picklist paymenttermscodeField;

		private Lookup pricelevelidField;

		private Picklist pricingerrorcodeField;

		private Key quoteidField;

		private string quotenumberField;

		private CrmDateTime requestdeliverybyField;

		private CrmNumber revisionnumberField;

		private Picklist shippingmethodcodeField;

		private UniqueIdentifier shipto_addressidField;

		private string shipto_cityField;

		private string shipto_contactnameField;

		private string shipto_countryField;

		private string shipto_faxField;

		private Picklist shipto_freighttermscodeField;

		private string shipto_line1Field;

		private string shipto_line2Field;

		private string shipto_line3Field;

		private string shipto_nameField;

		private string shipto_postalcodeField;

		private string shipto_stateorprovinceField;

		private string shipto_telephoneField;

		private QuoteStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmMoney totalamountField;

		private CrmMoney totalamount_baseField;

		private CrmMoney totalamountlessfreightField;

		private CrmMoney totalamountlessfreight_baseField;

		private CrmMoney totaldiscountamountField;

		private CrmMoney totaldiscountamount_baseField;

		private CrmMoney totallineitemamountField;

		private CrmMoney totallineitemamount_baseField;

		private CrmMoney totallineitemdiscountamountField;

		private CrmMoney totallineitemdiscountamount_baseField;

		private CrmMoney totaltaxField;

		private CrmMoney totaltax_baseField;

		private Lookup transactioncurrencyidField;

		private CrmNumber utcconversiontimezonecodeField;

		private CrmBoolean willcallField;

		[XmlElement] //[XmlElement(Order=0)]
		public UniqueIdentifier billto_addressid
		{
			get
			{
				return this.billto_addressidField;
			}
			set
			{
				this.billto_addressidField = value;
				base.RaisePropertyChanged("billto_addressid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string billto_city
		{
			get
			{
				return this.billto_cityField;
			}
			set
			{
				this.billto_cityField = value;
				base.RaisePropertyChanged("billto_city");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string billto_contactname
		{
			get
			{
				return this.billto_contactnameField;
			}
			set
			{
				this.billto_contactnameField = value;
				base.RaisePropertyChanged("billto_contactname");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string billto_country
		{
			get
			{
				return this.billto_countryField;
			}
			set
			{
				this.billto_countryField = value;
				base.RaisePropertyChanged("billto_country");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string billto_fax
		{
			get
			{
				return this.billto_faxField;
			}
			set
			{
				this.billto_faxField = value;
				base.RaisePropertyChanged("billto_fax");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public string billto_line1
		{
			get
			{
				return this.billto_line1Field;
			}
			set
			{
				this.billto_line1Field = value;
				base.RaisePropertyChanged("billto_line1");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string billto_line2
		{
			get
			{
				return this.billto_line2Field;
			}
			set
			{
				this.billto_line2Field = value;
				base.RaisePropertyChanged("billto_line2");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public string billto_line3
		{
			get
			{
				return this.billto_line3Field;
			}
			set
			{
				this.billto_line3Field = value;
				base.RaisePropertyChanged("billto_line3");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string billto_name
		{
			get
			{
				return this.billto_nameField;
			}
			set
			{
				this.billto_nameField = value;
				base.RaisePropertyChanged("billto_name");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string billto_postalcode
		{
			get
			{
				return this.billto_postalcodeField;
			}
			set
			{
				this.billto_postalcodeField = value;
				base.RaisePropertyChanged("billto_postalcode");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string billto_stateorprovince
		{
			get
			{
				return this.billto_stateorprovinceField;
			}
			set
			{
				this.billto_stateorprovinceField = value;
				base.RaisePropertyChanged("billto_stateorprovince");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string billto_telephone
		{
			get
			{
				return this.billto_telephoneField;
			}
			set
			{
				this.billto_telephoneField = value;
				base.RaisePropertyChanged("billto_telephone");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDateTime closedon
		{
			get
			{
				return this.closedonField;
			}
			set
			{
				this.closedonField = value;
				base.RaisePropertyChanged("closedon");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public CrmMoney discountamount
		{
			get
			{
				return this.discountamountField;
			}
			set
			{
				this.discountamountField = value;
				base.RaisePropertyChanged("discountamount");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmMoney discountamount_base
		{
			get
			{
				return this.discountamount_baseField;
			}
			set
			{
				this.discountamount_baseField = value;
				base.RaisePropertyChanged("discountamount_base");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
		public CrmDateTime effectivefrom
		{
			get
			{
				return this.effectivefromField;
			}
			set
			{
				this.effectivefromField = value;
				base.RaisePropertyChanged("effectivefrom");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmDateTime effectiveto
		{
			get
			{
				return this.effectivetoField;
			}
			set
			{
				this.effectivetoField = value;
				base.RaisePropertyChanged("effectiveto");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
		public CrmMoney freightamount
		{
			get
			{
				return this.freightamountField;
			}
			set
			{
				this.freightamountField = value;
				base.RaisePropertyChanged("freightamount");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmMoney freightamount_base
		{
			get
			{
				return this.freightamount_baseField;
			}
			set
			{
				this.freightamount_baseField = value;
				base.RaisePropertyChanged("freightamount_base");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public Picklist freighttermscode
		{
			get
			{
				return this.freighttermscodeField;
			}
			set
			{
				this.freighttermscodeField = value;
				base.RaisePropertyChanged("freighttermscode");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
		public Lookup opportunityid
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
		public Picklist paymenttermscode
		{
			get
			{
				return this.paymenttermscodeField;
			}
			set
			{
				this.paymenttermscodeField = value;
				base.RaisePropertyChanged("paymenttermscode");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
		public Key quoteid
		{
			get
			{
				return this.quoteidField;
			}
			set
			{
				this.quoteidField = value;
				base.RaisePropertyChanged("quoteid");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public string quotenumber
		{
			get
			{
				return this.quotenumberField;
			}
			set
			{
				this.quotenumberField = value;
				base.RaisePropertyChanged("quotenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public CrmDateTime requestdeliveryby
		{
			get
			{
				return this.requestdeliverybyField;
			}
			set
			{
				this.requestdeliverybyField = value;
				base.RaisePropertyChanged("requestdeliveryby");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public CrmNumber revisionnumber
		{
			get
			{
				return this.revisionnumberField;
			}
			set
			{
				this.revisionnumberField = value;
				base.RaisePropertyChanged("revisionnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public Picklist shippingmethodcode
		{
			get
			{
				return this.shippingmethodcodeField;
			}
			set
			{
				this.shippingmethodcodeField = value;
				base.RaisePropertyChanged("shippingmethodcode");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public UniqueIdentifier shipto_addressid
		{
			get
			{
				return this.shipto_addressidField;
			}
			set
			{
				this.shipto_addressidField = value;
				base.RaisePropertyChanged("shipto_addressid");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public string shipto_city
		{
			get
			{
				return this.shipto_cityField;
			}
			set
			{
				this.shipto_cityField = value;
				base.RaisePropertyChanged("shipto_city");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public string shipto_contactname
		{
			get
			{
				return this.shipto_contactnameField;
			}
			set
			{
				this.shipto_contactnameField = value;
				base.RaisePropertyChanged("shipto_contactname");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public string shipto_country
		{
			get
			{
				return this.shipto_countryField;
			}
			set
			{
				this.shipto_countryField = value;
				base.RaisePropertyChanged("shipto_country");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public string shipto_fax
		{
			get
			{
				return this.shipto_faxField;
			}
			set
			{
				this.shipto_faxField = value;
				base.RaisePropertyChanged("shipto_fax");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public Picklist shipto_freighttermscode
		{
			get
			{
				return this.shipto_freighttermscodeField;
			}
			set
			{
				this.shipto_freighttermscodeField = value;
				base.RaisePropertyChanged("shipto_freighttermscode");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public string shipto_line1
		{
			get
			{
				return this.shipto_line1Field;
			}
			set
			{
				this.shipto_line1Field = value;
				base.RaisePropertyChanged("shipto_line1");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public string shipto_line2
		{
			get
			{
				return this.shipto_line2Field;
			}
			set
			{
				this.shipto_line2Field = value;
				base.RaisePropertyChanged("shipto_line2");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public string shipto_line3
		{
			get
			{
				return this.shipto_line3Field;
			}
			set
			{
				this.shipto_line3Field = value;
				base.RaisePropertyChanged("shipto_line3");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public string shipto_name
		{
			get
			{
				return this.shipto_nameField;
			}
			set
			{
				this.shipto_nameField = value;
				base.RaisePropertyChanged("shipto_name");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public string shipto_postalcode
		{
			get
			{
				return this.shipto_postalcodeField;
			}
			set
			{
				this.shipto_postalcodeField = value;
				base.RaisePropertyChanged("shipto_postalcode");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public string shipto_stateorprovince
		{
			get
			{
				return this.shipto_stateorprovinceField;
			}
			set
			{
				this.shipto_stateorprovinceField = value;
				base.RaisePropertyChanged("shipto_stateorprovince");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public string shipto_telephone
		{
			get
			{
				return this.shipto_telephoneField;
			}
			set
			{
				this.shipto_telephoneField = value;
				base.RaisePropertyChanged("shipto_telephone");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public QuoteStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=58)]
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

		[XmlElement] //[XmlElement(Order=59)]
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

		[XmlElement] //[XmlElement(Order=60)]
		public CrmMoney totalamount
		{
			get
			{
				return this.totalamountField;
			}
			set
			{
				this.totalamountField = value;
				base.RaisePropertyChanged("totalamount");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public CrmMoney totalamount_base
		{
			get
			{
				return this.totalamount_baseField;
			}
			set
			{
				this.totalamount_baseField = value;
				base.RaisePropertyChanged("totalamount_base");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public CrmMoney totalamountlessfreight
		{
			get
			{
				return this.totalamountlessfreightField;
			}
			set
			{
				this.totalamountlessfreightField = value;
				base.RaisePropertyChanged("totalamountlessfreight");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public CrmMoney totalamountlessfreight_base
		{
			get
			{
				return this.totalamountlessfreight_baseField;
			}
			set
			{
				this.totalamountlessfreight_baseField = value;
				base.RaisePropertyChanged("totalamountlessfreight_base");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public CrmMoney totaldiscountamount
		{
			get
			{
				return this.totaldiscountamountField;
			}
			set
			{
				this.totaldiscountamountField = value;
				base.RaisePropertyChanged("totaldiscountamount");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public CrmMoney totaldiscountamount_base
		{
			get
			{
				return this.totaldiscountamount_baseField;
			}
			set
			{
				this.totaldiscountamount_baseField = value;
				base.RaisePropertyChanged("totaldiscountamount_base");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public CrmMoney totallineitemamount
		{
			get
			{
				return this.totallineitemamountField;
			}
			set
			{
				this.totallineitemamountField = value;
				base.RaisePropertyChanged("totallineitemamount");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public CrmMoney totallineitemamount_base
		{
			get
			{
				return this.totallineitemamount_baseField;
			}
			set
			{
				this.totallineitemamount_baseField = value;
				base.RaisePropertyChanged("totallineitemamount_base");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public CrmMoney totallineitemdiscountamount
		{
			get
			{
				return this.totallineitemdiscountamountField;
			}
			set
			{
				this.totallineitemdiscountamountField = value;
				base.RaisePropertyChanged("totallineitemdiscountamount");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public CrmMoney totallineitemdiscountamount_base
		{
			get
			{
				return this.totallineitemdiscountamount_baseField;
			}
			set
			{
				this.totallineitemdiscountamount_baseField = value;
				base.RaisePropertyChanged("totallineitemdiscountamount_base");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public CrmMoney totaltax
		{
			get
			{
				return this.totaltaxField;
			}
			set
			{
				this.totaltaxField = value;
				base.RaisePropertyChanged("totaltax");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public CrmMoney totaltax_base
		{
			get
			{
				return this.totaltax_baseField;
			}
			set
			{
				this.totaltax_baseField = value;
				base.RaisePropertyChanged("totaltax_base");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
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

		[XmlElement] //[XmlElement(Order=73)]
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

		[XmlElement] //[XmlElement(Order=74)]
		public CrmBoolean willcall
		{
			get
			{
				return this.willcallField;
			}
			set
			{
				this.willcallField = value;
				base.RaisePropertyChanged("willcall");
			}
		}

		public quote()
		{
		}
	}
}