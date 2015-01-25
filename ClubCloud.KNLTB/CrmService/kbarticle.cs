using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
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

		[XmlElement] //[XmlElement(Order=0)]
		public string articlexml
		{
			get
			{
				return this.articlexmlField;
			}
			set
			{
				this.articlexmlField = value;
				base.RaisePropertyChanged("articlexml");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				base.RaisePropertyChanged("comments");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string content
		{
			get
			{
				return this.contentField;
			}
			set
			{
				this.contentField = value;
				base.RaisePropertyChanged("content");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public Key kbarticleid
		{
			get
			{
				return this.kbarticleidField;
			}
			set
			{
				this.kbarticleidField = value;
				base.RaisePropertyChanged("kbarticleid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup kbarticletemplateid
		{
			get
			{
				return this.kbarticletemplateidField;
			}
			set
			{
				this.kbarticletemplateidField = value;
				base.RaisePropertyChanged("kbarticletemplateid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string keywords
		{
			get
			{
				return this.keywordsField;
			}
			set
			{
				this.keywordsField = value;
				base.RaisePropertyChanged("keywords");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
				base.RaisePropertyChanged("number");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public KbArticleStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
				base.RaisePropertyChanged("subjectid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				base.RaisePropertyChanged("title");
			}
		}

		public kbarticle()
		{
		}
	}
}