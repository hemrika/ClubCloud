using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class transformationmapping : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Lookup importmapidField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Picklist processcodeField;
		private string sourceentitynameField;
		private TransformationMappingStateInfo statecodeField;
		private Status statuscodeField;
		private string targetentitynameField;
		private Key transformationmappingidField;
		private string transformationtypenameField;
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
		public Lookup importmapid
		{
			get
			{
				return this.importmapidField;
			}
			set
			{
				this.importmapidField = value;
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
		public string sourceentityname
		{
			get
			{
				return this.sourceentitynameField;
			}
			set
			{
				this.sourceentitynameField = value;
			}
		}
		public TransformationMappingStateInfo statecode
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
		public string targetentityname
		{
			get
			{
				return this.targetentitynameField;
			}
			set
			{
				this.targetentitynameField = value;
			}
		}
		public Key transformationmappingid
		{
			get
			{
				return this.transformationmappingidField;
			}
			set
			{
				this.transformationmappingidField = value;
			}
		}
		public string transformationtypename
		{
			get
			{
				return this.transformationtypenameField;
			}
			set
			{
				this.transformationtypenameField = value;
			}
		}
	}
}
