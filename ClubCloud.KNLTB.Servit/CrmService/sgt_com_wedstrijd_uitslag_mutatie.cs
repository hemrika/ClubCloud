using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmBoolean sgt_boete_intrekken_thuis
		{
			get
			{
				return this.sgt_boete_intrekken_thuisField;
			}
			set
			{
				this.sgt_boete_intrekken_thuisField = value;
			}
		}
		public CrmBoolean sgt_boete_intrekken_uit
		{
			get
			{
				return this.sgt_boete_intrekken_uitField;
			}
			set
			{
				this.sgt_boete_intrekken_uitField = value;
			}
		}
		public Lookup sgt_boete_thuis_nieuw_id
		{
			get
			{
				return this.sgt_boete_thuis_nieuw_idField;
			}
			set
			{
				this.sgt_boete_thuis_nieuw_idField = value;
			}
		}
		public Lookup sgt_boete_uit_nieuw_id
		{
			get
			{
				return this.sgt_boete_uit_nieuw_idField;
			}
			set
			{
				this.sgt_boete_uit_nieuw_idField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_thuis_huidig
		{
			get
			{
				return this.sgt_boetebedrag_thuis_huidigField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_huidigField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_thuis_huidig_base
		{
			get
			{
				return this.sgt_boetebedrag_thuis_huidig_baseField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_huidig_baseField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_thuis_nieuw
		{
			get
			{
				return this.sgt_boetebedrag_thuis_nieuwField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_nieuwField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_thuis_nieuw_base
		{
			get
			{
				return this.sgt_boetebedrag_thuis_nieuw_baseField;
			}
			set
			{
				this.sgt_boetebedrag_thuis_nieuw_baseField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_uit_huidig
		{
			get
			{
				return this.sgt_boetebedrag_uit_huidigField;
			}
			set
			{
				this.sgt_boetebedrag_uit_huidigField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_uit_huidig_base
		{
			get
			{
				return this.sgt_boetebedrag_uit_huidig_baseField;
			}
			set
			{
				this.sgt_boetebedrag_uit_huidig_baseField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_uit_nieuw
		{
			get
			{
				return this.sgt_boetebedrag_uit_nieuwField;
			}
			set
			{
				this.sgt_boetebedrag_uit_nieuwField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_uit_nieuw_base
		{
			get
			{
				return this.sgt_boetebedrag_uit_nieuw_baseField;
			}
			set
			{
				this.sgt_boetebedrag_uit_nieuw_baseField = value;
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
		public Key sgt_com_wedstrijd_uitslag_mutatieid
		{
			get
			{
				return this.sgt_com_wedstrijd_uitslag_mutatieidField;
			}
			set
			{
				this.sgt_com_wedstrijd_uitslag_mutatieidField = value;
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
		public Lookup sgt_huidge_boete_thuis_id
		{
			get
			{
				return this.sgt_huidge_boete_thuis_idField;
			}
			set
			{
				this.sgt_huidge_boete_thuis_idField = value;
			}
		}
		public Lookup sgt_huidige_boete_uit_id
		{
			get
			{
				return this.sgt_huidige_boete_uit_idField;
			}
			set
			{
				this.sgt_huidige_boete_uit_idField = value;
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
		public CrmDateTime sgt_inhaaldatum_nieuw
		{
			get
			{
				return this.sgt_inhaaldatum_nieuwField;
			}
			set
			{
				this.sgt_inhaaldatum_nieuwField = value;
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
		public Lookup sgt_reden_niet_gespeeld_nieuwid
		{
			get
			{
				return this.sgt_reden_niet_gespeeld_nieuwidField;
			}
			set
			{
				this.sgt_reden_niet_gespeeld_nieuwidField = value;
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
		public CrmNumber sgt_strafpunten_thuis_nieuw
		{
			get
			{
				return this.sgt_strafpunten_thuis_nieuwField;
			}
			set
			{
				this.sgt_strafpunten_thuis_nieuwField = value;
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
		public CrmNumber sgt_strafpunten_uit_nieuw
		{
			get
			{
				return this.sgt_strafpunten_uit_nieuwField;
			}
			set
			{
				this.sgt_strafpunten_uit_nieuwField = value;
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
		public Picklist sgt_uitslag_nieuw
		{
			get
			{
				return this.sgt_uitslag_nieuwField;
			}
			set
			{
				this.sgt_uitslag_nieuwField = value;
			}
		}
		public CrmNumber sgt_uitslag_thuis
		{
			get
			{
				return this.sgt_uitslag_thuisField;
			}
			set
			{
				this.sgt_uitslag_thuisField = value;
			}
		}
		public CrmNumber sgt_uitslag_thuis_nieuw
		{
			get
			{
				return this.sgt_uitslag_thuis_nieuwField;
			}
			set
			{
				this.sgt_uitslag_thuis_nieuwField = value;
			}
		}
		public CrmNumber sgt_uitslag_uit
		{
			get
			{
				return this.sgt_uitslag_uitField;
			}
			set
			{
				this.sgt_uitslag_uitField = value;
			}
		}
		public CrmNumber sgt_uitslag_uit_nieuw
		{
			get
			{
				return this.sgt_uitslag_uit_nieuwField;
			}
			set
			{
				this.sgt_uitslag_uit_nieuwField = value;
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
		public Sgt_com_wedstrijd_uitslag_mutatieStateInfo statecode
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
