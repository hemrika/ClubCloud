using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_opleidingsgroep : BusinessEntity
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
		private string sgt_aanvullende_informatieField;
		private string sgt_bo_opleidingsgroep1Field;
		private Key sgt_bo_opleidingsgroepidField;
		private string sgt_ecampus_codeField;
		private CrmDateTime sgt_ecampus_datum_tm_cursistenField;
		private CrmDateTime sgt_ecampus_datum_vanaf_cursistenField;
		private CrmDateTime sgt_einddatumField;
		private CrmMoney sgt_kosten_opleiding_overigField;
		private CrmMoney sgt_kosten_opleiding_overig_baseField;
		private Lookup sgt_lokatieidField;
		private Lookup sgt_opleidingidField;
		private Picklist sgt_opleidingsdagField;
		private string sgt_plaatsField;
		private CrmDateTime sgt_startdatumField;
		private Sgt_bo_opleidingsgroepStateInfo statecodeField;
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
		public string sgt_aanvullende_informatie
		{
			get
			{
				return this.sgt_aanvullende_informatieField;
			}
			set
			{
				this.sgt_aanvullende_informatieField = value;
			}
		}
		[XmlElement("sgt_bo_opleidingsgroep")]
		public string sgt_bo_opleidingsgroep1
		{
			get
			{
				return this.sgt_bo_opleidingsgroep1Field;
			}
			set
			{
				this.sgt_bo_opleidingsgroep1Field = value;
			}
		}
		public Key sgt_bo_opleidingsgroepid
		{
			get
			{
				return this.sgt_bo_opleidingsgroepidField;
			}
			set
			{
				this.sgt_bo_opleidingsgroepidField = value;
			}
		}
		public string sgt_ecampus_code
		{
			get
			{
				return this.sgt_ecampus_codeField;
			}
			set
			{
				this.sgt_ecampus_codeField = value;
			}
		}
		public CrmDateTime sgt_ecampus_datum_tm_cursisten
		{
			get
			{
				return this.sgt_ecampus_datum_tm_cursistenField;
			}
			set
			{
				this.sgt_ecampus_datum_tm_cursistenField = value;
			}
		}
		public CrmDateTime sgt_ecampus_datum_vanaf_cursisten
		{
			get
			{
				return this.sgt_ecampus_datum_vanaf_cursistenField;
			}
			set
			{
				this.sgt_ecampus_datum_vanaf_cursistenField = value;
			}
		}
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
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
		public Lookup sgt_lokatieid
		{
			get
			{
				return this.sgt_lokatieidField;
			}
			set
			{
				this.sgt_lokatieidField = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public Picklist sgt_opleidingsdag
		{
			get
			{
				return this.sgt_opleidingsdagField;
			}
			set
			{
				this.sgt_opleidingsdagField = value;
			}
		}
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
			}
		}
		public CrmDateTime sgt_startdatum
		{
			get
			{
				return this.sgt_startdatumField;
			}
			set
			{
				this.sgt_startdatumField = value;
			}
		}
		public Sgt_bo_opleidingsgroepStateInfo statecode
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
