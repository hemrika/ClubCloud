using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class campaignresponse : BusinessEntity
	{
		private Key activityidField;
		private CrmNumber actualdurationminutesField;
		private CrmDateTime actualendField;
		private CrmDateTime actualstartField;
		private string categoryField;
		private Picklist channeltypecodeField;
		private string companynameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private activityparty[] customerField;
		private string descriptionField;
		private string emailaddressField;
		private string faxField;
		private string firstnameField;
		private activityparty[] fromField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isbilledField;
		private CrmBoolean isworkflowcreatedField;
		private string lastnameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup originatingactivityidField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private activityparty[] partnerField;
		private Picklist prioritycodeField;
		private string promotioncodenameField;
		private CrmDateTime receivedonField;
		private Lookup regardingobjectidField;
		private Picklist responsecodeField;
		private CrmNumber scheduleddurationminutesField;
		private CrmDateTime scheduledendField;
		private CrmDateTime scheduledstartField;
		private Lookup serviceidField;
		private Lookup sgt_formulier_antwoord_idField;
		private Lookup sgt_ideal_betaling_gebeurtenisidField;
		private CrmDateTime sgt_igm_voorkeur1Field;
		private CrmDateTime sgt_igm_voorkeur2Field;
		private CrmDateTime sgt_igm_voorkeur3Field;
		private Lookup sgt_persoonidField;
		private Lookup sgt_registered_byidField;
		private CrmDateTime sgt_tijdstip_bevestigdField;
		private CampaignResponseStateInfo statecodeField;
		private Status statuscodeField;
		private string subcategoryField;
		private string subjectField;
		private string telephoneField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		private string yomicompanynameField;
		private string yomifirstnameField;
		private string yomilastnameField;
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
		public Picklist channeltypecode
		{
			get
			{
				return this.channeltypecodeField;
			}
			set
			{
				this.channeltypecodeField = value;
			}
		}
		public string companyname
		{
			get
			{
				return this.companynameField;
			}
			set
			{
				this.companynameField = value;
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
		[XmlArrayItem(IsNullable = false)]
		public activityparty[] customer
		{
			get
			{
				return this.customerField;
			}
			set
			{
				this.customerField = value;
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
		public string emailaddress
		{
			get
			{
				return this.emailaddressField;
			}
			set
			{
				this.emailaddressField = value;
			}
		}
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
			}
		}
		public string firstname
		{
			get
			{
				return this.firstnameField;
			}
			set
			{
				this.firstnameField = value;
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
		public string lastname
		{
			get
			{
				return this.lastnameField;
			}
			set
			{
				this.lastnameField = value;
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
		public Lookup originatingactivityid
		{
			get
			{
				return this.originatingactivityidField;
			}
			set
			{
				this.originatingactivityidField = value;
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
		[XmlArrayItem(IsNullable = false)]
		public activityparty[] partner
		{
			get
			{
				return this.partnerField;
			}
			set
			{
				this.partnerField = value;
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
		public string promotioncodename
		{
			get
			{
				return this.promotioncodenameField;
			}
			set
			{
				this.promotioncodenameField = value;
			}
		}
		public CrmDateTime receivedon
		{
			get
			{
				return this.receivedonField;
			}
			set
			{
				this.receivedonField = value;
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
		public Picklist responsecode
		{
			get
			{
				return this.responsecodeField;
			}
			set
			{
				this.responsecodeField = value;
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
		public Lookup sgt_formulier_antwoord_id
		{
			get
			{
				return this.sgt_formulier_antwoord_idField;
			}
			set
			{
				this.sgt_formulier_antwoord_idField = value;
			}
		}
		public Lookup sgt_ideal_betaling_gebeurtenisid
		{
			get
			{
				return this.sgt_ideal_betaling_gebeurtenisidField;
			}
			set
			{
				this.sgt_ideal_betaling_gebeurtenisidField = value;
			}
		}
		public CrmDateTime sgt_igm_voorkeur1
		{
			get
			{
				return this.sgt_igm_voorkeur1Field;
			}
			set
			{
				this.sgt_igm_voorkeur1Field = value;
			}
		}
		public CrmDateTime sgt_igm_voorkeur2
		{
			get
			{
				return this.sgt_igm_voorkeur2Field;
			}
			set
			{
				this.sgt_igm_voorkeur2Field = value;
			}
		}
		public CrmDateTime sgt_igm_voorkeur3
		{
			get
			{
				return this.sgt_igm_voorkeur3Field;
			}
			set
			{
				this.sgt_igm_voorkeur3Field = value;
			}
		}
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
			}
		}
		public Lookup sgt_registered_byid
		{
			get
			{
				return this.sgt_registered_byidField;
			}
			set
			{
				this.sgt_registered_byidField = value;
			}
		}
		public CrmDateTime sgt_tijdstip_bevestigd
		{
			get
			{
				return this.sgt_tijdstip_bevestigdField;
			}
			set
			{
				this.sgt_tijdstip_bevestigdField = value;
			}
		}
		public CampaignResponseStateInfo statecode
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
		public string telephone
		{
			get
			{
				return this.telephoneField;
			}
			set
			{
				this.telephoneField = value;
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
		public string yomicompanyname
		{
			get
			{
				return this.yomicompanynameField;
			}
			set
			{
				this.yomicompanynameField = value;
			}
		}
		public string yomifirstname
		{
			get
			{
				return this.yomifirstnameField;
			}
			set
			{
				this.yomifirstnameField = value;
			}
		}
		public string yomilastname
		{
			get
			{
				return this.yomilastnameField;
			}
			set
			{
				this.yomilastnameField = value;
			}
		}
	}
}
