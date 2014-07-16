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
		public CrmNumber sgt_aantal_banen_binnen
		{
			get
			{
				return this.sgt_aantal_banen_binnenField;
			}
			set
			{
				this.sgt_aantal_banen_binnenField = value;
				base.RaisePropertyChanged("sgt_aantal_banen_binnen");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_banen_buiten
		{
			get
			{
				return this.sgt_aantal_banen_buitenField;
			}
			set
			{
				this.sgt_aantal_banen_buitenField = value;
				base.RaisePropertyChanged("sgt_aantal_banen_buiten");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_aantal_douches_dames
		{
			get
			{
				return this.sgt_aantal_douches_damesField;
			}
			set
			{
				this.sgt_aantal_douches_damesField = value;
				base.RaisePropertyChanged("sgt_aantal_douches_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_aantal_douches_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_douches_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_douches_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_douches_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_aantal_douches_heren
		{
			get
			{
				return this.sgt_aantal_douches_herenField;
			}
			set
			{
				this.sgt_aantal_douches_herenField = value;
				base.RaisePropertyChanged("sgt_aantal_douches_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_aantal_douches_heren_clubhuis
		{
			get
			{
				return this.sgt_aantal_douches_heren_clubhuisField;
			}
			set
			{
				this.sgt_aantal_douches_heren_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_douches_heren_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_aantal_ehbo_fysio_ruimtes
		{
			get
			{
				return this.sgt_aantal_ehbo_fysio_ruimtesField;
			}
			set
			{
				this.sgt_aantal_ehbo_fysio_ruimtesField = value;
				base.RaisePropertyChanged("sgt_aantal_ehbo_fysio_ruimtes");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_aantal_ehbo_fysio_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_ehbo_fysio_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_ehbo_fysio_ruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_ehbo_fysio_ruimtes_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber sgt_aantal_fysio_ruimtes
		{
			get
			{
				return this.sgt_aantal_fysio_ruimtesField;
			}
			set
			{
				this.sgt_aantal_fysio_ruimtesField = value;
				base.RaisePropertyChanged("sgt_aantal_fysio_ruimtes");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber sgt_aantal_fysio_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_fysio_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_fysio_ruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_fysio_ruimtes_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber sgt_aantal_kleed_wasruimtes
		{
			get
			{
				return this.sgt_aantal_kleed_wasruimtesField;
			}
			set
			{
				this.sgt_aantal_kleed_wasruimtesField = value;
				base.RaisePropertyChanged("sgt_aantal_kleed_wasruimtes");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber sgt_aantal_kleed_wasruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_kleed_wasruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_kleed_wasruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_kleed_wasruimtes_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmNumber sgt_aantal_kleedruimte_dames
		{
			get
			{
				return this.sgt_aantal_kleedruimte_damesField;
			}
			set
			{
				this.sgt_aantal_kleedruimte_damesField = value;
				base.RaisePropertyChanged("sgt_aantal_kleedruimte_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmNumber sgt_aantal_kleedruimtes_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_kleedruimtes_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_kleedruimtes_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_kleedruimtes_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmNumber sgt_aantal_minibanen
		{
			get
			{
				return this.sgt_aantal_minibanenField;
			}
			set
			{
				this.sgt_aantal_minibanenField = value;
				base.RaisePropertyChanged("sgt_aantal_minibanen");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmNumber sgt_aantal_mv_parkeerplaatsen
		{
			get
			{
				return this.sgt_aantal_mv_parkeerplaatsenField;
			}
			set
			{
				this.sgt_aantal_mv_parkeerplaatsenField = value;
				base.RaisePropertyChanged("sgt_aantal_mv_parkeerplaatsen");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmNumber sgt_aantal_oefenmuren
		{
			get
			{
				return this.sgt_aantal_oefenmurenField;
			}
			set
			{
				this.sgt_aantal_oefenmurenField = value;
				base.RaisePropertyChanged("sgt_aantal_oefenmuren");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmNumber sgt_aantal_oranje_banen
		{
			get
			{
				return this.sgt_aantal_oranje_banenField;
			}
			set
			{
				this.sgt_aantal_oranje_banenField = value;
				base.RaisePropertyChanged("sgt_aantal_oranje_banen");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmNumber sgt_aantal_parkeerplaatsen
		{
			get
			{
				return this.sgt_aantal_parkeerplaatsenField;
			}
			set
			{
				this.sgt_aantal_parkeerplaatsenField = value;
				base.RaisePropertyChanged("sgt_aantal_parkeerplaatsen");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmNumber sgt_aantal_playgrounds
		{
			get
			{
				return this.sgt_aantal_playgroundsField;
			}
			set
			{
				this.sgt_aantal_playgroundsField = value;
				base.RaisePropertyChanged("sgt_aantal_playgrounds");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmNumber sgt_aantal_rode_banen
		{
			get
			{
				return this.sgt_aantal_rode_banenField;
			}
			set
			{
				this.sgt_aantal_rode_banenField = value;
				base.RaisePropertyChanged("sgt_aantal_rode_banen");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmNumber sgt_aantal_toiletten
		{
			get
			{
				return this.sgt_aantal_toilettenField;
			}
			set
			{
				this.sgt_aantal_toilettenField = value;
				base.RaisePropertyChanged("sgt_aantal_toiletten");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmNumber sgt_aantal_toiletten_clubhuis
		{
			get
			{
				return this.sgt_aantal_toiletten_clubhuisField;
			}
			set
			{
				this.sgt_aantal_toiletten_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_toiletten_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmNumber sgt_aantal_toiletten_dames
		{
			get
			{
				return this.sgt_aantal_toiletten_damesField;
			}
			set
			{
				this.sgt_aantal_toiletten_damesField = value;
				base.RaisePropertyChanged("sgt_aantal_toiletten_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmNumber sgt_aantal_toiletten_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_toiletten_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_toiletten_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_toiletten_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public CrmNumber sgt_aantal_verg_wed_ruimtes
		{
			get
			{
				return this.sgt_aantal_verg_wed_ruimtesField;
			}
			set
			{
				this.sgt_aantal_verg_wed_ruimtesField = value;
				base.RaisePropertyChanged("sgt_aantal_verg_wed_ruimtes");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public CrmNumber sgt_aantal_verg_wed_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_verg_wed_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_verg_wed_ruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_verg_wed_ruimtes_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public CrmNumber sgt_aantal_wasruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_wasruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_wasruimtes_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public CrmNumber sgt_aantal_wasruimtes_dames
		{
			get
			{
				return this.sgt_aantal_wasruimtes_damesField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_damesField = value;
				base.RaisePropertyChanged("sgt_aantal_wasruimtes_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public CrmNumber sgt_aantal_wasruimtes_dames_clubhuis
		{
			get
			{
				return this.sgt_aantal_wasruimtes_dames_clubhuisField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_wasruimtes_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public CrmNumber sgt_aantal_wasruimtes_heren
		{
			get
			{
				return this.sgt_aantal_wasruimtes_herenField;
			}
			set
			{
				this.sgt_aantal_wasruimtes_herenField = value;
				base.RaisePropertyChanged("sgt_aantal_wasruimtes_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public CrmNumber sgt_aantal_wedstrijdruimtes
		{
			get
			{
				return this.sgt_aantal_wedstrijdruimtesField;
			}
			set
			{
				this.sgt_aantal_wedstrijdruimtesField = value;
				base.RaisePropertyChanged("sgt_aantal_wedstrijdruimtes");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public CrmNumber sgt_aantal_wedstrijdruimtes_clubhuis
		{
			get
			{
				return this.sgt_aantal_wedstrijdruimtes_clubhuisField;
			}
			set
			{
				this.sgt_aantal_wedstrijdruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_aantal_wedstrijdruimtes_clubhuis");
			}
		}

		[XmlElement("sgt_alg_accommodatie")] //, Order=41)]
		public string sgt_alg_accommodatie1
		{
			get
			{
				return this.sgt_alg_accommodatie1Field;
			}
			set
			{
				this.sgt_alg_accommodatie1Field = value;
				base.RaisePropertyChanged("sgt_alg_accommodatie1");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public Key sgt_alg_accommodatieid
		{
			get
			{
				return this.sgt_alg_accommodatieidField;
			}
			set
			{
				this.sgt_alg_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_alg_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public CrmNumber sgt_baan_binnen
		{
			get
			{
				return this.sgt_baan_binnenField;
			}
			set
			{
				this.sgt_baan_binnenField = value;
				base.RaisePropertyChanged("sgt_baan_binnen");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public CrmNumber sgt_baan_binnen_afgekeurd
		{
			get
			{
				return this.sgt_baan_binnen_afgekeurdField;
			}
			set
			{
				this.sgt_baan_binnen_afgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_afgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public CrmNumber sgt_baan_binnen_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_afgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_afgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public CrmNumber sgt_baan_binnen_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_afgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_afgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public CrmNumber sgt_baan_binnen_dispensatie
		{
			get
			{
				return this.sgt_baan_binnen_dispensatieField;
			}
			set
			{
				this.sgt_baan_binnen_dispensatieField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_dispensatie");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public CrmNumber sgt_baan_binnen_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_dispensatie_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_dispensatie_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public CrmNumber sgt_baan_binnen_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_dispensatie_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_dispensatie_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public CrmNumber sgt_baan_binnen_goedgekeurd
		{
			get
			{
				return this.sgt_baan_binnen_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_binnen_goedgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_goedgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public CrmNumber sgt_baan_binnen_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_goedgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_goedgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public CrmNumber sgt_baan_binnen_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_goedgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_goedgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public CrmNumber sgt_baan_binnen_te_keuren
		{
			get
			{
				return this.sgt_baan_binnen_te_keurenField;
			}
			set
			{
				this.sgt_baan_binnen_te_keurenField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_te_keuren");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public CrmNumber sgt_baan_binnen_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_te_keuren_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_te_keuren_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public CrmNumber sgt_baan_binnen_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_binnen_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_binnen_te_keuren_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_binnen_te_keuren_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public CrmNumber sgt_baan_blaashal
		{
			get
			{
				return this.sgt_baan_blaashalField;
			}
			set
			{
				this.sgt_baan_blaashalField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public CrmNumber sgt_baan_blaashal_afgekeurd
		{
			get
			{
				return this.sgt_baan_blaashal_afgekeurdField;
			}
			set
			{
				this.sgt_baan_blaashal_afgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_afgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public CrmNumber sgt_baan_blaashal_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_afgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_afgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public CrmNumber sgt_baan_blaashal_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_afgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_afgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public CrmNumber sgt_baan_blaashal_dispensatie
		{
			get
			{
				return this.sgt_baan_blaashal_dispensatieField;
			}
			set
			{
				this.sgt_baan_blaashal_dispensatieField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_dispensatie");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public CrmNumber sgt_baan_blaashal_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_dispensatie_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_dispensatie_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public CrmNumber sgt_baan_blaashal_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_dispensatie_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_dispensatie_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public CrmNumber sgt_baan_blaashal_goedgekeurd
		{
			get
			{
				return this.sgt_baan_blaashal_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_blaashal_goedgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_goedgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public CrmNumber sgt_baan_blaashal_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_goedgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_goedgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public CrmNumber sgt_baan_blaashal_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_goedgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_goedgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public CrmNumber sgt_baan_blaashal_te_keuren
		{
			get
			{
				return this.sgt_baan_blaashal_te_keurenField;
			}
			set
			{
				this.sgt_baan_blaashal_te_keurenField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_te_keuren");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public CrmNumber sgt_baan_blaashal_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_te_keuren_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_te_keuren_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public CrmNumber sgt_baan_blaashal_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_blaashal_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_blaashal_te_keuren_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_blaashal_te_keuren_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public CrmNumber sgt_baan_buiten
		{
			get
			{
				return this.sgt_baan_buitenField;
			}
			set
			{
				this.sgt_baan_buitenField = value;
				base.RaisePropertyChanged("sgt_baan_buiten");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public CrmNumber sgt_baan_buiten_afgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_afgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_afgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_afgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public CrmNumber sgt_baan_buiten_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_afgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_afgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public CrmNumber sgt_baan_buiten_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_afgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_afgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=73)]
		public CrmNumber sgt_baan_buiten_dispensatie
		{
			get
			{
				return this.sgt_baan_buiten_dispensatieField;
			}
			set
			{
				this.sgt_baan_buiten_dispensatieField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_dispensatie");
			}
		}

		[XmlElement] //[XmlElement(Order=74)]
		public CrmNumber sgt_baan_buiten_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_dispensatie_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_dispensatie_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=75)]
		public CrmNumber sgt_baan_buiten_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_dispensatie_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_dispensatie_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=76)]
		public CrmNumber sgt_baan_buiten_goedgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_goedgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_goedgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=77)]
		public CrmNumber sgt_baan_buiten_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_goedgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_goedgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=78)]
		public CrmNumber sgt_baan_buiten_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_goedgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_goedgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=79)]
		public CrmNumber sgt_baan_buiten_ov
		{
			get
			{
				return this.sgt_baan_buiten_ovField;
			}
			set
			{
				this.sgt_baan_buiten_ovField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov");
			}
		}

		[XmlElement] //[XmlElement(Order=80)]
		public CrmNumber sgt_baan_buiten_ov_afgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_ov_afgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_ov_afgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_afgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=81)]
		public CrmNumber sgt_baan_buiten_ov_afgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_afgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_afgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_afgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=82)]
		public CrmNumber sgt_baan_buiten_ov_afgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_afgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_afgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_afgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=83)]
		public CrmNumber sgt_baan_buiten_ov_dispensatie
		{
			get
			{
				return this.sgt_baan_buiten_ov_dispensatieField;
			}
			set
			{
				this.sgt_baan_buiten_ov_dispensatieField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_dispensatie");
			}
		}

		[XmlElement] //[XmlElement(Order=84)]
		public CrmNumber sgt_baan_buiten_ov_dispensatie_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_dispensatie_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_dispensatie_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_dispensatie_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=85)]
		public CrmNumber sgt_baan_buiten_ov_dispensatie_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_dispensatie_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_dispensatie_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_dispensatie_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=86)]
		public CrmNumber sgt_baan_buiten_ov_goedgekeurd
		{
			get
			{
				return this.sgt_baan_buiten_ov_goedgekeurdField;
			}
			set
			{
				this.sgt_baan_buiten_ov_goedgekeurdField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_goedgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=87)]
		public CrmNumber sgt_baan_buiten_ov_goedgekeurd_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_goedgekeurd_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_goedgekeurd_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_goedgekeurd_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=88)]
		public CrmNumber sgt_baan_buiten_ov_goedgekeurd_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_goedgekeurd_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_goedgekeurd_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_goedgekeurd_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=89)]
		public CrmNumber sgt_baan_buiten_ov_te_keuren
		{
			get
			{
				return this.sgt_baan_buiten_ov_te_keurenField;
			}
			set
			{
				this.sgt_baan_buiten_ov_te_keurenField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_te_keuren");
			}
		}

		[XmlElement] //[XmlElement(Order=90)]
		public CrmNumber sgt_baan_buiten_ov_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_te_keuren_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_te_keuren_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=91)]
		public CrmNumber sgt_baan_buiten_ov_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_ov_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_ov_te_keuren_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_ov_te_keuren_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=92)]
		public CrmNumber sgt_baan_buiten_te_keuren
		{
			get
			{
				return this.sgt_baan_buiten_te_keurenField;
			}
			set
			{
				this.sgt_baan_buiten_te_keurenField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_te_keuren");
			}
		}

		[XmlElement] //[XmlElement(Order=93)]
		public CrmNumber sgt_baan_buiten_te_keuren_niet_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_te_keuren_niet_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_te_keuren_niet_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_te_keuren_niet_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=94)]
		public CrmNumber sgt_baan_buiten_te_keuren_verlicht
		{
			get
			{
				return this.sgt_baan_buiten_te_keuren_verlichtField;
			}
			set
			{
				this.sgt_baan_buiten_te_keuren_verlichtField = value;
				base.RaisePropertyChanged("sgt_baan_buiten_te_keuren_verlicht");
			}
		}

		[XmlElement] //[XmlElement(Order=95)]
		public Picklist sgt_beveiliging
		{
			get
			{
				return this.sgt_beveiligingField;
			}
			set
			{
				this.sgt_beveiligingField = value;
				base.RaisePropertyChanged("sgt_beveiliging");
			}
		}

		[XmlElement] //[XmlElement(Order=96)]
		public string sgt_bezoekadres_gemeente
		{
			get
			{
				return this.sgt_bezoekadres_gemeenteField;
			}
			set
			{
				this.sgt_bezoekadres_gemeenteField = value;
				base.RaisePropertyChanged("sgt_bezoekadres_gemeente");
			}
		}

		[XmlElement] //[XmlElement(Order=97)]
		public string sgt_bezoekadres_huisnummer
		{
			get
			{
				return this.sgt_bezoekadres_huisnummerField;
			}
			set
			{
				this.sgt_bezoekadres_huisnummerField = value;
				base.RaisePropertyChanged("sgt_bezoekadres_huisnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=98)]
		public string sgt_bezoekadres_plaats
		{
			get
			{
				return this.sgt_bezoekadres_plaatsField;
			}
			set
			{
				this.sgt_bezoekadres_plaatsField = value;
				base.RaisePropertyChanged("sgt_bezoekadres_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=99)]
		public string sgt_bezoekadres_postcode
		{
			get
			{
				return this.sgt_bezoekadres_postcodeField;
			}
			set
			{
				this.sgt_bezoekadres_postcodeField = value;
				base.RaisePropertyChanged("sgt_bezoekadres_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=100)]
		public string sgt_bezoekadres_straat
		{
			get
			{
				return this.sgt_bezoekadres_straatField;
			}
			set
			{
				this.sgt_bezoekadres_straatField = value;
				base.RaisePropertyChanged("sgt_bezoekadres_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=101)]
		public string sgt_bezoekadres_toevoeging
		{
			get
			{
				return this.sgt_bezoekadres_toevoegingField;
			}
			set
			{
				this.sgt_bezoekadres_toevoegingField = value;
				base.RaisePropertyChanged("sgt_bezoekadres_toevoeging");
			}
		}

		[XmlElement] //[XmlElement(Order=102)]
		public Lookup sgt_bezoekadreslandcodeid
		{
			get
			{
				return this.sgt_bezoekadreslandcodeidField;
			}
			set
			{
				this.sgt_bezoekadreslandcodeidField = value;
				base.RaisePropertyChanged("sgt_bezoekadreslandcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=103)]
		public CrmBoolean sgt_blaashal
		{
			get
			{
				return this.sgt_blaashalField;
			}
			set
			{
				this.sgt_blaashalField = value;
				base.RaisePropertyChanged("sgt_blaashal");
			}
		}

		[XmlElement] //[XmlElement(Order=104)]
		public Lookup sgt_bouwaardid
		{
			get
			{
				return this.sgt_bouwaardidField;
			}
			set
			{
				this.sgt_bouwaardidField = value;
				base.RaisePropertyChanged("sgt_bouwaardid");
			}
		}

		[XmlElement] //[XmlElement(Order=105)]
		public string sgt_bouwjaar_clubhuis
		{
			get
			{
				return this.sgt_bouwjaar_clubhuisField;
			}
			set
			{
				this.sgt_bouwjaar_clubhuisField = value;
				base.RaisePropertyChanged("sgt_bouwjaar_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=106)]
		public string sgt_bouwjaar_hal
		{
			get
			{
				return this.sgt_bouwjaar_halField;
			}
			set
			{
				this.sgt_bouwjaar_halField = value;
				base.RaisePropertyChanged("sgt_bouwjaar_hal");
			}
		}

		[XmlElement] //[XmlElement(Order=107)]
		public Lookup sgt_dagelijksonderhoudbanenid
		{
			get
			{
				return this.sgt_dagelijksonderhoudbanenidField;
			}
			set
			{
				this.sgt_dagelijksonderhoudbanenidField = value;
				base.RaisePropertyChanged("sgt_dagelijksonderhoudbanenid");
			}
		}

		[XmlElement] //[XmlElement(Order=108)]
		public CrmDateTime sgt_datum_keuring_clubhuis
		{
			get
			{
				return this.sgt_datum_keuring_clubhuisField;
			}
			set
			{
				this.sgt_datum_keuring_clubhuisField = value;
				base.RaisePropertyChanged("sgt_datum_keuring_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=109)]
		public CrmDateTime sgt_datum_keuring_hal
		{
			get
			{
				return this.sgt_datum_keuring_halField;
			}
			set
			{
				this.sgt_datum_keuring_halField = value;
				base.RaisePropertyChanged("sgt_datum_keuring_hal");
			}
		}

		[XmlElement] //[XmlElement(Order=110)]
		public CrmBoolean sgt_digitaal_afhangen
		{
			get
			{
				return this.sgt_digitaal_afhangenField;
			}
			set
			{
				this.sgt_digitaal_afhangenField = value;
				base.RaisePropertyChanged("sgt_digitaal_afhangen");
			}
		}

		[XmlElement] //[XmlElement(Order=111)]
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

		[XmlElement] //[XmlElement(Order=112)]
		public CrmBoolean sgt_ehbo_ruimte
		{
			get
			{
				return this.sgt_ehbo_ruimteField;
			}
			set
			{
				this.sgt_ehbo_ruimteField = value;
				base.RaisePropertyChanged("sgt_ehbo_ruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=113)]
		public CrmBoolean sgt_ehbo_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_ehbo_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_ehbo_ruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_ehbo_ruimtes_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=114)]
		public Lookup sgt_eigenaar_grondid
		{
			get
			{
				return this.sgt_eigenaar_grondidField;
			}
			set
			{
				this.sgt_eigenaar_grondidField = value;
				base.RaisePropertyChanged("sgt_eigenaar_grondid");
			}
		}

		[XmlElement] //[XmlElement(Order=115)]
		public Lookup sgt_eigenaaraccid
		{
			get
			{
				return this.sgt_eigenaaraccidField;
			}
			set
			{
				this.sgt_eigenaaraccidField = value;
				base.RaisePropertyChanged("sgt_eigenaaraccid");
			}
		}

		[XmlElement] //[XmlElement(Order=116)]
		public Lookup sgt_eigenaarid
		{
			get
			{
				return this.sgt_eigenaaridField;
			}
			set
			{
				this.sgt_eigenaaridField = value;
				base.RaisePropertyChanged("sgt_eigenaarid");
			}
		}

		[XmlElement] //[XmlElement(Order=117)]
		public Lookup sgt_eigenaarlichtinstallatieid
		{
			get
			{
				return this.sgt_eigenaarlichtinstallatieidField;
			}
			set
			{
				this.sgt_eigenaarlichtinstallatieidField = value;
				base.RaisePropertyChanged("sgt_eigenaarlichtinstallatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=118)]
		public Lookup sgt_eigendom_overkappingid
		{
			get
			{
				return this.sgt_eigendom_overkappingidField;
			}
			set
			{
				this.sgt_eigendom_overkappingidField = value;
				base.RaisePropertyChanged("sgt_eigendom_overkappingid");
			}
		}

		[XmlElement] //[XmlElement(Order=119)]
		public Lookup sgt_eigendomclubhuisid
		{
			get
			{
				return this.sgt_eigendomclubhuisidField;
			}
			set
			{
				this.sgt_eigendomclubhuisidField = value;
				base.RaisePropertyChanged("sgt_eigendomclubhuisid");
			}
		}

		[XmlElement] //[XmlElement(Order=120)]
		public Lookup sgt_eigendomhalid
		{
			get
			{
				return this.sgt_eigendomhalidField;
			}
			set
			{
				this.sgt_eigendomhalidField = value;
				base.RaisePropertyChanged("sgt_eigendomhalid");
			}
		}

		[XmlElement] //[XmlElement(Order=121)]
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
				base.RaisePropertyChanged("sgt_email");
			}
		}

		[XmlElement] //[XmlElement(Order=122)]
		public Lookup sgt_exploitantid
		{
			get
			{
				return this.sgt_exploitantidField;
			}
			set
			{
				this.sgt_exploitantidField = value;
				base.RaisePropertyChanged("sgt_exploitantid");
			}
		}

		[XmlElement] //[XmlElement(Order=123)]
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

		[XmlElement] //[XmlElement(Order=124)]
		public CrmBoolean sgt_fysio_ruimte
		{
			get
			{
				return this.sgt_fysio_ruimteField;
			}
			set
			{
				this.sgt_fysio_ruimteField = value;
				base.RaisePropertyChanged("sgt_fysio_ruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=125)]
		public CrmBoolean sgt_fysio_ruimte_clubhuis
		{
			get
			{
				return this.sgt_fysio_ruimte_clubhuisField;
			}
			set
			{
				this.sgt_fysio_ruimte_clubhuisField = value;
				base.RaisePropertyChanged("sgt_fysio_ruimte_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=126)]
		public Lookup sgt_gekeurddoorid
		{
			get
			{
				return this.sgt_gekeurddooridField;
			}
			set
			{
				this.sgt_gekeurddooridField = value;
				base.RaisePropertyChanged("sgt_gekeurddoorid");
			}
		}

		[XmlElement] //[XmlElement(Order=127)]
		public Lookup sgt_hal_gekeurd_doorid
		{
			get
			{
				return this.sgt_hal_gekeurd_dooridField;
			}
			set
			{
				this.sgt_hal_gekeurd_dooridField = value;
				base.RaisePropertyChanged("sgt_hal_gekeurd_doorid");
			}
		}

		[XmlElement] //[XmlElement(Order=128)]
		public Lookup sgt_jaarlijksonderhoudbanenid
		{
			get
			{
				return this.sgt_jaarlijksonderhoudbanenidField;
			}
			set
			{
				this.sgt_jaarlijksonderhoudbanenidField = value;
				base.RaisePropertyChanged("sgt_jaarlijksonderhoudbanenid");
			}
		}

		[XmlElement] //[XmlElement(Order=129)]
		public CrmBoolean sgt_jeugdhonk
		{
			get
			{
				return this.sgt_jeugdhonkField;
			}
			set
			{
				this.sgt_jeugdhonkField = value;
				base.RaisePropertyChanged("sgt_jeugdhonk");
			}
		}

		[XmlElement] //[XmlElement(Order=130)]
		public CrmBoolean sgt_jeugdhonk_clubhuis
		{
			get
			{
				return this.sgt_jeugdhonk_clubhuisField;
			}
			set
			{
				this.sgt_jeugdhonk_clubhuisField = value;
				base.RaisePropertyChanged("sgt_jeugdhonk_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=131)]
		public CrmBoolean sgt_kantine
		{
			get
			{
				return this.sgt_kantineField;
			}
			set
			{
				this.sgt_kantineField = value;
				base.RaisePropertyChanged("sgt_kantine");
			}
		}

		[XmlElement] //[XmlElement(Order=132)]
		public CrmBoolean sgt_kantine_clubhuis
		{
			get
			{
				return this.sgt_kantine_clubhuisField;
			}
			set
			{
				this.sgt_kantine_clubhuisField = value;
				base.RaisePropertyChanged("sgt_kantine_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=133)]
		public CrmBoolean sgt_keuken
		{
			get
			{
				return this.sgt_keukenField;
			}
			set
			{
				this.sgt_keukenField = value;
				base.RaisePropertyChanged("sgt_keuken");
			}
		}

		[XmlElement] //[XmlElement(Order=134)]
		public CrmBoolean sgt_keuken_clubhuis
		{
			get
			{
				return this.sgt_keuken_clubhuisField;
			}
			set
			{
				this.sgt_keuken_clubhuisField = value;
				base.RaisePropertyChanged("sgt_keuken_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=135)]
		public Picklist sgt_klasse_hal
		{
			get
			{
				return this.sgt_klasse_halField;
			}
			set
			{
				this.sgt_klasse_halField = value;
				base.RaisePropertyChanged("sgt_klasse_hal");
			}
		}

		[XmlElement] //[XmlElement(Order=136)]
		public CrmBoolean sgt_kleedruimte
		{
			get
			{
				return this.sgt_kleedruimteField;
			}
			set
			{
				this.sgt_kleedruimteField = value;
				base.RaisePropertyChanged("sgt_kleedruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=137)]
		public CrmBoolean sgt_kleedruimte_clubhuis
		{
			get
			{
				return this.sgt_kleedruimte_clubhuisField;
			}
			set
			{
				this.sgt_kleedruimte_clubhuisField = value;
				base.RaisePropertyChanged("sgt_kleedruimte_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=138)]
		public CrmBoolean sgt_kleedruimte_dames
		{
			get
			{
				return this.sgt_kleedruimte_damesField;
			}
			set
			{
				this.sgt_kleedruimte_damesField = value;
				base.RaisePropertyChanged("sgt_kleedruimte_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=139)]
		public CrmBoolean sgt_kleedruimte_dames_clubhuis
		{
			get
			{
				return this.sgt_kleedruimte_dames_clubhuisField;
			}
			set
			{
				this.sgt_kleedruimte_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_kleedruimte_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=140)]
		public Picklist sgt_lichtpuntsterkte_hal
		{
			get
			{
				return this.sgt_lichtpuntsterkte_halField;
			}
			set
			{
				this.sgt_lichtpuntsterkte_halField = value;
				base.RaisePropertyChanged("sgt_lichtpuntsterkte_hal");
			}
		}

		[XmlElement] //[XmlElement(Order=141)]
		public Lookup sgt_liggingid
		{
			get
			{
				return this.sgt_liggingidField;
			}
			set
			{
				this.sgt_liggingidField = value;
				base.RaisePropertyChanged("sgt_liggingid");
			}
		}

		[XmlElement] //[XmlElement(Order=142)]
		public CrmNumber sgt_m2_clubhuis
		{
			get
			{
				return this.sgt_m2_clubhuisField;
			}
			set
			{
				this.sgt_m2_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=143)]
		public CrmNumber sgt_m2_ehbo_fysio
		{
			get
			{
				return this.sgt_m2_ehbo_fysioField;
			}
			set
			{
				this.sgt_m2_ehbo_fysioField = value;
				base.RaisePropertyChanged("sgt_m2_ehbo_fysio");
			}
		}

		[XmlElement] //[XmlElement(Order=144)]
		public CrmNumber sgt_m2_ehbo_fysio_clubhuis
		{
			get
			{
				return this.sgt_m2_ehbo_fysio_clubhuisField;
			}
			set
			{
				this.sgt_m2_ehbo_fysio_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_ehbo_fysio_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=145)]
		public CrmNumber sgt_m2_fysio_ruimte
		{
			get
			{
				return this.sgt_m2_fysio_ruimteField;
			}
			set
			{
				this.sgt_m2_fysio_ruimteField = value;
				base.RaisePropertyChanged("sgt_m2_fysio_ruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=146)]
		public CrmNumber sgt_m2_fysio_ruimte_clubhuis
		{
			get
			{
				return this.sgt_m2_fysio_ruimte_clubhuisField;
			}
			set
			{
				this.sgt_m2_fysio_ruimte_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_fysio_ruimte_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=147)]
		public CrmNumber sgt_m2_hal
		{
			get
			{
				return this.sgt_m2_halField;
			}
			set
			{
				this.sgt_m2_halField = value;
				base.RaisePropertyChanged("sgt_m2_hal");
			}
		}

		[XmlElement] //[XmlElement(Order=148)]
		public CrmNumber sgt_m2_kantine
		{
			get
			{
				return this.sgt_m2_kantineField;
			}
			set
			{
				this.sgt_m2_kantineField = value;
				base.RaisePropertyChanged("sgt_m2_kantine");
			}
		}

		[XmlElement] //[XmlElement(Order=149)]
		public CrmNumber sgt_m2_kantine_clubhuis
		{
			get
			{
				return this.sgt_m2_kantine_clubhuisField;
			}
			set
			{
				this.sgt_m2_kantine_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_kantine_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=150)]
		public CrmNumber sgt_m2_keuken
		{
			get
			{
				return this.sgt_m2_keukenField;
			}
			set
			{
				this.sgt_m2_keukenField = value;
				base.RaisePropertyChanged("sgt_m2_keuken");
			}
		}

		[XmlElement] //[XmlElement(Order=151)]
		public CrmNumber sgt_m2_keuken_clubhuis
		{
			get
			{
				return this.sgt_m2_keuken_clubhuisField;
			}
			set
			{
				this.sgt_m2_keuken_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_keuken_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=152)]
		public CrmNumber sgt_m2_kleed_dames_clubhuis
		{
			get
			{
				return this.sgt_m2_kleed_dames_clubhuisField;
			}
			set
			{
				this.sgt_m2_kleed_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_kleed_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=153)]
		public CrmNumber sgt_m2_kleed_was
		{
			get
			{
				return this.sgt_m2_kleed_wasField;
			}
			set
			{
				this.sgt_m2_kleed_wasField = value;
				base.RaisePropertyChanged("sgt_m2_kleed_was");
			}
		}

		[XmlElement] //[XmlElement(Order=154)]
		public CrmNumber sgt_m2_kleed_was_clubhuis
		{
			get
			{
				return this.sgt_m2_kleed_was_clubhuisField;
			}
			set
			{
				this.sgt_m2_kleed_was_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_kleed_was_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=155)]
		public CrmNumber sgt_m2_kleedruimte_dames
		{
			get
			{
				return this.sgt_m2_kleedruimte_damesField;
			}
			set
			{
				this.sgt_m2_kleedruimte_damesField = value;
				base.RaisePropertyChanged("sgt_m2_kleedruimte_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=156)]
		public CrmNumber sgt_m2_verg_wed_ruimtes
		{
			get
			{
				return this.sgt_m2_verg_wed_ruimtesField;
			}
			set
			{
				this.sgt_m2_verg_wed_ruimtesField = value;
				base.RaisePropertyChanged("sgt_m2_verg_wed_ruimtes");
			}
		}

		[XmlElement] //[XmlElement(Order=157)]
		public CrmNumber sgt_m2_verg_wed_ruimtes_clubhuis
		{
			get
			{
				return this.sgt_m2_verg_wed_ruimtes_clubhuisField;
			}
			set
			{
				this.sgt_m2_verg_wed_ruimtes_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_verg_wed_ruimtes_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=158)]
		public CrmNumber sgt_m2_was_clubhuis
		{
			get
			{
				return this.sgt_m2_was_clubhuisField;
			}
			set
			{
				this.sgt_m2_was_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_was_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=159)]
		public CrmNumber sgt_m2_was_dames_clubhuis
		{
			get
			{
				return this.sgt_m2_was_dames_clubhuisField;
			}
			set
			{
				this.sgt_m2_was_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_was_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=160)]
		public CrmNumber sgt_m2_wasruimte_dames
		{
			get
			{
				return this.sgt_m2_wasruimte_damesField;
			}
			set
			{
				this.sgt_m2_wasruimte_damesField = value;
				base.RaisePropertyChanged("sgt_m2_wasruimte_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=161)]
		public CrmNumber sgt_m2_wasruimte_heren
		{
			get
			{
				return this.sgt_m2_wasruimte_herenField;
			}
			set
			{
				this.sgt_m2_wasruimte_herenField = value;
				base.RaisePropertyChanged("sgt_m2_wasruimte_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=162)]
		public CrmNumber sgt_m2_wedstrijdruimte
		{
			get
			{
				return this.sgt_m2_wedstrijdruimteField;
			}
			set
			{
				this.sgt_m2_wedstrijdruimteField = value;
				base.RaisePropertyChanged("sgt_m2_wedstrijdruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=163)]
		public CrmNumber sgt_m2_wedstrijdruimte_clubhuis
		{
			get
			{
				return this.sgt_m2_wedstrijdruimte_clubhuisField;
			}
			set
			{
				this.sgt_m2_wedstrijdruimte_clubhuisField = value;
				base.RaisePropertyChanged("sgt_m2_wedstrijdruimte_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=164)]
		public CrmBoolean sgt_minibanen
		{
			get
			{
				return this.sgt_minibanenField;
			}
			set
			{
				this.sgt_minibanenField = value;
				base.RaisePropertyChanged("sgt_minibanen");
			}
		}

		[XmlElement] //[XmlElement(Order=165)]
		public CrmBoolean sgt_oefenmuren
		{
			get
			{
				return this.sgt_oefenmurenField;
			}
			set
			{
				this.sgt_oefenmurenField = value;
				base.RaisePropertyChanged("sgt_oefenmuren");
			}
		}

		[XmlElement] //[XmlElement(Order=166)]
		public CrmBoolean sgt_ov_bereikbaar
		{
			get
			{
				return this.sgt_ov_bereikbaarField;
			}
			set
			{
				this.sgt_ov_bereikbaarField = value;
				base.RaisePropertyChanged("sgt_ov_bereikbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=167)]
		public CrmBoolean sgt_overkapping
		{
			get
			{
				return this.sgt_overkappingField;
			}
			set
			{
				this.sgt_overkappingField = value;
				base.RaisePropertyChanged("sgt_overkapping");
			}
		}

		[XmlElement] //[XmlElement(Order=168)]
		public CrmBoolean sgt_playgrounds
		{
			get
			{
				return this.sgt_playgroundsField;
			}
			set
			{
				this.sgt_playgroundsField = value;
				base.RaisePropertyChanged("sgt_playgrounds");
			}
		}

		[XmlElement] //[XmlElement(Order=169)]
		public string sgt_postadres_gemeente
		{
			get
			{
				return this.sgt_postadres_gemeenteField;
			}
			set
			{
				this.sgt_postadres_gemeenteField = value;
				base.RaisePropertyChanged("sgt_postadres_gemeente");
			}
		}

		[XmlElement] //[XmlElement(Order=170)]
		public string sgt_postadres_huisnummer
		{
			get
			{
				return this.sgt_postadres_huisnummerField;
			}
			set
			{
				this.sgt_postadres_huisnummerField = value;
				base.RaisePropertyChanged("sgt_postadres_huisnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=171)]
		public string sgt_postadres_plaats
		{
			get
			{
				return this.sgt_postadres_plaatsField;
			}
			set
			{
				this.sgt_postadres_plaatsField = value;
				base.RaisePropertyChanged("sgt_postadres_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=172)]
		public string sgt_postadres_postcode
		{
			get
			{
				return this.sgt_postadres_postcodeField;
			}
			set
			{
				this.sgt_postadres_postcodeField = value;
				base.RaisePropertyChanged("sgt_postadres_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=173)]
		public string sgt_postadres_straat
		{
			get
			{
				return this.sgt_postadres_straatField;
			}
			set
			{
				this.sgt_postadres_straatField = value;
				base.RaisePropertyChanged("sgt_postadres_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=174)]
		public string sgt_postadres_toevoeging
		{
			get
			{
				return this.sgt_postadres_toevoegingField;
			}
			set
			{
				this.sgt_postadres_toevoegingField = value;
				base.RaisePropertyChanged("sgt_postadres_toevoeging");
			}
		}

		[XmlElement] //[XmlElement(Order=175)]
		public Lookup sgt_postadreslandcodeid
		{
			get
			{
				return this.sgt_postadreslandcodeidField;
			}
			set
			{
				this.sgt_postadreslandcodeidField = value;
				base.RaisePropertyChanged("sgt_postadreslandcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=176)]
		public Lookup sgt_regioid
		{
			get
			{
				return this.sgt_regioidField;
			}
			set
			{
				this.sgt_regioidField = value;
				base.RaisePropertyChanged("sgt_regioid");
			}
		}

		[XmlElement] //[XmlElement(Order=177)]
		public CrmBoolean sgt_rolstoeltoegankelijk
		{
			get
			{
				return this.sgt_rolstoeltoegankelijkField;
			}
			set
			{
				this.sgt_rolstoeltoegankelijkField = value;
				base.RaisePropertyChanged("sgt_rolstoeltoegankelijk");
			}
		}

		[XmlElement] //[XmlElement(Order=178)]
		public Picklist sgt_soort_blaashal
		{
			get
			{
				return this.sgt_soort_blaashalField;
			}
			set
			{
				this.sgt_soort_blaashalField = value;
				base.RaisePropertyChanged("sgt_soort_blaashal");
			}
		}

		[XmlElement] //[XmlElement(Order=179)]
		public Picklist sgt_soort_overkapping
		{
			get
			{
				return this.sgt_soort_overkappingField;
			}
			set
			{
				this.sgt_soort_overkappingField = value;
				base.RaisePropertyChanged("sgt_soort_overkapping");
			}
		}

		[XmlElement] //[XmlElement(Order=180)]
		public Lookup sgt_soortverlichtingid
		{
			get
			{
				return this.sgt_soortverlichtingidField;
			}
			set
			{
				this.sgt_soortverlichtingidField = value;
				base.RaisePropertyChanged("sgt_soortverlichtingid");
			}
		}

		[XmlElement] //[XmlElement(Order=181)]
		public CrmBoolean sgt_speeltoestellen
		{
			get
			{
				return this.sgt_speeltoestellenField;
			}
			set
			{
				this.sgt_speeltoestellenField = value;
				base.RaisePropertyChanged("sgt_speeltoestellen");
			}
		}

		[XmlElement] //[XmlElement(Order=182)]
		public Picklist sgt_status_clubhuis
		{
			get
			{
				return this.sgt_status_clubhuisField;
			}
			set
			{
				this.sgt_status_clubhuisField = value;
				base.RaisePropertyChanged("sgt_status_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=183)]
		public Picklist sgt_status_hal
		{
			get
			{
				return this.sgt_status_halField;
			}
			set
			{
				this.sgt_status_halField = value;
				base.RaisePropertyChanged("sgt_status_hal");
			}
		}

		[XmlElement] //[XmlElement(Order=184)]
		public string sgt_telefoon
		{
			get
			{
				return this.sgt_telefoonField;
			}
			set
			{
				this.sgt_telefoonField = value;
				base.RaisePropertyChanged("sgt_telefoon");
			}
		}

		[XmlElement] //[XmlElement(Order=185)]
		public CrmBoolean sgt_tenniskids_huisstijl
		{
			get
			{
				return this.sgt_tenniskids_huisstijlField;
			}
			set
			{
				this.sgt_tenniskids_huisstijlField = value;
				base.RaisePropertyChanged("sgt_tenniskids_huisstijl");
			}
		}

		[XmlElement] //[XmlElement(Order=186)]
		public CrmNumber sgt_toiletten_mindervaliden
		{
			get
			{
				return this.sgt_toiletten_mindervalidenField;
			}
			set
			{
				this.sgt_toiletten_mindervalidenField = value;
				base.RaisePropertyChanged("sgt_toiletten_mindervaliden");
			}
		}

		[XmlElement] //[XmlElement(Order=187)]
		public CrmNumber sgt_toiletten_mindervaliden_clubhuis
		{
			get
			{
				return this.sgt_toiletten_mindervaliden_clubhuisField;
			}
			set
			{
				this.sgt_toiletten_mindervaliden_clubhuisField = value;
				base.RaisePropertyChanged("sgt_toiletten_mindervaliden_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=188)]
		public Lookup sgt_toplaag_minibanenid
		{
			get
			{
				return this.sgt_toplaag_minibanenidField;
			}
			set
			{
				this.sgt_toplaag_minibanenidField = value;
				base.RaisePropertyChanged("sgt_toplaag_minibanenid");
			}
		}

		[XmlElement] //[XmlElement(Order=189)]
		public Lookup sgt_toplaag_oefenmurenid
		{
			get
			{
				return this.sgt_toplaag_oefenmurenidField;
			}
			set
			{
				this.sgt_toplaag_oefenmurenidField = value;
				base.RaisePropertyChanged("sgt_toplaag_oefenmurenid");
			}
		}

		[XmlElement] //[XmlElement(Order=190)]
		public Lookup sgt_toplaag_playgroundid
		{
			get
			{
				return this.sgt_toplaag_playgroundidField;
			}
			set
			{
				this.sgt_toplaag_playgroundidField = value;
				base.RaisePropertyChanged("sgt_toplaag_playgroundid");
			}
		}

		[XmlElement] //[XmlElement(Order=191)]
		public CrmNumber sgt_totaal_aanta_lbaanblokken
		{
			get
			{
				return this.sgt_totaal_aanta_lbaanblokkenField;
			}
			set
			{
				this.sgt_totaal_aanta_lbaanblokkenField = value;
				base.RaisePropertyChanged("sgt_totaal_aanta_lbaanblokken");
			}
		}

		[XmlElement] //[XmlElement(Order=192)]
		public CrmNumber sgt_totaal_aantal_banen
		{
			get
			{
				return this.sgt_totaal_aantal_banenField;
			}
			set
			{
				this.sgt_totaal_aantal_banenField = value;
				base.RaisePropertyChanged("sgt_totaal_aantal_banen");
			}
		}

		[XmlElement] //[XmlElement(Order=193)]
		public CrmBoolean sgt_vergaderruimte
		{
			get
			{
				return this.sgt_vergaderruimteField;
			}
			set
			{
				this.sgt_vergaderruimteField = value;
				base.RaisePropertyChanged("sgt_vergaderruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=194)]
		public CrmBoolean sgt_vergaderruimte_clubhuis
		{
			get
			{
				return this.sgt_vergaderruimte_clubhuisField;
			}
			set
			{
				this.sgt_vergaderruimte_clubhuisField = value;
				base.RaisePropertyChanged("sgt_vergaderruimte_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=195)]
		public CrmBoolean sgt_wasruimte
		{
			get
			{
				return this.sgt_wasruimteField;
			}
			set
			{
				this.sgt_wasruimteField = value;
				base.RaisePropertyChanged("sgt_wasruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=196)]
		public CrmBoolean sgt_wasruimte_clubhuis
		{
			get
			{
				return this.sgt_wasruimte_clubhuisField;
			}
			set
			{
				this.sgt_wasruimte_clubhuisField = value;
				base.RaisePropertyChanged("sgt_wasruimte_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=197)]
		public CrmBoolean sgt_wasruimte_dames
		{
			get
			{
				return this.sgt_wasruimte_damesField;
			}
			set
			{
				this.sgt_wasruimte_damesField = value;
				base.RaisePropertyChanged("sgt_wasruimte_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=198)]
		public CrmBoolean sgt_wasruimte_dames_clubhuis
		{
			get
			{
				return this.sgt_wasruimte_dames_clubhuisField;
			}
			set
			{
				this.sgt_wasruimte_dames_clubhuisField = value;
				base.RaisePropertyChanged("sgt_wasruimte_dames_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=199)]
		public string sgt_website
		{
			get
			{
				return this.sgt_websiteField;
			}
			set
			{
				this.sgt_websiteField = value;
				base.RaisePropertyChanged("sgt_website");
			}
		}

		[XmlElement] //[XmlElement(Order=200)]
		public CrmBoolean sgt_wedstrijdruimte
		{
			get
			{
				return this.sgt_wedstrijdruimteField;
			}
			set
			{
				this.sgt_wedstrijdruimteField = value;
				base.RaisePropertyChanged("sgt_wedstrijdruimte");
			}
		}

		[XmlElement] //[XmlElement(Order=201)]
		public CrmBoolean sgt_wedstrijdruimte_clubhuis
		{
			get
			{
				return this.sgt_wedstrijdruimte_clubhuisField;
			}
			set
			{
				this.sgt_wedstrijdruimte_clubhuisField = value;
				base.RaisePropertyChanged("sgt_wedstrijdruimte_clubhuis");
			}
		}

		[XmlElement] //[XmlElement(Order=202)]
		public Sgt_alg_accommodatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=203)]
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

		[XmlElement] //[XmlElement(Order=204)]
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

		[XmlElement] //[XmlElement(Order=205)]
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

		public sgt_alg_accommodatie()
		{
		}
	}
}