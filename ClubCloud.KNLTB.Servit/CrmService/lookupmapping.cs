using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class lookupmapping : BusinessEntity
	{
		private Lookup columnmappingidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string lookupattributenameField;
		private string lookupentitynameField;
		private Key lookupmappingidField;
		private Picklist lookupsourcecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Picklist processcodeField;
		private LookUpMappingStateInfo statecodeField;
		private Status statuscodeField;
		private Lookup transformationparametermappingidField;
		public Lookup columnmappingid
		{
			get
			{
				return this.columnmappingidField;
			}
			set
			{
				this.columnmappingidField = value;
			}
		}
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
		public string lookupattributename
		{
			get
			{
				return this.lookupattributenameField;
			}
			set
			{
				this.lookupattributenameField = value;
			}
		}
		public string lookupentityname
		{
			get
			{
				return this.lookupentitynameField;
			}
			set
			{
				this.lookupentitynameField = value;
			}
		}
		public Key lookupmappingid
		{
			get
			{
				return this.lookupmappingidField;
			}
			set
			{
				this.lookupmappingidField = value;
			}
		}
		public Picklist lookupsourcecode
		{
			get
			{
				return this.lookupsourcecodeField;
			}
			set
			{
				this.lookupsourcecodeField = value;
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
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
			}
		}
		public LookUpMappingStateInfo statecode
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
		public Lookup transformationparametermappingid
		{
			get
			{
				return this.transformationparametermappingidField;
			}
			set
			{
				this.transformationparametermappingidField = value;
			}
		}
	}
}
