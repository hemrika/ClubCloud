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
	public class asyncoperation : BusinessEntity
	{
		private Key asyncoperationidField;

		private CrmDateTime completedonField;

		private UniqueIdentifier correlationidField;

		private CrmDateTime correlationupdatedtimeField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string dataField;

		private string dependencytokenField;

		private CrmNumber depthField;

		private CrmNumber errorcodeField;

		private string hostidField;

		private CrmBoolean iswaitingforeventField;

		private string messageField;

		private string messagenameField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Picklist operationtypeField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDateTime postponeuntilField;

		private EntityNameReference primaryentitytypeField;

		private string recurrencepatternField;

		private CrmDateTime recurrencestarttimeField;

		private Lookup regardingobjectidField;

		private UniqueIdentifier requestidField;

		private CrmNumber retrycountField;

		private CrmDateTime startedonField;

		private AsyncOperationStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		private Lookup workflowactivationidField;

		private string workflowstagenameField;

		[XmlElement] //[XmlElement(Order=0)]
		public Key asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
				base.RaisePropertyChanged("asyncoperationid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
				base.RaisePropertyChanged("completedon");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public UniqueIdentifier correlationid
		{
			get
			{
				return this.correlationidField;
			}
			set
			{
				this.correlationidField = value;
				base.RaisePropertyChanged("correlationid");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public CrmDateTime correlationupdatedtime
		{
			get
			{
				return this.correlationupdatedtimeField;
			}
			set
			{
				this.correlationupdatedtimeField = value;
				base.RaisePropertyChanged("correlationupdatedtime");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
				base.RaisePropertyChanged("data");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public string dependencytoken
		{
			get
			{
				return this.dependencytokenField;
			}
			set
			{
				this.dependencytokenField = value;
				base.RaisePropertyChanged("dependencytoken");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber depth
		{
			get
			{
				return this.depthField;
			}
			set
			{
				this.depthField = value;
				base.RaisePropertyChanged("depth");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber errorcode
		{
			get
			{
				return this.errorcodeField;
			}
			set
			{
				this.errorcodeField = value;
				base.RaisePropertyChanged("errorcode");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string hostid
		{
			get
			{
				return this.hostidField;
			}
			set
			{
				this.hostidField = value;
				base.RaisePropertyChanged("hostid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean iswaitingforevent
		{
			get
			{
				return this.iswaitingforeventField;
			}
			set
			{
				this.iswaitingforeventField = value;
				base.RaisePropertyChanged("iswaitingforevent");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public string messagename
		{
			get
			{
				return this.messagenameField;
			}
			set
			{
				this.messagenameField = value;
				base.RaisePropertyChanged("messagename");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist operationtype
		{
			get
			{
				return this.operationtypeField;
			}
			set
			{
				this.operationtypeField = value;
				base.RaisePropertyChanged("operationtype");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime postponeuntil
		{
			get
			{
				return this.postponeuntilField;
			}
			set
			{
				this.postponeuntilField = value;
				base.RaisePropertyChanged("postponeuntil");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public EntityNameReference primaryentitytype
		{
			get
			{
				return this.primaryentitytypeField;
			}
			set
			{
				this.primaryentitytypeField = value;
				base.RaisePropertyChanged("primaryentitytype");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string recurrencepattern
		{
			get
			{
				return this.recurrencepatternField;
			}
			set
			{
				this.recurrencepatternField = value;
				base.RaisePropertyChanged("recurrencepattern");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmDateTime recurrencestarttime
		{
			get
			{
				return this.recurrencestarttimeField;
			}
			set
			{
				this.recurrencestarttimeField = value;
				base.RaisePropertyChanged("recurrencestarttime");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
		public UniqueIdentifier requestid
		{
			get
			{
				return this.requestidField;
			}
			set
			{
				this.requestidField = value;
				base.RaisePropertyChanged("requestid");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmNumber retrycount
		{
			get
			{
				return this.retrycountField;
			}
			set
			{
				this.retrycountField = value;
				base.RaisePropertyChanged("retrycount");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmDateTime startedon
		{
			get
			{
				return this.startedonField;
			}
			set
			{
				this.startedonField = value;
				base.RaisePropertyChanged("startedon");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public AsyncOperationStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		[XmlElement] //[XmlElement(Order=32)]
		public Lookup workflowactivationid
		{
			get
			{
				return this.workflowactivationidField;
			}
			set
			{
				this.workflowactivationidField = value;
				base.RaisePropertyChanged("workflowactivationid");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string workflowstagename
		{
			get
			{
				return this.workflowstagenameField;
			}
			set
			{
				this.workflowstagenameField = value;
				base.RaisePropertyChanged("workflowstagename");
			}
		}

		public asyncoperation()
		{
		}
	}
}