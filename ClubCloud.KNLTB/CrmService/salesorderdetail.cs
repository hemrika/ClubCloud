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
	public class salesorderdetail : BusinessEntity
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

		private CrmBoolean iscopiedField;

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

		private CrmDecimal quantitybackorderedField;

		private CrmDecimal quantitycancelledField;

		private CrmDecimal quantityshippedField;

		private CrmDateTime requestdeliverybyField;

		private Key salesorderdetailidField;

		private Lookup salesorderidField;

		private CrmBoolean salesorderispricelockedField;

		private Picklist salesorderstatecodeField;

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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean iscopied
		{
			get
			{
				return this.iscopiedField;
			}
			set
			{
				this.iscopiedField = value;
				base.RaisePropertyChanged("iscopied");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
		public CrmDecimal quantitybackordered
		{
			get
			{
				return this.quantitybackorderedField;
			}
			set
			{
				this.quantitybackorderedField = value;
				base.RaisePropertyChanged("quantitybackordered");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmDecimal quantitycancelled
		{
			get
			{
				return this.quantitycancelledField;
			}
			set
			{
				this.quantitycancelledField = value;
				base.RaisePropertyChanged("quantitycancelled");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmDecimal quantityshipped
		{
			get
			{
				return this.quantityshippedField;
			}
			set
			{
				this.quantityshippedField = value;
				base.RaisePropertyChanged("quantityshipped");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
		public Key salesorderdetailid
		{
			get
			{
				return this.salesorderdetailidField;
			}
			set
			{
				this.salesorderdetailidField = value;
				base.RaisePropertyChanged("salesorderdetailid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Lookup salesorderid
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

		[XmlElement] //[XmlElement(Order=32)]
		public CrmBoolean salesorderispricelocked
		{
			get
			{
				return this.salesorderispricelockedField;
			}
			set
			{
				this.salesorderispricelockedField = value;
				base.RaisePropertyChanged("salesorderispricelocked");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Picklist salesorderstatecode
		{
			get
			{
				return this.salesorderstatecodeField;
			}
			set
			{
				this.salesorderstatecodeField = value;
				base.RaisePropertyChanged("salesorderstatecode");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
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

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
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

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
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

		[XmlElement] //[XmlElement(Order=47)]
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

		[XmlElement] //[XmlElement(Order=48)]
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

		[XmlElement] //[XmlElement(Order=49)]
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

		[XmlElement] //[XmlElement(Order=50)]
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

		[XmlElement] //[XmlElement(Order=51)]
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

		[XmlElement] //[XmlElement(Order=52)]
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

		[XmlElement] //[XmlElement(Order=53)]
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

		[XmlElement] //[XmlElement(Order=54)]
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

		[XmlElement] //[XmlElement(Order=55)]
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

		[XmlElement] //[XmlElement(Order=56)]
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

		public salesorderdetail()
		{
		}
	}
}