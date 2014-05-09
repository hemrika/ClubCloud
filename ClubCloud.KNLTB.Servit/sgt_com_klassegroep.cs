using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
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
		[XmlElement(Order = 41)]
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
		[XmlElement(Order = 42)]
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
		[XmlElement(Order = 43)]
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
		[XmlElement(Order = 44)]
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
		[XmlElement(Order = 45)]
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
		[XmlElement(Order = 46)]
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
		[XmlElement(Order = 47)]
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
		[XmlElement(Order = 48)]
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
		[XmlElement(Order = 49)]
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
		[XmlElement(Order = 50)]
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
		[XmlElement(Order = 51)]
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
		[XmlElement(Order = 52)]
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
		[XmlElement(Order = 53)]
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
		[XmlElement(Order = 54)]
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
		[XmlElement(Order = 55)]
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
		[XmlElement(Order = 56)]
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
		[XmlElement(Order = 57)]
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
		[XmlElement(Order = 58)]
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
		[XmlElement(Order = 59)]
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
		[XmlElement(Order = 60)]
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
		[XmlElement(Order = 61)]
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
		[XmlElement(Order = 62)]
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
		[XmlElement(Order = 63)]
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
		[XmlElement(Order = 64)]
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
		[XmlElement(Order = 65)]
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
		[XmlElement(Order = 66)]
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
		[XmlElement(Order = 67)]
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
		[XmlElement(Order = 68)]
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
		[XmlElement(Order = 69)]
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
		[XmlElement(Order = 70)]
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
		[XmlElement(Order = 71)]
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
		[XmlElement(Order = 72)]
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
		[XmlElement(Order = 73)]
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
		[XmlElement(Order = 74)]
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
		[XmlElement(Order = 75)]
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
		[XmlElement(Order = 76)]
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
		[XmlElement(Order = 77)]
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
		[XmlElement(Order = 78)]
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
		[XmlElement(Order = 79)]
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
		[XmlElement(Order = 80)]
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
		[XmlElement(Order = 81)]
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
		[XmlElement(Order = 82)]
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
		[XmlElement(Order = 83)]
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
		[XmlElement(Order = 84)]
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
		[XmlElement(Order = 85)]
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
		[XmlElement(Order = 86)]
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
		[XmlElement(Order = 87)]
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
		[XmlElement(Order = 88)]
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
		[XmlElement(Order = 89)]
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
		[XmlElement(Order = 90)]
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
		[XmlElement(Order = 91)]
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
		[XmlElement(Order = 92)]
		public string sgt_7e_inhaaldatumdagaanduiding
		{
			get
			{
				return this.sgt_7e_inhaaldatumdagaanduidingField;
			}
			set
			{
				this.sgt_7e_inhaaldatumdagaanduidingField = value;
				base.RaisePropertyChanged("sgt_7e_inhaaldatumdagaanduiding");
			}
		}
		[XmlElement(Order = 93)]
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
		[XmlElement(Order = 94)]
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
		[XmlElement(Order = 95)]
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
		[XmlElement(Order = 96)]
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
		[XmlElement(Order = 97)]
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
		[XmlElement(Order = 98)]
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
		[XmlElement(Order = 99)]
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
		[XmlElement(Order = 100)]
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
		[XmlElement(Order = 101)]
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
		[XmlElement(Order = 102)]
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
		[XmlElement(Order = 103)]
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
		[XmlElement(Order = 104)]
		public string sgt_9e_inhaaldatumdagaanduiding
		{
			get
			{
				return this.sgt_9e_inhaaldatumdagaanduidingField;
			}
			set
			{
				this.sgt_9e_inhaaldatumdagaanduidingField = value;
				base.RaisePropertyChanged("sgt_9e_inhaaldatumdagaanduiding");
			}
		}
		[XmlElement(Order = 105)]
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
		[XmlElement(Order = 106)]
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
		[XmlElement(Order = 107)]
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
		[XmlElement(Order = 108)]
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
		[XmlElement(Order = 109)]
		public CrmNumber sgt_aantal_degradatie
		{
			get
			{
				return this.sgt_aantal_degradatieField;
			}
			set
			{
				this.sgt_aantal_degradatieField = value;
				base.RaisePropertyChanged("sgt_aantal_degradatie");
			}
		}
		[XmlElement(Order = 110)]
		public CrmNumber sgt_aantal_hoofdscheidsrechters
		{
			get
			{
				return this.sgt_aantal_hoofdscheidsrechtersField;
			}
			set
			{
				this.sgt_aantal_hoofdscheidsrechtersField = value;
				base.RaisePropertyChanged("sgt_aantal_hoofdscheidsrechters");
			}
		}
		[XmlElement(Order = 111)]
		public CrmNumber sgt_aantal_lijnscheidsrechters
		{
			get
			{
				return this.sgt_aantal_lijnscheidsrechtersField;
			}
			set
			{
				this.sgt_aantal_lijnscheidsrechtersField = value;
				base.RaisePropertyChanged("sgt_aantal_lijnscheidsrechters");
			}
		}
		[XmlElement(Order = 112)]
		public CrmNumber sgt_aantal_partijen_dubbel
		{
			get
			{
				return this.sgt_aantal_partijen_dubbelField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbelField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_dubbel");
			}
		}
		[XmlElement(Order = 113)]
		public CrmNumber sgt_aantal_partijen_dubbel_dames
		{
			get
			{
				return this.sgt_aantal_partijen_dubbel_damesField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbel_damesField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_dubbel_dames");
			}
		}
		[XmlElement(Order = 114)]
		public CrmNumber sgt_aantal_partijen_dubbel_heren
		{
			get
			{
				return this.sgt_aantal_partijen_dubbel_herenField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbel_herenField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_dubbel_heren");
			}
		}
		[XmlElement(Order = 115)]
		public CrmNumber sgt_aantal_partijen_enkel
		{
			get
			{
				return this.sgt_aantal_partijen_enkelField;
			}
			set
			{
				this.sgt_aantal_partijen_enkelField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_enkel");
			}
		}
		[XmlElement(Order = 116)]
		public CrmNumber sgt_aantal_partijen_enkel_dames
		{
			get
			{
				return this.sgt_aantal_partijen_enkel_damesField;
			}
			set
			{
				this.sgt_aantal_partijen_enkel_damesField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_enkel_dames");
			}
		}
		[XmlElement(Order = 117)]
		public CrmNumber sgt_aantal_partijen_enkel_heren
		{
			get
			{
				return this.sgt_aantal_partijen_enkel_herenField;
			}
			set
			{
				this.sgt_aantal_partijen_enkel_herenField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_enkel_heren");
			}
		}
		[XmlElement(Order = 118)]
		public CrmNumber sgt_aantal_partijen_gemengd
		{
			get
			{
				return this.sgt_aantal_partijen_gemengdField;
			}
			set
			{
				this.sgt_aantal_partijen_gemengdField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_gemengd");
			}
		}
		[XmlElement(Order = 119)]
		public CrmNumber sgt_aantal_promotie
		{
			get
			{
				return this.sgt_aantal_promotieField;
			}
			set
			{
				this.sgt_aantal_promotieField = value;
				base.RaisePropertyChanged("sgt_aantal_promotie");
			}
		}
		[XmlElement(Order = 120)]
		public CrmNumber sgt_aantal_stoelscheidsrechters
		{
			get
			{
				return this.sgt_aantal_stoelscheidsrechtersField;
			}
			set
			{
				this.sgt_aantal_stoelscheidsrechtersField = value;
				base.RaisePropertyChanged("sgt_aantal_stoelscheidsrechters");
			}
		}
		[XmlElement(Order = 121)]
		public CrmNumber sgt_aantal_toezichthouders
		{
			get
			{
				return this.sgt_aantal_toezichthoudersField;
			}
			set
			{
				this.sgt_aantal_toezichthoudersField = value;
				base.RaisePropertyChanged("sgt_aantal_toezichthouders");
			}
		}
		[XmlElement(Order = 122)]
		public CrmDateTime sgt_aanvangstijd
		{
			get
			{
				return this.sgt_aanvangstijdField;
			}
			set
			{
				this.sgt_aanvangstijdField = value;
				base.RaisePropertyChanged("sgt_aanvangstijd");
			}
		}
		[XmlElement(Order = 123)]
		public CrmBoolean sgt_afdwingen
		{
			get
			{
				return this.sgt_afdwingenField;
			}
			set
			{
				this.sgt_afdwingenField = value;
				base.RaisePropertyChanged("sgt_afdwingen");
			}
		}
		[XmlElement(Order = 124)]
		public Picklist sgt_berekenen_reis
		{
			get
			{
				return this.sgt_berekenen_reisField;
			}
			set
			{
				this.sgt_berekenen_reisField = value;
				base.RaisePropertyChanged("sgt_berekenen_reis");
			}
		}
		[XmlElement(Order = 125)]
		public CrmNumber sgt_boete_aantal_dagen
		{
			get
			{
				return this.sgt_boete_aantal_dagenField;
			}
			set
			{
				this.sgt_boete_aantal_dagenField = value;
				base.RaisePropertyChanged("sgt_boete_aantal_dagen");
			}
		}
		[XmlElement(Order = 126)]
		public Lookup sgt_boete_niet_invoeren_uitslagenid
		{
			get
			{
				return this.sgt_boete_niet_invoeren_uitslagenidField;
			}
			set
			{
				this.sgt_boete_niet_invoeren_uitslagenidField = value;
				base.RaisePropertyChanged("sgt_boete_niet_invoeren_uitslagenid");
			}
		}
		[XmlElement(Order = 127)]
		public CrmMoney sgt_boetebedrag
		{
			get
			{
				return this.sgt_boetebedragField;
			}
			set
			{
				this.sgt_boetebedragField = value;
				base.RaisePropertyChanged("sgt_boetebedrag");
			}
		}
		[XmlElement(Order = 128)]
		public CrmMoney sgt_boetebedrag_base
		{
			get
			{
				return this.sgt_boetebedrag_baseField;
			}
			set
			{
				this.sgt_boetebedrag_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_base");
			}
		}
		[XmlElement(Order = 129)]
		public Key sgt_com_klassegroepid
		{
			get
			{
				return this.sgt_com_klassegroepidField;
			}
			set
			{
				this.sgt_com_klassegroepidField = value;
				base.RaisePropertyChanged("sgt_com_klassegroepid");
			}
		}
		[XmlElement(Order = 130)]
		public string sgt_com_omschrijving
		{
			get
			{
				return this.sgt_com_omschrijvingField;
			}
			set
			{
				this.sgt_com_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_com_omschrijving");
			}
		}
		[XmlElement(Order = 131)]
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
		[XmlElement(Order = 132)]
		public Picklist sgt_fact_regl_arbitrage
		{
			get
			{
				return this.sgt_fact_regl_arbitrageField;
			}
			set
			{
				this.sgt_fact_regl_arbitrageField = value;
				base.RaisePropertyChanged("sgt_fact_regl_arbitrage");
			}
		}
		[XmlElement(Order = 133)]
		public Lookup sgt_fact_regl_arbitrage_productid
		{
			get
			{
				return this.sgt_fact_regl_arbitrage_productidField;
			}
			set
			{
				this.sgt_fact_regl_arbitrage_productidField = value;
				base.RaisePropertyChanged("sgt_fact_regl_arbitrage_productid");
			}
		}
		[XmlElement(Order = 134)]
		public CrmNumber sgt_herinnering_aantal_dagen
		{
			get
			{
				return this.sgt_herinnering_aantal_dagenField;
			}
			set
			{
				this.sgt_herinnering_aantal_dagenField = value;
				base.RaisePropertyChanged("sgt_herinnering_aantal_dagen");
			}
		}
		[XmlElement(Order = 135)]
		public CrmBoolean sgt_invoeren_individueel
		{
			get
			{
				return this.sgt_invoeren_individueelField;
			}
			set
			{
				this.sgt_invoeren_individueelField = value;
				base.RaisePropertyChanged("sgt_invoeren_individueel");
			}
		}
		[XmlElement(Order = 136)]
		public CrmBoolean sgt_kampioenschap_indicator
		{
			get
			{
				return this.sgt_kampioenschap_indicatorField;
			}
			set
			{
				this.sgt_kampioenschap_indicatorField = value;
				base.RaisePropertyChanged("sgt_kampioenschap_indicator");
			}
		}
		[XmlElement(Order = 137)]
		public Lookup sgt_klassegroep_degradatieid
		{
			get
			{
				return this.sgt_klassegroep_degradatieidField;
			}
			set
			{
				this.sgt_klassegroep_degradatieidField = value;
				base.RaisePropertyChanged("sgt_klassegroep_degradatieid");
			}
		}
		[XmlElement(Order = 138)]
		public Lookup sgt_klassegroep_promotieid
		{
			get
			{
				return this.sgt_klassegroep_promotieidField;
			}
			set
			{
				this.sgt_klassegroep_promotieidField = value;
				base.RaisePropertyChanged("sgt_klassegroep_promotieid");
			}
		}
		[XmlElement(Order = 139)]
		public Lookup sgt_klasseid
		{
			get
			{
				return this.sgt_klasseidField;
			}
			set
			{
				this.sgt_klasseidField = value;
				base.RaisePropertyChanged("sgt_klasseid");
			}
		}
		[XmlElement(Order = 140)]
		public CrmNumber sgt_maximum_aantal_afdelingen
		{
			get
			{
				return this.sgt_maximum_aantal_afdelingenField;
			}
			set
			{
				this.sgt_maximum_aantal_afdelingenField = value;
				base.RaisePropertyChanged("sgt_maximum_aantal_afdelingen");
			}
		}
		[XmlElement(Order = 141)]
		public CrmNumber sgt_maximum_reisafstand
		{
			get
			{
				return this.sgt_maximum_reisafstandField;
			}
			set
			{
				this.sgt_maximum_reisafstandField = value;
				base.RaisePropertyChanged("sgt_maximum_reisafstand");
			}
		}
		[XmlElement(Order = 142)]
		public CrmNumber sgt_maximum_reistijd
		{
			get
			{
				return this.sgt_maximum_reistijdField;
			}
			set
			{
				this.sgt_maximum_reistijdField = value;
				base.RaisePropertyChanged("sgt_maximum_reistijd");
			}
		}
		[XmlElement(Order = 143)]
		public string sgt_nummer
		{
			get
			{
				return this.sgt_nummerField;
			}
			set
			{
				this.sgt_nummerField = value;
				base.RaisePropertyChanged("sgt_nummer");
			}
		}
		[XmlElement(Order = 144)]
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
				base.RaisePropertyChanged("sgt_piramideid");
			}
		}
		[XmlElement(Order = 145)]
		public Picklist sgt_ploeggemiddelde_bepaling
		{
			get
			{
				return this.sgt_ploeggemiddelde_bepalingField;
			}
			set
			{
				this.sgt_ploeggemiddelde_bepalingField = value;
				base.RaisePropertyChanged("sgt_ploeggemiddelde_bepaling");
			}
		}
		[XmlElement(Order = 146)]
		public CrmDecimal sgt_ploeggemiddelde_tot_en_met_decimal
		{
			get
			{
				return this.sgt_ploeggemiddelde_tot_en_met_decimalField;
			}
			set
			{
				this.sgt_ploeggemiddelde_tot_en_met_decimalField = value;
				base.RaisePropertyChanged("sgt_ploeggemiddelde_tot_en_met_decimal");
			}
		}
		[XmlElement(Order = 147)]
		public CrmDecimal sgt_ploeggemiddelde_vanaf_decimal
		{
			get
			{
				return this.sgt_ploeggemiddelde_vanaf_decimalField;
			}
			set
			{
				this.sgt_ploeggemiddelde_vanaf_decimalField = value;
				base.RaisePropertyChanged("sgt_ploeggemiddelde_vanaf_decimal");
			}
		}
		[XmlElement(Order = 148)]
		public CrmBoolean sgt_promotie_degradatie_meenemen_in_indeling
		{
			get
			{
				return this.sgt_promotie_degradatie_meenemen_in_indelingField;
			}
			set
			{
				this.sgt_promotie_degradatie_meenemen_in_indelingField = value;
				base.RaisePropertyChanged("sgt_promotie_degradatie_meenemen_in_indeling");
			}
		}
		[XmlElement(Order = 149)]
		public Lookup sgt_reeks_speeldatumsid
		{
			get
			{
				return this.sgt_reeks_speeldatumsidField;
			}
			set
			{
				this.sgt_reeks_speeldatumsidField = value;
				base.RaisePropertyChanged("sgt_reeks_speeldatumsid");
			}
		}
		[XmlElement(Order = 150)]
		public CrmBoolean sgt_vrije_inschrijving
		{
			get
			{
				return this.sgt_vrije_inschrijvingField;
			}
			set
			{
				this.sgt_vrije_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_vrije_inschrijving");
			}
		}
		[XmlElement(Order = 151)]
		public Sgt_com_klassegroepStateInfo statecode
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
		[XmlElement(Order = 152)]
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
		[XmlElement(Order = 153)]
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
		[XmlElement(Order = 154)]
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
		[XmlElement(Order = 155)]
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
