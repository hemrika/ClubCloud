using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_administratieve_overtreding : BusinessEntity
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
		private Picklist sgt_administratieve_overtreding_statusField;
		private CrmBoolean sgt_bepalen_strafmaatField;
		private CrmMoney sgt_boetebedragField;
		private CrmMoney sgt_boetebedrag_baseField;
		private Lookup sgt_constaterings_moment_ao_idField;
		private Lookup sgt_contact_deelnemer_idField;
		private Lookup sgt_contact_indiener_idField;
		private string sgt_deelnemer_bondsnummerField;
		private CrmBoolean sgt_deelnemer_inschrijfkaartField;
		private Picklist sgt_deelnemer_junior_seniorField;
		private CrmDateTime sgt_deelnemer_leeftijdField;
		private Picklist sgt_deelnemer_wedstrijdleidingField;
		private Lookup sgt_functionaris_indiener_idField;
		private Lookup sgt_functionaris_wedstrijdleider_idField;
		private string sgt_indiener_bondsnummerField;
		private Lookup sgt_indiener_functie_idField;
		private string sgt_memo_aard_overtredingField;
		private string sgt_memo_bondsgedelegeerdeField;
		private string sgt_memo_commissieField;
		private string sgt_memo_deelnemerField;
		private string sgt_memo_indienerField;
		private string sgt_memo_wedstrijdleidingField;
		private CrmNumber sgt_overtreding_herhalingField;
		private CrmDateTime sgt_ovetreding_datumField;
		private CrmNumber sgt_schorsingsperiodeField;
		private Lookup sgt_strafbepalingidField;
		private Lookup sgt_strafidField;
		private string sgt_toe_administratieve_overtreding1Field;
		private Key sgt_toe_administratieve_overtredingidField;
		private Lookup sgt_toernooi_idField;
		private Picklist sgt_type_evenementField;
		private Lookup sgt_vereniging_idField;
		private CrmNumber sgt_verstreken_periode_dagenField;
		private string sgt_volgnummer_administratieve_ovetredingField;
		private Sgt_toe_administratieve_overtredingStateInfo statecodeField;
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
		public Picklist sgt_administratieve_overtreding_status
		{
			get
			{
				return this.sgt_administratieve_overtreding_statusField;
			}
			set
			{
				this.sgt_administratieve_overtreding_statusField = value;
			}
		}
		public CrmBoolean sgt_bepalen_strafmaat
		{
			get
			{
				return this.sgt_bepalen_strafmaatField;
			}
			set
			{
				this.sgt_bepalen_strafmaatField = value;
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
		public Lookup sgt_constaterings_moment_ao_id
		{
			get
			{
				return this.sgt_constaterings_moment_ao_idField;
			}
			set
			{
				this.sgt_constaterings_moment_ao_idField = value;
			}
		}
		public Lookup sgt_contact_deelnemer_id
		{
			get
			{
				return this.sgt_contact_deelnemer_idField;
			}
			set
			{
				this.sgt_contact_deelnemer_idField = value;
			}
		}
		public Lookup sgt_contact_indiener_id
		{
			get
			{
				return this.sgt_contact_indiener_idField;
			}
			set
			{
				this.sgt_contact_indiener_idField = value;
			}
		}
		public string sgt_deelnemer_bondsnummer
		{
			get
			{
				return this.sgt_deelnemer_bondsnummerField;
			}
			set
			{
				this.sgt_deelnemer_bondsnummerField = value;
			}
		}
		public CrmBoolean sgt_deelnemer_inschrijfkaart
		{
			get
			{
				return this.sgt_deelnemer_inschrijfkaartField;
			}
			set
			{
				this.sgt_deelnemer_inschrijfkaartField = value;
			}
		}
		public Picklist sgt_deelnemer_junior_senior
		{
			get
			{
				return this.sgt_deelnemer_junior_seniorField;
			}
			set
			{
				this.sgt_deelnemer_junior_seniorField = value;
			}
		}
		public CrmDateTime sgt_deelnemer_leeftijd
		{
			get
			{
				return this.sgt_deelnemer_leeftijdField;
			}
			set
			{
				this.sgt_deelnemer_leeftijdField = value;
			}
		}
		public Picklist sgt_deelnemer_wedstrijdleiding
		{
			get
			{
				return this.sgt_deelnemer_wedstrijdleidingField;
			}
			set
			{
				this.sgt_deelnemer_wedstrijdleidingField = value;
			}
		}
		public Lookup sgt_functionaris_indiener_id
		{
			get
			{
				return this.sgt_functionaris_indiener_idField;
			}
			set
			{
				this.sgt_functionaris_indiener_idField = value;
			}
		}
		public Lookup sgt_functionaris_wedstrijdleider_id
		{
			get
			{
				return this.sgt_functionaris_wedstrijdleider_idField;
			}
			set
			{
				this.sgt_functionaris_wedstrijdleider_idField = value;
			}
		}
		public string sgt_indiener_bondsnummer
		{
			get
			{
				return this.sgt_indiener_bondsnummerField;
			}
			set
			{
				this.sgt_indiener_bondsnummerField = value;
			}
		}
		public Lookup sgt_indiener_functie_id
		{
			get
			{
				return this.sgt_indiener_functie_idField;
			}
			set
			{
				this.sgt_indiener_functie_idField = value;
			}
		}
		public string sgt_memo_aard_overtreding
		{
			get
			{
				return this.sgt_memo_aard_overtredingField;
			}
			set
			{
				this.sgt_memo_aard_overtredingField = value;
			}
		}
		public string sgt_memo_bondsgedelegeerde
		{
			get
			{
				return this.sgt_memo_bondsgedelegeerdeField;
			}
			set
			{
				this.sgt_memo_bondsgedelegeerdeField = value;
			}
		}
		public string sgt_memo_commissie
		{
			get
			{
				return this.sgt_memo_commissieField;
			}
			set
			{
				this.sgt_memo_commissieField = value;
			}
		}
		public string sgt_memo_deelnemer
		{
			get
			{
				return this.sgt_memo_deelnemerField;
			}
			set
			{
				this.sgt_memo_deelnemerField = value;
			}
		}
		public string sgt_memo_indiener
		{
			get
			{
				return this.sgt_memo_indienerField;
			}
			set
			{
				this.sgt_memo_indienerField = value;
			}
		}
		public string sgt_memo_wedstrijdleiding
		{
			get
			{
				return this.sgt_memo_wedstrijdleidingField;
			}
			set
			{
				this.sgt_memo_wedstrijdleidingField = value;
			}
		}
		public CrmNumber sgt_overtreding_herhaling
		{
			get
			{
				return this.sgt_overtreding_herhalingField;
			}
			set
			{
				this.sgt_overtreding_herhalingField = value;
			}
		}
		public CrmDateTime sgt_ovetreding_datum
		{
			get
			{
				return this.sgt_ovetreding_datumField;
			}
			set
			{
				this.sgt_ovetreding_datumField = value;
			}
		}
		public CrmNumber sgt_schorsingsperiode
		{
			get
			{
				return this.sgt_schorsingsperiodeField;
			}
			set
			{
				this.sgt_schorsingsperiodeField = value;
			}
		}
		public Lookup sgt_strafbepalingid
		{
			get
			{
				return this.sgt_strafbepalingidField;
			}
			set
			{
				this.sgt_strafbepalingidField = value;
			}
		}
		public Lookup sgt_strafid
		{
			get
			{
				return this.sgt_strafidField;
			}
			set
			{
				this.sgt_strafidField = value;
			}
		}
		[XmlElement("sgt_toe_administratieve_overtreding")]
		public string sgt_toe_administratieve_overtreding1
		{
			get
			{
				return this.sgt_toe_administratieve_overtreding1Field;
			}
			set
			{
				this.sgt_toe_administratieve_overtreding1Field = value;
			}
		}
		public Key sgt_toe_administratieve_overtredingid
		{
			get
			{
				return this.sgt_toe_administratieve_overtredingidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtredingidField = value;
			}
		}
		public Lookup sgt_toernooi_id
		{
			get
			{
				return this.sgt_toernooi_idField;
			}
			set
			{
				this.sgt_toernooi_idField = value;
			}
		}
		public Picklist sgt_type_evenement
		{
			get
			{
				return this.sgt_type_evenementField;
			}
			set
			{
				this.sgt_type_evenementField = value;
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
		public CrmNumber sgt_verstreken_periode_dagen
		{
			get
			{
				return this.sgt_verstreken_periode_dagenField;
			}
			set
			{
				this.sgt_verstreken_periode_dagenField = value;
			}
		}
		public string sgt_volgnummer_administratieve_ovetreding
		{
			get
			{
				return this.sgt_volgnummer_administratieve_ovetredingField;
			}
			set
			{
				this.sgt_volgnummer_administratieve_ovetredingField = value;
			}
		}
		public Sgt_toe_administratieve_overtredingStateInfo statecode
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
