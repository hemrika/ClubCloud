using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmDateTime sgt_begin_datum
		{
			get
			{
				return this.sgt_begin_datumField;
			}
			set
			{
				this.sgt_begin_datumField = value;
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
		public Key sgt_com_protest_mutatieid
		{
			get
			{
				return this.sgt_com_protest_mutatieidField;
			}
			set
			{
				this.sgt_com_protest_mutatieidField = value;
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
		public CrmDateTime sgt_datum_ontvangen
		{
			get
			{
				return this.sgt_datum_ontvangenField;
			}
			set
			{
				this.sgt_datum_ontvangenField = value;
			}
		}
		public CrmDateTime sgt_datum_ontvangen_nieuw
		{
			get
			{
				return this.sgt_datum_ontvangen_nieuwField;
			}
			set
			{
				this.sgt_datum_ontvangen_nieuwField = value;
			}
		}
		public CrmDateTime sgt_datum_uitspraak
		{
			get
			{
				return this.sgt_datum_uitspraakField;
			}
			set
			{
				this.sgt_datum_uitspraakField = value;
			}
		}
		public CrmDateTime sgt_datum_uitspraak_nieuw
		{
			get
			{
				return this.sgt_datum_uitspraak_nieuwField;
			}
			set
			{
				this.sgt_datum_uitspraak_nieuwField = value;
			}
		}
		public CrmDateTime sgt_eind_datum
		{
			get
			{
				return this.sgt_eind_datumField;
			}
			set
			{
				this.sgt_eind_datumField = value;
			}
		}
		public Lookup sgt_indienende_verengingid
		{
			get
			{
				return this.sgt_indienende_verengingidField;
			}
			set
			{
				this.sgt_indienende_verengingidField = value;
			}
		}
		public Lookup sgt_indienende_vereniging_nieuwid
		{
			get
			{
				return this.sgt_indienende_vereniging_nieuwidField;
			}
			set
			{
				this.sgt_indienende_vereniging_nieuwidField = value;
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
		public Lookup sgt_ploeg_uitid
		{
			get
			{
				return this.sgt_ploeg_uitidField;
			}
			set
			{
				this.sgt_ploeg_uitidField = value;
			}
		}
		public CrmBoolean sgt_protestgeld_betaald
		{
			get
			{
				return this.sgt_protestgeld_betaaldField;
			}
			set
			{
				this.sgt_protestgeld_betaaldField = value;
			}
		}
		public CrmBoolean sgt_protestgeld_betaald_nieuw
		{
			get
			{
				return this.sgt_protestgeld_betaald_nieuwField;
			}
			set
			{
				this.sgt_protestgeld_betaald_nieuwField = value;
			}
		}
		public CrmBoolean sgt_protestgeld_restitueren
		{
			get
			{
				return this.sgt_protestgeld_restituerenField;
			}
			set
			{
				this.sgt_protestgeld_restituerenField = value;
			}
		}
		public CrmBoolean sgt_protestgeld_restitueren_nieuw
		{
			get
			{
				return this.sgt_protestgeld_restitueren_nieuwField;
			}
			set
			{
				this.sgt_protestgeld_restitueren_nieuwField = value;
			}
		}
		public string sgt_reden_protest
		{
			get
			{
				return this.sgt_reden_protestField;
			}
			set
			{
				this.sgt_reden_protestField = value;
			}
		}
		public string sgt_reden_protest_nieuw
		{
			get
			{
				return this.sgt_reden_protest_nieuwField;
			}
			set
			{
				this.sgt_reden_protest_nieuwField = value;
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
		public Picklist sgt_status_nieuw
		{
			get
			{
				return this.sgt_status_nieuwField;
			}
			set
			{
				this.sgt_status_nieuwField = value;
			}
		}
		public string sgt_toelichting_uitspraak
		{
			get
			{
				return this.sgt_toelichting_uitspraakField;
			}
			set
			{
				this.sgt_toelichting_uitspraakField = value;
			}
		}
		public string sgt_toelichting_uitspraak_nieuw
		{
			get
			{
				return this.sgt_toelichting_uitspraak_nieuwField;
			}
			set
			{
				this.sgt_toelichting_uitspraak_nieuwField = value;
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
		public Sgt_com_protest_mutatieStateInfo statecode
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
