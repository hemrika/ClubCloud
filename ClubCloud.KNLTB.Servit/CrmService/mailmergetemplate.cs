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
	public class mailmergetemplate : BusinessEntity
	{
		private string bodyField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string defaultfilterField;

		private string descriptionField;

		private Picklist documentformatField;

		private string filenameField;

		private CrmNumber filesizeField;

		private CrmBoolean ispersonalField;

		private CrmNumber languagecodeField;

		private Key mailmergetemplateidField;

		private Picklist mailmergetypeField;

		private string mimetypeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string parameterxmlField;

		private MailMergeTemplateStateInfo statecodeField;

		private Status statuscodeField;

		private EntityNameReference templatetypecodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

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
		public string defaultfilter
		{
			get
			{
				return this.defaultfilterField;
			}
			set
			{
				this.defaultfilterField = value;
				base.RaisePropertyChanged("defaultfilter");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public Picklist documentformat
		{
			get
			{
				return this.documentformatField;
			}
			set
			{
				this.documentformatField = value;
				base.RaisePropertyChanged("documentformat");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
				base.RaisePropertyChanged("filename");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmNumber filesize
		{
			get
			{
				return this.filesizeField;
			}
			set
			{
				this.filesizeField = value;
				base.RaisePropertyChanged("filesize");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public Key mailmergetemplateid
		{
			get
			{
				return this.mailmergetemplateidField;
			}
			set
			{
				this.mailmergetemplateidField = value;
				base.RaisePropertyChanged("mailmergetemplateid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Picklist mailmergetype
		{
			get
			{
				return this.mailmergetypeField;
			}
			set
			{
				this.mailmergetypeField = value;
				base.RaisePropertyChanged("mailmergetype");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public string parameterxml
		{
			get
			{
				return this.parameterxmlField;
			}
			set
			{
				this.parameterxmlField = value;
				base.RaisePropertyChanged("parameterxml");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public MailMergeTemplateStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		public mailmergetemplate()
		{
		}
	}
}