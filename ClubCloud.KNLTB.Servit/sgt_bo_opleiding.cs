using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_opleiding : BusinessEntity
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
		private CrmNumber sgt_aantal_puntenField;
		private CrmBoolean sgt_applicatieField;
		private CrmMoney sgt_bo_inschrijfgeldField;
		private CrmMoney sgt_bo_inschrijfgeld_baseField;
		private string sgt_bo_opleiding1Field;
		private Key sgt_bo_opleidingidField;
		private Lookup sgt_certificaat_controleidField;
		private Lookup sgt_certificaatidField;
		private Picklist sgt_factuurindicatieField;
		private CrmBoolean sgt_fasevolgorde_afdwingenField;
		private string sgt_informatie_mijnknltbField;
		private CrmBoolean sgt_inschrijven_knltb_mogelijkField;
		private CrmMoney sgt_kosten_opleiding_overigField;
		private CrmMoney sgt_kosten_opleiding_overig_baseField;
		private Lookup sgt_licentieidField;
		private Lookup sgt_organisatieidField;
		private Picklist sgt_soort_opleidingField;
		private CrmDateTime sgt_uiterste_betaaldatum_opleidingField;
		private CrmDateTime sgt_uiterste_inschrijfdatum_opleidingField;
		private CrmDateTime sgt_uiterste_inschrijfdatum_testdagField;
		private string sgt_verkorte_codeField;
		private Sgt_bo_opleidingStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_applicatie
		{
			get
			{
				return this.sgt_applicatieField;
			}
			set
			{
				this.sgt_applicatieField = value;
				base.RaisePropertyChanged("sgt_applicatie");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney sgt_bo_inschrijfgeld
		{
			get
			{
				return this.sgt_bo_inschrijfgeldField;
			}
			set
			{
				this.sgt_bo_inschrijfgeldField = value;
				base.RaisePropertyChanged("sgt_bo_inschrijfgeld");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney sgt_bo_inschrijfgeld_base
		{
			get
			{
				return this.sgt_bo_inschrijfgeld_baseField;
			}
			set
			{
				this.sgt_bo_inschrijfgeld_baseField = value;
				base.RaisePropertyChanged("sgt_bo_inschrijfgeld_base");
			}
		}
		[XmlElement("sgt_bo_opleiding", Order = 13)]
		public string sgt_bo_opleiding1
		{
			get
			{
				return this.sgt_bo_opleiding1Field;
			}
			set
			{
				this.sgt_bo_opleiding1Field = value;
				base.RaisePropertyChanged("sgt_bo_opleiding1");
			}
		}
		[XmlElement(Order = 14)]
		public Key sgt_bo_opleidingid
		{
			get
			{
				return this.sgt_bo_opleidingidField;
			}
			set
			{
				this.sgt_bo_opleidingidField = value;
				base.RaisePropertyChanged("sgt_bo_opleidingid");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_certificaat_controleid
		{
			get
			{
				return this.sgt_certificaat_controleidField;
			}
			set
			{
				this.sgt_certificaat_controleidField = value;
				base.RaisePropertyChanged("sgt_certificaat_controleid");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_certificaatid
		{
			get
			{
				return this.sgt_certificaatidField;
			}
			set
			{
				this.sgt_certificaatidField = value;
				base.RaisePropertyChanged("sgt_certificaatid");
			}
		}
		[XmlElement(Order = 17)]
		public Picklist sgt_factuurindicatie
		{
			get
			{
				return this.sgt_factuurindicatieField;
			}
			set
			{
				this.sgt_factuurindicatieField = value;
				base.RaisePropertyChanged("sgt_factuurindicatie");
			}
		}
		[XmlElement(Order = 18)]
		public CrmBoolean sgt_fasevolgorde_afdwingen
		{
			get
			{
				return this.sgt_fasevolgorde_afdwingenField;
			}
			set
			{
				this.sgt_fasevolgorde_afdwingenField = value;
				base.RaisePropertyChanged("sgt_fasevolgorde_afdwingen");
			}
		}
		[XmlElement(Order = 19)]
		public string sgt_informatie_mijnknltb
		{
			get
			{
				return this.sgt_informatie_mijnknltbField;
			}
			set
			{
				this.sgt_informatie_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_informatie_mijnknltb");
			}
		}
		[XmlElement(Order = 20)]
		public CrmBoolean sgt_inschrijven_knltb_mogelijk
		{
			get
			{
				return this.sgt_inschrijven_knltb_mogelijkField;
			}
			set
			{
				this.sgt_inschrijven_knltb_mogelijkField = value;
				base.RaisePropertyChanged("sgt_inschrijven_knltb_mogelijk");
			}
		}
		[XmlElement(Order = 21)]
		public CrmMoney sgt_kosten_opleiding_overig
		{
			get
			{
				return this.sgt_kosten_opleiding_overigField;
			}
			set
			{
				this.sgt_kosten_opleiding_overigField = value;
				base.RaisePropertyChanged("sgt_kosten_opleiding_overig");
			}
		}
		[XmlElement(Order = 22)]
		public CrmMoney sgt_kosten_opleiding_overig_base
		{
			get
			{
				return this.sgt_kosten_opleiding_overig_baseField;
			}
			set
			{
				this.sgt_kosten_opleiding_overig_baseField = value;
				base.RaisePropertyChanged("sgt_kosten_opleiding_overig_base");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
				base.RaisePropertyChanged("sgt_licentieid");
			}
		}
		[XmlElement(Order = 24)]
		public Lookup sgt_organisatieid
		{
			get
			{
				return this.sgt_organisatieidField;
			}
			set
			{
				this.sgt_organisatieidField = value;
				base.RaisePropertyChanged("sgt_organisatieid");
			}
		}
		[XmlElement(Order = 25)]
		public Picklist sgt_soort_opleiding
		{
			get
			{
				return this.sgt_soort_opleidingField;
			}
			set
			{
				this.sgt_soort_opleidingField = value;
				base.RaisePropertyChanged("sgt_soort_opleiding");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDateTime sgt_uiterste_betaaldatum_opleiding
		{
			get
			{
				return this.sgt_uiterste_betaaldatum_opleidingField;
			}
			set
			{
				this.sgt_uiterste_betaaldatum_opleidingField = value;
				base.RaisePropertyChanged("sgt_uiterste_betaaldatum_opleiding");
			}
		}
		[XmlElement(Order = 27)]
		public CrmDateTime sgt_uiterste_inschrijfdatum_opleiding
		{
			get
			{
				return this.sgt_uiterste_inschrijfdatum_opleidingField;
			}
			set
			{
				this.sgt_uiterste_inschrijfdatum_opleidingField = value;
				base.RaisePropertyChanged("sgt_uiterste_inschrijfdatum_opleiding");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDateTime sgt_uiterste_inschrijfdatum_testdag
		{
			get
			{
				return this.sgt_uiterste_inschrijfdatum_testdagField;
			}
			set
			{
				this.sgt_uiterste_inschrijfdatum_testdagField = value;
				base.RaisePropertyChanged("sgt_uiterste_inschrijfdatum_testdag");
			}
		}
		[XmlElement(Order = 29)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}
		[XmlElement(Order = 30)]
		public Sgt_bo_opleidingStateInfo statecode
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
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
