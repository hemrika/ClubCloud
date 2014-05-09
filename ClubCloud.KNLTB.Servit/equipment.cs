using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class equipment : BusinessEntity
	{
		private Lookup businessunitidField;
		private Lookup calendaridField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmBoolean displayinserviceviewsField;
		private string emailaddressField;
		private Key equipmentidField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isdisabledField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Lookup siteidField;
		private string skillsField;
		private CrmNumber timezonecodeField;
		private CrmNumber timezoneruleversionnumberField;
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
		public Lookup calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
				base.RaisePropertyChanged("calendarid");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
		public CrmBoolean displayinserviceviews
		{
			get
			{
				return this.displayinserviceviewsField;
			}
			set
			{
				this.displayinserviceviewsField = value;
				base.RaisePropertyChanged("displayinserviceviews");
			}
		}
		[XmlElement(Order = 6)]
		public string emailaddress
		{
			get
			{
				return this.emailaddressField;
			}
			set
			{
				this.emailaddressField = value;
				base.RaisePropertyChanged("emailaddress");
			}
		}
		[XmlElement(Order = 7)]
		public Key equipmentid
		{
			get
			{
				return this.equipmentidField;
			}
			set
			{
				this.equipmentidField = value;
				base.RaisePropertyChanged("equipmentid");
			}
		}
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public CrmBoolean isdisabled
		{
			get
			{
				return this.isdisabledField;
			}
			set
			{
				this.isdisabledField = value;
				base.RaisePropertyChanged("isdisabled");
			}
		}
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Lookup siteid
		{
			get
			{
				return this.siteidField;
			}
			set
			{
				this.siteidField = value;
				base.RaisePropertyChanged("siteid");
			}
		}
		[XmlElement(Order = 16)]
		public string skills
		{
			get
			{
				return this.skillsField;
			}
			set
			{
				this.skillsField = value;
				base.RaisePropertyChanged("skills");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber timezonecode
		{
			get
			{
				return this.timezonecodeField;
			}
			set
			{
				this.timezonecodeField = value;
				base.RaisePropertyChanged("timezonecode");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
