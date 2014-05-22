using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_record_lock : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_nameField;
		private Key sgt_alg_record_lockidField;
		private string sgt_entity_idField;
		private string sgt_entity_nameField;
		private Picklist sgt_locktypeField;
		private string sgt_process_idField;
		private string sgt_process_nameField;
		private CrmDateTime sgt_timestampField;
		private Sgt_alg_record_lockStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public Key sgt_alg_record_lockid
		{
			get
			{
				return this.sgt_alg_record_lockidField;
			}
			set
			{
				this.sgt_alg_record_lockidField = value;
			}
		}
		public string sgt_entity_id
		{
			get
			{
				return this.sgt_entity_idField;
			}
			set
			{
				this.sgt_entity_idField = value;
			}
		}
		public string sgt_entity_name
		{
			get
			{
				return this.sgt_entity_nameField;
			}
			set
			{
				this.sgt_entity_nameField = value;
			}
		}
		public Picklist sgt_locktype
		{
			get
			{
				return this.sgt_locktypeField;
			}
			set
			{
				this.sgt_locktypeField = value;
			}
		}
		public string sgt_process_id
		{
			get
			{
				return this.sgt_process_idField;
			}
			set
			{
				this.sgt_process_idField = value;
			}
		}
		public string sgt_process_name
		{
			get
			{
				return this.sgt_process_nameField;
			}
			set
			{
				this.sgt_process_nameField = value;
			}
		}
		public CrmDateTime sgt_timestamp
		{
			get
			{
				return this.sgt_timestampField;
			}
			set
			{
				this.sgt_timestampField = value;
			}
		}
		public Sgt_alg_record_lockStateInfo statecode
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