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
	public class sw_tracelog : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Sw_tracelogStateInfo statecodeField;

		private Status statuscodeField;

		private Lookup sw_applicationidField;

		private string sw_dateField;

		private string sw_messageField;

		private string sw_moduleField;

		private Lookup sw_multiviewlookupidField;

		private string sw_nameField;

		private Picklist sw_severityField;

		private Lookup sw_singlelookupviewidField;

		private Key sw_tracelogidField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Sw_tracelogStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sw_applicationid
		{
			get
			{
				return this.sw_applicationidField;
			}
			set
			{
				this.sw_applicationidField = value;
				base.RaisePropertyChanged("sw_applicationid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sw_date
		{
			get
			{
				return this.sw_dateField;
			}
			set
			{
				this.sw_dateField = value;
				base.RaisePropertyChanged("sw_date");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sw_message
		{
			get
			{
				return this.sw_messageField;
			}
			set
			{
				this.sw_messageField = value;
				base.RaisePropertyChanged("sw_message");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sw_module
		{
			get
			{
				return this.sw_moduleField;
			}
			set
			{
				this.sw_moduleField = value;
				base.RaisePropertyChanged("sw_module");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sw_multiviewlookupid
		{
			get
			{
				return this.sw_multiviewlookupidField;
			}
			set
			{
				this.sw_multiviewlookupidField = value;
				base.RaisePropertyChanged("sw_multiviewlookupid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sw_name
		{
			get
			{
				return this.sw_nameField;
			}
			set
			{
				this.sw_nameField = value;
				base.RaisePropertyChanged("sw_name");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist sw_severity
		{
			get
			{
				return this.sw_severityField;
			}
			set
			{
				this.sw_severityField = value;
				base.RaisePropertyChanged("sw_severity");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sw_singlelookupviewid
		{
			get
			{
				return this.sw_singlelookupviewidField;
			}
			set
			{
				this.sw_singlelookupviewidField = value;
				base.RaisePropertyChanged("sw_singlelookupviewid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Key sw_tracelogid
		{
			get
			{
				return this.sw_tracelogidField;
			}
			set
			{
				this.sw_tracelogidField = value;
				base.RaisePropertyChanged("sw_tracelogid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		public sw_tracelog()
		{
		}
	}
}