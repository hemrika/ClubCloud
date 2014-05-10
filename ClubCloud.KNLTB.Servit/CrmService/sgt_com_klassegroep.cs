using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_klassegroep : BusinessEntity
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
		private string sgt_7e_inhaaldatumdagaanduidingField;
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
		private string sgt_9e_inhaaldatumdagaanduidingField;
		private CrmDateTime sgt_9e_speeldatumField;
		private Lookup sgt_9e_speeldatum_accommodatieidField;
		private string sgt_9e_speeldatum_dagaanduidingField;
		private CrmNumber sgt_9e_speeldatum_volgnummer_ploegField;
		private CrmNumber sgt_aantal_degradatieField;
		private CrmNumber sgt_aantal_hoofdscheidsrechtersField;
		private CrmNumber sgt_aantal_lijnscheidsrechtersField;
		private CrmNumber sgt_aantal_partijen_dubbelField;
		private CrmNumber sgt_aantal_partijen_dubbel_damesField;
		private CrmNumber sgt_aantal_partijen_dubbel_herenField;
		private CrmNumber sgt_aantal_partijen_enkelField;
		private CrmNumber sgt_aantal_partijen_enkel_damesField;
		private CrmNumber sgt_aantal_partijen_enkel_herenField;
		private CrmNumber sgt_aantal_partijen_gemengdField;
		private CrmNumber sgt_aantal_promotieField;
		private CrmNumber sgt_aantal_stoelscheidsrechtersField;
		private CrmNumber sgt_aantal_toezichthoudersField;
		private CrmDateTime sgt_aanvangstijdField;
		private CrmBoolean sgt_afdwingenField;
		private Picklist sgt_berekenen_reisField;
		private CrmNumber sgt_boete_aantal_dagenField;
		private Lookup sgt_boete_niet_invoeren_uitslagenidField;
		private CrmMoney sgt_boetebedragField;
		private CrmMoney sgt_boetebedrag_baseField;
		private Key sgt_com_klassegroepidField;
		private string sgt_com_omschrijvingField;
		private Lookup sgt_competitieidField;
		private Picklist sgt_fact_regl_arbitrageField;
		private Lookup sgt_fact_regl_arbitrage_productidField;
		private CrmNumber sgt_herinnering_aantal_dagenField;
		private CrmBoolean sgt_invoeren_individueelField;
		private CrmBoolean sgt_kampioenschap_indicatorField;
		private Lookup sgt_klassegroep_degradatieidField;
		private Lookup sgt_klassegroep_promotieidField;
		private Lookup sgt_klasseidField;
		private CrmNumber sgt_maximum_aantal_afdelingenField;
		private CrmNumber sgt_maximum_reisafstandField;
		private CrmNumber sgt_maximum_reistijdField;
		private string sgt_nummerField;
		private Lookup sgt_piramideidField;
		private Picklist sgt_ploeggemiddelde_bepalingField;
		private CrmDecimal sgt_ploeggemiddelde_tot_en_met_decimalField;
		private CrmDecimal sgt_ploeggemiddelde_vanaf_decimalField;
		private CrmBoolean sgt_promotie_degradatie_meenemen_in_indelingField;
		private Lookup sgt_reeks_speeldatumsidField;
		private CrmBoolean sgt_vrije_inschrijvingField;
		private Sgt_com_klassegroepStateInfo statecodeField;
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
		public string sgt_7e_inhaaldatumdagaanduiding
		{
			get
			{
				return this.sgt_7e_inhaaldatumdagaanduidingField;
			}
			set
			{
				this.sgt_7e_inhaaldatumdagaanduidingField = value;
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
		public string sgt_9e_inhaaldatumdagaanduiding
		{
			get
			{
				return this.sgt_9e_inhaaldatumdagaanduidingField;
			}
			set
			{
				this.sgt_9e_inhaaldatumdagaanduidingField = value;
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
		public CrmNumber sgt_aantal_degradatie
		{
			get
			{
				return this.sgt_aantal_degradatieField;
			}
			set
			{
				this.sgt_aantal_degradatieField = value;
			}
		}
		public CrmNumber sgt_aantal_hoofdscheidsrechters
		{
			get
			{
				return this.sgt_aantal_hoofdscheidsrechtersField;
			}
			set
			{
				this.sgt_aantal_hoofdscheidsrechtersField = value;
			}
		}
		public CrmNumber sgt_aantal_lijnscheidsrechters
		{
			get
			{
				return this.sgt_aantal_lijnscheidsrechtersField;
			}
			set
			{
				this.sgt_aantal_lijnscheidsrechtersField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_dubbel
		{
			get
			{
				return this.sgt_aantal_partijen_dubbelField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbelField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_dubbel_dames
		{
			get
			{
				return this.sgt_aantal_partijen_dubbel_damesField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbel_damesField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_dubbel_heren
		{
			get
			{
				return this.sgt_aantal_partijen_dubbel_herenField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbel_herenField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_enkel
		{
			get
			{
				return this.sgt_aantal_partijen_enkelField;
			}
			set
			{
				this.sgt_aantal_partijen_enkelField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_enkel_dames
		{
			get
			{
				return this.sgt_aantal_partijen_enkel_damesField;
			}
			set
			{
				this.sgt_aantal_partijen_enkel_damesField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_enkel_heren
		{
			get
			{
				return this.sgt_aantal_partijen_enkel_herenField;
			}
			set
			{
				this.sgt_aantal_partijen_enkel_herenField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_gemengd
		{
			get
			{
				return this.sgt_aantal_partijen_gemengdField;
			}
			set
			{
				this.sgt_aantal_partijen_gemengdField = value;
			}
		}
		public CrmNumber sgt_aantal_promotie
		{
			get
			{
				return this.sgt_aantal_promotieField;
			}
			set
			{
				this.sgt_aantal_promotieField = value;
			}
		}
		public CrmNumber sgt_aantal_stoelscheidsrechters
		{
			get
			{
				return this.sgt_aantal_stoelscheidsrechtersField;
			}
			set
			{
				this.sgt_aantal_stoelscheidsrechtersField = value;
			}
		}
		public CrmNumber sgt_aantal_toezichthouders
		{
			get
			{
				return this.sgt_aantal_toezichthoudersField;
			}
			set
			{
				this.sgt_aantal_toezichthoudersField = value;
			}
		}
		public CrmDateTime sgt_aanvangstijd
		{
			get
			{
				return this.sgt_aanvangstijdField;
			}
			set
			{
				this.sgt_aanvangstijdField = value;
			}
		}
		public CrmBoolean sgt_afdwingen
		{
			get
			{
				return this.sgt_afdwingenField;
			}
			set
			{
				this.sgt_afdwingenField = value;
			}
		}
		public Picklist sgt_berekenen_reis
		{
			get
			{
				return this.sgt_berekenen_reisField;
			}
			set
			{
				this.sgt_berekenen_reisField = value;
			}
		}
		public CrmNumber sgt_boete_aantal_dagen
		{
			get
			{
				return this.sgt_boete_aantal_dagenField;
			}
			set
			{
				this.sgt_boete_aantal_dagenField = value;
			}
		}
		public Lookup sgt_boete_niet_invoeren_uitslagenid
		{
			get
			{
				return this.sgt_boete_niet_invoeren_uitslagenidField;
			}
			set
			{
				this.sgt_boete_niet_invoeren_uitslagenidField = value;
			}
		}
		public CrmMoney sgt_boetebedrag
		{
			get
			{
				return this.sgt_boetebedragField;
			}
			set
			{
				this.sgt_boetebedragField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_base
		{
			get
			{
				return this.sgt_boetebedrag_baseField;
			}
			set
			{
				this.sgt_boetebedrag_baseField = value;
			}
		}
		public Key sgt_com_klassegroepid
		{
			get
			{
				return this.sgt_com_klassegroepidField;
			}
			set
			{
				this.sgt_com_klassegroepidField = value;
			}
		}
		public string sgt_com_omschrijving
		{
			get
			{
				return this.sgt_com_omschrijvingField;
			}
			set
			{
				this.sgt_com_omschrijvingField = value;
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
		public Picklist sgt_fact_regl_arbitrage
		{
			get
			{
				return this.sgt_fact_regl_arbitrageField;
			}
			set
			{
				this.sgt_fact_regl_arbitrageField = value;
			}
		}
		public Lookup sgt_fact_regl_arbitrage_productid
		{
			get
			{
				return this.sgt_fact_regl_arbitrage_productidField;
			}
			set
			{
				this.sgt_fact_regl_arbitrage_productidField = value;
			}
		}
		public CrmNumber sgt_herinnering_aantal_dagen
		{
			get
			{
				return this.sgt_herinnering_aantal_dagenField;
			}
			set
			{
				this.sgt_herinnering_aantal_dagenField = value;
			}
		}
		public CrmBoolean sgt_invoeren_individueel
		{
			get
			{
				return this.sgt_invoeren_individueelField;
			}
			set
			{
				this.sgt_invoeren_individueelField = value;
			}
		}
		public CrmBoolean sgt_kampioenschap_indicator
		{
			get
			{
				return this.sgt_kampioenschap_indicatorField;
			}
			set
			{
				this.sgt_kampioenschap_indicatorField = value;
			}
		}
		public Lookup sgt_klassegroep_degradatieid
		{
			get
			{
				return this.sgt_klassegroep_degradatieidField;
			}
			set
			{
				this.sgt_klassegroep_degradatieidField = value;
			}
		}
		public Lookup sgt_klassegroep_promotieid
		{
			get
			{
				return this.sgt_klassegroep_promotieidField;
			}
			set
			{
				this.sgt_klassegroep_promotieidField = value;
			}
		}
		public Lookup sgt_klasseid
		{
			get
			{
				return this.sgt_klasseidField;
			}
			set
			{
				this.sgt_klasseidField = value;
			}
		}
		public CrmNumber sgt_maximum_aantal_afdelingen
		{
			get
			{
				return this.sgt_maximum_aantal_afdelingenField;
			}
			set
			{
				this.sgt_maximum_aantal_afdelingenField = value;
			}
		}
		public CrmNumber sgt_maximum_reisafstand
		{
			get
			{
				return this.sgt_maximum_reisafstandField;
			}
			set
			{
				this.sgt_maximum_reisafstandField = value;
			}
		}
		public CrmNumber sgt_maximum_reistijd
		{
			get
			{
				return this.sgt_maximum_reistijdField;
			}
			set
			{
				this.sgt_maximum_reistijdField = value;
			}
		}
		public string sgt_nummer
		{
			get
			{
				return this.sgt_nummerField;
			}
			set
			{
				this.sgt_nummerField = value;
			}
		}
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
			}
		}
		public Picklist sgt_ploeggemiddelde_bepaling
		{
			get
			{
				return this.sgt_ploeggemiddelde_bepalingField;
			}
			set
			{
				this.sgt_ploeggemiddelde_bepalingField = value;
			}
		}
		public CrmDecimal sgt_ploeggemiddelde_tot_en_met_decimal
		{
			get
			{
				return this.sgt_ploeggemiddelde_tot_en_met_decimalField;
			}
			set
			{
				this.sgt_ploeggemiddelde_tot_en_met_decimalField = value;
			}
		}
		public CrmDecimal sgt_ploeggemiddelde_vanaf_decimal
		{
			get
			{
				return this.sgt_ploeggemiddelde_vanaf_decimalField;
			}
			set
			{
				this.sgt_ploeggemiddelde_vanaf_decimalField = value;
			}
		}
		public CrmBoolean sgt_promotie_degradatie_meenemen_in_indeling
		{
			get
			{
				return this.sgt_promotie_degradatie_meenemen_in_indelingField;
			}
			set
			{
				this.sgt_promotie_degradatie_meenemen_in_indelingField = value;
			}
		}
		public Lookup sgt_reeks_speeldatumsid
		{
			get
			{
				return this.sgt_reeks_speeldatumsidField;
			}
			set
			{
				this.sgt_reeks_speeldatumsidField = value;
			}
		}
		public CrmBoolean sgt_vrije_inschrijving
		{
			get
			{
				return this.sgt_vrije_inschrijvingField;
			}
			set
			{
				this.sgt_vrije_inschrijvingField = value;
			}
		}
		public Sgt_com_klassegroepStateInfo statecode
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
