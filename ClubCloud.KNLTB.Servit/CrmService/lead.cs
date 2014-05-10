using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class lead : BusinessEntity
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
		private Lookup campaignidField;
		private string companynameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private string descriptionField;
		private CrmBoolean donotbulkemailField;
		private CrmBoolean donotemailField;
		private CrmBoolean donotfaxField;
		private CrmBoolean donotphoneField;
		private CrmBoolean donotpostalmailField;
		private CrmBoolean donotsendmmField;
		private string emailaddress1Field;
		private string emailaddress2Field;
		private string emailaddress3Field;
		private CrmMoney estimatedamountField;
		private CrmMoney estimatedamount_baseField;
		private CrmDateTime estimatedclosedateField;
		private CrmFloat estimatedvalueField;
		private CrmDecimal exchangerateField;
		private string faxField;
		private string firstnameField;
		private string fullnameField;
		private CrmNumber importsequencenumberField;
		private Picklist industrycodeField;
		private string jobtitleField;
		private string lastnameField;
		private CrmDateTime lastusedincampaignField;
		private Key leadidField;
		private Picklist leadqualitycodeField;
		private Picklist leadsourcecodeField;
		private Lookup masteridField;
		private CrmBoolean mergedField;
		private string middlenameField;
		private string mobilephoneField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmNumber numberofemployeesField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string pagerField;
		private CrmBoolean participatesinworkflowField;
		private Picklist preferredcontactmethodcodeField;
		private Picklist prioritycodeField;
		private CrmMoney revenueField;
		private CrmMoney revenue_baseField;
		private Picklist salesstagecodeField;
		private string salutationField;
		private string sicField;
		private LeadStateInfo statecodeField;
		private Status statuscodeField;
		private string subjectField;
		private string telephone1Field;
		private string telephone2Field;
		private string telephone3Field;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		private string websiteurlField;
		private string yomicompanynameField;
		private string yomifirstnameField;
		private string yomifullnameField;
		private string yomilastnameField;
		private string yomimiddlenameField;
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
		public Lookup campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
			}
		}
		public string companyname
		{
			get
			{
				return this.companynameField;
			}
			set
			{
				this.companynameField = value;
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
		public CrmBoolean donotbulkemail
		{
			get
			{
				return this.donotbulkemailField;
			}
			set
			{
				this.donotbulkemailField = value;
			}
		}
		public CrmBoolean donotemail
		{
			get
			{
				return this.donotemailField;
			}
			set
			{
				this.donotemailField = value;
			}
		}
		public CrmBoolean donotfax
		{
			get
			{
				return this.donotfaxField;
			}
			set
			{
				this.donotfaxField = value;
			}
		}
		public CrmBoolean donotphone
		{
			get
			{
				return this.donotphoneField;
			}
			set
			{
				this.donotphoneField = value;
			}
		}
		public CrmBoolean donotpostalmail
		{
			get
			{
				return this.donotpostalmailField;
			}
			set
			{
				this.donotpostalmailField = value;
			}
		}
		public CrmBoolean donotsendmm
		{
			get
			{
				return this.donotsendmmField;
			}
			set
			{
				this.donotsendmmField = value;
			}
		}
		public string emailaddress1
		{
			get
			{
				return this.emailaddress1Field;
			}
			set
			{
				this.emailaddress1Field = value;
			}
		}
		public string emailaddress2
		{
			get
			{
				return this.emailaddress2Field;
			}
			set
			{
				this.emailaddress2Field = value;
			}
		}
		public string emailaddress3
		{
			get
			{
				return this.emailaddress3Field;
			}
			set
			{
				this.emailaddress3Field = value;
			}
		}
		public CrmMoney estimatedamount
		{
			get
			{
				return this.estimatedamountField;
			}
			set
			{
				this.estimatedamountField = value;
			}
		}
		public CrmMoney estimatedamount_base
		{
			get
			{
				return this.estimatedamount_baseField;
			}
			set
			{
				this.estimatedamount_baseField = value;
			}
		}
		public CrmDateTime estimatedclosedate
		{
			get
			{
				return this.estimatedclosedateField;
			}
			set
			{
				this.estimatedclosedateField = value;
			}
		}
		public CrmFloat estimatedvalue
		{
			get
			{
				return this.estimatedvalueField;
			}
			set
			{
				this.estimatedvalueField = value;
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
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
			}
		}
		public string firstname
		{
			get
			{
				return this.firstnameField;
			}
			set
			{
				this.firstnameField = value;
			}
		}
		public string fullname
		{
			get
			{
				return this.fullnameField;
			}
			set
			{
				this.fullnameField = value;
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
		public Picklist industrycode
		{
			get
			{
				return this.industrycodeField;
			}
			set
			{
				this.industrycodeField = value;
			}
		}
		public string jobtitle
		{
			get
			{
				return this.jobtitleField;
			}
			set
			{
				this.jobtitleField = value;
			}
		}
		public string lastname
		{
			get
			{
				return this.lastnameField;
			}
			set
			{
				this.lastnameField = value;
			}
		}
		public CrmDateTime lastusedincampaign
		{
			get
			{
				return this.lastusedincampaignField;
			}
			set
			{
				this.lastusedincampaignField = value;
			}
		}
		public Key leadid
		{
			get
			{
				return this.leadidField;
			}
			set
			{
				this.leadidField = value;
			}
		}
		public Picklist leadqualitycode
		{
			get
			{
				return this.leadqualitycodeField;
			}
			set
			{
				this.leadqualitycodeField = value;
			}
		}
		public Picklist leadsourcecode
		{
			get
			{
				return this.leadsourcecodeField;
			}
			set
			{
				this.leadsourcecodeField = value;
			}
		}
		public Lookup masterid
		{
			get
			{
				return this.masteridField;
			}
			set
			{
				this.masteridField = value;
			}
		}
		public CrmBoolean merged
		{
			get
			{
				return this.mergedField;
			}
			set
			{
				this.mergedField = value;
			}
		}
		public string middlename
		{
			get
			{
				return this.middlenameField;
			}
			set
			{
				this.middlenameField = value;
			}
		}
		public string mobilephone
		{
			get
			{
				return this.mobilephoneField;
			}
			set
			{
				this.mobilephoneField = value;
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
		public CrmNumber numberofemployees
		{
			get
			{
				return this.numberofemployeesField;
			}
			set
			{
				this.numberofemployeesField = value;
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
		public string pager
		{
			get
			{
				return this.pagerField;
			}
			set
			{
				this.pagerField = value;
			}
		}
		public CrmBoolean participatesinworkflow
		{
			get
			{
				return this.participatesinworkflowField;
			}
			set
			{
				this.participatesinworkflowField = value;
			}
		}
		public Picklist preferredcontactmethodcode
		{
			get
			{
				return this.preferredcontactmethodcodeField;
			}
			set
			{
				this.preferredcontactmethodcodeField = value;
			}
		}
		public Picklist prioritycode
		{
			get
			{
				return this.prioritycodeField;
			}
			set
			{
				this.prioritycodeField = value;
			}
		}
		public CrmMoney revenue
		{
			get
			{
				return this.revenueField;
			}
			set
			{
				this.revenueField = value;
			}
		}
		public CrmMoney revenue_base
		{
			get
			{
				return this.revenue_baseField;
			}
			set
			{
				this.revenue_baseField = value;
			}
		}
		public Picklist salesstagecode
		{
			get
			{
				return this.salesstagecodeField;
			}
			set
			{
				this.salesstagecodeField = value;
			}
		}
		public string salutation
		{
			get
			{
				return this.salutationField;
			}
			set
			{
				this.salutationField = value;
			}
		}
		public string sic
		{
			get
			{
				return this.sicField;
			}
			set
			{
				this.sicField = value;
			}
		}
		public LeadStateInfo statecode
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
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}
		public string telephone1
		{
			get
			{
				return this.telephone1Field;
			}
			set
			{
				this.telephone1Field = value;
			}
		}
		public string telephone2
		{
			get
			{
				return this.telephone2Field;
			}
			set
			{
				this.telephone2Field = value;
			}
		}
		public string telephone3
		{
			get
			{
				return this.telephone3Field;
			}
			set
			{
				this.telephone3Field = value;
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
		public string yomicompanyname
		{
			get
			{
				return this.yomicompanynameField;
			}
			set
			{
				this.yomicompanynameField = value;
			}
		}
		public string yomifirstname
		{
			get
			{
				return this.yomifirstnameField;
			}
			set
			{
				this.yomifirstnameField = value;
			}
		}
		public string yomifullname
		{
			get
			{
				return this.yomifullnameField;
			}
			set
			{
				this.yomifullnameField = value;
			}
		}
		public string yomilastname
		{
			get
			{
				return this.yomilastnameField;
			}
			set
			{
				this.yomilastnameField = value;
			}
		}
		public string yomimiddlename
		{
			get
			{
				return this.yomimiddlenameField;
			}
			set
			{
				this.yomimiddlenameField = value;
			}
		}
	}
}
