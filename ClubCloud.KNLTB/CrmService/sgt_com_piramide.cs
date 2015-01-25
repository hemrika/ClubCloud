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
		public CrmDateTime sgt_10e_inhaaldatum
		{
			get
			{
				return this.sgt_10e_inhaaldatumField;
			}
			set
			{
				this.sgt_10e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_10e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_10e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_10e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_10e_speeldatum
		{
			get
			{
				return this.sgt_10e_speeldatumField;
			}
			set
			{
				this.sgt_10e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_10e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_10e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_10e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_10e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_10e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_10e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_10e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_10e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_10e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_10e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_10e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDateTime sgt_11e_speeldatum
		{
			get
			{
				return this.sgt_11e_speeldatumField;
			}
			set
			{
				this.sgt_11e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_11e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_11e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_11e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_11e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_11e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_11e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_11e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_11e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_11e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber sgt_11e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_11e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_11e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_11e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmDateTime sgt_12e_speeldatum
		{
			get
			{
				return this.sgt_12e_speeldatumField;
			}
			set
			{
				this.sgt_12e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_12e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_12e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_12e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_12e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_12e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_12e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_12e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_12e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_12e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmNumber sgt_12e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_12e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_12e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_12e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmDateTime sgt_13e_speeldatum
		{
			get
			{
				return this.sgt_13e_speeldatumField;
			}
			set
			{
				this.sgt_13e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_13e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_13e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_13e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_13e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_13e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_13e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_13e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_13e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_13e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmNumber sgt_13e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_13e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_13e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_13e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmDateTime sgt_14e_speeldatum
		{
			get
			{
				return this.sgt_14e_speeldatumField;
			}
			set
			{
				this.sgt_14e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_14e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_14e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_14e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_14e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_14e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_14e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_14e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_14e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_14e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmNumber sgt_14e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_14e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_14e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_14e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmDateTime sgt_15e_speeldatum
		{
			get
			{
				return this.sgt_15e_speeldatumField;
			}
			set
			{
				this.sgt_15e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_15e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public Lookup sgt_15e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_15e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_15e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_15e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_15e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_15e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_15e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_15e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public CrmNumber sgt_15e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_15e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_15e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_15e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public CrmDateTime sgt_16e_speeldatum
		{
			get
			{
				return this.sgt_16e_speeldatumField;
			}
			set
			{
				this.sgt_16e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_16e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Lookup sgt_16e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_16e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_16e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_16e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public string sgt_16e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_16e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_16e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_16e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public CrmNumber sgt_16e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_16e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_16e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_16e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public CrmDateTime sgt_17e_speeldatum
		{
			get
			{
				return this.sgt_17e_speeldatumField;
			}
			set
			{
				this.sgt_17e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_17e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public Lookup sgt_17e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_17e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_17e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_17e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public string sgt_17e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_17e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_17e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_17e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public CrmNumber sgt_17e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_17e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_17e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_17e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public CrmDateTime sgt_18e_speeldatum
		{
			get
			{
				return this.sgt_18e_speeldatumField;
			}
			set
			{
				this.sgt_18e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_18e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public Lookup sgt_18e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_18e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_18e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_18e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public string sgt_18e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_18e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_18e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_18e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public CrmNumber sgt_18e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_18e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_18e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_18e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public CrmDateTime sgt_19e_speeldatum
		{
			get
			{
				return this.sgt_19e_speeldatumField;
			}
			set
			{
				this.sgt_19e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_19e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public Lookup sgt_19e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_19e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_19e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_19e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public string sgt_19e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_19e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_19e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_19e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public CrmNumber sgt_19e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_19e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_19e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_19e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public CrmDateTime sgt_1e_inhaaldatum
		{
			get
			{
				return this.sgt_1e_inhaaldatumField;
			}
			set
			{
				this.sgt_1e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_1e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public string sgt_1e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_1e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public CrmDateTime sgt_1e_speeldatum
		{
			get
			{
				return this.sgt_1e_speeldatumField;
			}
			set
			{
				this.sgt_1e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_1e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public Lookup sgt_1e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_1e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_1e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_1e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public string sgt_1e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_1e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public CrmNumber sgt_1e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_1e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_1e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_1e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public CrmDateTime sgt_20e_speeldatum
		{
			get
			{
				return this.sgt_20e_speeldatumField;
			}
			set
			{
				this.sgt_20e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_20e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public Lookup sgt_20e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_20e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_20e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_20e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public string sgt_20e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_20e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_20e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_20e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public CrmNumber sgt_20e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_20e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_20e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_20e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public CrmDateTime sgt_2e_inhaaldatum
		{
			get
			{
				return this.sgt_2e_inhaaldatumField;
			}
			set
			{
				this.sgt_2e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_2e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public string sgt_2e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_2e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public CrmDateTime sgt_2e_speeldatum
		{
			get
			{
				return this.sgt_2e_speeldatumField;
			}
			set
			{
				this.sgt_2e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_2e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public Lookup sgt_2e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_2e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_2e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_2e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public string sgt_2e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_2e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public CrmNumber sgt_2e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_2e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_2e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_2e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public CrmDateTime sgt_3e_inhaaldatum
		{
			get
			{
				return this.sgt_3e_inhaaldatumField;
			}
			set
			{
				this.sgt_3e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_3e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public string sgt_3e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_3e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public CrmDateTime sgt_3e_speeldatum
		{
			get
			{
				return this.sgt_3e_speeldatumField;
			}
			set
			{
				this.sgt_3e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_3e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public Lookup sgt_3e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_3e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_3e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_3e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public string sgt_3e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_3e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public CrmNumber sgt_3e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_3e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_3e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_3e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=73)]
		public CrmDateTime sgt_4e_inhaaldatum
		{
			get
			{
				return this.sgt_4e_inhaaldatumField;
			}
			set
			{
				this.sgt_4e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_4e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=74)]
		public string sgt_4e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_4e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=75)]
		public CrmDateTime sgt_4e_speeldatum
		{
			get
			{
				return this.sgt_4e_speeldatumField;
			}
			set
			{
				this.sgt_4e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_4e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=76)]
		public Lookup sgt_4e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_4e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_4e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_4e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=77)]
		public string sgt_4e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_4e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=78)]
		public CrmNumber sgt_4e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_4e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_4e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_4e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=79)]
		public CrmDateTime sgt_5e_inhaaldatum
		{
			get
			{
				return this.sgt_5e_inhaaldatumField;
			}
			set
			{
				this.sgt_5e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_5e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=80)]
		public string sgt_5e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_5e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=81)]
		public CrmDateTime sgt_5e_speeldatum
		{
			get
			{
				return this.sgt_5e_speeldatumField;
			}
			set
			{
				this.sgt_5e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_5e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=82)]
		public Lookup sgt_5e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_5e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_5e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_5e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=83)]
		public string sgt_5e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_5e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=84)]
		public CrmNumber sgt_5e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_5e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_5e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_5e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=85)]
		public CrmDateTime sgt_6e_inhaaldatum
		{
			get
			{
				return this.sgt_6e_inhaaldatumField;
			}
			set
			{
				this.sgt_6e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_6e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=86)]
		public string sgt_6e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_6e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=87)]
		public CrmDateTime sgt_6e_speeldatum
		{
			get
			{
				return this.sgt_6e_speeldatumField;
			}
			set
			{
				this.sgt_6e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_6e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=88)]
		public Lookup sgt_6e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_6e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_6e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_6e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=89)]
		public string sgt_6e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_6e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=90)]
		public CrmNumber sgt_6e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_6e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_6e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_6e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=91)]
		public CrmDateTime sgt_7e_inhaaldatum
		{
			get
			{
				return this.sgt_7e_inhaaldatumField;
			}
			set
			{
				this.sgt_7e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_7e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=92)]
		public string sgt_7e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_7e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=93)]
		public CrmDateTime sgt_7e_speeldatum
		{
			get
			{
				return this.sgt_7e_speeldatumField;
			}
			set
			{
				this.sgt_7e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_7e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=94)]
		public Lookup sgt_7e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_7e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_7e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_7e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=95)]
		public string sgt_7e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_7e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=96)]
		public CrmNumber sgt_7e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_7e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_7e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_7e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=97)]
		public CrmDateTime sgt_8e_inhaaldatum
		{
			get
			{
				return this.sgt_8e_inhaaldatumField;
			}
			set
			{
				this.sgt_8e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_8e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=98)]
		public string sgt_8e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_8e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=99)]
		public CrmDateTime sgt_8e_speeldatum
		{
			get
			{
				return this.sgt_8e_speeldatumField;
			}
			set
			{
				this.sgt_8e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_8e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=100)]
		public Lookup sgt_8e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_8e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_8e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_8e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=101)]
		public string sgt_8e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_8e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=102)]
		public CrmNumber sgt_8e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_8e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_8e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_8e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=103)]
		public CrmDateTime sgt_9e_inhaaldatum
		{
			get
			{
				return this.sgt_9e_inhaaldatumField;
			}
			set
			{
				this.sgt_9e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_9e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=104)]
		public string sgt_9e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_9e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=105)]
		public CrmDateTime sgt_9e_speeldatum
		{
			get
			{
				return this.sgt_9e_speeldatumField;
			}
			set
			{
				this.sgt_9e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_9e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=106)]
		public Lookup sgt_9e_speeldatum_accommodatieid
		{
			get
			{
				return this.sgt_9e_speeldatum_accommodatieidField;
			}
			set
			{
				this.sgt_9e_speeldatum_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_9e_speeldatum_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=107)]
		public string sgt_9e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_9e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=108)]
		public CrmNumber sgt_9e_speeldatum_volgnummer_ploeg
		{
			get
			{
				return this.sgt_9e_speeldatum_volgnummer_ploegField;
			}
			set
			{
				this.sgt_9e_speeldatum_volgnummer_ploegField = value;
				base.RaisePropertyChanged("sgt_9e_speeldatum_volgnummer_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=109)]
		public CrmNumber sgt_aantal_winstpunten_per_gewonnen_partij
		{
			get
			{
				return this.sgt_aantal_winstpunten_per_gewonnen_partijField;
			}
			set
			{
				this.sgt_aantal_winstpunten_per_gewonnen_partijField = value;
				base.RaisePropertyChanged("sgt_aantal_winstpunten_per_gewonnen_partij");
			}
		}

		[XmlElement] //[XmlElement(Order=110)]
		public CrmMoney sgt_bedrag_inschrijfbijdrage
		{
			get
			{
				return this.sgt_bedrag_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_bedrag_inschrijfbijdrageField = value;
				base.RaisePropertyChanged("sgt_bedrag_inschrijfbijdrage");
			}
		}

		[XmlElement] //[XmlElement(Order=111)]
		public CrmMoney sgt_bedrag_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_bedrag_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_bedrag_inschrijfbijdrage_baseField = value;
				base.RaisePropertyChanged("sgt_bedrag_inschrijfbijdrage_base");
			}
		}

		[XmlElement] //[XmlElement(Order=112)]
		public CrmMoney sgt_bedrag_toeslag
		{
			get
			{
				return this.sgt_bedrag_toeslagField;
			}
			set
			{
				this.sgt_bedrag_toeslagField = value;
				base.RaisePropertyChanged("sgt_bedrag_toeslag");
			}
		}

		[XmlElement] //[XmlElement(Order=113)]
		public CrmMoney sgt_bedrag_toeslag_base
		{
			get
			{
				return this.sgt_bedrag_toeslag_baseField;
			}
			set
			{
				this.sgt_bedrag_toeslag_baseField = value;
				base.RaisePropertyChanged("sgt_bedrag_toeslag_base");
			}
		}

		[XmlElement] //[XmlElement(Order=114)]
		public CrmNumber sgt_bonuspunten_bij_setwinst
		{
			get
			{
				return this.sgt_bonuspunten_bij_setwinstField;
			}
			set
			{
				this.sgt_bonuspunten_bij_setwinstField = value;
				base.RaisePropertyChanged("sgt_bonuspunten_bij_setwinst");
			}
		}

		[XmlElement("sgt_com_piramide")] //, Order=115)]
		public string sgt_com_piramide1
		{
			get
			{
				return this.sgt_com_piramide1Field;
			}
			set
			{
				this.sgt_com_piramide1Field = value;
				base.RaisePropertyChanged("sgt_com_piramide1");
			}
		}

		[XmlElement] //[XmlElement(Order=116)]
		public Key sgt_com_piramideid
		{
			get
			{
				return this.sgt_com_piramideidField;
			}
			set
			{
				this.sgt_com_piramideidField = value;
				base.RaisePropertyChanged("sgt_com_piramideid");
			}
		}

		[XmlElement] //[XmlElement(Order=117)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=118)]
		public Lookup sgt_competitiesoortid
		{
			get
			{
				return this.sgt_competitiesoortidField;
			}
			set
			{
				this.sgt_competitiesoortidField = value;
				base.RaisePropertyChanged("sgt_competitiesoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=119)]
		public Picklist sgt_dag
		{
			get
			{
				return this.sgt_dagField;
			}
			set
			{
				this.sgt_dagField = value;
				base.RaisePropertyChanged("sgt_dag");
			}
		}

		[XmlElement] //[XmlElement(Order=120)]
		public Picklist sgt_dagdeel
		{
			get
			{
				return this.sgt_dagdeelField;
			}
			set
			{
				this.sgt_dagdeelField = value;
				base.RaisePropertyChanged("sgt_dagdeel");
			}
		}

		[XmlElement] //[XmlElement(Order=121)]
		public CrmNumber sgt_dames_dubbel
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

		[XmlElement] //[XmlElement(Order=122)]
		public CrmNumber sgt_dames_enkel
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

		[XmlElement] //[XmlElement(Order=123)]
		public string sgt_eerste_afdeling
		{
			get
			{
				return this.sgt_eerste_afdelingField;
			}
			set
			{
				this.sgt_eerste_afdelingField = value;
				base.RaisePropertyChanged("sgt_eerste_afdeling");
			}
		}

		[XmlElement] //[XmlElement(Order=124)]
		public CrmBoolean sgt_einduitslag_som_van_partijuitslagen
		{
			get
			{
				return this.sgt_einduitslag_som_van_partijuitslagenField;
			}
			set
			{
				this.sgt_einduitslag_som_van_partijuitslagenField = value;
				base.RaisePropertyChanged("sgt_einduitslag_som_van_partijuitslagen");
			}
		}

		[XmlElement] //[XmlElement(Order=125)]
		public Picklist sgt_gelijk_geeindigde_ploegen_vergelijken_op
		{
			get
			{
				return this.sgt_gelijk_geeindigde_ploegen_vergelijken_opField;
			}
			set
			{
				this.sgt_gelijk_geeindigde_ploegen_vergelijken_opField = value;
				base.RaisePropertyChanged("sgt_gelijk_geeindigde_ploegen_vergelijken_op");
			}
		}

		[XmlElement] //[XmlElement(Order=126)]
		public CrmNumber sgt_gemengd_dubbel
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

		[XmlElement] //[XmlElement(Order=127)]
		public CrmNumber sgt_heren_dubbel
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

		[XmlElement] //[XmlElement(Order=128)]
		public CrmNumber sgt_heren_enkel
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

		[XmlElement] //[XmlElement(Order=129)]
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

		[XmlElement] //[XmlElement(Order=130)]
		public CrmNumber sgt_lwinstpunten_per_gelijkgespeelde_partij
		{
			get
			{
				return this.sgt_lwinstpunten_per_gelijkgespeelde_partijField;
			}
			set
			{
				this.sgt_lwinstpunten_per_gelijkgespeelde_partijField = value;
				base.RaisePropertyChanged("sgt_lwinstpunten_per_gelijkgespeelde_partij");
			}
		}

		[XmlElement] //[XmlElement(Order=131)]
		public CrmNumber sgt_maximum_aantal_partijen_per_persoon
		{
			get
			{
				return this.sgt_maximum_aantal_partijen_per_persoonField;
			}
			set
			{
				this.sgt_maximum_aantal_partijen_per_persoonField = value;
				base.RaisePropertyChanged("sgt_maximum_aantal_partijen_per_persoon");
			}
		}

		[XmlElement] //[XmlElement(Order=132)]
		public CrmNumber sgt_maximum_aantal_ploegen_per_afdeling
		{
			get
			{
				return this.sgt_maximum_aantal_ploegen_per_afdelingField;
			}
			set
			{
				this.sgt_maximum_aantal_ploegen_per_afdelingField = value;
				base.RaisePropertyChanged("sgt_maximum_aantal_ploegen_per_afdeling");
			}
		}

		[XmlElement] //[XmlElement(Order=133)]
		public CrmNumber sgt_min_dames
		{
			get
			{
				return this.sgt_min_damesField;
			}
			set
			{
				this.sgt_min_damesField = value;
				base.RaisePropertyChanged("sgt_min_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=134)]
		public CrmNumber sgt_min_heren
		{
			get
			{
				return this.sgt_min_herenField;
			}
			set
			{
				this.sgt_min_herenField = value;
				base.RaisePropertyChanged("sgt_min_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=135)]
		public CrmNumber sgt_min_spelers
		{
			get
			{
				return this.sgt_min_spelersField;
			}
			set
			{
				this.sgt_min_spelersField = value;
				base.RaisePropertyChanged("sgt_min_spelers");
			}
		}

		[XmlElement] //[XmlElement(Order=136)]
		public CrmFloat sgt_minimum_aantal_banen_per_ploeg
		{
			get
			{
				return this.sgt_minimum_aantal_banen_per_ploegField;
			}
			set
			{
				this.sgt_minimum_aantal_banen_per_ploegField = value;
				base.RaisePropertyChanged("sgt_minimum_aantal_banen_per_ploeg");
			}
		}

		[XmlElement] //[XmlElement(Order=137)]
		public string sgt_omschrijving_inschrijfbijdrage
		{
			get
			{
				return this.sgt_omschrijving_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_omschrijving_inschrijfbijdrageField = value;
				base.RaisePropertyChanged("sgt_omschrijving_inschrijfbijdrage");
			}
		}

		[XmlElement] //[XmlElement(Order=138)]
		public string sgt_omschrijving_toeslag
		{
			get
			{
				return this.sgt_omschrijving_toeslagField;
			}
			set
			{
				this.sgt_omschrijving_toeslagField = value;
				base.RaisePropertyChanged("sgt_omschrijving_toeslag");
			}
		}

		[XmlElement] //[XmlElement(Order=139)]
		public CrmBoolean sgt_op_tijd
		{
			get
			{
				return this.sgt_op_tijdField;
			}
			set
			{
				this.sgt_op_tijdField = value;
				base.RaisePropertyChanged("sgt_op_tijd");
			}
		}

		[XmlElement] //[XmlElement(Order=140)]
		public CrmBoolean sgt_partij_mag_gelijk_eindigen
		{
			get
			{
				return this.sgt_partij_mag_gelijk_eindigenField;
			}
			set
			{
				this.sgt_partij_mag_gelijk_eindigenField = value;
				base.RaisePropertyChanged("sgt_partij_mag_gelijk_eindigen");
			}
		}

		[XmlElement] //[XmlElement(Order=141)]
		public CrmNumber sgt_partijen_dubbel
		{
			get
			{
				return this.sgt_partijen_dubbelField;
			}
			set
			{
				this.sgt_partijen_dubbelField = value;
				base.RaisePropertyChanged("sgt_partijen_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=142)]
		public CrmNumber sgt_partijen_enkel
		{
			get
			{
				return this.sgt_partijen_enkelField;
			}
			set
			{
				this.sgt_partijen_enkelField = value;
				base.RaisePropertyChanged("sgt_partijen_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=143)]
		public CrmBoolean sgt_ploegopgave_bij_inschrijven
		{
			get
			{
				return this.sgt_ploegopgave_bij_inschrijvenField;
			}
			set
			{
				this.sgt_ploegopgave_bij_inschrijvenField = value;
				base.RaisePropertyChanged("sgt_ploegopgave_bij_inschrijven");
			}
		}

		[XmlElement] //[XmlElement(Order=144)]
		public CrmNumber sgt_punten_bij_afgebroken_set
		{
			get
			{
				return this.sgt_punten_bij_afgebroken_setField;
			}
			set
			{
				this.sgt_punten_bij_afgebroken_setField = value;
				base.RaisePropertyChanged("sgt_punten_bij_afgebroken_set");
			}
		}

		[XmlElement] //[XmlElement(Order=145)]
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

		[XmlElement] //[XmlElement(Order=146)]
		public CrmNumber sgt_punten_bij_verlies
		{
			get
			{
				return this.sgt_punten_bij_verliesField;
			}
			set
			{
				this.sgt_punten_bij_verliesField = value;
				base.RaisePropertyChanged("sgt_punten_bij_verlies");
			}
		}

		[XmlElement] //[XmlElement(Order=147)]
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

		[XmlElement] //[XmlElement(Order=148)]
		public CrmBoolean sgt_resultaten_tellen_mee_voor_dss
		{
			get
			{
				return this.sgt_resultaten_tellen_mee_voor_dssField;
			}
			set
			{
				this.sgt_resultaten_tellen_mee_voor_dssField = value;
				base.RaisePropertyChanged("sgt_resultaten_tellen_mee_voor_dss");
			}
		}

		[XmlElement] //[XmlElement(Order=149)]
		public CrmDateTime sgt_speeldatum_beslissingswedstrijd
		{
			get
			{
				return this.sgt_speeldatum_beslissingswedstrijdField;
			}
			set
			{
				this.sgt_speeldatum_beslissingswedstrijdField = value;
				base.RaisePropertyChanged("sgt_speeldatum_beslissingswedstrijd");
			}
		}

		[XmlElement] //[XmlElement(Order=150)]
		public Lookup sgt_speeldatumsid
		{
			get
			{
				return this.sgt_speeldatumsidField;
			}
			set
			{
				this.sgt_speeldatumsidField = value;
				base.RaisePropertyChanged("sgt_speeldatumsid");
			}
		}

		[XmlElement] //[XmlElement(Order=151)]
		public CrmBoolean sgt_spelen_op_1_locatie
		{
			get
			{
				return this.sgt_spelen_op_1_locatieField;
			}
			set
			{
				this.sgt_spelen_op_1_locatieField = value;
				base.RaisePropertyChanged("sgt_spelen_op_1_locatie");
			}
		}

		[XmlElement] //[XmlElement(Order=152)]
		public Lookup sgt_telmethode_id
		{
			get
			{
				return this.sgt_telmethode_idField;
			}
			set
			{
				this.sgt_telmethode_idField = value;
				base.RaisePropertyChanged("sgt_telmethode_id");
			}
		}

		[XmlElement] //[XmlElement(Order=153)]
		public Lookup sgt_toeslag_ibid
		{
			get
			{
				return this.sgt_toeslag_ibidField;
			}
			set
			{
				this.sgt_toeslag_ibidField = value;
				base.RaisePropertyChanged("sgt_toeslag_ibid");
			}
		}

		[XmlElement] //[XmlElement(Order=154)]
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

		[XmlElement] //[XmlElement(Order=155)]
		public CrmBoolean sgt_variabele_begintijden
		{
			get
			{
				return this.sgt_variabele_begintijdenField;
			}
			set
			{
				this.sgt_variabele_begintijdenField = value;
				base.RaisePropertyChanged("sgt_variabele_begintijden");
			}
		}

		[XmlElement] //[XmlElement(Order=156)]
		public CrmDateTime sgt_vaste_begintijd
		{
			get
			{
				return this.sgt_vaste_begintijdField;
			}
			set
			{
				this.sgt_vaste_begintijdField = value;
				base.RaisePropertyChanged("sgt_vaste_begintijd");
			}
		}

		[XmlElement] //[XmlElement(Order=157)]
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

		[XmlElement] //[XmlElement(Order=158)]
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

		[XmlElement] //[XmlElement(Order=159)]
		public CrmNumber sgt_winstpunten_per_verloren_partij
		{
			get
			{
				return this.sgt_winstpunten_per_verloren_partijField;
			}
			set
			{
				this.sgt_winstpunten_per_verloren_partijField = value;
				base.RaisePropertyChanged("sgt_winstpunten_per_verloren_partij");
			}
		}

		[XmlElement] //[XmlElement(Order=160)]
		public Sgt_com_piramideStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=161)]
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

		[XmlElement] //[XmlElement(Order=162)]
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

		[XmlElement] //[XmlElement(Order=163)]
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

		[XmlElement] //[XmlElement(Order=164)]
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

		public sgt_com_piramide()
		{
		}
	}
}