using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmBoolean sgt_applicatie
		{
			get
			{
				return this.sgt_applicatieField;
			}
			set
			{
				this.sgt_applicatieField = value;
			}
		}
		public CrmMoney sgt_bo_inschrijfgeld
		{
			get
			{
				return this.sgt_bo_inschrijfgeldField;
			}
			set
			{
				this.sgt_bo_inschrijfgeldField = value;
			}
		}
		public CrmMoney sgt_bo_inschrijfgeld_base
		{
			get
			{
				return this.sgt_bo_inschrijfgeld_baseField;
			}
			set
			{
				this.sgt_bo_inschrijfgeld_baseField = value;
			}
		}
		[XmlElement("sgt_bo_opleiding")]
		public string sgt_bo_opleiding1
		{
			get
			{
				return this.sgt_bo_opleiding1Field;
			}
			set
			{
				this.sgt_bo_opleiding1Field = value;
			}
		}
		public Key sgt_bo_opleidingid
		{
			get
			{
				return this.sgt_bo_opleidingidField;
			}
			set
			{
				this.sgt_bo_opleidingidField = value;
			}
		}
		public Lookup sgt_certificaat_controleid
		{
			get
			{
				return this.sgt_certificaat_controleidField;
			}
			set
			{
				this.sgt_certificaat_controleidField = value;
			}
		}
		public Lookup sgt_certificaatid
		{
			get
			{
				return this.sgt_certificaatidField;
			}
			set
			{
				this.sgt_certificaatidField = value;
			}
		}
		public Picklist sgt_factuurindicatie
		{
			get
			{
				return this.sgt_factuurindicatieField;
			}
			set
			{
				this.sgt_factuurindicatieField = value;
			}
		}
		public CrmBoolean sgt_fasevolgorde_afdwingen
		{
			get
			{
				return this.sgt_fasevolgorde_afdwingenField;
			}
			set
			{
				this.sgt_fasevolgorde_afdwingenField = value;
			}
		}
		public string sgt_informatie_mijnknltb
		{
			get
			{
				return this.sgt_informatie_mijnknltbField;
			}
			set
			{
				this.sgt_informatie_mijnknltbField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_knltb_mogelijk
		{
			get
			{
				return this.sgt_inschrijven_knltb_mogelijkField;
			}
			set
			{
				this.sgt_inschrijven_knltb_mogelijkField = value;
			}
		}
		public CrmMoney sgt_kosten_opleiding_overig
		{
			get
			{
				return this.sgt_kosten_opleiding_overigField;
			}
			set
			{
				this.sgt_kosten_opleiding_overigField = value;
			}
		}
		public CrmMoney sgt_kosten_opleiding_overig_base
		{
			get
			{
				return this.sgt_kosten_opleiding_overig_baseField;
			}
			set
			{
				this.sgt_kosten_opleiding_overig_baseField = value;
			}
		}
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
			}
		}
		public Lookup sgt_organisatieid
		{
			get
			{
				return this.sgt_organisatieidField;
			}
			set
			{
				this.sgt_organisatieidField = value;
			}
		}
		public Picklist sgt_soort_opleiding
		{
			get
			{
				return this.sgt_soort_opleidingField;
			}
			set
			{
				this.sgt_soort_opleidingField = value;
			}
		}
		public CrmDateTime sgt_uiterste_betaaldatum_opleiding
		{
			get
			{
				return this.sgt_uiterste_betaaldatum_opleidingField;
			}
			set
			{
				this.sgt_uiterste_betaaldatum_opleidingField = value;
			}
		}
		public CrmDateTime sgt_uiterste_inschrijfdatum_opleiding
		{
			get
			{
				return this.sgt_uiterste_inschrijfdatum_opleidingField;
			}
			set
			{
				this.sgt_uiterste_inschrijfdatum_opleidingField = value;
			}
		}
		public CrmDateTime sgt_uiterste_inschrijfdatum_testdag
		{
			get
			{
				return this.sgt_uiterste_inschrijfdatum_testdagField;
			}
			set
			{
				this.sgt_uiterste_inschrijfdatum_testdagField = value;
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
		public Sgt_bo_opleidingStateInfo statecode
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
