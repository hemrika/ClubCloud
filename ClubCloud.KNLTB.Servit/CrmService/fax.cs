using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class fax : BusinessEntity
	{
		private Key activityidField;
		private CrmNumber actualdurationminutesField;
		private CrmDateTime actualendField;
		private CrmDateTime actualstartField;
		private string billingcodeField;
		private string categoryField;
		private string coverpagenameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmBoolean directioncodeField;
		private string faxnumberField;
		private activityparty[] fromField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isbilledField;
		private CrmBoolean isworkflowcreatedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmNumber numberofpagesField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist prioritycodeField;
		private Lookup regardingobjectidField;
		private CrmNumber scheduleddurationminutesField;
		private CrmDateTime scheduledendField;
		private CrmDateTime scheduledstartField;
		private Lookup serviceidField;
		private FaxStateInfo statecodeField;
		private Status statuscodeField;
		private string subcategoryField;
		private string subjectField;
		private UniqueIdentifier subscriptionidField;
		private CrmNumber timezoneruleversionnumberField;
		private activityparty[] toField;
		private string tsidField;
		private CrmNumber utcconversiontimezonecodeField;
		public Key activityid
		{
			get
			{
				return this.activityidField;
			}
			set
			{
				this.activityidField = value;
			}
		}
		public CrmNumber actualdurationminutes
		{
			get
			{
				return this.actualdurationminutesField;
			}
			set
			{
				this.actualdurationminutesField = value;
			}
		}
		public CrmDateTime actualend
		{
			get
			{
				return this.actualendField;
			}
			set
			{
				this.actualendField = value;
			}
		}
		public CrmDateTime actualstart
		{
			get
			{
				return this.actualstartField;
			}
			set
			{
				this.actualstartField = value;
			}
		}
		public string billingcode
		{
			get
			{
				return this.billingcodeField;
			}
			set
			{
				this.billingcodeField = value;
			}
		}
		public string category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		public string coverpagename
		{
			get
			{
				return this.coverpagenameField;
			}
			set
			{
				this.coverpagenameField = value;
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
		public CrmBoolean directioncode
		{
			get
			{
				return this.directioncodeField;
			}
			set
			{
				this.directioncodeField = value;
			}
		}
		public string faxnumber
		{
			get
			{
				return this.faxnumberField;
			}
			set
			{
				this.faxnumberField = value;
			}
		}
		[XmlArrayItem(IsNullable = false)]
		public activityparty[] from
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
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
		public CrmBoolean isbilled
		{
			get
			{
				return this.isbilledField;
			}
			set
			{
				this.isbilledField = value;
			}
		}
		public CrmBoolean isworkflowcreated
		{
			get
			{
				return this.isworkflowcreatedField;
			}
			set
			{
				this.isworkflowcreatedField = value;
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
		public CrmNumber numberofpages
		{
			get
			{
				return this.numberofpagesField;
			}
			set
			{
				this.numberofpagesField = value;
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
		public Picklist prioritycode
		{
			get
			{
				return this.prioritycodeField;
			}
			set
			{
				this.prioritycodeField = value;
			}
		}
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
			}
		}
		public CrmNumber scheduleddurationminutes
		{
			get
			{
				return this.scheduleddurationminutesField;
			}
			set
			{
				this.scheduleddurationminutesField = value;
			}
		}
		public CrmDateTime scheduledend
		{
			get
			{
				return this.scheduledendField;
			}
			set
			{
				this.scheduledendField = value;
			}
		}
		public CrmDateTime scheduledstart
		{
			get
			{
				return this.scheduledstartField;
			}
			set
			{
				this.scheduledstartField = value;
			}
		}
		public Lookup serviceid
		{
			get
			{
				return this.serviceidField;
			}
			set
			{
				this.serviceidField = value;
			}
		}
		public FaxStateInfo statecode
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
		public string subcategory
		{
			get
			{
				return this.subcategoryField;
			}
			set
			{
				this.subcategoryField = value;
			}
		}
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}
		public UniqueIdentifier subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
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
		[XmlArrayItem(IsNullable = false)]
		public activityparty[] to
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
			}
		}
		public string tsid
		{
			get
			{
				return this.tsidField;
			}
			set
			{
				this.tsidField = value;
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