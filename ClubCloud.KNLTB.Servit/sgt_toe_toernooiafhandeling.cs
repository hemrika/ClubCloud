using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public string sgt_aanhef_tav
		{
			get
			{
				return this.sgt_aanhef_tavField;
			}
			set
			{
				this.sgt_aanhef_tavField = value;
				base.RaisePropertyChanged("sgt_aanhef_tav");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
				base.RaisePropertyChanged("sgt_aantal_banen");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_aanvraag_dagtoernooiid
		{
			get
			{
				return this.sgt_aanvraag_dagtoernooiidField;
			}
			set
			{
				this.sgt_aanvraag_dagtoernooiidField = value;
				base.RaisePropertyChanged("sgt_aanvraag_dagtoernooiid");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_aanvraag_doorid
		{
			get
			{
				return this.sgt_aanvraag_dooridField;
			}
			set
			{
				this.sgt_aanvraag_dooridField = value;
				base.RaisePropertyChanged("sgt_aanvraag_doorid");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Lookup sgt_afgewezen_door_id
		{
			get
			{
				return this.sgt_afgewezen_door_idField;
			}
			set
			{
				this.sgt_afgewezen_door_idField = value;
				base.RaisePropertyChanged("sgt_afgewezen_door_id");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_afsluiting_toernooi_om
		{
			get
			{
				return this.sgt_afsluiting_toernooi_omField;
			}
			set
			{
				this.sgt_afsluiting_toernooi_omField = value;
				base.RaisePropertyChanged("sgt_afsluiting_toernooi_om");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_afwijkingen
		{
			get
			{
				return this.sgt_afwijkingenField;
			}
			set
			{
				this.sgt_afwijkingenField = value;
				base.RaisePropertyChanged("sgt_afwijkingen");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_annulering_behandeld_door_id
		{
			get
			{
				return this.sgt_annulering_behandeld_door_idField;
			}
			set
			{
				this.sgt_annulering_behandeld_door_idField = value;
				base.RaisePropertyChanged("sgt_annulering_behandeld_door_id");
			}
		}
		[XmlElement(Order = 19)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
		public CrmDateTime sgt_begindatum_werkelijk
		{
			get
			{
				return this.sgt_begindatum_werkelijkField;
			}
			set
			{
				this.sgt_begindatum_werkelijkField = value;
				base.RaisePropertyChanged("sgt_begindatum_werkelijk");
			}
		}
		[XmlElement(Order = 22)]
		public CrmDateTime sgt_betalen_voor
		{
			get
			{
				return this.sgt_betalen_voorField;
			}
			set
			{
				this.sgt_betalen_voorField = value;
				base.RaisePropertyChanged("sgt_betalen_voor");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_bgd_rapportage_ingeleverd
		{
			get
			{
				return this.sgt_bgd_rapportage_ingeleverdField;
			}
			set
			{
				this.sgt_bgd_rapportage_ingeleverdField = value;
				base.RaisePropertyChanged("sgt_bgd_rapportage_ingeleverd");
			}
		}
		[XmlElement(Order = 24)]
		public CrmMoney sgt_boete_bedrag
		{
			get
			{
				return this.sgt_boete_bedragField;
			}
			set
			{
				this.sgt_boete_bedragField = value;
				base.RaisePropertyChanged("sgt_boete_bedrag");
			}
		}
		[XmlElement(Order = 25)]
		public CrmMoney sgt_boete_bedrag_base
		{
			get
			{
				return this.sgt_boete_bedrag_baseField;
			}
			set
			{
				this.sgt_boete_bedrag_baseField = value;
				base.RaisePropertyChanged("sgt_boete_bedrag_base");
			}
		}
		[XmlElement(Order = 26)]
		public string sgt_boete_omschrijving
		{
			get
			{
				return this.sgt_boete_omschrijvingField;
			}
			set
			{
				this.sgt_boete_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_boete_omschrijving");
			}
		}
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerde_id");
			}
		}
		[XmlElement(Order = 29)]
		public Lookup sgt_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeidField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerdeid");
			}
		}
		[XmlElement(Order = 30)]
		public Lookup sgt_bondsorganisatie_id
		{
			get
			{
				return this.sgt_bondsorganisatie_idField;
			}
			set
			{
				this.sgt_bondsorganisatie_idField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatie_id");
			}
		}
		[XmlElement(Order = 31)]
		public CrmBoolean sgt_bulk_inschrijving
		{
			get
			{
				return this.sgt_bulk_inschrijvingField;
			}
			set
			{
				this.sgt_bulk_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_bulk_inschrijving");
			}
		}
		[XmlElement(Order = 32)]
		public Lookup sgt_contactpersoonid
		{
			get
			{
				return this.sgt_contactpersoonidField;
			}
			set
			{
				this.sgt_contactpersoonidField = value;
				base.RaisePropertyChanged("sgt_contactpersoonid");
			}
		}
		[XmlElement(Order = 33)]
		public CrmDateTime sgt_datum_aanvraag_dispensatie
		{
			get
			{
				return this.sgt_datum_aanvraag_dispensatieField;
			}
			set
			{
				this.sgt_datum_aanvraag_dispensatieField = value;
				base.RaisePropertyChanged("sgt_datum_aanvraag_dispensatie");
			}
		}
		[XmlElement(Order = 34)]
		public CrmDateTime sgt_datum_afgewezen
		{
			get
			{
				return this.sgt_datum_afgewezenField;
			}
			set
			{
				this.sgt_datum_afgewezenField = value;
				base.RaisePropertyChanged("sgt_datum_afgewezen");
			}
		}
		[XmlElement(Order = 35)]
		public CrmDateTime sgt_datum_annulering_afgehandeld
		{
			get
			{
				return this.sgt_datum_annulering_afgehandeldField;
			}
			set
			{
				this.sgt_datum_annulering_afgehandeldField = value;
				base.RaisePropertyChanged("sgt_datum_annulering_afgehandeld");
			}
		}
		[XmlElement(Order = 36)]
		public CrmDateTime sgt_datum_bericht
		{
			get
			{
				return this.sgt_datum_berichtField;
			}
			set
			{
				this.sgt_datum_berichtField = value;
				base.RaisePropertyChanged("sgt_datum_bericht");
			}
		}
		[XmlElement(Order = 37)]
		public CrmDateTime sgt_datum_dispensatie_afgehandeld
		{
			get
			{
				return this.sgt_datum_dispensatie_afgehandeldField;
			}
			set
			{
				this.sgt_datum_dispensatie_afgehandeldField = value;
				base.RaisePropertyChanged("sgt_datum_dispensatie_afgehandeld");
			}
		}
		[XmlElement(Order = 38)]
		public CrmDateTime sgt_datum_melding_annuleren
		{
			get
			{
				return this.sgt_datum_melding_annulerenField;
			}
			set
			{
				this.sgt_datum_melding_annulerenField = value;
				base.RaisePropertyChanged("sgt_datum_melding_annuleren");
			}
		}
		[XmlElement(Order = 39)]
		public Picklist sgt_definitieve_keuze
		{
			get
			{
				return this.sgt_definitieve_keuzeField;
			}
			set
			{
				this.sgt_definitieve_keuzeField = value;
				base.RaisePropertyChanged("sgt_definitieve_keuze");
			}
		}
		[XmlElement(Order = 40)]
		public Lookup sgt_dispensatie_afgehandeld_door_id
		{
			get
			{
				return this.sgt_dispensatie_afgehandeld_door_idField;
			}
			set
			{
				this.sgt_dispensatie_afgehandeld_door_idField = value;
				base.RaisePropertyChanged("sgt_dispensatie_afgehandeld_door_id");
			}
		}
		[XmlElement(Order = 41)]
		public Lookup sgt_dispensatie_toernooibijdrageid
		{
			get
			{
				return this.sgt_dispensatie_toernooibijdrageidField;
			}
			set
			{
				this.sgt_dispensatie_toernooibijdrageidField = value;
				base.RaisePropertyChanged("sgt_dispensatie_toernooibijdrageid");
			}
		}
		[XmlElement(Order = 42)]
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
		[XmlElement(Order = 43)]
		public CrmNumber sgt_duur_partijen
		{
			get
			{
				return this.sgt_duur_partijenField;
			}
			set
			{
				this.sgt_duur_partijenField = value;
				base.RaisePropertyChanged("sgt_duur_partijen");
			}
		}
		[XmlElement(Order = 44)]
		public CrmNumber sgt_duur_partijen_schema
		{
			get
			{
				return this.sgt_duur_partijen_schemaField;
			}
			set
			{
				this.sgt_duur_partijen_schemaField = value;
				base.RaisePropertyChanged("sgt_duur_partijen_schema");
			}
		}
		[XmlElement(Order = 45)]
		public Lookup sgt_dynamisch_formulierid
		{
			get
			{
				return this.sgt_dynamisch_formulieridField;
			}
			set
			{
				this.sgt_dynamisch_formulieridField = value;
				base.RaisePropertyChanged("sgt_dynamisch_formulierid");
			}
		}
		[XmlElement(Order = 46)]
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
		[XmlElement(Order = 47)]
		public CrmDateTime sgt_einddatum_werkelijk
		{
			get
			{
				return this.sgt_einddatum_werkelijkField;
			}
			set
			{
				this.sgt_einddatum_werkelijkField = value;
				base.RaisePropertyChanged("sgt_einddatum_werkelijk");
			}
		}
		[XmlElement(Order = 48)]
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
		[XmlElement(Order = 49)]
		public CrmBoolean sgt_email_her_bondsgedelegeerde_rap_verstuurd
		{
			get
			{
				return this.sgt_email_her_bondsgedelegeerde_rap_verstuurdField;
			}
			set
			{
				this.sgt_email_her_bondsgedelegeerde_rap_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_her_bondsgedelegeerde_rap_verstuurd");
			}
		}
		[XmlElement(Order = 50)]
		public CrmBoolean sgt_email_her_wedstrijdleider_rap_verstuurd
		{
			get
			{
				return this.sgt_email_her_wedstrijdleider_rap_verstuurdField;
			}
			set
			{
				this.sgt_email_her_wedstrijdleider_rap_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_her_wedstrijdleider_rap_verstuurd");
			}
		}
		[XmlElement(Order = 51)]
		public CrmBoolean sgt_herinnering_voor_einde_inschrijving_jn
		{
			get
			{
				return this.sgt_herinnering_voor_einde_inschrijving_jnField;
			}
			set
			{
				this.sgt_herinnering_voor_einde_inschrijving_jnField = value;
				base.RaisePropertyChanged("sgt_herinnering_voor_einde_inschrijving_jn");
			}
		}
		[XmlElement(Order = 52)]
		public Lookup sgt_hoofdscheidsrechter_id
		{
			get
			{
				return this.sgt_hoofdscheidsrechter_idField;
			}
			set
			{
				this.sgt_hoofdscheidsrechter_idField = value;
				base.RaisePropertyChanged("sgt_hoofdscheidsrechter_id");
			}
		}
		[XmlElement(Order = 53)]
		public Lookup sgt_hoofdscheidsrechterid
		{
			get
			{
				return this.sgt_hoofdscheidsrechteridField;
			}
			set
			{
				this.sgt_hoofdscheidsrechteridField = value;
				base.RaisePropertyChanged("sgt_hoofdscheidsrechterid");
			}
		}
		[XmlElement(Order = 54)]
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
				base.RaisePropertyChanged("sgt_huisnummer");
			}
		}
		[XmlElement(Order = 55)]
		public CrmBoolean sgt_individueel_inschrijven
		{
			get
			{
				return this.sgt_individueel_inschrijvenField;
			}
			set
			{
				this.sgt_individueel_inschrijvenField = value;
				base.RaisePropertyChanged("sgt_individueel_inschrijven");
			}
		}
		[XmlElement(Order = 56)]
		public Lookup sgt_inhoud_aanvr_form_dagtoern_id
		{
			get
			{
				return this.sgt_inhoud_aanvr_form_dagtoern_idField;
			}
			set
			{
				this.sgt_inhoud_aanvr_form_dagtoern_idField = value;
				base.RaisePropertyChanged("sgt_inhoud_aanvr_form_dagtoern_id");
			}
		}
		[XmlElement(Order = 57)]
		public Lookup sgt_inhoud_aanvraagformulier_id
		{
			get
			{
				return this.sgt_inhoud_aanvraagformulier_idField;
			}
			set
			{
				this.sgt_inhoud_aanvraagformulier_idField = value;
				base.RaisePropertyChanged("sgt_inhoud_aanvraagformulier_id");
			}
		}
		[XmlElement(Order = 58)]
		public Picklist sgt_innen_inschrijfgeld
		{
			get
			{
				return this.sgt_innen_inschrijfgeldField;
			}
			set
			{
				this.sgt_innen_inschrijfgeldField = value;
				base.RaisePropertyChanged("sgt_innen_inschrijfgeld");
			}
		}
		[XmlElement(Order = 59)]
		public CrmMoney sgt_inschrijfgeld
		{
			get
			{
				return this.sgt_inschrijfgeldField;
			}
			set
			{
				this.sgt_inschrijfgeldField = value;
				base.RaisePropertyChanged("sgt_inschrijfgeld");
			}
		}
		[XmlElement(Order = 60)]
		public CrmMoney sgt_inschrijfgeld_base
		{
			get
			{
				return this.sgt_inschrijfgeld_baseField;
			}
			set
			{
				this.sgt_inschrijfgeld_baseField = value;
				base.RaisePropertyChanged("sgt_inschrijfgeld_base");
			}
		}
		[XmlElement(Order = 61)]
		public CrmBoolean sgt_inschrijven_per_koppel
		{
			get
			{
				return this.sgt_inschrijven_per_koppelField;
			}
			set
			{
				this.sgt_inschrijven_per_koppelField = value;
				base.RaisePropertyChanged("sgt_inschrijven_per_koppel");
			}
		}
		[XmlElement(Order = 62)]
		public CrmDateTime sgt_inschrijven_tm
		{
			get
			{
				return this.sgt_inschrijven_tmField;
			}
			set
			{
				this.sgt_inschrijven_tmField = value;
				base.RaisePropertyChanged("sgt_inschrijven_tm");
			}
		}
		[XmlElement(Order = 63)]
		public CrmDateTime sgt_inschrijven_vanaf
		{
			get
			{
				return this.sgt_inschrijven_vanafField;
			}
			set
			{
				this.sgt_inschrijven_vanafField = value;
				base.RaisePropertyChanged("sgt_inschrijven_vanaf");
			}
		}
		[XmlElement(Order = 64)]
		public CrmBoolean sgt_interfaces
		{
			get
			{
				return this.sgt_interfacesField;
			}
			set
			{
				this.sgt_interfacesField = value;
				base.RaisePropertyChanged("sgt_interfaces");
			}
		}
		[XmlElement(Order = 65)]
		public CrmBoolean sgt_landelijk
		{
			get
			{
				return this.sgt_landelijkField;
			}
			set
			{
				this.sgt_landelijkField = value;
				base.RaisePropertyChanged("sgt_landelijk");
			}
		}
		[XmlElement(Order = 66)]
		public CrmBoolean sgt_lunch
		{
			get
			{
				return this.sgt_lunchField;
			}
			set
			{
				this.sgt_lunchField = value;
				base.RaisePropertyChanged("sgt_lunch");
			}
		}
		[XmlElement(Order = 67)]
		public Picklist sgt_manier_van_bevestigen
		{
			get
			{
				return this.sgt_manier_van_bevestigenField;
			}
			set
			{
				this.sgt_manier_van_bevestigenField = value;
				base.RaisePropertyChanged("sgt_manier_van_bevestigen");
			}
		}
		[XmlElement(Order = 68)]
		public CrmNumber sgt_max_aantal_partijen
		{
			get
			{
				return this.sgt_max_aantal_partijenField;
			}
			set
			{
				this.sgt_max_aantal_partijenField = value;
				base.RaisePropertyChanged("sgt_max_aantal_partijen");
			}
		}
		[XmlElement(Order = 69)]
		public Lookup sgt_meldingdoorid
		{
			get
			{
				return this.sgt_meldingdooridField;
			}
			set
			{
				this.sgt_meldingdooridField = value;
				base.RaisePropertyChanged("sgt_meldingdoorid");
			}
		}
		[XmlElement(Order = 70)]
		public CrmBoolean sgt_niet_knltb
		{
			get
			{
				return this.sgt_niet_knltbField;
			}
			set
			{
				this.sgt_niet_knltbField = value;
				base.RaisePropertyChanged("sgt_niet_knltb");
			}
		}
		[XmlElement(Order = 71)]
		public string sgt_ontvangsttijd
		{
			get
			{
				return this.sgt_ontvangsttijdField;
			}
			set
			{
				this.sgt_ontvangsttijdField = value;
				base.RaisePropertyChanged("sgt_ontvangsttijd");
			}
		}
		[XmlElement(Order = 72)]
		public CrmBoolean sgt_op_afstand
		{
			get
			{
				return this.sgt_op_afstandField;
			}
			set
			{
				this.sgt_op_afstandField = value;
				base.RaisePropertyChanged("sgt_op_afstand");
			}
		}
		[XmlElement(Order = 73)]
		public string sgt_opmerking_tbv_mijnknltb
		{
			get
			{
				return this.sgt_opmerking_tbv_mijnknltbField;
			}
			set
			{
				this.sgt_opmerking_tbv_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_opmerking_tbv_mijnknltb");
			}
		}
		[XmlElement(Order = 74)]
		public string sgt_opmerkingen_toernooi
		{
			get
			{
				return this.sgt_opmerkingen_toernooiField;
			}
			set
			{
				this.sgt_opmerkingen_toernooiField = value;
				base.RaisePropertyChanged("sgt_opmerkingen_toernooi");
			}
		}
		[XmlElement(Order = 75)]
		public CrmMoney sgt_ot_bijdrage_circuit
		{
			get
			{
				return this.sgt_ot_bijdrage_circuitField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuitField = value;
				base.RaisePropertyChanged("sgt_ot_bijdrage_circuit");
			}
		}
		[XmlElement(Order = 76)]
		public CrmMoney sgt_ot_bijdrage_circuit_base
		{
			get
			{
				return this.sgt_ot_bijdrage_circuit_baseField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuit_baseField = value;
				base.RaisePropertyChanged("sgt_ot_bijdrage_circuit_base");
			}
		}
		[XmlElement(Order = 77)]
		public CrmMoney sgt_ot_handlingsfee
		{
			get
			{
				return this.sgt_ot_handlingsfeeField;
			}
			set
			{
				this.sgt_ot_handlingsfeeField = value;
				base.RaisePropertyChanged("sgt_ot_handlingsfee");
			}
		}
		[XmlElement(Order = 78)]
		public CrmMoney sgt_ot_handlingsfee_base
		{
			get
			{
				return this.sgt_ot_handlingsfee_baseField;
			}
			set
			{
				this.sgt_ot_handlingsfee_baseField = value;
				base.RaisePropertyChanged("sgt_ot_handlingsfee_base");
			}
		}
		[XmlElement(Order = 79)]
		public CrmMoney sgt_ot_inschrijfbijdrage
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrageField = value;
				base.RaisePropertyChanged("sgt_ot_inschrijfbijdrage");
			}
		}
		[XmlElement(Order = 80)]
		public CrmMoney sgt_ot_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrage_baseField = value;
				base.RaisePropertyChanged("sgt_ot_inschrijfbijdrage_base");
			}
		}
		[XmlElement(Order = 81)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annulerenField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_annuleren");
			}
		}
		[XmlElement(Order = 82)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annuleren_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_annuleren_base");
			}
		}
		[XmlElement(Order = 83)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatieField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_dispensatie");
			}
		}
		[XmlElement(Order = 84)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_dispensatie_base");
			}
		}
		[XmlElement(Order = 85)]
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annulerenField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_hf_annuleren");
			}
		}
		[XmlElement(Order = 86)]
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annuleren_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_hf_annuleren_base");
			}
		}
		[XmlElement(Order = 87)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annulerenField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_annuleren");
			}
		}
		[XmlElement(Order = 88)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annuleren_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_annuleren_base");
			}
		}
		[XmlElement(Order = 89)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatieField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_dispensatie");
			}
		}
		[XmlElement(Order = 90)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_dispensatie_base");
			}
		}
		[XmlElement(Order = 91)]
		public string sgt_partijen_starten_om
		{
			get
			{
				return this.sgt_partijen_starten_omField;
			}
			set
			{
				this.sgt_partijen_starten_omField = value;
				base.RaisePropertyChanged("sgt_partijen_starten_om");
			}
		}
		[XmlElement(Order = 92)]
		public string sgt_plaatsnaam
		{
			get
			{
				return this.sgt_plaatsnaamField;
			}
			set
			{
				this.sgt_plaatsnaamField = value;
				base.RaisePropertyChanged("sgt_plaatsnaam");
			}
		}
		[XmlElement(Order = 93)]
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
		[XmlElement(Order = 94)]
		public string sgt_postcode_tm
		{
			get
			{
				return this.sgt_postcode_tmField;
			}
			set
			{
				this.sgt_postcode_tmField = value;
				base.RaisePropertyChanged("sgt_postcode_tm");
			}
		}
		[XmlElement(Order = 95)]
		public string sgt_postcode_vanaf
		{
			get
			{
				return this.sgt_postcode_vanafField;
			}
			set
			{
				this.sgt_postcode_vanafField = value;
				base.RaisePropertyChanged("sgt_postcode_vanaf");
			}
		}
		[XmlElement(Order = 96)]
		public CrmBoolean sgt_publiceren_mijn_knltb
		{
			get
			{
				return this.sgt_publiceren_mijn_knltbField;
			}
			set
			{
				this.sgt_publiceren_mijn_knltbField = value;
				base.RaisePropertyChanged("sgt_publiceren_mijn_knltb");
			}
		}
		[XmlElement(Order = 97)]
		public CrmBoolean sgt_rapportage_ingeleverd_wedstrijdleider
		{
			get
			{
				return this.sgt_rapportage_ingeleverd_wedstrijdleiderField;
			}
			set
			{
				this.sgt_rapportage_ingeleverd_wedstrijdleiderField = value;
				base.RaisePropertyChanged("sgt_rapportage_ingeleverd_wedstrijdleider");
			}
		}
		[XmlElement(Order = 98)]
		public Lookup sgt_reden_afwijzingid
		{
			get
			{
				return this.sgt_reden_afwijzingidField;
			}
			set
			{
				this.sgt_reden_afwijzingidField = value;
				base.RaisePropertyChanged("sgt_reden_afwijzingid");
			}
		}
		[XmlElement(Order = 99)]
		public Lookup sgt_reden_annuleren_toernooiid
		{
			get
			{
				return this.sgt_reden_annuleren_toernooiidField;
			}
			set
			{
				this.sgt_reden_annuleren_toernooiidField = value;
				base.RaisePropertyChanged("sgt_reden_annuleren_toernooiid");
			}
		}
		[XmlElement(Order = 100)]
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
		[XmlElement(Order = 101)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}
		[XmlElement(Order = 102)]
		public Picklist sgt_status_dispensatie
		{
			get
			{
				return this.sgt_status_dispensatieField;
			}
			set
			{
				this.sgt_status_dispensatieField = value;
				base.RaisePropertyChanged("sgt_status_dispensatie");
			}
		}
		[XmlElement(Order = 103)]
		public CrmNumber sgt_straal
		{
			get
			{
				return this.sgt_straalField;
			}
			set
			{
				this.sgt_straalField = value;
				base.RaisePropertyChanged("sgt_straal");
			}
		}
		[XmlElement(Order = 104)]
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
				base.RaisePropertyChanged("sgt_straat");
			}
		}
		[XmlElement(Order = 105)]
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
				base.RaisePropertyChanged("sgt_telefoonnummer");
			}
		}
		[XmlElement(Order = 106)]
		public string sgt_ten_name_van
		{
			get
			{
				return this.sgt_ten_name_vanField;
			}
			set
			{
				this.sgt_ten_name_vanField = value;
				base.RaisePropertyChanged("sgt_ten_name_van");
			}
		}
		[XmlElement("sgt_toe_toernooiafhandeling", Order = 107)]
		public string sgt_toe_toernooiafhandeling1
		{
			get
			{
				return this.sgt_toe_toernooiafhandeling1Field;
			}
			set
			{
				this.sgt_toe_toernooiafhandeling1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooiafhandeling1");
			}
		}
		[XmlElement(Order = 108)]
		public Key sgt_toe_toernooiafhandelingid
		{
			get
			{
				return this.sgt_toe_toernooiafhandelingidField;
			}
			set
			{
				this.sgt_toe_toernooiafhandelingidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooiafhandelingid");
			}
		}
		[XmlElement(Order = 109)]
		public string sgt_toelichting
		{
			get
			{
				return this.sgt_toelichtingField;
			}
			set
			{
				this.sgt_toelichtingField = value;
				base.RaisePropertyChanged("sgt_toelichting");
			}
		}
		[XmlElement(Order = 110)]
		public string sgt_toelichting_afhandeling_annulering
		{
			get
			{
				return this.sgt_toelichting_afhandeling_annuleringField;
			}
			set
			{
				this.sgt_toelichting_afhandeling_annuleringField = value;
				base.RaisePropertyChanged("sgt_toelichting_afhandeling_annulering");
			}
		}
		[XmlElement(Order = 111)]
		public string sgt_toelichting_afwijzing
		{
			get
			{
				return this.sgt_toelichting_afwijzingField;
			}
			set
			{
				this.sgt_toelichting_afwijzingField = value;
				base.RaisePropertyChanged("sgt_toelichting_afwijzing");
			}
		}
		[XmlElement(Order = 112)]
		public string sgt_toelichting_dispensatie
		{
			get
			{
				return this.sgt_toelichting_dispensatieField;
			}
			set
			{
				this.sgt_toelichting_dispensatieField = value;
				base.RaisePropertyChanged("sgt_toelichting_dispensatie");
			}
		}
		[XmlElement(Order = 113)]
		public Lookup sgt_toernooi_afhandeling_vorig_jr_id
		{
			get
			{
				return this.sgt_toernooi_afhandeling_vorig_jr_idField;
			}
			set
			{
				this.sgt_toernooi_afhandeling_vorig_jr_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_afhandeling_vorig_jr_id");
			}
		}
		[XmlElement(Order = 114)]
		public Lookup sgt_toernooi_in_district_id
		{
			get
			{
				return this.sgt_toernooi_in_district_idField;
			}
			set
			{
				this.sgt_toernooi_in_district_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_in_district_id");
			}
		}
		[XmlElement(Order = 115)]
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toernooiid");
			}
		}
		[XmlElement(Order = 116)]
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
				base.RaisePropertyChanged("sgt_toernooinummer");
			}
		}
		[XmlElement(Order = 117)]
		public Lookup sgt_toernooiorganisatie_id
		{
			get
			{
				return this.sgt_toernooiorganisatie_idField;
			}
			set
			{
				this.sgt_toernooiorganisatie_idField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatie_id");
			}
		}
		[XmlElement(Order = 118)]
		public Lookup sgt_toernooiorganisatie_oorspr_id
		{
			get
			{
				return this.sgt_toernooiorganisatie_oorspr_idField;
			}
			set
			{
				this.sgt_toernooiorganisatie_oorspr_idField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatie_oorspr_id");
			}
		}
		[XmlElement(Order = 119)]
		public string sgt_toernooiplannernaam
		{
			get
			{
				return this.sgt_toernooiplannernaamField;
			}
			set
			{
				this.sgt_toernooiplannernaamField = value;
				base.RaisePropertyChanged("sgt_toernooiplannernaam");
			}
		}
		[XmlElement(Order = 120)]
		public string sgt_toernooiplannerversie
		{
			get
			{
				return this.sgt_toernooiplannerversieField;
			}
			set
			{
				this.sgt_toernooiplannerversieField = value;
				base.RaisePropertyChanged("sgt_toernooiplannerversie");
			}
		}
		[XmlElement(Order = 121)]
		public Lookup sgt_toernooisoort
		{
			get
			{
				return this.sgt_toernooisoortField;
			}
			set
			{
				this.sgt_toernooisoortField = value;
				base.RaisePropertyChanged("sgt_toernooisoort");
			}
		}
		[XmlElement(Order = 122)]
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
				base.RaisePropertyChanged("sgt_toevoeging");
			}
		}
		[XmlElement(Order = 123)]
		public CrmBoolean sgt_verlichting
		{
			get
			{
				return this.sgt_verlichtingField;
			}
			set
			{
				this.sgt_verlichtingField = value;
				base.RaisePropertyChanged("sgt_verlichting");
			}
		}
		[XmlElement(Order = 124)]
		public CrmDateTime sgt_voorkeur_begindatum_1
		{
			get
			{
				return this.sgt_voorkeur_begindatum_1Field;
			}
			set
			{
				this.sgt_voorkeur_begindatum_1Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_begindatum_1");
			}
		}
		[XmlElement(Order = 125)]
		public CrmDateTime sgt_voorkeur_begindatum_2
		{
			get
			{
				return this.sgt_voorkeur_begindatum_2Field;
			}
			set
			{
				this.sgt_voorkeur_begindatum_2Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_begindatum_2");
			}
		}
		[XmlElement(Order = 126)]
		public CrmDateTime sgt_voorkeur_begindatum_3
		{
			get
			{
				return this.sgt_voorkeur_begindatum_3Field;
			}
			set
			{
				this.sgt_voorkeur_begindatum_3Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_begindatum_3");
			}
		}
		[XmlElement(Order = 127)]
		public CrmDateTime sgt_voorkeur_einddatum_1
		{
			get
			{
				return this.sgt_voorkeur_einddatum_1Field;
			}
			set
			{
				this.sgt_voorkeur_einddatum_1Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_einddatum_1");
			}
		}
		[XmlElement(Order = 128)]
		public CrmDateTime sgt_voorkeur_einddatum_2
		{
			get
			{
				return this.sgt_voorkeur_einddatum_2Field;
			}
			set
			{
				this.sgt_voorkeur_einddatum_2Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_einddatum_2");
			}
		}
		[XmlElement(Order = 129)]
		public CrmDateTime sgt_voorkeur_einddatum_3
		{
			get
			{
				return this.sgt_voorkeur_einddatum_3Field;
			}
			set
			{
				this.sgt_voorkeur_einddatum_3Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_einddatum_3");
			}
		}
		[XmlElement(Order = 130)]
		public string sgt_voorkeur_week_tm_1
		{
			get
			{
				return this.sgt_voorkeur_week_tm_1Field;
			}
			set
			{
				this.sgt_voorkeur_week_tm_1Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_week_tm_1");
			}
		}
		[XmlElement(Order = 131)]
		public string sgt_voorkeur_week_tm_2
		{
			get
			{
				return this.sgt_voorkeur_week_tm_2Field;
			}
			set
			{
				this.sgt_voorkeur_week_tm_2Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_week_tm_2");
			}
		}
		[XmlElement(Order = 132)]
		public string sgt_voorkeur_week_tm_3
		{
			get
			{
				return this.sgt_voorkeur_week_tm_3Field;
			}
			set
			{
				this.sgt_voorkeur_week_tm_3Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_week_tm_3");
			}
		}
		[XmlElement(Order = 133)]
		public string sgt_voorkeur_week_vanaf_1
		{
			get
			{
				return this.sgt_voorkeur_week_vanaf_1Field;
			}
			set
			{
				this.sgt_voorkeur_week_vanaf_1Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_week_vanaf_1");
			}
		}
		[XmlElement(Order = 134)]
		public string sgt_voorkeur_week_vanaf_2
		{
			get
			{
				return this.sgt_voorkeur_week_vanaf_2Field;
			}
			set
			{
				this.sgt_voorkeur_week_vanaf_2Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_week_vanaf_2");
			}
		}
		[XmlElement(Order = 135)]
		public string sgt_voorkeur_week_vanaf_3
		{
			get
			{
				return this.sgt_voorkeur_week_vanaf_3Field;
			}
			set
			{
				this.sgt_voorkeur_week_vanaf_3Field = value;
				base.RaisePropertyChanged("sgt_voorkeur_week_vanaf_3");
			}
		}
		[XmlElement(Order = 136)]
		public string sgt_voorlooptekst1
		{
			get
			{
				return this.sgt_voorlooptekst1Field;
			}
			set
			{
				this.sgt_voorlooptekst1Field = value;
				base.RaisePropertyChanged("sgt_voorlooptekst1");
			}
		}
		[XmlElement(Order = 137)]
		public string sgt_voorlooptekst2
		{
			get
			{
				return this.sgt_voorlooptekst2Field;
			}
			set
			{
				this.sgt_voorlooptekst2Field = value;
				base.RaisePropertyChanged("sgt_voorlooptekst2");
			}
		}
		[XmlElement(Order = 138)]
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
		[XmlElement(Order = 139)]
		public string sgt_wedstrijd_bepalingen
		{
			get
			{
				return this.sgt_wedstrijd_bepalingenField;
			}
			set
			{
				this.sgt_wedstrijd_bepalingenField = value;
				base.RaisePropertyChanged("sgt_wedstrijd_bepalingen");
			}
		}
		[XmlElement(Order = 140)]
		public Lookup sgt_wedstrijdleiderid
		{
			get
			{
				return this.sgt_wedstrijdleideridField;
			}
			set
			{
				this.sgt_wedstrijdleideridField = value;
				base.RaisePropertyChanged("sgt_wedstrijdleiderid");
			}
		}
		[XmlElement(Order = 141)]
		public string sgt_weeknummer_begin
		{
			get
			{
				return this.sgt_weeknummer_beginField;
			}
			set
			{
				this.sgt_weeknummer_beginField = value;
				base.RaisePropertyChanged("sgt_weeknummer_begin");
			}
		}
		[XmlElement(Order = 142)]
		public string sgt_weeknummer_tot_en_met
		{
			get
			{
				return this.sgt_weeknummer_tot_en_metField;
			}
			set
			{
				this.sgt_weeknummer_tot_en_metField = value;
				base.RaisePropertyChanged("sgt_weeknummer_tot_en_met");
			}
		}
		[XmlElement(Order = 143)]
		public string sgt_zwaarte
		{
			get
			{
				return this.sgt_zwaarteField;
			}
			set
			{
				this.sgt_zwaarteField = value;
				base.RaisePropertyChanged("sgt_zwaarte");
			}
		}
		[XmlElement(Order = 144)]
		public Lookup sgt_zwaarteid
		{
			get
			{
				return this.sgt_zwaarteidField;
			}
			set
			{
				this.sgt_zwaarteidField = value;
				base.RaisePropertyChanged("sgt_zwaarteid");
			}
		}
		[XmlElement(Order = 145)]
		public Sgt_toe_toernooiafhandelingStateInfo statecode
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
		[XmlElement(Order = 146)]
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
		[XmlElement(Order = 147)]
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
		[XmlElement(Order = 148)]
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
		[XmlElement(Order = 149)]
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
