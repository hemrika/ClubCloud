using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_mutatie_toernooiuitslag_poule : BusinessEntity
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
		private Lookup sgt_gt_pb_toernooiverwijzing_idField;
		private Picklist sgt_import_exportField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Lookup sgt_pb_to_verwijzing_ronde_idField;
		private Lookup sgt_pb_toernooionderdeelverwijzing_idField;
		private string sgt_poule_naamField;
		private Key sgt_toe_pb_mutatie_toernooiuitslag_pouleidField;
		private string sgt_toe_volgnummerField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_pouleStateInfo statecodeField;
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
		public Lookup sgt_gt_pb_toernooiverwijzing_id
		{
			get
			{
				return this.sgt_gt_pb_toernooiverwijzing_idField;
			}
			set
			{
				this.sgt_gt_pb_toernooiverwijzing_idField = value;
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
		public Lookup sgt_pb_to_verwijzing_ronde_id
		{
			get
			{
				return this.sgt_pb_to_verwijzing_ronde_idField;
			}
			set
			{
				this.sgt_pb_to_verwijzing_ronde_idField = value;
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
		public string sgt_poule_naam
		{
			get
			{
				return this.sgt_poule_naamField;
			}
			set
			{
				this.sgt_poule_naamField = value;
			}
		}
		public Key sgt_toe_pb_mutatie_toernooiuitslag_pouleid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_pouleidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_pouleidField = value;
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
		public Sgt_toe_pb_mutatie_toernooiuitslag_pouleStateInfo statecode
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
