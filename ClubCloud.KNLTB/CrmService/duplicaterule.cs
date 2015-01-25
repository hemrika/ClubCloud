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

		[XmlElement] //[XmlElement(Order=0)]
		public string baseentitymatchcodetable
		{
			get
			{
				return this.baseentitymatchcodetableField;
			}
			set
			{
				this.baseentitymatchcodetableField = value;
				base.RaisePropertyChanged("baseentitymatchcodetable");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string baseentityname
		{
			get
			{
				return this.baseentitynameField;
			}
			set
			{
				this.baseentitynameField = value;
				base.RaisePropertyChanged("baseentityname");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public Picklist baseentitytypecode
		{
			get
			{
				return this.baseentitytypecodeField;
			}
			set
			{
				this.baseentitytypecodeField = value;
				base.RaisePropertyChanged("baseentitytypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
		public Key duplicateruleid
		{
			get
			{
				return this.duplicateruleidField;
			}
			set
			{
				this.duplicateruleidField = value;
				base.RaisePropertyChanged("duplicateruleid");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean iscasesensitive
		{
			get
			{
				return this.iscasesensitiveField;
			}
			set
			{
				this.iscasesensitiveField = value;
				base.RaisePropertyChanged("iscasesensitive");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string matchingentitymatchcodetable
		{
			get
			{
				return this.matchingentitymatchcodetableField;
			}
			set
			{
				this.matchingentitymatchcodetableField = value;
				base.RaisePropertyChanged("matchingentitymatchcodetable");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string matchingentityname
		{
			get
			{
				return this.matchingentitynameField;
			}
			set
			{
				this.matchingentitynameField = value;
				base.RaisePropertyChanged("matchingentityname");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist matchingentitytypecode
		{
			get
			{
				return this.matchingentitytypecodeField;
			}
			set
			{
				this.matchingentitytypecodeField = value;
				base.RaisePropertyChanged("matchingentitytypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public DuplicateRuleStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public duplicaterule()
		{
		}
	}
}