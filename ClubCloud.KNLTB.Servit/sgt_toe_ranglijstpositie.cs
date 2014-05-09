using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public CrmNumber sgt_aantal_punten
		{
			get
			{
				return this.sgt_aantal_puntenField;
			}
			set
			{
				this.sgt_aantal_puntenField = value;
				base.RaisePropertyChanged("sgt_aantal_punten");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_punten_dubbelspel
		{
			get
			{
				return this.sgt_aantal_punten_dubbelspelField;
			}
			set
			{
				this.sgt_aantal_punten_dubbelspelField = value;
				base.RaisePropertyChanged("sgt_aantal_punten_dubbelspel");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber sgt_aantal_toernooien
		{
			get
			{
				return this.sgt_aantal_toernooienField;
			}
			set
			{
				this.sgt_aantal_toernooienField = value;
				base.RaisePropertyChanged("sgt_aantal_toernooien");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber sgt_aantal_toernooien_dubbelspel
		{
			get
			{
				return this.sgt_aantal_toernooien_dubbelspelField;
			}
			set
			{
				this.sgt_aantal_toernooien_dubbelspelField = value;
				base.RaisePropertyChanged("sgt_aantal_toernooien_dubbelspel");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDecimal sgt_bonuspunten_aantal
		{
			get
			{
				return this.sgt_bonuspunten_aantalField;
			}
			set
			{
				this.sgt_bonuspunten_aantalField = value;
				base.RaisePropertyChanged("sgt_bonuspunten_aantal");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
				base.RaisePropertyChanged("sgt_circuitid");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_circuitranglijst_logboekid
		{
			get
			{
				return this.sgt_circuitranglijst_logboekidField;
			}
			set
			{
				this.sgt_circuitranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_circuitranglijst_logboekid");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_datum_ranglijst
		{
			get
			{
				return this.sgt_datum_ranglijstField;
			}
			set
			{
				this.sgt_datum_ranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_ranglijst");
			}
		}
		[XmlElement(Order = 16)]
		public CrmDecimal sgt_gemiddeld_aantal_punten
		{
			get
			{
				return this.sgt_gemiddeld_aantal_puntenField;
			}
			set
			{
				this.sgt_gemiddeld_aantal_puntenField = value;
				base.RaisePropertyChanged("sgt_gemiddeld_aantal_punten");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDecimal sgt_gemiddeld_aantal_punten_dubbelspel
		{
			get
			{
				return this.sgt_gemiddeld_aantal_punten_dubbelspelField;
			}
			set
			{
				this.sgt_gemiddeld_aantal_punten_dubbelspelField = value;
				base.RaisePropertyChanged("sgt_gemiddeld_aantal_punten_dubbelspel");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_ranglijst_logboekid
		{
			get
			{
				return this.sgt_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_ranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_logboekid");
			}
		}
		[XmlElement(Order = 19)]
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
				base.RaisePropertyChanged("sgt_ranglijstid");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber sgt_ranglijstpositie
		{
			get
			{
				return this.sgt_ranglijstpositieField;
			}
			set
			{
				this.sgt_ranglijstpositieField = value;
				base.RaisePropertyChanged("sgt_ranglijstpositie");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_schaduwranglijst_logboekid
		{
			get
			{
				return this.sgt_schaduwranglijst_logboekidField;
			}
			set
			{
				this.sgt_schaduwranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_schaduwranglijst_logboekid");
			}
		}
		[XmlElement(Order = 22)]
		public string sgt_sorteercode_crm
		{
			get
			{
				return this.sgt_sorteercode_crmField;
			}
			set
			{
				this.sgt_sorteercode_crmField = value;
				base.RaisePropertyChanged("sgt_sorteercode_crm");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}
		[XmlElement("sgt_toe_ranglijstpositie", Order = 24)]
		public string sgt_toe_ranglijstpositie1
		{
			get
			{
				return this.sgt_toe_ranglijstpositie1Field;
			}
			set
			{
				this.sgt_toe_ranglijstpositie1Field = value;
				base.RaisePropertyChanged("sgt_toe_ranglijstpositie1");
			}
		}
		[XmlElement(Order = 25)]
		public Key sgt_toe_ranglijstpositieid
		{
			get
			{
				return this.sgt_toe_ranglijstpositieidField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieidField = value;
				base.RaisePropertyChanged("sgt_toe_ranglijstpositieid");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDecimal sgt_tot_aantal_punten
		{
			get
			{
				return this.sgt_tot_aantal_puntenField;
			}
			set
			{
				this.sgt_tot_aantal_puntenField = value;
				base.RaisePropertyChanged("sgt_tot_aantal_punten");
			}
		}
		[XmlElement(Order = 27)]
		public CrmNumber sgt_vorige_ranglijstpositie
		{
			get
			{
				return this.sgt_vorige_ranglijstpositieField;
			}
			set
			{
				this.sgt_vorige_ranglijstpositieField = value;
				base.RaisePropertyChanged("sgt_vorige_ranglijstpositie");
			}
		}
		[XmlElement(Order = 28)]
		public Sgt_toe_ranglijstpositieStateInfo statecode
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
	}
}
