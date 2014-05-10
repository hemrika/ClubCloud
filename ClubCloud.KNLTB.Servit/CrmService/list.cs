using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class list : BusinessEntity
	{
		private CrmMoney costField;
		private CrmMoney cost_baseField;
		private Lookup createdbyField;
		private Picklist createdfromcodeField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmBoolean donotsendonoptoutField;
		private CrmDecimal exchangerateField;
		private CrmBoolean ignoreinactivelistmembersField;
		private CrmNumber importsequencenumberField;
		private CrmDateTime lastusedonField;
		private Key listidField;
		private string listnameField;
		private CrmBoolean lockstatusField;
		private CrmNumber membercountField;
		private CrmNumber membertypeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string purposeField;
		private string sourceField;
		private ListStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmMoney cost
		{
			get
			{
				return this.costField;
			}
			set
			{
				this.costField = value;
			}
		}
		public CrmMoney cost_base
		{
			get
			{
				return this.cost_baseField;
			}
			set
			{
				this.cost_baseField = value;
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
		public Picklist createdfromcode
		{
			get
			{
				return this.createdfromcodeField;
			}
			set
			{
				this.createdfromcodeField = value;
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
		public CrmBoolean donotsendonoptout
		{
			get
			{
				return this.donotsendonoptoutField;
			}
			set
			{
				this.donotsendonoptoutField = value;
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
		public CrmBoolean ignoreinactivelistmembers
		{
			get
			{
				return this.ignoreinactivelistmembersField;
			}
			set
			{
				this.ignoreinactivelistmembersField = value;
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
		public CrmDateTime lastusedon
		{
			get
			{
				return this.lastusedonField;
			}
			set
			{
				this.lastusedonField = value;
			}
		}
		public Key listid
		{
			get
			{
				return this.listidField;
			}
			set
			{
				this.listidField = value;
			}
		}
		public string listname
		{
			get
			{
				return this.listnameField;
			}
			set
			{
				this.listnameField = value;
			}
		}
		public CrmBoolean lockstatus
		{
			get
			{
				return this.lockstatusField;
			}
			set
			{
				this.lockstatusField = value;
			}
		}
		public CrmNumber membercount
		{
			get
			{
				return this.membercountField;
			}
			set
			{
				this.membercountField = value;
			}
		}
		public CrmNumber membertype
		{
			get
			{
				return this.membertypeField;
			}
			set
			{
				this.membertypeField = value;
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
		public string purpose
		{
			get
			{
				return this.purposeField;
			}
			set
			{
				this.purposeField = value;
			}
		}
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
			}
		}
		public ListStateInfo statecode
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
