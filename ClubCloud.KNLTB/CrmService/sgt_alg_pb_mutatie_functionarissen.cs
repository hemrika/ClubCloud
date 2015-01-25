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
	public class sgt_alg_pb_mutatie_functionarissen : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_2e_nationaliteitidField;

		private string sgt_achternaamField;

		private CrmBoolean sgt_adres_geheimField;

		private Key sgt_alg_pb_mutatie_functionarissenidField;

		private Lookup sgt_bestuursorgaanidField;

		private string sgt_bestuursorgaanid_naamField;

		private string sgt_bondsnummerField;

		private CrmDateTime sgt_datum_mutatie_verwerktField;

		private CrmDateTime sgt_datum_overledenField;

		private Lookup sgt_districtidField;

		private string sgt_districtid_naamField;

		private CrmBoolean sgt_do_not_bulk_emailField;

		private CrmBoolean sgt_do_not_emailField;

		private CrmBoolean sgt_do_not_faxField;

		private CrmBoolean sgt_do_not_phoneField;

		private CrmBoolean sgt_do_not_postal_mailField;

		private string sgt_emailadresField;

		private string sgt_emailadres2Field;

		private string sgt_emailadres3Field;

		private string sgt_faxField;

		private Lookup sgt_functieidField;

		private string sgt_functieid_naamField;

		private Lookup sgt_functionarisidField;

		private CrmDateTime sgt_geboortedatumField;

		private string sgt_gemeente_paField;

		private string sgt_gemeente_waField;

		private Picklist sgt_geslachtField;

		private string sgt_huisnummer_paField;

		private string sgt_huisnummer_waField;

		private Picklist sgt_import_exportField;

		private Lookup sgt_landcode_postadresidField;

		private Lookup sgt_landcode_woonadresidField;

		private CrmBoolean sgt_meerlingField;

		private string sgt_mobielField;

		private Lookup sgt_nationaliteitidField;

		private CrmBoolean sgt_ongeldige_licentie_tennisleraarField;

		private Lookup sgt_pb_interface_logboek_export_xmlidField;

		private Lookup sgt_pb_interface_logboek_import_xmlidField;

		private Lookup sgt_pb_interface_logboekidField;

		private Lookup sgt_persoonidField;

		private string sgt_plaats_paField;

		private string sgt_plaats_waField;

		private string sgt_postcode_paField;

		private string sgt_postcode_waField;

		private string sgt_roepnaamField;

		private string sgt_straat_paField;

		private string sgt_straat_waField;

		private string sgt_telefoon_avondField;

		private CrmBoolean sgt_telefoon_geheimField;

		private string sgt_telefoon_overdagField;

		private CrmDateTime sgt_termijn_begintField;

		private CrmDateTime sgt_termijn_loopt_afField;

		private string sgt_toevoeging_paField;

		private string sgt_toevoeging_waField;

		private string sgt_tussenvoegselsField;

		private Picklist sgt_type_mutatieField;

		private Lookup sgt_verenigingidField;

		private string sgt_verenigingsnummerField;

		private string sgt_volgnummerField;

		private string sgt_volledige_naamField;

		private Picklist sgt_voorkeur_contactwijzeField;

		private string sgt_voorlettersField;

		private string sgt_voornamenField;

		private Sgt_alg_pb_mutatie_functionarissenStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_achternaam
		{
			get
			{
				return this.sgt_achternaamField;
			}
			set
			{
				this.sgt_achternaamField = value;
				base.RaisePropertyChanged("sgt_achternaam");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public Key sgt_alg_pb_mutatie_functionarissenid
		{
			get
			{
				return this.sgt_alg_pb_mutatie_functionarissenidField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_functionarissenidField = value;
				base.RaisePropertyChanged("sgt_alg_pb_mutatie_functionarissenid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_bestuursorgaanid
		{
			get
			{
				return this.sgt_bestuursorgaanidField;
			}
			set
			{
				this.sgt_bestuursorgaanidField = value;
				base.RaisePropertyChanged("sgt_bestuursorgaanid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_bestuursorgaanid_naam
		{
			get
			{
				return this.sgt_bestuursorgaanid_naamField;
			}
			set
			{
				this.sgt_bestuursorgaanid_naamField = value;
				base.RaisePropertyChanged("sgt_bestuursorgaanid_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDateTime sgt_datum_mutatie_verwerkt
		{
			get
			{
				return this.sgt_datum_mutatie_verwerktField;
			}
			set
			{
				this.sgt_datum_mutatie_verwerktField = value;
				base.RaisePropertyChanged("sgt_datum_mutatie_verwerkt");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_districtid_naam
		{
			get
			{
				return this.sgt_districtid_naamField;
			}
			set
			{
				this.sgt_districtid_naamField = value;
				base.RaisePropertyChanged("sgt_districtid_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmBoolean sgt_do_not_bulk_email
		{
			get
			{
				return this.sgt_do_not_bulk_emailField;
			}
			set
			{
				this.sgt_do_not_bulk_emailField = value;
				base.RaisePropertyChanged("sgt_do_not_bulk_email");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmBoolean sgt_do_not_email
		{
			get
			{
				return this.sgt_do_not_emailField;
			}
			set
			{
				this.sgt_do_not_emailField = value;
				base.RaisePropertyChanged("sgt_do_not_email");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmBoolean sgt_do_not_fax
		{
			get
			{
				return this.sgt_do_not_faxField;
			}
			set
			{
				this.sgt_do_not_faxField = value;
				base.RaisePropertyChanged("sgt_do_not_fax");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmBoolean sgt_do_not_phone
		{
			get
			{
				return this.sgt_do_not_phoneField;
			}
			set
			{
				this.sgt_do_not_phoneField = value;
				base.RaisePropertyChanged("sgt_do_not_phone");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmBoolean sgt_do_not_postal_mail
		{
			get
			{
				return this.sgt_do_not_postal_mailField;
			}
			set
			{
				this.sgt_do_not_postal_mailField = value;
				base.RaisePropertyChanged("sgt_do_not_postal_mail");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_emailadres
		{
			get
			{
				return this.sgt_emailadresField;
			}
			set
			{
				this.sgt_emailadresField = value;
				base.RaisePropertyChanged("sgt_emailadres");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_emailadres2
		{
			get
			{
				return this.sgt_emailadres2Field;
			}
			set
			{
				this.sgt_emailadres2Field = value;
				base.RaisePropertyChanged("sgt_emailadres2");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public string sgt_emailadres3
		{
			get
			{
				return this.sgt_emailadres3Field;
			}
			set
			{
				this.sgt_emailadres3Field = value;
				base.RaisePropertyChanged("sgt_emailadres3");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_fax
		{
			get
			{
				return this.sgt_faxField;
			}
			set
			{
				this.sgt_faxField = value;
				base.RaisePropertyChanged("sgt_fax");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
				base.RaisePropertyChanged("sgt_functieid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_functieid_naam
		{
			get
			{
				return this.sgt_functieid_naamField;
			}
			set
			{
				this.sgt_functieid_naamField = value;
				base.RaisePropertyChanged("sgt_functieid_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_functionarisid
		{
			get
			{
				return this.sgt_functionarisidField;
			}
			set
			{
				this.sgt_functionarisidField = value;
				base.RaisePropertyChanged("sgt_functionarisid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
				base.RaisePropertyChanged("sgt_geboortedatum");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_gemeente_pa
		{
			get
			{
				return this.sgt_gemeente_paField;
			}
			set
			{
				this.sgt_gemeente_paField = value;
				base.RaisePropertyChanged("sgt_gemeente_pa");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_gemeente_wa
		{
			get
			{
				return this.sgt_gemeente_waField;
			}
			set
			{
				this.sgt_gemeente_waField = value;
				base.RaisePropertyChanged("sgt_gemeente_wa");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public string sgt_huisnummer_pa
		{
			get
			{
				return this.sgt_huisnummer_paField;
			}
			set
			{
				this.sgt_huisnummer_paField = value;
				base.RaisePropertyChanged("sgt_huisnummer_pa");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public string sgt_huisnummer_wa
		{
			get
			{
				return this.sgt_huisnummer_waField;
			}
			set
			{
				this.sgt_huisnummer_waField = value;
				base.RaisePropertyChanged("sgt_huisnummer_wa");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Picklist sgt_import_export
		{
			get
			{
				return this.sgt_import_exportField;
			}
			set
			{
				this.sgt_import_exportField = value;
				base.RaisePropertyChanged("sgt_import_export");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
		public string sgt_mobiel
		{
			get
			{
				return this.sgt_mobielField;
			}
			set
			{
				this.sgt_mobielField = value;
				base.RaisePropertyChanged("sgt_mobiel");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
		public CrmBoolean sgt_ongeldige_licentie_tennisleraar
		{
			get
			{
				return this.sgt_ongeldige_licentie_tennisleraarField;
			}
			set
			{
				this.sgt_ongeldige_licentie_tennisleraarField = value;
				base.RaisePropertyChanged("sgt_ongeldige_licentie_tennisleraar");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public Lookup sgt_pb_interface_logboek_export_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_export_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_export_xmlidField = value;
				base.RaisePropertyChanged("sgt_pb_interface_logboek_export_xmlid");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public Lookup sgt_pb_interface_logboek_import_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_import_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_import_xmlidField = value;
				base.RaisePropertyChanged("sgt_pb_interface_logboek_import_xmlid");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public Lookup sgt_pb_interface_logboekid
		{
			get
			{
				return this.sgt_pb_interface_logboekidField;
			}
			set
			{
				this.sgt_pb_interface_logboekidField = value;
				base.RaisePropertyChanged("sgt_pb_interface_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public string sgt_plaats_pa
		{
			get
			{
				return this.sgt_plaats_paField;
			}
			set
			{
				this.sgt_plaats_paField = value;
				base.RaisePropertyChanged("sgt_plaats_pa");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public string sgt_plaats_wa
		{
			get
			{
				return this.sgt_plaats_waField;
			}
			set
			{
				this.sgt_plaats_waField = value;
				base.RaisePropertyChanged("sgt_plaats_wa");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public string sgt_postcode_pa
		{
			get
			{
				return this.sgt_postcode_paField;
			}
			set
			{
				this.sgt_postcode_paField = value;
				base.RaisePropertyChanged("sgt_postcode_pa");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public string sgt_postcode_wa
		{
			get
			{
				return this.sgt_postcode_waField;
			}
			set
			{
				this.sgt_postcode_waField = value;
				base.RaisePropertyChanged("sgt_postcode_wa");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public string sgt_roepnaam
		{
			get
			{
				return this.sgt_roepnaamField;
			}
			set
			{
				this.sgt_roepnaamField = value;
				base.RaisePropertyChanged("sgt_roepnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public string sgt_straat_pa
		{
			get
			{
				return this.sgt_straat_paField;
			}
			set
			{
				this.sgt_straat_paField = value;
				base.RaisePropertyChanged("sgt_straat_pa");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public string sgt_straat_wa
		{
			get
			{
				return this.sgt_straat_waField;
			}
			set
			{
				this.sgt_straat_waField = value;
				base.RaisePropertyChanged("sgt_straat_wa");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public string sgt_telefoon_avond
		{
			get
			{
				return this.sgt_telefoon_avondField;
			}
			set
			{
				this.sgt_telefoon_avondField = value;
				base.RaisePropertyChanged("sgt_telefoon_avond");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
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

		[XmlElement] //[XmlElement(Order=57)]
		public string sgt_telefoon_overdag
		{
			get
			{
				return this.sgt_telefoon_overdagField;
			}
			set
			{
				this.sgt_telefoon_overdagField = value;
				base.RaisePropertyChanged("sgt_telefoon_overdag");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public CrmDateTime sgt_termijn_begint
		{
			get
			{
				return this.sgt_termijn_begintField;
			}
			set
			{
				this.sgt_termijn_begintField = value;
				base.RaisePropertyChanged("sgt_termijn_begint");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public CrmDateTime sgt_termijn_loopt_af
		{
			get
			{
				return this.sgt_termijn_loopt_afField;
			}
			set
			{
				this.sgt_termijn_loopt_afField = value;
				base.RaisePropertyChanged("sgt_termijn_loopt_af");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public string sgt_toevoeging_pa
		{
			get
			{
				return this.sgt_toevoeging_paField;
			}
			set
			{
				this.sgt_toevoeging_paField = value;
				base.RaisePropertyChanged("sgt_toevoeging_pa");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public string sgt_toevoeging_wa
		{
			get
			{
				return this.sgt_toevoeging_waField;
			}
			set
			{
				this.sgt_toevoeging_waField = value;
				base.RaisePropertyChanged("sgt_toevoeging_wa");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public string sgt_tussenvoegsels
		{
			get
			{
				return this.sgt_tussenvoegselsField;
			}
			set
			{
				this.sgt_tussenvoegselsField = value;
				base.RaisePropertyChanged("sgt_tussenvoegsels");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public Picklist sgt_type_mutatie
		{
			get
			{
				return this.sgt_type_mutatieField;
			}
			set
			{
				this.sgt_type_mutatieField = value;
				base.RaisePropertyChanged("sgt_type_mutatie");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
				base.RaisePropertyChanged("sgt_verenigingid");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
				base.RaisePropertyChanged("sgt_verenigingsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public string sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
				base.RaisePropertyChanged("sgt_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public string sgt_volledige_naam
		{
			get
			{
				return this.sgt_volledige_naamField;
			}
			set
			{
				this.sgt_volledige_naamField = value;
				base.RaisePropertyChanged("sgt_volledige_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public Picklist sgt_voorkeur_contactwijze
		{
			get
			{
				return this.sgt_voorkeur_contactwijzeField;
			}
			set
			{
				this.sgt_voorkeur_contactwijzeField = value;
				base.RaisePropertyChanged("sgt_voorkeur_contactwijze");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public string sgt_voorletters
		{
			get
			{
				return this.sgt_voorlettersField;
			}
			set
			{
				this.sgt_voorlettersField = value;
				base.RaisePropertyChanged("sgt_voorletters");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
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

		[XmlElement] //[XmlElement(Order=71)]
		public Sgt_alg_pb_mutatie_functionarissenStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=72)]
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

		[XmlElement] //[XmlElement(Order=73)]
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

		[XmlElement] //[XmlElement(Order=74)]
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

		public sgt_alg_pb_mutatie_functionarissen()
		{
		}
	}
}