using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class account : BusinessEntity
	{
		private Picklist accountcategorycodeField;
		private Picklist accountclassificationcodeField;
		private Key accountidField;
		private string accountnumberField;
		private Picklist accountratingcodeField;
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
		private Picklist businesstypecodeField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmMoney creditlimitField;
		private CrmMoney creditlimit_baseField;
		private CrmBoolean creditonholdField;
		private Picklist customersizecodeField;
		private Picklist customertypecodeField;
		private Lookup defaultpricelevelidField;
		private string descriptionField;
		private CrmBoolean donotbulkemailField;
		private CrmBoolean donotbulkpostalmailField;
		private CrmBoolean donotemailField;
		private CrmBoolean donotfaxField;
		private CrmBoolean donotphoneField;
		private CrmBoolean donotpostalmailField;
		private CrmBoolean donotsendmmField;
		private string emailaddress1Field;
		private string emailaddress2Field;
		private string emailaddress3Field;
		private CrmDecimal exchangerateField;
		private string faxField;
		private string ftpsiteurlField;
		private CrmNumber importsequencenumberField;
		private Picklist industrycodeField;
		private CrmDateTime lastusedincampaignField;
		private CrmMoney marketcapField;
		private CrmMoney marketcap_baseField;
		private Lookup masteridField;
		private CrmBoolean mergedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private CrmNumber numberofemployeesField;
		private Lookup originatingleadidField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Picklist ownershipcodeField;
		private Lookup owningbusinessunitField;
		private Lookup parentaccountidField;
		private CrmBoolean participatesinworkflowField;
		private Picklist paymenttermscodeField;
		private Picklist preferredappointmentdaycodeField;
		private Picklist preferredappointmenttimecodeField;
		private Picklist preferredcontactmethodcodeField;
		private Lookup preferredequipmentidField;
		private Lookup preferredserviceidField;
		private Lookup preferredsystemuseridField;
		private Lookup primarycontactidField;
		private CrmMoney revenueField;
		private CrmMoney revenue_baseField;
		private CrmNumber sgt_aantal_dagen_amusementsmuziekField;
		private CrmNumber sgt_aantal_leden_damesField;
		private CrmNumber sgt_aantal_leden_herenField;
		private CrmNumber sgt_aantal_leden_jongensField;
		private CrmNumber sgt_aantal_leden_meisjesField;
		private Picklist sgt_aantal_maanden_geopendField;
		private CrmDateTime sgt_afas_exportdatumField;
		private Picklist sgt_afas_exportstatusField;
		private Lookup sgt_ba_landcodeidField;
		private Lookup sgt_betalingsvoorwaardeidField;
		private CrmBoolean sgt_bondField;
		private CrmNumber sgt_buma_aantal_m2Field;
		private string sgt_buma_achtergrondmuziekField;
		private Picklist sgt_buma_soortField;
		private CrmBoolean sgt_centre_courtField;
		private string sgt_crediteurnummerField;
		private CrmDateTime sgt_datum_afmeldingField;
		private CrmDateTime sgt_datum_fusieField;
		private CrmDateTime sgt_datum_oprichtingField;
		private CrmDateTime sgt_datumer_kenningField;
		private string sgt_debiteurnummerField;
		private Lookup sgt_districtidField;
		private CrmBoolean sgt_export_importField;
		private CrmBoolean sgt_gemeenteField;
		private Lookup sgt_hoofdaccomodatieidField;
		private string sgt_iban_codeField;
		private CrmBoolean sgt_klantField;
		private string sgt_kvk_nummerField;
		private Lookup sgt_kvkbrancheidField;
		private Lookup sgt_kvkplaatsidField;
		private CrmBoolean sgt_leverancierField;
		private Lookup sgt_leveringsconditieidField;
		private Lookup sgt_logboek_facturatie_exp_debiteuridField;
		private CrmBoolean sgt_mediaField;
		private Picklist sgt_naam_op_pasField;
		private CrmDateTime sgt_occ_lastupdateField;
		private string sgt_occ_timestampField;
		private CrmBoolean sgt_opnieuw_bepalen_ledenaantallenField;
		private Lookup sgt_pa_landcodeidField;
		private CrmBoolean sgt_partnerField;
		private string sgt_pasnaamField;
		private string sgt_ploegnaamField;
		private Lookup sgt_postbus_interface_idField;
		private Lookup sgt_rechtsvormidField;
		private CrmBoolean sgt_regioField;
		private string sgt_rekeningnummerField;
		private string sgt_rekeningnummer_plaatsField;
		private CrmBoolean sgt_senaField;
		private Lookup sgt_soort_apparatuuridField;
		private Picklist sgt_sortering_ledenpassenField;
		private CrmBoolean sgt_sponsorField;
		private Picklist sgt_status_sponsorField;
		private Picklist sgt_tegenprestatie_sponsorField;
		private CrmBoolean sgt_tennis_magazineField;
		private CrmBoolean sgt_tennisschoolField;
		private CrmBoolean sgt_toernooimutaties_via_postbusField;
		private CrmBoolean sgt_toernooiorganisatieField;
		private Picklist sgt_type_sponsorField;
		private CrmBoolean sgt_verenigingField;
		private Lookup sgt_verzendwijzeidField;
		private CrmBoolean sgt_wedstrijdcomiteField;
		private CrmNumber sharesoutstandingField;
		private Picklist shippingmethodcodeField;
		private string sicField;
		private AccountStateInfo statecodeField;
		private Status statuscodeField;
		private string stockexchangeField;
		private string telephone1Field;
		private string telephone2Field;
		private string telephone3Field;
		private Picklist territorycodeField;
		private Lookup territoryidField;
		private string tickersymbolField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		private string websiteurlField;
		private string yominameField;
		public Picklist accountcategorycode
		{
			get
			{
				return this.accountcategorycodeField;
			}
			set
			{
				this.accountcategorycodeField = value;
			}
		}
		public Picklist accountclassificationcode
		{
			get
			{
				return this.accountclassificationcodeField;
			}
			set
			{
				this.accountclassificationcodeField = value;
			}
		}
		public Key accountid
		{
			get
			{
				return this.accountidField;
			}
			set
			{
				this.accountidField = value;
			}
		}
		public string accountnumber
		{
			get
			{
				return this.accountnumberField;
			}
			set
			{
				this.accountnumberField = value;
			}
		}
		public Picklist accountratingcode
		{
			get
			{
				return this.accountratingcodeField;
			}
			set
			{
				this.accountratingcodeField = value;
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
		public Picklist businesstypecode
		{
			get
			{
				return this.businesstypecodeField;
			}
			set
			{
				this.businesstypecodeField = value;
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
		public CrmMoney marketcap
		{
			get
			{
				return this.marketcapField;
			}
			set
			{
				this.marketcapField = value;
			}
		}
		public CrmMoney marketcap_base
		{
			get
			{
				return this.marketcap_baseField;
			}
			set
			{
				this.marketcap_baseField = value;
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
		public Picklist ownershipcode
		{
			get
			{
				return this.ownershipcodeField;
			}
			set
			{
				this.ownershipcodeField = value;
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
		public Lookup parentaccountid
		{
			get
			{
				return this.parentaccountidField;
			}
			set
			{
				this.parentaccountidField = value;
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
		public Lookup primarycontactid
		{
			get
			{
				return this.primarycontactidField;
			}
			set
			{
				this.primarycontactidField = value;
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
		public CrmNumber sgt_aantal_dagen_amusementsmuziek
		{
			get
			{
				return this.sgt_aantal_dagen_amusementsmuziekField;
			}
			set
			{
				this.sgt_aantal_dagen_amusementsmuziekField = value;
			}
		}
		public CrmNumber sgt_aantal_leden_dames
		{
			get
			{
				return this.sgt_aantal_leden_damesField;
			}
			set
			{
				this.sgt_aantal_leden_damesField = value;
			}
		}
		public CrmNumber sgt_aantal_leden_heren
		{
			get
			{
				return this.sgt_aantal_leden_herenField;
			}
			set
			{
				this.sgt_aantal_leden_herenField = value;
			}
		}
		public CrmNumber sgt_aantal_leden_jongens
		{
			get
			{
				return this.sgt_aantal_leden_jongensField;
			}
			set
			{
				this.sgt_aantal_leden_jongensField = value;
			}
		}
		public CrmNumber sgt_aantal_leden_meisjes
		{
			get
			{
				return this.sgt_aantal_leden_meisjesField;
			}
			set
			{
				this.sgt_aantal_leden_meisjesField = value;
			}
		}
		public Picklist sgt_aantal_maanden_geopend
		{
			get
			{
				return this.sgt_aantal_maanden_geopendField;
			}
			set
			{
				this.sgt_aantal_maanden_geopendField = value;
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
		public Lookup sgt_ba_landcodeid
		{
			get
			{
				return this.sgt_ba_landcodeidField;
			}
			set
			{
				this.sgt_ba_landcodeidField = value;
			}
		}
		public Lookup sgt_betalingsvoorwaardeid
		{
			get
			{
				return this.sgt_betalingsvoorwaardeidField;
			}
			set
			{
				this.sgt_betalingsvoorwaardeidField = value;
			}
		}
		public CrmBoolean sgt_bond
		{
			get
			{
				return this.sgt_bondField;
			}
			set
			{
				this.sgt_bondField = value;
			}
		}
		public CrmNumber sgt_buma_aantal_m2
		{
			get
			{
				return this.sgt_buma_aantal_m2Field;
			}
			set
			{
				this.sgt_buma_aantal_m2Field = value;
			}
		}
		public string sgt_buma_achtergrondmuziek
		{
			get
			{
				return this.sgt_buma_achtergrondmuziekField;
			}
			set
			{
				this.sgt_buma_achtergrondmuziekField = value;
			}
		}
		public Picklist sgt_buma_soort
		{
			get
			{
				return this.sgt_buma_soortField;
			}
			set
			{
				this.sgt_buma_soortField = value;
			}
		}
		public CrmBoolean sgt_centre_court
		{
			get
			{
				return this.sgt_centre_courtField;
			}
			set
			{
				this.sgt_centre_courtField = value;
			}
		}
		public string sgt_crediteurnummer
		{
			get
			{
				return this.sgt_crediteurnummerField;
			}
			set
			{
				this.sgt_crediteurnummerField = value;
			}
		}
		public CrmDateTime sgt_datum_afmelding
		{
			get
			{
				return this.sgt_datum_afmeldingField;
			}
			set
			{
				this.sgt_datum_afmeldingField = value;
			}
		}
		public CrmDateTime sgt_datum_fusie
		{
			get
			{
				return this.sgt_datum_fusieField;
			}
			set
			{
				this.sgt_datum_fusieField = value;
			}
		}
		public CrmDateTime sgt_datum_oprichting
		{
			get
			{
				return this.sgt_datum_oprichtingField;
			}
			set
			{
				this.sgt_datum_oprichtingField = value;
			}
		}
		public CrmDateTime sgt_datumer_kenning
		{
			get
			{
				return this.sgt_datumer_kenningField;
			}
			set
			{
				this.sgt_datumer_kenningField = value;
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
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
			}
		}
		public CrmBoolean sgt_export_import
		{
			get
			{
				return this.sgt_export_importField;
			}
			set
			{
				this.sgt_export_importField = value;
			}
		}
		public CrmBoolean sgt_gemeente
		{
			get
			{
				return this.sgt_gemeenteField;
			}
			set
			{
				this.sgt_gemeenteField = value;
			}
		}
		public Lookup sgt_hoofdaccomodatieid
		{
			get
			{
				return this.sgt_hoofdaccomodatieidField;
			}
			set
			{
				this.sgt_hoofdaccomodatieidField = value;
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
		public CrmBoolean sgt_klant
		{
			get
			{
				return this.sgt_klantField;
			}
			set
			{
				this.sgt_klantField = value;
			}
		}
		public string sgt_kvk_nummer
		{
			get
			{
				return this.sgt_kvk_nummerField;
			}
			set
			{
				this.sgt_kvk_nummerField = value;
			}
		}
		public Lookup sgt_kvkbrancheid
		{
			get
			{
				return this.sgt_kvkbrancheidField;
			}
			set
			{
				this.sgt_kvkbrancheidField = value;
			}
		}
		public Lookup sgt_kvkplaatsid
		{
			get
			{
				return this.sgt_kvkplaatsidField;
			}
			set
			{
				this.sgt_kvkplaatsidField = value;
			}
		}
		public CrmBoolean sgt_leverancier
		{
			get
			{
				return this.sgt_leverancierField;
			}
			set
			{
				this.sgt_leverancierField = value;
			}
		}
		public Lookup sgt_leveringsconditieid
		{
			get
			{
				return this.sgt_leveringsconditieidField;
			}
			set
			{
				this.sgt_leveringsconditieidField = value;
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
		public CrmBoolean sgt_media
		{
			get
			{
				return this.sgt_mediaField;
			}
			set
			{
				this.sgt_mediaField = value;
			}
		}
		public Picklist sgt_naam_op_pas
		{
			get
			{
				return this.sgt_naam_op_pasField;
			}
			set
			{
				this.sgt_naam_op_pasField = value;
			}
		}
		public CrmDateTime sgt_occ_lastupdate
		{
			get
			{
				return this.sgt_occ_lastupdateField;
			}
			set
			{
				this.sgt_occ_lastupdateField = value;
			}
		}
		public string sgt_occ_timestamp
		{
			get
			{
				return this.sgt_occ_timestampField;
			}
			set
			{
				this.sgt_occ_timestampField = value;
			}
		}
		public CrmBoolean sgt_opnieuw_bepalen_ledenaantallen
		{
			get
			{
				return this.sgt_opnieuw_bepalen_ledenaantallenField;
			}
			set
			{
				this.sgt_opnieuw_bepalen_ledenaantallenField = value;
			}
		}
		public Lookup sgt_pa_landcodeid
		{
			get
			{
				return this.sgt_pa_landcodeidField;
			}
			set
			{
				this.sgt_pa_landcodeidField = value;
			}
		}
		public CrmBoolean sgt_partner
		{
			get
			{
				return this.sgt_partnerField;
			}
			set
			{
				this.sgt_partnerField = value;
			}
		}
		public string sgt_pasnaam
		{
			get
			{
				return this.sgt_pasnaamField;
			}
			set
			{
				this.sgt_pasnaamField = value;
			}
		}
		public string sgt_ploegnaam
		{
			get
			{
				return this.sgt_ploegnaamField;
			}
			set
			{
				this.sgt_ploegnaamField = value;
			}
		}
		public Lookup sgt_postbus_interface_id
		{
			get
			{
				return this.sgt_postbus_interface_idField;
			}
			set
			{
				this.sgt_postbus_interface_idField = value;
			}
		}
		public Lookup sgt_rechtsvormid
		{
			get
			{
				return this.sgt_rechtsvormidField;
			}
			set
			{
				this.sgt_rechtsvormidField = value;
			}
		}
		public CrmBoolean sgt_regio
		{
			get
			{
				return this.sgt_regioField;
			}
			set
			{
				this.sgt_regioField = value;
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
		public CrmBoolean sgt_sena
		{
			get
			{
				return this.sgt_senaField;
			}
			set
			{
				this.sgt_senaField = value;
			}
		}
		public Lookup sgt_soort_apparatuurid
		{
			get
			{
				return this.sgt_soort_apparatuuridField;
			}
			set
			{
				this.sgt_soort_apparatuuridField = value;
			}
		}
		public Picklist sgt_sortering_ledenpassen
		{
			get
			{
				return this.sgt_sortering_ledenpassenField;
			}
			set
			{
				this.sgt_sortering_ledenpassenField = value;
			}
		}
		public CrmBoolean sgt_sponsor
		{
			get
			{
				return this.sgt_sponsorField;
			}
			set
			{
				this.sgt_sponsorField = value;
			}
		}
		public Picklist sgt_status_sponsor
		{
			get
			{
				return this.sgt_status_sponsorField;
			}
			set
			{
				this.sgt_status_sponsorField = value;
			}
		}
		public Picklist sgt_tegenprestatie_sponsor
		{
			get
			{
				return this.sgt_tegenprestatie_sponsorField;
			}
			set
			{
				this.sgt_tegenprestatie_sponsorField = value;
			}
		}
		public CrmBoolean sgt_tennis_magazine
		{
			get
			{
				return this.sgt_tennis_magazineField;
			}
			set
			{
				this.sgt_tennis_magazineField = value;
			}
		}
		public CrmBoolean sgt_tennisschool
		{
			get
			{
				return this.sgt_tennisschoolField;
			}
			set
			{
				this.sgt_tennisschoolField = value;
			}
		}
		public CrmBoolean sgt_toernooimutaties_via_postbus
		{
			get
			{
				return this.sgt_toernooimutaties_via_postbusField;
			}
			set
			{
				this.sgt_toernooimutaties_via_postbusField = value;
			}
		}
		public CrmBoolean sgt_toernooiorganisatie
		{
			get
			{
				return this.sgt_toernooiorganisatieField;
			}
			set
			{
				this.sgt_toernooiorganisatieField = value;
			}
		}
		public Picklist sgt_type_sponsor
		{
			get
			{
				return this.sgt_type_sponsorField;
			}
			set
			{
				this.sgt_type_sponsorField = value;
			}
		}
		public CrmBoolean sgt_vereniging
		{
			get
			{
				return this.sgt_verenigingField;
			}
			set
			{
				this.sgt_verenigingField = value;
			}
		}
		public Lookup sgt_verzendwijzeid
		{
			get
			{
				return this.sgt_verzendwijzeidField;
			}
			set
			{
				this.sgt_verzendwijzeidField = value;
			}
		}
		public CrmBoolean sgt_wedstrijdcomite
		{
			get
			{
				return this.sgt_wedstrijdcomiteField;
			}
			set
			{
				this.sgt_wedstrijdcomiteField = value;
			}
		}
		public CrmNumber sharesoutstanding
		{
			get
			{
				return this.sharesoutstandingField;
			}
			set
			{
				this.sharesoutstandingField = value;
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
		public AccountStateInfo statecode
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
		public Lookup territoryid
		{
			get
			{
				return this.territoryidField;
			}
			set
			{
				this.territoryidField = value;
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
