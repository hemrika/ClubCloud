using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sw_lookuptemplate : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Sw_lookuptemplateStateInfo statecodeField;
		private Status statuscodeField;
		private string sw_classField;
		private Lookup sw_defaultviewidField;
		private string sw_descriptionField;
		private string sw_displaynameField;
		private Key sw_lookuptemplateidField;
		private Picklist sw_tracingField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public Sw_lookuptemplateStateInfo statecode
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public string sw_class
		{
			get
			{
				return this.sw_classField;
			}
			set
			{
				this.sw_classField = value;
				base.RaisePropertyChanged("sw_class");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sw_defaultviewid
		{
			get
			{
				return this.sw_defaultviewidField;
			}
			set
			{
				this.sw_defaultviewidField = value;
				base.RaisePropertyChanged("sw_defaultviewid");
			}
		}
		[XmlElement(Order = 11)]
		public string sw_description
		{
			get
			{
				return this.sw_descriptionField;
			}
			set
			{
				this.sw_descriptionField = value;
				base.RaisePropertyChanged("sw_description");
			}
		}
		[XmlElement(Order = 12)]
		public string sw_displayname
		{
			get
			{
				return this.sw_displaynameField;
			}
			set
			{
				this.sw_displaynameField = value;
				base.RaisePropertyChanged("sw_displayname");
			}
		}
		[XmlElement(Order = 13)]
		public Key sw_lookuptemplateid
		{
			get
			{
				return this.sw_lookuptemplateidField;
			}
			set
			{
				this.sw_lookuptemplateidField = value;
				base.RaisePropertyChanged("sw_lookuptemplateid");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist sw_tracing
		{
			get
			{
				return this.sw_tracingField;
			}
			set
			{
				this.sw_tracingField = value;
				base.RaisePropertyChanged("sw_tracing");
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
