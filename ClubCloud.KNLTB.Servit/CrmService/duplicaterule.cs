using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class duplicaterule : BusinessEntity
	{
		private string baseentitymatchcodetableField;
		private string baseentitynameField;
		private Picklist baseentitytypecodeField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private Key duplicateruleidField;
		private CrmBoolean iscasesensitiveField;
		private string matchingentitymatchcodetableField;
		private string matchingentitynameField;
		private Picklist matchingentitytypecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private DuplicateRuleStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public string baseentitymatchcodetable
		{
			get
			{
				return this.baseentitymatchcodetableField;
			}
			set
			{
				this.baseentitymatchcodetableField = value;
			}
		}
		public string baseentityname
		{
			get
			{
				return this.baseentitynameField;
			}
			set
			{
				this.baseentitynameField = value;
			}
		}
		public Picklist baseentitytypecode
		{
			get
			{
				return this.baseentitytypecodeField;
			}
			set
			{
				this.baseentitytypecodeField = value;
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
		public Key duplicateruleid
		{
			get
			{
				return this.duplicateruleidField;
			}
			set
			{
				this.duplicateruleidField = value;
			}
		}
		public CrmBoolean iscasesensitive
		{
			get
			{
				return this.iscasesensitiveField;
			}
			set
			{
				this.iscasesensitiveField = value;
			}
		}
		public string matchingentitymatchcodetable
		{
			get
			{
				return this.matchingentitymatchcodetableField;
			}
			set
			{
				this.matchingentitymatchcodetableField = value;
			}
		}
		public string matchingentityname
		{
			get
			{
				return this.matchingentitynameField;
			}
			set
			{
				this.matchingentitynameField = value;
			}
		}
		public Picklist matchingentitytypecode
		{
			get
			{
				return this.matchingentitytypecodeField;
			}
			set
			{
				this.matchingentitytypecodeField = value;
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
		public DuplicateRuleStateInfo statecode
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
