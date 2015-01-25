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
	public class report : BusinessEntity
	{
		private string bodybinaryField;

		private string bodytextField;

		private string bodyurlField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string customreportxmlField;

		private string defaultfilterField;

		private string descriptionField;

		private string filenameField;

		private CrmNumber filesizeField;

		private CrmBoolean iscustomreportField;

		private CrmBoolean ispersonalField;

		private CrmBoolean isscheduledreportField;

		private CrmNumber languagecodeField;

		private string mimetypeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup parentreportidField;

		private string queryinfoField;

		private Key reportidField;

		private Picklist reporttypecodeField;

		private string schedulexmlField;

		private CrmDateTime signaturedateField;

		private UniqueIdentifier signatureidField;

		private CrmNumber signaturelcidField;

		private CrmNumber signaturemajorversionField;

		private CrmNumber signatureminorversionField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public string bodybinary
		{
			get
			{
				return this.bodybinaryField;
			}
			set
			{
				this.bodybinaryField = value;
				base.RaisePropertyChanged("bodybinary");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string bodytext
		{
			get
			{
				return this.bodytextField;
			}
			set
			{
				this.bodytextField = value;
				base.RaisePropertyChanged("bodytext");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string bodyurl
		{
			get
			{
				return this.bodyurlField;
			}
			set
			{
				this.bodyurlField = value;
				base.RaisePropertyChanged("bodyurl");
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
		public string customreportxml
		{
			get
			{
				return this.customreportxmlField;
			}
			set
			{
				this.customreportxmlField = value;
				base.RaisePropertyChanged("customreportxml");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean iscustomreport
		{
			get
			{
				return this.iscustomreportField;
			}
			set
			{
				this.iscustomreportField = value;
				base.RaisePropertyChanged("iscustomreport");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean isscheduledreport
		{
			get
			{
				return this.isscheduledreportField;
			}
			set
			{
				this.isscheduledreportField = value;
				base.RaisePropertyChanged("isscheduledreport");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup parentreportid
		{
			get
			{
				return this.parentreportidField;
			}
			set
			{
				this.parentreportidField = value;
				base.RaisePropertyChanged("parentreportid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string queryinfo
		{
			get
			{
				return this.queryinfoField;
			}
			set
			{
				this.queryinfoField = value;
				base.RaisePropertyChanged("queryinfo");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Key reportid
		{
			get
			{
				return this.reportidField;
			}
			set
			{
				this.reportidField = value;
				base.RaisePropertyChanged("reportid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Picklist reporttypecode
		{
			get
			{
				return this.reporttypecodeField;
			}
			set
			{
				this.reporttypecodeField = value;
				base.RaisePropertyChanged("reporttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string schedulexml
		{
			get
			{
				return this.schedulexmlField;
			}
			set
			{
				this.schedulexmlField = value;
				base.RaisePropertyChanged("schedulexml");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmDateTime signaturedate
		{
			get
			{
				return this.signaturedateField;
			}
			set
			{
				this.signaturedateField = value;
				base.RaisePropertyChanged("signaturedate");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public UniqueIdentifier signatureid
		{
			get
			{
				return this.signatureidField;
			}
			set
			{
				this.signatureidField = value;
				base.RaisePropertyChanged("signatureid");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmNumber signaturelcid
		{
			get
			{
				return this.signaturelcidField;
			}
			set
			{
				this.signaturelcidField = value;
				base.RaisePropertyChanged("signaturelcid");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmNumber signaturemajorversion
		{
			get
			{
				return this.signaturemajorversionField;
			}
			set
			{
				this.signaturemajorversionField = value;
				base.RaisePropertyChanged("signaturemajorversion");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmNumber signatureminorversion
		{
			get
			{
				return this.signatureminorversionField;
			}
			set
			{
				this.signatureminorversionField = value;
				base.RaisePropertyChanged("signatureminorversion");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		public report()
		{
		}
	}
}