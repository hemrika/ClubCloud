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

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup activeworkflowid
		{
			get
			{
				return this.activeworkflowidField;
			}
			set
			{
				this.activeworkflowidField = value;
				base.RaisePropertyChanged("activeworkflowid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string activities
		{
			get
			{
				return this.activitiesField;
			}
			set
			{
				this.activitiesField = value;
				base.RaisePropertyChanged("activities");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public CrmBoolean iscrmuiworkflow
		{
			get
			{
				return this.iscrmuiworkflowField;
			}
			set
			{
				this.iscrmuiworkflowField = value;
				base.RaisePropertyChanged("iscrmuiworkflow");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean ondemand
		{
			get
			{
				return this.ondemandField;
			}
			set
			{
				this.ondemandField = value;
				base.RaisePropertyChanged("ondemand");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup parentworkflowid
		{
			get
			{
				return this.parentworkflowidField;
			}
			set
			{
				this.parentworkflowidField = value;
				base.RaisePropertyChanged("parentworkflowid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup plugintypeid
		{
			get
			{
				return this.plugintypeidField;
			}
			set
			{
				this.plugintypeidField = value;
				base.RaisePropertyChanged("plugintypeid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public EntityNameReference primaryentity
		{
			get
			{
				return this.primaryentityField;
			}
			set
			{
				this.primaryentityField = value;
				base.RaisePropertyChanged("primaryentity");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string rules
		{
			get
			{
				return this.rulesField;
			}
			set
			{
				this.rulesField = value;
				base.RaisePropertyChanged("rules");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist scope
		{
			get
			{
				return this.scopeField;
			}
			set
			{
				this.scopeField = value;
				base.RaisePropertyChanged("scope");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public WorkflowStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
		public CrmBoolean subprocess
		{
			get
			{
				return this.subprocessField;
			}
			set
			{
				this.subprocessField = value;
				base.RaisePropertyChanged("subprocess");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				base.RaisePropertyChanged("type");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string uidata
		{
			get
			{
				return this.uidataField;
			}
			set
			{
				this.uidataField = value;
				base.RaisePropertyChanged("uidata");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Key workflowid
		{
			get
			{
				return this.workflowidField;
			}
			set
			{
				this.workflowidField = value;
				base.RaisePropertyChanged("workflowid");
			}
		}

		public workflow()
		{
		}
	}
}