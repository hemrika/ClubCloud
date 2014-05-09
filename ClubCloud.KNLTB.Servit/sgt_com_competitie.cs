using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_competitie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_vrije_afdelingnummersField;
		private Lookup sgt_accommodatieidField;
		private Lookup sgt_administratieidField;
		private CrmBoolean sgt_baancontroleField;
		private CrmDateTime sgt_begindatumField;
		private Picklist sgt_benodigde_banenField;
		private CrmBoolean sgt_bericht_inschrijvingField;
		private Lookup sgt_boeteidField;
		private Lookup sgt_bondsorganisatieidField;
		private string sgt_com_competitie1Field;
		private Key sgt_com_competitieidField;
		private Lookup sgt_competitie_kalenderidField;
		private string sgt_competitie_omschrijvingField;
		private Lookup sgt_competitietypeidField;
		private CrmBoolean sgt_controle_vcl_certificaatField;
		private CrmBoolean sgt_dispensatie_ander_parkField;
		private CrmBoolean sgt_dispensatie_banenField;
		private CrmBoolean sgt_dispensatie_geslachtField;
		private CrmBoolean sgt_dispensatie_goedgekeurde_banenField;
		private CrmBoolean sgt_dispensatie_leeftijdField;
		private CrmDateTime sgt_einddatumField;
		private CrmDateTime sgt_einde_inschrijvingField;
		private CrmNumber sgt_herinnering_dagenField;
		private CrmDateTime sgt_herinneringsdatumField;
		private Lookup sgt_herkomst_competitieidField;
		private Lookup sgt_inschrijfbijdrageidField;
		private CrmBoolean sgt_inschrijven_niet_knltb_leden_toegestaanField;
		private CrmBoolean sgt_kampioenschapField;
		private CrmNumber sgt_max_ploegen_thuisField;
		private Picklist sgt_max_te_spelen_setsField;
		private CrmNumber sgt_min_ploegen_afdelingField;
		private string sgt_plaatsField;
		private CrmNumber sgt_ploegen_ingeschrevenField;
		private Lookup sgt_post_naaridField;
		private string sgt_postcodeField;
		private CrmDateTime sgt_start_inschrijvingField;
		private Picklist sgt_status_competitieField;
		private Picklist sgt_status_mijnknltbField;
		private CrmBoolean sgt_thuis_thuis_schemaField;
		private Lookup sgt_tussentijdse_rating_peildatumidField;
		private CrmNumber sgt_verenigingen_ingeschrevenField;
		private Lookup sgt_verenigingidField;
		private Picklist sgt_verlichting_noodzakelijkField;
		private CrmDateTime sgt_wedstrijdprogramma_aangemaaktField;
		private Sgt_com_competitieStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_vrije_afdelingnummers
		{
			get
			{
				return this.sgt_aantal_vrije_afdelingnummersField;
			}
			set
			{
				this.sgt_aantal_vrije_afdelingnummersField = value;
				base.RaisePropertyChanged("sgt_aantal_vrije_afdelingnummers");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
				base.RaisePropertyChanged("sgt_administratieid");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_baancontrole
		{
			get
			{
				return this.sgt_baancontroleField;
			}
			set
			{
				this.sgt_baancontroleField = value;
				base.RaisePropertyChanged("sgt_baancontrole");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
				base.RaisePropertyChanged("sgt_begindatum");
			}
		}
		[XmlElement(Order = 13)]
		public Picklist sgt_benodigde_banen
		{
			get
			{
				return this.sgt_benodigde_banenField;
			}
			set
			{
				this.sgt_benodigde_banenField = value;
				base.RaisePropertyChanged("sgt_benodigde_banen");
			}
		}
		[XmlElement(Order = 14)]
		public CrmBoolean sgt_bericht_inschrijving
		{
			get
			{
				return this.sgt_bericht_inschrijvingField;
			}
			set
			{
				this.sgt_bericht_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_bericht_inschrijving");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_boeteid
		{
			get
			{
				return this.sgt_boeteidField;
			}
			set
			{
				this.sgt_boeteidField = value;
				base.RaisePropertyChanged("sgt_boeteid");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatieid");
			}
		}
		[XmlElement("sgt_com_competitie", Order = 17)]
		public string sgt_com_competitie1
		{
			get
			{
				return this.sgt_com_competitie1Field;
			}
			set
			{
				this.sgt_com_competitie1Field = value;
				base.RaisePropertyChanged("sgt_com_competitie1");
			}
		}
		[XmlElement(Order = 18)]
		public Key sgt_com_competitieid
		{
			get
			{
				return this.sgt_com_competitieidField;
			}
			set
			{
				this.sgt_com_competitieidField = value;
				base.RaisePropertyChanged("sgt_com_competitieid");
			}
		}
		[XmlElement(Order = 19)]
		public Lookup sgt_competitie_kalenderid
		{
			get
			{
				return this.sgt_competitie_kalenderidField;
			}
			set
			{
				this.sgt_competitie_kalenderidField = value;
				base.RaisePropertyChanged("sgt_competitie_kalenderid");
			}
		}
		[XmlElement(Order = 20)]
		public string sgt_competitie_omschrijving
		{
			get
			{
				return this.sgt_competitie_omschrijvingField;
			}
			set
			{
				this.sgt_competitie_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_competitie_omschrijving");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_competitietypeid
		{
			get
			{
				return this.sgt_competitietypeidField;
			}
			set
			{
				this.sgt_competitietypeidField = value;
				base.RaisePropertyChanged("sgt_competitietypeid");
			}
		}
		[XmlElement(Order = 22)]
		public CrmBoolean sgt_controle_vcl_certificaat
		{
			get
			{
				return this.sgt_controle_vcl_certificaatField;
			}
			set
			{
				this.sgt_controle_vcl_certificaatField = value;
				base.RaisePropertyChanged("sgt_controle_vcl_certificaat");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_dispensatie_ander_park
		{
			get
			{
				return this.sgt_dispensatie_ander_parkField;
			}
			set
			{
				this.sgt_dispensatie_ander_parkField = value;
				base.RaisePropertyChanged("sgt_dispensatie_ander_park");
			}
		}
		[XmlElement(Order = 24)]
		public CrmBoolean sgt_dispensatie_banen
		{
			get
			{
				return this.sgt_dispensatie_banenField;
			}
			set
			{
				this.sgt_dispensatie_banenField = value;
				base.RaisePropertyChanged("sgt_dispensatie_banen");
			}
		}
		[XmlElement(Order = 25)]
		public CrmBoolean sgt_dispensatie_geslacht
		{
			get
			{
				return this.sgt_dispensatie_geslachtField;
			}
			set
			{
				this.sgt_dispensatie_geslachtField = value;
				base.RaisePropertyChanged("sgt_dispensatie_geslacht");
			}
		}
		[XmlElement(Order = 26)]
		public CrmBoolean sgt_dispensatie_goedgekeurde_banen
		{
			get
			{
				return this.sgt_dispensatie_goedgekeurde_banenField;
			}
			set
			{
				this.sgt_dispensatie_goedgekeurde_banenField = value;
				base.RaisePropertyChanged("sgt_dispensatie_goedgekeurde_banen");
			}
		}
		[XmlElement(Order = 27)]
		public CrmBoolean sgt_dispensatie_leeftijd
		{
			get
			{
				return this.sgt_dispensatie_leeftijdField;
			}
			set
			{
				this.sgt_dispensatie_leeftijdField = value;
				base.RaisePropertyChanged("sgt_dispensatie_leeftijd");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
				base.RaisePropertyChanged("sgt_einddatum");
			}
		}
		[XmlElement(Order = 29)]
		public CrmDateTime sgt_einde_inschrijving
		{
			get
			{
				return this.sgt_einde_inschrijvingField;
			}
			set
			{
				this.sgt_einde_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_einde_inschrijving");
			}
		}
		[XmlElement(Order = 30)]
		public CrmNumber sgt_herinnering_dagen
		{
			get
			{
				return this.sgt_herinnering_dagenField;
			}
			set
			{
				this.sgt_herinnering_dagenField = value;
				base.RaisePropertyChanged("sgt_herinnering_dagen");
			}
		}
		[XmlElement(Order = 31)]
		public CrmDateTime sgt_herinneringsdatum
		{
			get
			{
				return this.sgt_herinneringsdatumField;
			}
			set
			{
				this.sgt_herinneringsdatumField = value;
				base.RaisePropertyChanged("sgt_herinneringsdatum");
			}
		}
		[XmlElement(Order = 32)]
		public Lookup sgt_herkomst_competitieid
		{
			get
			{
				return this.sgt_herkomst_competitieidField;
			}
			set
			{
				this.sgt_herkomst_competitieidField = value;
				base.RaisePropertyChanged("sgt_herkomst_competitieid");
			}
		}
		[XmlElement(Order = 33)]
		public Lookup sgt_inschrijfbijdrageid
		{
			get
			{
				return this.sgt_inschrijfbijdrageidField;
			}
			set
			{
				this.sgt_inschrijfbijdrageidField = value;
				base.RaisePropertyChanged("sgt_inschrijfbijdrageid");
			}
		}
		[XmlElement(Order = 34)]
		public CrmBoolean sgt_inschrijven_niet_knltb_leden_toegestaan
		{
			get
			{
				return this.sgt_inschrijven_niet_knltb_leden_toegestaanField;
			}
			set
			{
				this.sgt_inschrijven_niet_knltb_leden_toegestaanField = value;
				base.RaisePropertyChanged("sgt_inschrijven_niet_knltb_leden_toegestaan");
			}
		}
		[XmlElement(Order = 35)]
		public CrmBoolean sgt_kampioenschap
		{
			get
			{
				return this.sgt_kampioenschapField;
			}
			set
			{
				this.sgt_kampioenschapField = value;
				base.RaisePropertyChanged("sgt_kampioenschap");
			}
		}
		[XmlElement(Order = 36)]
		public CrmNumber sgt_max_ploegen_thuis
		{
			get
			{
				return this.sgt_max_ploegen_thuisField;
			}
			set
			{
				this.sgt_max_ploegen_thuisField = value;
				base.RaisePropertyChanged("sgt_max_ploegen_thuis");
			}
		}
		[XmlElement(Order = 37)]
		public Picklist sgt_max_te_spelen_sets
		{
			get
			{
				return this.sgt_max_te_spelen_setsField;
			}
			set
			{
				this.sgt_max_te_spelen_setsField = value;
				base.RaisePropertyChanged("sgt_max_te_spelen_sets");
			}
		}
		[XmlElement(Order = 38)]
		public CrmNumber sgt_min_ploegen_afdeling
		{
			get
			{
				return this.sgt_min_ploegen_afdelingField;
			}
			set
			{
				this.sgt_min_ploegen_afdelingField = value;
				base.RaisePropertyChanged("sgt_min_ploegen_afdeling");
			}
		}
		[XmlElement(Order = 39)]
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
				base.RaisePropertyChanged("sgt_plaats");
			}
		}
		[XmlElement(Order = 40)]
		public CrmNumber sgt_ploegen_ingeschreven
		{
			get
			{
				return this.sgt_ploegen_ingeschrevenField;
			}
			set
			{
				this.sgt_ploegen_ingeschrevenField = value;
				base.RaisePropertyChanged("sgt_ploegen_ingeschreven");
			}
		}
		[XmlElement(Order = 41)]
		public Lookup sgt_post_naarid
		{
			get
			{
				return this.sgt_post_naaridField;
			}
			set
			{
				this.sgt_post_naaridField = value;
				base.RaisePropertyChanged("sgt_post_naarid");
			}
		}
		[XmlElement(Order = 42)]
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
				base.RaisePropertyChanged("sgt_postcode");
			}
		}
		[XmlElement(Order = 43)]
		public CrmDateTime sgt_start_inschrijving
		{
			get
			{
				return this.sgt_start_inschrijvingField;
			}
			set
			{
				this.sgt_start_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_start_inschrijving");
			}
		}
		[XmlElement(Order = 44)]
		public Picklist sgt_status_competitie
		{
			get
			{
				return this.sgt_status_competitieField;
			}
			set
			{
				this.sgt_status_competitieField = value;
				base.RaisePropertyChanged("sgt_status_competitie");
			}
		}
		[XmlElement(Order = 45)]
		public Picklist sgt_status_mijnknltb
		{
			get
			{
				return this.sgt_status_mijnknltbField;
			}
			set
			{
				this.sgt_status_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_status_mijnknltb");
			}
		}
		[XmlElement(Order = 46)]
		public CrmBoolean sgt_thuis_thuis_schema
		{
			get
			{
				return this.sgt_thuis_thuis_schemaField;
			}
			set
			{
				this.sgt_thuis_thuis_schemaField = value;
				base.RaisePropertyChanged("sgt_thuis_thuis_schema");
			}
		}
		[XmlElement(Order = 47)]
		public Lookup sgt_tussentijdse_rating_peildatumid
		{
			get
			{
				return this.sgt_tussentijdse_rating_peildatumidField;
			}
			set
			{
				this.sgt_tussentijdse_rating_peildatumidField = value;
				base.RaisePropertyChanged("sgt_tussentijdse_rating_peildatumid");
			}
		}
		[XmlElement(Order = 48)]
		public CrmNumber sgt_verenigingen_ingeschreven
		{
			get
			{
				return this.sgt_verenigingen_ingeschrevenField;
			}
			set
			{
				this.sgt_verenigingen_ingeschrevenField = value;
				base.RaisePropertyChanged("sgt_verenigingen_ingeschreven");
			}
		}
		[XmlElement(Order = 49)]
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
		[XmlElement(Order = 50)]
		public Picklist sgt_verlichting_noodzakelijk
		{
			get
			{
				return this.sgt_verlichting_noodzakelijkField;
			}
			set
			{
				this.sgt_verlichting_noodzakelijkField = value;
				base.RaisePropertyChanged("sgt_verlichting_noodzakelijk");
			}
		}
		[XmlElement(Order = 51)]
		public CrmDateTime sgt_wedstrijdprogramma_aangemaakt
		{
			get
			{
				return this.sgt_wedstrijdprogramma_aangemaaktField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_aangemaaktField = value;
				base.RaisePropertyChanged("sgt_wedstrijdprogramma_aangemaakt");
			}
		}
		[XmlElement(Order = 52)]
		public Sgt_com_competitieStateInfo statecode
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
		[XmlElement(Order = 53)]
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
		[XmlElement(Order = 54)]
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
		[XmlElement(Order = 55)]
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
