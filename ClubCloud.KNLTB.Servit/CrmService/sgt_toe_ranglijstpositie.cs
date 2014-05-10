using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ranglijstpositie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_puntenField;
		private CrmNumber sgt_aantal_punten_dubbelspelField;
		private CrmNumber sgt_aantal_toernooienField;
		private CrmNumber sgt_aantal_toernooien_dubbelspelField;
		private CrmDecimal sgt_bonuspunten_aantalField;
		private Lookup sgt_circuitidField;
		private Lookup sgt_circuitranglijst_logboekidField;
		private CrmDateTime sgt_datum_ranglijstField;
		private CrmDecimal sgt_gemiddeld_aantal_puntenField;
		private CrmDecimal sgt_gemiddeld_aantal_punten_dubbelspelField;
		private Lookup sgt_ranglijst_logboekidField;
		private Lookup sgt_ranglijstidField;
		private CrmNumber sgt_ranglijstpositieField;
		private Lookup sgt_schaduwranglijst_logboekidField;
		private string sgt_sorteercode_crmField;
		private Lookup sgt_speleridField;
		private string sgt_toe_ranglijstpositie1Field;
		private Key sgt_toe_ranglijstpositieidField;
		private CrmDecimal sgt_tot_aantal_puntenField;
		private CrmNumber sgt_vorige_ranglijstpositieField;
		private Sgt_toe_ranglijstpositieStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_punten
		{
			get
			{
				return this.sgt_aantal_puntenField;
			}
			set
			{
				this.sgt_aantal_puntenField = value;
			}
		}
		public CrmNumber sgt_aantal_punten_dubbelspel
		{
			get
			{
				return this.sgt_aantal_punten_dubbelspelField;
			}
			set
			{
				this.sgt_aantal_punten_dubbelspelField = value;
			}
		}
		public CrmNumber sgt_aantal_toernooien
		{
			get
			{
				return this.sgt_aantal_toernooienField;
			}
			set
			{
				this.sgt_aantal_toernooienField = value;
			}
		}
		public CrmNumber sgt_aantal_toernooien_dubbelspel
		{
			get
			{
				return this.sgt_aantal_toernooien_dubbelspelField;
			}
			set
			{
				this.sgt_aantal_toernooien_dubbelspelField = value;
			}
		}
		public CrmDecimal sgt_bonuspunten_aantal
		{
			get
			{
				return this.sgt_bonuspunten_aantalField;
			}
			set
			{
				this.sgt_bonuspunten_aantalField = value;
			}
		}
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
			}
		}
		public Lookup sgt_circuitranglijst_logboekid
		{
			get
			{
				return this.sgt_circuitranglijst_logboekidField;
			}
			set
			{
				this.sgt_circuitranglijst_logboekidField = value;
			}
		}
		public CrmDateTime sgt_datum_ranglijst
		{
			get
			{
				return this.sgt_datum_ranglijstField;
			}
			set
			{
				this.sgt_datum_ranglijstField = value;
			}
		}
		public CrmDecimal sgt_gemiddeld_aantal_punten
		{
			get
			{
				return this.sgt_gemiddeld_aantal_puntenField;
			}
			set
			{
				this.sgt_gemiddeld_aantal_puntenField = value;
			}
		}
		public CrmDecimal sgt_gemiddeld_aantal_punten_dubbelspel
		{
			get
			{
				return this.sgt_gemiddeld_aantal_punten_dubbelspelField;
			}
			set
			{
				this.sgt_gemiddeld_aantal_punten_dubbelspelField = value;
			}
		}
		public Lookup sgt_ranglijst_logboekid
		{
			get
			{
				return this.sgt_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_ranglijst_logboekidField = value;
			}
		}
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
			}
		}
		public CrmNumber sgt_ranglijstpositie
		{
			get
			{
				return this.sgt_ranglijstpositieField;
			}
			set
			{
				this.sgt_ranglijstpositieField = value;
			}
		}
		public Lookup sgt_schaduwranglijst_logboekid
		{
			get
			{
				return this.sgt_schaduwranglijst_logboekidField;
			}
			set
			{
				this.sgt_schaduwranglijst_logboekidField = value;
			}
		}
		public string sgt_sorteercode_crm
		{
			get
			{
				return this.sgt_sorteercode_crmField;
			}
			set
			{
				this.sgt_sorteercode_crmField = value;
			}
		}
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
			}
		}
		[XmlElement("sgt_toe_ranglijstpositie")]
		public string sgt_toe_ranglijstpositie1
		{
			get
			{
				return this.sgt_toe_ranglijstpositie1Field;
			}
			set
			{
				this.sgt_toe_ranglijstpositie1Field = value;
			}
		}
		public Key sgt_toe_ranglijstpositieid
		{
			get
			{
				return this.sgt_toe_ranglijstpositieidField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieidField = value;
			}
		}
		public CrmDecimal sgt_tot_aantal_punten
		{
			get
			{
				return this.sgt_tot_aantal_puntenField;
			}
			set
			{
				this.sgt_tot_aantal_puntenField = value;
			}
		}
		public CrmNumber sgt_vorige_ranglijstpositie
		{
			get
			{
				return this.sgt_vorige_ranglijstpositieField;
			}
			set
			{
				this.sgt_vorige_ranglijstpositieField = value;
			}
		}
		public Sgt_toe_ranglijstpositieStateInfo statecode
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
