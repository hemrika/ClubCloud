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
	public class kbarticletemplate : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string descriptionField;

		private string formatxmlField;

		private CrmNumber importsequencenumberField;

		private CrmBoolean isactiveField;

		private Key kbarticletemplateidField;

		private CrmNumber languagecodeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private string structurexmlField;

		private string titleField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public string formatxml
		{
			get
			{
				return this.formatxmlField;
			}
			set
			{
				this.formatxmlField = value;
				base.RaisePropertyChanged("formatxml");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public CrmBoolean isactive
		{
			get
			{
				return this.isactiveField;
			}
			set
			{
				this.isactiveField = value;
				base.RaisePropertyChanged("isactive");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Key kbarticletemplateid
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

		[XmlElement] //[XmlElement(Order=7)]
		public CrmNumber languagecode
		{
			get
			{
				return this.languagecodeField;
			}
			set
			{
				this.languagecodeField = value;
				base.RaisePropertyChanged("languagecode");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string structurexml
		{
			get
			{
				return this.structurexmlField;
			}
			set
			{
				this.structurexmlField = value;
				base.RaisePropertyChanged("structurexml");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		public kbarticletemplate()
		{
		}
	}
}