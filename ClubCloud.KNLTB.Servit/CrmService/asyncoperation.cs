using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Key asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
			}
		}
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
			}
		}
		public UniqueIdentifier correlationid
		{
			get
			{
				return this.correlationidField;
			}
			set
			{
				this.correlationidField = value;
			}
		}
		public CrmDateTime correlationupdatedtime
		{
			get
			{
				return this.correlationupdatedtimeField;
			}
			set
			{
				this.correlationupdatedtimeField = value;
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
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}
		public string dependencytoken
		{
			get
			{
				return this.dependencytokenField;
			}
			set
			{
				this.dependencytokenField = value;
			}
		}
		public CrmNumber depth
		{
			get
			{
				return this.depthField;
			}
			set
			{
				this.depthField = value;
			}
		}
		public CrmNumber errorcode
		{
			get
			{
				return this.errorcodeField;
			}
			set
			{
				this.errorcodeField = value;
			}
		}
		public string hostid
		{
			get
			{
				return this.hostidField;
			}
			set
			{
				this.hostidField = value;
			}
		}
		public CrmBoolean iswaitingforevent
		{
			get
			{
				return this.iswaitingforeventField;
			}
			set
			{
				this.iswaitingforeventField = value;
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
		public string messagename
		{
			get
			{
				return this.messagenameField;
			}
			set
			{
				this.messagenameField = value;
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
		public Picklist operationtype
		{
			get
			{
				return this.operationtypeField;
			}
			set
			{
				this.operationtypeField = value;
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
		public CrmDateTime postponeuntil
		{
			get
			{
				return this.postponeuntilField;
			}
			set
			{
				this.postponeuntilField = value;
			}
		}
		public EntityNameReference primaryentitytype
		{
			get
			{
				return this.primaryentitytypeField;
			}
			set
			{
				this.primaryentitytypeField = value;
			}
		}
		public string recurrencepattern
		{
			get
			{
				return this.recurrencepatternField;
			}
			set
			{
				this.recurrencepatternField = value;
			}
		}
		public CrmDateTime recurrencestarttime
		{
			get
			{
				return this.recurrencestarttimeField;
			}
			set
			{
				this.recurrencestarttimeField = value;
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
		public UniqueIdentifier requestid
		{
			get
			{
				return this.requestidField;
			}
			set
			{
				this.requestidField = value;
			}
		}
		public CrmNumber retrycount
		{
			get
			{
				return this.retrycountField;
			}
			set
			{
				this.retrycountField = value;
			}
		}
		public CrmDateTime startedon
		{
			get
			{
				return this.startedonField;
			}
			set
			{
				this.startedonField = value;
			}
		}
		public AsyncOperationStateInfo statecode
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
		public Lookup workflowactivationid
		{
			get
			{
				return this.workflowactivationidField;
			}
			set
			{
				this.workflowactivationidField = value;
			}
		}
		public string workflowstagename
		{
			get
			{
				return this.workflowstagenameField;
			}
			set
			{
				this.workflowstagenameField = value;
			}
		}
	}
}
