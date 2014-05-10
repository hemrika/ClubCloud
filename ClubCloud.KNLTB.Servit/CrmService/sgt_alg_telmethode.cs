using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_telmethode : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_telmethode1Field;
		private Key sgt_alg_telmethodeidField;
		private string sgt_beschrijvingField;
		private CrmNumber sgt_bonuspunten_bij_setwinstField;
		private CrmBoolean sgt_kolom_uitslag_tonen_jnField;
		private string sgt_meervoudsnaamField;
		private string sgt_omschrijvingField;
		private CrmNumber sgt_punten_bij_afbreken_verschil_groter_dan_1Field;
		private CrmNumber sgt_punten_bij_afbreken_verschil_maximaal_1Field;
		private CrmNumber sgt_punten_bij_gelijkspelField;
		private CrmNumber sgt_punten_bij_gewonnen_tiebreakField;
		private CrmNumber sgt_punten_bij_verliesField;
		private CrmNumber sgt_punten_bij_verloren_tiebreakField;
		private CrmNumber sgt_punten_bij_winstField;
		private Picklist sgt_type_telmethodeField;
		private string sgt_verkorte_codeField;
		private Sgt_alg_telmethodeStateInfo statecodeField;
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
		[XmlElement("sgt_alg_telmethode")]
		public string sgt_alg_telmethode1
		{
			get
			{
				return this.sgt_alg_telmethode1Field;
			}
			set
			{
				this.sgt_alg_telmethode1Field = value;
			}
		}
		public Key sgt_alg_telmethodeid
		{
			get
			{
				return this.sgt_alg_telmethodeidField;
			}
			set
			{
				this.sgt_alg_telmethodeidField = value;
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
		public CrmNumber sgt_bonuspunten_bij_setwinst
		{
			get
			{
				return this.sgt_bonuspunten_bij_setwinstField;
			}
			set
			{
				this.sgt_bonuspunten_bij_setwinstField = value;
			}
		}
		public CrmBoolean sgt_kolom_uitslag_tonen_jn
		{
			get
			{
				return this.sgt_kolom_uitslag_tonen_jnField;
			}
			set
			{
				this.sgt_kolom_uitslag_tonen_jnField = value;
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
		public CrmNumber sgt_punten_bij_afbreken_verschil_groter_dan_1
		{
			get
			{
				return this.sgt_punten_bij_afbreken_verschil_groter_dan_1Field;
			}
			set
			{
				this.sgt_punten_bij_afbreken_verschil_groter_dan_1Field = value;
			}
		}
		public CrmNumber sgt_punten_bij_afbreken_verschil_maximaal_1
		{
			get
			{
				return this.sgt_punten_bij_afbreken_verschil_maximaal_1Field;
			}
			set
			{
				this.sgt_punten_bij_afbreken_verschil_maximaal_1Field = value;
			}
		}
		public CrmNumber sgt_punten_bij_gelijkspel
		{
			get
			{
				return this.sgt_punten_bij_gelijkspelField;
			}
			set
			{
				this.sgt_punten_bij_gelijkspelField = value;
			}
		}
		public CrmNumber sgt_punten_bij_gewonnen_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_gewonnen_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_gewonnen_tiebreakField = value;
			}
		}
		public CrmNumber sgt_punten_bij_verlies
		{
			get
			{
				return this.sgt_punten_bij_verliesField;
			}
			set
			{
				this.sgt_punten_bij_verliesField = value;
			}
		}
		public CrmNumber sgt_punten_bij_verloren_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_verloren_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_verloren_tiebreakField = value;
			}
		}
		public CrmNumber sgt_punten_bij_winst
		{
			get
			{
				return this.sgt_punten_bij_winstField;
			}
			set
			{
				this.sgt_punten_bij_winstField = value;
			}
		}
		public Picklist sgt_type_telmethode
		{
			get
			{
				return this.sgt_type_telmethodeField;
			}
			set
			{
				this.sgt_type_telmethodeField = value;
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
		public Sgt_alg_telmethodeStateInfo statecode
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
