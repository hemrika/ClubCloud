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

		[XmlElement] //[XmlElement(Order=0)]
		public CrmDateTime activeon
		{
			get
			{
				return this.activeonField;
			}
			set
			{
				this.activeonField = value;
				base.RaisePropertyChanged("activeon");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmDateTime activeuntil
		{
			get
			{
				return this.activeuntilField;
			}
			set
			{
				this.activeuntilField = value;
				base.RaisePropertyChanged("activeuntil");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string articletitle
		{
			get
			{
				return this.articletitleField;
			}
			set
			{
				this.articletitleField = value;
				base.RaisePropertyChanged("articletitle");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Picklist articletypecode
		{
			get
			{
				return this.articletypecodeField;
			}
			set
			{
				this.articletypecodeField = value;
				base.RaisePropertyChanged("articletypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string articleurl
		{
			get
			{
				return this.articleurlField;
			}
			set
			{
				this.articleurlField = value;
				base.RaisePropertyChanged("articleurl");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Key businessunitnewsarticleid
		{
			get
			{
				return this.businessunitnewsarticleidField;
			}
			set
			{
				this.businessunitnewsarticleidField = value;
				base.RaisePropertyChanged("businessunitnewsarticleid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public string newsarticle
		{
			get
			{
				return this.newsarticleField;
			}
			set
			{
				this.newsarticleField = value;
				base.RaisePropertyChanged("newsarticle");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean showonhomepage
		{
			get
			{
				return this.showonhomepageField;
			}
			set
			{
				this.showonhomepageField = value;
				base.RaisePropertyChanged("showonhomepage");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}

		public businessunitnewsarticle()
		{
		}
	}
}