using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_mutatie_toernooiuitslag_ps : BusinessEntity
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
		private Picklist sgt_import_exportField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Lookup sgt_pb_to_verwijzing_poule_idField;
		private Lookup sgt_pb_toernooionderdeelverwijzing_idField;
		private Lookup sgt_pb_toernooiverwijzing_idField;
		private CrmNumber sgt_positieField;
		private Lookup sgt_sgt_pb_to_verwijzing_ronde_idField;
		private string sgt_team_idField;
		private Lookup sgt_team_identificatieField;
		private Key sgt_toe_pb_mutatie_toernooiuitslag_psidField;
		private string sgt_toe_volgnummerField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_psStateInfo statecodeField;
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
		public Lookup sgt_pb_to_verwijzing_poule_id
		{
			get
			{
				return this.sgt_pb_to_verwijzing_poule_idField;
			}
			set
			{
				this.sgt_pb_to_verwijzing_poule_idField = value;
			}
		}
		public Lookup sgt_pb_toernooionderdeelverwijzing_id
		{
			get
			{
				return this.sgt_pb_toernooionderdeelverwijzing_idField;
			}
			set
			{
				this.sgt_pb_toernooionderdeelverwijzing_idField = value;
			}
		}
		public Lookup sgt_pb_toernooiverwijzing_id
		{
			get
			{
				return this.sgt_pb_toernooiverwijzing_idField;
			}
			set
			{
				this.sgt_pb_toernooiverwijzing_idField = value;
			}
		}
		public CrmNumber sgt_positie
		{
			get
			{
				return this.sgt_positieField;
			}
			set
			{
				this.sgt_positieField = value;
			}
		}
		public Lookup sgt_sgt_pb_to_verwijzing_ronde_id
		{
			get
			{
				return this.sgt_sgt_pb_to_verwijzing_ronde_idField;
			}
			set
			{
				this.sgt_sgt_pb_to_verwijzing_ronde_idField = value;
			}
		}
		public string sgt_team_id
		{
			get
			{
				return this.sgt_team_idField;
			}
			set
			{
				this.sgt_team_idField = value;
			}
		}
		public Lookup sgt_team_identificatie
		{
			get
			{
				return this.sgt_team_identificatieField;
			}
			set
			{
				this.sgt_team_identificatieField = value;
			}
		}
		public Key sgt_toe_pb_mutatie_toernooiuitslag_psid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_psidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_psidField = value;
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
		public Sgt_toe_pb_mutatie_toernooiuitslag_psStateInfo statecode
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
