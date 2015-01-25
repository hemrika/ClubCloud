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
	public class template : BusinessEntity
	{
		private string bodyField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string descriptionField;

		private CrmNumber generationtypecodeField;

		private CrmNumber importsequencenumberField;

		private CrmBoolean ispersonalField;

		private CrmNumber languagecodeField;

		private string mimetypeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string presentationxmlField;

		private string subjectField;

		private string subjectpresentationxmlField;

		private Key templateidField;

		private EntityNameReference templatetypecodeField;

		private string titleField;

		[XmlElement] //[XmlElement(Order=0)]
		public string body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
				base.RaisePropertyChanged("body");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
		public CrmNumber generationtypecode
		{
			get
			{
				return this.generationtypecodeField;
			}
			set
			{
				this.generationtypecodeField = value;
				base.RaisePropertyChanged("generationtypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
		public CrmBoolean ispersonal
		{
			get
			{
				return this.ispersonalField;
			}
			set
			{
				this.ispersonalField = value;
				base.RaisePropertyChanged("ispersonal");
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
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
				base.RaisePropertyChanged("mimetype");
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
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string presentationxml
		{
			get
			{
				return this.presentationxmlField;
			}
			set
			{
				this.presentationxmlField = value;
				base.RaisePropertyChanged("presentationxml");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
				base.RaisePropertyChanged("subject");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string subjectpresentationxml
		{
			get
			{
				return this.subjectpresentationxmlField;
			}
			set
			{
				this.subjectpresentationxmlField = value;
				base.RaisePropertyChanged("subjectpresentationxml");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Key templateid
		{
			get
			{
				return this.templateidField;
			}
			set
			{
				this.templateidField = value;
				base.RaisePropertyChanged("templateid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public EntityNameReference templatetypecode
		{
			get
			{
				return this.templatetypecodeField;
			}
			set
			{
				this.templatetypecodeField = value;
				base.RaisePropertyChanged("templatetypecode");
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

		public template()
		{
		}
	}
}