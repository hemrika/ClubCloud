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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_kwalificanten
		{
			get
			{
				return this.sgt_aantal_kwalificantenField;
			}
			set
			{
				this.sgt_aantal_kwalificantenField = value;
				base.RaisePropertyChanged("sgt_aantal_kwalificanten");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_aantal_special_exempts
		{
			get
			{
				return this.sgt_aantal_special_exemptsField;
			}
			set
			{
				this.sgt_aantal_special_exemptsField = value;
				base.RaisePropertyChanged("sgt_aantal_special_exempts");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_aantal_special_exempts_kwalificatie
		{
			get
			{
				return this.sgt_aantal_special_exempts_kwalificatieField;
			}
			set
			{
				this.sgt_aantal_special_exempts_kwalificatieField = value;
				base.RaisePropertyChanged("sgt_aantal_special_exempts_kwalificatie");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_aantal_te_accepteren
		{
			get
			{
				return this.sgt_aantal_te_accepterenField;
			}
			set
			{
				this.sgt_aantal_te_accepterenField = value;
				base.RaisePropertyChanged("sgt_aantal_te_accepteren");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_aantal_te_accepteren_kwalificatie
		{
			get
			{
				return this.sgt_aantal_te_accepteren_kwalificatieField;
			}
			set
			{
				this.sgt_aantal_te_accepteren_kwalificatieField = value;
				base.RaisePropertyChanged("sgt_aantal_te_accepteren_kwalificatie");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_aantal_wildcards
		{
			get
			{
				return this.sgt_aantal_wildcardsField;
			}
			set
			{
				this.sgt_aantal_wildcardsField = value;
				base.RaisePropertyChanged("sgt_aantal_wildcards");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_aantal_wildcards_kwalificatie
		{
			get
			{
				return this.sgt_aantal_wildcards_kwalificatieField;
			}
			set
			{
				this.sgt_aantal_wildcards_kwalificatieField = value;
				base.RaisePropertyChanged("sgt_aantal_wildcards_kwalificatie");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist sgt_acceptatie
		{
			get
			{
				return this.sgt_acceptatieField;
			}
			set
			{
				this.sgt_acceptatieField = value;
				base.RaisePropertyChanged("sgt_acceptatie");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_dagtoernooiid
		{
			get
			{
				return this.sgt_dagtoernooiidField;
			}
			set
			{
				this.sgt_dagtoernooiidField = value;
				base.RaisePropertyChanged("sgt_dagtoernooiid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmBoolean sgt_dss
		{
			get
			{
				return this.sgt_dssField;
			}
			set
			{
				this.sgt_dssField = value;
				base.RaisePropertyChanged("sgt_dss");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmBoolean sgt_handlingsfee_gefactureerd
		{
			get
			{
				return this.sgt_handlingsfee_gefactureerdField;
			}
			set
			{
				this.sgt_handlingsfee_gefactureerdField = value;
				base.RaisePropertyChanged("sgt_handlingsfee_gefactureerd");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmBoolean sgt_hoofdtoernooi_definitief
		{
			get
			{
				return this.sgt_hoofdtoernooi_definitiefField;
			}
			set
			{
				this.sgt_hoofdtoernooi_definitiefField = value;
				base.RaisePropertyChanged("sgt_hoofdtoernooi_definitief");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_hoofdtoernooi_schema_id
		{
			get
			{
				return this.sgt_hoofdtoernooi_schema_idField;
			}
			set
			{
				this.sgt_hoofdtoernooi_schema_idField = value;
				base.RaisePropertyChanged("sgt_hoofdtoernooi_schema_id");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Picklist sgt_in_samenstelling_onderdelen
		{
			get
			{
				return this.sgt_in_samenstelling_onderdelenField;
			}
			set
			{
				this.sgt_in_samenstelling_onderdelenField = value;
				base.RaisePropertyChanged("sgt_in_samenstelling_onderdelen");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmMoney sgt_inschrijfbijdrage
		{
			get
			{
				return this.sgt_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_inschrijfbijdrageField = value;
				base.RaisePropertyChanged("sgt_inschrijfbijdrage");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmMoney sgt_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_inschrijfbijdrage_baseField = value;
				base.RaisePropertyChanged("sgt_inschrijfbijdrage_base");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_inschrijven_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_via_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_inschrijven_via_mijnknltb");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmBoolean sgt_inschrijven_via_toernooiorganisator
		{
			get
			{
				return this.sgt_inschrijven_via_toernooiorganisatorField;
			}
			set
			{
				this.sgt_inschrijven_via_toernooiorganisatorField = value;
				base.RaisePropertyChanged("sgt_inschrijven_via_toernooiorganisator");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmBoolean sgt_inschrijven_via_vereniging
		{
			get
			{
				return this.sgt_inschrijven_via_verenigingField;
			}
			set
			{
				this.sgt_inschrijven_via_verenigingField = value;
				base.RaisePropertyChanged("sgt_inschrijven_via_vereniging");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmBoolean sgt_inschrijven_wildcards_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_wildcards_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_wildcards_via_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_inschrijven_wildcards_via_mijnknltb");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmBoolean sgt_kwalificatietoernooi_definitief
		{
			get
			{
				return this.sgt_kwalificatietoernooi_definitiefField;
			}
			set
			{
				this.sgt_kwalificatietoernooi_definitiefField = value;
				base.RaisePropertyChanged("sgt_kwalificatietoernooi_definitief");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public Lookup sgt_kwalificatietoernooi_schema_id
		{
			get
			{
				return this.sgt_kwalificatietoernooi_schema_idField;
			}
			set
			{
				this.sgt_kwalificatietoernooi_schema_idField = value;
				base.RaisePropertyChanged("sgt_kwalificatietoernooi_schema_id");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
		public Lookup sgt_leeftijdscategorieid
		{
			get
			{
				return this.sgt_leeftijdscategorieidField;
			}
			set
			{
				this.sgt_leeftijdscategorieidField = value;
				base.RaisePropertyChanged("sgt_leeftijdscategorieid");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Lookup sgt_nhoud_aanvraagform_dagtoern_id
		{
			get
			{
				return this.sgt_nhoud_aanvraagform_dagtoern_idField;
			}
			set
			{
				this.sgt_nhoud_aanvraagform_dagtoern_idField = value;
				base.RaisePropertyChanged("sgt_nhoud_aanvraagform_dagtoern_id");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public CrmMoney sgt_prijzengeld
		{
			get
			{
				return this.sgt_prijzengeldField;
			}
			set
			{
				this.sgt_prijzengeldField = value;
				base.RaisePropertyChanged("sgt_prijzengeld");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public CrmMoney sgt_prijzengeld_base
		{
			get
			{
				return this.sgt_prijzengeld_baseField;
			}
			set
			{
				this.sgt_prijzengeld_baseField = value;
				base.RaisePropertyChanged("sgt_prijzengeld_base");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public CrmMoney sgt_prijzengeld_maximaal
		{
			get
			{
				return this.sgt_prijzengeld_maximaalField;
			}
			set
			{
				this.sgt_prijzengeld_maximaalField = value;
				base.RaisePropertyChanged("sgt_prijzengeld_maximaal");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public CrmMoney sgt_prijzengeld_maximaal_base
		{
			get
			{
				return this.sgt_prijzengeld_maximaal_baseField;
			}
			set
			{
				this.sgt_prijzengeld_maximaal_baseField = value;
				base.RaisePropertyChanged("sgt_prijzengeld_maximaal_base");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public CrmMoney sgt_prijzengeld_minimum
		{
			get
			{
				return this.sgt_prijzengeld_minimumField;
			}
			set
			{
				this.sgt_prijzengeld_minimumField = value;
				base.RaisePropertyChanged("sgt_prijzengeld_minimum");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public CrmMoney sgt_prijzengeld_minimum_base
		{
			get
			{
				return this.sgt_prijzengeld_minimum_baseField;
			}
			set
			{
				this.sgt_prijzengeld_minimum_baseField = value;
				base.RaisePropertyChanged("sgt_prijzengeld_minimum_base");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public CrmBoolean sgt_publicatie_mijn_knltb
		{
			get
			{
				return this.sgt_publicatie_mijn_knltbField;
			}
			set
			{
				this.sgt_publicatie_mijn_knltbField = value;
				base.RaisePropertyChanged("sgt_publicatie_mijn_knltb");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public CrmNumber sgt_punten_bij_afgebroken_set_gelijkspel
		{
			get
			{
				return this.sgt_punten_bij_afgebroken_set_gelijkspelField;
			}
			set
			{
				this.sgt_punten_bij_afgebroken_set_gelijkspelField = value;
				base.RaisePropertyChanged("sgt_punten_bij_afgebroken_set_gelijkspel");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public CrmNumber sgt_punten_bij_afgebroken_set_winst
		{
			get
			{
				return this.sgt_punten_bij_afgebroken_set_winstField;
			}
			set
			{
				this.sgt_punten_bij_afgebroken_set_winstField = value;
				base.RaisePropertyChanged("sgt_punten_bij_afgebroken_set_winst");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public CrmNumber sgt_punten_bij_gelijkspel
		{
			get
			{
				return this.sgt_punten_bij_gelijkspelField;
			}
			set
			{
				this.sgt_punten_bij_gelijkspelField = value;
				base.RaisePropertyChanged("sgt_punten_bij_gelijkspel");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public CrmNumber sgt_punten_bij_verlies_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_verlies_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_verlies_tiebreakField = value;
				base.RaisePropertyChanged("sgt_punten_bij_verlies_tiebreak");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public CrmNumber sgt_punten_bij_winst
		{
			get
			{
				return this.sgt_punten_bij_winstField;
			}
			set
			{
				this.sgt_punten_bij_winstField = value;
				base.RaisePropertyChanged("sgt_punten_bij_winst");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public CrmNumber sgt_punten_bij_winst_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_winst_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_winst_tiebreakField = value;
				base.RaisePropertyChanged("sgt_punten_bij_winst_tiebreak");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public Lookup sgt_ranglijst_id
		{
			get
			{
				return this.sgt_ranglijst_idField;
			}
			set
			{
				this.sgt_ranglijst_idField = value;
				base.RaisePropertyChanged("sgt_ranglijst_id");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public Lookup sgt_schemagrootteid
		{
			get
			{
				return this.sgt_schemagrootteidField;
			}
			set
			{
				this.sgt_schemagrootteidField = value;
				base.RaisePropertyChanged("sgt_schemagrootteid");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public Lookup sgt_schemagroottekwalid
		{
			get
			{
				return this.sgt_schemagroottekwalidField;
			}
			set
			{
				this.sgt_schemagroottekwalidField = value;
				base.RaisePropertyChanged("sgt_schemagroottekwalid");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public Lookup sgt_schemasoort_ht_id
		{
			get
			{
				return this.sgt_schemasoort_ht_idField;
			}
			set
			{
				this.sgt_schemasoort_ht_idField = value;
				base.RaisePropertyChanged("sgt_schemasoort_ht_id");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public Lookup sgt_schemasoort_kt_id
		{
			get
			{
				return this.sgt_schemasoort_kt_idField;
			}
			set
			{
				this.sgt_schemasoort_kt_idField = value;
				base.RaisePropertyChanged("sgt_schemasoort_kt_id");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public string sgt_sleutel_toernooipakket
		{
			get
			{
				return this.sgt_sleutel_toernooipakketField;
			}
			set
			{
				this.sgt_sleutel_toernooipakketField = value;
				base.RaisePropertyChanged("sgt_sleutel_toernooipakket");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public CrmDateTime sgt_special_exempts_inschrijven_tm
		{
			get
			{
				return this.sgt_special_exempts_inschrijven_tmField;
			}
			set
			{
				this.sgt_special_exempts_inschrijven_tmField = value;
				base.RaisePropertyChanged("sgt_special_exempts_inschrijven_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public CrmBoolean sgt_speelschema_hoofdtoernooi_gegenereerd
		{
			get
			{
				return this.sgt_speelschema_hoofdtoernooi_gegenereerdField;
			}
			set
			{
				this.sgt_speelschema_hoofdtoernooi_gegenereerdField = value;
				base.RaisePropertyChanged("sgt_speelschema_hoofdtoernooi_gegenereerd");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public CrmBoolean sgt_speelschema_kwalificatie_gegenereerd
		{
			get
			{
				return this.sgt_speelschema_kwalificatie_gegenereerdField;
			}
			set
			{
				this.sgt_speelschema_kwalificatie_gegenereerdField = value;
				base.RaisePropertyChanged("sgt_speelschema_kwalificatie_gegenereerd");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public Lookup sgt_speelsterkteid
		{
			get
			{
				return this.sgt_speelsterkteidField;
			}
			set
			{
				this.sgt_speelsterkteidField = value;
				base.RaisePropertyChanged("sgt_speelsterkteid");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public CrmBoolean sgt_spelen_op_tijd
		{
			get
			{
				return this.sgt_spelen_op_tijdField;
			}
			set
			{
				this.sgt_spelen_op_tijdField = value;
				base.RaisePropertyChanged("sgt_spelen_op_tijd");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
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

		[XmlElement] //[XmlElement(Order=63)]
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

		[XmlElement] //[XmlElement(Order=64)]
		public Lookup sgt_telmethodeid
		{
			get
			{
				return this.sgt_telmethodeidField;
			}
			set
			{
				this.sgt_telmethodeidField = value;
				base.RaisePropertyChanged("sgt_telmethodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public CrmBoolean sgt_telt_mee_voor_de_ranglijst
		{
			get
			{
				return this.sgt_telt_mee_voor_de_ranglijstField;
			}
			set
			{
				this.sgt_telt_mee_voor_de_ranglijstField = value;
				base.RaisePropertyChanged("sgt_telt_mee_voor_de_ranglijst");
			}
		}

		[XmlElement("sgt_toe_toernooionderdeel")] //, Order=66)]
		public string sgt_toe_toernooionderdeel1
		{
			get
			{
				return this.sgt_toe_toernooionderdeel1Field;
			}
			set
			{
				this.sgt_toe_toernooionderdeel1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooionderdeel1");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public Key sgt_toe_toernooionderdeelid
		{
			get
			{
				return this.sgt_toe_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooionderdeelid");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public Lookup sgt_toernooi_aanvraag_verwerkingid
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerkingidField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerkingidField = value;
				base.RaisePropertyChanged("sgt_toernooi_aanvraag_verwerkingid");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
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

		[XmlElement] //[XmlElement(Order=70)]
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

		[XmlElement] //[XmlElement(Order=71)]
		public Lookup sgt_toernooionderdeel_vorig_jaarid
		{
			get
			{
				return this.sgt_toernooionderdeel_vorig_jaaridField;
			}
			set
			{
				this.sgt_toernooionderdeel_vorig_jaaridField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeel_vorig_jaarid");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
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

		[XmlElement] //[XmlElement(Order=73)]
		public CrmBoolean sgt_tonen_als_jongens_meisjes
		{
			get
			{
				return this.sgt_tonen_als_jongens_meisjesField;
			}
			set
			{
				this.sgt_tonen_als_jongens_meisjesField = value;
				base.RaisePropertyChanged("sgt_tonen_als_jongens_meisjes");
			}
		}

		[XmlElement] //[XmlElement(Order=74)]
		public Picklist sgt_type_leeftijdbepaling
		{
			get
			{
				return this.sgt_type_leeftijdbepalingField;
			}
			set
			{
				this.sgt_type_leeftijdbepalingField = value;
				base.RaisePropertyChanged("sgt_type_leeftijdbepaling");
			}
		}

		[XmlElement] //[XmlElement(Order=75)]
		public CrmBoolean sgt_verkorte_sets
		{
			get
			{
				return this.sgt_verkorte_setsField;
			}
			set
			{
				this.sgt_verkorte_setsField = value;
				base.RaisePropertyChanged("sgt_verkorte_sets");
			}
		}

		[XmlElement] //[XmlElement(Order=76)]
		public CrmDateTime sgt_wildcardsinschrijventm
		{
			get
			{
				return this.sgt_wildcardsinschrijventmField;
			}
			set
			{
				this.sgt_wildcardsinschrijventmField = value;
				base.RaisePropertyChanged("sgt_wildcardsinschrijventm");
			}
		}

		[XmlElement] //[XmlElement(Order=77)]
		public CrmNumber sgt_winstpunten_gelijkspel_in_poul
		{
			get
			{
				return this.sgt_winstpunten_gelijkspel_in_poulField;
			}
			set
			{
				this.sgt_winstpunten_gelijkspel_in_poulField = value;
				base.RaisePropertyChanged("sgt_winstpunten_gelijkspel_in_poul");
			}
		}

		[XmlElement] //[XmlElement(Order=78)]
		public CrmNumber sgt_winstpunten_gewonnen_partij
		{
			get
			{
				return this.sgt_winstpunten_gewonnen_partijField;
			}
			set
			{
				this.sgt_winstpunten_gewonnen_partijField = value;
				base.RaisePropertyChanged("sgt_winstpunten_gewonnen_partij");
			}
		}

		[XmlElement] //[XmlElement(Order=79)]
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

		[XmlElement] //[XmlElement(Order=80)]
		public Sgt_toe_toernooionderdeelStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=81)]
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

		[XmlElement] //[XmlElement(Order=82)]
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

		[XmlElement] //[XmlElement(Order=83)]
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

		[XmlElement] //[XmlElement(Order=84)]
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

		public sgt_toe_toernooionderdeel()
		{
		}
	}
}