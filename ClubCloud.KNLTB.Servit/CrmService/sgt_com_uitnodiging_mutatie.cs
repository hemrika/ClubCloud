using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmDateTime sgt_aanvangstijd_datumtijd
		{
			get
			{
				return this.sgt_aanvangstijd_datumtijdField;
			}
			set
			{
				this.sgt_aanvangstijd_datumtijdField = value;
			}
		}
		public CrmDateTime sgt_aanvangstijd_datumtijd_nieuw
		{
			get
			{
				return this.sgt_aanvangstijd_datumtijd_nieuwField;
			}
			set
			{
				this.sgt_aanvangstijd_datumtijd_nieuwField = value;
			}
		}
		public Lookup sgt_aanvoerder_nieuw_id
		{
			get
			{
				return this.sgt_aanvoerder_nieuw_idField;
			}
			set
			{
				this.sgt_aanvoerder_nieuw_idField = value;
			}
		}
		public Lookup sgt_aanvoerder_oud_id
		{
			get
			{
				return this.sgt_aanvoerder_oud_idField;
			}
			set
			{
				this.sgt_aanvoerder_oud_idField = value;
			}
		}
		public string sgt_aanvullende_informatie
		{
			get
			{
				return this.sgt_aanvullende_informatieField;
			}
			set
			{
				this.sgt_aanvullende_informatieField = value;
			}
		}
		public string sgt_aanvullende_informatie_nieuw
		{
			get
			{
				return this.sgt_aanvullende_informatie_nieuwField;
			}
			set
			{
				this.sgt_aanvullende_informatie_nieuwField = value;
			}
		}
		public Lookup sgt_accomodatieid
		{
			get
			{
				return this.sgt_accomodatieidField;
			}
			set
			{
				this.sgt_accomodatieidField = value;
			}
		}
		public Lookup sgt_afdelingid
		{
			get
			{
				return this.sgt_afdelingidField;
			}
			set
			{
				this.sgt_afdelingidField = value;
			}
		}
		public Lookup sgt_baansoort_nieuwid
		{
			get
			{
				return this.sgt_baansoort_nieuwidField;
			}
			set
			{
				this.sgt_baansoort_nieuwidField = value;
			}
		}
		public Lookup sgt_baansoortid
		{
			get
			{
				return this.sgt_baansoortidField;
			}
			set
			{
				this.sgt_baansoortidField = value;
			}
		}
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
			}
		}
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
			}
		}
		public Key sgt_com_uitnodiging_mutatieid
		{
			get
			{
				return this.sgt_com_uitnodiging_mutatieidField;
			}
			set
			{
				this.sgt_com_uitnodiging_mutatieidField = value;
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
		public Lookup sgt_competitietypeid
		{
			get
			{
				return this.sgt_competitietypeidField;
			}
			set
			{
				this.sgt_competitietypeidField = value;
			}
		}
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
			}
		}
		public string sgt_naam_aanvoerder
		{
			get
			{
				return this.sgt_naam_aanvoerderField;
			}
			set
			{
				this.sgt_naam_aanvoerderField = value;
			}
		}
		public string sgt_naam_aanvoerder_nieuw
		{
			get
			{
				return this.sgt_naam_aanvoerder_nieuwField;
			}
			set
			{
				this.sgt_naam_aanvoerder_nieuwField = value;
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
		public Lookup sgt_organiserende_verenigingid
		{
			get
			{
				return this.sgt_organiserende_verenigingidField;
			}
			set
			{
				this.sgt_organiserende_verenigingidField = value;
			}
		}
		public CrmBoolean sgt_overnemen_andere_uitnodigingen
		{
			get
			{
				return this.sgt_overnemen_andere_uitnodigingenField;
			}
			set
			{
				this.sgt_overnemen_andere_uitnodigingenField = value;
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
		public Lookup sgt_ploeg_thuisid
		{
			get
			{
				return this.sgt_ploeg_thuisidField;
			}
			set
			{
				this.sgt_ploeg_thuisidField = value;
			}
		}
		public Lookup sgt_ploeguit_id
		{
			get
			{
				return this.sgt_ploeguit_idField;
			}
			set
			{
				this.sgt_ploeguit_idField = value;
			}
		}
		public string sgt_telefoon
		{
			get
			{
				return this.sgt_telefoonField;
			}
			set
			{
				this.sgt_telefoonField = value;
			}
		}
		public string sgt_telefoon_nieuw
		{
			get
			{
				return this.sgt_telefoon_nieuwField;
			}
			set
			{
				this.sgt_telefoon_nieuwField = value;
			}
		}
		public CrmDateTime sgt_tijd_aanwezig_datumtijd
		{
			get
			{
				return this.sgt_tijd_aanwezig_datumtijdField;
			}
			set
			{
				this.sgt_tijd_aanwezig_datumtijdField = value;
			}
		}
		public CrmDateTime sgt_tijd_aanwezig_datumtijd_nieuw
		{
			get
			{
				return this.sgt_tijd_aanwezig_datumtijd_nieuwField;
			}
			set
			{
				this.sgt_tijd_aanwezig_datumtijd_nieuwField = value;
			}
		}
		public Lookup sgt_vereniging_thuisid
		{
			get
			{
				return this.sgt_vereniging_thuisidField;
			}
			set
			{
				this.sgt_vereniging_thuisidField = value;
			}
		}
		public Lookup sgt_vereniging_uitid
		{
			get
			{
				return this.sgt_vereniging_uitidField;
			}
			set
			{
				this.sgt_vereniging_uitidField = value;
			}
		}
		public Lookup sgt_wedstrijdid
		{
			get
			{
				return this.sgt_wedstrijdidField;
			}
			set
			{
				this.sgt_wedstrijdidField = value;
			}
		}
		public Sgt_com_uitnodiging_mutatieStateInfo statecode
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
