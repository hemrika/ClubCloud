using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class importfile : BusinessEntity
	{
		private string additionalheaderrowField;
		private CrmDateTime completedonField;
		private string contentField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Picklist datadelimitercodeField;
		private CrmBoolean enableduplicatedetectionField;
		private CrmNumber failurecountField;
		private Picklist fielddelimitercodeField;
		private string headerrowField;
		private Key importfileidField;
		private Lookup importidField;
		private Lookup importmapidField;
		private CrmBoolean isfirstrowheaderField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string parsedtablecolumnprefixField;
		private CrmNumber parsedtablecolumnsnumberField;
		private string parsedtablenameField;
		private Picklist processcodeField;
		private Picklist processingstatusField;
		private CrmNumber progresscounterField;
		private Lookup recordsowneridField;
		private string sizeField;
		private string sourceField;
		private string sourceentitynameField;
		private ImportFileStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber successcountField;
		private string targetentitynameField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber totalcountField;
		private CrmBoolean usesystemmapField;
		private CrmNumber utcconversiontimezonecodeField;
		public string additionalheaderrow
		{
			get
			{
				return this.additionalheaderrowField;
			}
			set
			{
				this.additionalheaderrowField = value;
			}
		}
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
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
		public Picklist datadelimitercode
		{
			get
			{
				return this.datadelimitercodeField;
			}
			set
			{
				this.datadelimitercodeField = value;
			}
		}
		public CrmBoolean enableduplicatedetection
		{
			get
			{
				return this.enableduplicatedetectionField;
			}
			set
			{
				this.enableduplicatedetectionField = value;
			}
		}
		public CrmNumber failurecount
		{
			get
			{
				return this.failurecountField;
			}
			set
			{
				this.failurecountField = value;
			}
		}
		public Picklist fielddelimitercode
		{
			get
			{
				return this.fielddelimitercodeField;
			}
			set
			{
				this.fielddelimitercodeField = value;
			}
		}
		public string headerrow
		{
			get
			{
				return this.headerrowField;
			}
			set
			{
				this.headerrowField = value;
			}
		}
		public Key importfileid
		{
			get
			{
				return this.importfileidField;
			}
			set
			{
				this.importfileidField = value;
			}
		}
		public Lookup importid
		{
			get
			{
				return this.importidField;
			}
			set
			{
				this.importidField = value;
			}
		}
		public Lookup importmapid
		{
			get
			{
				return this.importmapidField;
			}
			set
			{
				this.importmapidField = value;
			}
		}
		public CrmBoolean isfirstrowheader
		{
			get
			{
				return this.isfirstrowheaderField;
			}
			set
			{
				this.isfirstrowheaderField = value;
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
		public string parsedtablecolumnprefix
		{
			get
			{
				return this.parsedtablecolumnprefixField;
			}
			set
			{
				this.parsedtablecolumnprefixField = value;
			}
		}
		public CrmNumber parsedtablecolumnsnumber
		{
			get
			{
				return this.parsedtablecolumnsnumberField;
			}
			set
			{
				this.parsedtablecolumnsnumberField = value;
			}
		}
		public string parsedtablename
		{
			get
			{
				return this.parsedtablenameField;
			}
			set
			{
				this.parsedtablenameField = value;
			}
		}
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
			}
		}
		public Picklist processingstatus
		{
			get
			{
				return this.processingstatusField;
			}
			set
			{
				this.processingstatusField = value;
			}
		}
		public CrmNumber progresscounter
		{
			get
			{
				return this.progresscounterField;
			}
			set
			{
				this.progresscounterField = value;
			}
		}
		public Lookup recordsownerid
		{
			get
			{
				return this.recordsowneridField;
			}
			set
			{
				this.recordsowneridField = value;
			}
		}
		public string size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
			}
		}
		public string sourceentityname
		{
			get
			{
				return this.sourceentitynameField;
			}
			set
			{
				this.sourceentitynameField = value;
			}
		}
		public ImportFileStateInfo statecode
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
		public CrmNumber successcount
		{
			get
			{
				return this.successcountField;
			}
			set
			{
				this.successcountField = value;
			}
		}
		public string targetentityname
		{
			get
			{
				return this.targetentitynameField;
			}
			set
			{
				this.targetentitynameField = value;
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
		public CrmNumber totalcount
		{
			get
			{
				return this.totalcountField;
			}
			set
			{
				this.totalcountField = value;
			}
		}
		public CrmBoolean usesystemmap
		{
			get
			{
				return this.usesystemmapField;
			}
			set
			{
				this.usesystemmapField = value;
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
