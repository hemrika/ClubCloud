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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_accommodatieid");
			}
		}
		[XmlElement(Order = 21)]
		public string sgt_accommodatienaam
		{
			get
			{
				return this.sgt_accommodatienaamField;
			}
			set
			{
				this.sgt_accommodatienaamField = value;
				base.RaisePropertyChanged("sgt_accommodatienaam");
			}
		}
		[XmlElement(Order = 22)]
		public Key sgt_alg_pb_mutatie_accommodatiesid
		{
			get
			{
				return this.sgt_alg_pb_mutatie_accommodatiesidField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_accommodatiesidField = value;
				base.RaisePropertyChanged("sgt_alg_pb_mutatie_accommodatiesid");
			}
		}
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
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
		[XmlElement(Order = 41)]
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
		[XmlElement(Order = 42)]
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
		[XmlElement(Order = 43)]
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
		[XmlElement(Order = 44)]
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
		[XmlElement(Order = 45)]
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
		[XmlElement(Order = 46)]
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
		[XmlElement(Order = 47)]
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
		[XmlElement(Order = 48)]
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
		[XmlElement(Order = 49)]
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
		[XmlElement(Order = 50)]
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
		[XmlElement(Order = 51)]
		public string sgt_bezoekadreslandcodeid_naam
		{
			get
			{
				return this.sgt_bezoekadreslandcodeid_naamField;
			}
			set
			{
				this.sgt_bezoekadreslandcodeid_naamField = value;
				base.RaisePropertyChanged("sgt_bezoekadreslandcodeid_naam");
			}
		}
		[XmlElement(Order = 52)]
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
		[XmlElement(Order = 53)]
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
		[XmlElement(Order = 54)]
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
		[XmlElement(Order = 55)]
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
		[XmlElement(Order = 56)]
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
		[XmlElement(Order = 57)]
		public string sgt_dagelijksonderhoudbanenid_naam
		{
			get
			{
				return this.sgt_dagelijksonderhoudbanenid_naamField;
			}
			set
			{
				this.sgt_dagelijksonderhoudbanenid_naamField = value;
				base.RaisePropertyChanged("sgt_dagelijksonderhoudbanenid_naam");
			}
		}
		[XmlElement(Order = 58)]
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
		[XmlElement(Order = 59)]
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
		[XmlElement(Order = 60)]
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
		[XmlElement(Order = 61)]
		public string sgt_eigenaar_grondid_naam
		{
			get
			{
				return this.sgt_eigenaar_grondid_naamField;
			}
			set
			{
				this.sgt_eigenaar_grondid_naamField = value;
				base.RaisePropertyChanged("sgt_eigenaar_grondid_naam");
			}
		}
		[XmlElement(Order = 62)]
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
		[XmlElement(Order = 63)]
		public string sgt_eigenaaraccid_naam
		{
			get
			{
				return this.sgt_eigenaaraccid_naamField;
			}
			set
			{
				this.sgt_eigenaaraccid_naamField = value;
				base.RaisePropertyChanged("sgt_eigenaaraccid_naam");
			}
		}
		[XmlElement(Order = 64)]
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
		[XmlElement(Order = 65)]
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
		[XmlElement(Order = 66)]
		public string sgt_eigenaarlichtinstallatieid_naam
		{
			get
			{
				return this.sgt_eigenaarlichtinstallatieid_naamField;
			}
			set
			{
				this.sgt_eigenaarlichtinstallatieid_naamField = value;
				base.RaisePropertyChanged("sgt_eigenaarlichtinstallatieid_naam");
			}
		}
		[XmlElement(Order = 67)]
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
		[XmlElement(Order = 68)]
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
		[XmlElement(Order = 69)]
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
		[XmlElement(Order = 70)]
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
		[XmlElement(Order = 71)]
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
		[XmlElement(Order = 72)]
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
		[XmlElement(Order = 73)]
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
		[XmlElement(Order = 74)]
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
		[XmlElement(Order = 75)]
		public string sgt_jaarlijksonderhoudbanenid_naam
		{
			get
			{
				return this.sgt_jaarlijksonderhoudbanenid_naamField;
			}
			set
			{
				this.sgt_jaarlijksonderhoudbanenid_naamField = value;
				base.RaisePropertyChanged("sgt_jaarlijksonderhoudbanenid_naam");
			}
		}
		[XmlElement(Order = 76)]
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
		[XmlElement(Order = 77)]
		public string sgt_liggingid_naam
		{
			get
			{
				return this.sgt_liggingid_naamField;
			}
			set
			{
				this.sgt_liggingid_naamField = value;
				base.RaisePropertyChanged("sgt_liggingid_naam");
			}
		}
		[XmlElement(Order = 78)]
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
		[XmlElement(Order = 79)]
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
		[XmlElement(Order = 80)]
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
		[XmlElement(Order = 81)]
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
		[XmlElement(Order = 82)]
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
		[XmlElement(Order = 83)]
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
		[XmlElement(Order = 84)]
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
		[XmlElement(Order = 85)]
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
		[XmlElement(Order = 86)]
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
		[XmlElement(Order = 87)]
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
		[XmlElement(Order = 88)]
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
		[XmlElement(Order = 89)]
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
		[XmlElement(Order = 90)]
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
		[XmlElement(Order = 91)]
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
		[XmlElement(Order = 92)]
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
		[XmlElement(Order = 93)]
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
		[XmlElement(Order = 94)]
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
		[XmlElement(Order = 95)]
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
		[XmlElement(Order = 96)]
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
		[XmlElement(Order = 97)]
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
		[XmlElement(Order = 98)]
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
		[XmlElement(Order = 99)]
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
		[XmlElement(Order = 100)]
		public string sgt_postadreslandcodeid_naam
		{
			get
			{
				return this.sgt_postadreslandcodeid_naamField;
			}
			set
			{
				this.sgt_postadreslandcodeid_naamField = value;
				base.RaisePropertyChanged("sgt_postadreslandcodeid_naam");
			}
		}
		[XmlElement(Order = 101)]
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
		[XmlElement(Order = 102)]
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
		[XmlElement(Order = 103)]
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
		[XmlElement(Order = 104)]
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
		[XmlElement(Order = 105)]
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
		[XmlElement(Order = 106)]
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
		[XmlElement(Order = 107)]
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
		[XmlElement(Order = 108)]
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
		[XmlElement(Order = 109)]
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
		[XmlElement(Order = 110)]
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
		[XmlElement(Order = 111)]
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
		[XmlElement(Order = 112)]
		public Sgt_alg_pb_mutatie_accommodatiesStateInfo statecode
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
		[XmlElement(Order = 113)]
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
		[XmlElement(Order = 114)]
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
		[XmlElement(Order = 115)]
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
	}
}
