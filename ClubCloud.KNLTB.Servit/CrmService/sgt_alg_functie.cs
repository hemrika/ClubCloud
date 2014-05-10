using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_functie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_functie1Field;
		private Key sgt_alg_functieidField;
		private CrmBoolean sgt_arbitrage_functionarisField;
		private CrmBoolean sgt_basisorganisatieField;
		private CrmBoolean sgt_basisorganisatie_termijn_opgevenField;
		private string sgt_beschrijvingField;
		private CrmBoolean sgt_bestuursorgaanField;
		private CrmBoolean sgt_bestuursorgaan_termijn_opgevenField;
		private CrmBoolean sgt_centre_courtField;
		private CrmBoolean sgt_controle_geheim_adresField;
		private CrmBoolean sgt_docentfunctionarisField;
		private Picklist sgt_functie_kenmerkField;
		private Picklist sgt_functiecoderingField;
		private string sgt_meervoudsnaamField;
		private string sgt_omschrijvingField;
		private CrmBoolean sgt_persoonField;
		private CrmBoolean sgt_persoon_termijn_opgevenField;
		private Lookup sgt_soort_lidmaatschapidField;
		private CrmBoolean sgt_toegang_crm_toegestaanField;
		private Picklist sgt_toegangsniveauField;
		private string sgt_verkorte_codeField;
		private Sgt_alg_functieStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		[XmlElement("sgt_alg_functie")]
		public string sgt_alg_functie1
		{
			get
			{
				return this.sgt_alg_functie1Field;
			}
			set
			{
				this.sgt_alg_functie1Field = value;
			}
		}
		public Key sgt_alg_functieid
		{
			get
			{
				return this.sgt_alg_functieidField;
			}
			set
			{
				this.sgt_alg_functieidField = value;
			}
		}
		public CrmBoolean sgt_arbitrage_functionaris
		{
			get
			{
				return this.sgt_arbitrage_functionarisField;
			}
			set
			{
				this.sgt_arbitrage_functionarisField = value;
			}
		}
		public CrmBoolean sgt_basisorganisatie
		{
			get
			{
				return this.sgt_basisorganisatieField;
			}
			set
			{
				this.sgt_basisorganisatieField = value;
			}
		}
		public CrmBoolean sgt_basisorganisatie_termijn_opgeven
		{
			get
			{
				return this.sgt_basisorganisatie_termijn_opgevenField;
			}
			set
			{
				this.sgt_basisorganisatie_termijn_opgevenField = value;
			}
		}
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
			}
		}
		public CrmBoolean sgt_bestuursorgaan
		{
			get
			{
				return this.sgt_bestuursorgaanField;
			}
			set
			{
				this.sgt_bestuursorgaanField = value;
			}
		}
		public CrmBoolean sgt_bestuursorgaan_termijn_opgeven
		{
			get
			{
				return this.sgt_bestuursorgaan_termijn_opgevenField;
			}
			set
			{
				this.sgt_bestuursorgaan_termijn_opgevenField = value;
			}
		}
		public CrmBoolean sgt_centre_court
		{
			get
			{
				return this.sgt_centre_courtField;
			}
			set
			{
				this.sgt_centre_courtField = value;
			}
		}
		public CrmBoolean sgt_controle_geheim_adres
		{
			get
			{
				return this.sgt_controle_geheim_adresField;
			}
			set
			{
				this.sgt_controle_geheim_adresField = value;
			}
		}
		public CrmBoolean sgt_docentfunctionaris
		{
			get
			{
				return this.sgt_docentfunctionarisField;
			}
			set
			{
				this.sgt_docentfunctionarisField = value;
			}
		}
		public Picklist sgt_functie_kenmerk
		{
			get
			{
				return this.sgt_functie_kenmerkField;
			}
			set
			{
				this.sgt_functie_kenmerkField = value;
			}
		}
		public Picklist sgt_functiecodering
		{
			get
			{
				return this.sgt_functiecoderingField;
			}
			set
			{
				this.sgt_functiecoderingField = value;
			}
		}
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public CrmBoolean sgt_persoon
		{
			get
			{
				return this.sgt_persoonField;
			}
			set
			{
				this.sgt_persoonField = value;
			}
		}
		public CrmBoolean sgt_persoon_termijn_opgeven
		{
			get
			{
				return this.sgt_persoon_termijn_opgevenField;
			}
			set
			{
				this.sgt_persoon_termijn_opgevenField = value;
			}
		}
		public Lookup sgt_soort_lidmaatschapid
		{
			get
			{
				return this.sgt_soort_lidmaatschapidField;
			}
			set
			{
				this.sgt_soort_lidmaatschapidField = value;
			}
		}
		public CrmBoolean sgt_toegang_crm_toegestaan
		{
			get
			{
				return this.sgt_toegang_crm_toegestaanField;
			}
			set
			{
				this.sgt_toegang_crm_toegestaanField = value;
			}
		}
		public Picklist sgt_toegangsniveau
		{
			get
			{
				return this.sgt_toegangsniveauField;
			}
			set
			{
				this.sgt_toegangsniveauField = value;
			}
		}
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
			}
		}
		public Sgt_alg_functieStateInfo statecode
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
