using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class campaign : BusinessEntity
	{
		private CrmDateTime actualendField;
		private CrmDateTime actualstartField;
		private CrmMoney budgetedcostField;
		private CrmMoney budgetedcost_baseField;
		private Key campaignidField;
		private string codenameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmDecimal exchangerateField;
		private CrmNumber expectedresponseField;
		private CrmMoney expectedrevenueField;
		private CrmMoney expectedrevenue_baseField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean istemplateField;
		private string messageField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private string objectiveField;
		private CrmMoney othercostField;
		private CrmMoney othercost_baseField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup pricelistidField;
		private string promotioncodenameField;
		private CrmDateTime proposedendField;
		private CrmDateTime proposedstartField;
		private Lookup sgt_gebeurtenisidField;
		private CampaignStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmMoney totalactualcostField;
		private CrmMoney totalactualcost_baseField;
		private CrmMoney totalcampaignactivityactualcostField;
		private CrmMoney totalcampaignactivityactualcost_baseField;
		private Lookup transactioncurrencyidField;
		private Picklist typecodeField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
		public Key campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
				base.RaisePropertyChanged("campaignid");
			}
		}
		[XmlElement(Order = 5)]
		public string codename
		{
			get
			{
				return this.codenameField;
			}
			set
			{
				this.codenameField = value;
				base.RaisePropertyChanged("codename");
			}
		}
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 10)]
		public CrmNumber expectedresponse
		{
			get
			{
				return this.expectedresponseField;
			}
			set
			{
				this.expectedresponseField = value;
				base.RaisePropertyChanged("expectedresponse");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney expectedrevenue
		{
			get
			{
				return this.expectedrevenueField;
			}
			set
			{
				this.expectedrevenueField = value;
				base.RaisePropertyChanged("expectedrevenue");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney expectedrevenue_base
		{
			get
			{
				return this.expectedrevenue_baseField;
			}
			set
			{
				this.expectedrevenue_baseField = value;
				base.RaisePropertyChanged("expectedrevenue_base");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public CrmBoolean istemplate
		{
			get
			{
				return this.istemplateField;
			}
			set
			{
				this.istemplateField = value;
				base.RaisePropertyChanged("istemplate");
			}
		}
		[XmlElement(Order = 15)]
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
				base.RaisePropertyChanged("message");
			}
		}
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
		public string objective
		{
			get
			{
				return this.objectiveField;
			}
			set
			{
				this.objectiveField = value;
				base.RaisePropertyChanged("objective");
			}
		}
		[XmlElement(Order = 20)]
		public CrmMoney othercost
		{
			get
			{
				return this.othercostField;
			}
			set
			{
				this.othercostField = value;
				base.RaisePropertyChanged("othercost");
			}
		}
		[XmlElement(Order = 21)]
		public CrmMoney othercost_base
		{
			get
			{
				return this.othercost_baseField;
			}
			set
			{
				this.othercost_baseField = value;
				base.RaisePropertyChanged("othercost_base");
			}
		}
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
		public Lookup pricelistid
		{
			get
			{
				return this.pricelistidField;
			}
			set
			{
				this.pricelistidField = value;
				base.RaisePropertyChanged("pricelistid");
			}
		}
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
		public CrmDateTime proposedend
		{
			get
			{
				return this.proposedendField;
			}
			set
			{
				this.proposedendField = value;
				base.RaisePropertyChanged("proposedend");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDateTime proposedstart
		{
			get
			{
				return this.proposedstartField;
			}
			set
			{
				this.proposedstartField = value;
				base.RaisePropertyChanged("proposedstart");
			}
		}
		[XmlElement(Order = 29)]
		public Lookup sgt_gebeurtenisid
		{
			get
			{
				return this.sgt_gebeurtenisidField;
			}
			set
			{
				this.sgt_gebeurtenisidField = value;
				base.RaisePropertyChanged("sgt_gebeurtenisid");
			}
		}
		[XmlElement(Order = 30)]
		public CampaignStateInfo statecode
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
		public CrmMoney totalactualcost
		{
			get
			{
				return this.totalactualcostField;
			}
			set
			{
				this.totalactualcostField = value;
				base.RaisePropertyChanged("totalactualcost");
			}
		}
		[XmlElement(Order = 34)]
		public CrmMoney totalactualcost_base
		{
			get
			{
				return this.totalactualcost_baseField;
			}
			set
			{
				this.totalactualcost_baseField = value;
				base.RaisePropertyChanged("totalactualcost_base");
			}
		}
		[XmlElement(Order = 35)]
		public CrmMoney totalcampaignactivityactualcost
		{
			get
			{
				return this.totalcampaignactivityactualcostField;
			}
			set
			{
				this.totalcampaignactivityactualcostField = value;
				base.RaisePropertyChanged("totalcampaignactivityactualcost");
			}
		}
		[XmlElement(Order = 36)]
		public CrmMoney totalcampaignactivityactualcost_base
		{
			get
			{
				return this.totalcampaignactivityactualcost_baseField;
			}
			set
			{
				this.totalcampaignactivityactualcost_baseField = value;
				base.RaisePropertyChanged("totalcampaignactivityactualcost_base");
			}
		}
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
