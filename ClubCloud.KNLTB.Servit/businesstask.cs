using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class businesstask : BusinessEntity
	{
		private string actionurlField;
		private Key businesstaskidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private string helpurlField;
		private string iconurlField;
		private CrmNumber languagecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private Lookup parentbusinesstaskidField;
		private Picklist privilegeField;
		private BusinessTaskStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber taskorderField;
		[XmlElement(Order = 0)]
		public string actionurl
		{
			get
			{
				return this.actionurlField;
			}
			set
			{
				this.actionurlField = value;
				base.RaisePropertyChanged("actionurl");
			}
		}
		[XmlElement(Order = 1)]
		public Key businesstaskid
		{
			get
			{
				return this.businesstaskidField;
			}
			set
			{
				this.businesstaskidField = value;
				base.RaisePropertyChanged("businesstaskid");
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
		public string helpurl
		{
			get
			{
				return this.helpurlField;
			}
			set
			{
				this.helpurlField = value;
				base.RaisePropertyChanged("helpurl");
			}
		}
		[XmlElement(Order = 6)]
		public string iconurl
		{
			get
			{
				return this.iconurlField;
			}
			set
			{
				this.iconurlField = value;
				base.RaisePropertyChanged("iconurl");
			}
		}
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
		public Lookup parentbusinesstaskid
		{
			get
			{
				return this.parentbusinesstaskidField;
			}
			set
			{
				this.parentbusinesstaskidField = value;
				base.RaisePropertyChanged("parentbusinesstaskid");
			}
		}
		[XmlElement(Order = 13)]
		public Picklist privilege
		{
			get
			{
				return this.privilegeField;
			}
			set
			{
				this.privilegeField = value;
				base.RaisePropertyChanged("privilege");
			}
		}
		[XmlElement(Order = 14)]
		public BusinessTaskStateInfo statecode
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public CrmNumber taskorder
		{
			get
			{
				return this.taskorderField;
			}
			set
			{
				this.taskorderField = value;
				base.RaisePropertyChanged("taskorder");
			}
		}
	}
}
