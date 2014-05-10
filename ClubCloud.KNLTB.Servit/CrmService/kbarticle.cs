using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class kbarticle : BusinessEntity
	{
		private string articlexmlField;
		private string commentsField;
		private string contentField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmNumber importsequencenumberField;
		private Key kbarticleidField;
		private Lookup kbarticletemplateidField;
		private string keywordsField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string numberField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private KbArticleStateInfo statecodeField;
		private Status statuscodeField;
		private Lookup subjectidField;
		private string titleField;
		public string articlexml
		{
			get
			{
				return this.articlexmlField;
			}
			set
			{
				this.articlexmlField = value;
			}
		}
		public string comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
			}
		}
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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
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
		public Key kbarticleid
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
		public Lookup kbarticletemplateid
		{
			get
			{
				return this.kbarticletemplateidField;
			}
			set
			{
				this.kbarticletemplateidField = value;
			}
		}
		public string keywords
		{
			get
			{
				return this.keywordsField;
			}
			set
			{
				this.keywordsField = value;
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
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
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
		public KbArticleStateInfo statecode
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
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
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
