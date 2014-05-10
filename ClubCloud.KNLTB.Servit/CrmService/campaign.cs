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
		public CrmMoney budgetedcost
		{
			get
			{
				return this.budgetedcostField;
			}
			set
			{
				this.budgetedcostField = value;
			}
		}
		public CrmMoney budgetedcost_base
		{
			get
			{
				return this.budgetedcost_baseField;
			}
			set
			{
				this.budgetedcost_baseField = value;
			}
		}
		public Key campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
			}
		}
		public string codename
		{
			get
			{
				return this.codenameField;
			}
			set
			{
				this.codenameField = value;
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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
			}
		}
		public CrmNumber expectedresponse
		{
			get
			{
				return this.expectedresponseField;
			}
			set
			{
				this.expectedresponseField = value;
			}
		}
		public CrmMoney expectedrevenue
		{
			get
			{
				return this.expectedrevenueField;
			}
			set
			{
				this.expectedrevenueField = value;
			}
		}
		public CrmMoney expectedrevenue_base
		{
			get
			{
				return this.expectedrevenue_baseField;
			}
			set
			{
				this.expectedrevenue_baseField = value;
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
		public CrmBoolean istemplate
		{
			get
			{
				return this.istemplateField;
			}
			set
			{
				this.istemplateField = value;
			}
		}
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public string objective
		{
			get
			{
				return this.objectiveField;
			}
			set
			{
				this.objectiveField = value;
			}
		}
		public CrmMoney othercost
		{
			get
			{
				return this.othercostField;
			}
			set
			{
				this.othercostField = value;
			}
		}
		public CrmMoney othercost_base
		{
			get
			{
				return this.othercost_baseField;
			}
			set
			{
				this.othercost_baseField = value;
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
		public Lookup pricelistid
		{
			get
			{
				return this.pricelistidField;
			}
			set
			{
				this.pricelistidField = value;
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
		public CrmDateTime proposedend
		{
			get
			{
				return this.proposedendField;
			}
			set
			{
				this.proposedendField = value;
			}
		}
		public CrmDateTime proposedstart
		{
			get
			{
				return this.proposedstartField;
			}
			set
			{
				this.proposedstartField = value;
			}
		}
		public Lookup sgt_gebeurtenisid
		{
			get
			{
				return this.sgt_gebeurtenisidField;
			}
			set
			{
				this.sgt_gebeurtenisidField = value;
			}
		}
		public CampaignStateInfo statecode
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
		public CrmMoney totalactualcost
		{
			get
			{
				return this.totalactualcostField;
			}
			set
			{
				this.totalactualcostField = value;
			}
		}
		public CrmMoney totalactualcost_base
		{
			get
			{
				return this.totalactualcost_baseField;
			}
			set
			{
				this.totalactualcost_baseField = value;
			}
		}
		public CrmMoney totalcampaignactivityactualcost
		{
			get
			{
				return this.totalcampaignactivityactualcostField;
			}
			set
			{
				this.totalcampaignactivityactualcostField = value;
			}
		}
		public CrmMoney totalcampaignactivityactualcost_base
		{
			get
			{
				return this.totalcampaignactivityactualcost_baseField;
			}
			set
			{
				this.totalcampaignactivityactualcost_baseField = value;
			}
		}
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
			}
		}
		public Picklist typecode
		{
			get
			{
				return this.typecodeField;
			}
			set
			{
				this.typecodeField = value;
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
