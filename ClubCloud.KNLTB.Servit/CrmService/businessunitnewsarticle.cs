using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class businessunitnewsarticle : BusinessEntity
	{
		private CrmDateTime activeonField;
		private CrmDateTime activeuntilField;
		private string articletitleField;
		private Picklist articletypecodeField;
		private string articleurlField;
		private Key businessunitnewsarticleidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string newsarticleField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmBoolean showonhomepageField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmDateTime activeon
		{
			get
			{
				return this.activeonField;
			}
			set
			{
				this.activeonField = value;
			}
		}
		public CrmDateTime activeuntil
		{
			get
			{
				return this.activeuntilField;
			}
			set
			{
				this.activeuntilField = value;
			}
		}
		public string articletitle
		{
			get
			{
				return this.articletitleField;
			}
			set
			{
				this.articletitleField = value;
			}
		}
		public Picklist articletypecode
		{
			get
			{
				return this.articletypecodeField;
			}
			set
			{
				this.articletypecodeField = value;
			}
		}
		public string articleurl
		{
			get
			{
				return this.articleurlField;
			}
			set
			{
				this.articleurlField = value;
			}
		}
		public Key businessunitnewsarticleid
		{
			get
			{
				return this.businessunitnewsarticleidField;
			}
			set
			{
				this.businessunitnewsarticleidField = value;
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
		public string newsarticle
		{
			get
			{
				return this.newsarticleField;
			}
			set
			{
				this.newsarticleField = value;
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
		public CrmBoolean showonhomepage
		{
			get
			{
				return this.showonhomepageField;
			}
			set
			{
				this.showonhomepageField = value;
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
