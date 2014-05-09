using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class salesorder : BusinessEntity
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
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private CrmDateTime datefulfilledField;
		private string descriptionField;
		private CrmMoney discountamountField;
		private CrmMoney discountamount_baseField;
		private CrmDecimal discountpercentageField;
		private CrmDecimal exchangerateField;
		private CrmMoney freightamountField;
		private CrmMoney freightamount_baseField;
		private Picklist freighttermscodeField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean ispricelockedField;
		private CrmDateTime lastbackofficesubmitField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup opportunityidField;
		private string ordernumberField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist paymenttermscodeField;
		private Lookup pricelevelidField;
		private Picklist pricingerrorcodeField;
		private Picklist prioritycodeField;
		private Lookup quoteidField;
		private CrmDateTime requestdeliverybyField;
		private Key salesorderidField;
		private Lookup sgt_campagneidField;
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
		private SalesOrderStateInfo statecodeField;
		private Status statuscodeField;
		private CrmDateTime submitdateField;
		private CrmNumber submitstatusField;
		private string submitstatusdescriptionField;
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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public CrmDateTime datefulfilled
		{
			get
			{
				return this.datefulfilledField;
			}
			set
			{
				this.datefulfilledField = value;
				base.RaisePropertyChanged("datefulfilled");
			}
		}
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
		public CrmBoolean ispricelocked
		{
			get
			{
				return this.ispricelockedField;
			}
			set
			{
				this.ispricelockedField = value;
				base.RaisePropertyChanged("ispricelocked");
			}
		}
		[XmlElement(Order = 27)]
		public CrmDateTime lastbackofficesubmit
		{
			get
			{
				return this.lastbackofficesubmitField;
			}
			set
			{
				this.lastbackofficesubmitField = value;
				base.RaisePropertyChanged("lastbackofficesubmit");
			}
		}
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
		public string ordernumber
		{
			get
			{
				return this.ordernumberField;
			}
			set
			{
				this.ordernumberField = value;
				base.RaisePropertyChanged("ordernumber");
			}
		}
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
		public Lookup quoteid
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
		[XmlElement(Order = 41)]
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
		[XmlElement(Order = 42)]
		public Key salesorderid
		{
			get
			{
				return this.salesorderidField;
			}
			set
			{
				this.salesorderidField = value;
				base.RaisePropertyChanged("salesorderid");
			}
		}
		[XmlElement(Order = 43)]
		public Lookup sgt_campagneid
		{
			get
			{
				return this.sgt_campagneidField;
			}
			set
			{
				this.sgt_campagneidField = value;
				base.RaisePropertyChanged("sgt_campagneid");
			}
		}
		[XmlElement(Order = 44)]
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
		[XmlElement(Order = 45)]
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
		[XmlElement(Order = 46)]
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
		[XmlElement(Order = 47)]
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
		[XmlElement(Order = 48)]
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
		[XmlElement(Order = 49)]
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
		[XmlElement(Order = 50)]
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
		[XmlElement(Order = 51)]
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
		[XmlElement(Order = 52)]
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
		[XmlElement(Order = 53)]
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
		[XmlElement(Order = 54)]
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
		[XmlElement(Order = 55)]
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
		[XmlElement(Order = 56)]
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
		[XmlElement(Order = 57)]
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
		[XmlElement(Order = 58)]
		public SalesOrderStateInfo statecode
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
		[XmlElement(Order = 59)]
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
		[XmlElement(Order = 60)]
		public CrmDateTime submitdate
		{
			get
			{
				return this.submitdateField;
			}
			set
			{
				this.submitdateField = value;
				base.RaisePropertyChanged("submitdate");
			}
		}
		[XmlElement(Order = 61)]
		public CrmNumber submitstatus
		{
			get
			{
				return this.submitstatusField;
			}
			set
			{
				this.submitstatusField = value;
				base.RaisePropertyChanged("submitstatus");
			}
		}
		[XmlElement(Order = 62)]
		public string submitstatusdescription
		{
			get
			{
				return this.submitstatusdescriptionField;
			}
			set
			{
				this.submitstatusdescriptionField = value;
				base.RaisePropertyChanged("submitstatusdescription");
			}
		}
		[XmlElement(Order = 63)]
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
		[XmlElement(Order = 64)]
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
		[XmlElement(Order = 65)]
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
		[XmlElement(Order = 66)]
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
		[XmlElement(Order = 67)]
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
		[XmlElement(Order = 68)]
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
		[XmlElement(Order = 69)]
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
		[XmlElement(Order = 70)]
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
		[XmlElement(Order = 71)]
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
		[XmlElement(Order = 72)]
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
		[XmlElement(Order = 73)]
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
		[XmlElement(Order = 74)]
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
		[XmlElement(Order = 75)]
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
		[XmlElement(Order = 76)]
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
		[XmlElement(Order = 77)]
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
		[XmlElement(Order = 78)]
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
	}
}
