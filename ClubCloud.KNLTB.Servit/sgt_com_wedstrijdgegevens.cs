using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_wedstrijdgegevens : BusinessEntity
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
		private CrmDateTime sgt_aanvangstijd_datumtijdField;
		private string sgt_aanvoerderField;
		private string sgt_aanvullende_informatieField;
		private Lookup sgt_accommodatieidField;
		private Lookup sgt_afdelingidField;
		private Lookup sgt_baansoortidField;
		private CrmDateTime sgt_begindatumField;
		private CrmBoolean sgt_beslissingswedstrijdField;
		private Lookup sgt_boete_thuisidField;
		private Lookup sgt_boete_uitidField;
		private CrmMoney sgt_boetebedrag_thuisField;
		private CrmMoney sgt_boetebedrag_thuis_baseField;
		private CrmMoney sgt_boetebedrag_uitField;
		private CrmMoney sgt_boetebedrag_uit_baseField;
		private Lookup sgt_bondsorganisatieidField;
		private string sgt_com_naamField;
		private Key sgt_com_wedstrijdgegevensidField;
		private Lookup sgt_competitieidField;
		private Lookup sgt_competitietypeidField;
		private CrmDateTime sgt_datum_ontvangenField;
		private CrmDateTime sgt_datum_uitspraakField;
		private CrmDateTime sgt_einddatumField;
		private CrmNumber sgt_einduitslag_thuisField;
		private CrmNumber sgt_einduitslag_uitField;
		private Lookup sgt_indienende_verenigingidField;
		private CrmDateTime sgt_inhaaldatumField;
		private Lookup sgt_klassegroepidField;
		private CrmBoolean sgt_niet_meetellen_in_standField;
		private string sgt_nummerField;
		private Lookup sgt_organiserende_verenigingidField;
		private CrmBoolean sgt_partij_uitslagen_verwerktField;
		private Lookup sgt_piramideidField;
		private Lookup sgt_ploeg_thuisidField;
		private Lookup sgt_ploeg_uitidField;
		private CrmBoolean sgt_protestgeld_betaaldField;
		private CrmBoolean sgt_protestgeld_gerestitueerdField;
		private Lookup sgt_reden_niet_gespeeldidField;
		private string sgt_reden_protestField;
		private CrmDateTime sgt_speeldatumField;
		private Picklist sgt_status_protestField;
		private CrmNumber sgt_strafpunten_thuisField;
		private CrmNumber sgt_strafpunten_uitField;
		private CrmBoolean sgt_teamautorisaties_uitschakelenField;
		private string sgt_telefoonField;
		private CrmDateTime sgt_tijd_aanwezig_datumtijdField;
		private string sgt_toelichting_uitspraakField;
		private Picklist sgt_uitslagField;
		private Lookup sgt_vereniging_thuisidField;
		private Lookup sgt_vereniging_uitidField;
		private Picklist sgt_wedstrijdstatusField;
		private Sgt_com_wedstrijdgegevensStateInfo statecodeField;
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
		public CrmDateTime sgt_aanvangstijd_datumtijd
		{
			get
			{
				return this.sgt_aanvangstijd_datumtijdField;
			}
			set
			{
				this.sgt_aanvangstijd_datumtijdField = value;
				base.RaisePropertyChanged("sgt_aanvangstijd_datumtijd");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_aanvoerder
		{
			get
			{
				return this.sgt_aanvoerderField;
			}
			set
			{
				this.sgt_aanvoerderField = value;
				base.RaisePropertyChanged("sgt_aanvoerder");
			}
		}
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public Lookup sgt_afdelingid
		{
			get
			{
				return this.sgt_afdelingidField;
			}
			set
			{
				this.sgt_afdelingidField = value;
				base.RaisePropertyChanged("sgt_afdelingid");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_baansoortid
		{
			get
			{
				return this.sgt_baansoortidField;
			}
			set
			{
				this.sgt_baansoortidField = value;
				base.RaisePropertyChanged("sgt_baansoortid");
			}
		}
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public CrmBoolean sgt_beslissingswedstrijd
		{
			get
			{
				return this.sgt_beslissingswedstrijdField;
			}
			set
			{
				this.sgt_beslissingswedstrijdField = value;
				base.RaisePropertyChanged("sgt_beslissingswedstrijd");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_boete_thuisid
		{
			get
			{
				return this.sgt_boete_thuisidField;
			}
			set
			{
				this.sgt_boete_thuisidField = value;
				base.RaisePropertyChanged("sgt_boete_thuisid");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_boete_uitid
		{
			get
			{
				return this.sgt_boete_uitidField;
			}
			set
			{
				this.sgt_boete_uitidField = value;
				base.RaisePropertyChanged("sgt_boete_uitid");
			}
		}
		[XmlElement(Order = 19)]
		public CrmMoney sgt_boetebedrag_thuis
		{
			get
			{
				return this.sgt_boetebedrag_thuisField;
			}
			set
			{
				this.sgt_boetebedrag_thuisField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_thuis");
			}
		}
		[XmlElement(Order = 20)]
		public CrmMoney sgt_boetebedrag_thuis_base
		{
			get
			{
				return this.sgt_boetebedrag_thuis_baseField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_thuis_base");
			}
		}
		[XmlElement(Order = 21)]
		public CrmMoney sgt_boetebedrag_uit
		{
			get
			{
				return this.sgt_boetebedrag_uitField;
			}
			set
			{
				this.sgt_boetebedrag_uitField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_uit");
			}
		}
		[XmlElement(Order = 22)]
		public CrmMoney sgt_boetebedrag_uit_base
		{
			get
			{
				return this.sgt_boetebedrag_uit_baseField;
			}
			set
			{
				this.sgt_boetebedrag_uit_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_uit_base");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatieid");
			}
		}
		[XmlElement(Order = 24)]
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
				base.RaisePropertyChanged("sgt_com_naam");
			}
		}
		[XmlElement(Order = 25)]
		public Key sgt_com_wedstrijdgegevensid
		{
			get
			{
				return this.sgt_com_wedstrijdgegevensidField;
			}
			set
			{
				this.sgt_com_wedstrijdgegevensidField = value;
				base.RaisePropertyChanged("sgt_com_wedstrijdgegevensid");
			}
		}
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
		public Lookup sgt_competitietypeid
		{
			get
			{
				return this.sgt_competitietypeidField;
			}
			set
			{
				this.sgt_competitietypeidField = value;
				base.RaisePropertyChanged("sgt_competitietypeid");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDateTime sgt_datum_ontvangen
		{
			get
			{
				return this.sgt_datum_ontvangenField;
			}
			set
			{
				this.sgt_datum_ontvangenField = value;
				base.RaisePropertyChanged("sgt_datum_ontvangen");
			}
		}
		[XmlElement(Order = 29)]
		public CrmDateTime sgt_datum_uitspraak
		{
			get
			{
				return this.sgt_datum_uitspraakField;
			}
			set
			{
				this.sgt_datum_uitspraakField = value;
				base.RaisePropertyChanged("sgt_datum_uitspraak");
			}
		}
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
		public CrmNumber sgt_einduitslag_thuis
		{
			get
			{
				return this.sgt_einduitslag_thuisField;
			}
			set
			{
				this.sgt_einduitslag_thuisField = value;
				base.RaisePropertyChanged("sgt_einduitslag_thuis");
			}
		}
		[XmlElement(Order = 32)]
		public CrmNumber sgt_einduitslag_uit
		{
			get
			{
				return this.sgt_einduitslag_uitField;
			}
			set
			{
				this.sgt_einduitslag_uitField = value;
				base.RaisePropertyChanged("sgt_einduitslag_uit");
			}
		}
		[XmlElement(Order = 33)]
		public Lookup sgt_indienende_verenigingid
		{
			get
			{
				return this.sgt_indienende_verenigingidField;
			}
			set
			{
				this.sgt_indienende_verenigingidField = value;
				base.RaisePropertyChanged("sgt_indienende_verenigingid");
			}
		}
		[XmlElement(Order = 34)]
		public CrmDateTime sgt_inhaaldatum
		{
			get
			{
				return this.sgt_inhaaldatumField;
			}
			set
			{
				this.sgt_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_inhaaldatum");
			}
		}
		[XmlElement(Order = 35)]
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
				base.RaisePropertyChanged("sgt_klassegroepid");
			}
		}
		[XmlElement(Order = 36)]
		public CrmBoolean sgt_niet_meetellen_in_stand
		{
			get
			{
				return this.sgt_niet_meetellen_in_standField;
			}
			set
			{
				this.sgt_niet_meetellen_in_standField = value;
				base.RaisePropertyChanged("sgt_niet_meetellen_in_stand");
			}
		}
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
		public Lookup sgt_organiserende_verenigingid
		{
			get
			{
				return this.sgt_organiserende_verenigingidField;
			}
			set
			{
				this.sgt_organiserende_verenigingidField = value;
				base.RaisePropertyChanged("sgt_organiserende_verenigingid");
			}
		}
		[XmlElement(Order = 39)]
		public CrmBoolean sgt_partij_uitslagen_verwerkt
		{
			get
			{
				return this.sgt_partij_uitslagen_verwerktField;
			}
			set
			{
				this.sgt_partij_uitslagen_verwerktField = value;
				base.RaisePropertyChanged("sgt_partij_uitslagen_verwerkt");
			}
		}
		[XmlElement(Order = 40)]
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
		[XmlElement(Order = 41)]
		public Lookup sgt_ploeg_thuisid
		{
			get
			{
				return this.sgt_ploeg_thuisidField;
			}
			set
			{
				this.sgt_ploeg_thuisidField = value;
				base.RaisePropertyChanged("sgt_ploeg_thuisid");
			}
		}
		[XmlElement(Order = 42)]
		public Lookup sgt_ploeg_uitid
		{
			get
			{
				return this.sgt_ploeg_uitidField;
			}
			set
			{
				this.sgt_ploeg_uitidField = value;
				base.RaisePropertyChanged("sgt_ploeg_uitid");
			}
		}
		[XmlElement(Order = 43)]
		public CrmBoolean sgt_protestgeld_betaald
		{
			get
			{
				return this.sgt_protestgeld_betaaldField;
			}
			set
			{
				this.sgt_protestgeld_betaaldField = value;
				base.RaisePropertyChanged("sgt_protestgeld_betaald");
			}
		}
		[XmlElement(Order = 44)]
		public CrmBoolean sgt_protestgeld_gerestitueerd
		{
			get
			{
				return this.sgt_protestgeld_gerestitueerdField;
			}
			set
			{
				this.sgt_protestgeld_gerestitueerdField = value;
				base.RaisePropertyChanged("sgt_protestgeld_gerestitueerd");
			}
		}
		[XmlElement(Order = 45)]
		public Lookup sgt_reden_niet_gespeeldid
		{
			get
			{
				return this.sgt_reden_niet_gespeeldidField;
			}
			set
			{
				this.sgt_reden_niet_gespeeldidField = value;
				base.RaisePropertyChanged("sgt_reden_niet_gespeeldid");
			}
		}
		[XmlElement(Order = 46)]
		public string sgt_reden_protest
		{
			get
			{
				return this.sgt_reden_protestField;
			}
			set
			{
				this.sgt_reden_protestField = value;
				base.RaisePropertyChanged("sgt_reden_protest");
			}
		}
		[XmlElement(Order = 47)]
		public CrmDateTime sgt_speeldatum
		{
			get
			{
				return this.sgt_speeldatumField;
			}
			set
			{
				this.sgt_speeldatumField = value;
				base.RaisePropertyChanged("sgt_speeldatum");
			}
		}
		[XmlElement(Order = 48)]
		public Picklist sgt_status_protest
		{
			get
			{
				return this.sgt_status_protestField;
			}
			set
			{
				this.sgt_status_protestField = value;
				base.RaisePropertyChanged("sgt_status_protest");
			}
		}
		[XmlElement(Order = 49)]
		public CrmNumber sgt_strafpunten_thuis
		{
			get
			{
				return this.sgt_strafpunten_thuisField;
			}
			set
			{
				this.sgt_strafpunten_thuisField = value;
				base.RaisePropertyChanged("sgt_strafpunten_thuis");
			}
		}
		[XmlElement(Order = 50)]
		public CrmNumber sgt_strafpunten_uit
		{
			get
			{
				return this.sgt_strafpunten_uitField;
			}
			set
			{
				this.sgt_strafpunten_uitField = value;
				base.RaisePropertyChanged("sgt_strafpunten_uit");
			}
		}
		[XmlElement(Order = 51)]
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
		[XmlElement(Order = 52)]
		public string sgt_telefoon
		{
			get
			{
				return this.sgt_telefoonField;
			}
			set
			{
				this.sgt_telefoonField = value;
				base.RaisePropertyChanged("sgt_telefoon");
			}
		}
		[XmlElement(Order = 53)]
		public CrmDateTime sgt_tijd_aanwezig_datumtijd
		{
			get
			{
				return this.sgt_tijd_aanwezig_datumtijdField;
			}
			set
			{
				this.sgt_tijd_aanwezig_datumtijdField = value;
				base.RaisePropertyChanged("sgt_tijd_aanwezig_datumtijd");
			}
		}
		[XmlElement(Order = 54)]
		public string sgt_toelichting_uitspraak
		{
			get
			{
				return this.sgt_toelichting_uitspraakField;
			}
			set
			{
				this.sgt_toelichting_uitspraakField = value;
				base.RaisePropertyChanged("sgt_toelichting_uitspraak");
			}
		}
		[XmlElement(Order = 55)]
		public Picklist sgt_uitslag
		{
			get
			{
				return this.sgt_uitslagField;
			}
			set
			{
				this.sgt_uitslagField = value;
				base.RaisePropertyChanged("sgt_uitslag");
			}
		}
		[XmlElement(Order = 56)]
		public Lookup sgt_vereniging_thuisid
		{
			get
			{
				return this.sgt_vereniging_thuisidField;
			}
			set
			{
				this.sgt_vereniging_thuisidField = value;
				base.RaisePropertyChanged("sgt_vereniging_thuisid");
			}
		}
		[XmlElement(Order = 57)]
		public Lookup sgt_vereniging_uitid
		{
			get
			{
				return this.sgt_vereniging_uitidField;
			}
			set
			{
				this.sgt_vereniging_uitidField = value;
				base.RaisePropertyChanged("sgt_vereniging_uitid");
			}
		}
		[XmlElement(Order = 58)]
		public Picklist sgt_wedstrijdstatus
		{
			get
			{
				return this.sgt_wedstrijdstatusField;
			}
			set
			{
				this.sgt_wedstrijdstatusField = value;
				base.RaisePropertyChanged("sgt_wedstrijdstatus");
			}
		}
		[XmlElement(Order = 59)]
		public Sgt_com_wedstrijdgegevensStateInfo statecode
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
		[XmlElement(Order = 60)]
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
		[XmlElement(Order = 61)]
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
		[XmlElement(Order = 62)]
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
		[XmlElement(Order = 63)]
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
