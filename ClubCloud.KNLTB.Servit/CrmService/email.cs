using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		[XmlArrayItem(IsNullable = false)]
		public activityparty[] bcc
		{
			get
			{
				return this.bccField;
			}
			set
			{
				this.bccField = value;
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
		[XmlArrayItem(IsNullable = false)]
		public activityparty[] cc
		{
			get
			{
				return this.ccField;
			}
			set
			{
				this.ccField = value;
			}
		}
		public CrmBoolean compressed
		{
			get
			{
				return this.compressedField;
			}
			set
			{
				this.compressedField = value;
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
		public CrmNumber deliveryattempts
		{
			get
			{
				return this.deliveryattemptsField;
			}
			set
			{
				this.deliveryattemptsField = value;
			}
		}
		public CrmBoolean deliveryreceiptrequested
		{
			get
			{
				return this.deliveryreceiptrequestedField;
			}
			set
			{
				this.deliveryreceiptrequestedField = value;
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
		public string messageid
		{
			get
			{
				return this.messageidField;
			}
			set
			{
				this.messageidField = value;
			}
		}
		public UniqueIdentifier messageiddupcheck
		{
			get
			{
				return this.messageiddupcheckField;
			}
			set
			{
				this.messageiddupcheckField = value;
			}
		}
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
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
		public Picklist notifications
		{
			get
			{
				return this.notificationsField;
			}
			set
			{
				this.notificationsField = value;
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
		public CrmBoolean readreceiptrequested
		{
			get
			{
				return this.readreceiptrequestedField;
			}
			set
			{
				this.readreceiptrequestedField = value;
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
		public string sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
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
		public Picklist sgt_mailing_type
		{
			get
			{
				return this.sgt_mailing_typeField;
			}
			set
			{
				this.sgt_mailing_typeField = value;
			}
		}
		public Lookup sgt_onderwerp1_id
		{
			get
			{
				return this.sgt_onderwerp1_idField;
			}
			set
			{
				this.sgt_onderwerp1_idField = value;
			}
		}
		public Lookup sgt_onderwerp2_id
		{
			get
			{
				return this.sgt_onderwerp2_idField;
			}
			set
			{
				this.sgt_onderwerp2_idField = value;
			}
		}
		public Lookup sgt_onderwerp3_id
		{
			get
			{
				return this.sgt_onderwerp3_idField;
			}
			set
			{
				this.sgt_onderwerp3_idField = value;
			}
		}
		public EmailStateInfo statecode
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
		public string submittedby
		{
			get
			{
				return this.submittedbyField;
			}
			set
			{
				this.submittedbyField = value;
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
		public string torecipients
		{
			get
			{
				return this.torecipientsField;
			}
			set
			{
				this.torecipientsField = value;
			}
		}
		public string trackingtoken
		{
			get
			{
				return this.trackingtokenField;
			}
			set
			{
				this.trackingtokenField = value;
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