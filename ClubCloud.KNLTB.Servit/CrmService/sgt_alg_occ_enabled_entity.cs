using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_occ_enabled_entity : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_nameField;
		private Key sgt_alg_occ_enabled_entityidField;
		private string sgt_entity_nameField;
		private CrmBoolean sgt_fail_on_errorField;
		private string sgt_id_attribute_nameField;
		private string sgt_timestamp_attribute_nameField;
		private Sgt_alg_occ_enabled_entityStateInfo statecodeField;
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
		public Key sgt_alg_occ_enabled_entityid
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityidField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityidField = value;
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
		public CrmBoolean sgt_fail_on_error
		{
			get
			{
				return this.sgt_fail_on_errorField;
			}
			set
			{
				this.sgt_fail_on_errorField = value;
			}
		}
		public string sgt_id_attribute_name
		{
			get
			{
				return this.sgt_id_attribute_nameField;
			}
			set
			{
				this.sgt_id_attribute_nameField = value;
			}
		}
		public string sgt_timestamp_attribute_name
		{
			get
			{
				return this.sgt_timestamp_attribute_nameField;
			}
			set
			{
				this.sgt_timestamp_attribute_nameField = value;
			}
		}
		public Sgt_alg_occ_enabled_entityStateInfo statecode
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
