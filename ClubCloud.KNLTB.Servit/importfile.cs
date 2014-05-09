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
		[XmlElement(Order = 0)]
		public string additionalheaderrow
		{
			get
			{
				return this.additionalheaderrowField;
			}
			set
			{
				this.additionalheaderrowField = value;
				base.RaisePropertyChanged("additionalheaderrow");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
				base.RaisePropertyChanged("completedon");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
		public Picklist datadelimitercode
		{
			get
			{
				return this.datadelimitercodeField;
			}
			set
			{
				this.datadelimitercodeField = value;
				base.RaisePropertyChanged("datadelimitercode");
			}
		}
		[XmlElement(Order = 6)]
		public CrmBoolean enableduplicatedetection
		{
			get
			{
				return this.enableduplicatedetectionField;
			}
			set
			{
				this.enableduplicatedetectionField = value;
				base.RaisePropertyChanged("enableduplicatedetection");
			}
		}
		[XmlElement(Order = 7)]
		public CrmNumber failurecount
		{
			get
			{
				return this.failurecountField;
			}
			set
			{
				this.failurecountField = value;
				base.RaisePropertyChanged("failurecount");
			}
		}
		[XmlElement(Order = 8)]
		public Picklist fielddelimitercode
		{
			get
			{
				return this.fielddelimitercodeField;
			}
			set
			{
				this.fielddelimitercodeField = value;
				base.RaisePropertyChanged("fielddelimitercode");
			}
		}
		[XmlElement(Order = 9)]
		public string headerrow
		{
			get
			{
				return this.headerrowField;
			}
			set
			{
				this.headerrowField = value;
				base.RaisePropertyChanged("headerrow");
			}
		}
		[XmlElement(Order = 10)]
		public Key importfileid
		{
			get
			{
				return this.importfileidField;
			}
			set
			{
				this.importfileidField = value;
				base.RaisePropertyChanged("importfileid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup importid
		{
			get
			{
				return this.importidField;
			}
			set
			{
				this.importidField = value;
				base.RaisePropertyChanged("importid");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup importmapid
		{
			get
			{
				return this.importmapidField;
			}
			set
			{
				this.importmapidField = value;
				base.RaisePropertyChanged("importmapid");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean isfirstrowheader
		{
			get
			{
				return this.isfirstrowheaderField;
			}
			set
			{
				this.isfirstrowheaderField = value;
				base.RaisePropertyChanged("isfirstrowheader");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
		public string parsedtablecolumnprefix
		{
			get
			{
				return this.parsedtablecolumnprefixField;
			}
			set
			{
				this.parsedtablecolumnprefixField = value;
				base.RaisePropertyChanged("parsedtablecolumnprefix");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber parsedtablecolumnsnumber
		{
			get
			{
				return this.parsedtablecolumnsnumberField;
			}
			set
			{
				this.parsedtablecolumnsnumberField = value;
				base.RaisePropertyChanged("parsedtablecolumnsnumber");
			}
		}
		[XmlElement(Order = 21)]
		public string parsedtablename
		{
			get
			{
				return this.parsedtablenameField;
			}
			set
			{
				this.parsedtablenameField = value;
				base.RaisePropertyChanged("parsedtablename");
			}
		}
		[XmlElement(Order = 22)]
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
				base.RaisePropertyChanged("processcode");
			}
		}
		[XmlElement(Order = 23)]
		public Picklist processingstatus
		{
			get
			{
				return this.processingstatusField;
			}
			set
			{
				this.processingstatusField = value;
				base.RaisePropertyChanged("processingstatus");
			}
		}
		[XmlElement(Order = 24)]
		public CrmNumber progresscounter
		{
			get
			{
				return this.progresscounterField;
			}
			set
			{
				this.progresscounterField = value;
				base.RaisePropertyChanged("progresscounter");
			}
		}
		[XmlElement(Order = 25)]
		public Lookup recordsownerid
		{
			get
			{
				return this.recordsowneridField;
			}
			set
			{
				this.recordsowneridField = value;
				base.RaisePropertyChanged("recordsownerid");
			}
		}
		[XmlElement(Order = 26)]
		public string size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
				base.RaisePropertyChanged("size");
			}
		}
		[XmlElement(Order = 27)]
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
				base.RaisePropertyChanged("source");
			}
		}
		[XmlElement(Order = 28)]
		public string sourceentityname
		{
			get
			{
				return this.sourceentitynameField;
			}
			set
			{
				this.sourceentitynameField = value;
				base.RaisePropertyChanged("sourceentityname");
			}
		}
		[XmlElement(Order = 29)]
		public ImportFileStateInfo statecode
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
		public CrmNumber successcount
		{
			get
			{
				return this.successcountField;
			}
			set
			{
				this.successcountField = value;
				base.RaisePropertyChanged("successcount");
			}
		}
		[XmlElement(Order = 32)]
		public string targetentityname
		{
			get
			{
				return this.targetentitynameField;
			}
			set
			{
				this.targetentitynameField = value;
				base.RaisePropertyChanged("targetentityname");
			}
		}
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
		public CrmNumber totalcount
		{
			get
			{
				return this.totalcountField;
			}
			set
			{
				this.totalcountField = value;
				base.RaisePropertyChanged("totalcount");
			}
		}
		[XmlElement(Order = 35)]
		public CrmBoolean usesystemmap
		{
			get
			{
				return this.usesystemmapField;
			}
			set
			{
				this.usesystemmapField = value;
				base.RaisePropertyChanged("usesystemmap");
			}
		}
		[XmlElement(Order = 36)]
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
	}
}
