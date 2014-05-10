using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooiafhandeling : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_aanhef_tavField;
		private CrmNumber sgt_aantal_banenField;
		private Lookup sgt_aanvraag_dagtoernooiidField;
		private Lookup sgt_aanvraag_dooridField;
		private Lookup sgt_accommodatieidField;
		private Lookup sgt_administratieidField;
		private Lookup sgt_afgewezen_door_idField;
		private string sgt_afsluiting_toernooi_omField;
		private string sgt_afwijkingenField;
		private Lookup sgt_annulering_behandeld_door_idField;
		private Lookup sgt_basisorganisatieidField;
		private CrmDateTime sgt_begindatumField;
		private CrmDateTime sgt_begindatum_werkelijkField;
		private CrmDateTime sgt_betalen_voorField;
		private CrmBoolean sgt_bgd_rapportage_ingeleverdField;
		private CrmMoney sgt_boete_bedragField;
		private CrmMoney sgt_boete_bedrag_baseField;
		private string sgt_boete_omschrijvingField;
		private Lookup sgt_boeteidField;
		private Lookup sgt_bondsgedelegeerde_idField;
		private Lookup sgt_bondsgedelegeerdeidField;
		private Lookup sgt_bondsorganisatie_idField;
		private CrmBoolean sgt_bulk_inschrijvingField;
		private Lookup sgt_contactpersoonidField;
		private CrmDateTime sgt_datum_aanvraag_dispensatieField;
		private CrmDateTime sgt_datum_afgewezenField;
		private CrmDateTime sgt_datum_annulering_afgehandeldField;
		private CrmDateTime sgt_datum_berichtField;
		private CrmDateTime sgt_datum_dispensatie_afgehandeldField;
		private CrmDateTime sgt_datum_melding_annulerenField;
		private Picklist sgt_definitieve_keuzeField;
		private Lookup sgt_dispensatie_afgehandeld_door_idField;
		private Lookup sgt_dispensatie_toernooibijdrageidField;
		private Lookup sgt_districtidField;
		private CrmNumber sgt_duur_partijenField;
		private CrmNumber sgt_duur_partijen_schemaField;
		private Lookup sgt_dynamisch_formulieridField;
		private CrmDateTime sgt_einddatumField;
		private CrmDateTime sgt_einddatum_werkelijkField;
		private string sgt_emailField;
		private CrmBoolean sgt_email_her_bondsgedelegeerde_rap_verstuurdField;
		private CrmBoolean sgt_email_her_wedstrijdleider_rap_verstuurdField;
		private CrmBoolean sgt_herinnering_voor_einde_inschrijving_jnField;
		private Lookup sgt_hoofdscheidsrechter_idField;
		private Lookup sgt_hoofdscheidsrechteridField;
		private string sgt_huisnummerField;
		private CrmBoolean sgt_individueel_inschrijvenField;
		private Lookup sgt_inhoud_aanvr_form_dagtoern_idField;
		private Lookup sgt_inhoud_aanvraagformulier_idField;
		private Picklist sgt_innen_inschrijfgeldField;
		private CrmMoney sgt_inschrijfgeldField;
		private CrmMoney sgt_inschrijfgeld_baseField;
		private CrmBoolean sgt_inschrijven_per_koppelField;
		private CrmDateTime sgt_inschrijven_tmField;
		private CrmDateTime sgt_inschrijven_vanafField;
		private CrmBoolean sgt_interfacesField;
		private CrmBoolean sgt_landelijkField;
		private CrmBoolean sgt_lunchField;
		private Picklist sgt_manier_van_bevestigenField;
		private CrmNumber sgt_max_aantal_partijenField;
		private Lookup sgt_meldingdooridField;
		private CrmBoolean sgt_niet_knltbField;
		private string sgt_ontvangsttijdField;
		private CrmBoolean sgt_op_afstandField;
		private string sgt_opmerking_tbv_mijnknltbField;
		private string sgt_opmerkingen_toernooiField;
		private CrmMoney sgt_ot_bijdrage_circuitField;
		private CrmMoney sgt_ot_bijdrage_circuit_baseField;
		private CrmMoney sgt_ot_handlingsfeeField;
		private CrmMoney sgt_ot_handlingsfee_baseField;
		private CrmMoney sgt_ot_inschrijfbijdrageField;
		private CrmMoney sgt_ot_inschrijfbijdrage_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_annulerenField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_annuleren_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_dispensatieField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_hf_annulerenField;
		private CrmMoney sgt_ot_restitutiebedrag_hf_annuleren_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_annulerenField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_annuleren_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_dispensatieField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie_baseField;
		private string sgt_partijen_starten_omField;
		private string sgt_plaatsnaamField;
		private string sgt_postcodeField;
		private string sgt_postcode_tmField;
		private string sgt_postcode_vanafField;
		private CrmBoolean sgt_publiceren_mijn_knltbField;
		private CrmBoolean sgt_rapportage_ingeleverd_wedstrijdleiderField;
		private Lookup sgt_reden_afwijzingidField;
		private Lookup sgt_reden_annuleren_toernooiidField;
		private string sgt_rekeningnummerField;
		private Picklist sgt_statusField;
		private Picklist sgt_status_dispensatieField;
		private CrmNumber sgt_straalField;
		private string sgt_straatField;
		private string sgt_telefoonnummerField;
		private string sgt_ten_name_vanField;
		private string sgt_toe_toernooiafhandeling1Field;
		private Key sgt_toe_toernooiafhandelingidField;
		private string sgt_toelichtingField;
		private string sgt_toelichting_afhandeling_annuleringField;
		private string sgt_toelichting_afwijzingField;
		private string sgt_toelichting_dispensatieField;
		private Lookup sgt_toernooi_afhandeling_vorig_jr_idField;
		private Lookup sgt_toernooi_in_district_idField;
		private Lookup sgt_toernooiidField;
		private string sgt_toernooinummerField;
		private Lookup sgt_toernooiorganisatie_idField;
		private Lookup sgt_toernooiorganisatie_oorspr_idField;
		private string sgt_toernooiplannernaamField;
		private string sgt_toernooiplannerversieField;
		private Lookup sgt_toernooisoortField;
		private string sgt_toevoegingField;
		private CrmBoolean sgt_verlichtingField;
		private CrmDateTime sgt_voorkeur_begindatum_1Field;
		private CrmDateTime sgt_voorkeur_begindatum_2Field;
		private CrmDateTime sgt_voorkeur_begindatum_3Field;
		private CrmDateTime sgt_voorkeur_einddatum_1Field;
		private CrmDateTime sgt_voorkeur_einddatum_2Field;
		private CrmDateTime sgt_voorkeur_einddatum_3Field;
		private string sgt_voorkeur_week_tm_1Field;
		private string sgt_voorkeur_week_tm_2Field;
		private string sgt_voorkeur_week_tm_3Field;
		private string sgt_voorkeur_week_vanaf_1Field;
		private string sgt_voorkeur_week_vanaf_2Field;
		private string sgt_voorkeur_week_vanaf_3Field;
		private string sgt_voorlooptekst1Field;
		private string sgt_voorlooptekst2Field;
		private string sgt_websiteField;
		private string sgt_wedstrijd_bepalingenField;
		private Lookup sgt_wedstrijdleideridField;
		private string sgt_weeknummer_beginField;
		private string sgt_weeknummer_tot_en_metField;
		private string sgt_zwaarteField;
		private Lookup sgt_zwaarteidField;
		private Sgt_toe_toernooiafhandelingStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
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
		public string sgt_aanhef_tav
		{
			get
			{
				return this.sgt_aanhef_tavField;
			}
			set
			{
				this.sgt_aanhef_tavField = value;
			}
		}
		public CrmNumber sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
			}
		}
		public Lookup sgt_aanvraag_dagtoernooiid
		{
			get
			{
				return this.sgt_aanvraag_dagtoernooiidField;
			}
			set
			{
				this.sgt_aanvraag_dagtoernooiidField = value;
			}
		}
		public Lookup sgt_aanvraag_doorid
		{
			get
			{
				return this.sgt_aanvraag_dooridField;
			}
			set
			{
				this.sgt_aanvraag_dooridField = value;
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
		public Lookup sgt_afgewezen_door_id
		{
			get
			{
				return this.sgt_afgewezen_door_idField;
			}
			set
			{
				this.sgt_afgewezen_door_idField = value;
			}
		}
		public string sgt_afsluiting_toernooi_om
		{
			get
			{
				return this.sgt_afsluiting_toernooi_omField;
			}
			set
			{
				this.sgt_afsluiting_toernooi_omField = value;
			}
		}
		public string sgt_afwijkingen
		{
			get
			{
				return this.sgt_afwijkingenField;
			}
			set
			{
				this.sgt_afwijkingenField = value;
			}
		}
		public Lookup sgt_annulering_behandeld_door_id
		{
			get
			{
				return this.sgt_annulering_behandeld_door_idField;
			}
			set
			{
				this.sgt_annulering_behandeld_door_idField = value;
			}
		}
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
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
		public CrmDateTime sgt_begindatum_werkelijk
		{
			get
			{
				return this.sgt_begindatum_werkelijkField;
			}
			set
			{
				this.sgt_begindatum_werkelijkField = value;
			}
		}
		public CrmDateTime sgt_betalen_voor
		{
			get
			{
				return this.sgt_betalen_voorField;
			}
			set
			{
				this.sgt_betalen_voorField = value;
			}
		}
		public CrmBoolean sgt_bgd_rapportage_ingeleverd
		{
			get
			{
				return this.sgt_bgd_rapportage_ingeleverdField;
			}
			set
			{
				this.sgt_bgd_rapportage_ingeleverdField = value;
			}
		}
		public CrmMoney sgt_boete_bedrag
		{
			get
			{
				return this.sgt_boete_bedragField;
			}
			set
			{
				this.sgt_boete_bedragField = value;
			}
		}
		public CrmMoney sgt_boete_bedrag_base
		{
			get
			{
				return this.sgt_boete_bedrag_baseField;
			}
			set
			{
				this.sgt_boete_bedrag_baseField = value;
			}
		}
		public string sgt_boete_omschrijving
		{
			get
			{
				return this.sgt_boete_omschrijvingField;
			}
			set
			{
				this.sgt_boete_omschrijvingField = value;
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
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
			}
		}
		public Lookup sgt_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeidField = value;
			}
		}
		public Lookup sgt_bondsorganisatie_id
		{
			get
			{
				return this.sgt_bondsorganisatie_idField;
			}
			set
			{
				this.sgt_bondsorganisatie_idField = value;
			}
		}
		public CrmBoolean sgt_bulk_inschrijving
		{
			get
			{
				return this.sgt_bulk_inschrijvingField;
			}
			set
			{
				this.sgt_bulk_inschrijvingField = value;
			}
		}
		public Lookup sgt_contactpersoonid
		{
			get
			{
				return this.sgt_contactpersoonidField;
			}
			set
			{
				this.sgt_contactpersoonidField = value;
			}
		}
		public CrmDateTime sgt_datum_aanvraag_dispensatie
		{
			get
			{
				return this.sgt_datum_aanvraag_dispensatieField;
			}
			set
			{
				this.sgt_datum_aanvraag_dispensatieField = value;
			}
		}
		public CrmDateTime sgt_datum_afgewezen
		{
			get
			{
				return this.sgt_datum_afgewezenField;
			}
			set
			{
				this.sgt_datum_afgewezenField = value;
			}
		}
		public CrmDateTime sgt_datum_annulering_afgehandeld
		{
			get
			{
				return this.sgt_datum_annulering_afgehandeldField;
			}
			set
			{
				this.sgt_datum_annulering_afgehandeldField = value;
			}
		}
		public CrmDateTime sgt_datum_bericht
		{
			get
			{
				return this.sgt_datum_berichtField;
			}
			set
			{
				this.sgt_datum_berichtField = value;
			}
		}
		public CrmDateTime sgt_datum_dispensatie_afgehandeld
		{
			get
			{
				return this.sgt_datum_dispensatie_afgehandeldField;
			}
			set
			{
				this.sgt_datum_dispensatie_afgehandeldField = value;
			}
		}
		public CrmDateTime sgt_datum_melding_annuleren
		{
			get
			{
				return this.sgt_datum_melding_annulerenField;
			}
			set
			{
				this.sgt_datum_melding_annulerenField = value;
			}
		}
		public Picklist sgt_definitieve_keuze
		{
			get
			{
				return this.sgt_definitieve_keuzeField;
			}
			set
			{
				this.sgt_definitieve_keuzeField = value;
			}
		}
		public Lookup sgt_dispensatie_afgehandeld_door_id
		{
			get
			{
				return this.sgt_dispensatie_afgehandeld_door_idField;
			}
			set
			{
				this.sgt_dispensatie_afgehandeld_door_idField = value;
			}
		}
		public Lookup sgt_dispensatie_toernooibijdrageid
		{
			get
			{
				return this.sgt_dispensatie_toernooibijdrageidField;
			}
			set
			{
				this.sgt_dispensatie_toernooibijdrageidField = value;
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
		public CrmNumber sgt_duur_partijen
		{
			get
			{
				return this.sgt_duur_partijenField;
			}
			set
			{
				this.sgt_duur_partijenField = value;
			}
		}
		public CrmNumber sgt_duur_partijen_schema
		{
			get
			{
				return this.sgt_duur_partijen_schemaField;
			}
			set
			{
				this.sgt_duur_partijen_schemaField = value;
			}
		}
		public Lookup sgt_dynamisch_formulierid
		{
			get
			{
				return this.sgt_dynamisch_formulieridField;
			}
			set
			{
				this.sgt_dynamisch_formulieridField = value;
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
		public CrmDateTime sgt_einddatum_werkelijk
		{
			get
			{
				return this.sgt_einddatum_werkelijkField;
			}
			set
			{
				this.sgt_einddatum_werkelijkField = value;
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
		public CrmBoolean sgt_email_her_bondsgedelegeerde_rap_verstuurd
		{
			get
			{
				return this.sgt_email_her_bondsgedelegeerde_rap_verstuurdField;
			}
			set
			{
				this.sgt_email_her_bondsgedelegeerde_rap_verstuurdField = value;
			}
		}
		public CrmBoolean sgt_email_her_wedstrijdleider_rap_verstuurd
		{
			get
			{
				return this.sgt_email_her_wedstrijdleider_rap_verstuurdField;
			}
			set
			{
				this.sgt_email_her_wedstrijdleider_rap_verstuurdField = value;
			}
		}
		public CrmBoolean sgt_herinnering_voor_einde_inschrijving_jn
		{
			get
			{
				return this.sgt_herinnering_voor_einde_inschrijving_jnField;
			}
			set
			{
				this.sgt_herinnering_voor_einde_inschrijving_jnField = value;
			}
		}
		public Lookup sgt_hoofdscheidsrechter_id
		{
			get
			{
				return this.sgt_hoofdscheidsrechter_idField;
			}
			set
			{
				this.sgt_hoofdscheidsrechter_idField = value;
			}
		}
		public Lookup sgt_hoofdscheidsrechterid
		{
			get
			{
				return this.sgt_hoofdscheidsrechteridField;
			}
			set
			{
				this.sgt_hoofdscheidsrechteridField = value;
			}
		}
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
			}
		}
		public CrmBoolean sgt_individueel_inschrijven
		{
			get
			{
				return this.sgt_individueel_inschrijvenField;
			}
			set
			{
				this.sgt_individueel_inschrijvenField = value;
			}
		}
		public Lookup sgt_inhoud_aanvr_form_dagtoern_id
		{
			get
			{
				return this.sgt_inhoud_aanvr_form_dagtoern_idField;
			}
			set
			{
				this.sgt_inhoud_aanvr_form_dagtoern_idField = value;
			}
		}
		public Lookup sgt_inhoud_aanvraagformulier_id
		{
			get
			{
				return this.sgt_inhoud_aanvraagformulier_idField;
			}
			set
			{
				this.sgt_inhoud_aanvraagformulier_idField = value;
			}
		}
		public Picklist sgt_innen_inschrijfgeld
		{
			get
			{
				return this.sgt_innen_inschrijfgeldField;
			}
			set
			{
				this.sgt_innen_inschrijfgeldField = value;
			}
		}
		public CrmMoney sgt_inschrijfgeld
		{
			get
			{
				return this.sgt_inschrijfgeldField;
			}
			set
			{
				this.sgt_inschrijfgeldField = value;
			}
		}
		public CrmMoney sgt_inschrijfgeld_base
		{
			get
			{
				return this.sgt_inschrijfgeld_baseField;
			}
			set
			{
				this.sgt_inschrijfgeld_baseField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_per_koppel
		{
			get
			{
				return this.sgt_inschrijven_per_koppelField;
			}
			set
			{
				this.sgt_inschrijven_per_koppelField = value;
			}
		}
		public CrmDateTime sgt_inschrijven_tm
		{
			get
			{
				return this.sgt_inschrijven_tmField;
			}
			set
			{
				this.sgt_inschrijven_tmField = value;
			}
		}
		public CrmDateTime sgt_inschrijven_vanaf
		{
			get
			{
				return this.sgt_inschrijven_vanafField;
			}
			set
			{
				this.sgt_inschrijven_vanafField = value;
			}
		}
		public CrmBoolean sgt_interfaces
		{
			get
			{
				return this.sgt_interfacesField;
			}
			set
			{
				this.sgt_interfacesField = value;
			}
		}
		public CrmBoolean sgt_landelijk
		{
			get
			{
				return this.sgt_landelijkField;
			}
			set
			{
				this.sgt_landelijkField = value;
			}
		}
		public CrmBoolean sgt_lunch
		{
			get
			{
				return this.sgt_lunchField;
			}
			set
			{
				this.sgt_lunchField = value;
			}
		}
		public Picklist sgt_manier_van_bevestigen
		{
			get
			{
				return this.sgt_manier_van_bevestigenField;
			}
			set
			{
				this.sgt_manier_van_bevestigenField = value;
			}
		}
		public CrmNumber sgt_max_aantal_partijen
		{
			get
			{
				return this.sgt_max_aantal_partijenField;
			}
			set
			{
				this.sgt_max_aantal_partijenField = value;
			}
		}
		public Lookup sgt_meldingdoorid
		{
			get
			{
				return this.sgt_meldingdooridField;
			}
			set
			{
				this.sgt_meldingdooridField = value;
			}
		}
		public CrmBoolean sgt_niet_knltb
		{
			get
			{
				return this.sgt_niet_knltbField;
			}
			set
			{
				this.sgt_niet_knltbField = value;
			}
		}
		public string sgt_ontvangsttijd
		{
			get
			{
				return this.sgt_ontvangsttijdField;
			}
			set
			{
				this.sgt_ontvangsttijdField = value;
			}
		}
		public CrmBoolean sgt_op_afstand
		{
			get
			{
				return this.sgt_op_afstandField;
			}
			set
			{
				this.sgt_op_afstandField = value;
			}
		}
		public string sgt_opmerking_tbv_mijnknltb
		{
			get
			{
				return this.sgt_opmerking_tbv_mijnknltbField;
			}
			set
			{
				this.sgt_opmerking_tbv_mijnknltbField = value;
			}
		}
		public string sgt_opmerkingen_toernooi
		{
			get
			{
				return this.sgt_opmerkingen_toernooiField;
			}
			set
			{
				this.sgt_opmerkingen_toernooiField = value;
			}
		}
		public CrmMoney sgt_ot_bijdrage_circuit
		{
			get
			{
				return this.sgt_ot_bijdrage_circuitField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuitField = value;
			}
		}
		public CrmMoney sgt_ot_bijdrage_circuit_base
		{
			get
			{
				return this.sgt_ot_bijdrage_circuit_baseField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuit_baseField = value;
			}
		}
		public CrmMoney sgt_ot_handlingsfee
		{
			get
			{
				return this.sgt_ot_handlingsfeeField;
			}
			set
			{
				this.sgt_ot_handlingsfeeField = value;
			}
		}
		public CrmMoney sgt_ot_handlingsfee_base
		{
			get
			{
				return this.sgt_ot_handlingsfee_baseField;
			}
			set
			{
				this.sgt_ot_handlingsfee_baseField = value;
			}
		}
		public CrmMoney sgt_ot_inschrijfbijdrage
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrageField = value;
			}
		}
		public CrmMoney sgt_ot_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrage_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annulerenField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annuleren_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatieField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annulerenField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annuleren_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annulerenField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annuleren_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatieField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField = value;
			}
		}
		public string sgt_partijen_starten_om
		{
			get
			{
				return this.sgt_partijen_starten_omField;
			}
			set
			{
				this.sgt_partijen_starten_omField = value;
			}
		}
		public string sgt_plaatsnaam
		{
			get
			{
				return this.sgt_plaatsnaamField;
			}
			set
			{
				this.sgt_plaatsnaamField = value;
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
		public string sgt_postcode_tm
		{
			get
			{
				return this.sgt_postcode_tmField;
			}
			set
			{
				this.sgt_postcode_tmField = value;
			}
		}
		public string sgt_postcode_vanaf
		{
			get
			{
				return this.sgt_postcode_vanafField;
			}
			set
			{
				this.sgt_postcode_vanafField = value;
			}
		}
		public CrmBoolean sgt_publiceren_mijn_knltb
		{
			get
			{
				return this.sgt_publiceren_mijn_knltbField;
			}
			set
			{
				this.sgt_publiceren_mijn_knltbField = value;
			}
		}
		public CrmBoolean sgt_rapportage_ingeleverd_wedstrijdleider
		{
			get
			{
				return this.sgt_rapportage_ingeleverd_wedstrijdleiderField;
			}
			set
			{
				this.sgt_rapportage_ingeleverd_wedstrijdleiderField = value;
			}
		}
		public Lookup sgt_reden_afwijzingid
		{
			get
			{
				return this.sgt_reden_afwijzingidField;
			}
			set
			{
				this.sgt_reden_afwijzingidField = value;
			}
		}
		public Lookup sgt_reden_annuleren_toernooiid
		{
			get
			{
				return this.sgt_reden_annuleren_toernooiidField;
			}
			set
			{
				this.sgt_reden_annuleren_toernooiidField = value;
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
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public Picklist sgt_status_dispensatie
		{
			get
			{
				return this.sgt_status_dispensatieField;
			}
			set
			{
				this.sgt_status_dispensatieField = value;
			}
		}
		public CrmNumber sgt_straal
		{
			get
			{
				return this.sgt_straalField;
			}
			set
			{
				this.sgt_straalField = value;
			}
		}
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
			}
		}
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
			}
		}
		public string sgt_ten_name_van
		{
			get
			{
				return this.sgt_ten_name_vanField;
			}
			set
			{
				this.sgt_ten_name_vanField = value;
			}
		}
		[XmlElement("sgt_toe_toernooiafhandeling")]
		public string sgt_toe_toernooiafhandeling1
		{
			get
			{
				return this.sgt_toe_toernooiafhandeling1Field;
			}
			set
			{
				this.sgt_toe_toernooiafhandeling1Field = value;
			}
		}
		public Key sgt_toe_toernooiafhandelingid
		{
			get
			{
				return this.sgt_toe_toernooiafhandelingidField;
			}
			set
			{
				this.sgt_toe_toernooiafhandelingidField = value;
			}
		}
		public string sgt_toelichting
		{
			get
			{
				return this.sgt_toelichtingField;
			}
			set
			{
				this.sgt_toelichtingField = value;
			}
		}
		public string sgt_toelichting_afhandeling_annulering
		{
			get
			{
				return this.sgt_toelichting_afhandeling_annuleringField;
			}
			set
			{
				this.sgt_toelichting_afhandeling_annuleringField = value;
			}
		}
		public string sgt_toelichting_afwijzing
		{
			get
			{
				return this.sgt_toelichting_afwijzingField;
			}
			set
			{
				this.sgt_toelichting_afwijzingField = value;
			}
		}
		public string sgt_toelichting_dispensatie
		{
			get
			{
				return this.sgt_toelichting_dispensatieField;
			}
			set
			{
				this.sgt_toelichting_dispensatieField = value;
			}
		}
		public Lookup sgt_toernooi_afhandeling_vorig_jr_id
		{
			get
			{
				return this.sgt_toernooi_afhandeling_vorig_jr_idField;
			}
			set
			{
				this.sgt_toernooi_afhandeling_vorig_jr_idField = value;
			}
		}
		public Lookup sgt_toernooi_in_district_id
		{
			get
			{
				return this.sgt_toernooi_in_district_idField;
			}
			set
			{
				this.sgt_toernooi_in_district_idField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
			}
		}
		public Lookup sgt_toernooiorganisatie_id
		{
			get
			{
				return this.sgt_toernooiorganisatie_idField;
			}
			set
			{
				this.sgt_toernooiorganisatie_idField = value;
			}
		}
		public Lookup sgt_toernooiorganisatie_oorspr_id
		{
			get
			{
				return this.sgt_toernooiorganisatie_oorspr_idField;
			}
			set
			{
				this.sgt_toernooiorganisatie_oorspr_idField = value;
			}
		}
		public string sgt_toernooiplannernaam
		{
			get
			{
				return this.sgt_toernooiplannernaamField;
			}
			set
			{
				this.sgt_toernooiplannernaamField = value;
			}
		}
		public string sgt_toernooiplannerversie
		{
			get
			{
				return this.sgt_toernooiplannerversieField;
			}
			set
			{
				this.sgt_toernooiplannerversieField = value;
			}
		}
		public Lookup sgt_toernooisoort
		{
			get
			{
				return this.sgt_toernooisoortField;
			}
			set
			{
				this.sgt_toernooisoortField = value;
			}
		}
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
			}
		}
		public CrmBoolean sgt_verlichting
		{
			get
			{
				return this.sgt_verlichtingField;
			}
			set
			{
				this.sgt_verlichtingField = value;
			}
		}
		public CrmDateTime sgt_voorkeur_begindatum_1
		{
			get
			{
				return this.sgt_voorkeur_begindatum_1Field;
			}
			set
			{
				this.sgt_voorkeur_begindatum_1Field = value;
			}
		}
		public CrmDateTime sgt_voorkeur_begindatum_2
		{
			get
			{
				return this.sgt_voorkeur_begindatum_2Field;
			}
			set
			{
				this.sgt_voorkeur_begindatum_2Field = value;
			}
		}
		public CrmDateTime sgt_voorkeur_begindatum_3
		{
			get
			{
				return this.sgt_voorkeur_begindatum_3Field;
			}
			set
			{
				this.sgt_voorkeur_begindatum_3Field = value;
			}
		}
		public CrmDateTime sgt_voorkeur_einddatum_1
		{
			get
			{
				return this.sgt_voorkeur_einddatum_1Field;
			}
			set
			{
				this.sgt_voorkeur_einddatum_1Field = value;
			}
		}
		public CrmDateTime sgt_voorkeur_einddatum_2
		{
			get
			{
				return this.sgt_voorkeur_einddatum_2Field;
			}
			set
			{
				this.sgt_voorkeur_einddatum_2Field = value;
			}
		}
		public CrmDateTime sgt_voorkeur_einddatum_3
		{
			get
			{
				return this.sgt_voorkeur_einddatum_3Field;
			}
			set
			{
				this.sgt_voorkeur_einddatum_3Field = value;
			}
		}
		public string sgt_voorkeur_week_tm_1
		{
			get
			{
				return this.sgt_voorkeur_week_tm_1Field;
			}
			set
			{
				this.sgt_voorkeur_week_tm_1Field = value;
			}
		}
		public string sgt_voorkeur_week_tm_2
		{
			get
			{
				return this.sgt_voorkeur_week_tm_2Field;
			}
			set
			{
				this.sgt_voorkeur_week_tm_2Field = value;
			}
		}
		public string sgt_voorkeur_week_tm_3
		{
			get
			{
				return this.sgt_voorkeur_week_tm_3Field;
			}
			set
			{
				this.sgt_voorkeur_week_tm_3Field = value;
			}
		}
		public string sgt_voorkeur_week_vanaf_1
		{
			get
			{
				return this.sgt_voorkeur_week_vanaf_1Field;
			}
			set
			{
				this.sgt_voorkeur_week_vanaf_1Field = value;
			}
		}
		public string sgt_voorkeur_week_vanaf_2
		{
			get
			{
				return this.sgt_voorkeur_week_vanaf_2Field;
			}
			set
			{
				this.sgt_voorkeur_week_vanaf_2Field = value;
			}
		}
		public string sgt_voorkeur_week_vanaf_3
		{
			get
			{
				return this.sgt_voorkeur_week_vanaf_3Field;
			}
			set
			{
				this.sgt_voorkeur_week_vanaf_3Field = value;
			}
		}
		public string sgt_voorlooptekst1
		{
			get
			{
				return this.sgt_voorlooptekst1Field;
			}
			set
			{
				this.sgt_voorlooptekst1Field = value;
			}
		}
		public string sgt_voorlooptekst2
		{
			get
			{
				return this.sgt_voorlooptekst2Field;
			}
			set
			{
				this.sgt_voorlooptekst2Field = value;
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
		public string sgt_wedstrijd_bepalingen
		{
			get
			{
				return this.sgt_wedstrijd_bepalingenField;
			}
			set
			{
				this.sgt_wedstrijd_bepalingenField = value;
			}
		}
		public Lookup sgt_wedstrijdleiderid
		{
			get
			{
				return this.sgt_wedstrijdleideridField;
			}
			set
			{
				this.sgt_wedstrijdleideridField = value;
			}
		}
		public string sgt_weeknummer_begin
		{
			get
			{
				return this.sgt_weeknummer_beginField;
			}
			set
			{
				this.sgt_weeknummer_beginField = value;
			}
		}
		public string sgt_weeknummer_tot_en_met
		{
			get
			{
				return this.sgt_weeknummer_tot_en_metField;
			}
			set
			{
				this.sgt_weeknummer_tot_en_metField = value;
			}
		}
		public string sgt_zwaarte
		{
			get
			{
				return this.sgt_zwaarteField;
			}
			set
			{
				this.sgt_zwaarteField = value;
			}
		}
		public Lookup sgt_zwaarteid
		{
			get
			{
				return this.sgt_zwaarteidField;
			}
			set
			{
				this.sgt_zwaarteidField = value;
			}
		}
		public Sgt_toe_toernooiafhandelingStateInfo statecode
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
	}
}
