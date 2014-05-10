using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
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
		public string sgt_aanvoerder
		{
			get
			{
				return this.sgt_aanvoerderField;
			}
			set
			{
				this.sgt_aanvoerderField = value;
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
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
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
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
			}
		}
		public CrmBoolean sgt_beslissingswedstrijd
		{
			get
			{
				return this.sgt_beslissingswedstrijdField;
			}
			set
			{
				this.sgt_beslissingswedstrijdField = value;
			}
		}
		public Lookup sgt_boete_thuisid
		{
			get
			{
				return this.sgt_boete_thuisidField;
			}
			set
			{
				this.sgt_boete_thuisidField = value;
			}
		}
		public Lookup sgt_boete_uitid
		{
			get
			{
				return this.sgt_boete_uitidField;
			}
			set
			{
				this.sgt_boete_uitidField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_thuis
		{
			get
			{
				return this.sgt_boetebedrag_thuisField;
			}
			set
			{
				this.sgt_boetebedrag_thuisField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_thuis_base
		{
			get
			{
				return this.sgt_boetebedrag_thuis_baseField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_baseField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_uit
		{
			get
			{
				return this.sgt_boetebedrag_uitField;
			}
			set
			{
				this.sgt_boetebedrag_uitField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_uit_base
		{
			get
			{
				return this.sgt_boetebedrag_uit_baseField;
			}
			set
			{
				this.sgt_boetebedrag_uit_baseField = value;
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
		public Key sgt_com_wedstrijdgegevensid
		{
			get
			{
				return this.sgt_com_wedstrijdgegevensidField;
			}
			set
			{
				this.sgt_com_wedstrijdgegevensidField = value;
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
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
			}
		}
		public CrmNumber sgt_einduitslag_thuis
		{
			get
			{
				return this.sgt_einduitslag_thuisField;
			}
			set
			{
				this.sgt_einduitslag_thuisField = value;
			}
		}
		public CrmNumber sgt_einduitslag_uit
		{
			get
			{
				return this.sgt_einduitslag_uitField;
			}
			set
			{
				this.sgt_einduitslag_uitField = value;
			}
		}
		public Lookup sgt_indienende_verenigingid
		{
			get
			{
				return this.sgt_indienende_verenigingidField;
			}
			set
			{
				this.sgt_indienende_verenigingidField = value;
			}
		}
		public CrmDateTime sgt_inhaaldatum
		{
			get
			{
				return this.sgt_inhaaldatumField;
			}
			set
			{
				this.sgt_inhaaldatumField = value;
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
		public CrmBoolean sgt_niet_meetellen_in_stand
		{
			get
			{
				return this.sgt_niet_meetellen_in_standField;
			}
			set
			{
				this.sgt_niet_meetellen_in_standField = value;
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
		public CrmBoolean sgt_partij_uitslagen_verwerkt
		{
			get
			{
				return this.sgt_partij_uitslagen_verwerktField;
			}
			set
			{
				this.sgt_partij_uitslagen_verwerktField = value;
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
		public CrmBoolean sgt_protestgeld_gerestitueerd
		{
			get
			{
				return this.sgt_protestgeld_gerestitueerdField;
			}
			set
			{
				this.sgt_protestgeld_gerestitueerdField = value;
			}
		}
		public Lookup sgt_reden_niet_gespeeldid
		{
			get
			{
				return this.sgt_reden_niet_gespeeldidField;
			}
			set
			{
				this.sgt_reden_niet_gespeeldidField = value;
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
		public CrmDateTime sgt_speeldatum
		{
			get
			{
				return this.sgt_speeldatumField;
			}
			set
			{
				this.sgt_speeldatumField = value;
			}
		}
		public Picklist sgt_status_protest
		{
			get
			{
				return this.sgt_status_protestField;
			}
			set
			{
				this.sgt_status_protestField = value;
			}
		}
		public CrmNumber sgt_strafpunten_thuis
		{
			get
			{
				return this.sgt_strafpunten_thuisField;
			}
			set
			{
				this.sgt_strafpunten_thuisField = value;
			}
		}
		public CrmNumber sgt_strafpunten_uit
		{
			get
			{
				return this.sgt_strafpunten_uitField;
			}
			set
			{
				this.sgt_strafpunten_uitField = value;
			}
		}
		public CrmBoolean sgt_teamautorisaties_uitschakelen
		{
			get
			{
				return this.sgt_teamautorisaties_uitschakelenField;
			}
			set
			{
				this.sgt_teamautorisaties_uitschakelenField = value;
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
		public Picklist sgt_uitslag
		{
			get
			{
				return this.sgt_uitslagField;
			}
			set
			{
				this.sgt_uitslagField = value;
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
		public Picklist sgt_wedstrijdstatus
		{
			get
			{
				return this.sgt_wedstrijdstatusField;
			}
			set
			{
				this.sgt_wedstrijdstatusField = value;
			}
		}
		public Sgt_com_wedstrijdgegevensStateInfo statecode
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
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
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
