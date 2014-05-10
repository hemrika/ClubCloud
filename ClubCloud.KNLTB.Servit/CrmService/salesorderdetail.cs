using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmMoney baseamount
		{
			get
			{
				return this.baseamountField;
			}
			set
			{
				this.baseamountField = value;
			}
		}
		public CrmMoney baseamount_base
		{
			get
			{
				return this.baseamount_baseField;
			}
			set
			{
				this.baseamount_baseField = value;
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
		public CrmMoney extendedamount
		{
			get
			{
				return this.extendedamountField;
			}
			set
			{
				this.extendedamountField = value;
			}
		}
		public CrmMoney extendedamount_base
		{
			get
			{
				return this.extendedamount_baseField;
			}
			set
			{
				this.extendedamount_baseField = value;
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
		public CrmBoolean iscopied
		{
			get
			{
				return this.iscopiedField;
			}
			set
			{
				this.iscopiedField = value;
			}
		}
		public CrmBoolean ispriceoverridden
		{
			get
			{
				return this.ispriceoverriddenField;
			}
			set
			{
				this.ispriceoverriddenField = value;
			}
		}
		public CrmBoolean isproductoverridden
		{
			get
			{
				return this.isproductoverriddenField;
			}
			set
			{
				this.isproductoverriddenField = value;
			}
		}
		public CrmNumber lineitemnumber
		{
			get
			{
				return this.lineitemnumberField;
			}
			set
			{
				this.lineitemnumberField = value;
			}
		}
		public CrmMoney manualdiscountamount
		{
			get
			{
				return this.manualdiscountamountField;
			}
			set
			{
				this.manualdiscountamountField = value;
			}
		}
		public CrmMoney manualdiscountamount_base
		{
			get
			{
				return this.manualdiscountamount_baseField;
			}
			set
			{
				this.manualdiscountamount_baseField = value;
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
		public CrmMoney priceperunit
		{
			get
			{
				return this.priceperunitField;
			}
			set
			{
				this.priceperunitField = value;
			}
		}
		public CrmMoney priceperunit_base
		{
			get
			{
				return this.priceperunit_baseField;
			}
			set
			{
				this.priceperunit_baseField = value;
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
		public string productdescription
		{
			get
			{
				return this.productdescriptionField;
			}
			set
			{
				this.productdescriptionField = value;
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
		public CrmDecimal quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}
		public CrmDecimal quantitybackordered
		{
			get
			{
				return this.quantitybackorderedField;
			}
			set
			{
				this.quantitybackorderedField = value;
			}
		}
		public CrmDecimal quantitycancelled
		{
			get
			{
				return this.quantitycancelledField;
			}
			set
			{
				this.quantitycancelledField = value;
			}
		}
		public CrmDecimal quantityshipped
		{
			get
			{
				return this.quantityshippedField;
			}
			set
			{
				this.quantityshippedField = value;
			}
		}
		public CrmDateTime requestdeliveryby
		{
			get
			{
				return this.requestdeliverybyField;
			}
			set
			{
				this.requestdeliverybyField = value;
			}
		}
		public Key salesorderdetailid
		{
			get
			{
				return this.salesorderdetailidField;
			}
			set
			{
				this.salesorderdetailidField = value;
			}
		}
		public Lookup salesorderid
		{
			get
			{
				return this.salesorderidField;
			}
			set
			{
				this.salesorderidField = value;
			}
		}
		public CrmBoolean salesorderispricelocked
		{
			get
			{
				return this.salesorderispricelockedField;
			}
			set
			{
				this.salesorderispricelockedField = value;
			}
		}
		public Picklist salesorderstatecode
		{
			get
			{
				return this.salesorderstatecodeField;
			}
			set
			{
				this.salesorderstatecodeField = value;
			}
		}
		public Lookup salesrepid
		{
			get
			{
				return this.salesrepidField;
			}
			set
			{
				this.salesrepidField = value;
			}
		}
		public UniqueIdentifier shipto_addressid
		{
			get
			{
				return this.shipto_addressidField;
			}
			set
			{
				this.shipto_addressidField = value;
			}
		}
		public string shipto_city
		{
			get
			{
				return this.shipto_cityField;
			}
			set
			{
				this.shipto_cityField = value;
			}
		}
		public string shipto_contactname
		{
			get
			{
				return this.shipto_contactnameField;
			}
			set
			{
				this.shipto_contactnameField = value;
			}
		}
		public string shipto_country
		{
			get
			{
				return this.shipto_countryField;
			}
			set
			{
				this.shipto_countryField = value;
			}
		}
		public string shipto_fax
		{
			get
			{
				return this.shipto_faxField;
			}
			set
			{
				this.shipto_faxField = value;
			}
		}
		public Picklist shipto_freighttermscode
		{
			get
			{
				return this.shipto_freighttermscodeField;
			}
			set
			{
				this.shipto_freighttermscodeField = value;
			}
		}
		public string shipto_line1
		{
			get
			{
				return this.shipto_line1Field;
			}
			set
			{
				this.shipto_line1Field = value;
			}
		}
		public string shipto_line2
		{
			get
			{
				return this.shipto_line2Field;
			}
			set
			{
				this.shipto_line2Field = value;
			}
		}
		public string shipto_line3
		{
			get
			{
				return this.shipto_line3Field;
			}
			set
			{
				this.shipto_line3Field = value;
			}
		}
		public string shipto_name
		{
			get
			{
				return this.shipto_nameField;
			}
			set
			{
				this.shipto_nameField = value;
			}
		}
		public string shipto_postalcode
		{
			get
			{
				return this.shipto_postalcodeField;
			}
			set
			{
				this.shipto_postalcodeField = value;
			}
		}
		public string shipto_stateorprovince
		{
			get
			{
				return this.shipto_stateorprovinceField;
			}
			set
			{
				this.shipto_stateorprovinceField = value;
			}
		}
		public string shipto_telephone
		{
			get
			{
				return this.shipto_telephoneField;
			}
			set
			{
				this.shipto_telephoneField = value;
			}
		}
		public CrmMoney tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
			}
		}
		public CrmMoney tax_base
		{
			get
			{
				return this.tax_baseField;
			}
			set
			{
				this.tax_baseField = value;
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
		public CrmMoney volumediscountamount
		{
			get
			{
				return this.volumediscountamountField;
			}
			set
			{
				this.volumediscountamountField = value;
			}
		}
		public CrmMoney volumediscountamount_base
		{
			get
			{
				return this.volumediscountamount_baseField;
			}
			set
			{
				this.volumediscountamount_baseField = value;
			}
		}
		public CrmBoolean willcall
		{
			get
			{
				return this.willcallField;
			}
			set
			{
				this.willcallField = value;
			}
		}
	}
}
