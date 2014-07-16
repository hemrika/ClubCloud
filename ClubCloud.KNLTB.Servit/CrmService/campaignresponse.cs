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

		[XmlElement] //[XmlElement(Order=5)]
		public Picklist channeltypecode
		{
			get
			{
				return this.channeltypecodeField;
			}
			set
			{
				this.channeltypecodeField = value;
				base.RaisePropertyChanged("channeltypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string companyname
		{
			get
			{
				return this.companynameField;
			}
			set
			{
				this.companynameField = value;
				base.RaisePropertyChanged("companyname");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlArray] //[XmlArray(Order=9)]
		[XmlArrayItem(IsNullable=false)]
		public activityparty[] customer
		{
			get
			{
				return this.customerField;
			}
			set
			{
				this.customerField = value;
				base.RaisePropertyChanged("customer");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public string emailaddress
		{
			get
			{
				return this.emailaddressField;
			}
			set
			{
				this.emailaddressField = value;
				base.RaisePropertyChanged("emailaddress");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
				base.RaisePropertyChanged("fax");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string firstname
		{
			get
			{
				return this.firstnameField;
			}
			set
			{
				this.firstnameField = value;
				base.RaisePropertyChanged("firstname");
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
		public string lastname
		{
			get
			{
				return this.lastnameField;
			}
			set
			{
				this.lastnameField = value;
				base.RaisePropertyChanged("lastname");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup originatingactivityid
		{
			get
			{
				return this.originatingactivityidField;
			}
			set
			{
				this.originatingactivityidField = value;
				base.RaisePropertyChanged("originatingactivityid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlArray] //[XmlArray(Order=25)]
		[XmlArrayItem(IsNullable=false)]
		public activityparty[] partner
		{
			get
			{
				return this.partnerField;
			}
			set
			{
				this.partnerField = value;
				base.RaisePropertyChanged("partner");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
		public string promotioncodename
		{
			get
			{
				return this.promotioncodenameField;
			}
			set
			{
				this.promotioncodenameField = value;
				base.RaisePropertyChanged("promotioncodename");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmDateTime receivedon
		{
			get
			{
				return this.receivedonField;
			}
			set
			{
				this.receivedonField = value;
				base.RaisePropertyChanged("receivedon");
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
		public Picklist responsecode
		{
			get
			{
				return this.responsecodeField;
			}
			set
			{
				this.responsecodeField = value;
				base.RaisePropertyChanged("responsecode");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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
		public Lookup sgt_formulier_antwoord_id
		{
			get
			{
				return this.sgt_formulier_antwoord_idField;
			}
			set
			{
				this.sgt_formulier_antwoord_idField = value;
				base.RaisePropertyChanged("sgt_formulier_antwoord_id");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Lookup sgt_ideal_betaling_gebeurtenisid
		{
			get
			{
				return this.sgt_ideal_betaling_gebeurtenisidField;
			}
			set
			{
				this.sgt_ideal_betaling_gebeurtenisidField = value;
				base.RaisePropertyChanged("sgt_ideal_betaling_gebeurtenisid");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public Lookup sgt_registered_byid
		{
			get
			{
				return this.sgt_registered_byidField;
			}
			set
			{
				this.sgt_registered_byidField = value;
				base.RaisePropertyChanged("sgt_registered_byid");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public CrmDateTime sgt_tijdstip_bevestigd
		{
			get
			{
				return this.sgt_tijdstip_bevestigdField;
			}
			set
			{
				this.sgt_tijdstip_bevestigdField = value;
				base.RaisePropertyChanged("sgt_tijdstip_bevestigd");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public CampaignResponseStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
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

		[XmlElement] //[XmlElement(Order=47)]
		public string telephone
		{
			get
			{
				return this.telephoneField;
			}
			set
			{
				this.telephoneField = value;
				base.RaisePropertyChanged("telephone");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
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

		[XmlElement] //[XmlElement(Order=49)]
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

		[XmlElement] //[XmlElement(Order=50)]
		public string yomicompanyname
		{
			get
			{
				return this.yomicompanynameField;
			}
			set
			{
				this.yomicompanynameField = value;
				base.RaisePropertyChanged("yomicompanyname");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public string yomifirstname
		{
			get
			{
				return this.yomifirstnameField;
			}
			set
			{
				this.yomifirstnameField = value;
				base.RaisePropertyChanged("yomifirstname");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public string yomilastname
		{
			get
			{
				return this.yomilastnameField;
			}
			set
			{
				this.yomilastnameField = value;
				base.RaisePropertyChanged("yomilastname");
			}
		}

		public campaignresponse()
		{
		}
	}
}