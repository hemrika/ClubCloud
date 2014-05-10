using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class transformationparametermapping : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string dataField;
		private Picklist datatypecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmNumber parameterarrayindexField;
		private CrmNumber parametersequenceField;
		private Picklist parametertypecodeField;
		private Lookup transformationmappingidField;
		private Key transformationparametermappingidField;
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
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}
		public Picklist datatypecode
		{
			get
			{
				return this.datatypecodeField;
			}
			set
			{
				this.datatypecodeField = value;
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
		public CrmNumber parameterarrayindex
		{
			get
			{
				return this.parameterarrayindexField;
			}
			set
			{
				this.parameterarrayindexField = value;
			}
		}
		public CrmNumber parametersequence
		{
			get
			{
				return this.parametersequenceField;
			}
			set
			{
				this.parametersequenceField = value;
			}
		}
		public Picklist parametertypecode
		{
			get
			{
				return this.parametertypecodeField;
			}
			set
			{
				this.parametertypecodeField = value;
			}
		}
		public Lookup transformationmappingid
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
		public Key transformationparametermappingid
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
