using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class campaignactivity : BusinessEntity
	{
		private Key activityidField;
		private CrmMoney actualcostField;
		private CrmMoney actualcost_baseField;
		private CrmNumber actualdurationminutesField;
		private CrmDateTime actualendField;
		private CrmDateTime actualstartField;
		private CrmMoney budgetedcostField;
		private CrmMoney budgetedcost_baseField;
		private string categoryField;
		private Picklist channeltypecodeField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmBoolean donotsendonoptoutField;
		private CrmDecimal exchangerateField;
		private CrmNumber excludeifcontactedinxdaysField;
		private activityparty[] fromField;
		private CrmBoolean ignoreinactivelistmembersField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isbilledField;
		private CrmBoolean isworkflowcreatedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private activityparty[] partnersField;
		private Picklist prioritycodeField;
		private Lookup regardingobjectidField;
		private CrmNumber scheduleddurationminutesField;
		private CrmDateTime scheduledendField;
		private CrmDateTime scheduledstartField;
		private Lookup serviceidField;
		private CampaignActivityStateInfo statecodeField;
		private Status statuscodeField;
		private string subcategoryField;
		private string subjectField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private Picklist typecodeField;
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
		public CrmMoney actualcost
		{
			get
			{
				return this.actualcostField;
			}
			set
			{
				this.actualcostField = value;
				base.RaisePropertyChanged("actualcost");
			}
		}
		[XmlElement(Order = 2)]
		public CrmMoney actualcost_base
		{
			get
			{
				return this.actualcost_baseField;
			}
			set
			{
				this.actualcost_baseField = value;
				base.RaisePropertyChanged("actualcost_base");
			}
		}
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public CrmMoney budgetedcost
		{
			get
			{
				return this.budgetedcostField;
			}
			set
			{
				this.budgetedcostField = value;
				base.RaisePropertyChanged("budgetedcost");
			}
		}
		[XmlElement(Order = 7)]
		public CrmMoney budgetedcost_base
		{
			get
			{
				return this.budgetedcost_baseField;
			}
			set
			{
				this.budgetedcost_baseField = value;
				base.RaisePropertyChanged("budgetedcost_base");
			}
		}
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public CrmBoolean donotsendonoptout
		{
			get
			{
				return this.donotsendonoptoutField;
			}
			set
			{
				this.donotsendonoptoutField = value;
				base.RaisePropertyChanged("donotsendonoptout");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}
		[XmlElement(Order = 15)]
		public CrmNumber excludeifcontactedinxdays
		{
			get
			{
				return this.excludeifcontactedinxdaysField;
			}
			set
			{
				this.excludeifcontactedinxdaysField = value;
				base.RaisePropertyChanged("excludeifcontactedinxdays");
			}
		}
		[XmlArray(Order = 16), XmlArrayItem(IsNullable = false)]
		public activityparty[] from
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
		[XmlElement(Order = 17)]
		public CrmBoolean ignoreinactivelistmembers
		{
			get
			{
				return this.ignoreinactivelistmembersField;
			}
			set
			{
				this.ignoreinactivelistmembersField = value;
				base.RaisePropertyChanged("ignoreinactivelistmembers");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlArray(Order = 26), XmlArrayItem(IsNullable = false)]
		public activityparty[] partners
		{
			get
			{
				return this.partnersField;
			}
			set
			{
				this.partnersField = value;
				base.RaisePropertyChanged("partners");
			}
		}
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
		public CampaignActivityStateInfo statecode
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
		[XmlElement(Order = 34)]
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}
		[XmlElement(Order = 39)]
		public Picklist typecode
		{
			get
			{
				return this.typecodeField;
			}
			set
			{
				this.typecodeField = value;
				base.RaisePropertyChanged("typecode");
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
