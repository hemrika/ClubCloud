using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string actionurl
		{
			get
			{
				return this.actionurlField;
			}
			set
			{
				this.actionurlField = value;
			}
		}
		public Key businesstaskid
		{
			get
			{
				return this.businesstaskidField;
			}
			set
			{
				this.businesstaskidField = value;
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
		public string helpurl
		{
			get
			{
				return this.helpurlField;
			}
			set
			{
				this.helpurlField = value;
			}
		}
		public string iconurl
		{
			get
			{
				return this.iconurlField;
			}
			set
			{
				this.iconurlField = value;
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
		public Lookup parentbusinesstaskid
		{
			get
			{
				return this.parentbusinesstaskidField;
			}
			set
			{
				this.parentbusinesstaskidField = value;
			}
		}
		public Picklist privilege
		{
			get
			{
				return this.privilegeField;
			}
			set
			{
				this.privilegeField = value;
			}
		}
		public BusinessTaskStateInfo statecode
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
		public CrmNumber taskorder
		{
			get
			{
				return this.taskorderField;
			}
			set
			{
				this.taskorderField = value;
			}
		}
	}
}
