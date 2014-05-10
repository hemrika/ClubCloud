using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_functionele_log : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_functionele_logidField;
		private string sgt_boodschapField;
		private CrmDateTime sgt_datum_tijdField;
		private string sgt_entiteit_idField;
		private string sgt_entiteit_naamField;
		private string sgt_extra_informatieField;
		private string sgt_functie_naamField;
		private Picklist sgt_levelField;
		private string sgt_proces_idField;
		private string sgt_volgnummerField;
		private Sgt_alg_functionele_logStateInfo statecodeField;
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
		public Key sgt_alg_functionele_logid
		{
			get
			{
				return this.sgt_alg_functionele_logidField;
			}
			set
			{
				this.sgt_alg_functionele_logidField = value;
			}
		}
		public string sgt_boodschap
		{
			get
			{
				return this.sgt_boodschapField;
			}
			set
			{
				this.sgt_boodschapField = value;
			}
		}
		public CrmDateTime sgt_datum_tijd
		{
			get
			{
				return this.sgt_datum_tijdField;
			}
			set
			{
				this.sgt_datum_tijdField = value;
			}
		}
		public string sgt_entiteit_id
		{
			get
			{
				return this.sgt_entiteit_idField;
			}
			set
			{
				this.sgt_entiteit_idField = value;
			}
		}
		public string sgt_entiteit_naam
		{
			get
			{
				return this.sgt_entiteit_naamField;
			}
			set
			{
				this.sgt_entiteit_naamField = value;
			}
		}
		public string sgt_extra_informatie
		{
			get
			{
				return this.sgt_extra_informatieField;
			}
			set
			{
				this.sgt_extra_informatieField = value;
			}
		}
		public string sgt_functie_naam
		{
			get
			{
				return this.sgt_functie_naamField;
			}
			set
			{
				this.sgt_functie_naamField = value;
			}
		}
		public Picklist sgt_level
		{
			get
			{
				return this.sgt_levelField;
			}
			set
			{
				this.sgt_levelField = value;
			}
		}
		public string sgt_proces_id
		{
			get
			{
				return this.sgt_proces_idField;
			}
			set
			{
				this.sgt_proces_idField = value;
			}
		}
		public string sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
			}
		}
		public Sgt_alg_functionele_logStateInfo statecode
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
