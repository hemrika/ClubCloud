using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_autorisatie_entiteit_gekoppeld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_autorisatie_attibuteField;
		private Key sgt_autorisatie_entiteit_gekoppeldidField;
		private string sgt_autorisatie_entity_gekoppeldField;
		private Lookup sgt_autorisatie_entityidField;
		private CrmNumber sgt_grantrightsField;
		private string sgt_nameField;
		private Sgt_autorisatie_entiteit_gekoppeldStateInfo statecodeField;
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
		public string sgt_autorisatie_attibute
		{
			get
			{
				return this.sgt_autorisatie_attibuteField;
			}
			set
			{
				this.sgt_autorisatie_attibuteField = value;
			}
		}
		public Key sgt_autorisatie_entiteit_gekoppeldid
		{
			get
			{
				return this.sgt_autorisatie_entiteit_gekoppeldidField;
			}
			set
			{
				this.sgt_autorisatie_entiteit_gekoppeldidField = value;
			}
		}
		public string sgt_autorisatie_entity_gekoppeld
		{
			get
			{
				return this.sgt_autorisatie_entity_gekoppeldField;
			}
			set
			{
				this.sgt_autorisatie_entity_gekoppeldField = value;
			}
		}
		public Lookup sgt_autorisatie_entityid
		{
			get
			{
				return this.sgt_autorisatie_entityidField;
			}
			set
			{
				this.sgt_autorisatie_entityidField = value;
			}
		}
		public CrmNumber sgt_grantrights
		{
			get
			{
				return this.sgt_grantrightsField;
			}
			set
			{
				this.sgt_grantrightsField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public Sgt_autorisatie_entiteit_gekoppeldStateInfo statecode
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
