using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class workflow : BusinessEntity
	{
		private Lookup activeworkflowidField;
		private string activitiesField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmBoolean iscrmuiworkflowField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private CrmBoolean ondemandField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup parentworkflowidField;
		private Lookup plugintypeidField;
		private EntityNameReference primaryentityField;
		private string rulesField;
		private Picklist scopeField;
		private WorkflowStateInfo statecodeField;
		private Status statuscodeField;
		private CrmBoolean subprocessField;
		private Picklist typeField;
		private string uidataField;
		private Key workflowidField;
		public Lookup activeworkflowid
		{
			get
			{
				return this.activeworkflowidField;
			}
			set
			{
				this.activeworkflowidField = value;
			}
		}
		public string activities
		{
			get
			{
				return this.activitiesField;
			}
			set
			{
				this.activitiesField = value;
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
		public CrmBoolean iscrmuiworkflow
		{
			get
			{
				return this.iscrmuiworkflowField;
			}
			set
			{
				this.iscrmuiworkflowField = value;
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
		public CrmBoolean ondemand
		{
			get
			{
				return this.ondemandField;
			}
			set
			{
				this.ondemandField = value;
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
		public Lookup parentworkflowid
		{
			get
			{
				return this.parentworkflowidField;
			}
			set
			{
				this.parentworkflowidField = value;
			}
		}
		public Lookup plugintypeid
		{
			get
			{
				return this.plugintypeidField;
			}
			set
			{
				this.plugintypeidField = value;
			}
		}
		public EntityNameReference primaryentity
		{
			get
			{
				return this.primaryentityField;
			}
			set
			{
				this.primaryentityField = value;
			}
		}
		public string rules
		{
			get
			{
				return this.rulesField;
			}
			set
			{
				this.rulesField = value;
			}
		}
		public Picklist scope
		{
			get
			{
				return this.scopeField;
			}
			set
			{
				this.scopeField = value;
			}
		}
		public WorkflowStateInfo statecode
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
		public CrmBoolean subprocess
		{
			get
			{
				return this.subprocessField;
			}
			set
			{
				this.subprocessField = value;
			}
		}
		public Picklist type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		public string uidata
		{
			get
			{
				return this.uidataField;
			}
			set
			{
				this.uidataField = value;
			}
		}
		public Key workflowid
		{
			get
			{
				return this.workflowidField;
			}
			set
			{
				this.workflowidField = value;
			}
		}
	}
}
