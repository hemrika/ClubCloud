using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_piramide : BusinessEntity
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
		private CrmDateTime sgt_10e_inhaaldatumField;
		private string sgt_10e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_10e_speeldatumField;
		private Lookup sgt_10e_speeldatum_accommodatieidField;
		private string sgt_10e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_10e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_11e_speeldatumField;
		private Lookup sgt_11e_speeldatum_accommodatieidField;
		private string sgt_11e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_11e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_12e_speeldatumField;
		private Lookup sgt_12e_speeldatum_accommodatieidField;
		private string sgt_12e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_12e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_13e_speeldatumField;
		private Lookup sgt_13e_speeldatum_accommodatieidField;
		private string sgt_13e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_13e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_14e_speeldatumField;
		private Lookup sgt_14e_speeldatum_accommodatieidField;
		private string sgt_14e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_14e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_15e_speeldatumField;
		private Lookup sgt_15e_speeldatum_accommodatieidField;
		private string sgt_15e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_15e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_16e_speeldatumField;
		private Lookup sgt_16e_speeldatum_accommodatieidField;
		private string sgt_16e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_16e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_17e_speeldatumField;
		private Lookup sgt_17e_speeldatum_accommodatieidField;
		private string sgt_17e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_17e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_18e_speeldatumField;
		private Lookup sgt_18e_speeldatum_accommodatieidField;
		private string sgt_18e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_18e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_19e_speeldatumField;
		private Lookup sgt_19e_speeldatum_accommodatieidField;
		private string sgt_19e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_19e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_1e_inhaaldatumField;
		private string sgt_1e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_1e_speeldatumField;
		private Lookup sgt_1e_speeldatum_accommodatieidField;
		private string sgt_1e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_1e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_20e_speeldatumField;
		private Lookup sgt_20e_speeldatum_accommodatieidField;
		private string sgt_20e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_20e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_2e_inhaaldatumField;
		private string sgt_2e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_2e_speeldatumField;
		private Lookup sgt_2e_speeldatum_accommodatieidField;
		private string sgt_2e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_2e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_3e_inhaaldatumField;
		private string sgt_3e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_3e_speeldatumField;
		private Lookup sgt_3e_speeldatum_accommodatieidField;
		private string sgt_3e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_3e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_4e_inhaaldatumField;
		private string sgt_4e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_4e_speeldatumField;
		private Lookup sgt_4e_speeldatum_accommodatieidField;
		private string sgt_4e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_4e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_5e_inhaaldatumField;
		private string sgt_5e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_5e_speeldatumField;
		private Lookup sgt_5e_speeldatum_accommodatieidField;
		private string sgt_5e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_5e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_6e_inhaaldatumField;
		private string sgt_6e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_6e_speeldatumField;
		private Lookup sgt_6e_speeldatum_accommodatieidField;
		private string sgt_6e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_6e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_7e_inhaaldatumField;
		private string sgt_7e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_7e_speeldatumField;
		private Lookup sgt_7e_speeldatum_accommodatieidField;
		private string sgt_7e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_7e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_8e_inhaaldatumField;
		private string sgt_8e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_8e_speeldatumField;
		private Lookup sgt_8e_speeldatum_accommodatieidField;
		private string sgt_8e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_8e_speeldatum_volgnummer_ploegField;
		private CrmDateTime sgt_9e_inhaaldatumField;
		private string sgt_9e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_9e_speeldatumField;
		private Lookup sgt_9e_speeldatum_accommodatieidField;
		private string sgt_9e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_9e_speeldatum_volgnummer_ploegField;
		private CrmNumber sgt_aantal_winstpunten_per_gewonnen_partijField;
		private CrmMoney sgt_bedrag_inschrijfbijdrageField;
		private CrmMoney sgt_bedrag_inschrijfbijdrage_baseField;
		private CrmMoney sgt_bedrag_toeslagField;
		private CrmMoney sgt_bedrag_toeslag_baseField;
		private CrmNumber sgt_bonuspunten_bij_setwinstField;
		private string sgt_com_piramide1Field;
		private Key sgt_com_piramideidField;
		private Lookup sgt_competitieidField;
		private Lookup sgt_competitiesoortidField;
		private Picklist sgt_dagField;
		private Picklist sgt_dagdeelField;
		private CrmNumber sgt_dames_dubbelField;
		private CrmNumber sgt_dames_enkelField;
		private string sgt_eerste_afdelingField;
		private CrmBoolean sgt_einduitslag_som_van_partijuitslagenField;
		private Picklist sgt_gelijk_geeindigde_ploegen_vergelijken_opField;
		private CrmNumber sgt_gemengd_dubbelField;
		private CrmNumber sgt_heren_dubbelField;
		private CrmNumber sgt_heren_enkelField;
		private Lookup sgt_inschrijfbijdrageidField;
		private CrmNumber sgt_lwinstpunten_per_gelijkgespeelde_partijField;
		private CrmNumber sgt_maximum_aantal_partijen_per_persoonField;
		private CrmNumber sgt_maximum_aantal_ploegen_per_afdelingField;
		private CrmNumber sgt_min_damesField;
		private CrmNumber sgt_min_herenField;
		private CrmNumber sgt_min_spelersField;
		private CrmFloat sgt_minimum_aantal_banen_per_ploegField;
		private string sgt_omschrijving_inschrijfbijdrageField;
		private string sgt_omschrijving_toeslagField;
		private CrmBoolean sgt_op_tijdField;
		private CrmBoolean sgt_partij_mag_gelijk_eindigenField;
		private CrmNumber sgt_partijen_dubbelField;
		private CrmNumber sgt_partijen_enkelField;
		private CrmBoolean sgt_ploegopgave_bij_inschrijvenField;
		private CrmNumber sgt_punten_bij_afgebroken_setField;
		private CrmNumber sgt_punten_bij_gelijkspelField;
		private CrmNumber sgt_punten_bij_verliesField;
		private CrmNumber sgt_punten_bij_winstField;
		private CrmBoolean sgt_resultaten_tellen_mee_voor_dssField;
		private CrmDateTime sgt_speeldatum_beslissingswedstrijdField;
		private Lookup sgt_speeldatumsidField;
		private CrmBoolean sgt_spelen_op_1_locatieField;
		private Lookup sgt_telmethode_idField;
		private Lookup sgt_toeslag_ibidField;
		private CrmBoolean sgt_tonen_als_jongens_meisjesField;
		private CrmBoolean sgt_variabele_begintijdenField;
		private CrmDateTime sgt_vaste_begintijdField;
		private CrmBoolean sgt_verkorte_setsField;
		private Picklist sgt_verlichting_noodzakelijkField;
		private CrmNumber sgt_winstpunten_per_verloren_partijField;
		private Sgt_com_piramideStateInfo statecodeField;
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
		public CrmDateTime sgt_10e_inhaaldatum
		{
			get
			{
				return this.sgt_10e_inhaaldatumField;
			}
			set
			{
				this.sgt_10e_inhaaldatumField = value;
			}
		}
		public string sgt_10e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_10e_speeldatum
		{
			get
			{
				return this.sgt_10e_speeldatumField;
			}
			set
			{
				this.sgt_10e_speeldatumField = value;
			}
		}
		public Lookup sgt_10e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_10e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_10e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_10e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_10e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_10e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_10e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_11e_speeldatum
		{
			get
			{
				return this.sgt_11e_speeldatumField;
			}
			set
			{
				this.sgt_11e_speeldatumField = value;
			}
		}
		public Lookup sgt_11e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_11e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_11e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_11e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_11e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_11e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_11e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_11e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_11e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_12e_speeldatum
		{
			get
			{
				return this.sgt_12e_speeldatumField;
			}
			set
			{
				this.sgt_12e_speeldatumField = value;
			}
		}
		public Lookup sgt_12e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_12e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_12e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_12e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_12e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_12e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_12e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_12e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_12e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_13e_speeldatum
		{
			get
			{
				return this.sgt_13e_speeldatumField;
			}
			set
			{
				this.sgt_13e_speeldatumField = value;
			}
		}
		public Lookup sgt_13e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_13e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_13e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_13e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_13e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_13e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_13e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_13e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_13e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_14e_speeldatum
		{
			get
			{
				return this.sgt_14e_speeldatumField;
			}
			set
			{
				this.sgt_14e_speeldatumField = value;
			}
		}
		public Lookup sgt_14e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_14e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_14e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_14e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_14e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_14e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_14e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_14e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_14e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_15e_speeldatum
		{
			get
			{
				return this.sgt_15e_speeldatumField;
			}
			set
			{
				this.sgt_15e_speeldatumField = value;
			}
		}
		public Lookup sgt_15e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_15e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_15e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_15e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_15e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_15e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_15e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_15e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_15e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_16e_speeldatum
		{
			get
			{
				return this.sgt_16e_speeldatumField;
			}
			set
			{
				this.sgt_16e_speeldatumField = value;
			}
		}
		public Lookup sgt_16e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_16e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_16e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_16e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_16e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_16e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_16e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_16e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_16e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_17e_speeldatum
		{
			get
			{
				return this.sgt_17e_speeldatumField;
			}
			set
			{
				this.sgt_17e_speeldatumField = value;
			}
		}
		public Lookup sgt_17e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_17e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_17e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_17e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_17e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_17e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_17e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_17e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_17e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_18e_speeldatum
		{
			get
			{
				return this.sgt_18e_speeldatumField;
			}
			set
			{
				this.sgt_18e_speeldatumField = value;
			}
		}
		public Lookup sgt_18e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_18e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_18e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_18e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_18e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_18e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_18e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_18e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_18e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_19e_speeldatum
		{
			get
			{
				return this.sgt_19e_speeldatumField;
			}
			set
			{
				this.sgt_19e_speeldatumField = value;
			}
		}
		public Lookup sgt_19e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_19e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_19e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_19e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_19e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_19e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_19e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_19e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_19e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_1e_inhaaldatum
		{
			get
			{
				return this.sgt_1e_inhaaldatumField;
			}
			set
			{
				this.sgt_1e_inhaaldatumField = value;
			}
		}
		public string sgt_1e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_1e_speeldatum
		{
			get
			{
				return this.sgt_1e_speeldatumField;
			}
			set
			{
				this.sgt_1e_speeldatumField = value;
			}
		}
		public Lookup sgt_1e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_1e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_1e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_1e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_1e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_1e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_1e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_20e_speeldatum
		{
			get
			{
				return this.sgt_20e_speeldatumField;
			}
			set
			{
				this.sgt_20e_speeldatumField = value;
			}
		}
		public Lookup sgt_20e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_20e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_20e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_20e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_20e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_20e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_20e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_20e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_20e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_2e_inhaaldatum
		{
			get
			{
				return this.sgt_2e_inhaaldatumField;
			}
			set
			{
				this.sgt_2e_inhaaldatumField = value;
			}
		}
		public string sgt_2e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_2e_speeldatum
		{
			get
			{
				return this.sgt_2e_speeldatumField;
			}
			set
			{
				this.sgt_2e_speeldatumField = value;
			}
		}
		public Lookup sgt_2e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_2e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_2e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_2e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_2e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_2e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_2e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_3e_inhaaldatum
		{
			get
			{
				return this.sgt_3e_inhaaldatumField;
			}
			set
			{
				this.sgt_3e_inhaaldatumField = value;
			}
		}
		public string sgt_3e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_3e_speeldatum
		{
			get
			{
				return this.sgt_3e_speeldatumField;
			}
			set
			{
				this.sgt_3e_speeldatumField = value;
			}
		}
		public Lookup sgt_3e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_3e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_3e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_3e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_3e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_3e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_3e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_4e_inhaaldatum
		{
			get
			{
				return this.sgt_4e_inhaaldatumField;
			}
			set
			{
				this.sgt_4e_inhaaldatumField = value;
			}
		}
		public string sgt_4e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_4e_speeldatum
		{
			get
			{
				return this.sgt_4e_speeldatumField;
			}
			set
			{
				this.sgt_4e_speeldatumField = value;
			}
		}
		public Lookup sgt_4e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_4e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_4e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_4e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_4e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_4e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_4e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_5e_inhaaldatum
		{
			get
			{
				return this.sgt_5e_inhaaldatumField;
			}
			set
			{
				this.sgt_5e_inhaaldatumField = value;
			}
		}
		public string sgt_5e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_5e_speeldatum
		{
			get
			{
				return this.sgt_5e_speeldatumField;
			}
			set
			{
				this.sgt_5e_speeldatumField = value;
			}
		}
		public Lookup sgt_5e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_5e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_5e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_5e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_5e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_5e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_5e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_6e_inhaaldatum
		{
			get
			{
				return this.sgt_6e_inhaaldatumField;
			}
			set
			{
				this.sgt_6e_inhaaldatumField = value;
			}
		}
		public string sgt_6e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_6e_speeldatum
		{
			get
			{
				return this.sgt_6e_speeldatumField;
			}
			set
			{
				this.sgt_6e_speeldatumField = value;
			}
		}
		public Lookup sgt_6e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_6e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_6e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_6e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_6e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_6e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_6e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_7e_inhaaldatum
		{
			get
			{
				return this.sgt_7e_inhaaldatumField;
			}
			set
			{
				this.sgt_7e_inhaaldatumField = value;
			}
		}
		public string sgt_7e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_7e_speeldatum
		{
			get
			{
				return this.sgt_7e_speeldatumField;
			}
			set
			{
				this.sgt_7e_speeldatumField = value;
			}
		}
		public Lookup sgt_7e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_7e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_7e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_7e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_7e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_7e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_7e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_8e_inhaaldatum
		{
			get
			{
				return this.sgt_8e_inhaaldatumField;
			}
			set
			{
				this.sgt_8e_inhaaldatumField = value;
			}
		}
		public string sgt_8e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_8e_speeldatum
		{
			get
			{
				return this.sgt_8e_speeldatumField;
			}
			set
			{
				this.sgt_8e_speeldatumField = value;
			}
		}
		public Lookup sgt_8e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_8e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_8e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_8e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_8e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_8e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_8e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmDateTime sgt_9e_inhaaldatum
		{
			get
			{
				return this.sgt_9e_inhaaldatumField;
			}
			set
			{
				this.sgt_9e_inhaaldatumField = value;
			}
		}
		public string sgt_9e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_9e_speeldatum
		{
			get
			{
				return this.sgt_9e_speeldatumField;
			}
			set
			{
				this.sgt_9e_speeldatumField = value;
			}
		}
		public Lookup sgt_9e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_9e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_9e_speeldatum_accommodatieidField = value;
			}
		}
		public string sgt_9e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmNumber sgt_9e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_9e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_9e_speeldatum_volgnummer_ploegField = value;
			}
		}
		public CrmNumber sgt_aantal_winstpunten_per_gewonnen_partij
		{
			get
			{
				return this.sgt_aantal_winstpunten_per_gewonnen_partijField;
			}
			set
			{
				this.sgt_aantal_winstpunten_per_gewonnen_partijField = value;
			}
		}
		public CrmMoney sgt_bedrag_inschrijfbijdrage
		{
			get
			{
				return this.sgt_bedrag_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_bedrag_inschrijfbijdrageField = value;
			}
		}
		public CrmMoney sgt_bedrag_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_bedrag_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_bedrag_inschrijfbijdrage_baseField = value;
			}
		}
		public CrmMoney sgt_bedrag_toeslag
		{
			get
			{
				return this.sgt_bedrag_toeslagField;
			}
			set
			{
				this.sgt_bedrag_toeslagField = value;
			}
		}
		public CrmMoney sgt_bedrag_toeslag_base
		{
			get
			{
				return this.sgt_bedrag_toeslag_baseField;
			}
			set
			{
				this.sgt_bedrag_toeslag_baseField = value;
			}
		}
		public CrmNumber sgt_bonuspunten_bij_setwinst
		{
			get
			{
				return this.sgt_bonuspunten_bij_setwinstField;
			}
			set
			{
				this.sgt_bonuspunten_bij_setwinstField = value;
			}
		}
		[XmlElement("sgt_com_piramide")]
		public string sgt_com_piramide1
		{
			get
			{
				return this.sgt_com_piramide1Field;
			}
			set
			{
				this.sgt_com_piramide1Field = value;
			}
		}
		public Key sgt_com_piramideid
		{
			get
			{
				return this.sgt_com_piramideidField;
			}
			set
			{
				this.sgt_com_piramideidField = value;
			}
		}
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
			}
		}
		public Lookup sgt_competitiesoortid
		{
			get
			{
				return this.sgt_competitiesoortidField;
			}
			set
			{
				this.sgt_competitiesoortidField = value;
			}
		}
		public Picklist sgt_dag
		{
			get
			{
				return this.sgt_dagField;
			}
			set
			{
				this.sgt_dagField = value;
			}
		}
		public Picklist sgt_dagdeel
		{
			get
			{
				return this.sgt_dagdeelField;
			}
			set
			{
				this.sgt_dagdeelField = value;
			}
		}
		public CrmNumber sgt_dames_dubbel
		{
			get
			{
				return this.sgt_dames_dubbelField;
			}
			set
			{
				this.sgt_dames_dubbelField = value;
			}
		}
		public CrmNumber sgt_dames_enkel
		{
			get
			{
				return this.sgt_dames_enkelField;
			}
			set
			{
				this.sgt_dames_enkelField = value;
			}
		}
		public string sgt_eerste_afdeling
		{
			get
			{
				return this.sgt_eerste_afdelingField;
			}
			set
			{
				this.sgt_eerste_afdelingField = value;
			}
		}
		public CrmBoolean sgt_einduitslag_som_van_partijuitslagen
		{
			get
			{
				return this.sgt_einduitslag_som_van_partijuitslagenField;
			}
			set
			{
				this.sgt_einduitslag_som_van_partijuitslagenField = value;
			}
		}
		public Picklist sgt_gelijk_geeindigde_ploegen_vergelijken_op
		{
			get
			{
				return this.sgt_gelijk_geeindigde_ploegen_vergelijken_opField;
			}
			set
			{
				this.sgt_gelijk_geeindigde_ploegen_vergelijken_opField = value;
			}
		}
		public CrmNumber sgt_gemengd_dubbel
		{
			get
			{
				return this.sgt_gemengd_dubbelField;
			}
			set
			{
				this.sgt_gemengd_dubbelField = value;
			}
		}
		public CrmNumber sgt_heren_dubbel
		{
			get
			{
				return this.sgt_heren_dubbelField;
			}
			set
			{
				this.sgt_heren_dubbelField = value;
			}
		}
		public CrmNumber sgt_heren_enkel
		{
			get
			{
				return this.sgt_heren_enkelField;
			}
			set
			{
				this.sgt_heren_enkelField = value;
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
		public CrmNumber sgt_lwinstpunten_per_gelijkgespeelde_partij
		{
			get
			{
				return this.sgt_lwinstpunten_per_gelijkgespeelde_partijField;
			}
			set
			{
				this.sgt_lwinstpunten_per_gelijkgespeelde_partijField = value;
			}
		}
		public CrmNumber sgt_maximum_aantal_partijen_per_persoon
		{
			get
			{
				return this.sgt_maximum_aantal_partijen_per_persoonField;
			}
			set
			{
				this.sgt_maximum_aantal_partijen_per_persoonField = value;
			}
		}
		public CrmNumber sgt_maximum_aantal_ploegen_per_afdeling
		{
			get
			{
				return this.sgt_maximum_aantal_ploegen_per_afdelingField;
			}
			set
			{
				this.sgt_maximum_aantal_ploegen_per_afdelingField = value;
			}
		}
		public CrmNumber sgt_min_dames
		{
			get
			{
				return this.sgt_min_damesField;
			}
			set
			{
				this.sgt_min_damesField = value;
			}
		}
		public CrmNumber sgt_min_heren
		{
			get
			{
				return this.sgt_min_herenField;
			}
			set
			{
				this.sgt_min_herenField = value;
			}
		}
		public CrmNumber sgt_min_spelers
		{
			get
			{
				return this.sgt_min_spelersField;
			}
			set
			{
				this.sgt_min_spelersField = value;
			}
		}
		public CrmFloat sgt_minimum_aantal_banen_per_ploeg
		{
			get
			{
				return this.sgt_minimum_aantal_banen_per_ploegField;
			}
			set
			{
				this.sgt_minimum_aantal_banen_per_ploegField = value;
			}
		}
		public string sgt_omschrijving_inschrijfbijdrage
		{
			get
			{
				return this.sgt_omschrijving_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_omschrijving_inschrijfbijdrageField = value;
			}
		}
		public string sgt_omschrijving_toeslag
		{
			get
			{
				return this.sgt_omschrijving_toeslagField;
			}
			set
			{
				this.sgt_omschrijving_toeslagField = value;
			}
		}
		public CrmBoolean sgt_op_tijd
		{
			get
			{
				return this.sgt_op_tijdField;
			}
			set
			{
				this.sgt_op_tijdField = value;
			}
		}
		public CrmBoolean sgt_partij_mag_gelijk_eindigen
		{
			get
			{
				return this.sgt_partij_mag_gelijk_eindigenField;
			}
			set
			{
				this.sgt_partij_mag_gelijk_eindigenField = value;
			}
		}
		public CrmNumber sgt_partijen_dubbel
		{
			get
			{
				return this.sgt_partijen_dubbelField;
			}
			set
			{
				this.sgt_partijen_dubbelField = value;
			}
		}
		public CrmNumber sgt_partijen_enkel
		{
			get
			{
				return this.sgt_partijen_enkelField;
			}
			set
			{
				this.sgt_partijen_enkelField = value;
			}
		}
		public CrmBoolean sgt_ploegopgave_bij_inschrijven
		{
			get
			{
				return this.sgt_ploegopgave_bij_inschrijvenField;
			}
			set
			{
				this.sgt_ploegopgave_bij_inschrijvenField = value;
			}
		}
		public CrmNumber sgt_punten_bij_afgebroken_set
		{
			get
			{
				return this.sgt_punten_bij_afgebroken_setField;
			}
			set
			{
				this.sgt_punten_bij_afgebroken_setField = value;
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
		public CrmNumber sgt_punten_bij_verlies
		{
			get
			{
				return this.sgt_punten_bij_verliesField;
			}
			set
			{
				this.sgt_punten_bij_verliesField = value;
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
		public CrmBoolean sgt_resultaten_tellen_mee_voor_dss
		{
			get
			{
				return this.sgt_resultaten_tellen_mee_voor_dssField;
			}
			set
			{
				this.sgt_resultaten_tellen_mee_voor_dssField = value;
			}
		}
		public CrmDateTime sgt_speeldatum_beslissingswedstrijd
		{
			get
			{
				return this.sgt_speeldatum_beslissingswedstrijdField;
			}
			set
			{
				this.sgt_speeldatum_beslissingswedstrijdField = value;
			}
		}
		public Lookup sgt_speeldatumsid
		{
			get
			{
				return this.sgt_speeldatumsidField;
			}
			set
			{
				this.sgt_speeldatumsidField = value;
			}
		}
		public CrmBoolean sgt_spelen_op_1_locatie
		{
			get
			{
				return this.sgt_spelen_op_1_locatieField;
			}
			set
			{
				this.sgt_spelen_op_1_locatieField = value;
			}
		}
		public Lookup sgt_telmethode_id
		{
			get
			{
				return this.sgt_telmethode_idField;
			}
			set
			{
				this.sgt_telmethode_idField = value;
			}
		}
		public Lookup sgt_toeslag_ibid
		{
			get
			{
				return this.sgt_toeslag_ibidField;
			}
			set
			{
				this.sgt_toeslag_ibidField = value;
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
		public CrmBoolean sgt_variabele_begintijden
		{
			get
			{
				return this.sgt_variabele_begintijdenField;
			}
			set
			{
				this.sgt_variabele_begintijdenField = value;
			}
		}
		public CrmDateTime sgt_vaste_begintijd
		{
			get
			{
				return this.sgt_vaste_begintijdField;
			}
			set
			{
				this.sgt_vaste_begintijdField = value;
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
		public CrmNumber sgt_winstpunten_per_verloren_partij
		{
			get
			{
				return this.sgt_winstpunten_per_verloren_partijField;
			}
			set
			{
				this.sgt_winstpunten_per_verloren_partijField = value;
			}
		}
		public Sgt_com_piramideStateInfo statecode
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
