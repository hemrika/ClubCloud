using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_ploeginschrijving_afhandeling : BusinessEntity
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
		private CrmBoolean sgt_accepteren_ploegField;
		private Lookup sgt_afgehandeld_dooridField;
		private Lookup sgt_boete_idField;
		private CrmMoney sgt_boetebedragField;
		private CrmMoney sgt_boetebedrag_baseField;
		private string sgt_com_naamField;
		private Key sgt_com_ploeginschrijving_afhandelingidField;
		private Lookup sgt_competitie_idField;
		private CrmDateTime sgt_datum_accepterenField;
		private CrmDateTime sgt_datum_terugtrekkenField;
		private CrmDateTime sgt_datum_uitgevoerdField;
		private Lookup sgt_geaccepteerd_dooridField;
		private Lookup sgt_klassegroep_idField;
		private CrmBoolean sgt_onvoldoende_beschikbare_banenField;
		private Lookup sgt_piramide_idField;
		private CrmDecimal sgt_ploeg_speelsterkte_dField;
		private CrmDecimal sgt_ploeg_speelsterkte_eField;
		private CrmDecimal sgt_ploeggemiddeldeField;
		private Lookup sgt_ploegnaam_idField;
		private CrmBoolean sgt_promoveren_degraderenField;
		private Lookup sgt_teruggetrokken_dooridField;
		private CrmBoolean sgt_terugtrekkenField;
		private Lookup sgt_valuta_idField;
		private Lookup sgt_vereniging_idField;
		private CrmBoolean sgt_verenigingsrecht_intrekkenField;
		private Lookup sgt_verzoekklasse_naaridField;
		private Sgt_com_ploeginschrijving_afhandelingStateInfo statecodeField;
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
		public CrmBoolean sgt_accepteren_ploeg
		{
			get
			{
				return this.sgt_accepteren_ploegField;
			}
			set
			{
				this.sgt_accepteren_ploegField = value;
			}
		}
		public Lookup sgt_afgehandeld_doorid
		{
			get
			{
				return this.sgt_afgehandeld_dooridField;
			}
			set
			{
				this.sgt_afgehandeld_dooridField = value;
			}
		}
		public Lookup sgt_boete_id
		{
			get
			{
				return this.sgt_boete_idField;
			}
			set
			{
				this.sgt_boete_idField = value;
			}
		}
		public CrmMoney sgt_boetebedrag
		{
			get
			{
				return this.sgt_boetebedragField;
			}
			set
			{
				this.sgt_boetebedragField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_base
		{
			get
			{
				return this.sgt_boetebedrag_baseField;
			}
			set
			{
				this.sgt_boetebedrag_baseField = value;
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
		public Key sgt_com_ploeginschrijving_afhandelingid
		{
			get
			{
				return this.sgt_com_ploeginschrijving_afhandelingidField;
			}
			set
			{
				this.sgt_com_ploeginschrijving_afhandelingidField = value;
			}
		}
		public Lookup sgt_competitie_id
		{
			get
			{
				return this.sgt_competitie_idField;
			}
			set
			{
				this.sgt_competitie_idField = value;
			}
		}
		public CrmDateTime sgt_datum_accepteren
		{
			get
			{
				return this.sgt_datum_accepterenField;
			}
			set
			{
				this.sgt_datum_accepterenField = value;
			}
		}
		public CrmDateTime sgt_datum_terugtrekken
		{
			get
			{
				return this.sgt_datum_terugtrekkenField;
			}
			set
			{
				this.sgt_datum_terugtrekkenField = value;
			}
		}
		public CrmDateTime sgt_datum_uitgevoerd
		{
			get
			{
				return this.sgt_datum_uitgevoerdField;
			}
			set
			{
				this.sgt_datum_uitgevoerdField = value;
			}
		}
		public Lookup sgt_geaccepteerd_doorid
		{
			get
			{
				return this.sgt_geaccepteerd_dooridField;
			}
			set
			{
				this.sgt_geaccepteerd_dooridField = value;
			}
		}
		public Lookup sgt_klassegroep_id
		{
			get
			{
				return this.sgt_klassegroep_idField;
			}
			set
			{
				this.sgt_klassegroep_idField = value;
			}
		}
		public CrmBoolean sgt_onvoldoende_beschikbare_banen
		{
			get
			{
				return this.sgt_onvoldoende_beschikbare_banenField;
			}
			set
			{
				this.sgt_onvoldoende_beschikbare_banenField = value;
			}
		}
		public Lookup sgt_piramide_id
		{
			get
			{
				return this.sgt_piramide_idField;
			}
			set
			{
				this.sgt_piramide_idField = value;
			}
		}
		public CrmDecimal sgt_ploeg_speelsterkte_d
		{
			get
			{
				return this.sgt_ploeg_speelsterkte_dField;
			}
			set
			{
				this.sgt_ploeg_speelsterkte_dField = value;
			}
		}
		public CrmDecimal sgt_ploeg_speelsterkte_e
		{
			get
			{
				return this.sgt_ploeg_speelsterkte_eField;
			}
			set
			{
				this.sgt_ploeg_speelsterkte_eField = value;
			}
		}
		public CrmDecimal sgt_ploeggemiddelde
		{
			get
			{
				return this.sgt_ploeggemiddeldeField;
			}
			set
			{
				this.sgt_ploeggemiddeldeField = value;
			}
		}
		public Lookup sgt_ploegnaam_id
		{
			get
			{
				return this.sgt_ploegnaam_idField;
			}
			set
			{
				this.sgt_ploegnaam_idField = value;
			}
		}
		public CrmBoolean sgt_promoveren_degraderen
		{
			get
			{
				return this.sgt_promoveren_degraderenField;
			}
			set
			{
				this.sgt_promoveren_degraderenField = value;
			}
		}
		public Lookup sgt_teruggetrokken_doorid
		{
			get
			{
				return this.sgt_teruggetrokken_dooridField;
			}
			set
			{
				this.sgt_teruggetrokken_dooridField = value;
			}
		}
		public CrmBoolean sgt_terugtrekken
		{
			get
			{
				return this.sgt_terugtrekkenField;
			}
			set
			{
				this.sgt_terugtrekkenField = value;
			}
		}
		public Lookup sgt_valuta_id
		{
			get
			{
				return this.sgt_valuta_idField;
			}
			set
			{
				this.sgt_valuta_idField = value;
			}
		}
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
			}
		}
		public CrmBoolean sgt_verenigingsrecht_intrekken
		{
			get
			{
				return this.sgt_verenigingsrecht_intrekkenField;
			}
			set
			{
				this.sgt_verenigingsrecht_intrekkenField = value;
			}
		}
		public Lookup sgt_verzoekklasse_naarid
		{
			get
			{
				return this.sgt_verzoekklasse_naaridField;
			}
			set
			{
				this.sgt_verzoekklasse_naaridField = value;
			}
		}
		public Sgt_com_ploeginschrijving_afhandelingStateInfo statecode
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
