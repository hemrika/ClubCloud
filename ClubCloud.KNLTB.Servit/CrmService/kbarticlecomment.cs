using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class kbarticlecomment : BusinessEntity
	{
		private string commenttextField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Key kbarticlecommentidField;
		private Lookup kbarticleidField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier organizationidField;
		private string titleField;
		public string commenttext
		{
			get
			{
				return this.commenttextField;
			}
			set
			{
				this.commenttextField = value;
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
		public Key kbarticlecommentid
		{
			get
			{
				return this.kbarticlecommentidField;
			}
			set
			{
				this.kbarticlecommentidField = value;
			}
		}
		public Lookup kbarticleid
		{
			get
			{
				return this.kbarticleidField;
			}
			set
			{
				this.kbarticleidField = value;
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
		public UniqueIdentifier organizationid
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
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}
	}
}
