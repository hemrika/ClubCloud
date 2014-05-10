using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sw_retrievequery : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Sw_retrievequeryStateInfo statecodeField;
		private Status statuscodeField;
		private string sw_classField;
		private string sw_descriptionField;
		private string sw_entitytypeField;
		private string sw_nameField;
		private string sw_providertypeField;
		private string sw_queryField;
		private Key sw_retrievequeryidField;
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
		public Sw_retrievequeryStateInfo statecode
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
		public string sw_name
		{
			get
			{
				return this.sw_nameField;
			}
			set
			{
				this.sw_nameField = value;
			}
		}
		public string sw_providertype
		{
			get
			{
				return this.sw_providertypeField;
			}
			set
			{
				this.sw_providertypeField = value;
			}
		}
		public string sw_query
		{
			get
			{
				return this.sw_queryField;
			}
			set
			{
				this.sw_queryField = value;
			}
		}
		public Key sw_retrievequeryid
		{
			get
			{
				return this.sw_retrievequeryidField;
			}
			set
			{
				this.sw_retrievequeryidField = value;
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
