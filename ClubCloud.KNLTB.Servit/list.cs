using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public CrmMoney cost
		{
			get
			{
				return this.costField;
			}
			set
			{
				this.costField = value;
				base.RaisePropertyChanged("cost");
			}
		}
		[XmlElement(Order = 1)]
		public CrmMoney cost_base
		{
			get
			{
				return this.cost_baseField;
			}
			set
			{
				this.cost_baseField = value;
				base.RaisePropertyChanged("cost_base");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
		public Picklist createdfromcode
		{
			get
			{
				return this.createdfromcodeField;
			}
			set
			{
				this.createdfromcodeField = value;
				base.RaisePropertyChanged("createdfromcode");
			}
		}
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		public CrmDateTime lastusedon
		{
			get
			{
				return this.lastusedonField;
			}
			set
			{
				this.lastusedonField = value;
				base.RaisePropertyChanged("lastusedon");
			}
		}
		[XmlElement(Order = 11)]
		public Key listid
		{
			get
			{
				return this.listidField;
			}
			set
			{
				this.listidField = value;
				base.RaisePropertyChanged("listid");
			}
		}
		[XmlElement(Order = 12)]
		public string listname
		{
			get
			{
				return this.listnameField;
			}
			set
			{
				this.listnameField = value;
				base.RaisePropertyChanged("listname");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean lockstatus
		{
			get
			{
				return this.lockstatusField;
			}
			set
			{
				this.lockstatusField = value;
				base.RaisePropertyChanged("lockstatus");
			}
		}
		[XmlElement(Order = 14)]
		public CrmNumber membercount
		{
			get
			{
				return this.membercountField;
			}
			set
			{
				this.membercountField = value;
				base.RaisePropertyChanged("membercount");
			}
		}
		[XmlElement(Order = 15)]
		public CrmNumber membertype
		{
			get
			{
				return this.membertypeField;
			}
			set
			{
				this.membertypeField = value;
				base.RaisePropertyChanged("membertype");
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
		public string purpose
		{
			get
			{
				return this.purposeField;
			}
			set
			{
				this.purposeField = value;
				base.RaisePropertyChanged("purpose");
			}
		}
		[XmlElement(Order = 22)]
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
				base.RaisePropertyChanged("source");
			}
		}
		[XmlElement(Order = 23)]
		public ListStateInfo statecode
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
