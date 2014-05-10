using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_mutatie_toernooiuitslag_to : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private CrmDateTime sgt_datum_opnieuw_verwerktField;
		private Picklist sgt_geslachtField;
		private CrmBoolean sgt_herstart_mogelijkField;
		private Picklist sgt_import_exportField;
		private CrmNumber sgt_leeftijd_tot_en_metField;
		private CrmNumber sgt_leeftijd_vanafField;
		private string sgt_onderdeel_idField;
		private string sgt_onderdeel_naamField;
		private CrmBoolean sgt_opnieuw_verwerkenField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Lookup sgt_pb_uitslag_toernooiverwijzing_idField;
		private Picklist sgt_speelsterkteField;
		private Picklist sgt_spelsoortField;
		private Key sgt_toe_pb_mutatie_toernooiuitslag_toidField;
		private string sgt_toe_volgnummerField;
		private CrmBoolean sgt_verwerkenField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_toStateInfo statecodeField;
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
		public CrmDateTime sgt_datum_mutatie_verwerkt
		{
			get
			{
				return this.sgt_datum_mutatie_verwerktField;
			}
			set
			{
				this.sgt_datum_mutatie_verwerktField = value;
			}
		}
		public CrmDateTime sgt_datum_opnieuw_verwerkt
		{
			get
			{
				return this.sgt_datum_opnieuw_verwerktField;
			}
			set
			{
				this.sgt_datum_opnieuw_verwerktField = value;
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
		public CrmBoolean sgt_herstart_mogelijk
		{
			get
			{
				return this.sgt_herstart_mogelijkField;
			}
			set
			{
				this.sgt_herstart_mogelijkField = value;
			}
		}
		public Picklist sgt_import_export
		{
			get
			{
				return this.sgt_import_exportField;
			}
			set
			{
				this.sgt_import_exportField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met
		{
			get
			{
				return this.sgt_leeftijd_tot_en_metField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_metField = value;
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
		public string sgt_onderdeel_id
		{
			get
			{
				return this.sgt_onderdeel_idField;
			}
			set
			{
				this.sgt_onderdeel_idField = value;
			}
		}
		public string sgt_onderdeel_naam
		{
			get
			{
				return this.sgt_onderdeel_naamField;
			}
			set
			{
				this.sgt_onderdeel_naamField = value;
			}
		}
		public CrmBoolean sgt_opnieuw_verwerken
		{
			get
			{
				return this.sgt_opnieuw_verwerkenField;
			}
			set
			{
				this.sgt_opnieuw_verwerkenField = value;
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
		public Lookup sgt_pb_uitslag_toernooiverwijzing_id
		{
			get
			{
				return this.sgt_pb_uitslag_toernooiverwijzing_idField;
			}
			set
			{
				this.sgt_pb_uitslag_toernooiverwijzing_idField = value;
			}
		}
		public Picklist sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
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
		public Key sgt_toe_pb_mutatie_toernooiuitslag_toid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_toidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_toidField = value;
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
		public CrmBoolean sgt_verwerken
		{
			get
			{
				return this.sgt_verwerkenField;
			}
			set
			{
				this.sgt_verwerkenField = value;
			}
		}
		public Sgt_toe_pb_mutatie_toernooiuitslag_toStateInfo statecode
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
