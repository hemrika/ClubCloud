using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public Picklist accountrolecode
		{
			get
			{
				return this.accountrolecodeField;
			}
			set
			{
				this.accountrolecodeField = value;
				base.RaisePropertyChanged("accountrolecode");
			}
		}
		[XmlElement(Order = 1)]
		public Key address1_addressid
		{
			get
			{
				return this.address1_addressidField;
			}
			set
			{
				this.address1_addressidField = value;
				base.RaisePropertyChanged("address1_addressid");
			}
		}
		[XmlElement(Order = 2)]
		public Picklist address1_addresstypecode
		{
			get
			{
				return this.address1_addresstypecodeField;
			}
			set
			{
				this.address1_addresstypecodeField = value;
				base.RaisePropertyChanged("address1_addresstypecode");
			}
		}
		[XmlElement(Order = 3)]
		public string address1_city
		{
			get
			{
				return this.address1_cityField;
			}
			set
			{
				this.address1_cityField = value;
				base.RaisePropertyChanged("address1_city");
			}
		}
		[XmlElement(Order = 4)]
		public string address1_country
		{
			get
			{
				return this.address1_countryField;
			}
			set
			{
				this.address1_countryField = value;
				base.RaisePropertyChanged("address1_country");
			}
		}
		[XmlElement(Order = 5)]
		public string address1_county
		{
			get
			{
				return this.address1_countyField;
			}
			set
			{
				this.address1_countyField = value;
				base.RaisePropertyChanged("address1_county");
			}
		}
		[XmlElement(Order = 6)]
		public string address1_fax
		{
			get
			{
				return this.address1_faxField;
			}
			set
			{
				this.address1_faxField = value;
				base.RaisePropertyChanged("address1_fax");
			}
		}
		[XmlElement(Order = 7)]
		public Picklist address1_freighttermscode
		{
			get
			{
				return this.address1_freighttermscodeField;
			}
			set
			{
				this.address1_freighttermscodeField = value;
				base.RaisePropertyChanged("address1_freighttermscode");
			}
		}
		[XmlElement(Order = 8)]
		public CrmFloat address1_latitude
		{
			get
			{
				return this.address1_latitudeField;
			}
			set
			{
				this.address1_latitudeField = value;
				base.RaisePropertyChanged("address1_latitude");
			}
		}
		[XmlElement(Order = 9)]
		public string address1_line1
		{
			get
			{
				return this.address1_line1Field;
			}
			set
			{
				this.address1_line1Field = value;
				base.RaisePropertyChanged("address1_line1");
			}
		}
		[XmlElement(Order = 10)]
		public string address1_line2
		{
			get
			{
				return this.address1_line2Field;
			}
			set
			{
				this.address1_line2Field = value;
				base.RaisePropertyChanged("address1_line2");
			}
		}
		[XmlElement(Order = 11)]
		public string address1_line3
		{
			get
			{
				return this.address1_line3Field;
			}
			set
			{
				this.address1_line3Field = value;
				base.RaisePropertyChanged("address1_line3");
			}
		}
		[XmlElement(Order = 12)]
		public CrmFloat address1_longitude
		{
			get
			{
				return this.address1_longitudeField;
			}
			set
			{
				this.address1_longitudeField = value;
				base.RaisePropertyChanged("address1_longitude");
			}
		}
		[XmlElement(Order = 13)]
		public string address1_name
		{
			get
			{
				return this.address1_nameField;
			}
			set
			{
				this.address1_nameField = value;
				base.RaisePropertyChanged("address1_name");
			}
		}
		[XmlElement(Order = 14)]
		public string address1_postalcode
		{
			get
			{
				return this.address1_postalcodeField;
			}
			set
			{
				this.address1_postalcodeField = value;
				base.RaisePropertyChanged("address1_postalcode");
			}
		}
		[XmlElement(Order = 15)]
		public string address1_postofficebox
		{
			get
			{
				return this.address1_postofficeboxField;
			}
			set
			{
				this.address1_postofficeboxField = value;
				base.RaisePropertyChanged("address1_postofficebox");
			}
		}
		[XmlElement(Order = 16)]
		public string address1_primarycontactname
		{
			get
			{
				return this.address1_primarycontactnameField;
			}
			set
			{
				this.address1_primarycontactnameField = value;
				base.RaisePropertyChanged("address1_primarycontactname");
			}
		}
		[XmlElement(Order = 17)]
		public Picklist address1_shippingmethodcode
		{
			get
			{
				return this.address1_shippingmethodcodeField;
			}
			set
			{
				this.address1_shippingmethodcodeField = value;
				base.RaisePropertyChanged("address1_shippingmethodcode");
			}
		}
		[XmlElement(Order = 18)]
		public string address1_stateorprovince
		{
			get
			{
				return this.address1_stateorprovinceField;
			}
			set
			{
				this.address1_stateorprovinceField = value;
				base.RaisePropertyChanged("address1_stateorprovince");
			}
		}
		[XmlElement(Order = 19)]
		public string address1_telephone1
		{
			get
			{
				return this.address1_telephone1Field;
			}
			set
			{
				this.address1_telephone1Field = value;
				base.RaisePropertyChanged("address1_telephone1");
			}
		}
		[XmlElement(Order = 20)]
		public string address1_telephone2
		{
			get
			{
				return this.address1_telephone2Field;
			}
			set
			{
				this.address1_telephone2Field = value;
				base.RaisePropertyChanged("address1_telephone2");
			}
		}
		[XmlElement(Order = 21)]
		public string address1_telephone3
		{
			get
			{
				return this.address1_telephone3Field;
			}
			set
			{
				this.address1_telephone3Field = value;
				base.RaisePropertyChanged("address1_telephone3");
			}
		}
		[XmlElement(Order = 22)]
		public string address1_upszone
		{
			get
			{
				return this.address1_upszoneField;
			}
			set
			{
				this.address1_upszoneField = value;
				base.RaisePropertyChanged("address1_upszone");
			}
		}
		[XmlElement(Order = 23)]
		public CrmNumber address1_utcoffset
		{
			get
			{
				return this.address1_utcoffsetField;
			}
			set
			{
				this.address1_utcoffsetField = value;
				base.RaisePropertyChanged("address1_utcoffset");
			}
		}
		[XmlElement(Order = 24)]
		public Key address2_addressid
		{
			get
			{
				return this.address2_addressidField;
			}
			set
			{
				this.address2_addressidField = value;
				base.RaisePropertyChanged("address2_addressid");
			}
		}
		[XmlElement(Order = 25)]
		public Picklist address2_addresstypecode
		{
			get
			{
				return this.address2_addresstypecodeField;
			}
			set
			{
				this.address2_addresstypecodeField = value;
				base.RaisePropertyChanged("address2_addresstypecode");
			}
		}
		[XmlElement(Order = 26)]
		public string address2_city
		{
			get
			{
				return this.address2_cityField;
			}
			set
			{
				this.address2_cityField = value;
				base.RaisePropertyChanged("address2_city");
			}
		}
		[XmlElement(Order = 27)]
		public string address2_country
		{
			get
			{
				return this.address2_countryField;
			}
			set
			{
				this.address2_countryField = value;
				base.RaisePropertyChanged("address2_country");
			}
		}
		[XmlElement(Order = 28)]
		public string address2_county
		{
			get
			{
				return this.address2_countyField;
			}
			set
			{
				this.address2_countyField = value;
				base.RaisePropertyChanged("address2_county");
			}
		}
		[XmlElement(Order = 29)]
		public string address2_fax
		{
			get
			{
				return this.address2_faxField;
			}
			set
			{
				this.address2_faxField = value;
				base.RaisePropertyChanged("address2_fax");
			}
		}
		[XmlElement(Order = 30)]
		public Picklist address2_freighttermscode
		{
			get
			{
				return this.address2_freighttermscodeField;
			}
			set
			{
				this.address2_freighttermscodeField = value;
				base.RaisePropertyChanged("address2_freighttermscode");
			}
		}
		[XmlElement(Order = 31)]
		public CrmFloat address2_latitude
		{
			get
			{
				return this.address2_latitudeField;
			}
			set
			{
				this.address2_latitudeField = value;
				base.RaisePropertyChanged("address2_latitude");
			}
		}
		[XmlElement(Order = 32)]
		public string address2_line1
		{
			get
			{
				return this.address2_line1Field;
			}
			set
			{
				this.address2_line1Field = value;
				base.RaisePropertyChanged("address2_line1");
			}
		}
		[XmlElement(Order = 33)]
		public string address2_line2
		{
			get
			{
				return this.address2_line2Field;
			}
			set
			{
				this.address2_line2Field = value;
				base.RaisePropertyChanged("address2_line2");
			}
		}
		[XmlElement(Order = 34)]
		public string address2_line3
		{
			get
			{
				return this.address2_line3Field;
			}
			set
			{
				this.address2_line3Field = value;
				base.RaisePropertyChanged("address2_line3");
			}
		}
		[XmlElement(Order = 35)]
		public CrmFloat address2_longitude
		{
			get
			{
				return this.address2_longitudeField;
			}
			set
			{
				this.address2_longitudeField = value;
				base.RaisePropertyChanged("address2_longitude");
			}
		}
		[XmlElement(Order = 36)]
		public string address2_name
		{
			get
			{
				return this.address2_nameField;
			}
			set
			{
				this.address2_nameField = value;
				base.RaisePropertyChanged("address2_name");
			}
		}
		[XmlElement(Order = 37)]
		public string address2_postalcode
		{
			get
			{
				return this.address2_postalcodeField;
			}
			set
			{
				this.address2_postalcodeField = value;
				base.RaisePropertyChanged("address2_postalcode");
			}
		}
		[XmlElement(Order = 38)]
		public string address2_postofficebox
		{
			get
			{
				return this.address2_postofficeboxField;
			}
			set
			{
				this.address2_postofficeboxField = value;
				base.RaisePropertyChanged("address2_postofficebox");
			}
		}
		[XmlElement(Order = 39)]
		public string address2_primarycontactname
		{
			get
			{
				return this.address2_primarycontactnameField;
			}
			set
			{
				this.address2_primarycontactnameField = value;
				base.RaisePropertyChanged("address2_primarycontactname");
			}
		}
		[XmlElement(Order = 40)]
		public Picklist address2_shippingmethodcode
		{
			get
			{
				return this.address2_shippingmethodcodeField;
			}
			set
			{
				this.address2_shippingmethodcodeField = value;
				base.RaisePropertyChanged("address2_shippingmethodcode");
			}
		}
		[XmlElement(Order = 41)]
		public string address2_stateorprovince
		{
			get
			{
				return this.address2_stateorprovinceField;
			}
			set
			{
				this.address2_stateorprovinceField = value;
				base.RaisePropertyChanged("address2_stateorprovince");
			}
		}
		[XmlElement(Order = 42)]
		public string address2_telephone1
		{
			get
			{
				return this.address2_telephone1Field;
			}
			set
			{
				this.address2_telephone1Field = value;
				base.RaisePropertyChanged("address2_telephone1");
			}
		}
		[XmlElement(Order = 43)]
		public string address2_telephone2
		{
			get
			{
				return this.address2_telephone2Field;
			}
			set
			{
				this.address2_telephone2Field = value;
				base.RaisePropertyChanged("address2_telephone2");
			}
		}
		[XmlElement(Order = 44)]
		public string address2_telephone3
		{
			get
			{
				return this.address2_telephone3Field;
			}
			set
			{
				this.address2_telephone3Field = value;
				base.RaisePropertyChanged("address2_telephone3");
			}
		}
		[XmlElement(Order = 45)]
		public string address2_upszone
		{
			get
			{
				return this.address2_upszoneField;
			}
			set
			{
				this.address2_upszoneField = value;
				base.RaisePropertyChanged("address2_upszone");
			}
		}
		[XmlElement(Order = 46)]
		public CrmNumber address2_utcoffset
		{
			get
			{
				return this.address2_utcoffsetField;
			}
			set
			{
				this.address2_utcoffsetField = value;
				base.RaisePropertyChanged("address2_utcoffset");
			}
		}
		[XmlElement(Order = 47)]
		public CrmMoney aging30
		{
			get
			{
				return this.aging30Field;
			}
			set
			{
				this.aging30Field = value;
				base.RaisePropertyChanged("aging30");
			}
		}
		[XmlElement(Order = 48)]
		public CrmMoney aging30_base
		{
			get
			{
				return this.aging30_baseField;
			}
			set
			{
				this.aging30_baseField = value;
				base.RaisePropertyChanged("aging30_base");
			}
		}
		[XmlElement(Order = 49)]
		public CrmMoney aging60
		{
			get
			{
				return this.aging60Field;
			}
			set
			{
				this.aging60Field = value;
				base.RaisePropertyChanged("aging60");
			}
		}
		[XmlElement(Order = 50)]
		public CrmMoney aging60_base
		{
			get
			{
				return this.aging60_baseField;
			}
			set
			{
				this.aging60_baseField = value;
				base.RaisePropertyChanged("aging60_base");
			}
		}
		[XmlElement(Order = 51)]
		public CrmMoney aging90
		{
			get
			{
				return this.aging90Field;
			}
			set
			{
				this.aging90Field = value;
				base.RaisePropertyChanged("aging90");
			}
		}
		[XmlElement(Order = 52)]
		public CrmMoney aging90_base
		{
			get
			{
				return this.aging90_baseField;
			}
			set
			{
				this.aging90_baseField = value;
				base.RaisePropertyChanged("aging90_base");
			}
		}
		[XmlElement(Order = 53)]
		public CrmDateTime anniversary
		{
			get
			{
				return this.anniversaryField;
			}
			set
			{
				this.anniversaryField = value;
				base.RaisePropertyChanged("anniversary");
			}
		}
		[XmlElement(Order = 54)]
		public CrmMoney annualincome
		{
			get
			{
				return this.annualincomeField;
			}
			set
			{
				this.annualincomeField = value;
				base.RaisePropertyChanged("annualincome");
			}
		}
		[XmlElement(Order = 55)]
		public CrmMoney annualincome_base
		{
			get
			{
				return this.annualincome_baseField;
			}
			set
			{
				this.annualincome_baseField = value;
				base.RaisePropertyChanged("annualincome_base");
			}
		}
		[XmlElement(Order = 56)]
		public string assistantname
		{
			get
			{
				return this.assistantnameField;
			}
			set
			{
				this.assistantnameField = value;
				base.RaisePropertyChanged("assistantname");
			}
		}
		[XmlElement(Order = 57)]
		public string assistantphone
		{
			get
			{
				return this.assistantphoneField;
			}
			set
			{
				this.assistantphoneField = value;
				base.RaisePropertyChanged("assistantphone");
			}
		}
		[XmlElement(Order = 58)]
		public CrmDateTime birthdate
		{
			get
			{
				return this.birthdateField;
			}
			set
			{
				this.birthdateField = value;
				base.RaisePropertyChanged("birthdate");
			}
		}
		[XmlElement(Order = 59)]
		public string childrensnames
		{
			get
			{
				return this.childrensnamesField;
			}
			set
			{
				this.childrensnamesField = value;
				base.RaisePropertyChanged("childrensnames");
			}
		}
		[XmlElement(Order = 60)]
		public Key contactid
		{
			get
			{
				return this.contactidField;
			}
			set
			{
				this.contactidField = value;
				base.RaisePropertyChanged("contactid");
			}
		}
		[XmlElement(Order = 61)]
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
		[XmlElement(Order = 62)]
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
		[XmlElement(Order = 63)]
		public CrmMoney creditlimit
		{
			get
			{
				return this.creditlimitField;
			}
			set
			{
				this.creditlimitField = value;
				base.RaisePropertyChanged("creditlimit");
			}
		}
		[XmlElement(Order = 64)]
		public CrmMoney creditlimit_base
		{
			get
			{
				return this.creditlimit_baseField;
			}
			set
			{
				this.creditlimit_baseField = value;
				base.RaisePropertyChanged("creditlimit_base");
			}
		}
		[XmlElement(Order = 65)]
		public CrmBoolean creditonhold
		{
			get
			{
				return this.creditonholdField;
			}
			set
			{
				this.creditonholdField = value;
				base.RaisePropertyChanged("creditonhold");
			}
		}
		[XmlElement(Order = 66)]
		public Picklist customersizecode
		{
			get
			{
				return this.customersizecodeField;
			}
			set
			{
				this.customersizecodeField = value;
				base.RaisePropertyChanged("customersizecode");
			}
		}
		[XmlElement(Order = 67)]
		public Picklist customertypecode
		{
			get
			{
				return this.customertypecodeField;
			}
			set
			{
				this.customertypecodeField = value;
				base.RaisePropertyChanged("customertypecode");
			}
		}
		[XmlElement(Order = 68)]
		public Lookup defaultpricelevelid
		{
			get
			{
				return this.defaultpricelevelidField;
			}
			set
			{
				this.defaultpricelevelidField = value;
				base.RaisePropertyChanged("defaultpricelevelid");
			}
		}
		[XmlElement(Order = 69)]
		public string department
		{
			get
			{
				return this.departmentField;
			}
			set
			{
				this.departmentField = value;
				base.RaisePropertyChanged("department");
			}
		}
		[XmlElement(Order = 70)]
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
		[XmlElement(Order = 71)]
		public CrmBoolean donotbulkemail
		{
			get
			{
				return this.donotbulkemailField;
			}
			set
			{
				this.donotbulkemailField = value;
				base.RaisePropertyChanged("donotbulkemail");
			}
		}
		[XmlElement(Order = 72)]
		public CrmBoolean donotbulkpostalmail
		{
			get
			{
				return this.donotbulkpostalmailField;
			}
			set
			{
				this.donotbulkpostalmailField = value;
				base.RaisePropertyChanged("donotbulkpostalmail");
			}
		}
		[XmlElement(Order = 73)]
		public CrmBoolean donotemail
		{
			get
			{
				return this.donotemailField;
			}
			set
			{
				this.donotemailField = value;
				base.RaisePropertyChanged("donotemail");
			}
		}
		[XmlElement(Order = 74)]
		public CrmBoolean donotfax
		{
			get
			{
				return this.donotfaxField;
			}
			set
			{
				this.donotfaxField = value;
				base.RaisePropertyChanged("donotfax");
			}
		}
		[XmlElement(Order = 75)]
		public CrmBoolean donotphone
		{
			get
			{
				return this.donotphoneField;
			}
			set
			{
				this.donotphoneField = value;
				base.RaisePropertyChanged("donotphone");
			}
		}
		[XmlElement(Order = 76)]
		public CrmBoolean donotpostalmail
		{
			get
			{
				return this.donotpostalmailField;
			}
			set
			{
				this.donotpostalmailField = value;
				base.RaisePropertyChanged("donotpostalmail");
			}
		}
		[XmlElement(Order = 77)]
		public CrmBoolean donotsendmm
		{
			get
			{
				return this.donotsendmmField;
			}
			set
			{
				this.donotsendmmField = value;
				base.RaisePropertyChanged("donotsendmm");
			}
		}
		[XmlElement(Order = 78)]
		public Picklist educationcode
		{
			get
			{
				return this.educationcodeField;
			}
			set
			{
				this.educationcodeField = value;
				base.RaisePropertyChanged("educationcode");
			}
		}
		[XmlElement(Order = 79)]
		public string emailaddress1
		{
			get
			{
				return this.emailaddress1Field;
			}
			set
			{
				this.emailaddress1Field = value;
				base.RaisePropertyChanged("emailaddress1");
			}
		}
		[XmlElement(Order = 80)]
		public string emailaddress2
		{
			get
			{
				return this.emailaddress2Field;
			}
			set
			{
				this.emailaddress2Field = value;
				base.RaisePropertyChanged("emailaddress2");
			}
		}
		[XmlElement(Order = 81)]
		public string emailaddress3
		{
			get
			{
				return this.emailaddress3Field;
			}
			set
			{
				this.emailaddress3Field = value;
				base.RaisePropertyChanged("emailaddress3");
			}
		}
		[XmlElement(Order = 82)]
		public string employeeid
		{
			get
			{
				return this.employeeidField;
			}
			set
			{
				this.employeeidField = value;
				base.RaisePropertyChanged("employeeid");
			}
		}
		[XmlElement(Order = 83)]
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
		[XmlElement(Order = 84)]
		public string externaluseridentifier
		{
			get
			{
				return this.externaluseridentifierField;
			}
			set
			{
				this.externaluseridentifierField = value;
				base.RaisePropertyChanged("externaluseridentifier");
			}
		}
		[XmlElement(Order = 85)]
		public Picklist familystatuscode
		{
			get
			{
				return this.familystatuscodeField;
			}
			set
			{
				this.familystatuscodeField = value;
				base.RaisePropertyChanged("familystatuscode");
			}
		}
		[XmlElement(Order = 86)]
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
				base.RaisePropertyChanged("fax");
			}
		}
		[XmlElement(Order = 87)]
		public string firstname
		{
			get
			{
				return this.firstnameField;
			}
			set
			{
				this.firstnameField = value;
				base.RaisePropertyChanged("firstname");
			}
		}
		[XmlElement(Order = 88)]
		public string ftpsiteurl
		{
			get
			{
				return this.ftpsiteurlField;
			}
			set
			{
				this.ftpsiteurlField = value;
				base.RaisePropertyChanged("ftpsiteurl");
			}
		}
		[XmlElement(Order = 89)]
		public string fullname
		{
			get
			{
				return this.fullnameField;
			}
			set
			{
				this.fullnameField = value;
				base.RaisePropertyChanged("fullname");
			}
		}
		[XmlElement(Order = 90)]
		public Picklist gendercode
		{
			get
			{
				return this.gendercodeField;
			}
			set
			{
				this.gendercodeField = value;
				base.RaisePropertyChanged("gendercode");
			}
		}
		[XmlElement(Order = 91)]
		public string governmentid
		{
			get
			{
				return this.governmentidField;
			}
			set
			{
				this.governmentidField = value;
				base.RaisePropertyChanged("governmentid");
			}
		}
		[XmlElement(Order = 92)]
		public Picklist haschildrencode
		{
			get
			{
				return this.haschildrencodeField;
			}
			set
			{
				this.haschildrencodeField = value;
				base.RaisePropertyChanged("haschildrencode");
			}
		}
		[XmlElement(Order = 93)]
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
		[XmlElement(Order = 94)]
		public CrmBoolean isbackofficecustomer
		{
			get
			{
				return this.isbackofficecustomerField;
			}
			set
			{
				this.isbackofficecustomerField = value;
				base.RaisePropertyChanged("isbackofficecustomer");
			}
		}
		[XmlElement(Order = 95)]
		public string jobtitle
		{
			get
			{
				return this.jobtitleField;
			}
			set
			{
				this.jobtitleField = value;
				base.RaisePropertyChanged("jobtitle");
			}
		}
		[XmlElement(Order = 96)]
		public string lastname
		{
			get
			{
				return this.lastnameField;
			}
			set
			{
				this.lastnameField = value;
				base.RaisePropertyChanged("lastname");
			}
		}
		[XmlElement(Order = 97)]
		public CrmDateTime lastusedincampaign
		{
			get
			{
				return this.lastusedincampaignField;
			}
			set
			{
				this.lastusedincampaignField = value;
				base.RaisePropertyChanged("lastusedincampaign");
			}
		}
		[XmlElement(Order = 98)]
		public Picklist leadsourcecode
		{
			get
			{
				return this.leadsourcecodeField;
			}
			set
			{
				this.leadsourcecodeField = value;
				base.RaisePropertyChanged("leadsourcecode");
			}
		}
		[XmlElement(Order = 99)]
		public string managername
		{
			get
			{
				return this.managernameField;
			}
			set
			{
				this.managernameField = value;
				base.RaisePropertyChanged("managername");
			}
		}
		[XmlElement(Order = 100)]
		public string managerphone
		{
			get
			{
				return this.managerphoneField;
			}
			set
			{
				this.managerphoneField = value;
				base.RaisePropertyChanged("managerphone");
			}
		}
		[XmlElement(Order = 101)]
		public Lookup masterid
		{
			get
			{
				return this.masteridField;
			}
			set
			{
				this.masteridField = value;
				base.RaisePropertyChanged("masterid");
			}
		}
		[XmlElement(Order = 102)]
		public CrmBoolean merged
		{
			get
			{
				return this.mergedField;
			}
			set
			{
				this.mergedField = value;
				base.RaisePropertyChanged("merged");
			}
		}
		[XmlElement(Order = 103)]
		public string middlename
		{
			get
			{
				return this.middlenameField;
			}
			set
			{
				this.middlenameField = value;
				base.RaisePropertyChanged("middlename");
			}
		}
		[XmlElement(Order = 104)]
		public string mobilephone
		{
			get
			{
				return this.mobilephoneField;
			}
			set
			{
				this.mobilephoneField = value;
				base.RaisePropertyChanged("mobilephone");
			}
		}
		[XmlElement(Order = 105)]
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
		[XmlElement(Order = 106)]
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
		[XmlElement(Order = 107)]
		public string nickname
		{
			get
			{
				return this.nicknameField;
			}
			set
			{
				this.nicknameField = value;
				base.RaisePropertyChanged("nickname");
			}
		}
		[XmlElement(Order = 108)]
		public CrmNumber numberofchildren
		{
			get
			{
				return this.numberofchildrenField;
			}
			set
			{
				this.numberofchildrenField = value;
				base.RaisePropertyChanged("numberofchildren");
			}
		}
		[XmlElement(Order = 109)]
		public Lookup originatingleadid
		{
			get
			{
				return this.originatingleadidField;
			}
			set
			{
				this.originatingleadidField = value;
				base.RaisePropertyChanged("originatingleadid");
			}
		}
		[XmlElement(Order = 110)]
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
		[XmlElement(Order = 111)]
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
		[XmlElement(Order = 112)]
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
		[XmlElement(Order = 113)]
		public string pager
		{
			get
			{
				return this.pagerField;
			}
			set
			{
				this.pagerField = value;
				base.RaisePropertyChanged("pager");
			}
		}
		[XmlElement(Order = 114)]
		public Customer parentcustomerid
		{
			get
			{
				return this.parentcustomeridField;
			}
			set
			{
				this.parentcustomeridField = value;
				base.RaisePropertyChanged("parentcustomerid");
			}
		}
		[XmlElement(Order = 115)]
		public CrmBoolean participatesinworkflow
		{
			get
			{
				return this.participatesinworkflowField;
			}
			set
			{
				this.participatesinworkflowField = value;
				base.RaisePropertyChanged("participatesinworkflow");
			}
		}
		[XmlElement(Order = 116)]
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
		[XmlElement(Order = 117)]
		public Picklist preferredappointmentdaycode
		{
			get
			{
				return this.preferredappointmentdaycodeField;
			}
			set
			{
				this.preferredappointmentdaycodeField = value;
				base.RaisePropertyChanged("preferredappointmentdaycode");
			}
		}
		[XmlElement(Order = 118)]
		public Picklist preferredappointmenttimecode
		{
			get
			{
				return this.preferredappointmenttimecodeField;
			}
			set
			{
				this.preferredappointmenttimecodeField = value;
				base.RaisePropertyChanged("preferredappointmenttimecode");
			}
		}
		[XmlElement(Order = 119)]
		public Picklist preferredcontactmethodcode
		{
			get
			{
				return this.preferredcontactmethodcodeField;
			}
			set
			{
				this.preferredcontactmethodcodeField = value;
				base.RaisePropertyChanged("preferredcontactmethodcode");
			}
		}
		[XmlElement(Order = 120)]
		public Lookup preferredequipmentid
		{
			get
			{
				return this.preferredequipmentidField;
			}
			set
			{
				this.preferredequipmentidField = value;
				base.RaisePropertyChanged("preferredequipmentid");
			}
		}
		[XmlElement(Order = 121)]
		public Lookup preferredserviceid
		{
			get
			{
				return this.preferredserviceidField;
			}
			set
			{
				this.preferredserviceidField = value;
				base.RaisePropertyChanged("preferredserviceid");
			}
		}
		[XmlElement(Order = 122)]
		public Lookup preferredsystemuserid
		{
			get
			{
				return this.preferredsystemuseridField;
			}
			set
			{
				this.preferredsystemuseridField = value;
				base.RaisePropertyChanged("preferredsystemuserid");
			}
		}
		[XmlElement(Order = 123)]
		public string salutation
		{
			get
			{
				return this.salutationField;
			}
			set
			{
				this.salutationField = value;
				base.RaisePropertyChanged("salutation");
			}
		}
		[XmlElement(Order = 124)]
		public Lookup sgt_2e_nationaliteitid
		{
			get
			{
				return this.sgt_2e_nationaliteitidField;
			}
			set
			{
				this.sgt_2e_nationaliteitidField = value;
				base.RaisePropertyChanged("sgt_2e_nationaliteitid");
			}
		}
		[XmlElement(Order = 125)]
		public string sgt_aanhef_briefhoofd_nl
		{
			get
			{
				return this.sgt_aanhef_briefhoofd_nlField;
			}
			set
			{
				this.sgt_aanhef_briefhoofd_nlField = value;
				base.RaisePropertyChanged("sgt_aanhef_briefhoofd_nl");
			}
		}
		[XmlElement(Order = 126)]
		public string sgt_aanhef_tav_nl
		{
			get
			{
				return this.sgt_aanhef_tav_nlField;
			}
			set
			{
				this.sgt_aanhef_tav_nlField = value;
				base.RaisePropertyChanged("sgt_aanhef_tav_nl");
			}
		}
		[XmlElement(Order = 127)]
		public CrmBoolean sgt_adres_geheim
		{
			get
			{
				return this.sgt_adres_geheimField;
			}
			set
			{
				this.sgt_adres_geheimField = value;
				base.RaisePropertyChanged("sgt_adres_geheim");
			}
		}
		[XmlElement(Order = 128)]
		public CrmDateTime sgt_afas_exportdatum
		{
			get
			{
				return this.sgt_afas_exportdatumField;
			}
			set
			{
				this.sgt_afas_exportdatumField = value;
				base.RaisePropertyChanged("sgt_afas_exportdatum");
			}
		}
		[XmlElement(Order = 129)]
		public Picklist sgt_afas_exportstatus
		{
			get
			{
				return this.sgt_afas_exportstatusField;
			}
			set
			{
				this.sgt_afas_exportstatusField = value;
				base.RaisePropertyChanged("sgt_afas_exportstatus");
			}
		}
		[XmlElement(Order = 130)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}
		[XmlElement(Order = 131)]
		public CrmDateTime sgt_datum_foto_upload
		{
			get
			{
				return this.sgt_datum_foto_uploadField;
			}
			set
			{
				this.sgt_datum_foto_uploadField = value;
				base.RaisePropertyChanged("sgt_datum_foto_upload");
			}
		}
		[XmlElement(Order = 132)]
		public CrmDateTime sgt_datum_overleden
		{
			get
			{
				return this.sgt_datum_overledenField;
			}
			set
			{
				this.sgt_datum_overledenField = value;
				base.RaisePropertyChanged("sgt_datum_overleden");
			}
		}
		[XmlElement(Order = 133)]
		public CrmDateTime sgt_dcp_data_gewijzigd_op
		{
			get
			{
				return this.sgt_dcp_data_gewijzigd_opField;
			}
			set
			{
				this.sgt_dcp_data_gewijzigd_opField = value;
				base.RaisePropertyChanged("sgt_dcp_data_gewijzigd_op");
			}
		}
		[XmlElement(Order = 134)]
		public CrmDateTime sgt_dcp_foto_gewijzigd_op
		{
			get
			{
				return this.sgt_dcp_foto_gewijzigd_opField;
			}
			set
			{
				this.sgt_dcp_foto_gewijzigd_opField = value;
				base.RaisePropertyChanged("sgt_dcp_foto_gewijzigd_op");
			}
		}
		[XmlElement(Order = 135)]
		public string sgt_debiteurnummer
		{
			get
			{
				return this.sgt_debiteurnummerField;
			}
			set
			{
				this.sgt_debiteurnummerField = value;
				base.RaisePropertyChanged("sgt_debiteurnummer");
			}
		}
		[XmlElement(Order = 136)]
		public string sgt_fotonummer
		{
			get
			{
				return this.sgt_fotonummerField;
			}
			set
			{
				this.sgt_fotonummerField = value;
				base.RaisePropertyChanged("sgt_fotonummer");
			}
		}
		[XmlElement(Order = 137)]
		public string sgt_geboorteplaats
		{
			get
			{
				return this.sgt_geboorteplaatsField;
			}
			set
			{
				this.sgt_geboorteplaatsField = value;
				base.RaisePropertyChanged("sgt_geboorteplaats");
			}
		}
		[XmlElement(Order = 138)]
		public string sgt_iban_code
		{
			get
			{
				return this.sgt_iban_codeField;
			}
			set
			{
				this.sgt_iban_codeField = value;
				base.RaisePropertyChanged("sgt_iban_code");
			}
		}
		[XmlElement(Order = 139)]
		public CrmBoolean sgt_is_functionaris
		{
			get
			{
				return this.sgt_is_functionarisField;
			}
			set
			{
				this.sgt_is_functionarisField = value;
				base.RaisePropertyChanged("sgt_is_functionaris");
			}
		}
		[XmlElement(Order = 140)]
		public CrmBoolean sgt_is_lid
		{
			get
			{
				return this.sgt_is_lidField;
			}
			set
			{
				this.sgt_is_lidField = value;
				base.RaisePropertyChanged("sgt_is_lid");
			}
		}
		[XmlElement(Order = 141)]
		public Picklist sgt_junior_senior
		{
			get
			{
				return this.sgt_junior_seniorField;
			}
			set
			{
				this.sgt_junior_seniorField = value;
				base.RaisePropertyChanged("sgt_junior_senior");
			}
		}
		[XmlElement(Order = 142)]
		public Lookup sgt_landcode_postadresid
		{
			get
			{
				return this.sgt_landcode_postadresidField;
			}
			set
			{
				this.sgt_landcode_postadresidField = value;
				base.RaisePropertyChanged("sgt_landcode_postadresid");
			}
		}
		[XmlElement(Order = 143)]
		public Lookup sgt_landcode_woonadresid
		{
			get
			{
				return this.sgt_landcode_woonadresidField;
			}
			set
			{
				this.sgt_landcode_woonadresidField = value;
				base.RaisePropertyChanged("sgt_landcode_woonadresid");
			}
		}
		[XmlElement(Order = 144)]
		public Lookup sgt_logboek_facturatie_exp_debiteurid
		{
			get
			{
				return this.sgt_logboek_facturatie_exp_debiteuridField;
			}
			set
			{
				this.sgt_logboek_facturatie_exp_debiteuridField = value;
				base.RaisePropertyChanged("sgt_logboek_facturatie_exp_debiteurid");
			}
		}
		[XmlElement(Order = 145)]
		public CrmBoolean sgt_meerling
		{
			get
			{
				return this.sgt_meerlingField;
			}
			set
			{
				this.sgt_meerlingField = value;
				base.RaisePropertyChanged("sgt_meerling");
			}
		}
		[XmlElement(Order = 146)]
		public Lookup sgt_nationaliteitid
		{
			get
			{
				return this.sgt_nationaliteitidField;
			}
			set
			{
				this.sgt_nationaliteitidField = value;
				base.RaisePropertyChanged("sgt_nationaliteitid");
			}
		}
		[XmlElement(Order = 147)]
		public CrmBoolean sgt_openstaande_boetes
		{
			get
			{
				return this.sgt_openstaande_boetesField;
			}
			set
			{
				this.sgt_openstaande_boetesField = value;
				base.RaisePropertyChanged("sgt_openstaande_boetes");
			}
		}
		[XmlElement(Order = 148)]
		public Lookup sgt_pb_mutatie_ledenid
		{
			get
			{
				return this.sgt_pb_mutatie_ledenidField;
			}
			set
			{
				this.sgt_pb_mutatie_ledenidField = value;
				base.RaisePropertyChanged("sgt_pb_mutatie_ledenid");
			}
		}
		[XmlElement(Order = 149)]
		public Lookup sgt_primaire_vereniging_id
		{
			get
			{
				return this.sgt_primaire_vereniging_idField;
			}
			set
			{
				this.sgt_primaire_vereniging_idField = value;
				base.RaisePropertyChanged("sgt_primaire_vereniging_id");
			}
		}
		[XmlElement(Order = 150)]
		public CrmDecimal sgt_rating_dubbel
		{
			get
			{
				return this.sgt_rating_dubbelField;
			}
			set
			{
				this.sgt_rating_dubbelField = value;
				base.RaisePropertyChanged("sgt_rating_dubbel");
			}
		}
		[XmlElement(Order = 151)]
		public CrmDecimal sgt_rating_enkel
		{
			get
			{
				return this.sgt_rating_enkelField;
			}
			set
			{
				this.sgt_rating_enkelField = value;
				base.RaisePropertyChanged("sgt_rating_enkel");
			}
		}
		[XmlElement(Order = 152)]
		public string sgt_rekeningnummer
		{
			get
			{
				return this.sgt_rekeningnummerField;
			}
			set
			{
				this.sgt_rekeningnummerField = value;
				base.RaisePropertyChanged("sgt_rekeningnummer");
			}
		}
		[XmlElement(Order = 153)]
		public string sgt_rekeningnummer_plaats
		{
			get
			{
				return this.sgt_rekeningnummer_plaatsField;
			}
			set
			{
				this.sgt_rekeningnummer_plaatsField = value;
				base.RaisePropertyChanged("sgt_rekeningnummer_plaats");
			}
		}
		[XmlElement(Order = 154)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}
		[XmlElement(Order = 155)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}
		[XmlElement(Order = 156)]
		public CrmBoolean sgt_telefoon_geheim
		{
			get
			{
				return this.sgt_telefoon_geheimField;
			}
			set
			{
				this.sgt_telefoon_geheimField = value;
				base.RaisePropertyChanged("sgt_telefoon_geheim");
			}
		}
		[XmlElement(Order = 157)]
		public Lookup sgt_tennisnationaliteitid
		{
			get
			{
				return this.sgt_tennisnationaliteitidField;
			}
			set
			{
				this.sgt_tennisnationaliteitidField = value;
				base.RaisePropertyChanged("sgt_tennisnationaliteitid");
			}
		}
		[XmlElement(Order = 158)]
		public string sgt_voornamen
		{
			get
			{
				return this.sgt_voornamenField;
			}
			set
			{
				this.sgt_voornamenField = value;
				base.RaisePropertyChanged("sgt_voornamen");
			}
		}
		[XmlElement(Order = 159)]
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
		[XmlElement(Order = 160)]
		public string spousesname
		{
			get
			{
				return this.spousesnameField;
			}
			set
			{
				this.spousesnameField = value;
				base.RaisePropertyChanged("spousesname");
			}
		}
		[XmlElement(Order = 161)]
		public ContactStateInfo statecode
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
		[XmlElement(Order = 162)]
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
		[XmlElement(Order = 163)]
		public UniqueIdentifier subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
				base.RaisePropertyChanged("subscriptionid");
			}
		}
		[XmlElement(Order = 164)]
		public string suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
				base.RaisePropertyChanged("suffix");
			}
		}
		[XmlElement(Order = 165)]
		public string telephone1
		{
			get
			{
				return this.telephone1Field;
			}
			set
			{
				this.telephone1Field = value;
				base.RaisePropertyChanged("telephone1");
			}
		}
		[XmlElement(Order = 166)]
		public string telephone2
		{
			get
			{
				return this.telephone2Field;
			}
			set
			{
				this.telephone2Field = value;
				base.RaisePropertyChanged("telephone2");
			}
		}
		[XmlElement(Order = 167)]
		public string telephone3
		{
			get
			{
				return this.telephone3Field;
			}
			set
			{
				this.telephone3Field = value;
				base.RaisePropertyChanged("telephone3");
			}
		}
		[XmlElement(Order = 168)]
		public Picklist territorycode
		{
			get
			{
				return this.territorycodeField;
			}
			set
			{
				this.territorycodeField = value;
				base.RaisePropertyChanged("territorycode");
			}
		}
		[XmlElement(Order = 169)]
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
		[XmlElement(Order = 170)]
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
		[XmlElement(Order = 171)]
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
		[XmlElement(Order = 172)]
		public string websiteurl
		{
			get
			{
				return this.websiteurlField;
			}
			set
			{
				this.websiteurlField = value;
				base.RaisePropertyChanged("websiteurl");
			}
		}
		[XmlElement(Order = 173)]
		public string yomifirstname
		{
			get
			{
				return this.yomifirstnameField;
			}
			set
			{
				this.yomifirstnameField = value;
				base.RaisePropertyChanged("yomifirstname");
			}
		}
		[XmlElement(Order = 174)]
		public string yomifullname
		{
			get
			{
				return this.yomifullnameField;
			}
			set
			{
				this.yomifullnameField = value;
				base.RaisePropertyChanged("yomifullname");
			}
		}
		[XmlElement(Order = 175)]
		public string yomilastname
		{
			get
			{
				return this.yomilastnameField;
			}
			set
			{
				this.yomilastnameField = value;
				base.RaisePropertyChanged("yomilastname");
			}
		}
		[XmlElement(Order = 176)]
		public string yomimiddlename
		{
			get
			{
				return this.yomimiddlenameField;
			}
			set
			{
				this.yomimiddlenameField = value;
				base.RaisePropertyChanged("yomimiddlename");
			}
		}
	}
}
