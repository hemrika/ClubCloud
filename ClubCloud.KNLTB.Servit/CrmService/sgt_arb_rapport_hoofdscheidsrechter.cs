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
	public class sgt_arb_rapport_hoofdscheidsrechter : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmNumber sgt_aantal_malen_sps_toegepastField;

		private CrmNumber sgt_aantal_sps_formulieren_bijgevoegdField;

		private CrmNumber sgt_aantal_sr_beoordelingsform_bijgevoegdField;

		private CrmNumber sgt_aantal_sr_declaratieform_bijgevoegdField;

		private CrmDateTime sgt_aanvangstijd_datumtijdField;

		private Lookup sgt_accommodatieidField;

		private Lookup sgt_afdelingidField;

		private string sgt_arb_nameField;

		private Key sgt_arb_rapport_hoofdscheidsrechteridField;

		private Lookup sgt_baansoortidField;

		private Lookup sgt_competitieidField;

		private CrmDateTime sgt_datum_tmField;

		private CrmDateTime sgt_datum_vanafField;

		private string sgt_eindtijdField;

		private Lookup sgt_hoofdscheidsrechteridField;

		private Lookup sgt_klassengroepidField;

		private Picklist sgt_locatieField;

		private string sgt_merk_ballenField;

		private Picklist sgt_nieuwe_ballenField;

		private string sgt_opmerkingenField;

		private Lookup sgt_piramideidField;

		private string sgt_plaatsField;

		private Lookup sgt_ploeg_thuisidField;

		private Lookup sgt_ploeg_uitidField;

		private Lookup sgt_ploegthuisidField;

		private Lookup sgt_ploeguitidField;

		private CrmDateTime sgt_speeldatumField;

		private string sgt_toelichtingField;

		private Lookup sgt_toernooi_aanvraag_verwerkingidField;

		private Lookup sgt_toernooiidField;

		private Lookup sgt_verenigingthuisidField;

		private Lookup sgt_vereniginguitidField;

		private Lookup sgt_wedstrijdidField;

		private Sgt_arb_rapport_hoofdscheidsrechterStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber sgt_aantal_malen_sps_toegepast
		{
			get
			{
				return this.sgt_aantal_malen_sps_toegepastField;
			}
			set
			{
				this.sgt_aantal_malen_sps_toegepastField = value;
				base.RaisePropertyChanged("sgt_aantal_malen_sps_toegepast");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_sps_formulieren_bijgevoegd
		{
			get
			{
				return this.sgt_aantal_sps_formulieren_bijgevoegdField;
			}
			set
			{
				this.sgt_aantal_sps_formulieren_bijgevoegdField = value;
				base.RaisePropertyChanged("sgt_aantal_sps_formulieren_bijgevoegd");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_aantal_sr_beoordelingsform_bijgevoegd
		{
			get
			{
				return this.sgt_aantal_sr_beoordelingsform_bijgevoegdField;
			}
			set
			{
				this.sgt_aantal_sr_beoordelingsform_bijgevoegdField = value;
				base.RaisePropertyChanged("sgt_aantal_sr_beoordelingsform_bijgevoegd");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_aantal_sr_declaratieform_bijgevoegd
		{
			get
			{
				return this.sgt_aantal_sr_declaratieform_bijgevoegdField;
			}
			set
			{
				this.sgt_aantal_sr_declaratieform_bijgevoegdField = value;
				base.RaisePropertyChanged("sgt_aantal_sr_declaratieform_bijgevoegd");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_arb_name
		{
			get
			{
				return this.sgt_arb_nameField;
			}
			set
			{
				this.sgt_arb_nameField = value;
				base.RaisePropertyChanged("sgt_arb_name");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Key sgt_arb_rapport_hoofdscheidsrechterid
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechteridField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechteridField = value;
				base.RaisePropertyChanged("sgt_arb_rapport_hoofdscheidsrechterid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_eindtijd
		{
			get
			{
				return this.sgt_eindtijdField;
			}
			set
			{
				this.sgt_eindtijdField = value;
				base.RaisePropertyChanged("sgt_eindtijd");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_klassengroepid
		{
			get
			{
				return this.sgt_klassengroepidField;
			}
			set
			{
				this.sgt_klassengroepidField = value;
				base.RaisePropertyChanged("sgt_klassengroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Picklist sgt_locatie
		{
			get
			{
				return this.sgt_locatieField;
			}
			set
			{
				this.sgt_locatieField = value;
				base.RaisePropertyChanged("sgt_locatie");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_merk_ballen
		{
			get
			{
				return this.sgt_merk_ballenField;
			}
			set
			{
				this.sgt_merk_ballenField = value;
				base.RaisePropertyChanged("sgt_merk_ballen");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Picklist sgt_nieuwe_ballen
		{
			get
			{
				return this.sgt_nieuwe_ballenField;
			}
			set
			{
				this.sgt_nieuwe_ballenField = value;
				base.RaisePropertyChanged("sgt_nieuwe_ballen");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_opmerkingen
		{
			get
			{
				return this.sgt_opmerkingenField;
			}
			set
			{
				this.sgt_opmerkingenField = value;
				base.RaisePropertyChanged("sgt_opmerkingen");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
		public Lookup sgt_ploegthuisid
		{
			get
			{
				return this.sgt_ploegthuisidField;
			}
			set
			{
				this.sgt_ploegthuisidField = value;
				base.RaisePropertyChanged("sgt_ploegthuisid");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Lookup sgt_ploeguitid
		{
			get
			{
				return this.sgt_ploeguitidField;
			}
			set
			{
				this.sgt_ploeguitidField = value;
				base.RaisePropertyChanged("sgt_ploeguitid");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
		public Lookup sgt_verenigingthuisid
		{
			get
			{
				return this.sgt_verenigingthuisidField;
			}
			set
			{
				this.sgt_verenigingthuisidField = value;
				base.RaisePropertyChanged("sgt_verenigingthuisid");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public Lookup sgt_vereniginguitid
		{
			get
			{
				return this.sgt_vereniginguitidField;
			}
			set
			{
				this.sgt_vereniginguitidField = value;
				base.RaisePropertyChanged("sgt_vereniginguitid");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
		public Sgt_arb_rapport_hoofdscheidsrechterStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
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

		[XmlElement] //[XmlElement(Order=44)]
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

		public sgt_arb_rapport_hoofdscheidsrechter()
		{
		}
	}
}