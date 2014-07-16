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
	public class sgt_com_protest_mutatie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_afdelingidField;

		private CrmDateTime sgt_begin_datumField;

		private Lookup sgt_bondsorganisatieidField;

		private string sgt_com_naamField;

		private Key sgt_com_protest_mutatieidField;

		private Lookup sgt_competitieidField;

		private Lookup sgt_competitietypeidField;

		private CrmDateTime sgt_datum_ontvangenField;

		private CrmDateTime sgt_datum_ontvangen_nieuwField;

		private CrmDateTime sgt_datum_uitspraakField;

		private CrmDateTime sgt_datum_uitspraak_nieuwField;

		private CrmDateTime sgt_eind_datumField;

		private Lookup sgt_indienende_verengingidField;

		private Lookup sgt_indienende_vereniging_nieuwidField;

		private Lookup sgt_klassegroepidField;

		private Lookup sgt_piramideidField;

		private Lookup sgt_ploeg_thuisidField;

		private Lookup sgt_ploeg_uitidField;

		private CrmBoolean sgt_protestgeld_betaaldField;

		private CrmBoolean sgt_protestgeld_betaald_nieuwField;

		private CrmBoolean sgt_protestgeld_restituerenField;

		private CrmBoolean sgt_protestgeld_restitueren_nieuwField;

		private string sgt_reden_protestField;

		private string sgt_reden_protest_nieuwField;

		private Picklist sgt_statusField;

		private Picklist sgt_status_nieuwField;

		private string sgt_toelichting_uitspraakField;

		private string sgt_toelichting_uitspraak_nieuwField;

		private Lookup sgt_vereniging_thuisidField;

		private Lookup sgt_vereniging_uitidField;

		private Lookup sgt_wedstrijdidField;

		private Sgt_com_protest_mutatieStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public Key sgt_com_protest_mutatieid
		{
			get
			{
				return this.sgt_com_protest_mutatieidField;
			}
			set
			{
				this.sgt_com_protest_mutatieidField = value;
				base.RaisePropertyChanged("sgt_com_protest_mutatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public CrmDateTime sgt_datum_ontvangen_nieuw
		{
			get
			{
				return this.sgt_datum_ontvangen_nieuwField;
			}
			set
			{
				this.sgt_datum_ontvangen_nieuwField = value;
				base.RaisePropertyChanged("sgt_datum_ontvangen_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_datum_uitspraak_nieuw
		{
			get
			{
				return this.sgt_datum_uitspraak_nieuwField;
			}
			set
			{
				this.sgt_datum_uitspraak_nieuwField = value;
				base.RaisePropertyChanged("sgt_datum_uitspraak_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_indienende_verengingid
		{
			get
			{
				return this.sgt_indienende_verengingidField;
			}
			set
			{
				this.sgt_indienende_verengingidField = value;
				base.RaisePropertyChanged("sgt_indienende_verengingid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_indienende_vereniging_nieuwid
		{
			get
			{
				return this.sgt_indienende_vereniging_nieuwidField;
			}
			set
			{
				this.sgt_indienende_vereniging_nieuwidField = value;
				base.RaisePropertyChanged("sgt_indienende_vereniging_nieuwid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_protestgeld_betaald_nieuw
		{
			get
			{
				return this.sgt_protestgeld_betaald_nieuwField;
			}
			set
			{
				this.sgt_protestgeld_betaald_nieuwField = value;
				base.RaisePropertyChanged("sgt_protestgeld_betaald_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmBoolean sgt_protestgeld_restitueren
		{
			get
			{
				return this.sgt_protestgeld_restituerenField;
			}
			set
			{
				this.sgt_protestgeld_restituerenField = value;
				base.RaisePropertyChanged("sgt_protestgeld_restitueren");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmBoolean sgt_protestgeld_restitueren_nieuw
		{
			get
			{
				return this.sgt_protestgeld_restitueren_nieuwField;
			}
			set
			{
				this.sgt_protestgeld_restitueren_nieuwField = value;
				base.RaisePropertyChanged("sgt_protestgeld_restitueren_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_reden_protest_nieuw
		{
			get
			{
				return this.sgt_reden_protest_nieuwField;
			}
			set
			{
				this.sgt_reden_protest_nieuwField = value;
				base.RaisePropertyChanged("sgt_reden_protest_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
		public string sgt_toelichting_uitspraak_nieuw
		{
			get
			{
				return this.sgt_toelichting_uitspraak_nieuwField;
			}
			set
			{
				this.sgt_toelichting_uitspraak_nieuwField = value;
				base.RaisePropertyChanged("sgt_toelichting_uitspraak_nieuw");
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
		public Sgt_com_protest_mutatieStateInfo statecode
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

		public sgt_com_protest_mutatie()
		{
		}
	}
}