using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class wfprocessinstance : BusinessEntity
	{
		private Lookup businessunitidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDateTime lastactivityonField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier objectidField;
		private string objecttypeField;
		private Lookup parentidField;
		private Lookup processidField;
		private Key processinstanceidField;
		private Lookup startedbyField;
		private CrmDateTime startedonField;
		private WFProcessInstanceStateInfo statecodeField;
		private CrmNumber stepcounterField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup usercontextField;
		private CrmNumber utcconversiontimezonecodeField;
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
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
		public CrmDateTime lastactivityon
		{
			get
			{
				return this.lastactivityonField;
			}
			set
			{
				this.lastactivityonField = value;
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
		public UniqueIdentifier objectid
		{
			get
			{
				return this.objectidField;
			}
			set
			{
				this.objectidField = value;
			}
		}
		public string objecttype
		{
			get
			{
				return this.objecttypeField;
			}
			set
			{
				this.objecttypeField = value;
			}
		}
		public Lookup parentid
		{
			get
			{
				return this.parentidField;
			}
			set
			{
				this.parentidField = value;
			}
		}
		public Lookup processid
		{
			get
			{
				return this.processidField;
			}
			set
			{
				this.processidField = value;
			}
		}
		public Key processinstanceid
		{
			get
			{
				return this.processinstanceidField;
			}
			set
			{
				this.processinstanceidField = value;
			}
		}
		public Lookup startedby
		{
			get
			{
				return this.startedbyField;
			}
			set
			{
				this.startedbyField = value;
			}
		}
		public CrmDateTime startedon
		{
			get
			{
				return this.startedonField;
			}
			set
			{
				this.startedonField = value;
			}
		}
		public WFProcessInstanceStateInfo statecode
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
		public CrmNumber stepcounter
		{
			get
			{
				return this.stepcounterField;
			}
			set
			{
				this.stepcounterField = value;
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
		public Lookup usercontext
		{
			get
			{
				return this.usercontextField;
			}
			set
			{
				this.usercontextField = value;
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
