using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmNumber sgt_aantal_jaren_tennisspelend
		{
			get
			{
				return this.sgt_aantal_jaren_tennisspelendField;
			}
			set
			{
				this.sgt_aantal_jaren_tennisspelendField = value;
			}
		}
		public CrmNumber sgt_aantal_tennislessen
		{
			get
			{
				return this.sgt_aantal_tennislessenField;
			}
			set
			{
				this.sgt_aantal_tennislessenField = value;
			}
		}
		public CrmNumber sgt_aantal_toernooien_afgelopen_jaar
		{
			get
			{
				return this.sgt_aantal_toernooien_afgelopen_jaarField;
			}
			set
			{
				this.sgt_aantal_toernooien_afgelopen_jaarField = value;
			}
		}
		public string sgt_beroep
		{
			get
			{
				return this.sgt_beroepField;
			}
			set
			{
				this.sgt_beroepField = value;
			}
		}
		[XmlElement("sgt_bo_inschrijfformulier_testdag")]
		public string sgt_bo_inschrijfformulier_testdag1
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdag1Field;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdag1Field = value;
			}
		}
		public Key sgt_bo_inschrijfformulier_testdagid
		{
			get
			{
				return this.sgt_bo_inschrijfformulier_testdagidField;
			}
			set
			{
				this.sgt_bo_inschrijfformulier_testdagidField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
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
		public string sgt_diploma_behaald_in
		{
			get
			{
				return this.sgt_diploma_behaald_inField;
			}
			set
			{
				this.sgt_diploma_behaald_inField = value;
			}
		}
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
			}
		}
		public string sgt_extra_info
		{
			get
			{
				return this.sgt_extra_infoField;
			}
			set
			{
				this.sgt_extra_infoField = value;
			}
		}
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
			}
		}
		public string sgt_geboorteplaats
		{
			get
			{
				return this.sgt_geboorteplaatsField;
			}
			set
			{
				this.sgt_geboorteplaatsField = value;
			}
		}
		public string sgt_gemeente
		{
			get
			{
				return this.sgt_gemeenteField;
			}
			set
			{
				this.sgt_gemeenteField = value;
			}
		}
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
			}
		}
		public Lookup sgt_ingedeeld_op_testdagid
		{
			get
			{
				return this.sgt_ingedeeld_op_testdagidField;
			}
			set
			{
				this.sgt_ingedeeld_op_testdagidField = value;
			}
		}
		public Lookup sgt_klassengroepid
		{
			get
			{
				return this.sgt_klassengroepidField;
			}
			set
			{
				this.sgt_klassengroepidField = value;
			}
		}
		public string sgt_mobiel_telefoonnummer
		{
			get
			{
				return this.sgt_mobiel_telefoonnummerField;
			}
			set
			{
				this.sgt_mobiel_telefoonnummerField = value;
			}
		}
		public Lookup sgt_nationaliteitid
		{
			get
			{
				return this.sgt_nationaliteitidField;
			}
			set
			{
				this.sgt_nationaliteitidField = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
			}
		}
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
			}
		}
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
			}
		}
		public CrmBoolean sgt_ppersoonsgegevens_aangepast
		{
			get
			{
				return this.sgt_ppersoonsgegevens_aangepastField;
			}
			set
			{
				this.sgt_ppersoonsgegevens_aangepastField = value;
			}
		}
		public string sgt_roepnaam
		{
			get
			{
				return this.sgt_roepnaamField;
			}
			set
			{
				this.sgt_roepnaamField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
			}
		}
		public string sgt_telefoonoverdag
		{
			get
			{
				return this.sgt_telefoonoverdagField;
			}
			set
			{
				this.sgt_telefoonoverdagField = value;
			}
		}
		public string sgt_telefoonsavonds
		{
			get
			{
				return this.sgt_telefoonsavondsField;
			}
			set
			{
				this.sgt_telefoonsavondsField = value;
			}
		}
		public string sgt_tennisleraar_niet_knltb
		{
			get
			{
				return this.sgt_tennisleraar_niet_knltbField;
			}
			set
			{
				this.sgt_tennisleraar_niet_knltbField = value;
			}
		}
		public Lookup sgt_tennisleraarid
		{
			get
			{
				return this.sgt_tennisleraaridField;
			}
			set
			{
				this.sgt_tennisleraaridField = value;
			}
		}
		public Lookup sgt_testdag_3e_voorkeur
		{
			get
			{
				return this.sgt_testdag_3e_voorkeurField;
			}
			set
			{
				this.sgt_testdag_3e_voorkeurField = value;
			}
		}
		public CrmBoolean sgt_testdag_betaald
		{
			get
			{
				return this.sgt_testdag_betaaldField;
			}
			set
			{
				this.sgt_testdag_betaaldField = value;
			}
		}
		public Lookup sgt_testdag_de_voorkeurid
		{
			get
			{
				return this.sgt_testdag_de_voorkeuridField;
			}
			set
			{
				this.sgt_testdag_de_voorkeuridField = value;
			}
		}
		public CrmBoolean sgt_testdag_niet_nodig
		{
			get
			{
				return this.sgt_testdag_niet_nodigField;
			}
			set
			{
				this.sgt_testdag_niet_nodigField = value;
			}
		}
		public Lookup sgt_testdagid
		{
			get
			{
				return this.sgt_testdagidField;
			}
			set
			{
				this.sgt_testdagidField = value;
			}
		}
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
			}
		}
		public string sgt_voornamen
		{
			get
			{
				return this.sgt_voornamenField;
			}
			set
			{
				this.sgt_voornamenField = value;
			}
		}
		public Lookup sgt_vooropleidingid
		{
			get
			{
				return this.sgt_vooropleidingidField;
			}
			set
			{
				this.sgt_vooropleidingidField = value;
			}
		}
		public Sgt_bo_inschrijfformulier_testdagStateInfo statecode
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
