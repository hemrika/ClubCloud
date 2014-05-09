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
		[XmlElement(Order = 0)]
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
				base.RaisePropertyChanged("businessunitid");
			}
		}
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
		public CrmDateTime lastactivityon
		{
			get
			{
				return this.lastactivityonField;
			}
			set
			{
				this.lastactivityonField = value;
				base.RaisePropertyChanged("lastactivityon");
			}
		}
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public UniqueIdentifier objectid
		{
			get
			{
				return this.objectidField;
			}
			set
			{
				this.objectidField = value;
				base.RaisePropertyChanged("objectid");
			}
		}
		[XmlElement(Order = 7)]
		public string objecttype
		{
			get
			{
				return this.objecttypeField;
			}
			set
			{
				this.objecttypeField = value;
				base.RaisePropertyChanged("objecttype");
			}
		}
		[XmlElement(Order = 8)]
		public Lookup parentid
		{
			get
			{
				return this.parentidField;
			}
			set
			{
				this.parentidField = value;
				base.RaisePropertyChanged("parentid");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup processid
		{
			get
			{
				return this.processidField;
			}
			set
			{
				this.processidField = value;
				base.RaisePropertyChanged("processid");
			}
		}
		[XmlElement(Order = 10)]
		public Key processinstanceid
		{
			get
			{
				return this.processinstanceidField;
			}
			set
			{
				this.processinstanceidField = value;
				base.RaisePropertyChanged("processinstanceid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup startedby
		{
			get
			{
				return this.startedbyField;
			}
			set
			{
				this.startedbyField = value;
				base.RaisePropertyChanged("startedby");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime startedon
		{
			get
			{
				return this.startedonField;
			}
			set
			{
				this.startedonField = value;
				base.RaisePropertyChanged("startedon");
			}
		}
		[XmlElement(Order = 13)]
		public WFProcessInstanceStateInfo statecode
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
		[XmlElement(Order = 14)]
		public CrmNumber stepcounter
		{
			get
			{
				return this.stepcounterField;
			}
			set
			{
				this.stepcounterField = value;
				base.RaisePropertyChanged("stepcounter");
			}
		}
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public Lookup usercontext
		{
			get
			{
				return this.usercontextField;
			}
			set
			{
				this.usercontextField = value;
				base.RaisePropertyChanged("usercontext");
			}
		}
		[XmlElement(Order = 17)]
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
