using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sw_lookupcolumn : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Sw_lookupcolumnStateInfo statecodeField;
		private Status statuscodeField;
		private string sw_attributenameField;
		private Picklist sw_databindingField;
		private string sw_formatstringField;
		private Key sw_lookupcolumnidField;
		private Lookup sw_lookupdefinitionidField;
		private CrmNumber sw_sortindexField;
		private string sw_widthField;
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
		public Sw_lookupcolumnStateInfo statecode
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
		public string sw_attributename
		{
			get
			{
				return this.sw_attributenameField;
			}
			set
			{
				this.sw_attributenameField = value;
			}
		}
		public Picklist sw_databinding
		{
			get
			{
				return this.sw_databindingField;
			}
			set
			{
				this.sw_databindingField = value;
			}
		}
		public string sw_formatstring
		{
			get
			{
				return this.sw_formatstringField;
			}
			set
			{
				this.sw_formatstringField = value;
			}
		}
		public Key sw_lookupcolumnid
		{
			get
			{
				return this.sw_lookupcolumnidField;
			}
			set
			{
				this.sw_lookupcolumnidField = value;
			}
		}
		public Lookup sw_lookupdefinitionid
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
		public CrmNumber sw_sortindex
		{
			get
			{
				return this.sw_sortindexField;
			}
			set
			{
				this.sw_sortindexField = value;
			}
		}
		public string sw_width
		{
			get
			{
				return this.sw_widthField;
			}
			set
			{
				this.sw_widthField = value;
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
