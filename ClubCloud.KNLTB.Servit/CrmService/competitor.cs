using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class competitor : BusinessEntity
	{
		private Key address1_addressidField;
		private Picklist address1_addresstypecodeField;
		private string address1_cityField;
		private string address1_countryField;
		private string address1_countyField;
		private string address1_faxField;
		private CrmFloat address1_latitudeField;
		private string address1_line1Field;
		private string address1_line2Field;
		private string address1_line3Field;
		private CrmFloat address1_longitudeField;
		private string address1_nameField;
		private string address1_postalcodeField;
		private string address1_postofficeboxField;
		private Picklist address1_shippingmethodcodeField;
		private string address1_stateorprovinceField;
		private string address1_telephone1Field;
		private string address1_telephone2Field;
		private string address1_telephone3Field;
		private string address1_upszoneField;
		private CrmNumber address1_utcoffsetField;
		private Key address2_addressidField;
		private Picklist address2_addresstypecodeField;
		private string address2_cityField;
		private string address2_countryField;
		private string address2_countyField;
		private string address2_faxField;
		private CrmFloat address2_latitudeField;
		private string address2_line1Field;
		private string address2_line2Field;
		private string address2_line3Field;
		private CrmFloat address2_longitudeField;
		private string address2_nameField;
		private string address2_postalcodeField;
		private string address2_postofficeboxField;
		private Picklist address2_shippingmethodcodeField;
		private string address2_stateorprovinceField;
		private string address2_telephone1Field;
		private string address2_telephone2Field;
		private string address2_telephone3Field;
		private string address2_upszoneField;
		private CrmNumber address2_utcoffsetField;
		private Key competitoridField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private string keyproductField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private string opportunitiesField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string overviewField;
		private string referenceinfourlField;
		private CrmMoney reportedrevenueField;
		private CrmMoney reportedrevenue_baseField;
		private CrmNumber reportingquarterField;
		private CrmNumber reportingyearField;
		private string stockexchangeField;
		private string strengthsField;
		private string threatsField;
		private string tickersymbolField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		private string weaknessesField;
		private string websiteurlField;
		private CrmFloat winpercentageField;
		private string yominameField;
		public Key address1_addressid
		{
			get
			{
				return this.address1_addressidField;
			}
			set
			{
				this.address1_addressidField = value;
			}
		}
		public Picklist address1_addresstypecode
		{
			get
			{
				return this.address1_addresstypecodeField;
			}
			set
			{
				this.address1_addresstypecodeField = value;
			}
		}
		public string address1_city
		{
			get
			{
				return this.address1_cityField;
			}
			set
			{
				this.address1_cityField = value;
			}
		}
		public string address1_country
		{
			get
			{
				return this.address1_countryField;
			}
			set
			{
				this.address1_countryField = value;
			}
		}
		public string address1_county
		{
			get
			{
				return this.address1_countyField;
			}
			set
			{
				this.address1_countyField = value;
			}
		}
		public string address1_fax
		{
			get
			{
				return this.address1_faxField;
			}
			set
			{
				this.address1_faxField = value;
			}
		}
		public CrmFloat address1_latitude
		{
			get
			{
				return this.address1_latitudeField;
			}
			set
			{
				this.address1_latitudeField = value;
			}
		}
		public string address1_line1
		{
			get
			{
				return this.address1_line1Field;
			}
			set
			{
				this.address1_line1Field = value;
			}
		}
		public string address1_line2
		{
			get
			{
				return this.address1_line2Field;
			}
			set
			{
				this.address1_line2Field = value;
			}
		}
		public string address1_line3
		{
			get
			{
				return this.address1_line3Field;
			}
			set
			{
				this.address1_line3Field = value;
			}
		}
		public CrmFloat address1_longitude
		{
			get
			{
				return this.address1_longitudeField;
			}
			set
			{
				this.address1_longitudeField = value;
			}
		}
		public string address1_name
		{
			get
			{
				return this.address1_nameField;
			}
			set
			{
				this.address1_nameField = value;
			}
		}
		public string address1_postalcode
		{
			get
			{
				return this.address1_postalcodeField;
			}
			set
			{
				this.address1_postalcodeField = value;
			}
		}
		public string address1_postofficebox
		{
			get
			{
				return this.address1_postofficeboxField;
			}
			set
			{
				this.address1_postofficeboxField = value;
			}
		}
		public Picklist address1_shippingmethodcode
		{
			get
			{
				return this.address1_shippingmethodcodeField;
			}
			set
			{
				this.address1_shippingmethodcodeField = value;
			}
		}
		public string address1_stateorprovince
		{
			get
			{
				return this.address1_stateorprovinceField;
			}
			set
			{
				this.address1_stateorprovinceField = value;
			}
		}
		public string address1_telephone1
		{
			get
			{
				return this.address1_telephone1Field;
			}
			set
			{
				this.address1_telephone1Field = value;
			}
		}
		public string address1_telephone2
		{
			get
			{
				return this.address1_telephone2Field;
			}
			set
			{
				this.address1_telephone2Field = value;
			}
		}
		public string address1_telephone3
		{
			get
			{
				return this.address1_telephone3Field;
			}
			set
			{
				this.address1_telephone3Field = value;
			}
		}
		public string address1_upszone
		{
			get
			{
				return this.address1_upszoneField;
			}
			set
			{
				this.address1_upszoneField = value;
			}
		}
		public CrmNumber address1_utcoffset
		{
			get
			{
				return this.address1_utcoffsetField;
			}
			set
			{
				this.address1_utcoffsetField = value;
			}
		}
		public Key address2_addressid
		{
			get
			{
				return this.address2_addressidField;
			}
			set
			{
				this.address2_addressidField = value;
			}
		}
		public Picklist address2_addresstypecode
		{
			get
			{
				return this.address2_addresstypecodeField;
			}
			set
			{
				this.address2_addresstypecodeField = value;
			}
		}
		public string address2_city
		{
			get
			{
				return this.address2_cityField;
			}
			set
			{
				this.address2_cityField = value;
			}
		}
		public string address2_country
		{
			get
			{
				return this.address2_countryField;
			}
			set
			{
				this.address2_countryField = value;
			}
		}
		public string address2_county
		{
			get
			{
				return this.address2_countyField;
			}
			set
			{
				this.address2_countyField = value;
			}
		}
		public string address2_fax
		{
			get
			{
				return this.address2_faxField;
			}
			set
			{
				this.address2_faxField = value;
			}
		}
		public CrmFloat address2_latitude
		{
			get
			{
				return this.address2_latitudeField;
			}
			set
			{
				this.address2_latitudeField = value;
			}
		}
		public string address2_line1
		{
			get
			{
				return this.address2_line1Field;
			}
			set
			{
				this.address2_line1Field = value;
			}
		}
		public string address2_line2
		{
			get
			{
				return this.address2_line2Field;
			}
			set
			{
				this.address2_line2Field = value;
			}
		}
		public string address2_line3
		{
			get
			{
				return this.address2_line3Field;
			}
			set
			{
				this.address2_line3Field = value;
			}
		}
		public CrmFloat address2_longitude
		{
			get
			{
				return this.address2_longitudeField;
			}
			set
			{
				this.address2_longitudeField = value;
			}
		}
		public string address2_name
		{
			get
			{
				return this.address2_nameField;
			}
			set
			{
				this.address2_nameField = value;
			}
		}
		public string address2_postalcode
		{
			get
			{
				return this.address2_postalcodeField;
			}
			set
			{
				this.address2_postalcodeField = value;
			}
		}
		public string address2_postofficebox
		{
			get
			{
				return this.address2_postofficeboxField;
			}
			set
			{
				this.address2_postofficeboxField = value;
			}
		}
		public Picklist address2_shippingmethodcode
		{
			get
			{
				return this.address2_shippingmethodcodeField;
			}
			set
			{
				this.address2_shippingmethodcodeField = value;
			}
		}
		public string address2_stateorprovince
		{
			get
			{
				return this.address2_stateorprovinceField;
			}
			set
			{
				this.address2_stateorprovinceField = value;
			}
		}
		public string address2_telephone1
		{
			get
			{
				return this.address2_telephone1Field;
			}
			set
			{
				this.address2_telephone1Field = value;
			}
		}
		public string address2_telephone2
		{
			get
			{
				return this.address2_telephone2Field;
			}
			set
			{
				this.address2_telephone2Field = value;
			}
		}
		public string address2_telephone3
		{
			get
			{
				return this.address2_telephone3Field;
			}
			set
			{
				this.address2_telephone3Field = value;
			}
		}
		public string address2_upszone
		{
			get
			{
				return this.address2_upszoneField;
			}
			set
			{
				this.address2_upszoneField = value;
			}
		}
		public CrmNumber address2_utcoffset
		{
			get
			{
				return this.address2_utcoffsetField;
			}
			set
			{
				this.address2_utcoffsetField = value;
			}
		}
		public Key competitorid
		{
			get
			{
				return this.competitoridField;
			}
			set
			{
				this.competitoridField = value;
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
		public string keyproduct
		{
			get
			{
				return this.keyproductField;
			}
			set
			{
				this.keyproductField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public string opportunities
		{
			get
			{
				return this.opportunitiesField;
			}
			set
			{
				this.opportunitiesField = value;
			}
		}
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public string overview
		{
			get
			{
				return this.overviewField;
			}
			set
			{
				this.overviewField = value;
			}
		}
		public string referenceinfourl
		{
			get
			{
				return this.referenceinfourlField;
			}
			set
			{
				this.referenceinfourlField = value;
			}
		}
		public CrmMoney reportedrevenue
		{
			get
			{
				return this.reportedrevenueField;
			}
			set
			{
				this.reportedrevenueField = value;
			}
		}
		public CrmMoney reportedrevenue_base
		{
			get
			{
				return this.reportedrevenue_baseField;
			}
			set
			{
				this.reportedrevenue_baseField = value;
			}
		}
		public CrmNumber reportingquarter
		{
			get
			{
				return this.reportingquarterField;
			}
			set
			{
				this.reportingquarterField = value;
			}
		}
		public CrmNumber reportingyear
		{
			get
			{
				return this.reportingyearField;
			}
			set
			{
				this.reportingyearField = value;
			}
		}
		public string stockexchange
		{
			get
			{
				return this.stockexchangeField;
			}
			set
			{
				this.stockexchangeField = value;
			}
		}
		public string strengths
		{
			get
			{
				return this.strengthsField;
			}
			set
			{
				this.strengthsField = value;
			}
		}
		public string threats
		{
			get
			{
				return this.threatsField;
			}
			set
			{
				this.threatsField = value;
			}
		}
		public string tickersymbol
		{
			get
			{
				return this.tickersymbolField;
			}
			set
			{
				this.tickersymbolField = value;
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
		public string weaknesses
		{
			get
			{
				return this.weaknessesField;
			}
			set
			{
				this.weaknessesField = value;
			}
		}
		public string websiteurl
		{
			get
			{
				return this.websiteurlField;
			}
			set
			{
				this.websiteurlField = value;
			}
		}
		public CrmFloat winpercentage
		{
			get
			{
				return this.winpercentageField;
			}
			set
			{
				this.winpercentageField = value;
			}
		}
		public string yominame
		{
			get
			{
				return this.yominameField;
			}
			set
			{
				this.yominameField = value;
			}
		}
	}
}
