using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Picklist sgt_administratieve_overtreding_status
		{
			get
			{
				return this.sgt_administratieve_overtreding_statusField;
			}
			set
			{
				this.sgt_administratieve_overtreding_statusField = value;
				base.RaisePropertyChanged("sgt_administratieve_overtreding_status");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_bepalen_strafmaat
		{
			get
			{
				return this.sgt_bepalen_strafmaatField;
			}
			set
			{
				this.sgt_bepalen_strafmaatField = value;
				base.RaisePropertyChanged("sgt_bepalen_strafmaat");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmMoney sgt_boetebedrag
		{
			get
			{
				return this.sgt_boetebedragField;
			}
			set
			{
				this.sgt_boetebedragField = value;
				base.RaisePropertyChanged("sgt_boetebedrag");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmMoney sgt_boetebedrag_base
		{
			get
			{
				return this.sgt_boetebedrag_baseField;
			}
			set
			{
				this.sgt_boetebedrag_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_base");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_constaterings_moment_ao_id
		{
			get
			{
				return this.sgt_constaterings_moment_ao_idField;
			}
			set
			{
				this.sgt_constaterings_moment_ao_idField = value;
				base.RaisePropertyChanged("sgt_constaterings_moment_ao_id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_contact_deelnemer_id
		{
			get
			{
				return this.sgt_contact_deelnemer_idField;
			}
			set
			{
				this.sgt_contact_deelnemer_idField = value;
				base.RaisePropertyChanged("sgt_contact_deelnemer_id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_contact_indiener_id
		{
			get
			{
				return this.sgt_contact_indiener_idField;
			}
			set
			{
				this.sgt_contact_indiener_idField = value;
				base.RaisePropertyChanged("sgt_contact_indiener_id");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_deelnemer_bondsnummer
		{
			get
			{
				return this.sgt_deelnemer_bondsnummerField;
			}
			set
			{
				this.sgt_deelnemer_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_deelnemer_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_deelnemer_inschrijfkaart
		{
			get
			{
				return this.sgt_deelnemer_inschrijfkaartField;
			}
			set
			{
				this.sgt_deelnemer_inschrijfkaartField = value;
				base.RaisePropertyChanged("sgt_deelnemer_inschrijfkaart");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Picklist sgt_deelnemer_junior_senior
		{
			get
			{
				return this.sgt_deelnemer_junior_seniorField;
			}
			set
			{
				this.sgt_deelnemer_junior_seniorField = value;
				base.RaisePropertyChanged("sgt_deelnemer_junior_senior");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmDateTime sgt_deelnemer_leeftijd
		{
			get
			{
				return this.sgt_deelnemer_leeftijdField;
			}
			set
			{
				this.sgt_deelnemer_leeftijdField = value;
				base.RaisePropertyChanged("sgt_deelnemer_leeftijd");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_deelnemer_wedstrijdleiding
		{
			get
			{
				return this.sgt_deelnemer_wedstrijdleidingField;
			}
			set
			{
				this.sgt_deelnemer_wedstrijdleidingField = value;
				base.RaisePropertyChanged("sgt_deelnemer_wedstrijdleiding");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_functionaris_indiener_id
		{
			get
			{
				return this.sgt_functionaris_indiener_idField;
			}
			set
			{
				this.sgt_functionaris_indiener_idField = value;
				base.RaisePropertyChanged("sgt_functionaris_indiener_id");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_functionaris_wedstrijdleider_id
		{
			get
			{
				return this.sgt_functionaris_wedstrijdleider_idField;
			}
			set
			{
				this.sgt_functionaris_wedstrijdleider_idField = value;
				base.RaisePropertyChanged("sgt_functionaris_wedstrijdleider_id");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_indiener_bondsnummer
		{
			get
			{
				return this.sgt_indiener_bondsnummerField;
			}
			set
			{
				this.sgt_indiener_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_indiener_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_indiener_functie_id
		{
			get
			{
				return this.sgt_indiener_functie_idField;
			}
			set
			{
				this.sgt_indiener_functie_idField = value;
				base.RaisePropertyChanged("sgt_indiener_functie_id");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_memo_aard_overtreding
		{
			get
			{
				return this.sgt_memo_aard_overtredingField;
			}
			set
			{
				this.sgt_memo_aard_overtredingField = value;
				base.RaisePropertyChanged("sgt_memo_aard_overtreding");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public string sgt_memo_bondsgedelegeerde
		{
			get
			{
				return this.sgt_memo_bondsgedelegeerdeField;
			}
			set
			{
				this.sgt_memo_bondsgedelegeerdeField = value;
				base.RaisePropertyChanged("sgt_memo_bondsgedelegeerde");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_memo_commissie
		{
			get
			{
				return this.sgt_memo_commissieField;
			}
			set
			{
				this.sgt_memo_commissieField = value;
				base.RaisePropertyChanged("sgt_memo_commissie");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string sgt_memo_deelnemer
		{
			get
			{
				return this.sgt_memo_deelnemerField;
			}
			set
			{
				this.sgt_memo_deelnemerField = value;
				base.RaisePropertyChanged("sgt_memo_deelnemer");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_memo_indiener
		{
			get
			{
				return this.sgt_memo_indienerField;
			}
			set
			{
				this.sgt_memo_indienerField = value;
				base.RaisePropertyChanged("sgt_memo_indiener");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string sgt_memo_wedstrijdleiding
		{
			get
			{
				return this.sgt_memo_wedstrijdleidingField;
			}
			set
			{
				this.sgt_memo_wedstrijdleidingField = value;
				base.RaisePropertyChanged("sgt_memo_wedstrijdleiding");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmNumber sgt_overtreding_herhaling
		{
			get
			{
				return this.sgt_overtreding_herhalingField;
			}
			set
			{
				this.sgt_overtreding_herhalingField = value;
				base.RaisePropertyChanged("sgt_overtreding_herhaling");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmDateTime sgt_ovetreding_datum
		{
			get
			{
				return this.sgt_ovetreding_datumField;
			}
			set
			{
				this.sgt_ovetreding_datumField = value;
				base.RaisePropertyChanged("sgt_ovetreding_datum");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public CrmNumber sgt_schorsingsperiode
		{
			get
			{
				return this.sgt_schorsingsperiodeField;
			}
			set
			{
				this.sgt_schorsingsperiodeField = value;
				base.RaisePropertyChanged("sgt_schorsingsperiode");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Lookup sgt_strafbepalingid
		{
			get
			{
				return this.sgt_strafbepalingidField;
			}
			set
			{
				this.sgt_strafbepalingidField = value;
				base.RaisePropertyChanged("sgt_strafbepalingid");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Lookup sgt_strafid
		{
			get
			{
				return this.sgt_strafidField;
			}
			set
			{
				this.sgt_strafidField = value;
				base.RaisePropertyChanged("sgt_strafid");
			}
		}

		[XmlElement("sgt_toe_administratieve_overtreding")] //, Order=36)]
		public string sgt_toe_administratieve_overtreding1
		{
			get
			{
				return this.sgt_toe_administratieve_overtreding1Field;
			}
			set
			{
				this.sgt_toe_administratieve_overtreding1Field = value;
				base.RaisePropertyChanged("sgt_toe_administratieve_overtreding1");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Key sgt_toe_administratieve_overtredingid
		{
			get
			{
				return this.sgt_toe_administratieve_overtredingidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtredingidField = value;
				base.RaisePropertyChanged("sgt_toe_administratieve_overtredingid");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public Lookup sgt_toernooi_id
		{
			get
			{
				return this.sgt_toernooi_idField;
			}
			set
			{
				this.sgt_toernooi_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_id");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public Picklist sgt_type_evenement
		{
			get
			{
				return this.sgt_type_evenementField;
			}
			set
			{
				this.sgt_type_evenementField = value;
				base.RaisePropertyChanged("sgt_type_evenement");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
				base.RaisePropertyChanged("sgt_vereniging_id");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public CrmNumber sgt_verstreken_periode_dagen
		{
			get
			{
				return this.sgt_verstreken_periode_dagenField;
			}
			set
			{
				this.sgt_verstreken_periode_dagenField = value;
				base.RaisePropertyChanged("sgt_verstreken_periode_dagen");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public string sgt_volgnummer_administratieve_ovetreding
		{
			get
			{
				return this.sgt_volgnummer_administratieve_ovetredingField;
			}
			set
			{
				this.sgt_volgnummer_administratieve_ovetredingField = value;
				base.RaisePropertyChanged("sgt_volgnummer_administratieve_ovetreding");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public Sgt_toe_administratieve_overtredingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
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

		public sgt_toe_administratieve_overtreding()
		{
		}
	}
}