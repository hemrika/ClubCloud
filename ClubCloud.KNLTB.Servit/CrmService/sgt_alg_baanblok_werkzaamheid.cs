using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_baanblok_werkzaamheid : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accommodatie_idField;
		private Key sgt_alg_baanblok_werkzaamheididField;
		private string sgt_alg_nameField;
		private Lookup sgt_baanblokidField;
		private string sgt_beschrijvingField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private string sgt_nieuwe_baansoortField;
		private Picklist sgt_soort_werkzaamheidField;
		private Lookup sgt_uitvoerende_idField;
		private Sgt_alg_baanblok_werkzaamheidStateInfo statecodeField;
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
		public Lookup sgt_accommodatie_id
		{
			get
			{
				return this.sgt_accommodatie_idField;
			}
			set
			{
				this.sgt_accommodatie_idField = value;
			}
		}
		public Key sgt_alg_baanblok_werkzaamheidid
		{
			get
			{
				return this.sgt_alg_baanblok_werkzaamheididField;
			}
			set
			{
				this.sgt_alg_baanblok_werkzaamheididField = value;
			}
		}
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
			}
		}
		public Lookup sgt_baanblokid
		{
			get
			{
				return this.sgt_baanblokidField;
			}
			set
			{
				this.sgt_baanblokidField = value;
			}
		}
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
			}
		}
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
			}
		}
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
			}
		}
		public string sgt_nieuwe_baansoort
		{
			get
			{
				return this.sgt_nieuwe_baansoortField;
			}
			set
			{
				this.sgt_nieuwe_baansoortField = value;
			}
		}
		public Picklist sgt_soort_werkzaamheid
		{
			get
			{
				return this.sgt_soort_werkzaamheidField;
			}
			set
			{
				this.sgt_soort_werkzaamheidField = value;
			}
		}
		public Lookup sgt_uitvoerende_id
		{
			get
			{
				return this.sgt_uitvoerende_idField;
			}
			set
			{
				this.sgt_uitvoerende_idField = value;
			}
		}
		public Sgt_alg_baanblok_werkzaamheidStateInfo statecode
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
