using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class serviceappointment : BusinessEntity
	{
		private Key activityidField;
		private CrmNumber actualdurationminutesField;
		private CrmDateTime actualendField;
		private CrmDateTime actualstartField;
		private string categoryField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private activityparty[] customersField;
		private string descriptionField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isalldayeventField;
		private CrmBoolean isbilledField;
		private CrmBoolean isworkflowcreatedField;
		private string locationField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist prioritycodeField;
		private Lookup regardingobjectidField;
		private activityparty[] resourcesField;
		private CrmNumber scheduleddurationminutesField;
		private CrmDateTime scheduledendField;
		private CrmDateTime scheduledstartField;
		private Lookup serviceidField;
		private Lookup sgt_formulier_antwoord_sa_idField;
		private CrmDateTime sgt_igm_voorkeur1Field;
		private CrmDateTime sgt_igm_voorkeur2Field;
		private CrmDateTime sgt_igm_voorkeur3Field;
		private Lookup sgt_onderwerp1_idField;
		private Lookup sgt_onderwerp2_idField;
		private Lookup sgt_onderwerp3_idField;
		private Lookup siteidField;
		private ServiceAppointmentStateInfo statecodeField;
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
		[XmlArray(Order = 7), XmlArrayItem(IsNullable = false)]
		public activityparty[] customers
		{
			get
			{
				return this.customersField;
			}
			set
			{
				this.customersField = value;
				base.RaisePropertyChanged("customers");
			}
		}
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlArray(Order = 21), XmlArrayItem(IsNullable = false)]
		public activityparty[] resources
		{
			get
			{
				return this.resourcesField;
			}
			set
			{
				this.resourcesField = value;
				base.RaisePropertyChanged("resources");
			}
		}
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
		public Lookup sgt_formulier_antwoord_sa_id
		{
			get
			{
				return this.sgt_formulier_antwoord_sa_idField;
			}
			set
			{
				this.sgt_formulier_antwoord_sa_idField = value;
				base.RaisePropertyChanged("sgt_formulier_antwoord_sa_id");
			}
		}
		[XmlElement(Order = 27)]
		public CrmDateTime sgt_igm_voorkeur1
		{
			get
			{
				return this.sgt_igm_voorkeur1Field;
			}
			set
			{
				this.sgt_igm_voorkeur1Field = value;
				base.RaisePropertyChanged("sgt_igm_voorkeur1");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDateTime sgt_igm_voorkeur2
		{
			get
			{
				return this.sgt_igm_voorkeur2Field;
			}
			set
			{
				this.sgt_igm_voorkeur2Field = value;
				base.RaisePropertyChanged("sgt_igm_voorkeur2");
			}
		}
		[XmlElement(Order = 29)]
		public CrmDateTime sgt_igm_voorkeur3
		{
			get
			{
				return this.sgt_igm_voorkeur3Field;
			}
			set
			{
				this.sgt_igm_voorkeur3Field = value;
				base.RaisePropertyChanged("sgt_igm_voorkeur3");
			}
		}
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
		public ServiceAppointmentStateInfo statecode
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
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
