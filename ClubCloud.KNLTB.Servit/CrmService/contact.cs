using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class contact : BusinessEntity
	{
		private Picklist accountrolecodeField;
		private Key address1_addressidField;
		private Picklist address1_addresstypecodeField;
		private string address1_cityField;
		private string address1_countryField;
		private string address1_countyField;
		private string address1_faxField;
		private Picklist address1_freighttermscodeField;
		private CrmFloat address1_latitudeField;
		private string address1_line1Field;
		private string address1_line2Field;
		private string address1_line3Field;
		private CrmFloat address1_longitudeField;
		private string address1_nameField;
		private string address1_postalcodeField;
		private string address1_postofficeboxField;
		private string address1_primarycontactnameField;
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
		private Picklist address2_freighttermscodeField;
		private CrmFloat address2_latitudeField;
		private string address2_line1Field;
		private string address2_line2Field;
		private string address2_line3Field;
		private CrmFloat address2_longitudeField;
		private string address2_nameField;
		private string address2_postalcodeField;
		private string address2_postofficeboxField;
		private string address2_primarycontactnameField;
		private Picklist address2_shippingmethodcodeField;
		private string address2_stateorprovinceField;
		private string address2_telephone1Field;
		private string address2_telephone2Field;
		private string address2_telephone3Field;
		private string address2_upszoneField;
		private CrmNumber address2_utcoffsetField;
		private CrmMoney aging30Field;
		private CrmMoney aging30_baseField;
		private CrmMoney aging60Field;
		private CrmMoney aging60_baseField;
		private CrmMoney aging90Field;
		private CrmMoney aging90_baseField;
		private CrmDateTime anniversaryField;
		private CrmMoney annualincomeField;
		private CrmMoney annualincome_baseField;
		private string assistantnameField;
		private string assistantphoneField;
		private CrmDateTime birthdateField;
		private string childrensnamesField;
		private Key contactidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmMoney creditlimitField;
		private CrmMoney creditlimit_baseField;
		private CrmBoolean creditonholdField;
		private Picklist customersizecodeField;
		private Picklist customertypecodeField;
		private Lookup defaultpricelevelidField;
		private string departmentField;
		private string descriptionField;
		private CrmBoolean donotbulkemailField;
		private CrmBoolean donotbulkpostalmailField;
		private CrmBoolean donotemailField;
		private CrmBoolean donotfaxField;
		private CrmBoolean donotphoneField;
		private CrmBoolean donotpostalmailField;
		private CrmBoolean donotsendmmField;
		private Picklist educationcodeField;
		private string emailaddress1Field;
		private string emailaddress2Field;
		private string emailaddress3Field;
		private string employeeidField;
		private CrmDecimal exchangerateField;
		private string externaluseridentifierField;
		private Picklist familystatuscodeField;
		private string faxField;
		private string firstnameField;
		private string ftpsiteurlField;
		private string fullnameField;
		private Picklist gendercodeField;
		private string governmentidField;
		private Picklist haschildrencodeField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isbackofficecustomerField;
		private string jobtitleField;
		private string lastnameField;
		private CrmDateTime lastusedincampaignField;
		private Picklist leadsourcecodeField;
		private string managernameField;
		private string managerphoneField;
		private Lookup masteridField;
		private CrmBoolean mergedField;
		private string middlenameField;
		private string mobilephoneField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nicknameField;
		private CrmNumber numberofchildrenField;
		private Lookup originatingleadidField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string pagerField;
		private Customer parentcustomeridField;
		private CrmBoolean participatesinworkflowField;
		private Picklist paymenttermscodeField;
		private Picklist preferredappointmentdaycodeField;
		private Picklist preferredappointmenttimecodeField;
		private Picklist preferredcontactmethodcodeField;
		private Lookup preferredequipmentidField;
		private Lookup preferredserviceidField;
		private Lookup preferredsystemuseridField;
		private string salutationField;
		private Lookup sgt_2e_nationaliteitidField;
		private string sgt_aanhef_briefhoofd_nlField;
		private string sgt_aanhef_tav_nlField;
		private CrmBoolean sgt_adres_geheimField;
		private CrmDateTime sgt_afas_exportdatumField;
		private Picklist sgt_afas_exportstatusField;
		private string sgt_bondsnummerField;
		private CrmDateTime sgt_datum_foto_uploadField;
		private CrmDateTime sgt_datum_overledenField;
		private CrmDateTime sgt_dcp_data_gewijzigd_opField;
		private CrmDateTime sgt_dcp_foto_gewijzigd_opField;
		private string sgt_debiteurnummerField;
		private string sgt_fotonummerField;
		private string sgt_geboorteplaatsField;
		private string sgt_iban_codeField;
		private CrmBoolean sgt_is_functionarisField;
		private CrmBoolean sgt_is_lidField;
		private Picklist sgt_junior_seniorField;
		private Lookup sgt_landcode_postadresidField;
		private Lookup sgt_landcode_woonadresidField;
		private Lookup sgt_logboek_facturatie_exp_debiteuridField;
		private CrmBoolean sgt_meerlingField;
		private Lookup sgt_nationaliteitidField;
		private CrmBoolean sgt_openstaande_boetesField;
		private Lookup sgt_pb_mutatie_ledenidField;
		private Lookup sgt_primaire_vereniging_idField;
		private CrmDecimal sgt_rating_dubbelField;
		private CrmDecimal sgt_rating_enkelField;
		private string sgt_rekeningnummerField;
		private string sgt_rekeningnummer_plaatsField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private CrmBoolean sgt_telefoon_geheimField;
		private Lookup sgt_tennisnationaliteitidField;
		private string sgt_voornamenField;
		private Picklist shippingmethodcodeField;
		private string spousesnameField;
		private ContactStateInfo statecodeField;
		private Status statuscodeField;
		private UniqueIdentifier subscriptionidField;
		private string suffixField;
		private string telephone1Field;
		private string telephone2Field;
		private string telephone3Field;
		private Picklist territorycodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		private string websiteurlField;
		private string yomifirstnameField;
		private string yomifullnameField;
		private string yomilastnameField;
		private string yomimiddlenameField;
		public Picklist accountrolecode
		{
			get
			{
				return this.accountrolecodeField;
			}
			set
			{
				this.accountrolecodeField = value;
			}
		}
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
		public Picklist address1_freighttermscode
		{
			get
			{
				return this.address1_freighttermscodeField;
			}
			set
			{
				this.address1_freighttermscodeField = value;
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
		public string address1_primarycontactname
		{
			get
			{
				return this.address1_primarycontactnameField;
			}
			set
			{
				this.address1_primarycontactnameField = value;
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
		public Picklist address2_freighttermscode
		{
			get
			{
				return this.address2_freighttermscodeField;
			}
			set
			{
				this.address2_freighttermscodeField = value;
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
		public string address2_primarycontactname
		{
			get
			{
				return this.address2_primarycontactnameField;
			}
			set
			{
				this.address2_primarycontactnameField = value;
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
		public CrmMoney aging30
		{
			get
			{
				return this.aging30Field;
			}
			set
			{
				this.aging30Field = value;
			}
		}
		public CrmMoney aging30_base
		{
			get
			{
				return this.aging30_baseField;
			}
			set
			{
				this.aging30_baseField = value;
			}
		}
		public CrmMoney aging60
		{
			get
			{
				return this.aging60Field;
			}
			set
			{
				this.aging60Field = value;
			}
		}
		public CrmMoney aging60_base
		{
			get
			{
				return this.aging60_baseField;
			}
			set
			{
				this.aging60_baseField = value;
			}
		}
		public CrmMoney aging90
		{
			get
			{
				return this.aging90Field;
			}
			set
			{
				this.aging90Field = value;
			}
		}
		public CrmMoney aging90_base
		{
			get
			{
				return this.aging90_baseField;
			}
			set
			{
				this.aging90_baseField = value;
			}
		}
		public CrmDateTime anniversary
		{
			get
			{
				return this.anniversaryField;
			}
			set
			{
				this.anniversaryField = value;
			}
		}
		public CrmMoney annualincome
		{
			get
			{
				return this.annualincomeField;
			}
			set
			{
				this.annualincomeField = value;
			}
		}
		public CrmMoney annualincome_base
		{
			get
			{
				return this.annualincome_baseField;
			}
			set
			{
				this.annualincome_baseField = value;
			}
		}
		public string assistantname
		{
			get
			{
				return this.assistantnameField;
			}
			set
			{
				this.assistantnameField = value;
			}
		}
		public string assistantphone
		{
			get
			{
				return this.assistantphoneField;
			}
			set
			{
				this.assistantphoneField = value;
			}
		}
		public CrmDateTime birthdate
		{
			get
			{
				return this.birthdateField;
			}
			set
			{
				this.birthdateField = value;
			}
		}
		public string childrensnames
		{
			get
			{
				return this.childrensnamesField;
			}
			set
			{
				this.childrensnamesField = value;
			}
		}
		public Key contactid
		{
			get
			{
				return this.contactidField;
			}
			set
			{
				this.contactidField = value;
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
		public CrmMoney creditlimit
		{
			get
			{
				return this.creditlimitField;
			}
			set
			{
				this.creditlimitField = value;
			}
		}
		public CrmMoney creditlimit_base
		{
			get
			{
				return this.creditlimit_baseField;
			}
			set
			{
				this.creditlimit_baseField = value;
			}
		}
		public CrmBoolean creditonhold
		{
			get
			{
				return this.creditonholdField;
			}
			set
			{
				this.creditonholdField = value;
			}
		}
		public Picklist customersizecode
		{
			get
			{
				return this.customersizecodeField;
			}
			set
			{
				this.customersizecodeField = value;
			}
		}
		public Picklist customertypecode
		{
			get
			{
				return this.customertypecodeField;
			}
			set
			{
				this.customertypecodeField = value;
			}
		}
		public Lookup defaultpricelevelid
		{
			get
			{
				return this.defaultpricelevelidField;
			}
			set
			{
				this.defaultpricelevelidField = value;
			}
		}
		public string department
		{
			get
			{
				return this.departmentField;
			}
			set
			{
				this.departmentField = value;
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
		public CrmBoolean donotbulkpostalmail
		{
			get
			{
				return this.donotbulkpostalmailField;
			}
			set
			{
				this.donotbulkpostalmailField = value;
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
		public Picklist educationcode
		{
			get
			{
				return this.educationcodeField;
			}
			set
			{
				this.educationcodeField = value;
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
		public string employeeid
		{
			get
			{
				return this.employeeidField;
			}
			set
			{
				this.employeeidField = value;
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
		public string externaluseridentifier
		{
			get
			{
				return this.externaluseridentifierField;
			}
			set
			{
				this.externaluseridentifierField = value;
			}
		}
		public Picklist familystatuscode
		{
			get
			{
				return this.familystatuscodeField;
			}
			set
			{
				this.familystatuscodeField = value;
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
		public string ftpsiteurl
		{
			get
			{
				return this.ftpsiteurlField;
			}
			set
			{
				this.ftpsiteurlField = value;
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
		public Picklist gendercode
		{
			get
			{
				return this.gendercodeField;
			}
			set
			{
				this.gendercodeField = value;
			}
		}
		public string governmentid
		{
			get
			{
				return this.governmentidField;
			}
			set
			{
				this.governmentidField = value;
			}
		}
		public Picklist haschildrencode
		{
			get
			{
				return this.haschildrencodeField;
			}
			set
			{
				this.haschildrencodeField = value;
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
		public CrmBoolean isbackofficecustomer
		{
			get
			{
				return this.isbackofficecustomerField;
			}
			set
			{
				this.isbackofficecustomerField = value;
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
		public string managername
		{
			get
			{
				return this.managernameField;
			}
			set
			{
				this.managernameField = value;
			}
		}
		public string managerphone
		{
			get
			{
				return this.managerphoneField;
			}
			set
			{
				this.managerphoneField = value;
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
		public string nickname
		{
			get
			{
				return this.nicknameField;
			}
			set
			{
				this.nicknameField = value;
			}
		}
		public CrmNumber numberofchildren
		{
			get
			{
				return this.numberofchildrenField;
			}
			set
			{
				this.numberofchildrenField = value;
			}
		}
		public Lookup originatingleadid
		{
			get
			{
				return this.originatingleadidField;
			}
			set
			{
				this.originatingleadidField = value;
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
		public Customer parentcustomerid
		{
			get
			{
				return this.parentcustomeridField;
			}
			set
			{
				this.parentcustomeridField = value;
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
		public Picklist paymenttermscode
		{
			get
			{
				return this.paymenttermscodeField;
			}
			set
			{
				this.paymenttermscodeField = value;
			}
		}
		public Picklist preferredappointmentdaycode
		{
			get
			{
				return this.preferredappointmentdaycodeField;
			}
			set
			{
				this.preferredappointmentdaycodeField = value;
			}
		}
		public Picklist preferredappointmenttimecode
		{
			get
			{
				return this.preferredappointmenttimecodeField;
			}
			set
			{
				this.preferredappointmenttimecodeField = value;
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
		public Lookup preferredequipmentid
		{
			get
			{
				return this.preferredequipmentidField;
			}
			set
			{
				this.preferredequipmentidField = value;
			}
		}
		public Lookup preferredserviceid
		{
			get
			{
				return this.preferredserviceidField;
			}
			set
			{
				this.preferredserviceidField = value;
			}
		}
		public Lookup preferredsystemuserid
		{
			get
			{
				return this.preferredsystemuseridField;
			}
			set
			{
				this.preferredsystemuseridField = value;
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
		public Lookup sgt_2e_nationaliteitid
		{
			get
			{
				return this.sgt_2e_nationaliteitidField;
			}
			set
			{
				this.sgt_2e_nationaliteitidField = value;
			}
		}
		public string sgt_aanhef_briefhoofd_nl
		{
			get
			{
				return this.sgt_aanhef_briefhoofd_nlField;
			}
			set
			{
				this.sgt_aanhef_briefhoofd_nlField = value;
			}
		}
		public string sgt_aanhef_tav_nl
		{
			get
			{
				return this.sgt_aanhef_tav_nlField;
			}
			set
			{
				this.sgt_aanhef_tav_nlField = value;
			}
		}
		public CrmBoolean sgt_adres_geheim
		{
			get
			{
				return this.sgt_adres_geheimField;
			}
			set
			{
				this.sgt_adres_geheimField = value;
			}
		}
		public CrmDateTime sgt_afas_exportdatum
		{
			get
			{
				return this.sgt_afas_exportdatumField;
			}
			set
			{
				this.sgt_afas_exportdatumField = value;
			}
		}
		public Picklist sgt_afas_exportstatus
		{
			get
			{
				return this.sgt_afas_exportstatusField;
			}
			set
			{
				this.sgt_afas_exportstatusField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public CrmDateTime sgt_datum_foto_upload
		{
			get
			{
				return this.sgt_datum_foto_uploadField;
			}
			set
			{
				this.sgt_datum_foto_uploadField = value;
			}
		}
		public CrmDateTime sgt_datum_overleden
		{
			get
			{
				return this.sgt_datum_overledenField;
			}
			set
			{
				this.sgt_datum_overledenField = value;
			}
		}
		public CrmDateTime sgt_dcp_data_gewijzigd_op
		{
			get
			{
				return this.sgt_dcp_data_gewijzigd_opField;
			}
			set
			{
				this.sgt_dcp_data_gewijzigd_opField = value;
			}
		}
		public CrmDateTime sgt_dcp_foto_gewijzigd_op
		{
			get
			{
				return this.sgt_dcp_foto_gewijzigd_opField;
			}
			set
			{
				this.sgt_dcp_foto_gewijzigd_opField = value;
			}
		}
		public string sgt_debiteurnummer
		{
			get
			{
				return this.sgt_debiteurnummerField;
			}
			set
			{
				this.sgt_debiteurnummerField = value;
			}
		}
		public string sgt_fotonummer
		{
			get
			{
				return this.sgt_fotonummerField;
			}
			set
			{
				this.sgt_fotonummerField = value;
			}
		}
		public string sgt_geboorteplaats
		{
			get
			{
				return this.sgt_geboorteplaatsField;
			}
			set
			{
				this.sgt_geboorteplaatsField = value;
			}
		}
		public string sgt_iban_code
		{
			get
			{
				return this.sgt_iban_codeField;
			}
			set
			{
				this.sgt_iban_codeField = value;
			}
		}
		public CrmBoolean sgt_is_functionaris
		{
			get
			{
				return this.sgt_is_functionarisField;
			}
			set
			{
				this.sgt_is_functionarisField = value;
			}
		}
		public CrmBoolean sgt_is_lid
		{
			get
			{
				return this.sgt_is_lidField;
			}
			set
			{
				this.sgt_is_lidField = value;
			}
		}
		public Picklist sgt_junior_senior
		{
			get
			{
				return this.sgt_junior_seniorField;
			}
			set
			{
				this.sgt_junior_seniorField = value;
			}
		}
		public Lookup sgt_landcode_postadresid
		{
			get
			{
				return this.sgt_landcode_postadresidField;
			}
			set
			{
				this.sgt_landcode_postadresidField = value;
			}
		}
		public Lookup sgt_landcode_woonadresid
		{
			get
			{
				return this.sgt_landcode_woonadresidField;
			}
			set
			{
				this.sgt_landcode_woonadresidField = value;
			}
		}
		public Lookup sgt_logboek_facturatie_exp_debiteurid
		{
			get
			{
				return this.sgt_logboek_facturatie_exp_debiteuridField;
			}
			set
			{
				this.sgt_logboek_facturatie_exp_debiteuridField = value;
			}
		}
		public CrmBoolean sgt_meerling
		{
			get
			{
				return this.sgt_meerlingField;
			}
			set
			{
				this.sgt_meerlingField = value;
			}
		}
		public Lookup sgt_nationaliteitid
		{
			get
			{
				return this.sgt_nationaliteitidField;
			}
			set
			{
				this.sgt_nationaliteitidField = value;
			}
		}
		public CrmBoolean sgt_openstaande_boetes
		{
			get
			{
				return this.sgt_openstaande_boetesField;
			}
			set
			{
				this.sgt_openstaande_boetesField = value;
			}
		}
		public Lookup sgt_pb_mutatie_ledenid
		{
			get
			{
				return this.sgt_pb_mutatie_ledenidField;
			}
			set
			{
				this.sgt_pb_mutatie_ledenidField = value;
			}
		}
		public Lookup sgt_primaire_vereniging_id
		{
			get
			{
				return this.sgt_primaire_vereniging_idField;
			}
			set
			{
				this.sgt_primaire_vereniging_idField = value;
			}
		}
		public CrmDecimal sgt_rating_dubbel
		{
			get
			{
				return this.sgt_rating_dubbelField;
			}
			set
			{
				this.sgt_rating_dubbelField = value;
			}
		}
		public CrmDecimal sgt_rating_enkel
		{
			get
			{
				return this.sgt_rating_enkelField;
			}
			set
			{
				this.sgt_rating_enkelField = value;
			}
		}
		public string sgt_rekeningnummer
		{
			get
			{
				return this.sgt_rekeningnummerField;
			}
			set
			{
				this.sgt_rekeningnummerField = value;
			}
		}
		public string sgt_rekeningnummer_plaats
		{
			get
			{
				return this.sgt_rekeningnummer_plaatsField;
			}
			set
			{
				this.sgt_rekeningnummer_plaatsField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
			}
		}
		public CrmBoolean sgt_telefoon_geheim
		{
			get
			{
				return this.sgt_telefoon_geheimField;
			}
			set
			{
				this.sgt_telefoon_geheimField = value;
			}
		}
		public Lookup sgt_tennisnationaliteitid
		{
			get
			{
				return this.sgt_tennisnationaliteitidField;
			}
			set
			{
				this.sgt_tennisnationaliteitidField = value;
			}
		}
		public string sgt_voornamen
		{
			get
			{
				return this.sgt_voornamenField;
			}
			set
			{
				this.sgt_voornamenField = value;
			}
		}
		public Picklist shippingmethodcode
		{
			get
			{
				return this.shippingmethodcodeField;
			}
			set
			{
				this.shippingmethodcodeField = value;
			}
		}
		public string spousesname
		{
			get
			{
				return this.spousesnameField;
			}
			set
			{
				this.spousesnameField = value;
			}
		}
		public ContactStateInfo statecode
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
		public UniqueIdentifier subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
			}
		}
		public string suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
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
		public Picklist territorycode
		{
			get
			{
				return this.territorycodeField;
			}
			set
			{
				this.territorycodeField = value;
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
