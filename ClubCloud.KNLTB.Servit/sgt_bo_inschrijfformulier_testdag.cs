using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_inschrijfformulier_testdag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_jaren_tennisspelendField;
		private CrmNumber sgt_aantal_tennislessenField;
		private CrmNumber sgt_aantal_toernooien_afgelopen_jaarField;
		private string sgt_beroepField;
		private string sgt_bo_inschrijfformulier_testdag1Field;
		private Key sgt_bo_inschrijfformulier_testdagidField;
		private string sgt_bondsnummerField;
		private Lookup sgt_competitieidField;
		private string sgt_diploma_behaald_inField;
		private string sgt_emailField;
		private string sgt_extra_infoField;
		private CrmDateTime sgt_geboortedatumField;
		private string sgt_geboorteplaatsField;
		private string sgt_gemeenteField;
		private string sgt_huisnummerField;
		private Lookup sgt_ingedeeld_op_testdagidField;
		private Lookup sgt_klassengroepidField;
		private string sgt_mobiel_telefoonnummerField;
		private Lookup sgt_nationaliteitidField;
		private Lookup sgt_opleidingidField;
		private Lookup sgt_persoonidField;
		private string sgt_plaatsField;
		private string sgt_postcodeField;
		private CrmBoolean sgt_ppersoonsgegevens_aangepastField;
		private string sgt_roepnaamField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private Picklist sgt_statusField;
		private string sgt_straatField;
		private string sgt_telefoonoverdagField;
		private string sgt_telefoonsavondsField;
		private string sgt_tennisleraar_niet_knltbField;
		private Lookup sgt_tennisleraaridField;
		private Lookup sgt_testdag_3e_voorkeurField;
		private CrmBoolean sgt_testdag_betaaldField;
		private Lookup sgt_testdag_de_voorkeuridField;
		private CrmBoolean sgt_testdag_niet_nodigField;
		private Lookup sgt_testdagidField;
		private string sgt_toevoegingField;
		private string sgt_voornamenField;
		private Lookup sgt_vooropleidingidField;
		private Sgt_bo_inschrijfformulier_testdagStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public CrmNumber sgt_aantal_jaren_tennisspelend
		{
			get
			{
				return this.sgt_aantal_jaren_tennisspelendField;
			}
			set
			{
				this.sgt_aantal_jaren_tennisspelendField = value;
				base.RaisePropertyChanged("sgt_aantal_jaren_tennisspelend");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_tennislessen
		{
			get
			{
				return this.sgt_aantal_tennislessenField;
			}
			set
			{
				this.sgt_aantal_tennislessenField = value;
				base.RaisePropertyChanged("sgt_aantal_tennislessen");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber sgt_aantal_toernooien_afgelopen_jaar
		{
			get
			{
				return this.sgt_aantal_toernooien_afgelopen_jaarField;
			}
			set
			{
				this.sgt_aantal_toernooien_afgelopen_jaarField = value;
				base.RaisePropertyChanged("sgt_aantal_toernooien_afgelopen_jaar");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_beroep
		{
			get
			{
				return this.sgt_beroepField;
			}
			set
			{
				this.sgt_beroepField = value;
				base.RaisePropertyChanged("sgt_beroep");
			}
		}
		[XmlElement("sgt_bo_inschrijfformulier_testdag", Order = 12)]
		public string sgt_bo_inschrijfformulier_testdag1
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdag1Field;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdag1Field = value;
				base.RaisePropertyChanged("sgt_bo_inschrijfformulier_testdag1");
			}
		}
		[XmlElement(Order = 13)]
		public Key sgt_bo_inschrijfformulier_testdagid
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdagidField;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdagidField = value;
				base.RaisePropertyChanged("sgt_bo_inschrijfformulier_testdagid");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public string sgt_diploma_behaald_in
		{
			get
			{
				return this.sgt_diploma_behaald_inField;
			}
			set
			{
				this.sgt_diploma_behaald_inField = value;
				base.RaisePropertyChanged("sgt_diploma_behaald_in");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
				base.RaisePropertyChanged("sgt_email");
			}
		}
		[XmlElement(Order = 18)]
		public string sgt_extra_info
		{
			get
			{
				return this.sgt_extra_infoField;
			}
			set
			{
				this.sgt_extra_infoField = value;
				base.RaisePropertyChanged("sgt_extra_info");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
				base.RaisePropertyChanged("sgt_geboortedatum");
			}
		}
		[XmlElement(Order = 20)]
		public string sgt_geboorteplaats
		{
			get
			{
				return this.sgt_geboorteplaatsField;
			}
			set
			{
				this.sgt_geboorteplaatsField = value;
				base.RaisePropertyChanged("sgt_geboorteplaats");
			}
		}
		[XmlElement(Order = 21)]
		public string sgt_gemeente
		{
			get
			{
				return this.sgt_gemeenteField;
			}
			set
			{
				this.sgt_gemeenteField = value;
				base.RaisePropertyChanged("sgt_gemeente");
			}
		}
		[XmlElement(Order = 22)]
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
				base.RaisePropertyChanged("sgt_huisnummer");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_ingedeeld_op_testdagid
		{
			get
			{
				return this.sgt_ingedeeld_op_testdagidField;
			}
			set
			{
				this.sgt_ingedeeld_op_testdagidField = value;
				base.RaisePropertyChanged("sgt_ingedeeld_op_testdagid");
			}
		}
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
		public string sgt_mobiel_telefoonnummer
		{
			get
			{
				return this.sgt_mobiel_telefoonnummerField;
			}
			set
			{
				this.sgt_mobiel_telefoonnummerField = value;
				base.RaisePropertyChanged("sgt_mobiel_telefoonnummer");
			}
		}
		[XmlElement(Order = 26)]
		public Lookup sgt_nationaliteitid
		{
			get
			{
				return this.sgt_nationaliteitidField;
			}
			set
			{
				this.sgt_nationaliteitidField = value;
				base.RaisePropertyChanged("sgt_nationaliteitid");
			}
		}
		[XmlElement(Order = 27)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}
		[XmlElement(Order = 28)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
				base.RaisePropertyChanged("sgt_postcode");
			}
		}
		[XmlElement(Order = 31)]
		public CrmBoolean sgt_ppersoonsgegevens_aangepast
		{
			get
			{
				return this.sgt_ppersoonsgegevens_aangepastField;
			}
			set
			{
				this.sgt_ppersoonsgegevens_aangepastField = value;
				base.RaisePropertyChanged("sgt_ppersoonsgegevens_aangepast");
			}
		}
		[XmlElement(Order = 32)]
		public string sgt_roepnaam
		{
			get
			{
				return this.sgt_roepnaamField;
			}
			set
			{
				this.sgt_roepnaamField = value;
				base.RaisePropertyChanged("sgt_roepnaam");
			}
		}
		[XmlElement(Order = 33)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}
		[XmlElement(Order = 34)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
				base.RaisePropertyChanged("sgt_straat");
			}
		}
		[XmlElement(Order = 37)]
		public string sgt_telefoonoverdag
		{
			get
			{
				return this.sgt_telefoonoverdagField;
			}
			set
			{
				this.sgt_telefoonoverdagField = value;
				base.RaisePropertyChanged("sgt_telefoonoverdag");
			}
		}
		[XmlElement(Order = 38)]
		public string sgt_telefoonsavonds
		{
			get
			{
				return this.sgt_telefoonsavondsField;
			}
			set
			{
				this.sgt_telefoonsavondsField = value;
				base.RaisePropertyChanged("sgt_telefoonsavonds");
			}
		}
		[XmlElement(Order = 39)]
		public string sgt_tennisleraar_niet_knltb
		{
			get
			{
				return this.sgt_tennisleraar_niet_knltbField;
			}
			set
			{
				this.sgt_tennisleraar_niet_knltbField = value;
				base.RaisePropertyChanged("sgt_tennisleraar_niet_knltb");
			}
		}
		[XmlElement(Order = 40)]
		public Lookup sgt_tennisleraarid
		{
			get
			{
				return this.sgt_tennisleraaridField;
			}
			set
			{
				this.sgt_tennisleraaridField = value;
				base.RaisePropertyChanged("sgt_tennisleraarid");
			}
		}
		[XmlElement(Order = 41)]
		public Lookup sgt_testdag_3e_voorkeur
		{
			get
			{
				return this.sgt_testdag_3e_voorkeurField;
			}
			set
			{
				this.sgt_testdag_3e_voorkeurField = value;
				base.RaisePropertyChanged("sgt_testdag_3e_voorkeur");
			}
		}
		[XmlElement(Order = 42)]
		public CrmBoolean sgt_testdag_betaald
		{
			get
			{
				return this.sgt_testdag_betaaldField;
			}
			set
			{
				this.sgt_testdag_betaaldField = value;
				base.RaisePropertyChanged("sgt_testdag_betaald");
			}
		}
		[XmlElement(Order = 43)]
		public Lookup sgt_testdag_de_voorkeurid
		{
			get
			{
				return this.sgt_testdag_de_voorkeuridField;
			}
			set
			{
				this.sgt_testdag_de_voorkeuridField = value;
				base.RaisePropertyChanged("sgt_testdag_de_voorkeurid");
			}
		}
		[XmlElement(Order = 44)]
		public CrmBoolean sgt_testdag_niet_nodig
		{
			get
			{
				return this.sgt_testdag_niet_nodigField;
			}
			set
			{
				this.sgt_testdag_niet_nodigField = value;
				base.RaisePropertyChanged("sgt_testdag_niet_nodig");
			}
		}
		[XmlElement(Order = 45)]
		public Lookup sgt_testdagid
		{
			get
			{
				return this.sgt_testdagidField;
			}
			set
			{
				this.sgt_testdagidField = value;
				base.RaisePropertyChanged("sgt_testdagid");
			}
		}
		[XmlElement(Order = 46)]
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
				base.RaisePropertyChanged("sgt_toevoeging");
			}
		}
		[XmlElement(Order = 47)]
		public string sgt_voornamen
		{
			get
			{
				return this.sgt_voornamenField;
			}
			set
			{
				this.sgt_voornamenField = value;
				base.RaisePropertyChanged("sgt_voornamen");
			}
		}
		[XmlElement(Order = 48)]
		public Lookup sgt_vooropleidingid
		{
			get
			{
				return this.sgt_vooropleidingidField;
			}
			set
			{
				this.sgt_vooropleidingidField = value;
				base.RaisePropertyChanged("sgt_vooropleidingid");
			}
		}
		[XmlElement(Order = 49)]
		public Sgt_bo_inschrijfformulier_testdagStateInfo statecode
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
		[XmlElement(Order = 50)]
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
		[XmlElement(Order = 51)]
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
		[XmlElement(Order = 52)]
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
