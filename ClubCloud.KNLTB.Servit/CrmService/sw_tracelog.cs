using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Sw_tracelogStateInfo statecode
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
		public Lookup sw_applicationid
		{
			get
			{
				return this.sw_applicationidField;
			}
			set
			{
				this.sw_applicationidField = value;
			}
		}
		public string sw_date
		{
			get
			{
				return this.sw_dateField;
			}
			set
			{
				this.sw_dateField = value;
			}
		}
		public string sw_message
		{
			get
			{
				return this.sw_messageField;
			}
			set
			{
				this.sw_messageField = value;
			}
		}
		public string sw_module
		{
			get
			{
				return this.sw_moduleField;
			}
			set
			{
				this.sw_moduleField = value;
			}
		}
		public Lookup sw_multiviewlookupid
		{
			get
			{
				return this.sw_multiviewlookupidField;
			}
			set
			{
				this.sw_multiviewlookupidField = value;
			}
		}
		public string sw_name
		{
			get
			{
				return this.sw_nameField;
			}
			set
			{
				this.sw_nameField = value;
			}
		}
		public Picklist sw_severity
		{
			get
			{
				return this.sw_severityField;
			}
			set
			{
				this.sw_severityField = value;
			}
		}
		public Lookup sw_singlelookupviewid
		{
			get
			{
				return this.sw_singlelookupviewidField;
			}
			set
			{
				this.sw_singlelookupviewidField = value;
			}
		}
		public Key sw_tracelogid
		{
			get
			{
				return this.sw_tracelogidField;
			}
			set
			{
				this.sw_tracelogidField = value;
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
