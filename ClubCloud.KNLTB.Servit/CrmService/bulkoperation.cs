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
	public class bulkoperation : BusinessEntity
	{
		private Key activityidField;

		private CrmNumber actualdurationminutesField;

		private CrmDateTime actualendField;

		private CrmDateTime actualstartField;

		private string bulkoperationnumberField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Picklist createdrecordtypecodeField;

		private string descriptionField;

		private CrmNumber errornumberField;

		private CrmNumber failurecountField;

		private CrmBoolean isbilledField;

		private CrmBoolean isworkflowcreatedField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Picklist operationtypecodeField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string parametersField;

		private Lookup regardingobjectidField;

		private CrmNumber scheduleddurationminutesField;

		private CrmDateTime scheduledendField;

		private CrmDateTime scheduledstartField;

		private Lookup serviceidField;

		private BulkOperationStateInfo statecodeField;

		private Status statuscodeField;

		private string subjectField;

		private CrmNumber successcountField;

		private Picklist targetedrecordtypecodeField;

		private CrmNumber targetmemberscountField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
		public string bulkoperationnumber
		{
			get
			{
				return this.bulkoperationnumberField;
			}
			set
			{
				this.bulkoperationnumberField = value;
				base.RaisePropertyChanged("bulkoperationnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Picklist createdrecordtypecode
		{
			get
			{
				return this.createdrecordtypecodeField;
			}
			set
			{
				this.createdrecordtypecodeField = value;
				base.RaisePropertyChanged("createdrecordtypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber errornumber
		{
			get
			{
				return this.errornumberField;
			}
			set
			{
				this.errornumberField = value;
				base.RaisePropertyChanged("errornumber");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber failurecount
		{
			get
			{
				return this.failurecountField;
			}
			set
			{
				this.failurecountField = value;
				base.RaisePropertyChanged("failurecount");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist operationtypecode
		{
			get
			{
				return this.operationtypecodeField;
			}
			set
			{
				this.operationtypecodeField = value;
				base.RaisePropertyChanged("operationtypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public string parameters
		{
			get
			{
				return this.parametersField;
			}
			set
			{
				this.parametersField = value;
				base.RaisePropertyChanged("parameters");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
		public BulkOperationStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
		public CrmNumber successcount
		{
			get
			{
				return this.successcountField;
			}
			set
			{
				this.successcountField = value;
				base.RaisePropertyChanged("successcount");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Picklist targetedrecordtypecode
		{
			get
			{
				return this.targetedrecordtypecodeField;
			}
			set
			{
				this.targetedrecordtypecodeField = value;
				base.RaisePropertyChanged("targetedrecordtypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmNumber targetmemberscount
		{
			get
			{
				return this.targetmemberscountField;
			}
			set
			{
				this.targetmemberscountField = value;
				base.RaisePropertyChanged("targetmemberscount");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		public bulkoperation()
		{
		}
	}
}