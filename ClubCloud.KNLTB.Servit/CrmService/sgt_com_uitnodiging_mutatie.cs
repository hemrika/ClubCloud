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
	public class sgt_com_uitnodiging_mutatie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDateTime sgt_aanvangstijd_datumtijdField;

		private CrmDateTime sgt_aanvangstijd_datumtijd_nieuwField;

		private Lookup sgt_aanvoerder_nieuw_idField;

		private Lookup sgt_aanvoerder_oud_idField;

		private string sgt_aanvullende_informatieField;

		private string sgt_aanvullende_informatie_nieuwField;

		private Lookup sgt_accomodatieidField;

		private Lookup sgt_afdelingidField;

		private Lookup sgt_baansoort_nieuwidField;

		private Lookup sgt_baansoortidField;

		private Lookup sgt_bondsorganisatieidField;

		private string sgt_com_naamField;

		private Key sgt_com_uitnodiging_mutatieidField;

		private Lookup sgt_competitieidField;

		private Lookup sgt_competitietypeidField;

		private Lookup sgt_klassegroepidField;

		private string sgt_naam_aanvoerderField;

		private string sgt_naam_aanvoerder_nieuwField;

		private string sgt_nummerField;

		private Lookup sgt_organiserende_verenigingidField;

		private CrmBoolean sgt_overnemen_andere_uitnodigingenField;

		private Lookup sgt_piramideidField;

		private Lookup sgt_ploeg_thuisidField;

		private Lookup sgt_ploeguit_idField;

		private string sgt_telefoonField;

		private string sgt_telefoon_nieuwField;

		private CrmDateTime sgt_tijd_aanwezig_datumtijdField;

		private CrmDateTime sgt_tijd_aanwezig_datumtijd_nieuwField;

		private Lookup sgt_vereniging_thuisidField;

		private Lookup sgt_vereniging_uitidField;

		private Lookup sgt_wedstrijdidField;

		private Sgt_com_uitnodiging_mutatieStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDateTime sgt_aanvangstijd_datumtijd_nieuw
		{
			get
			{
				return this.sgt_aanvangstijd_datumtijd_nieuwField;
			}
			set
			{
				this.sgt_aanvangstijd_datumtijd_nieuwField = value;
				base.RaisePropertyChanged("sgt_aanvangstijd_datumtijd_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_aanvoerder_nieuw_id
		{
			get
			{
				return this.sgt_aanvoerder_nieuw_idField;
			}
			set
			{
				this.sgt_aanvoerder_nieuw_idField = value;
				base.RaisePropertyChanged("sgt_aanvoerder_nieuw_id");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_aanvoerder_oud_id
		{
			get
			{
				return this.sgt_aanvoerder_oud_idField;
			}
			set
			{
				this.sgt_aanvoerder_oud_idField = value;
				base.RaisePropertyChanged("sgt_aanvoerder_oud_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_aanvullende_informatie_nieuw
		{
			get
			{
				return this.sgt_aanvullende_informatie_nieuwField;
			}
			set
			{
				this.sgt_aanvullende_informatie_nieuwField = value;
				base.RaisePropertyChanged("sgt_aanvullende_informatie_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_accomodatieid
		{
			get
			{
				return this.sgt_accomodatieidField;
			}
			set
			{
				this.sgt_accomodatieidField = value;
				base.RaisePropertyChanged("sgt_accomodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_baansoort_nieuwid
		{
			get
			{
				return this.sgt_baansoort_nieuwidField;
			}
			set
			{
				this.sgt_baansoort_nieuwidField = value;
				base.RaisePropertyChanged("sgt_baansoort_nieuwid");
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public Key sgt_com_uitnodiging_mutatieid
		{
			get
			{
				return this.sgt_com_uitnodiging_mutatieidField;
			}
			set
			{
				this.sgt_com_uitnodiging_mutatieidField = value;
				base.RaisePropertyChanged("sgt_com_uitnodiging_mutatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_naam_aanvoerder
		{
			get
			{
				return this.sgt_naam_aanvoerderField;
			}
			set
			{
				this.sgt_naam_aanvoerderField = value;
				base.RaisePropertyChanged("sgt_naam_aanvoerder");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_naam_aanvoerder_nieuw
		{
			get
			{
				return this.sgt_naam_aanvoerder_nieuwField;
			}
			set
			{
				this.sgt_naam_aanvoerder_nieuwField = value;
				base.RaisePropertyChanged("sgt_naam_aanvoerder_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
		public CrmBoolean sgt_overnemen_andere_uitnodigingen
		{
			get
			{
				return this.sgt_overnemen_andere_uitnodigingenField;
			}
			set
			{
				this.sgt_overnemen_andere_uitnodigingenField = value;
				base.RaisePropertyChanged("sgt_overnemen_andere_uitnodigingen");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
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
		public Lookup sgt_ploeguit_id
		{
			get
			{
				return this.sgt_ploeguit_idField;
			}
			set
			{
				this.sgt_ploeguit_idField = value;
				base.RaisePropertyChanged("sgt_ploeguit_id");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_telefoon_nieuw
		{
			get
			{
				return this.sgt_telefoon_nieuwField;
			}
			set
			{
				this.sgt_telefoon_nieuwField = value;
				base.RaisePropertyChanged("sgt_telefoon_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
		public CrmDateTime sgt_tijd_aanwezig_datumtijd_nieuw
		{
			get
			{
				return this.sgt_tijd_aanwezig_datumtijd_nieuwField;
			}
			set
			{
				this.sgt_tijd_aanwezig_datumtijd_nieuwField = value;
				base.RaisePropertyChanged("sgt_tijd_aanwezig_datumtijd_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
		public Sgt_com_uitnodiging_mutatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
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

		[XmlElement] //[XmlElement(Order=42)]
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

		public sgt_com_uitnodiging_mutatie()
		{
		}
	}
}