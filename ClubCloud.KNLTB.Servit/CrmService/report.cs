using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public string bodybinary
		{
			get
			{
				return this.bodybinaryField;
			}
			set
			{
				this.bodybinaryField = value;
			}
		}
		public string bodytext
		{
			get
			{
				return this.bodytextField;
			}
			set
			{
				this.bodytextField = value;
			}
		}
		public string bodyurl
		{
			get
			{
				return this.bodyurlField;
			}
			set
			{
				this.bodyurlField = value;
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
		public string customreportxml
		{
			get
			{
				return this.customreportxmlField;
			}
			set
			{
				this.customreportxmlField = value;
			}
		}
		public string defaultfilter
		{
			get
			{
				return this.defaultfilterField;
			}
			set
			{
				this.defaultfilterField = value;
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
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
			}
		}
		public CrmNumber filesize
		{
			get
			{
				return this.filesizeField;
			}
			set
			{
				this.filesizeField = value;
			}
		}
		public CrmBoolean iscustomreport
		{
			get
			{
				return this.iscustomreportField;
			}
			set
			{
				this.iscustomreportField = value;
			}
		}
		public CrmBoolean ispersonal
		{
			get
			{
				return this.ispersonalField;
			}
			set
			{
				this.ispersonalField = value;
			}
		}
		public CrmBoolean isscheduledreport
		{
			get
			{
				return this.isscheduledreportField;
			}
			set
			{
				this.isscheduledreportField = value;
			}
		}
		public CrmNumber languagecode
		{
			get
			{
				return this.languagecodeField;
			}
			set
			{
				this.languagecodeField = value;
			}
		}
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public Lookup parentreportid
		{
			get
			{
				return this.parentreportidField;
			}
			set
			{
				this.parentreportidField = value;
			}
		}
		public string queryinfo
		{
			get
			{
				return this.queryinfoField;
			}
			set
			{
				this.queryinfoField = value;
			}
		}
		public Key reportid
		{
			get
			{
				return this.reportidField;
			}
			set
			{
				this.reportidField = value;
			}
		}
		public Picklist reporttypecode
		{
			get
			{
				return this.reporttypecodeField;
			}
			set
			{
				this.reporttypecodeField = value;
			}
		}
		public string schedulexml
		{
			get
			{
				return this.schedulexmlField;
			}
			set
			{
				this.schedulexmlField = value;
			}
		}
		public CrmDateTime signaturedate
		{
			get
			{
				return this.signaturedateField;
			}
			set
			{
				this.signaturedateField = value;
			}
		}
		public UniqueIdentifier signatureid
		{
			get
			{
				return this.signatureidField;
			}
			set
			{
				this.signatureidField = value;
			}
		}
		public CrmNumber signaturelcid
		{
			get
			{
				return this.signaturelcidField;
			}
			set
			{
				this.signaturelcidField = value;
			}
		}
		public CrmNumber signaturemajorversion
		{
			get
			{
				return this.signaturemajorversionField;
			}
			set
			{
				this.signaturemajorversionField = value;
			}
		}
		public CrmNumber signatureminorversion
		{
			get
			{
				return this.signatureminorversionField;
			}
			set
			{
				this.signatureminorversionField = value;
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
