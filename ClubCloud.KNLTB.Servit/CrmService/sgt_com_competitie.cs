using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmNumber sgt_aantal_vrije_afdelingnummers
		{
			get
			{
				return this.sgt_aantal_vrije_afdelingnummersField;
			}
			set
			{
				this.sgt_aantal_vrije_afdelingnummersField = value;
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
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
			}
		}
		public CrmBoolean sgt_baancontrole
		{
			get
			{
				return this.sgt_baancontroleField;
			}
			set
			{
				this.sgt_baancontroleField = value;
			}
		}
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
			}
		}
		public Picklist sgt_benodigde_banen
		{
			get
			{
				return this.sgt_benodigde_banenField;
			}
			set
			{
				this.sgt_benodigde_banenField = value;
			}
		}
		public CrmBoolean sgt_bericht_inschrijving
		{
			get
			{
				return this.sgt_bericht_inschrijvingField;
			}
			set
			{
				this.sgt_bericht_inschrijvingField = value;
			}
		}
		public Lookup sgt_boeteid
		{
			get
			{
				return this.sgt_boeteidField;
			}
			set
			{
				this.sgt_boeteidField = value;
			}
		}
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
			}
		}
		[XmlElement("sgt_com_competitie")]
		public string sgt_com_competitie1
		{
			get
			{
				return this.sgt_com_competitie1Field;
			}
			set
			{
				this.sgt_com_competitie1Field = value;
			}
		}
		public Key sgt_com_competitieid
		{
			get
			{
				return this.sgt_com_competitieidField;
			}
			set
			{
				this.sgt_com_competitieidField = value;
			}
		}
		public Lookup sgt_competitie_kalenderid
		{
			get
			{
				return this.sgt_competitie_kalenderidField;
			}
			set
			{
				this.sgt_competitie_kalenderidField = value;
			}
		}
		public string sgt_competitie_omschrijving
		{
			get
			{
				return this.sgt_competitie_omschrijvingField;
			}
			set
			{
				this.sgt_competitie_omschrijvingField = value;
			}
		}
		public Lookup sgt_competitietypeid
		{
			get
			{
				return this.sgt_competitietypeidField;
			}
			set
			{
				this.sgt_competitietypeidField = value;
			}
		}
		public CrmBoolean sgt_controle_vcl_certificaat
		{
			get
			{
				return this.sgt_controle_vcl_certificaatField;
			}
			set
			{
				this.sgt_controle_vcl_certificaatField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_ander_park
		{
			get
			{
				return this.sgt_dispensatie_ander_parkField;
			}
			set
			{
				this.sgt_dispensatie_ander_parkField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_banen
		{
			get
			{
				return this.sgt_dispensatie_banenField;
			}
			set
			{
				this.sgt_dispensatie_banenField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_geslacht
		{
			get
			{
				return this.sgt_dispensatie_geslachtField;
			}
			set
			{
				this.sgt_dispensatie_geslachtField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_goedgekeurde_banen
		{
			get
			{
				return this.sgt_dispensatie_goedgekeurde_banenField;
			}
			set
			{
				this.sgt_dispensatie_goedgekeurde_banenField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_leeftijd
		{
			get
			{
				return this.sgt_dispensatie_leeftijdField;
			}
			set
			{
				this.sgt_dispensatie_leeftijdField = value;
			}
		}
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
			}
		}
		public CrmDateTime sgt_einde_inschrijving
		{
			get
			{
				return this.sgt_einde_inschrijvingField;
			}
			set
			{
				this.sgt_einde_inschrijvingField = value;
			}
		}
		public CrmNumber sgt_herinnering_dagen
		{
			get
			{
				return this.sgt_herinnering_dagenField;
			}
			set
			{
				this.sgt_herinnering_dagenField = value;
			}
		}
		public CrmDateTime sgt_herinneringsdatum
		{
			get
			{
				return this.sgt_herinneringsdatumField;
			}
			set
			{
				this.sgt_herinneringsdatumField = value;
			}
		}
		public Lookup sgt_herkomst_competitieid
		{
			get
			{
				return this.sgt_herkomst_competitieidField;
			}
			set
			{
				this.sgt_herkomst_competitieidField = value;
			}
		}
		public Lookup sgt_inschrijfbijdrageid
		{
			get
			{
				return this.sgt_inschrijfbijdrageidField;
			}
			set
			{
				this.sgt_inschrijfbijdrageidField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_niet_knltb_leden_toegestaan
		{
			get
			{
				return this.sgt_inschrijven_niet_knltb_leden_toegestaanField;
			}
			set
			{
				this.sgt_inschrijven_niet_knltb_leden_toegestaanField = value;
			}
		}
		public CrmBoolean sgt_kampioenschap
		{
			get
			{
				return this.sgt_kampioenschapField;
			}
			set
			{
				this.sgt_kampioenschapField = value;
			}
		}
		public CrmNumber sgt_max_ploegen_thuis
		{
			get
			{
				return this.sgt_max_ploegen_thuisField;
			}
			set
			{
				this.sgt_max_ploegen_thuisField = value;
			}
		}
		public Picklist sgt_max_te_spelen_sets
		{
			get
			{
				return this.sgt_max_te_spelen_setsField;
			}
			set
			{
				this.sgt_max_te_spelen_setsField = value;
			}
		}
		public CrmNumber sgt_min_ploegen_afdeling
		{
			get
			{
				return this.sgt_min_ploegen_afdelingField;
			}
			set
			{
				this.sgt_min_ploegen_afdelingField = value;
			}
		}
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
			}
		}
		public CrmNumber sgt_ploegen_ingeschreven
		{
			get
			{
				return this.sgt_ploegen_ingeschrevenField;
			}
			set
			{
				this.sgt_ploegen_ingeschrevenField = value;
			}
		}
		public Lookup sgt_post_naarid
		{
			get
			{
				return this.sgt_post_naaridField;
			}
			set
			{
				this.sgt_post_naaridField = value;
			}
		}
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
			}
		}
		public CrmDateTime sgt_start_inschrijving
		{
			get
			{
				return this.sgt_start_inschrijvingField;
			}
			set
			{
				this.sgt_start_inschrijvingField = value;
			}
		}
		public Picklist sgt_status_competitie
		{
			get
			{
				return this.sgt_status_competitieField;
			}
			set
			{
				this.sgt_status_competitieField = value;
			}
		}
		public Picklist sgt_status_mijnknltb
		{
			get
			{
				return this.sgt_status_mijnknltbField;
			}
			set
			{
				this.sgt_status_mijnknltbField = value;
			}
		}
		public CrmBoolean sgt_thuis_thuis_schema
		{
			get
			{
				return this.sgt_thuis_thuis_schemaField;
			}
			set
			{
				this.sgt_thuis_thuis_schemaField = value;
			}
		}
		public Lookup sgt_tussentijdse_rating_peildatumid
		{
			get
			{
				return this.sgt_tussentijdse_rating_peildatumidField;
			}
			set
			{
				this.sgt_tussentijdse_rating_peildatumidField = value;
			}
		}
		public CrmNumber sgt_verenigingen_ingeschreven
		{
			get
			{
				return this.sgt_verenigingen_ingeschrevenField;
			}
			set
			{
				this.sgt_verenigingen_ingeschrevenField = value;
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
		public Picklist sgt_verlichting_noodzakelijk
		{
			get
			{
				return this.sgt_verlichting_noodzakelijkField;
			}
			set
			{
				this.sgt_verlichting_noodzakelijkField = value;
			}
		}
		public CrmDateTime sgt_wedstrijdprogramma_aangemaakt
		{
			get
			{
				return this.sgt_wedstrijdprogramma_aangemaaktField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_aangemaaktField = value;
			}
		}
		public Sgt_com_competitieStateInfo statecode
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
