using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class quotedetail : BusinessEntity
	{
		private CrmMoney baseamountField;
		private CrmMoney baseamount_baseField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmDecimal exchangerateField;
		private CrmMoney extendedamountField;
		private CrmMoney extendedamount_baseField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean ispriceoverriddenField;
		private CrmBoolean isproductoverriddenField;
		private CrmNumber lineitemnumberField;
		private CrmMoney manualdiscountamountField;
		private CrmMoney manualdiscountamount_baseField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private CrmMoney priceperunitField;
		private CrmMoney priceperunit_baseField;
		private Picklist pricingerrorcodeField;
		private string productdescriptionField;
		private Lookup productidField;
		private CrmDecimal quantityField;
		private Key quotedetailidField;
		private Lookup quoteidField;
		private Picklist quotestatecodeField;
		private CrmDateTime requestdeliverybyField;
		private Lookup salesrepidField;
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
		private CrmMoney taxField;
		private CrmMoney tax_baseField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private Lookup uomidField;
		private CrmNumber utcconversiontimezonecodeField;
		private CrmMoney volumediscountamountField;
		private CrmMoney volumediscountamount_baseField;
		private CrmBoolean willcallField;
		[XmlElement(Order = 0)]
		public CrmMoney baseamount
		{
			get
			{
				return this.baseamountField;
			}
			set
			{
				this.baseamountField = value;
				base.RaisePropertyChanged("baseamount");
			}
		}
		[XmlElement(Order = 1)]
		public CrmMoney baseamount_base
		{
			get
			{
				return this.baseamount_baseField;
			}
			set
			{
				this.baseamount_baseField = value;
				base.RaisePropertyChanged("baseamount_base");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public CrmMoney extendedamount
		{
			get
			{
				return this.extendedamountField;
			}
			set
			{
				this.extendedamountField = value;
				base.RaisePropertyChanged("extendedamount");
			}
		}
		[XmlElement(Order = 7)]
		public CrmMoney extendedamount_base
		{
			get
			{
				return this.extendedamount_baseField;
			}
			set
			{
				this.extendedamount_baseField = value;
				base.RaisePropertyChanged("extendedamount_base");
			}
		}
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public CrmBoolean ispriceoverridden
		{
			get
			{
				return this.ispriceoverriddenField;
			}
			set
			{
				this.ispriceoverriddenField = value;
				base.RaisePropertyChanged("ispriceoverridden");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean isproductoverridden
		{
			get
			{
				return this.isproductoverriddenField;
			}
			set
			{
				this.isproductoverriddenField = value;
				base.RaisePropertyChanged("isproductoverridden");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber lineitemnumber
		{
			get
			{
				return this.lineitemnumberField;
			}
			set
			{
				this.lineitemnumberField = value;
				base.RaisePropertyChanged("lineitemnumber");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney manualdiscountamount
		{
			get
			{
				return this.manualdiscountamountField;
			}
			set
			{
				this.manualdiscountamountField = value;
				base.RaisePropertyChanged("manualdiscountamount");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney manualdiscountamount_base
		{
			get
			{
				return this.manualdiscountamount_baseField;
			}
			set
			{
				this.manualdiscountamount_baseField = value;
				base.RaisePropertyChanged("manualdiscountamount_base");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
		public CrmMoney priceperunit
		{
			get
			{
				return this.priceperunitField;
			}
			set
			{
				this.priceperunitField = value;
				base.RaisePropertyChanged("priceperunit");
			}
		}
		[XmlElement(Order = 20)]
		public CrmMoney priceperunit_base
		{
			get
			{
				return this.priceperunit_baseField;
			}
			set
			{
				this.priceperunit_baseField = value;
				base.RaisePropertyChanged("priceperunit_base");
			}
		}
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
		public string productdescription
		{
			get
			{
				return this.productdescriptionField;
			}
			set
			{
				this.productdescriptionField = value;
				base.RaisePropertyChanged("productdescription");
			}
		}
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
		public CrmDecimal quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				base.RaisePropertyChanged("quantity");
			}
		}
		[XmlElement(Order = 25)]
		public Key quotedetailid
		{
			get
			{
				return this.quotedetailidField;
			}
			set
			{
				this.quotedetailidField = value;
				base.RaisePropertyChanged("quotedetailid");
			}
		}
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
		public Picklist quotestatecode
		{
			get
			{
				return this.quotestatecodeField;
			}
			set
			{
				this.quotestatecodeField = value;
				base.RaisePropertyChanged("quotestatecode");
			}
		}
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
		public Lookup salesrepid
		{
			get
			{
				return this.salesrepidField;
			}
			set
			{
				this.salesrepidField = value;
				base.RaisePropertyChanged("salesrepid");
			}
		}
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
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
		[XmlElement(Order = 41)]
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
		[XmlElement(Order = 42)]
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
		[XmlElement(Order = 43)]
		public CrmMoney tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
				base.RaisePropertyChanged("tax");
			}
		}
		[XmlElement(Order = 44)]
		public CrmMoney tax_base
		{
			get
			{
				return this.tax_baseField;
			}
			set
			{
				this.tax_baseField = value;
				base.RaisePropertyChanged("tax_base");
			}
		}
		[XmlElement(Order = 45)]
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
		[XmlElement(Order = 46)]
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
		[XmlElement(Order = 47)]
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
		[XmlElement(Order = 48)]
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
		[XmlElement(Order = 49)]
		public CrmMoney volumediscountamount
		{
			get
			{
				return this.volumediscountamountField;
			}
			set
			{
				this.volumediscountamountField = value;
				base.RaisePropertyChanged("volumediscountamount");
			}
		}
		[XmlElement(Order = 50)]
		public CrmMoney volumediscountamount_base
		{
			get
			{
				return this.volumediscountamount_baseField;
			}
			set
			{
				this.volumediscountamount_baseField = value;
				base.RaisePropertyChanged("volumediscountamount_base");
			}
		}
		[XmlElement(Order = 51)]
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
