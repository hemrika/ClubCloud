using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_accommodatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_banen_binnenField;
		private CrmNumber sgt_aantal_banen_buitenField;
		private CrmNumber sgt_aantal_douches_damesField;
		private CrmNumber sgt_aantal_douches_dames_clubhuisField;
		private CrmNumber sgt_aantal_douches_herenField;
		private CrmNumber sgt_aantal_douches_heren_clubhuisField;
		private CrmNumber sgt_aantal_ehbo_fysio_ruimtesField;
		private CrmNumber sgt_aantal_ehbo_fysio_ruimtes_clubhuisField;
		private CrmNumber sgt_aantal_fysio_ruimtesField;
		private CrmNumber sgt_aantal_fysio_ruimtes_clubhuisField;
		private CrmNumber sgt_aantal_kleed_wasruimtesField;
		private CrmNumber sgt_aantal_kleed_wasruimtes_clubhuisField;
		private CrmNumber sgt_aantal_kleedruimte_damesField;
		private CrmNumber sgt_aantal_kleedruimtes_dames_clubhuisField;
		private CrmNumber sgt_aantal_minibanenField;
		private CrmNumber sgt_aantal_mv_parkeerplaatsenField;
		private CrmNumber sgt_aantal_oefenmurenField;
		private CrmNumber sgt_aantal_oranje_banenField;
		private CrmNumber sgt_aantal_parkeerplaatsenField;
		private CrmNumber sgt_aantal_playgroundsField;
		private CrmNumber sgt_aantal_rode_banenField;
		private CrmNumber sgt_aantal_toilettenField;
		private CrmNumber sgt_aantal_toiletten_clubhuisField;
		private CrmNumber sgt_aantal_toiletten_damesField;
		private CrmNumber sgt_aantal_toiletten_dames_clubhuisField;
		private CrmNumber sgt_aantal_verg_wed_ruimtesField;
		private CrmNumber sgt_aantal_verg_wed_ruimtes_clubhuisField;
		private CrmNumber sgt_aantal_wasruimtes_clubhuisField;
		private CrmNumber sgt_aantal_wasruimtes_damesField;
		private CrmNumber sgt_aantal_wasruimtes_dames_clubhuisField;
		private CrmNumber sgt_aantal_wasruimtes_herenField;
		private CrmNumber sgt_aantal_wedstrijdruimtesField;
		private CrmNumber sgt_aantal_wedstrijdruimtes_clubhuisField;
		private string sgt_alg_accommodatie1Field;
		private Key sgt_alg_accommodatieidField;
		private CrmNumber sgt_baan_binnenField;
		private CrmNumber sgt_baan_binnen_afgekeurdField;
		private CrmNumber sgt_baan_binnen_afgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_binnen_afgekeurd_verlichtField;
		private CrmNumber sgt_baan_binnen_dispensatieField;
		private CrmNumber sgt_baan_binnen_dispensatie_niet_verlichtField;
		private CrmNumber sgt_baan_binnen_dispensatie_verlichtField;
		private CrmNumber sgt_baan_binnen_goedgekeurdField;
		private CrmNumber sgt_baan_binnen_goedgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_binnen_goedgekeurd_verlichtField;
		private CrmNumber sgt_baan_binnen_te_keurenField;
		private CrmNumber sgt_baan_binnen_te_keuren_niet_verlichtField;
		private CrmNumber sgt_baan_binnen_te_keuren_verlichtField;
		private CrmNumber sgt_baan_blaashalField;
		private CrmNumber sgt_baan_blaashal_afgekeurdField;
		private CrmNumber sgt_baan_blaashal_afgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_blaashal_afgekeurd_verlichtField;
		private CrmNumber sgt_baan_blaashal_dispensatieField;
		private CrmNumber sgt_baan_blaashal_dispensatie_niet_verlichtField;
		private CrmNumber sgt_baan_blaashal_dispensatie_verlichtField;
		private CrmNumber sgt_baan_blaashal_goedgekeurdField;
		private CrmNumber sgt_baan_blaashal_goedgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_blaashal_goedgekeurd_verlichtField;
		private CrmNumber sgt_baan_blaashal_te_keurenField;
		private CrmNumber sgt_baan_blaashal_te_keuren_niet_verlichtField;
		private CrmNumber sgt_baan_blaashal_te_keuren_verlichtField;
		private CrmNumber sgt_baan_buitenField;
		private CrmNumber sgt_baan_buiten_afgekeurdField;
		private CrmNumber sgt_baan_buiten_afgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_afgekeurd_verlichtField;
		private CrmNumber sgt_baan_buiten_dispensatieField;
		private CrmNumber sgt_baan_buiten_dispensatie_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_dispensatie_verlichtField;
		private CrmNumber sgt_baan_buiten_goedgekeurdField;
		private CrmNumber sgt_baan_buiten_goedgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_goedgekeurd_verlichtField;
		private CrmNumber sgt_baan_buiten_ovField;
		private CrmNumber sgt_baan_buiten_ov_afgekeurdField;
		private CrmNumber sgt_baan_buiten_ov_afgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_ov_afgekeurd_verlichtField;
		private CrmNumber sgt_baan_buiten_ov_dispensatieField;
		private CrmNumber sgt_baan_buiten_ov_dispensatie_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_ov_dispensatie_verlichtField;
		private CrmNumber sgt_baan_buiten_ov_goedgekeurdField;
		private CrmNumber sgt_baan_buiten_ov_goedgekeurd_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_ov_goedgekeurd_verlichtField;
		private CrmNumber sgt_baan_buiten_ov_te_keurenField;
		private CrmNumber sgt_baan_buiten_ov_te_keuren_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_ov_te_keuren_verlichtField;
		private CrmNumber sgt_baan_buiten_te_keurenField;
		private CrmNumber sgt_baan_buiten_te_keuren_niet_verlichtField;
		private CrmNumber sgt_baan_buiten_te_keuren_verlichtField;
		private Picklist sgt_beveiligingField;
		private string sgt_bezoekadres_gemeenteField;
		private string sgt_bezoekadres_huisnummerField;
		private string sgt_bezoekadres_plaatsField;
		private string sgt_bezoekadres_postcodeField;
		private string sgt_bezoekadres_straatField;
		private string sgt_bezoekadres_toevoegingField;
		private Lookup sgt_bezoekadreslandcodeidField;
		private CrmBoolean sgt_blaashalField;
		private Lookup sgt_bouwaardidField;
		private string sgt_bouwjaar_clubhuisField;
		private string sgt_bouwjaar_halField;
		private Lookup sgt_dagelijksonderhoudbanenidField;
		private CrmDateTime sgt_datum_keuring_clubhuisField;
		private CrmDateTime sgt_datum_keuring_halField;
		private CrmBoolean sgt_digitaal_afhangenField;
		private Lookup sgt_districtidField;
		private CrmBoolean sgt_ehbo_ruimteField;
		private CrmBoolean sgt_ehbo_ruimtes_clubhuisField;
		private Lookup sgt_eigenaar_grondidField;
		private Lookup sgt_eigenaaraccidField;
		private Lookup sgt_eigenaaridField;
		private Lookup sgt_eigenaarlichtinstallatieidField;
		private Lookup sgt_eigendom_overkappingidField;
		private Lookup sgt_eigendomclubhuisidField;
		private Lookup sgt_eigendomhalidField;
		private string sgt_emailField;
		private Lookup sgt_exploitantidField;
		private string sgt_faxField;
		private CrmBoolean sgt_fysio_ruimteField;
		private CrmBoolean sgt_fysio_ruimte_clubhuisField;
		private Lookup sgt_gekeurddooridField;
		private Lookup sgt_hal_gekeurd_dooridField;
		private Lookup sgt_jaarlijksonderhoudbanenidField;
		private CrmBoolean sgt_jeugdhonkField;
		private CrmBoolean sgt_jeugdhonk_clubhuisField;
		private CrmBoolean sgt_kantineField;
		private CrmBoolean sgt_kantine_clubhuisField;
		private CrmBoolean sgt_keukenField;
		private CrmBoolean sgt_keuken_clubhuisField;
		private Picklist sgt_klasse_halField;
		private CrmBoolean sgt_kleedruimteField;
		private CrmBoolean sgt_kleedruimte_clubhuisField;
		private CrmBoolean sgt_kleedruimte_damesField;
		private CrmBoolean sgt_kleedruimte_dames_clubhuisField;
		private Picklist sgt_lichtpuntsterkte_halField;
		private Lookup sgt_liggingidField;
		private CrmNumber sgt_m2_clubhuisField;
		private CrmNumber sgt_m2_ehbo_fysioField;
		private CrmNumber sgt_m2_ehbo_fysio_clubhuisField;
		private CrmNumber sgt_m2_fysio_ruimteField;
		private CrmNumber sgt_m2_fysio_ruimte_clubhuisField;
		private CrmNumber sgt_m2_halField;
		private CrmNumber sgt_m2_kantineField;
		private CrmNumber sgt_m2_kantine_clubhuisField;
		private CrmNumber sgt_m2_keukenField;
		private CrmNumber sgt_m2_keuken_clubhuisField;
		private CrmNumber sgt_m2_kleed_dames_clubhuisField;
		private CrmNumber sgt_m2_kleed_wasField;
		private CrmNumber sgt_m2_kleed_was_clubhuisField;
		private CrmNumber sgt_m2_kleedruimte_damesField;
		private CrmNumber sgt_m2_verg_wed_ruimtesField;
		private CrmNumber sgt_m2_verg_wed_ruimtes_clubhuisField;
		private CrmNumber sgt_m2_was_clubhuisField;
		private CrmNumber sgt_m2_was_dames_clubhuisField;
		private CrmNumber sgt_m2_wasruimte_damesField;
		private CrmNumber sgt_m2_wasruimte_herenField;
		private CrmNumber sgt_m2_wedstrijdruimteField;
		private CrmNumber sgt_m2_wedstrijdruimte_clubhuisField;
		private CrmBoolean sgt_minibanenField;
		private CrmBoolean sgt_oefenmurenField;
		private CrmBoolean sgt_ov_bereikbaarField;
		private CrmBoolean sgt_overkappingField;
		private CrmBoolean sgt_playgroundsField;
		private string sgt_postadres_gemeenteField;
		private string sgt_postadres_huisnummerField;
		private string sgt_postadres_plaatsField;
		private string sgt_postadres_postcodeField;
		private string sgt_postadres_straatField;
		private string sgt_postadres_toevoegingField;
		private Lookup sgt_postadreslandcodeidField;
		private Lookup sgt_regioidField;
		private CrmBoolean sgt_rolstoeltoegankelijkField;
		private Picklist sgt_soort_blaashalField;
		private Picklist sgt_soort_overkappingField;
		private Lookup sgt_soortverlichtingidField;
		private CrmBoolean sgt_speeltoestellenField;
		private Picklist sgt_status_clubhuisField;
		private Picklist sgt_status_halField;
		private string sgt_telefoonField;
		private CrmBoolean sgt_tenniskids_huisstijlField;
		private CrmNumber sgt_toiletten_mindervalidenField;
		private CrmNumber sgt_toiletten_mindervaliden_clubhuisField;
		private Lookup sgt_toplaag_minibanenidField;
		private Lookup sgt_toplaag_oefenmurenidField;
		private Lookup sgt_toplaag_playgroundidField;
		private CrmNumber sgt_totaal_aanta_lbaanblokkenField;
		private CrmNumber sgt_totaal_aantal_banenField;
		private CrmBoolean sgt_vergaderruimteField;
		private CrmBoolean sgt_vergaderruimte_clubhuisField;
		private CrmBoolean sgt_wasruimteField;
		private CrmBoolean sgt_wasruimte_clubhuisField;
		private CrmBoolean sgt_wasruimte_damesField;
		private CrmBoolean sgt_wasruimte_dames_clubhuisField;
		private string sgt_websiteField;
		private CrmBoolean sgt_wedstrijdruimteField;
		private CrmBoolean sgt_wedstrijdruimte_clubhuisField;
		private Sgt_alg_accommodatieStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_banen_binnen
		{
			get
			{
				return this.sgt_aantal_banen_binnenField;
			}
			set
			{
				this.sgt_aantal_banen_binnenField = value;
			}
		}
		public CrmNumber sgt_aantal_banen_buiten
		{
			get
			{
				return this.sgt_aantal_banen_buitenField;
			}
			set
			{
				this.sgt_aantal_banen_buitenField = value;
			}
		}
		public CrmNumber sgt_aantal_douches_dames
		{
			get
			{
				return this.sgt_aantal_douches_damesField;
			}
			set
			{
				this.sgt_aantal_douches_damesField = value;
			}
		}
		public CrmNumber sgt_aantal_douches_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_douches_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_douches_dames_clubhuisField = value;
			}
		}
		public CrmNumber sgt_aantal_douches_heren
		{
			get
			{
				return this.sgt_aantal_douches_herenField;
			}
			set
			{
				this.sgt_aantal_douches_herenField = value;
			}
		}
		public CrmNumber sgt_aantal_douches_heren_clubhuis
		{
			get
			{
				return this.sgt_aantal_douches_heren_clubhuisField;
			}
			set
			{
				this.sgt_aantal_douches_heren_clubhuisField = value;
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
		public CrmNumber sgt_aantal_fysio_ruimtes
		{
			get
			{
				return this.sgt_aantal_fysio_ruimtesField;
			}
			set
			{
				this.sgt_aantal_fysio_ruimtesField = value;
			}
		}
		public CrmNumber sgt_aantal_fysio_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_fysio_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_fysio_ruimtes_clubhuisField = value;
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
		public CrmNumber sgt_aantal_kleedruimte_dames
		{
			get
			{
				return this.sgt_aantal_kleedruimte_damesField;
			}
			set
			{
				this.sgt_aantal_kleedruimte_damesField = value;
			}
		}
		public CrmNumber sgt_aantal_kleedruimtes_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_kleedruimtes_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_kleedruimtes_dames_clubhuisField = value;
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
		public CrmNumber sgt_aantal_oranje_banen
		{
			get
			{
				return this.sgt_aantal_oranje_banenField;
			}
			set
			{
				this.sgt_aantal_oranje_banenField = value;
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
		public CrmNumber sgt_aantal_rode_banen
		{
			get
			{
				return this.sgt_aantal_rode_banenField;
			}
			set
			{
				this.sgt_aantal_rode_banenField = value;
			}
		}
		public CrmNumber sgt_aantal_toiletten
		{
			get
			{
				return this.sgt_aantal_toilettenField;
			}
			set
			{
				this.sgt_aantal_toilettenField = value;
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
		public CrmNumber sgt_aantal_toiletten_dames
		{
			get
			{
				return this.sgt_aantal_toiletten_damesField;
			}
			set
			{
				this.sgt_aantal_toiletten_damesField = value;
			}
		}
		public CrmNumber sgt_aantal_toiletten_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_toiletten_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_toiletten_dames_clubhuisField = value;
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
		public CrmNumber sgt_aantal_wasruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_wasruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_clubhuisField = value;
			}
		}
		public CrmNumber sgt_aantal_wasruimtes_dames
		{
			get
			{
				return this.sgt_aantal_wasruimtes_damesField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_damesField = value;
			}
		}
		public CrmNumber sgt_aantal_wasruimtes_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_wasruimtes_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_dames_clubhuisField = value;
			}
		}
		public CrmNumber sgt_aantal_wasruimtes_heren
		{
			get
			{
				return this.sgt_aantal_wasruimtes_herenField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_herenField = value;
			}
		}
		public CrmNumber sgt_aantal_wedstrijdruimtes
		{
			get
			{
				return this.sgt_aantal_wedstrijdruimtesField;
			}
			set
			{
				this.sgt_aantal_wedstrijdruimtesField = value;
			}
		}
		public CrmNumber sgt_aantal_wedstrijdruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_wedstrijdruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_wedstrijdruimtes_clubhuisField = value;
			}
		}
		[XmlElement("sgt_alg_accommodatie")]
		public string sgt_alg_accommodatie1
		{
			get
			{
				return this.sgt_alg_accommodatie1Field;
			}
			set
			{
				this.sgt_alg_accommodatie1Field = value;
			}
		}
		public Key sgt_alg_accommodatieid
		{
			get
			{
				return this.sgt_alg_accommodatieidField;
			}
			set
			{
				this.sgt_alg_accommodatieidField = value;
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
		public CrmNumber sgt_baan_binnen_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_afgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_afgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_binnen_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_dispensatie_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_dispensatie_verlichtField = value;
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
		public CrmNumber sgt_baan_binnen_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_goedgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_goedgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_binnen_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_te_keuren_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_binnen_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_te_keuren_verlichtField = value;
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
		public CrmNumber sgt_baan_blaashal_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_afgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_afgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_blaashal_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_dispensatie_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_dispensatie_verlichtField = value;
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
		public CrmNumber sgt_baan_blaashal_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_goedgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_goedgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_blaashal_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_te_keuren_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_blaashal_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_te_keuren_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_afgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_afgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_dispensatie_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_dispensatie_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_goedgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_goedgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_ov_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_afgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_afgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_ov_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_dispensatie_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_dispensatie_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_ov_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_goedgekeurd_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_goedgekeurd_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_ov_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_te_keuren_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_ov_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_te_keuren_verlichtField = value;
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
		public CrmNumber sgt_baan_buiten_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_te_keuren_niet_verlichtField = value;
			}
		}
		public CrmNumber sgt_baan_buiten_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_te_keuren_verlichtField = value;
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
		public CrmDateTime sgt_datum_keuring_clubhuis
		{
			get
			{
				return this.sgt_datum_keuring_clubhuisField;
			}
			set
			{
				this.sgt_datum_keuring_clubhuisField = value;
			}
		}
		public CrmDateTime sgt_datum_keuring_hal
		{
			get
			{
				return this.sgt_datum_keuring_halField;
			}
			set
			{
				this.sgt_datum_keuring_halField = value;
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
		public CrmBoolean sgt_ehbo_ruimte
		{
			get
			{
				return this.sgt_ehbo_ruimteField;
			}
			set
			{
				this.sgt_ehbo_ruimteField = value;
			}
		}
		public CrmBoolean sgt_ehbo_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_ehbo_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_ehbo_ruimtes_clubhuisField = value;
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
		public CrmBoolean sgt_fysio_ruimte
		{
			get
			{
				return this.sgt_fysio_ruimteField;
			}
			set
			{
				this.sgt_fysio_ruimteField = value;
			}
		}
		public CrmBoolean sgt_fysio_ruimte_clubhuis
		{
			get
			{
				return this.sgt_fysio_ruimte_clubhuisField;
			}
			set
			{
				this.sgt_fysio_ruimte_clubhuisField = value;
			}
		}
		public Lookup sgt_gekeurddoorid
		{
			get
			{
				return this.sgt_gekeurddooridField;
			}
			set
			{
				this.sgt_gekeurddooridField = value;
			}
		}
		public Lookup sgt_hal_gekeurd_doorid
		{
			get
			{
				return this.sgt_hal_gekeurd_dooridField;
			}
			set
			{
				this.sgt_hal_gekeurd_dooridField = value;
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
		public CrmBoolean sgt_jeugdhonk
		{
			get
			{
				return this.sgt_jeugdhonkField;
			}
			set
			{
				this.sgt_jeugdhonkField = value;
			}
		}
		public CrmBoolean sgt_jeugdhonk_clubhuis
		{
			get
			{
				return this.sgt_jeugdhonk_clubhuisField;
			}
			set
			{
				this.sgt_jeugdhonk_clubhuisField = value;
			}
		}
		public CrmBoolean sgt_kantine
		{
			get
			{
				return this.sgt_kantineField;
			}
			set
			{
				this.sgt_kantineField = value;
			}
		}
		public CrmBoolean sgt_kantine_clubhuis
		{
			get
			{
				return this.sgt_kantine_clubhuisField;
			}
			set
			{
				this.sgt_kantine_clubhuisField = value;
			}
		}
		public CrmBoolean sgt_keuken
		{
			get
			{
				return this.sgt_keukenField;
			}
			set
			{
				this.sgt_keukenField = value;
			}
		}
		public CrmBoolean sgt_keuken_clubhuis
		{
			get
			{
				return this.sgt_keuken_clubhuisField;
			}
			set
			{
				this.sgt_keuken_clubhuisField = value;
			}
		}
		public Picklist sgt_klasse_hal
		{
			get
			{
				return this.sgt_klasse_halField;
			}
			set
			{
				this.sgt_klasse_halField = value;
			}
		}
		public CrmBoolean sgt_kleedruimte
		{
			get
			{
				return this.sgt_kleedruimteField;
			}
			set
			{
				this.sgt_kleedruimteField = value;
			}
		}
		public CrmBoolean sgt_kleedruimte_clubhuis
		{
			get
			{
				return this.sgt_kleedruimte_clubhuisField;
			}
			set
			{
				this.sgt_kleedruimte_clubhuisField = value;
			}
		}
		public CrmBoolean sgt_kleedruimte_dames
		{
			get
			{
				return this.sgt_kleedruimte_damesField;
			}
			set
			{
				this.sgt_kleedruimte_damesField = value;
			}
		}
		public CrmBoolean sgt_kleedruimte_dames_clubhuis
		{
			get
			{
				return this.sgt_kleedruimte_dames_clubhuisField;
			}
			set
			{
				this.sgt_kleedruimte_dames_clubhuisField = value;
			}
		}
		public Picklist sgt_lichtpuntsterkte_hal
		{
			get
			{
				return this.sgt_lichtpuntsterkte_halField;
			}
			set
			{
				this.sgt_lichtpuntsterkte_halField = value;
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
		public CrmNumber sgt_m2_fysio_ruimte
		{
			get
			{
				return this.sgt_m2_fysio_ruimteField;
			}
			set
			{
				this.sgt_m2_fysio_ruimteField = value;
			}
		}
		public CrmNumber sgt_m2_fysio_ruimte_clubhuis
		{
			get
			{
				return this.sgt_m2_fysio_ruimte_clubhuisField;
			}
			set
			{
				this.sgt_m2_fysio_ruimte_clubhuisField = value;
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
		public CrmNumber sgt_m2_keuken
		{
			get
			{
				return this.sgt_m2_keukenField;
			}
			set
			{
				this.sgt_m2_keukenField = value;
			}
		}
		public CrmNumber sgt_m2_keuken_clubhuis
		{
			get
			{
				return this.sgt_m2_keuken_clubhuisField;
			}
			set
			{
				this.sgt_m2_keuken_clubhuisField = value;
			}
		}
		public CrmNumber sgt_m2_kleed_dames_clubhuis
		{
			get
			{
				return this.sgt_m2_kleed_dames_clubhuisField;
			}
			set
			{
				this.sgt_m2_kleed_dames_clubhuisField = value;
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
		public CrmNumber sgt_m2_kleedruimte_dames
		{
			get
			{
				return this.sgt_m2_kleedruimte_damesField;
			}
			set
			{
				this.sgt_m2_kleedruimte_damesField = value;
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
		public CrmNumber sgt_m2_was_clubhuis
		{
			get
			{
				return this.sgt_m2_was_clubhuisField;
			}
			set
			{
				this.sgt_m2_was_clubhuisField = value;
			}
		}
		public CrmNumber sgt_m2_was_dames_clubhuis
		{
			get
			{
				return this.sgt_m2_was_dames_clubhuisField;
			}
			set
			{
				this.sgt_m2_was_dames_clubhuisField = value;
			}
		}
		public CrmNumber sgt_m2_wasruimte_dames
		{
			get
			{
				return this.sgt_m2_wasruimte_damesField;
			}
			set
			{
				this.sgt_m2_wasruimte_damesField = value;
			}
		}
		public CrmNumber sgt_m2_wasruimte_heren
		{
			get
			{
				return this.sgt_m2_wasruimte_herenField;
			}
			set
			{
				this.sgt_m2_wasruimte_herenField = value;
			}
		}
		public CrmNumber sgt_m2_wedstrijdruimte
		{
			get
			{
				return this.sgt_m2_wedstrijdruimteField;
			}
			set
			{
				this.sgt_m2_wedstrijdruimteField = value;
			}
		}
		public CrmNumber sgt_m2_wedstrijdruimte_clubhuis
		{
			get
			{
				return this.sgt_m2_wedstrijdruimte_clubhuisField;
			}
			set
			{
				this.sgt_m2_wedstrijdruimte_clubhuisField = value;
			}
		}
		public CrmBoolean sgt_minibanen
		{
			get
			{
				return this.sgt_minibanenField;
			}
			set
			{
				this.sgt_minibanenField = value;
			}
		}
		public CrmBoolean sgt_oefenmuren
		{
			get
			{
				return this.sgt_oefenmurenField;
			}
			set
			{
				this.sgt_oefenmurenField = value;
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
		public CrmBoolean sgt_playgrounds
		{
			get
			{
				return this.sgt_playgroundsField;
			}
			set
			{
				this.sgt_playgroundsField = value;
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
		public CrmBoolean sgt_speeltoestellen
		{
			get
			{
				return this.sgt_speeltoestellenField;
			}
			set
			{
				this.sgt_speeltoestellenField = value;
			}
		}
		public Picklist sgt_status_clubhuis
		{
			get
			{
				return this.sgt_status_clubhuisField;
			}
			set
			{
				this.sgt_status_clubhuisField = value;
			}
		}
		public Picklist sgt_status_hal
		{
			get
			{
				return this.sgt_status_halField;
			}
			set
			{
				this.sgt_status_halField = value;
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
		public CrmBoolean sgt_tenniskids_huisstijl
		{
			get
			{
				return this.sgt_tenniskids_huisstijlField;
			}
			set
			{
				this.sgt_tenniskids_huisstijlField = value;
			}
		}
		public CrmNumber sgt_toiletten_mindervaliden
		{
			get
			{
				return this.sgt_toiletten_mindervalidenField;
			}
			set
			{
				this.sgt_toiletten_mindervalidenField = value;
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
		public Lookup sgt_toplaag_minibanenid
		{
			get
			{
				return this.sgt_toplaag_minibanenidField;
			}
			set
			{
				this.sgt_toplaag_minibanenidField = value;
			}
		}
		public Lookup sgt_toplaag_oefenmurenid
		{
			get
			{
				return this.sgt_toplaag_oefenmurenidField;
			}
			set
			{
				this.sgt_toplaag_oefenmurenidField = value;
			}
		}
		public Lookup sgt_toplaag_playgroundid
		{
			get
			{
				return this.sgt_toplaag_playgroundidField;
			}
			set
			{
				this.sgt_toplaag_playgroundidField = value;
			}
		}
		public CrmNumber sgt_totaal_aanta_lbaanblokken
		{
			get
			{
				return this.sgt_totaal_aanta_lbaanblokkenField;
			}
			set
			{
				this.sgt_totaal_aanta_lbaanblokkenField = value;
			}
		}
		public CrmNumber sgt_totaal_aantal_banen
		{
			get
			{
				return this.sgt_totaal_aantal_banenField;
			}
			set
			{
				this.sgt_totaal_aantal_banenField = value;
			}
		}
		public CrmBoolean sgt_vergaderruimte
		{
			get
			{
				return this.sgt_vergaderruimteField;
			}
			set
			{
				this.sgt_vergaderruimteField = value;
			}
		}
		public CrmBoolean sgt_vergaderruimte_clubhuis
		{
			get
			{
				return this.sgt_vergaderruimte_clubhuisField;
			}
			set
			{
				this.sgt_vergaderruimte_clubhuisField = value;
			}
		}
		public CrmBoolean sgt_wasruimte
		{
			get
			{
				return this.sgt_wasruimteField;
			}
			set
			{
				this.sgt_wasruimteField = value;
			}
		}
		public CrmBoolean sgt_wasruimte_clubhuis
		{
			get
			{
				return this.sgt_wasruimte_clubhuisField;
			}
			set
			{
				this.sgt_wasruimte_clubhuisField = value;
			}
		}
		public CrmBoolean sgt_wasruimte_dames
		{
			get
			{
				return this.sgt_wasruimte_damesField;
			}
			set
			{
				this.sgt_wasruimte_damesField = value;
			}
		}
		public CrmBoolean sgt_wasruimte_dames_clubhuis
		{
			get
			{
				return this.sgt_wasruimte_dames_clubhuisField;
			}
			set
			{
				this.sgt_wasruimte_dames_clubhuisField = value;
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
		public CrmBoolean sgt_wedstrijdruimte
		{
			get
			{
				return this.sgt_wedstrijdruimteField;
			}
			set
			{
				this.sgt_wedstrijdruimteField = value;
			}
		}
		public CrmBoolean sgt_wedstrijdruimte_clubhuis
		{
			get
			{
				return this.sgt_wedstrijdruimte_clubhuisField;
			}
			set
			{
				this.sgt_wedstrijdruimte_clubhuisField = value;
			}
		}
		public Sgt_alg_accommodatieStateInfo statecode
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
