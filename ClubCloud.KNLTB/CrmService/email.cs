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
	public class email : BusinessEntity
	{
		private Key activityidField;

		private CrmNumber actualdurationminutesField;

		private CrmDateTime actualendField;

		private CrmDateTime actualstartField;

		private activityparty[] bccField;

		private string categoryField;

		private activityparty[] ccField;

		private CrmBoolean compressedField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber deliveryattemptsField;

		private CrmBoolean deliveryreceiptrequestedField;

		private string descriptionField;

		private CrmBoolean directioncodeField;

		private activityparty[] fromField;

		private CrmNumber importsequencenumberField;

		private CrmBoolean isbilledField;

		private CrmBoolean isworkflowcreatedField;

		private string messageidField;

		private UniqueIdentifier messageiddupcheckField;

		private string mimetypeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Picklist notificationsField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Picklist prioritycodeField;

		private CrmBoolean readreceiptrequestedField;

		private Lookup regardingobjectidField;

		private CrmNumber scheduleddurationminutesField;

		private CrmDateTime scheduledendField;

		private CrmDateTime scheduledstartField;

		private string senderField;

		private Lookup serviceidField;

		private Picklist sgt_mailing_typeField;

		private Lookup sgt_onderwerp1_idField;

		private Lookup sgt_onderwerp2_idField;

		private Lookup sgt_onderwerp3_idField;

		private EmailStateInfo statecodeField;

		private Status statuscodeField;

		private string subcategoryField;

		private string subjectField;

		private string submittedbyField;

		private CrmNumber timezoneruleversionnumberField;

		private activityparty[] toField;

		private string torecipientsField;

		private string trackingtokenField;

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

		[XmlArray] //[XmlArray(Order=4)]
		[XmlArrayItem(IsNullable=false)]
		public activityparty[] bcc
		{
			get
			{
				return this.bccField;
			}
			set
			{
				this.bccField = value;
				base.RaisePropertyChanged("bcc");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlArray] //[XmlArray(Order=6)]
		[XmlArrayItem(IsNullable=false)]
		public activityparty[] cc
		{
			get
			{
				return this.ccField;
			}
			set
			{
				this.ccField = value;
				base.RaisePropertyChanged("cc");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean compressed
		{
			get
			{
				return this.compressedField;
			}
			set
			{
				this.compressedField = value;
				base.RaisePropertyChanged("compressed");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber deliveryattempts
		{
			get
			{
				return this.deliveryattemptsField;
			}
			set
			{
				this.deliveryattemptsField = value;
				base.RaisePropertyChanged("deliveryattempts");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean deliveryreceiptrequested
		{
			get
			{
				return this.deliveryreceiptrequestedField;
			}
			set
			{
				this.deliveryreceiptrequestedField = value;
				base.RaisePropertyChanged("deliveryreceiptrequested");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean directioncode
		{
			get
			{
				return this.directioncodeField;
			}
			set
			{
				this.directioncodeField = value;
				base.RaisePropertyChanged("directioncode");
			}
		}

		[XmlArray] //[XmlArray(Order=14)]
		[XmlArrayItem(IsNullable=false)]
		public activityparty[] @from
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
				base.RaisePropertyChanged("from");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public string messageid
		{
			get
			{
				return this.messageidField;
			}
			set
			{
				this.messageidField = value;
				base.RaisePropertyChanged("messageid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public UniqueIdentifier messageiddupcheck
		{
			get
			{
				return this.messageiddupcheckField;
			}
			set
			{
				this.messageiddupcheckField = value;
				base.RaisePropertyChanged("messageiddupcheck");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
				base.RaisePropertyChanged("mimetype");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
		public Picklist notifications
		{
			get
			{
				return this.notificationsField;
			}
			set
			{
				this.notificationsField = value;
				base.RaisePropertyChanged("notifications");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
		public CrmBoolean readreceiptrequested
		{
			get
			{
				return this.readreceiptrequestedField;
			}
			set
			{
				this.readreceiptrequestedField = value;
				base.RaisePropertyChanged("readreceiptrequested");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
		public string sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
				base.RaisePropertyChanged("sender");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
		public Picklist sgt_mailing_type
		{
			get
			{
				return this.sgt_mailing_typeField;
			}
			set
			{
				this.sgt_mailing_typeField = value;
				base.RaisePropertyChanged("sgt_mailing_type");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
		public EmailStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=40)]
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

		[XmlElement] //[XmlElement(Order=41)]
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

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
		public string submittedby
		{
			get
			{
				return this.submittedbyField;
			}
			set
			{
				this.submittedbyField = value;
				base.RaisePropertyChanged("submittedby");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlArray] //[XmlArray(Order=45)]
		[XmlArrayItem(IsNullable=false)]
		public activityparty[] to
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
				base.RaisePropertyChanged("to");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public string torecipients
		{
			get
			{
				return this.torecipientsField;
			}
			set
			{
				this.torecipientsField = value;
				base.RaisePropertyChanged("torecipients");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public string trackingtoken
		{
			get
			{
				return this.trackingtokenField;
			}
			set
			{
				this.trackingtokenField = value;
				base.RaisePropertyChanged("trackingtoken");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
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

		public email()
		{
		}
	}
}