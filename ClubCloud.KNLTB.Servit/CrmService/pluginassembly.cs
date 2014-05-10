using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class pluginassembly : BusinessEntity
	{
		private string contentField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string cultureField;
		private CrmNumber customizationlevelField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private string pathField;
		private Key pluginassemblyidField;
		private UniqueIdentifier pluginassemblyiduniqueField;
		private string publickeytokenField;
		private string sourcehashField;
		private Picklist sourcetypeField;
		private string versionField;
		public string content
		{
			get
			{
				return this.contentField;
			}
			set
			{
				this.contentField = value;
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
		public string culture
		{
			get
			{
				return this.cultureField;
			}
			set
			{
				this.cultureField = value;
			}
		}
		public CrmNumber customizationlevel
		{
			get
			{
				return this.customizationlevelField;
			}
			set
			{
				this.customizationlevelField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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
		public string path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}
		public Key pluginassemblyid
		{
			get
			{
				return this.pluginassemblyidField;
			}
			set
			{
				this.pluginassemblyidField = value;
			}
		}
		public UniqueIdentifier pluginassemblyidunique
		{
			get
			{
				return this.pluginassemblyiduniqueField;
			}
			set
			{
				this.pluginassemblyiduniqueField = value;
			}
		}
		public string publickeytoken
		{
			get
			{
				return this.publickeytokenField;
			}
			set
			{
				this.publickeytokenField = value;
			}
		}
		public string sourcehash
		{
			get
			{
				return this.sourcehashField;
			}
			set
			{
				this.sourcehashField = value;
			}
		}
		public Picklist sourcetype
		{
			get
			{
				return this.sourcetypeField;
			}
			set
			{
				this.sourcetypeField = value;
			}
		}
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}
	}
}
