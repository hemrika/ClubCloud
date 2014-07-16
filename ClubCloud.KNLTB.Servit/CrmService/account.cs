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

		[XmlElement] //[XmlElement(Order=0)]
		public Picklist accountcategorycode
		{
			get
			{
				return this.accountcategorycodeField;
			}
			set
			{
				this.accountcategorycodeField = value;
				base.RaisePropertyChanged("accountcategorycode");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Picklist accountclassificationcode
		{
			get
			{
				return this.accountclassificationcodeField;
			}
			set
			{
				this.accountclassificationcodeField = value;
				base.RaisePropertyChanged("accountclassificationcode");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public Key accountid
		{
			get
			{
				return this.accountidField;
			}
			set
			{
				this.accountidField = value;
				base.RaisePropertyChanged("accountid");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string accountnumber
		{
			get
			{
				return this.accountnumberField;
			}
			set
			{
				this.accountnumberField = value;
				base.RaisePropertyChanged("accountnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Picklist accountratingcode
		{
			get
			{
				return this.accountratingcodeField;
			}
			set
			{
				this.accountratingcodeField = value;
				base.RaisePropertyChanged("accountratingcode");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
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

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
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

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
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

		[XmlElement] //[XmlElement(Order=47)]
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

		[XmlElement] //[XmlElement(Order=48)]
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

		[XmlElement] //[XmlElement(Order=49)]
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

		[XmlElement] //[XmlElement(Order=50)]
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

		[XmlElement] //[XmlElement(Order=51)]
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

		[XmlElement] //[XmlElement(Order=52)]
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

		[XmlElement] //[XmlElement(Order=53)]
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

		[XmlElement] //[XmlElement(Order=54)]
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

		[XmlElement] //[XmlElement(Order=55)]
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

		[XmlElement] //[XmlElement(Order=56)]
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

		[XmlElement] //[XmlElement(Order=57)]
		public Picklist businesstypecode
		{
			get
			{
				return this.businesstypecodeField;
			}
			set
			{
				this.businesstypecodeField = value;
				base.RaisePropertyChanged("businesstypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
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

		[XmlElement] //[XmlElement(Order=59)]
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

		[XmlElement] //[XmlElement(Order=60)]
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

		[XmlElement] //[XmlElement(Order=61)]
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

		[XmlElement] //[XmlElement(Order=62)]
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

		[XmlElement] //[XmlElement(Order=63)]
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

		[XmlElement] //[XmlElement(Order=64)]
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

		[XmlElement] //[XmlElement(Order=65)]
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

		[XmlElement] //[XmlElement(Order=66)]
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

		[XmlElement] //[XmlElement(Order=67)]
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

		[XmlElement] //[XmlElement(Order=68)]
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

		[XmlElement] //[XmlElement(Order=69)]
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

		[XmlElement] //[XmlElement(Order=70)]
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

		[XmlElement] //[XmlElement(Order=71)]
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

		[XmlElement] //[XmlElement(Order=72)]
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

		[XmlElement] //[XmlElement(Order=73)]
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

		[XmlElement] //[XmlElement(Order=74)]
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

		[XmlElement] //[XmlElement(Order=75)]
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

		[XmlElement] //[XmlElement(Order=76)]
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

		[XmlElement] //[XmlElement(Order=77)]
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

		[XmlElement] //[XmlElement(Order=78)]
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

		[XmlElement] //[XmlElement(Order=79)]
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

		[XmlElement] //[XmlElement(Order=80)]
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

		[XmlElement] //[XmlElement(Order=81)]
		public Picklist industrycode
		{
			get
			{
				return this.industrycodeField;
			}
			set
			{
				this.industrycodeField = value;
				base.RaisePropertyChanged("industrycode");
			}
		}

		[XmlElement] //[XmlElement(Order=82)]
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

		[XmlElement] //[XmlElement(Order=83)]
		public CrmMoney marketcap
		{
			get
			{
				return this.marketcapField;
			}
			set
			{
				this.marketcapField = value;
				base.RaisePropertyChanged("marketcap");
			}
		}

		[XmlElement] //[XmlElement(Order=84)]
		public CrmMoney marketcap_base
		{
			get
			{
				return this.marketcap_baseField;
			}
			set
			{
				this.marketcap_baseField = value;
				base.RaisePropertyChanged("marketcap_base");
			}
		}

		[XmlElement] //[XmlElement(Order=85)]
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

		[XmlElement] //[XmlElement(Order=86)]
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

		[XmlElement] //[XmlElement(Order=87)]
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

		[XmlElement] //[XmlElement(Order=88)]
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

		[XmlElement] //[XmlElement(Order=89)]
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

		[XmlElement] //[XmlElement(Order=90)]
		public CrmNumber numberofemployees
		{
			get
			{
				return this.numberofemployeesField;
			}
			set
			{
				this.numberofemployeesField = value;
				base.RaisePropertyChanged("numberofemployees");
			}
		}

		[XmlElement] //[XmlElement(Order=91)]
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

		[XmlElement] //[XmlElement(Order=92)]
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

		[XmlElement] //[XmlElement(Order=93)]
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

		[XmlElement] //[XmlElement(Order=94)]
		public Picklist ownershipcode
		{
			get
			{
				return this.ownershipcodeField;
			}
			set
			{
				this.ownershipcodeField = value;
				base.RaisePropertyChanged("ownershipcode");
			}
		}

		[XmlElement] //[XmlElement(Order=95)]
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

		[XmlElement] //[XmlElement(Order=96)]
		public Lookup parentaccountid
		{
			get
			{
				return this.parentaccountidField;
			}
			set
			{
				this.parentaccountidField = value;
				base.RaisePropertyChanged("parentaccountid");
			}
		}

		[XmlElement] //[XmlElement(Order=97)]
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

		[XmlElement] //[XmlElement(Order=98)]
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

		[XmlElement] //[XmlElement(Order=99)]
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

		[XmlElement] //[XmlElement(Order=100)]
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

		[XmlElement] //[XmlElement(Order=101)]
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

		[XmlElement] //[XmlElement(Order=102)]
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

		[XmlElement] //[XmlElement(Order=103)]
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

		[XmlElement] //[XmlElement(Order=104)]
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

		[XmlElement] //[XmlElement(Order=105)]
		public Lookup primarycontactid
		{
			get
			{
				return this.primarycontactidField;
			}
			set
			{
				this.primarycontactidField = value;
				base.RaisePropertyChanged("primarycontactid");
			}
		}

		[XmlElement] //[XmlElement(Order=106)]
		public CrmMoney revenue
		{
			get
			{
				return this.revenueField;
			}
			set
			{
				this.revenueField = value;
				base.RaisePropertyChanged("revenue");
			}
		}

		[XmlElement] //[XmlElement(Order=107)]
		public CrmMoney revenue_base
		{
			get
			{
				return this.revenue_baseField;
			}
			set
			{
				this.revenue_baseField = value;
				base.RaisePropertyChanged("revenue_base");
			}
		}

		[XmlElement] //[XmlElement(Order=108)]
		public CrmNumber sgt_aantal_dagen_amusementsmuziek
		{
			get
			{
				return this.sgt_aantal_dagen_amusementsmuziekField;
			}
			set
			{
				this.sgt_aantal_dagen_amusementsmuziekField = value;
				base.RaisePropertyChanged("sgt_aantal_dagen_amusementsmuziek");
			}
		}

		[XmlElement] //[XmlElement(Order=109)]
		public CrmNumber sgt_aantal_leden_dames
		{
			get
			{
				return this.sgt_aantal_leden_damesField;
			}
			set
			{
				this.sgt_aantal_leden_damesField = value;
				base.RaisePropertyChanged("sgt_aantal_leden_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=110)]
		public CrmNumber sgt_aantal_leden_heren
		{
			get
			{
				return this.sgt_aantal_leden_herenField;
			}
			set
			{
				this.sgt_aantal_leden_herenField = value;
				base.RaisePropertyChanged("sgt_aantal_leden_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=111)]
		public CrmNumber sgt_aantal_leden_jongens
		{
			get
			{
				return this.sgt_aantal_leden_jongensField;
			}
			set
			{
				this.sgt_aantal_leden_jongensField = value;
				base.RaisePropertyChanged("sgt_aantal_leden_jongens");
			}
		}

		[XmlElement] //[XmlElement(Order=112)]
		public CrmNumber sgt_aantal_leden_meisjes
		{
			get
			{
				return this.sgt_aantal_leden_meisjesField;
			}
			set
			{
				this.sgt_aantal_leden_meisjesField = value;
				base.RaisePropertyChanged("sgt_aantal_leden_meisjes");
			}
		}

		[XmlElement] //[XmlElement(Order=113)]
		public Picklist sgt_aantal_maanden_geopend
		{
			get
			{
				return this.sgt_aantal_maanden_geopendField;
			}
			set
			{
				this.sgt_aantal_maanden_geopendField = value;
				base.RaisePropertyChanged("sgt_aantal_maanden_geopend");
			}
		}

		[XmlElement] //[XmlElement(Order=114)]
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

		[XmlElement] //[XmlElement(Order=115)]
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

		[XmlElement] //[XmlElement(Order=116)]
		public Lookup sgt_ba_landcodeid
		{
			get
			{
				return this.sgt_ba_landcodeidField;
			}
			set
			{
				this.sgt_ba_landcodeidField = value;
				base.RaisePropertyChanged("sgt_ba_landcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=117)]
		public Lookup sgt_betalingsvoorwaardeid
		{
			get
			{
				return this.sgt_betalingsvoorwaardeidField;
			}
			set
			{
				this.sgt_betalingsvoorwaardeidField = value;
				base.RaisePropertyChanged("sgt_betalingsvoorwaardeid");
			}
		}

		[XmlElement] //[XmlElement(Order=118)]
		public CrmBoolean sgt_bond
		{
			get
			{
				return this.sgt_bondField;
			}
			set
			{
				this.sgt_bondField = value;
				base.RaisePropertyChanged("sgt_bond");
			}
		}

		[XmlElement] //[XmlElement(Order=119)]
		public CrmNumber sgt_buma_aantal_m2
		{
			get
			{
				return this.sgt_buma_aantal_m2Field;
			}
			set
			{
				this.sgt_buma_aantal_m2Field = value;
				base.RaisePropertyChanged("sgt_buma_aantal_m2");
			}
		}

		[XmlElement] //[XmlElement(Order=120)]
		public string sgt_buma_achtergrondmuziek
		{
			get
			{
				return this.sgt_buma_achtergrondmuziekField;
			}
			set
			{
				this.sgt_buma_achtergrondmuziekField = value;
				base.RaisePropertyChanged("sgt_buma_achtergrondmuziek");
			}
		}

		[XmlElement] //[XmlElement(Order=121)]
		public Picklist sgt_buma_soort
		{
			get
			{
				return this.sgt_buma_soortField;
			}
			set
			{
				this.sgt_buma_soortField = value;
				base.RaisePropertyChanged("sgt_buma_soort");
			}
		}

		[XmlElement] //[XmlElement(Order=122)]
		public CrmBoolean sgt_centre_court
		{
			get
			{
				return this.sgt_centre_courtField;
			}
			set
			{
				this.sgt_centre_courtField = value;
				base.RaisePropertyChanged("sgt_centre_court");
			}
		}

		[XmlElement] //[XmlElement(Order=123)]
		public string sgt_crediteurnummer
		{
			get
			{
				return this.sgt_crediteurnummerField;
			}
			set
			{
				this.sgt_crediteurnummerField = value;
				base.RaisePropertyChanged("sgt_crediteurnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=124)]
		public CrmDateTime sgt_datum_afmelding
		{
			get
			{
				return this.sgt_datum_afmeldingField;
			}
			set
			{
				this.sgt_datum_afmeldingField = value;
				base.RaisePropertyChanged("sgt_datum_afmelding");
			}
		}

		[XmlElement] //[XmlElement(Order=125)]
		public CrmDateTime sgt_datum_fusie
		{
			get
			{
				return this.sgt_datum_fusieField;
			}
			set
			{
				this.sgt_datum_fusieField = value;
				base.RaisePropertyChanged("sgt_datum_fusie");
			}
		}

		[XmlElement] //[XmlElement(Order=126)]
		public CrmDateTime sgt_datum_oprichting
		{
			get
			{
				return this.sgt_datum_oprichtingField;
			}
			set
			{
				this.sgt_datum_oprichtingField = value;
				base.RaisePropertyChanged("sgt_datum_oprichting");
			}
		}

		[XmlElement] //[XmlElement(Order=127)]
		public CrmDateTime sgt_datumer_kenning
		{
			get
			{
				return this.sgt_datumer_kenningField;
			}
			set
			{
				this.sgt_datumer_kenningField = value;
				base.RaisePropertyChanged("sgt_datumer_kenning");
			}
		}

		[XmlElement] //[XmlElement(Order=128)]
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

		[XmlElement] //[XmlElement(Order=129)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}

		[XmlElement] //[XmlElement(Order=130)]
		public CrmBoolean sgt_export_import
		{
			get
			{
				return this.sgt_export_importField;
			}
			set
			{
				this.sgt_export_importField = value;
				base.RaisePropertyChanged("sgt_export_import");
			}
		}

		[XmlElement] //[XmlElement(Order=131)]
		public CrmBoolean sgt_gemeente
		{
			get
			{
				return this.sgt_gemeenteField;
			}
			set
			{
				this.sgt_gemeenteField = value;
				base.RaisePropertyChanged("sgt_gemeente");
			}
		}

		[XmlElement] //[XmlElement(Order=132)]
		public Lookup sgt_hoofdaccomodatieid
		{
			get
			{
				return this.sgt_hoofdaccomodatieidField;
			}
			set
			{
				this.sgt_hoofdaccomodatieidField = value;
				base.RaisePropertyChanged("sgt_hoofdaccomodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=133)]
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

		[XmlElement] //[XmlElement(Order=134)]
		public CrmBoolean sgt_klant
		{
			get
			{
				return this.sgt_klantField;
			}
			set
			{
				this.sgt_klantField = value;
				base.RaisePropertyChanged("sgt_klant");
			}
		}

		[XmlElement] //[XmlElement(Order=135)]
		public string sgt_kvk_nummer
		{
			get
			{
				return this.sgt_kvk_nummerField;
			}
			set
			{
				this.sgt_kvk_nummerField = value;
				base.RaisePropertyChanged("sgt_kvk_nummer");
			}
		}

		[XmlElement] //[XmlElement(Order=136)]
		public Lookup sgt_kvkbrancheid
		{
			get
			{
				return this.sgt_kvkbrancheidField;
			}
			set
			{
				this.sgt_kvkbrancheidField = value;
				base.RaisePropertyChanged("sgt_kvkbrancheid");
			}
		}

		[XmlElement] //[XmlElement(Order=137)]
		public Lookup sgt_kvkplaatsid
		{
			get
			{
				return this.sgt_kvkplaatsidField;
			}
			set
			{
				this.sgt_kvkplaatsidField = value;
				base.RaisePropertyChanged("sgt_kvkplaatsid");
			}
		}

		[XmlElement] //[XmlElement(Order=138)]
		public CrmBoolean sgt_leverancier
		{
			get
			{
				return this.sgt_leverancierField;
			}
			set
			{
				this.sgt_leverancierField = value;
				base.RaisePropertyChanged("sgt_leverancier");
			}
		}

		[XmlElement] //[XmlElement(Order=139)]
		public Lookup sgt_leveringsconditieid
		{
			get
			{
				return this.sgt_leveringsconditieidField;
			}
			set
			{
				this.sgt_leveringsconditieidField = value;
				base.RaisePropertyChanged("sgt_leveringsconditieid");
			}
		}

		[XmlElement] //[XmlElement(Order=140)]
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

		[XmlElement] //[XmlElement(Order=141)]
		public CrmBoolean sgt_media
		{
			get
			{
				return this.sgt_mediaField;
			}
			set
			{
				this.sgt_mediaField = value;
				base.RaisePropertyChanged("sgt_media");
			}
		}

		[XmlElement] //[XmlElement(Order=142)]
		public Picklist sgt_naam_op_pas
		{
			get
			{
				return this.sgt_naam_op_pasField;
			}
			set
			{
				this.sgt_naam_op_pasField = value;
				base.RaisePropertyChanged("sgt_naam_op_pas");
			}
		}

		[XmlElement] //[XmlElement(Order=143)]
		public CrmDateTime sgt_occ_lastupdate
		{
			get
			{
				return this.sgt_occ_lastupdateField;
			}
			set
			{
				this.sgt_occ_lastupdateField = value;
				base.RaisePropertyChanged("sgt_occ_lastupdate");
			}
		}

		[XmlElement] //[XmlElement(Order=144)]
		public string sgt_occ_timestamp
		{
			get
			{
				return this.sgt_occ_timestampField;
			}
			set
			{
				this.sgt_occ_timestampField = value;
				base.RaisePropertyChanged("sgt_occ_timestamp");
			}
		}

		[XmlElement] //[XmlElement(Order=145)]
		public CrmBoolean sgt_opnieuw_bepalen_ledenaantallen
		{
			get
			{
				return this.sgt_opnieuw_bepalen_ledenaantallenField;
			}
			set
			{
				this.sgt_opnieuw_bepalen_ledenaantallenField = value;
				base.RaisePropertyChanged("sgt_opnieuw_bepalen_ledenaantallen");
			}
		}

		[XmlElement] //[XmlElement(Order=146)]
		public Lookup sgt_pa_landcodeid
		{
			get
			{
				return this.sgt_pa_landcodeidField;
			}
			set
			{
				this.sgt_pa_landcodeidField = value;
				base.RaisePropertyChanged("sgt_pa_landcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=147)]
		public CrmBoolean sgt_partner
		{
			get
			{
				return this.sgt_partnerField;
			}
			set
			{
				this.sgt_partnerField = value;
				base.RaisePropertyChanged("sgt_partner");
			}
		}

		[XmlElement] //[XmlElement(Order=148)]
		public string sgt_pasnaam
		{
			get
			{
				return this.sgt_pasnaamField;
			}
			set
			{
				this.sgt_pasnaamField = value;
				base.RaisePropertyChanged("sgt_pasnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=149)]
		public string sgt_ploegnaam
		{
			get
			{
				return this.sgt_ploegnaamField;
			}
			set
			{
				this.sgt_ploegnaamField = value;
				base.RaisePropertyChanged("sgt_ploegnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=150)]
		public Lookup sgt_postbus_interface_id
		{
			get
			{
				return this.sgt_postbus_interface_idField;
			}
			set
			{
				this.sgt_postbus_interface_idField = value;
				base.RaisePropertyChanged("sgt_postbus_interface_id");
			}
		}

		[XmlElement] //[XmlElement(Order=151)]
		public Lookup sgt_rechtsvormid
		{
			get
			{
				return this.sgt_rechtsvormidField;
			}
			set
			{
				this.sgt_rechtsvormidField = value;
				base.RaisePropertyChanged("sgt_rechtsvormid");
			}
		}

		[XmlElement] //[XmlElement(Order=152)]
		public CrmBoolean sgt_regio
		{
			get
			{
				return this.sgt_regioField;
			}
			set
			{
				this.sgt_regioField = value;
				base.RaisePropertyChanged("sgt_regio");
			}
		}

		[XmlElement] //[XmlElement(Order=153)]
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

		[XmlElement] //[XmlElement(Order=154)]
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

		[XmlElement] //[XmlElement(Order=155)]
		public CrmBoolean sgt_sena
		{
			get
			{
				return this.sgt_senaField;
			}
			set
			{
				this.sgt_senaField = value;
				base.RaisePropertyChanged("sgt_sena");
			}
		}

		[XmlElement] //[XmlElement(Order=156)]
		public Lookup sgt_soort_apparatuurid
		{
			get
			{
				return this.sgt_soort_apparatuuridField;
			}
			set
			{
				this.sgt_soort_apparatuuridField = value;
				base.RaisePropertyChanged("sgt_soort_apparatuurid");
			}
		}

		[XmlElement] //[XmlElement(Order=157)]
		public Picklist sgt_sortering_ledenpassen
		{
			get
			{
				return this.sgt_sortering_ledenpassenField;
			}
			set
			{
				this.sgt_sortering_ledenpassenField = value;
				base.RaisePropertyChanged("sgt_sortering_ledenpassen");
			}
		}

		[XmlElement] //[XmlElement(Order=158)]
		public CrmBoolean sgt_sponsor
		{
			get
			{
				return this.sgt_sponsorField;
			}
			set
			{
				this.sgt_sponsorField = value;
				base.RaisePropertyChanged("sgt_sponsor");
			}
		}

		[XmlElement] //[XmlElement(Order=159)]
		public Picklist sgt_status_sponsor
		{
			get
			{
				return this.sgt_status_sponsorField;
			}
			set
			{
				this.sgt_status_sponsorField = value;
				base.RaisePropertyChanged("sgt_status_sponsor");
			}
		}

		[XmlElement] //[XmlElement(Order=160)]
		public Picklist sgt_tegenprestatie_sponsor
		{
			get
			{
				return this.sgt_tegenprestatie_sponsorField;
			}
			set
			{
				this.sgt_tegenprestatie_sponsorField = value;
				base.RaisePropertyChanged("sgt_tegenprestatie_sponsor");
			}
		}

		[XmlElement] //[XmlElement(Order=161)]
		public CrmBoolean sgt_tennis_magazine
		{
			get
			{
				return this.sgt_tennis_magazineField;
			}
			set
			{
				this.sgt_tennis_magazineField = value;
				base.RaisePropertyChanged("sgt_tennis_magazine");
			}
		}

		[XmlElement] //[XmlElement(Order=162)]
		public CrmBoolean sgt_tennisschool
		{
			get
			{
				return this.sgt_tennisschoolField;
			}
			set
			{
				this.sgt_tennisschoolField = value;
				base.RaisePropertyChanged("sgt_tennisschool");
			}
		}

		[XmlElement] //[XmlElement(Order=163)]
		public CrmBoolean sgt_toernooimutaties_via_postbus
		{
			get
			{
				return this.sgt_toernooimutaties_via_postbusField;
			}
			set
			{
				this.sgt_toernooimutaties_via_postbusField = value;
				base.RaisePropertyChanged("sgt_toernooimutaties_via_postbus");
			}
		}

		[XmlElement] //[XmlElement(Order=164)]
		public CrmBoolean sgt_toernooiorganisatie
		{
			get
			{
				return this.sgt_toernooiorganisatieField;
			}
			set
			{
				this.sgt_toernooiorganisatieField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatie");
			}
		}

		[XmlElement] //[XmlElement(Order=165)]
		public Picklist sgt_type_sponsor
		{
			get
			{
				return this.sgt_type_sponsorField;
			}
			set
			{
				this.sgt_type_sponsorField = value;
				base.RaisePropertyChanged("sgt_type_sponsor");
			}
		}

		[XmlElement] //[XmlElement(Order=166)]
		public CrmBoolean sgt_vereniging
		{
			get
			{
				return this.sgt_verenigingField;
			}
			set
			{
				this.sgt_verenigingField = value;
				base.RaisePropertyChanged("sgt_vereniging");
			}
		}

		[XmlElement] //[XmlElement(Order=167)]
		public Lookup sgt_verzendwijzeid
		{
			get
			{
				return this.sgt_verzendwijzeidField;
			}
			set
			{
				this.sgt_verzendwijzeidField = value;
				base.RaisePropertyChanged("sgt_verzendwijzeid");
			}
		}

		[XmlElement] //[XmlElement(Order=168)]
		public CrmBoolean sgt_wedstrijdcomite
		{
			get
			{
				return this.sgt_wedstrijdcomiteField;
			}
			set
			{
				this.sgt_wedstrijdcomiteField = value;
				base.RaisePropertyChanged("sgt_wedstrijdcomite");
			}
		}

		[XmlElement] //[XmlElement(Order=169)]
		public CrmNumber sharesoutstanding
		{
			get
			{
				return this.sharesoutstandingField;
			}
			set
			{
				this.sharesoutstandingField = value;
				base.RaisePropertyChanged("sharesoutstanding");
			}
		}

		[XmlElement] //[XmlElement(Order=170)]
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

		[XmlElement] //[XmlElement(Order=171)]
		public string sic
		{
			get
			{
				return this.sicField;
			}
			set
			{
				this.sicField = value;
				base.RaisePropertyChanged("sic");
			}
		}

		[XmlElement] //[XmlElement(Order=172)]
		public AccountStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=173)]
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

		[XmlElement] //[XmlElement(Order=174)]
		public string stockexchange
		{
			get
			{
				return this.stockexchangeField;
			}
			set
			{
				this.stockexchangeField = value;
				base.RaisePropertyChanged("stockexchange");
			}
		}

		[XmlElement] //[XmlElement(Order=175)]
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

		[XmlElement] //[XmlElement(Order=176)]
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

		[XmlElement] //[XmlElement(Order=177)]
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

		[XmlElement] //[XmlElement(Order=178)]
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

		[XmlElement] //[XmlElement(Order=179)]
		public Lookup territoryid
		{
			get
			{
				return this.territoryidField;
			}
			set
			{
				this.territoryidField = value;
				base.RaisePropertyChanged("territoryid");
			}
		}

		[XmlElement] //[XmlElement(Order=180)]
		public string tickersymbol
		{
			get
			{
				return this.tickersymbolField;
			}
			set
			{
				this.tickersymbolField = value;
				base.RaisePropertyChanged("tickersymbol");
			}
		}

		[XmlElement] //[XmlElement(Order=181)]
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

		[XmlElement] //[XmlElement(Order=182)]
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

		[XmlElement] //[XmlElement(Order=183)]
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

		[XmlElement] //[XmlElement(Order=184)]
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

		[XmlElement] //[XmlElement(Order=185)]
		public string yominame
		{
			get
			{
				return this.yominameField;
			}
			set
			{
				this.yominameField = value;
				base.RaisePropertyChanged("yominame");
			}
		}

		public account()
		{
		}
	}
}