using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_pbmutatietoernooidefinitieonderdeel : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist sgt_geslachtField;
		private CrmNumber sgt_leeftijd_tmField;
		private CrmNumber sgt_leeftijd_vanafField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Key sgt_pbmutatietoernooidefinitieonderdeelidField;
		private Lookup sgt_schemasoort_idField;
		private string sgt_sleutel_toernooipakketField;
		private Lookup sgt_speelsterkte_idField;
		private Picklist sgt_spelsoortField;
		private string sgt_statusField;
		private string sgt_toe_volgnummerField;
		private Lookup sgt_toernooi_verwijzing_idField;
		private Lookup sgt_toernooionderdeel_idField;
		private Sgt_pbmutatietoernooidefinitieonderdeelStateInfo statecodeField;
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
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
			}
		}
		public Lookup sgt_pb_itf_log_toernooien_id
		{
			get
			{
				return this.sgt_pb_itf_log_toernooien_idField;
			}
			set
			{
				this.sgt_pb_itf_log_toernooien_idField = value;
			}
		}
		public Key sgt_pbmutatietoernooidefinitieonderdeelid
		{
			get
			{
				return this.sgt_pbmutatietoernooidefinitieonderdeelidField;
			}
			set
			{
				this.sgt_pbmutatietoernooidefinitieonderdeelidField = value;
			}
		}
		public Lookup sgt_schemasoort_id
		{
			get
			{
				return this.sgt_schemasoort_idField;
			}
			set
			{
				this.sgt_schemasoort_idField = value;
			}
		}
		public string sgt_sleutel_toernooipakket
		{
			get
			{
				return this.sgt_sleutel_toernooipakketField;
			}
			set
			{
				this.sgt_sleutel_toernooipakketField = value;
			}
		}
		public Lookup sgt_speelsterkte_id
		{
			get
			{
				return this.sgt_speelsterkte_idField;
			}
			set
			{
				this.sgt_speelsterkte_idField = value;
			}
		}
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
			}
		}
		public string sgt_status
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
		public string sgt_toe_volgnummer
		{
			get
			{
				return this.sgt_toe_volgnummerField;
			}
			set
			{
				this.sgt_toe_volgnummerField = value;
			}
		}
		public Lookup sgt_toernooi_verwijzing_id
		{
			get
			{
				return this.sgt_toernooi_verwijzing_idField;
			}
			set
			{
				this.sgt_toernooi_verwijzing_idField = value;
			}
		}
		public Lookup sgt_toernooionderdeel_id
		{
			get
			{
				return this.sgt_toernooionderdeel_idField;
			}
			set
			{
				this.sgt_toernooionderdeel_idField = value;
			}
		}
		public Sgt_pbmutatietoernooidefinitieonderdeelStateInfo statecode
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
