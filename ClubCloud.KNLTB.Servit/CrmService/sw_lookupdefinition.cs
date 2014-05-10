using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sw_lookupdefinition : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Sw_lookupdefinitionStateInfo statecodeField;
		private Status statuscodeField;
		private string sw_classField;
		private string sw_descriptionField;
		private string sw_displaynameField;
		private string sw_entitytypeField;
		private Key sw_lookupdefinitionidField;
		private Lookup sw_queryidField;
		private string sw_searchfieldsField;
		private Picklist sw_tracingField;
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
		public Sw_lookupdefinitionStateInfo statecode
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
		public string sw_class
		{
			get
			{
				return this.sw_classField;
			}
			set
			{
				this.sw_classField = value;
			}
		}
		public string sw_description
		{
			get
			{
				return this.sw_descriptionField;
			}
			set
			{
				this.sw_descriptionField = value;
			}
		}
		public string sw_displayname
		{
			get
			{
				return this.sw_displaynameField;
			}
			set
			{
				this.sw_displaynameField = value;
			}
		}
		public string sw_entitytype
		{
			get
			{
				return this.sw_entitytypeField;
			}
			set
			{
				this.sw_entitytypeField = value;
			}
		}
		public Key sw_lookupdefinitionid
		{
			get
			{
				return this.sw_lookupdefinitionidField;
			}
			set
			{
				this.sw_lookupdefinitionidField = value;
			}
		}
		public Lookup sw_queryid
		{
			get
			{
				return this.sw_queryidField;
			}
			set
			{
				this.sw_queryidField = value;
			}
		}
		public string sw_searchfields
		{
			get
			{
				return this.sw_searchfieldsField;
			}
			set
			{
				this.sw_searchfieldsField = value;
			}
		}
		public Picklist sw_tracing
		{
			get
			{
				return this.sw_tracingField;
			}
			set
			{
				this.sw_tracingField = value;
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
