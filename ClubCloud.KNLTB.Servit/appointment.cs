using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class appointment : BusinessEntity
	{
		private Key activityidField;
		private CrmNumber actualdurationminutesField;
		private CrmDateTime actualendField;
		private CrmDateTime actualstartField;
		private string categoryField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private string globalobjectidField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isalldayeventField;
		private CrmBoolean isbilledField;
		private CrmBoolean isworkflowcreatedField;
		private string locationField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private activityparty[] optionalattendeesField;
		private activityparty[] organizerField;
		private CrmNumber outlookownerapptidField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist prioritycodeField;
		private Lookup regardingobjectidField;
		private activityparty[] requiredattendeesField;
		private CrmNumber scheduleddurationminutesField;
		private CrmDateTime scheduledendField;
		private CrmDateTime scheduledstartField;
		private Lookup serviceidField;
		private Lookup sgt_onderwerp1_idField;
		private Lookup sgt_onderwerp2_idField;
		private Lookup sgt_onderwerp3_idField;
		private AppointmentStateInfo statecodeField;
		private Status statuscodeField;
		private string subcategoryField;
		private string subjectField;
		private UniqueIdentifier subscriptionidField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
		public Key activityid
		{
			get
			{
				return this.activityidField;
			}
			set
			{
				this.activityidField = value;
				base.RaisePropertyChanged("activityid");
			}
		}
		[XmlElement(Order = 1)]
		public CrmNumber actualdurationminutes
		{
			get
			{
				return this.actualdurationminutesField;
			}
			set
			{
				this.actualdurationminutesField = value;
				base.RaisePropertyChanged("actualdurationminutes");
			}
		}
		[XmlElement(Order = 2)]
		public CrmDateTime actualend
		{
			get
			{
				return this.actualendField;
			}
			set
			{
				this.actualendField = value;
				base.RaisePropertyChanged("actualend");
			}
		}
		[XmlElement(Order = 3)]
		public CrmDateTime actualstart
		{
			get
			{
				return this.actualstartField;
			}
			set
			{
				this.actualstartField = value;
				base.RaisePropertyChanged("actualstart");
			}
		}
		[XmlElement(Order = 4)]
		public string category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				base.RaisePropertyChanged("category");
			}
		}
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public string globalobjectid
		{
			get
			{
				return this.globalobjectidField;
			}
			set
			{
				this.globalobjectidField = value;
				base.RaisePropertyChanged("globalobjectid");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public CrmBoolean isalldayevent
		{
			get
			{
				return this.isalldayeventField;
			}
			set
			{
				this.isalldayeventField = value;
				base.RaisePropertyChanged("isalldayevent");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean isbilled
		{
			get
			{
				return this.isbilledField;
			}
			set
			{
				this.isbilledField = value;
				base.RaisePropertyChanged("isbilled");
			}
		}
		[XmlElement(Order = 12)]
		public CrmBoolean isworkflowcreated
		{
			get
			{
				return this.isworkflowcreatedField;
			}
			set
			{
				this.isworkflowcreatedField = value;
				base.RaisePropertyChanged("isworkflowcreated");
			}
		}
		[XmlElement(Order = 13)]
		public string location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
				base.RaisePropertyChanged("location");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlArray(Order = 16), XmlArrayItem(IsNullable = false)]
		public activityparty[] optionalattendees
		{
			get
			{
				return this.optionalattendeesField;
			}
			set
			{
				this.optionalattendeesField = value;
				base.RaisePropertyChanged("optionalattendees");
			}
		}
		[XmlArray(Order = 17), XmlArrayItem(IsNullable = false)]
		public activityparty[] organizer
		{
			get
			{
				return this.organizerField;
			}
			set
			{
				this.organizerField = value;
				base.RaisePropertyChanged("organizer");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber outlookownerapptid
		{
			get
			{
				return this.outlookownerapptidField;
			}
			set
			{
				this.outlookownerapptidField = value;
				base.RaisePropertyChanged("outlookownerapptid");
			}
		}
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
		public Picklist prioritycode
		{
			get
			{
				return this.prioritycodeField;
			}
			set
			{
				this.prioritycodeField = value;
				base.RaisePropertyChanged("prioritycode");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
				base.RaisePropertyChanged("regardingobjectid");
			}
		}
		[XmlArray(Order = 24), XmlArrayItem(IsNullable = false)]
		public activityparty[] requiredattendees
		{
			get
			{
				return this.requiredattendeesField;
			}
			set
			{
				this.requiredattendeesField = value;
				base.RaisePropertyChanged("requiredattendees");
			}
		}
		[XmlElement(Order = 25)]
		public CrmNumber scheduleddurationminutes
		{
			get
			{
				return this.scheduleddurationminutesField;
			}
			set
			{
				this.scheduleddurationminutesField = value;
				base.RaisePropertyChanged("scheduleddurationminutes");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDateTime scheduledend
		{
			get
			{
				return this.scheduledendField;
			}
			set
			{
				this.scheduledendField = value;
				base.RaisePropertyChanged("scheduledend");
			}
		}
		[XmlElement(Order = 27)]
		public CrmDateTime scheduledstart
		{
			get
			{
				return this.scheduledstartField;
			}
			set
			{
				this.scheduledstartField = value;
				base.RaisePropertyChanged("scheduledstart");
			}
		}
		[XmlElement(Order = 28)]
		public Lookup serviceid
		{
			get
			{
				return this.serviceidField;
			}
			set
			{
				this.serviceidField = value;
				base.RaisePropertyChanged("serviceid");
			}
		}
		[XmlElement(Order = 29)]
		public Lookup sgt_onderwerp1_id
		{
			get
			{
				return this.sgt_onderwerp1_idField;
			}
			set
			{
				this.sgt_onderwerp1_idField = value;
				base.RaisePropertyChanged("sgt_onderwerp1_id");
			}
		}
		[XmlElement(Order = 30)]
		public Lookup sgt_onderwerp2_id
		{
			get
			{
				return this.sgt_onderwerp2_idField;
			}
			set
			{
				this.sgt_onderwerp2_idField = value;
				base.RaisePropertyChanged("sgt_onderwerp2_id");
			}
		}
		[XmlElement(Order = 31)]
		public Lookup sgt_onderwerp3_id
		{
			get
			{
				return this.sgt_onderwerp3_idField;
			}
			set
			{
				this.sgt_onderwerp3_idField = value;
				base.RaisePropertyChanged("sgt_onderwerp3_id");
			}
		}
		[XmlElement(Order = 32)]
		public AppointmentStateInfo statecode
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
		public string subcategory
		{
			get
			{
				return this.subcategoryField;
			}
			set
			{
				this.subcategoryField = value;
				base.RaisePropertyChanged("subcategory");
			}
		}
		[XmlElement(Order = 35)]
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
				base.RaisePropertyChanged("subject");
			}
		}
		[XmlElement(Order = 36)]
		public UniqueIdentifier subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
				base.RaisePropertyChanged("subscriptionid");
			}
		}
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
