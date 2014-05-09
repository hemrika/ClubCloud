using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public string commenttext
		{
			get
			{
				return this.commenttextField;
			}
			set
			{
				this.commenttextField = value;
				base.RaisePropertyChanged("commenttext");
			}
		}
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
		public Key kbarticlecommentid
		{
			get
			{
				return this.kbarticlecommentidField;
			}
			set
			{
				this.kbarticlecommentidField = value;
				base.RaisePropertyChanged("kbarticlecommentid");
			}
		}
		[XmlElement(Order = 4)]
		public Lookup kbarticleid
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public UniqueIdentifier organizationid
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
		[XmlElement(Order = 8)]
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
	}
}
