using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_dagtoernooi : BusinessEntity
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
		private CrmNumber sgt_aantal_partijenField;
		private Lookup sgt_aanvraagformulieridField;
		private string sgt_aanvullende_informatieField;
		private Lookup sgt_accommodatieidField;
		private string sgt_afsluiting_toernooiField;
		private CrmDateTime sgt_begindatumField;
		private CrmDateTime sgt_begindatum2Field;
		private CrmDateTime sgt_betalen_voorField;
		private Lookup sgt_bondsorganisatie_idField;
		private Lookup sgt_contactpersoon_organisatieField;
		private Lookup sgt_dagtoernoo_aanvraag_vorig_jaar_idField;
		private CrmBoolean sgt_dames_dubbelField;
		private CrmBoolean sgt_dames_enkelField;
		private CrmBoolean sgt_dubbelField;
		private CrmNumber sgt_duur_partijenField;
		private CrmNumber sgt_duur_partijen_schemaField;
		private CrmDateTime sgt_einddatumField;
		private CrmDateTime sgt_einddatum2Field;
		private string sgt_emailField;
		private CrmBoolean sgt_enkelField;
		private CrmBoolean sgt_gemengd_dubbelField;
		private CrmBoolean sgt_gemengd_enkelField;
		private CrmBoolean sgt_heren_dubbelField;
		private CrmBoolean sgt_heren_enkelField;
		private string sgt_huisnummerField;
		private CrmBoolean sgt_individueel_inschrijvenField;
		private Picklist sgt_innen_inschrijfgeldField;
		private CrmMoney sgt_inschrijfgeldField;
		private CrmMoney sgt_inschrijfgeld_baseField;
		private CrmBoolean sgt_inschrijven_koppelField;
		private CrmDateTime sgt_inschrijven_vanafField;
		private CrmNumber sgt_leeftijd_tmField;
		private CrmNumber sgt_leeftijd_vanafField;
		private Lookup sgt_leeftijdscategorie_idField;
		private CrmBoolean sgt_lunchField;
		private Picklist sgt_manier_van_bevestigenField;
		private Lookup sgt_naam_organisatieidField;
		private string sgt_nevenactiviteitenField;
		private string sgt_ontvangsttijdField;
		private string sgt_partijen_starte_omField;
		private string sgt_plaatsField;
		private string sgt_plaatsnaam_rekeninghouderField;
		private string sgt_postcodeField;
		private string sgt_rekeningnummerField;
		private Lookup sgt_schemagrootte_idField;
		private Picklist sgt_statusField;
		private string sgt_straatField;
		private CrmBoolean sgt_teamautorisaties_uitschakelenField;
		private string sgt_telefoonnummerField;
		private string sgt_ten_name_vanField;
		private string sgt_toe_dagtoernooi1Field;
		private Key sgt_toe_dagtoernooiidField;
		private Lookup sgt_toernooi_in_district_idField;
		private Lookup sgt_toernooiafhandeling_vorig_jaar_idField;
		private string sgt_toernooinummerField;
		private Lookup sgt_toernooischema_idField;
		private Lookup sgt_toernooisoortidField;
		private string sgt_toevoegingField;
		private CrmDateTime sgt_uiterste_inschrijfdatumField;
		private CrmBoolean sgt_volgnummer_negerenField;
		private string sgt_websiteField;
		private Sgt_toe_dagtoernooiStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_partijen
		{
			get
			{
				return this.sgt_aantal_partijenField;
			}
			set
			{
				this.sgt_aantal_partijenField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_aanvraagformulierid
		{
			get
			{
				return this.sgt_aanvraagformulieridField;
			}
			set
			{
				this.sgt_aanvraagformulieridField = value;
				base.RaisePropertyChanged("sgt_aanvraagformulierid");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_aanvullende_informatie
		{
			get
			{
				return this.sgt_aanvullende_informatieField;
			}
			set
			{
				this.sgt_aanvullende_informatieField = value;
				base.RaisePropertyChanged("sgt_aanvullende_informatie");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public string sgt_afsluiting_toernooi
		{
			get
			{
				return this.sgt_afsluiting_toernooiField;
			}
			set
			{
				this.sgt_afsluiting_toernooiField = value;
				base.RaisePropertyChanged("sgt_afsluiting_toernooi");
			}
		}
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
		public CrmDateTime sgt_begindatum2
		{
			get
			{
				return this.sgt_begindatum2Field;
			}
			set
			{
				this.sgt_begindatum2Field = value;
				base.RaisePropertyChanged("sgt_begindatum2");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public Lookup sgt_contactpersoon_organisatie
		{
			get
			{
				return this.sgt_contactpersoon_organisatieField;
			}
			set
			{
				this.sgt_contactpersoon_organisatieField = value;
				base.RaisePropertyChanged("sgt_contactpersoon_organisatie");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_dagtoernoo_aanvraag_vorig_jaar_id
		{
			get
			{
				return this.sgt_dagtoernoo_aanvraag_vorig_jaar_idField;
			}
			set
			{
				this.sgt_dagtoernoo_aanvraag_vorig_jaar_idField = value;
				base.RaisePropertyChanged("sgt_dagtoernoo_aanvraag_vorig_jaar_id");
			}
		}
		[XmlElement(Order = 22)]
		public CrmBoolean sgt_dames_dubbel
		{
			get
			{
				return this.sgt_dames_dubbelField;
			}
			set
			{
				this.sgt_dames_dubbelField = value;
				base.RaisePropertyChanged("sgt_dames_dubbel");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_dames_enkel
		{
			get
			{
				return this.sgt_dames_enkelField;
			}
			set
			{
				this.sgt_dames_enkelField = value;
				base.RaisePropertyChanged("sgt_dames_enkel");
			}
		}
		[XmlElement(Order = 24)]
		public CrmBoolean sgt_dubbel
		{
			get
			{
				return this.sgt_dubbelField;
			}
			set
			{
				this.sgt_dubbelField = value;
				base.RaisePropertyChanged("sgt_dubbel");
			}
		}
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
		public CrmDateTime sgt_einddatum2
		{
			get
			{
				return this.sgt_einddatum2Field;
			}
			set
			{
				this.sgt_einddatum2Field = value;
				base.RaisePropertyChanged("sgt_einddatum2");
			}
		}
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
		public CrmBoolean sgt_enkel
		{
			get
			{
				return this.sgt_enkelField;
			}
			set
			{
				this.sgt_enkelField = value;
				base.RaisePropertyChanged("sgt_enkel");
			}
		}
		[XmlElement(Order = 31)]
		public CrmBoolean sgt_gemengd_dubbel
		{
			get
			{
				return this.sgt_gemengd_dubbelField;
			}
			set
			{
				this.sgt_gemengd_dubbelField = value;
				base.RaisePropertyChanged("sgt_gemengd_dubbel");
			}
		}
		[XmlElement(Order = 32)]
		public CrmBoolean sgt_gemengd_enkel
		{
			get
			{
				return this.sgt_gemengd_enkelField;
			}
			set
			{
				this.sgt_gemengd_enkelField = value;
				base.RaisePropertyChanged("sgt_gemengd_enkel");
			}
		}
		[XmlElement(Order = 33)]
		public CrmBoolean sgt_heren_dubbel
		{
			get
			{
				return this.sgt_heren_dubbelField;
			}
			set
			{
				this.sgt_heren_dubbelField = value;
				base.RaisePropertyChanged("sgt_heren_dubbel");
			}
		}
		[XmlElement(Order = 34)]
		public CrmBoolean sgt_heren_enkel
		{
			get
			{
				return this.sgt_heren_enkelField;
			}
			set
			{
				this.sgt_heren_enkelField = value;
				base.RaisePropertyChanged("sgt_heren_enkel");
			}
		}
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
		public CrmBoolean sgt_inschrijven_koppel
		{
			get
			{
				return this.sgt_inschrijven_koppelField;
			}
			set
			{
				this.sgt_inschrijven_koppelField = value;
				base.RaisePropertyChanged("sgt_inschrijven_koppel");
			}
		}
		[XmlElement(Order = 41)]
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
		[XmlElement(Order = 42)]
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tm");
			}
		}
		[XmlElement(Order = 43)]
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf");
			}
		}
		[XmlElement(Order = 44)]
		public Lookup sgt_leeftijdscategorie_id
		{
			get
			{
				return this.sgt_leeftijdscategorie_idField;
			}
			set
			{
				this.sgt_leeftijdscategorie_idField = value;
				base.RaisePropertyChanged("sgt_leeftijdscategorie_id");
			}
		}
		[XmlElement(Order = 45)]
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
		[XmlElement(Order = 46)]
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
		[XmlElement(Order = 47)]
		public Lookup sgt_naam_organisatieid
		{
			get
			{
				return this.sgt_naam_organisatieidField;
			}
			set
			{
				this.sgt_naam_organisatieidField = value;
				base.RaisePropertyChanged("sgt_naam_organisatieid");
			}
		}
		[XmlElement(Order = 48)]
		public string sgt_nevenactiviteiten
		{
			get
			{
				return this.sgt_nevenactiviteitenField;
			}
			set
			{
				this.sgt_nevenactiviteitenField = value;
				base.RaisePropertyChanged("sgt_nevenactiviteiten");
			}
		}
		[XmlElement(Order = 49)]
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
		[XmlElement(Order = 50)]
		public string sgt_partijen_starte_om
		{
			get
			{
				return this.sgt_partijen_starte_omField;
			}
			set
			{
				this.sgt_partijen_starte_omField = value;
				base.RaisePropertyChanged("sgt_partijen_starte_om");
			}
		}
		[XmlElement(Order = 51)]
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
		[XmlElement(Order = 52)]
		public string sgt_plaatsnaam_rekeninghouder
		{
			get
			{
				return this.sgt_plaatsnaam_rekeninghouderField;
			}
			set
			{
				this.sgt_plaatsnaam_rekeninghouderField = value;
				base.RaisePropertyChanged("sgt_plaatsnaam_rekeninghouder");
			}
		}
		[XmlElement(Order = 53)]
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
		[XmlElement(Order = 54)]
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
		[XmlElement(Order = 55)]
		public Lookup sgt_schemagrootte_id
		{
			get
			{
				return this.sgt_schemagrootte_idField;
			}
			set
			{
				this.sgt_schemagrootte_idField = value;
				base.RaisePropertyChanged("sgt_schemagrootte_id");
			}
		}
		[XmlElement(Order = 56)]
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
		[XmlElement(Order = 57)]
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
		[XmlElement(Order = 58)]
		public CrmBoolean sgt_teamautorisaties_uitschakelen
		{
			get
			{
				return this.sgt_teamautorisaties_uitschakelenField;
			}
			set
			{
				this.sgt_teamautorisaties_uitschakelenField = value;
				base.RaisePropertyChanged("sgt_teamautorisaties_uitschakelen");
			}
		}
		[XmlElement(Order = 59)]
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
		[XmlElement(Order = 60)]
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
		[XmlElement("sgt_toe_dagtoernooi", Order = 61)]
		public string sgt_toe_dagtoernooi1
		{
			get
			{
				return this.sgt_toe_dagtoernooi1Field;
			}
			set
			{
				this.sgt_toe_dagtoernooi1Field = value;
				base.RaisePropertyChanged("sgt_toe_dagtoernooi1");
			}
		}
		[XmlElement(Order = 62)]
		public Key sgt_toe_dagtoernooiid
		{
			get
			{
				return this.sgt_toe_dagtoernooiidField;
			}
			set
			{
				this.sgt_toe_dagtoernooiidField = value;
				base.RaisePropertyChanged("sgt_toe_dagtoernooiid");
			}
		}
		[XmlElement(Order = 63)]
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
		[XmlElement(Order = 64)]
		public Lookup sgt_toernooiafhandeling_vorig_jaar_id
		{
			get
			{
				return this.sgt_toernooiafhandeling_vorig_jaar_idField;
			}
			set
			{
				this.sgt_toernooiafhandeling_vorig_jaar_idField = value;
				base.RaisePropertyChanged("sgt_toernooiafhandeling_vorig_jaar_id");
			}
		}
		[XmlElement(Order = 65)]
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
		[XmlElement(Order = 66)]
		public Lookup sgt_toernooischema_id
		{
			get
			{
				return this.sgt_toernooischema_idField;
			}
			set
			{
				this.sgt_toernooischema_idField = value;
				base.RaisePropertyChanged("sgt_toernooischema_id");
			}
		}
		[XmlElement(Order = 67)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}
		[XmlElement(Order = 68)]
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
		[XmlElement(Order = 69)]
		public CrmDateTime sgt_uiterste_inschrijfdatum
		{
			get
			{
				return this.sgt_uiterste_inschrijfdatumField;
			}
			set
			{
				this.sgt_uiterste_inschrijfdatumField = value;
				base.RaisePropertyChanged("sgt_uiterste_inschrijfdatum");
			}
		}
		[XmlElement(Order = 70)]
		public CrmBoolean sgt_volgnummer_negeren
		{
			get
			{
				return this.sgt_volgnummer_negerenField;
			}
			set
			{
				this.sgt_volgnummer_negerenField = value;
				base.RaisePropertyChanged("sgt_volgnummer_negeren");
			}
		}
		[XmlElement(Order = 71)]
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
		[XmlElement(Order = 72)]
		public Sgt_toe_dagtoernooiStateInfo statecode
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
		[XmlElement(Order = 73)]
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
		[XmlElement(Order = 74)]
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
		[XmlElement(Order = 75)]
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
		[XmlElement(Order = 76)]
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
