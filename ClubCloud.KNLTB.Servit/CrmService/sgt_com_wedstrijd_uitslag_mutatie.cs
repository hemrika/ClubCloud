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
	public class sgt_com_wedstrijd_uitslag_mutatie : BusinessEntity
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

		private Lookup sgt_afdelingidField;

		private CrmDateTime sgt_begin_datumField;

		private CrmBoolean sgt_boete_intrekken_thuisField;

		private CrmBoolean sgt_boete_intrekken_uitField;

		private Lookup sgt_boete_thuis_nieuw_idField;

		private Lookup sgt_boete_uit_nieuw_idField;

		private CrmMoney sgt_boetebedrag_thuis_huidigField;

		private CrmMoney sgt_boetebedrag_thuis_huidig_baseField;

		private CrmMoney sgt_boetebedrag_thuis_nieuwField;

		private CrmMoney sgt_boetebedrag_thuis_nieuw_baseField;

		private CrmMoney sgt_boetebedrag_uit_huidigField;

		private CrmMoney sgt_boetebedrag_uit_huidig_baseField;

		private CrmMoney sgt_boetebedrag_uit_nieuwField;

		private CrmMoney sgt_boetebedrag_uit_nieuw_baseField;

		private Lookup sgt_bondsorganisatieidField;

		private string sgt_com_naamField;

		private Key sgt_com_wedstrijd_uitslag_mutatieidField;

		private Lookup sgt_competitieidField;

		private Lookup sgt_competitietypeidField;

		private CrmDateTime sgt_eind_datumField;

		private Lookup sgt_huidge_boete_thuis_idField;

		private Lookup sgt_huidige_boete_uit_idField;

		private CrmDateTime sgt_inhaaldatumField;

		private CrmDateTime sgt_inhaaldatum_nieuwField;

		private Lookup sgt_klassegroepidField;

		private string sgt_nummerField;

		private Lookup sgt_piramideidField;

		private Lookup sgt_ploeg_thuisidField;

		private Lookup sgt_ploeg_uitidField;

		private Lookup sgt_reden_niet_gespeeld_nieuwidField;

		private Lookup sgt_reden_niet_gespeeldidField;

		private Picklist sgt_statusField;

		private Picklist sgt_status_nieuwField;

		private CrmNumber sgt_strafpunten_thuisField;

		private CrmNumber sgt_strafpunten_thuis_nieuwField;

		private CrmNumber sgt_strafpunten_uitField;

		private CrmNumber sgt_strafpunten_uit_nieuwField;

		private Picklist sgt_uitslagField;

		private Picklist sgt_uitslag_nieuwField;

		private CrmNumber sgt_uitslag_thuisField;

		private CrmNumber sgt_uitslag_thuis_nieuwField;

		private CrmNumber sgt_uitslag_uitField;

		private CrmNumber sgt_uitslag_uit_nieuwField;

		private Lookup sgt_vereniging_thuisidField;

		private Lookup sgt_vereniging_uitidField;

		private Lookup sgt_wedstrijdidField;

		private Sgt_com_wedstrijd_uitslag_mutatieStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_begin_datum
		{
			get
			{
				return this.sgt_begin_datumField;
			}
			set
			{
				this.sgt_begin_datumField = value;
				base.RaisePropertyChanged("sgt_begin_datum");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_boete_intrekken_thuis
		{
			get
			{
				return this.sgt_boete_intrekken_thuisField;
			}
			set
			{
				this.sgt_boete_intrekken_thuisField = value;
				base.RaisePropertyChanged("sgt_boete_intrekken_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_boete_intrekken_uit
		{
			get
			{
				return this.sgt_boete_intrekken_uitField;
			}
			set
			{
				this.sgt_boete_intrekken_uitField = value;
				base.RaisePropertyChanged("sgt_boete_intrekken_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_boete_thuis_nieuw_id
		{
			get
			{
				return this.sgt_boete_thuis_nieuw_idField;
			}
			set
			{
				this.sgt_boete_thuis_nieuw_idField = value;
				base.RaisePropertyChanged("sgt_boete_thuis_nieuw_id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_boete_uit_nieuw_id
		{
			get
			{
				return this.sgt_boete_uit_nieuw_idField;
			}
			set
			{
				this.sgt_boete_uit_nieuw_idField = value;
				base.RaisePropertyChanged("sgt_boete_uit_nieuw_id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmMoney sgt_boetebedrag_thuis_huidig
		{
			get
			{
				return this.sgt_boetebedrag_thuis_huidigField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_huidigField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_thuis_huidig");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmMoney sgt_boetebedrag_thuis_huidig_base
		{
			get
			{
				return this.sgt_boetebedrag_thuis_huidig_baseField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_huidig_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_thuis_huidig_base");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmMoney sgt_boetebedrag_thuis_nieuw
		{
			get
			{
				return this.sgt_boetebedrag_thuis_nieuwField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_nieuwField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_thuis_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmMoney sgt_boetebedrag_thuis_nieuw_base
		{
			get
			{
				return this.sgt_boetebedrag_thuis_nieuw_baseField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_nieuw_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_thuis_nieuw_base");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmMoney sgt_boetebedrag_uit_huidig
		{
			get
			{
				return this.sgt_boetebedrag_uit_huidigField;
			}
			set
			{
				this.sgt_boetebedrag_uit_huidigField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_uit_huidig");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmMoney sgt_boetebedrag_uit_huidig_base
		{
			get
			{
				return this.sgt_boetebedrag_uit_huidig_baseField;
			}
			set
			{
				this.sgt_boetebedrag_uit_huidig_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_uit_huidig_base");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmMoney sgt_boetebedrag_uit_nieuw
		{
			get
			{
				return this.sgt_boetebedrag_uit_nieuwField;
			}
			set
			{
				this.sgt_boetebedrag_uit_nieuwField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_uit_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmMoney sgt_boetebedrag_uit_nieuw_base
		{
			get
			{
				return this.sgt_boetebedrag_uit_nieuw_baseField;
			}
			set
			{
				this.sgt_boetebedrag_uit_nieuw_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_uit_nieuw_base");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
		public Key sgt_com_wedstrijd_uitslag_mutatieid
		{
			get
			{
				return this.sgt_com_wedstrijd_uitslag_mutatieidField;
			}
			set
			{
				this.sgt_com_wedstrijd_uitslag_mutatieidField = value;
				base.RaisePropertyChanged("sgt_com_wedstrijd_uitslag_mutatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
		public CrmDateTime sgt_eind_datum
		{
			get
			{
				return this.sgt_eind_datumField;
			}
			set
			{
				this.sgt_eind_datumField = value;
				base.RaisePropertyChanged("sgt_eind_datum");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Lookup sgt_huidge_boete_thuis_id
		{
			get
			{
				return this.sgt_huidge_boete_thuis_idField;
			}
			set
			{
				this.sgt_huidge_boete_thuis_idField = value;
				base.RaisePropertyChanged("sgt_huidge_boete_thuis_id");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_huidige_boete_uit_id
		{
			get
			{
				return this.sgt_huidige_boete_uit_idField;
			}
			set
			{
				this.sgt_huidige_boete_uit_idField = value;
				base.RaisePropertyChanged("sgt_huidige_boete_uit_id");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
		public CrmDateTime sgt_inhaaldatum_nieuw
		{
			get
			{
				return this.sgt_inhaaldatum_nieuwField;
			}
			set
			{
				this.sgt_inhaaldatum_nieuwField = value;
				base.RaisePropertyChanged("sgt_inhaaldatum_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
		public Lookup sgt_reden_niet_gespeeld_nieuwid
		{
			get
			{
				return this.sgt_reden_niet_gespeeld_nieuwidField;
			}
			set
			{
				this.sgt_reden_niet_gespeeld_nieuwidField = value;
				base.RaisePropertyChanged("sgt_reden_niet_gespeeld_nieuwid");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
		public Picklist sgt_status_nieuw
		{
			get
			{
				return this.sgt_status_nieuwField;
			}
			set
			{
				this.sgt_status_nieuwField = value;
				base.RaisePropertyChanged("sgt_status_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
		public CrmNumber sgt_strafpunten_thuis_nieuw
		{
			get
			{
				return this.sgt_strafpunten_thuis_nieuwField;
			}
			set
			{
				this.sgt_strafpunten_thuis_nieuwField = value;
				base.RaisePropertyChanged("sgt_strafpunten_thuis_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
		public CrmNumber sgt_strafpunten_uit_nieuw
		{
			get
			{
				return this.sgt_strafpunten_uit_nieuwField;
			}
			set
			{
				this.sgt_strafpunten_uit_nieuwField = value;
				base.RaisePropertyChanged("sgt_strafpunten_uit_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
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

		[XmlElement] //[XmlElement(Order=47)]
		public Picklist sgt_uitslag_nieuw
		{
			get
			{
				return this.sgt_uitslag_nieuwField;
			}
			set
			{
				this.sgt_uitslag_nieuwField = value;
				base.RaisePropertyChanged("sgt_uitslag_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public CrmNumber sgt_uitslag_thuis
		{
			get
			{
				return this.sgt_uitslag_thuisField;
			}
			set
			{
				this.sgt_uitslag_thuisField = value;
				base.RaisePropertyChanged("sgt_uitslag_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public CrmNumber sgt_uitslag_thuis_nieuw
		{
			get
			{
				return this.sgt_uitslag_thuis_nieuwField;
			}
			set
			{
				this.sgt_uitslag_thuis_nieuwField = value;
				base.RaisePropertyChanged("sgt_uitslag_thuis_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public CrmNumber sgt_uitslag_uit
		{
			get
			{
				return this.sgt_uitslag_uitField;
			}
			set
			{
				this.sgt_uitslag_uitField = value;
				base.RaisePropertyChanged("sgt_uitslag_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public CrmNumber sgt_uitslag_uit_nieuw
		{
			get
			{
				return this.sgt_uitslag_uit_nieuwField;
			}
			set
			{
				this.sgt_uitslag_uit_nieuwField = value;
				base.RaisePropertyChanged("sgt_uitslag_uit_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
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

		[XmlElement] //[XmlElement(Order=53)]
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

		[XmlElement] //[XmlElement(Order=54)]
		public Lookup sgt_wedstrijdid
		{
			get
			{
				return this.sgt_wedstrijdidField;
			}
			set
			{
				this.sgt_wedstrijdidField = value;
				base.RaisePropertyChanged("sgt_wedstrijdid");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public Sgt_com_wedstrijd_uitslag_mutatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=56)]
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

		[XmlElement] //[XmlElement(Order=57)]
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

		[XmlElement] //[XmlElement(Order=58)]
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

		[XmlElement] //[XmlElement(Order=59)]
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

		public sgt_com_wedstrijd_uitslag_mutatie()
		{
		}
	}
}