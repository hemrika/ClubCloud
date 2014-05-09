using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		public string sgt_aanvullende_informatie
		{
			get
			{
				return this.sgt_aanvullende_informatieField;
			}
			set
			{
				this.sgt_aanvullende_informatieField = value;
				base.RaisePropertyChanged("sgt_aanvullende_informatie");
			}
		}
		[XmlElement("sgt_bo_opleidingsgroep", Order = 10)]
		public string sgt_bo_opleidingsgroep1
		{
			get
			{
				return this.sgt_bo_opleidingsgroep1Field;
			}
			set
			{
				this.sgt_bo_opleidingsgroep1Field = value;
				base.RaisePropertyChanged("sgt_bo_opleidingsgroep1");
			}
		}
		[XmlElement(Order = 11)]
		public Key sgt_bo_opleidingsgroepid
		{
			get
			{
				return this.sgt_bo_opleidingsgroepidField;
			}
			set
			{
				this.sgt_bo_opleidingsgroepidField = value;
				base.RaisePropertyChanged("sgt_bo_opleidingsgroepid");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_ecampus_code
		{
			get
			{
				return this.sgt_ecampus_codeField;
			}
			set
			{
				this.sgt_ecampus_codeField = value;
				base.RaisePropertyChanged("sgt_ecampus_code");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDateTime sgt_ecampus_datum_tm_cursisten
		{
			get
			{
				return this.sgt_ecampus_datum_tm_cursistenField;
			}
			set
			{
				this.sgt_ecampus_datum_tm_cursistenField = value;
				base.RaisePropertyChanged("sgt_ecampus_datum_tm_cursisten");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDateTime sgt_ecampus_datum_vanaf_cursisten
		{
			get
			{
				return this.sgt_ecampus_datum_vanaf_cursistenField;
			}
			set
			{
				this.sgt_ecampus_datum_vanaf_cursistenField = value;
				base.RaisePropertyChanged("sgt_ecampus_datum_vanaf_cursisten");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
				base.RaisePropertyChanged("sgt_einddatum");
			}
		}
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
		public Lookup sgt_lokatieid
		{
			get
			{
				return this.sgt_lokatieidField;
			}
			set
			{
				this.sgt_lokatieidField = value;
				base.RaisePropertyChanged("sgt_lokatieid");
			}
		}
		[XmlElement(Order = 19)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}
		[XmlElement(Order = 20)]
		public Picklist sgt_opleidingsdag
		{
			get
			{
				return this.sgt_opleidingsdagField;
			}
			set
			{
				this.sgt_opleidingsdagField = value;
				base.RaisePropertyChanged("sgt_opleidingsdag");
			}
		}
		[XmlElement(Order = 21)]
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
				base.RaisePropertyChanged("sgt_plaats");
			}
		}
		[XmlElement(Order = 22)]
		public CrmDateTime sgt_startdatum
		{
			get
			{
				return this.sgt_startdatumField;
			}
			set
			{
				this.sgt_startdatumField = value;
				base.RaisePropertyChanged("sgt_startdatum");
			}
		}
		[XmlElement(Order = 23)]
		public Sgt_bo_opleidingsgroepStateInfo statecode
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
