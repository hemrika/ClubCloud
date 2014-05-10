using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_pb_mutatie_accommodaties : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_ehbo_fysio_ruimtesField;
		private CrmNumber sgt_aantal_ehbo_fysio_ruimtes_clubhuisField;
		private CrmNumber sgt_aantal_kleed_wasruimtesField;
		private CrmNumber sgt_aantal_kleed_wasruimtes_clubhuisField;
		private CrmNumber sgt_aantal_minibanenField;
		private CrmNumber sgt_aantal_mv_parkeerplaatsenField;
		private CrmNumber sgt_aantal_oefenmurenField;
		private CrmNumber sgt_aantal_parkeerplaatsenField;
		private CrmNumber sgt_aantal_playgroundsField;
		private CrmNumber sgt_aantal_toiletten_clubhuisField;
		private CrmNumber sgt_aantal_verg_wed_ruimtesField;
		private CrmNumber sgt_aantal_verg_wed_ruimtes_clubhuisField;
		private Lookup sgt_accommodatieidField;
		private string sgt_accommodatienaamField;
		private Key sgt_alg_pb_mutatie_accommodatiesidField;
		private CrmNumber sgt_baan_binnenField;
		private CrmNumber sgt_baan_binnen_afgekeurdField;
		private CrmNumber sgt_baan_binnen_dispensatieField;
		private CrmNumber sgt_baan_binnen_goedgekeurdField;
		private CrmNumber sgt_baan_binnen_te_keurenField;
		private CrmNumber sgt_baan_blaashalField;
		private CrmNumber sgt_baan_blaashal_afgekeurdField;
		private CrmNumber sgt_baan_blaashal_dispensatieField;
		private CrmNumber sgt_baan_blaashal_goedgekeurdField;
		private CrmNumber sgt_baan_blaashal_te_keurenField;
		private CrmNumber sgt_baan_buitenField;
		private CrmNumber sgt_baan_buiten_afgekeurdField;
		private CrmNumber sgt_baan_buiten_dispensatieField;
		private CrmNumber sgt_baan_buiten_goedgekeurdField;
		private CrmNumber sgt_baan_buiten_ovField;
		private CrmNumber sgt_baan_buiten_ov_afgekeurdField;
		private CrmNumber sgt_baan_buiten_ov_dispensatieField;
		private CrmNumber sgt_baan_buiten_ov_goedgekeurdField;
		private CrmNumber sgt_baan_buiten_ov_te_keurenField;
		private CrmNumber sgt_baan_buiten_te_keurenField;
		private Picklist sgt_beveiligingField;
		private string sgt_bezoekadres_gemeenteField;
		private string sgt_bezoekadres_huisnummerField;
		private string sgt_bezoekadres_plaatsField;
		private string sgt_bezoekadres_postcodeField;
		private string sgt_bezoekadres_straatField;
		private string sgt_bezoekadres_toevoegingField;
		private Lookup sgt_bezoekadreslandcodeidField;
		private string sgt_bezoekadreslandcodeid_naamField;
		private CrmBoolean sgt_blaashalField;
		private Lookup sgt_bouwaardidField;
		private string sgt_bouwjaar_clubhuisField;
		private string sgt_bouwjaar_halField;
		private Lookup sgt_dagelijksonderhoudbanenidField;
		private string sgt_dagelijksonderhoudbanenid_naamField;
		private CrmBoolean sgt_digitaal_afhangenField;
		private Lookup sgt_districtidField;
		private Lookup sgt_eigenaar_grondidField;
		private string sgt_eigenaar_grondid_naamField;
		private Lookup sgt_eigenaaraccidField;
		private string sgt_eigenaaraccid_naamField;
		private Lookup sgt_eigenaaridField;
		private Lookup sgt_eigenaarlichtinstallatieidField;
		private string sgt_eigenaarlichtinstallatieid_naamField;
		private Lookup sgt_eigendom_overkappingidField;
		private Lookup sgt_eigendomclubhuisidField;
		private Lookup sgt_eigendomhalidField;
		private string sgt_emailField;
		private Lookup sgt_exploitantidField;
		private string sgt_faxField;
		private Picklist sgt_import_exportField;
		private Lookup sgt_jaarlijksonderhoudbanenidField;
		private string sgt_jaarlijksonderhoudbanenid_naamField;
		private Lookup sgt_liggingidField;
		private string sgt_liggingid_naamField;
		private CrmNumber sgt_m2_clubhuisField;
		private CrmNumber sgt_m2_ehbo_fysioField;
		private CrmNumber sgt_m2_ehbo_fysio_clubhuisField;
		private CrmNumber sgt_m2_halField;
		private CrmNumber sgt_m2_kantineField;
		private CrmNumber sgt_m2_kantine_clubhuisField;
		private CrmNumber sgt_m2_kleed_wasField;
		private CrmNumber sgt_m2_kleed_was_clubhuisField;
		private CrmNumber sgt_m2_verg_wed_ruimtesField;
		private CrmNumber sgt_m2_verg_wed_ruimtes_clubhuisField;
		private CrmBoolean sgt_ov_bereikbaarField;
		private CrmBoolean sgt_overkappingField;
		private Lookup sgt_pb_interface_logboek_export_xmlidField;
		private Lookup sgt_pb_interface_logboek_import_xmlidField;
		private Lookup sgt_pb_interface_logboekidField;
		private string sgt_postadres_gemeenteField;
		private string sgt_postadres_huisnummerField;
		private string sgt_postadres_plaatsField;
		private string sgt_postadres_postcodeField;
		private string sgt_postadres_straatField;
		private string sgt_postadres_toevoegingField;
		private Lookup sgt_postadreslandcodeidField;
		private string sgt_postadreslandcodeid_naamField;
		private Lookup sgt_regioidField;
		private CrmBoolean sgt_rolstoeltoegankelijkField;
		private Picklist sgt_soort_blaashalField;
		private Picklist sgt_soort_overkappingField;
		private Lookup sgt_soortverlichtingidField;
		private string sgt_telefoonField;
		private CrmNumber sgt_toiletten_mindervaliden_clubhuisField;
		private Lookup sgt_verenigingidField;
		private string sgt_verenigingsnummerField;
		private string sgt_volgnummerField;
		private string sgt_websiteField;
		private Sgt_alg_pb_mutatie_accommodatiesStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
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
		public CrmNumber sgt_aantal_ehbo_fysio_ruimtes
		{
			get
			{
				return this.sgt_aantal_ehbo_fysio_ruimtesField;
			}
			set
			{
				this.sgt_aantal_ehbo_fysio_ruimtesField = value;
			}
		}
		public CrmNumber sgt_aantal_ehbo_fysio_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_ehbo_fysio_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_ehbo_fysio_ruimtes_clubhuisField = value;
			}
		}
		public CrmNumber sgt_aantal_kleed_wasruimtes
		{
			get
			{
				return this.sgt_aantal_kleed_wasruimtesField;
			}
			set
			{
				this.sgt_aantal_kleed_wasruimtesField = value;
			}
		}
		public CrmNumber sgt_aantal_kleed_wasruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_kleed_wasruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_kleed_wasruimtes_clubhuisField = value;
			}
		}
		public CrmNumber sgt_aantal_minibanen
		{
			get
			{
				return this.sgt_aantal_minibanenField;
			}
			set
			{
				this.sgt_aantal_minibanenField = value;
			}
		}
		public CrmNumber sgt_aantal_mv_parkeerplaatsen
		{
			get
			{
				return this.sgt_aantal_mv_parkeerplaatsenField;
			}
			set
			{
				this.sgt_aantal_mv_parkeerplaatsenField = value;
			}
		}
		public CrmNumber sgt_aantal_oefenmuren
		{
			get
			{
				return this.sgt_aantal_oefenmurenField;
			}
			set
			{
				this.sgt_aantal_oefenmurenField = value;
			}
		}
		public CrmNumber sgt_aantal_parkeerplaatsen
		{
			get
			{
				return this.sgt_aantal_parkeerplaatsenField;
			}
			set
			{
				this.sgt_aantal_parkeerplaatsenField = value;
			}
		}
		public CrmNumber sgt_aantal_playgrounds
		{
			get
			{
				return this.sgt_aantal_playgroundsField;
			}
			set
			{
				this.sgt_aantal_playgroundsField = value;
			}
		}
		public CrmNumber sgt_aantal_toiletten_clubhuis
		{
			get
			{
				return this.sgt_aantal_toiletten_clubhuisField;
			}
			set
			{
				this.sgt_aantal_toiletten_clubhuisField = value;
			}
		}
		public CrmNumber sgt_aantal_verg_wed_ruimtes
		{
			get
			{
				return this.sgt_aantal_verg_wed_ruimtesField;
			}
			set
			{
				this.sgt_aantal_verg_wed_ruimtesField = value;
			}
		}
		public CrmNumber sgt_aantal_verg_wed_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_verg_wed_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_verg_wed_ruimtes_clubhuisField = value;
			}
		}
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
			}
		}
		public string sgt_accommodatienaam
		{
			get
			{
				return this.sgt_accommodatienaamField;
			}
			set
			{
				this.sgt_accommodatienaamField = value;
			}
		}
		public Key sgt_alg_pb_mutatie_accommodatiesid
		{
			get
			{
				return this.sgt_alg_pb_mutatie_accommodatiesidField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_accommodatiesidField = value;
			}
		}
		public CrmNumber sgt_baan_binnen
		{
			get
			{
				return this.sgt_baan_binnenField;
			}
			set
			{
				this.sgt_baan_binnenField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_afgekeurd
		{
			get
			{
				return this.sgt_baan_binnen_afgekeurdField;
			}
			set
			{
				this.sgt_baan_binnen_afgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_dispensatie
		{
			get
			{
				return this.sgt_baan_binnen_dispensatieField;
			}
			set
			{
				this.sgt_baan_binnen_dispensatieField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_goedgekeurd
		{
			get
			{
				return this.sgt_baan_binnen_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_binnen_goedgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_te_keuren
		{
			get
			{
				return this.sgt_baan_binnen_te_keurenField;
			}
			set
			{
				this.sgt_baan_binnen_te_keurenField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal
		{
			get
			{
				return this.sgt_baan_blaashalField;
			}
			set
			{
				this.sgt_baan_blaashalField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_afgekeurd
		{
			get
			{
				return this.sgt_baan_blaashal_afgekeurdField;
			}
			set
			{
				this.sgt_baan_blaashal_afgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_dispensatie
		{
			get
			{
				return this.sgt_baan_blaashal_dispensatieField;
			}
			set
			{
				this.sgt_baan_blaashal_dispensatieField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_goedgekeurd
		{
			get
			{
				return this.sgt_baan_blaashal_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_blaashal_goedgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_te_keuren
		{
			get
			{
				return this.sgt_baan_blaashal_te_keurenField;
			}
			set
			{
				this.sgt_baan_blaashal_te_keurenField = value;
			}
		}
		public CrmNumber sgt_baan_buiten
		{
			get
			{
				return this.sgt_baan_buitenField;
			}
			set
			{
				this.sgt_baan_buitenField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_afgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_afgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_afgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_dispensatie
		{
			get
			{
				return this.sgt_baan_buiten_dispensatieField;
			}
			set
			{
				this.sgt_baan_buiten_dispensatieField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_goedgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_goedgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov
		{
			get
			{
				return this.sgt_baan_buiten_ovField;
			}
			set
			{
				this.sgt_baan_buiten_ovField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_afgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_ov_afgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_ov_afgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_dispensatie
		{
			get
			{
				return this.sgt_baan_buiten_ov_dispensatieField;
			}
			set
			{
				this.sgt_baan_buiten_ov_dispensatieField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_goedgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_ov_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_ov_goedgekeurdField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_te_keuren
		{
			get
			{
				return this.sgt_baan_buiten_ov_te_keurenField;
			}
			set
			{
				this.sgt_baan_buiten_ov_te_keurenField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_te_keuren
		{
			get
			{
				return this.sgt_baan_buiten_te_keurenField;
			}
			set
			{
				this.sgt_baan_buiten_te_keurenField = value;
			}
		}
		public Picklist sgt_beveiliging
		{
			get
			{
				return this.sgt_beveiligingField;
			}
			set
			{
				this.sgt_beveiligingField = value;
			}
		}
		public string sgt_bezoekadres_gemeente
		{
			get
			{
				return this.sgt_bezoekadres_gemeenteField;
			}
			set
			{
				this.sgt_bezoekadres_gemeenteField = value;
			}
		}
		public string sgt_bezoekadres_huisnummer
		{
			get
			{
				return this.sgt_bezoekadres_huisnummerField;
			}
			set
			{
				this.sgt_bezoekadres_huisnummerField = value;
			}
		}
		public string sgt_bezoekadres_plaats
		{
			get
			{
				return this.sgt_bezoekadres_plaatsField;
			}
			set
			{
				this.sgt_bezoekadres_plaatsField = value;
			}
		}
		public string sgt_bezoekadres_postcode
		{
			get
			{
				return this.sgt_bezoekadres_postcodeField;
			}
			set
			{
				this.sgt_bezoekadres_postcodeField = value;
			}
		}
		public string sgt_bezoekadres_straat
		{
			get
			{
				return this.sgt_bezoekadres_straatField;
			}
			set
			{
				this.sgt_bezoekadres_straatField = value;
			}
		}
		public string sgt_bezoekadres_toevoeging
		{
			get
			{
				return this.sgt_bezoekadres_toevoegingField;
			}
			set
			{
				this.sgt_bezoekadres_toevoegingField = value;
			}
		}
		public Lookup sgt_bezoekadreslandcodeid
		{
			get
			{
				return this.sgt_bezoekadreslandcodeidField;
			}
			set
			{
				this.sgt_bezoekadreslandcodeidField = value;
			}
		}
		public string sgt_bezoekadreslandcodeid_naam
		{
			get
			{
				return this.sgt_bezoekadreslandcodeid_naamField;
			}
			set
			{
				this.sgt_bezoekadreslandcodeid_naamField = value;
			}
		}
		public CrmBoolean sgt_blaashal
		{
			get
			{
				return this.sgt_blaashalField;
			}
			set
			{
				this.sgt_blaashalField = value;
			}
		}
		public Lookup sgt_bouwaardid
		{
			get
			{
				return this.sgt_bouwaardidField;
			}
			set
			{
				this.sgt_bouwaardidField = value;
			}
		}
		public string sgt_bouwjaar_clubhuis
		{
			get
			{
				return this.sgt_bouwjaar_clubhuisField;
			}
			set
			{
				this.sgt_bouwjaar_clubhuisField = value;
			}
		}
		public string sgt_bouwjaar_hal
		{
			get
			{
				return this.sgt_bouwjaar_halField;
			}
			set
			{
				this.sgt_bouwjaar_halField = value;
			}
		}
		public Lookup sgt_dagelijksonderhoudbanenid
		{
			get
			{
				return this.sgt_dagelijksonderhoudbanenidField;
			}
			set
			{
				this.sgt_dagelijksonderhoudbanenidField = value;
			}
		}
		public string sgt_dagelijksonderhoudbanenid_naam
		{
			get
			{
				return this.sgt_dagelijksonderhoudbanenid_naamField;
			}
			set
			{
				this.sgt_dagelijksonderhoudbanenid_naamField = value;
			}
		}
		public CrmBoolean sgt_digitaal_afhangen
		{
			get
			{
				return this.sgt_digitaal_afhangenField;
			}
			set
			{
				this.sgt_digitaal_afhangenField = value;
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
		public Lookup sgt_eigenaar_grondid
		{
			get
			{
				return this.sgt_eigenaar_grondidField;
			}
			set
			{
				this.sgt_eigenaar_grondidField = value;
			}
		}
		public string sgt_eigenaar_grondid_naam
		{
			get
			{
				return this.sgt_eigenaar_grondid_naamField;
			}
			set
			{
				this.sgt_eigenaar_grondid_naamField = value;
			}
		}
		public Lookup sgt_eigenaaraccid
		{
			get
			{
				return this.sgt_eigenaaraccidField;
			}
			set
			{
				this.sgt_eigenaaraccidField = value;
			}
		}
		public string sgt_eigenaaraccid_naam
		{
			get
			{
				return this.sgt_eigenaaraccid_naamField;
			}
			set
			{
				this.sgt_eigenaaraccid_naamField = value;
			}
		}
		public Lookup sgt_eigenaarid
		{
			get
			{
				return this.sgt_eigenaaridField;
			}
			set
			{
				this.sgt_eigenaaridField = value;
			}
		}
		public Lookup sgt_eigenaarlichtinstallatieid
		{
			get
			{
				return this.sgt_eigenaarlichtinstallatieidField;
			}
			set
			{
				this.sgt_eigenaarlichtinstallatieidField = value;
			}
		}
		public string sgt_eigenaarlichtinstallatieid_naam
		{
			get
			{
				return this.sgt_eigenaarlichtinstallatieid_naamField;
			}
			set
			{
				this.sgt_eigenaarlichtinstallatieid_naamField = value;
			}
		}
		public Lookup sgt_eigendom_overkappingid
		{
			get
			{
				return this.sgt_eigendom_overkappingidField;
			}
			set
			{
				this.sgt_eigendom_overkappingidField = value;
			}
		}
		public Lookup sgt_eigendomclubhuisid
		{
			get
			{
				return this.sgt_eigendomclubhuisidField;
			}
			set
			{
				this.sgt_eigendomclubhuisidField = value;
			}
		}
		public Lookup sgt_eigendomhalid
		{
			get
			{
				return this.sgt_eigendomhalidField;
			}
			set
			{
				this.sgt_eigendomhalidField = value;
			}
		}
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
			}
		}
		public Lookup sgt_exploitantid
		{
			get
			{
				return this.sgt_exploitantidField;
			}
			set
			{
				this.sgt_exploitantidField = value;
			}
		}
		public string sgt_fax
		{
			get
			{
				return this.sgt_faxField;
			}
			set
			{
				this.sgt_faxField = value;
			}
		}
		public Picklist sgt_import_export
		{
			get
			{
				return this.sgt_import_exportField;
			}
			set
			{
				this.sgt_import_exportField = value;
			}
		}
		public Lookup sgt_jaarlijksonderhoudbanenid
		{
			get
			{
				return this.sgt_jaarlijksonderhoudbanenidField;
			}
			set
			{
				this.sgt_jaarlijksonderhoudbanenidField = value;
			}
		}
		public string sgt_jaarlijksonderhoudbanenid_naam
		{
			get
			{
				return this.sgt_jaarlijksonderhoudbanenid_naamField;
			}
			set
			{
				this.sgt_jaarlijksonderhoudbanenid_naamField = value;
			}
		}
		public Lookup sgt_liggingid
		{
			get
			{
				return this.sgt_liggingidField;
			}
			set
			{
				this.sgt_liggingidField = value;
			}
		}
		public string sgt_liggingid_naam
		{
			get
			{
				return this.sgt_liggingid_naamField;
			}
			set
			{
				this.sgt_liggingid_naamField = value;
			}
		}
		public CrmNumber sgt_m2_clubhuis
		{
			get
			{
				return this.sgt_m2_clubhuisField;
			}
			set
			{
				this.sgt_m2_clubhuisField = value;
			}
		}
		public CrmNumber sgt_m2_ehbo_fysio
		{
			get
			{
				return this.sgt_m2_ehbo_fysioField;
			}
			set
			{
				this.sgt_m2_ehbo_fysioField = value;
			}
		}
		public CrmNumber sgt_m2_ehbo_fysio_clubhuis
		{
			get
			{
				return this.sgt_m2_ehbo_fysio_clubhuisField;
			}
			set
			{
				this.sgt_m2_ehbo_fysio_clubhuisField = value;
			}
		}
		public CrmNumber sgt_m2_hal
		{
			get
			{
				return this.sgt_m2_halField;
			}
			set
			{
				this.sgt_m2_halField = value;
			}
		}
		public CrmNumber sgt_m2_kantine
		{
			get
			{
				return this.sgt_m2_kantineField;
			}
			set
			{
				this.sgt_m2_kantineField = value;
			}
		}
		public CrmNumber sgt_m2_kantine_clubhuis
		{
			get
			{
				return this.sgt_m2_kantine_clubhuisField;
			}
			set
			{
				this.sgt_m2_kantine_clubhuisField = value;
			}
		}
		public CrmNumber sgt_m2_kleed_was
		{
			get
			{
				return this.sgt_m2_kleed_wasField;
			}
			set
			{
				this.sgt_m2_kleed_wasField = value;
			}
		}
		public CrmNumber sgt_m2_kleed_was_clubhuis
		{
			get
			{
				return this.sgt_m2_kleed_was_clubhuisField;
			}
			set
			{
				this.sgt_m2_kleed_was_clubhuisField = value;
			}
		}
		public CrmNumber sgt_m2_verg_wed_ruimtes
		{
			get
			{
				return this.sgt_m2_verg_wed_ruimtesField;
			}
			set
			{
				this.sgt_m2_verg_wed_ruimtesField = value;
			}
		}
		public CrmNumber sgt_m2_verg_wed_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_m2_verg_wed_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_m2_verg_wed_ruimtes_clubhuisField = value;
			}
		}
		public CrmBoolean sgt_ov_bereikbaar
		{
			get
			{
				return this.sgt_ov_bereikbaarField;
			}
			set
			{
				this.sgt_ov_bereikbaarField = value;
			}
		}
		public CrmBoolean sgt_overkapping
		{
			get
			{
				return this.sgt_overkappingField;
			}
			set
			{
				this.sgt_overkappingField = value;
			}
		}
		public Lookup sgt_pb_interface_logboek_export_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_export_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_export_xmlidField = value;
			}
		}
		public Lookup sgt_pb_interface_logboek_import_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_import_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_import_xmlidField = value;
			}
		}
		public Lookup sgt_pb_interface_logboekid
		{
			get
			{
				return this.sgt_pb_interface_logboekidField;
			}
			set
			{
				this.sgt_pb_interface_logboekidField = value;
			}
		}
		public string sgt_postadres_gemeente
		{
			get
			{
				return this.sgt_postadres_gemeenteField;
			}
			set
			{
				this.sgt_postadres_gemeenteField = value;
			}
		}
		public string sgt_postadres_huisnummer
		{
			get
			{
				return this.sgt_postadres_huisnummerField;
			}
			set
			{
				this.sgt_postadres_huisnummerField = value;
			}
		}
		public string sgt_postadres_plaats
		{
			get
			{
				return this.sgt_postadres_plaatsField;
			}
			set
			{
				this.sgt_postadres_plaatsField = value;
			}
		}
		public string sgt_postadres_postcode
		{
			get
			{
				return this.sgt_postadres_postcodeField;
			}
			set
			{
				this.sgt_postadres_postcodeField = value;
			}
		}
		public string sgt_postadres_straat
		{
			get
			{
				return this.sgt_postadres_straatField;
			}
			set
			{
				this.sgt_postadres_straatField = value;
			}
		}
		public string sgt_postadres_toevoeging
		{
			get
			{
				return this.sgt_postadres_toevoegingField;
			}
			set
			{
				this.sgt_postadres_toevoegingField = value;
			}
		}
		public Lookup sgt_postadreslandcodeid
		{
			get
			{
				return this.sgt_postadreslandcodeidField;
			}
			set
			{
				this.sgt_postadreslandcodeidField = value;
			}
		}
		public string sgt_postadreslandcodeid_naam
		{
			get
			{
				return this.sgt_postadreslandcodeid_naamField;
			}
			set
			{
				this.sgt_postadreslandcodeid_naamField = value;
			}
		}
		public Lookup sgt_regioid
		{
			get
			{
				return this.sgt_regioidField;
			}
			set
			{
				this.sgt_regioidField = value;
			}
		}
		public CrmBoolean sgt_rolstoeltoegankelijk
		{
			get
			{
				return this.sgt_rolstoeltoegankelijkField;
			}
			set
			{
				this.sgt_rolstoeltoegankelijkField = value;
			}
		}
		public Picklist sgt_soort_blaashal
		{
			get
			{
				return this.sgt_soort_blaashalField;
			}
			set
			{
				this.sgt_soort_blaashalField = value;
			}
		}
		public Picklist sgt_soort_overkapping
		{
			get
			{
				return this.sgt_soort_overkappingField;
			}
			set
			{
				this.sgt_soort_overkappingField = value;
			}
		}
		public Lookup sgt_soortverlichtingid
		{
			get
			{
				return this.sgt_soortverlichtingidField;
			}
			set
			{
				this.sgt_soortverlichtingidField = value;
			}
		}
		public string sgt_telefoon
		{
			get
			{
				return this.sgt_telefoonField;
			}
			set
			{
				this.sgt_telefoonField = value;
			}
		}
		public CrmNumber sgt_toiletten_mindervaliden_clubhuis
		{
			get
			{
				return this.sgt_toiletten_mindervaliden_clubhuisField;
			}
			set
			{
				this.sgt_toiletten_mindervaliden_clubhuisField = value;
			}
		}
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
			}
		}
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
			}
		}
		public string sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
			}
		}
		public string sgt_website
		{
			get
			{
				return this.sgt_websiteField;
			}
			set
			{
				this.sgt_websiteField = value;
			}
		}
		public Sgt_alg_pb_mutatie_accommodatiesStateInfo statecode
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
	}
}
