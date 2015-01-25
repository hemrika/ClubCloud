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
	public class PropagateByExpressionRequest : Request
	{
		private QueryBase queryExpressionField;

		private string friendlyNameField;

		private bool executeImmediatelyField;

		private BusinessEntity activityField;

		private Guid templateIdField;

		private PropagationOwnershipOptions ownershipOptionsField;

		private bool postWorkflowEventField;

		private Moniker ownerField;

		private bool sendEmailField;

		[XmlElement] //[XmlElement(Order=3)]
		public BusinessEntity Activity
		{
			get
			{
				return this.activityField;
			}
			set
			{
				this.activityField = value;
				base.RaisePropertyChanged("Activity");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public bool ExecuteImmediately
		{
			get
			{
				return this.executeImmediatelyField;
			}
			set
			{
				this.executeImmediatelyField = value;
				base.RaisePropertyChanged("ExecuteImmediately");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string FriendlyName
		{
			get
			{
				return this.friendlyNameField;
			}
			set
			{
				this.friendlyNameField = value;
				base.RaisePropertyChanged("FriendlyName");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public Moniker Owner
		{
			get
			{
				return this.ownerField;
			}
			set
			{
				this.ownerField = value;
				base.RaisePropertyChanged("Owner");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public PropagationOwnershipOptions OwnershipOptions
		{
			get
			{
				return this.ownershipOptionsField;
			}
			set
			{
				this.ownershipOptionsField = value;
				base.RaisePropertyChanged("OwnershipOptions");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public bool PostWorkflowEvent
		{
			get
			{
				return this.postWorkflowEventField;
			}
			set
			{
				this.postWorkflowEventField = value;
				base.RaisePropertyChanged("PostWorkflowEvent");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public QueryBase QueryExpression
		{
			get
			{
				return this.queryExpressionField;
			}
			set
			{
				this.queryExpressionField = value;
				base.RaisePropertyChanged("QueryExpression");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public bool SendEmail
		{
			get
			{
				return this.sendEmailField;
			}
			set
			{
				this.sendEmailField = value;
				base.RaisePropertyChanged("SendEmail");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
				base.RaisePropertyChanged("TemplateId");
			}
		}

		public PropagateByExpressionRequest()
		{
		}
	}
}