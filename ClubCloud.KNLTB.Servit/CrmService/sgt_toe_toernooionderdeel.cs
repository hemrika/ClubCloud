using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooionderdeel : BusinessEntity
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
		private CrmNumber sgt_aantal_kwalificantenField;
		private CrmNumber sgt_aantal_special_exemptsField;
		private CrmNumber sgt_aantal_special_exempts_kwalificatieField;
		private CrmNumber sgt_aantal_te_accepterenField;
		private CrmNumber sgt_aantal_te_accepteren_kwalificatieField;
		private CrmNumber sgt_aantal_wildcardsField;
		private CrmNumber sgt_aantal_wildcards_kwalificatieField;
		private Lookup sgt_aanvraagformulieridField;
		private Picklist sgt_acceptatieField;
		private Lookup sgt_dagtoernooiidField;
		private CrmBoolean sgt_dssField;
		private Picklist sgt_geslachtField;
		private CrmBoolean sgt_handlingsfee_gefactureerdField;
		private CrmBoolean sgt_hoofdtoernooi_definitiefField;
		private Lookup sgt_hoofdtoernooi_schema_idField;
		private Picklist sgt_in_samenstelling_onderdelenField;
		private CrmMoney sgt_inschrijfbijdrageField;
		private CrmMoney sgt_inschrijfbijdrage_baseField;
		private CrmBoolean sgt_inschrijven_via_mijnknltbField;
		private CrmBoolean sgt_inschrijven_via_toernooiorganisatorField;
		private CrmBoolean sgt_inschrijven_via_verenigingField;
		private CrmBoolean sgt_inschrijven_wildcards_via_mijnknltbField;
		private CrmBoolean sgt_kwalificatietoernooi_definitiefField;
		private Lookup sgt_kwalificatietoernooi_schema_idField;
		private CrmNumber sgt_leeftijd_tmField;
		private CrmNumber sgt_leeftijd_vanafField;
		private Lookup sgt_leeftijdscategorieidField;
		private Lookup sgt_nhoud_aanvraagform_dagtoern_idField;
		private CrmMoney sgt_prijzengeldField;
		private CrmMoney sgt_prijzengeld_baseField;
		private CrmMoney sgt_prijzengeld_maximaalField;
		private CrmMoney sgt_prijzengeld_maximaal_baseField;
		private CrmMoney sgt_prijzengeld_minimumField;
		private CrmMoney sgt_prijzengeld_minimum_baseField;
		private CrmBoolean sgt_publicatie_mijn_knltbField;
		private CrmNumber sgt_punten_bij_afgebroken_set_gelijkspelField;
		private CrmNumber sgt_punten_bij_afgebroken_set_winstField;
		private CrmNumber sgt_punten_bij_gelijkspelField;
		private CrmNumber sgt_punten_bij_verlies_tiebreakField;
		private CrmNumber sgt_punten_bij_winstField;
		private CrmNumber sgt_punten_bij_winst_tiebreakField;
		private Lookup sgt_ranglijst_idField;
		private Lookup sgt_schemagrootteidField;
		private Lookup sgt_schemagroottekwalidField;
		private Lookup sgt_schemasoort_ht_idField;
		private Lookup sgt_schemasoort_kt_idField;
		private string sgt_sleutel_toernooipakketField;
		private CrmDateTime sgt_special_exempts_inschrijven_tmField;
		private CrmBoolean sgt_speelschema_hoofdtoernooi_gegenereerdField;
		private CrmBoolean sgt_speelschema_kwalificatie_gegenereerdField;
		private Lookup sgt_speelsterkteidField;
		private CrmBoolean sgt_spelen_op_tijdField;
		private Picklist sgt_spelsoortField;
		private Picklist sgt_statusField;
		private CrmBoolean sgt_teamautorisaties_uitschakelenField;
		private Lookup sgt_telmethodeidField;
		private CrmBoolean sgt_telt_mee_voor_de_ranglijstField;
		private string sgt_toe_toernooionderdeel1Field;
		private Key sgt_toe_toernooionderdeelidField;
		private Lookup sgt_toernooi_aanvraag_verwerkingidField;
		private Lookup sgt_toernooiidField;
		private string sgt_toernooinummerField;
		private Lookup sgt_toernooionderdeel_vorig_jaaridField;
		private Lookup sgt_toernooisoortidField;
		private CrmBoolean sgt_tonen_als_jongens_meisjesField;
		private Picklist sgt_type_leeftijdbepalingField;
		private CrmBoolean sgt_verkorte_setsField;
		private CrmDateTime sgt_wildcardsinschrijventmField;
		private CrmNumber sgt_winstpunten_gelijkspel_in_poulField;
		private CrmNumber sgt_winstpunten_gewonnen_partijField;
		private Lookup sgt_zwaarteidField;
		private Sgt_toe_toernooionderdeelStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_kwalificanten
		{
			get
			{
				return this.sgt_aantal_kwalificantenField;
			}
			set
			{
				this.sgt_aantal_kwalificantenField = value;
			}
		}
		public CrmNumber sgt_aantal_special_exempts
		{
			get
			{
				return this.sgt_aantal_special_exemptsField;
			}
			set
			{
				this.sgt_aantal_special_exemptsField = value;
			}
		}
		public CrmNumber sgt_aantal_special_exempts_kwalificatie
		{
			get
			{
				return this.sgt_aantal_special_exempts_kwalificatieField;
			}
			set
			{
				this.sgt_aantal_special_exempts_kwalificatieField = value;
			}
		}
		public CrmNumber sgt_aantal_te_accepteren
		{
			get
			{
				return this.sgt_aantal_te_accepterenField;
			}
			set
			{
				this.sgt_aantal_te_accepterenField = value;
			}
		}
		public CrmNumber sgt_aantal_te_accepteren_kwalificatie
		{
			get
			{
				return this.sgt_aantal_te_accepteren_kwalificatieField;
			}
			set
			{
				this.sgt_aantal_te_accepteren_kwalificatieField = value;
			}
		}
		public CrmNumber sgt_aantal_wildcards
		{
			get
			{
				return this.sgt_aantal_wildcardsField;
			}
			set
			{
				this.sgt_aantal_wildcardsField = value;
			}
		}
		public CrmNumber sgt_aantal_wildcards_kwalificatie
		{
			get
			{
				return this.sgt_aantal_wildcards_kwalificatieField;
			}
			set
			{
				this.sgt_aantal_wildcards_kwalificatieField = value;
			}
		}
		public Lookup sgt_aanvraagformulierid
		{
			get
			{
				return this.sgt_aanvraagformulieridField;
			}
			set
			{
				this.sgt_aanvraagformulieridField = value;
			}
		}
		public Picklist sgt_acceptatie
		{
			get
			{
				return this.sgt_acceptatieField;
			}
			set
			{
				this.sgt_acceptatieField = value;
			}
		}
		public Lookup sgt_dagtoernooiid
		{
			get
			{
				return this.sgt_dagtoernooiidField;
			}
			set
			{
				this.sgt_dagtoernooiidField = value;
			}
		}
		public CrmBoolean sgt_dss
		{
			get
			{
				return this.sgt_dssField;
			}
			set
			{
				this.sgt_dssField = value;
			}
		}
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public CrmBoolean sgt_handlingsfee_gefactureerd
		{
			get
			{
				return this.sgt_handlingsfee_gefactureerdField;
			}
			set
			{
				this.sgt_handlingsfee_gefactureerdField = value;
			}
		}
		public CrmBoolean sgt_hoofdtoernooi_definitief
		{
			get
			{
				return this.sgt_hoofdtoernooi_definitiefField;
			}
			set
			{
				this.sgt_hoofdtoernooi_definitiefField = value;
			}
		}
		public Lookup sgt_hoofdtoernooi_schema_id
		{
			get
			{
				return this.sgt_hoofdtoernooi_schema_idField;
			}
			set
			{
				this.sgt_hoofdtoernooi_schema_idField = value;
			}
		}
		public Picklist sgt_in_samenstelling_onderdelen
		{
			get
			{
				return this.sgt_in_samenstelling_onderdelenField;
			}
			set
			{
				this.sgt_in_samenstelling_onderdelenField = value;
			}
		}
		public CrmMoney sgt_inschrijfbijdrage
		{
			get
			{
				return this.sgt_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_inschrijfbijdrageField = value;
			}
		}
		public CrmMoney sgt_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_inschrijfbijdrage_baseField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_via_mijnknltbField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_via_toernooiorganisator
		{
			get
			{
				return this.sgt_inschrijven_via_toernooiorganisatorField;
			}
			set
			{
				this.sgt_inschrijven_via_toernooiorganisatorField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_via_vereniging
		{
			get
			{
				return this.sgt_inschrijven_via_verenigingField;
			}
			set
			{
				this.sgt_inschrijven_via_verenigingField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_wildcards_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_wildcards_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_wildcards_via_mijnknltbField = value;
			}
		}
		public CrmBoolean sgt_kwalificatietoernooi_definitief
		{
			get
			{
				return this.sgt_kwalificatietoernooi_definitiefField;
			}
			set
			{
				this.sgt_kwalificatietoernooi_definitiefField = value;
			}
		}
		public Lookup sgt_kwalificatietoernooi_schema_id
		{
			get
			{
				return this.sgt_kwalificatietoernooi_schema_idField;
			}
			set
			{
				this.sgt_kwalificatietoernooi_schema_idField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
			}
		}
		public Lookup sgt_leeftijdscategorieid
		{
			get
			{
				return this.sgt_leeftijdscategorieidField;
			}
			set
			{
				this.sgt_leeftijdscategorieidField = value;
			}
		}
		public Lookup sgt_nhoud_aanvraagform_dagtoern_id
		{
			get
			{
				return this.sgt_nhoud_aanvraagform_dagtoern_idField;
			}
			set
			{
				this.sgt_nhoud_aanvraagform_dagtoern_idField = value;
			}
		}
		public CrmMoney sgt_prijzengeld
		{
			get
			{
				return this.sgt_prijzengeldField;
			}
			set
			{
				this.sgt_prijzengeldField = value;
			}
		}
		public CrmMoney sgt_prijzengeld_base
		{
			get
			{
				return this.sgt_prijzengeld_baseField;
			}
			set
			{
				this.sgt_prijzengeld_baseField = value;
			}
		}
		public CrmMoney sgt_prijzengeld_maximaal
		{
			get
			{
				return this.sgt_prijzengeld_maximaalField;
			}
			set
			{
				this.sgt_prijzengeld_maximaalField = value;
			}
		}
		public CrmMoney sgt_prijzengeld_maximaal_base
		{
			get
			{
				return this.sgt_prijzengeld_maximaal_baseField;
			}
			set
			{
				this.sgt_prijzengeld_maximaal_baseField = value;
			}
		}
		public CrmMoney sgt_prijzengeld_minimum
		{
			get
			{
				return this.sgt_prijzengeld_minimumField;
			}
			set
			{
				this.sgt_prijzengeld_minimumField = value;
			}
		}
		public CrmMoney sgt_prijzengeld_minimum_base
		{
			get
			{
				return this.sgt_prijzengeld_minimum_baseField;
			}
			set
			{
				this.sgt_prijzengeld_minimum_baseField = value;
			}
		}
		public CrmBoolean sgt_publicatie_mijn_knltb
		{
			get
			{
				return this.sgt_publicatie_mijn_knltbField;
			}
			set
			{
				this.sgt_publicatie_mijn_knltbField = value;
			}
		}
		public CrmNumber sgt_punten_bij_afgebroken_set_gelijkspel
		{
			get
			{
				return this.sgt_punten_bij_afgebroken_set_gelijkspelField;
			}
			set
			{
				this.sgt_punten_bij_afgebroken_set_gelijkspelField = value;
			}
		}
		public CrmNumber sgt_punten_bij_afgebroken_set_winst
		{
			get
			{
				return this.sgt_punten_bij_afgebroken_set_winstField;
			}
			set
			{
				this.sgt_punten_bij_afgebroken_set_winstField = value;
			}
		}
		public CrmNumber sgt_punten_bij_gelijkspel
		{
			get
			{
				return this.sgt_punten_bij_gelijkspelField;
			}
			set
			{
				this.sgt_punten_bij_gelijkspelField = value;
			}
		}
		public CrmNumber sgt_punten_bij_verlies_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_verlies_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_verlies_tiebreakField = value;
			}
		}
		public CrmNumber sgt_punten_bij_winst
		{
			get
			{
				return this.sgt_punten_bij_winstField;
			}
			set
			{
				this.sgt_punten_bij_winstField = value;
			}
		}
		public CrmNumber sgt_punten_bij_winst_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_winst_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_winst_tiebreakField = value;
			}
		}
		public Lookup sgt_ranglijst_id
		{
			get
			{
				return this.sgt_ranglijst_idField;
			}
			set
			{
				this.sgt_ranglijst_idField = value;
			}
		}
		public Lookup sgt_schemagrootteid
		{
			get
			{
				return this.sgt_schemagrootteidField;
			}
			set
			{
				this.sgt_schemagrootteidField = value;
			}
		}
		public Lookup sgt_schemagroottekwalid
		{
			get
			{
				return this.sgt_schemagroottekwalidField;
			}
			set
			{
				this.sgt_schemagroottekwalidField = value;
			}
		}
		public Lookup sgt_schemasoort_ht_id
		{
			get
			{
				return this.sgt_schemasoort_ht_idField;
			}
			set
			{
				this.sgt_schemasoort_ht_idField = value;
			}
		}
		public Lookup sgt_schemasoort_kt_id
		{
			get
			{
				return this.sgt_schemasoort_kt_idField;
			}
			set
			{
				this.sgt_schemasoort_kt_idField = value;
			}
		}
		public string sgt_sleutel_toernooipakket
		{
			get
			{
				return this.sgt_sleutel_toernooipakketField;
			}
			set
			{
				this.sgt_sleutel_toernooipakketField = value;
			}
		}
		public CrmDateTime sgt_special_exempts_inschrijven_tm
		{
			get
			{
				return this.sgt_special_exempts_inschrijven_tmField;
			}
			set
			{
				this.sgt_special_exempts_inschrijven_tmField = value;
			}
		}
		public CrmBoolean sgt_speelschema_hoofdtoernooi_gegenereerd
		{
			get
			{
				return this.sgt_speelschema_hoofdtoernooi_gegenereerdField;
			}
			set
			{
				this.sgt_speelschema_hoofdtoernooi_gegenereerdField = value;
			}
		}
		public CrmBoolean sgt_speelschema_kwalificatie_gegenereerd
		{
			get
			{
				return this.sgt_speelschema_kwalificatie_gegenereerdField;
			}
			set
			{
				this.sgt_speelschema_kwalificatie_gegenereerdField = value;
			}
		}
		public Lookup sgt_speelsterkteid
		{
			get
			{
				return this.sgt_speelsterkteidField;
			}
			set
			{
				this.sgt_speelsterkteidField = value;
			}
		}
		public CrmBoolean sgt_spelen_op_tijd
		{
			get
			{
				return this.sgt_spelen_op_tijdField;
			}
			set
			{
				this.sgt_spelen_op_tijdField = value;
			}
		}
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
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
		public CrmBoolean sgt_teamautorisaties_uitschakelen
		{
			get
			{
				return this.sgt_teamautorisaties_uitschakelenField;
			}
			set
			{
				this.sgt_teamautorisaties_uitschakelenField = value;
			}
		}
		public Lookup sgt_telmethodeid
		{
			get
			{
				return this.sgt_telmethodeidField;
			}
			set
			{
				this.sgt_telmethodeidField = value;
			}
		}
		public CrmBoolean sgt_telt_mee_voor_de_ranglijst
		{
			get
			{
				return this.sgt_telt_mee_voor_de_ranglijstField;
			}
			set
			{
				this.sgt_telt_mee_voor_de_ranglijstField = value;
			}
		}
		[XmlElement("sgt_toe_toernooionderdeel")]
		public string sgt_toe_toernooionderdeel1
		{
			get
			{
				return this.sgt_toe_toernooionderdeel1Field;
			}
			set
			{
				this.sgt_toe_toernooionderdeel1Field = value;
			}
		}
		public Key sgt_toe_toernooionderdeelid
		{
			get
			{
				return this.sgt_toe_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelidField = value;
			}
		}
		public Lookup sgt_toernooi_aanvraag_verwerkingid
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerkingidField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerkingidField = value;
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
		public Lookup sgt_toernooionderdeel_vorig_jaarid
		{
			get
			{
				return this.sgt_toernooionderdeel_vorig_jaaridField;
			}
			set
			{
				this.sgt_toernooionderdeel_vorig_jaaridField = value;
			}
		}
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
			}
		}
		public CrmBoolean sgt_tonen_als_jongens_meisjes
		{
			get
			{
				return this.sgt_tonen_als_jongens_meisjesField;
			}
			set
			{
				this.sgt_tonen_als_jongens_meisjesField = value;
			}
		}
		public Picklist sgt_type_leeftijdbepaling
		{
			get
			{
				return this.sgt_type_leeftijdbepalingField;
			}
			set
			{
				this.sgt_type_leeftijdbepalingField = value;
			}
		}
		public CrmBoolean sgt_verkorte_sets
		{
			get
			{
				return this.sgt_verkorte_setsField;
			}
			set
			{
				this.sgt_verkorte_setsField = value;
			}
		}
		public CrmDateTime sgt_wildcardsinschrijventm
		{
			get
			{
				return this.sgt_wildcardsinschrijventmField;
			}
			set
			{
				this.sgt_wildcardsinschrijventmField = value;
			}
		}
		public CrmNumber sgt_winstpunten_gelijkspel_in_poul
		{
			get
			{
				return this.sgt_winstpunten_gelijkspel_in_poulField;
			}
			set
			{
				this.sgt_winstpunten_gelijkspel_in_poulField = value;
			}
		}
		public CrmNumber sgt_winstpunten_gewonnen_partij
		{
			get
			{
				return this.sgt_winstpunten_gewonnen_partijField;
			}
			set
			{
				this.sgt_winstpunten_gewonnen_partijField = value;
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
		public Sgt_toe_toernooionderdeelStateInfo statecode
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
