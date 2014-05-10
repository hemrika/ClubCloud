using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class plugintype : BusinessEntity
	{
		private string assemblynameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string cultureField;
		private CrmNumber customizationlevelField;
		private string friendlynameField;
		private CrmBoolean isworkflowactivityField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private Lookup pluginassemblyidField;
		private Key plugintypeidField;
		private UniqueIdentifier plugintypeiduniqueField;
		private string publickeytokenField;
		private string typenameField;
		private string versionField;
		public string assemblyname
		{
			get
			{
				return this.assemblynameField;
			}
			set
			{
				this.assemblynameField = value;
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
		public string friendlyname
		{
			get
			{
				return this.friendlynameField;
			}
			set
			{
				this.friendlynameField = value;
			}
		}
		public CrmBoolean isworkflowactivity
		{
			get
			{
				return this.isworkflowactivityField;
			}
			set
			{
				this.isworkflowactivityField = value;
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
		public Lookup pluginassemblyid
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
		public Key plugintypeid
		{
			get
			{
				return this.plugintypeidField;
			}
			set
			{
				this.plugintypeidField = value;
			}
		}
		public UniqueIdentifier plugintypeidunique
		{
			get
			{
				return this.plugintypeiduniqueField;
			}
			set
			{
				this.plugintypeiduniqueField = value;
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
		public string typename
		{
			get
			{
				return this.typenameField;
			}
			set
			{
				this.typenameField = value;
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
