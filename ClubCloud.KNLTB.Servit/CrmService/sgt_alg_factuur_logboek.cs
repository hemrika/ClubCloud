using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_factuur_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_administratieidField;
		private Key sgt_alg_factuur_logboekidField;
		private string sgt_alg_lognummerField;
		private CrmBoolean sgt_automatisch_gestartField;
		private CrmDateTime sgt_betalingen_vanafField;
		private Picklist sgt_debiteuren_exportField;
		private CrmDateTime sgt_exporteren_tm_datumField;
		private CrmDateTime sgt_exporteren_vanaf_datumField;
		private string sgt_omschrijvingField;
		private Picklist sgt_soortField;
		private Picklist sgt_statusField;
		private Sgt_alg_factuur_logboekStateInfo statecodeField;
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
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
			}
		}
		public Key sgt_alg_factuur_logboekid
		{
			get
			{
				return this.sgt_alg_factuur_logboekidField;
			}
			set
			{
				this.sgt_alg_factuur_logboekidField = value;
			}
		}
		public string sgt_alg_lognummer
		{
			get
			{
				return this.sgt_alg_lognummerField;
			}
			set
			{
				this.sgt_alg_lognummerField = value;
			}
		}
		public CrmBoolean sgt_automatisch_gestart
		{
			get
			{
				return this.sgt_automatisch_gestartField;
			}
			set
			{
				this.sgt_automatisch_gestartField = value;
			}
		}
		public CrmDateTime sgt_betalingen_vanaf
		{
			get
			{
				return this.sgt_betalingen_vanafField;
			}
			set
			{
				this.sgt_betalingen_vanafField = value;
			}
		}
		public Picklist sgt_debiteuren_export
		{
			get
			{
				return this.sgt_debiteuren_exportField;
			}
			set
			{
				this.sgt_debiteuren_exportField = value;
			}
		}
		public CrmDateTime sgt_exporteren_tm_datum
		{
			get
			{
				return this.sgt_exporteren_tm_datumField;
			}
			set
			{
				this.sgt_exporteren_tm_datumField = value;
			}
		}
		public CrmDateTime sgt_exporteren_vanaf_datum
		{
			get
			{
				return this.sgt_exporteren_vanaf_datumField;
			}
			set
			{
				this.sgt_exporteren_vanaf_datumField = value;
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
		public Picklist sgt_soort
		{
			get
			{
				return this.sgt_soortField;
			}
			set
			{
				this.sgt_soortField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public Sgt_alg_factuur_logboekStateInfo statecode
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
