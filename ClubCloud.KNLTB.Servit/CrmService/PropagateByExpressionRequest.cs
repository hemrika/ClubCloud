using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public QueryBase QueryExpression
		{
			get
			{
				return this.queryExpressionField;
			}
			set
			{
				this.queryExpressionField = value;
			}
		}
		public string FriendlyName
		{
			get
			{
				return this.friendlyNameField;
			}
			set
			{
				this.friendlyNameField = value;
			}
		}
		public bool ExecuteImmediately
		{
			get
			{
				return this.executeImmediatelyField;
			}
			set
			{
				this.executeImmediatelyField = value;
			}
		}
		public BusinessEntity Activity
		{
			get
			{
				return this.activityField;
			}
			set
			{
				this.activityField = value;
			}
		}
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
			}
		}
		public PropagationOwnershipOptions OwnershipOptions
		{
			get
			{
				return this.ownershipOptionsField;
			}
			set
			{
				this.ownershipOptionsField = value;
			}
		}
		public bool PostWorkflowEvent
		{
			get
			{
				return this.postWorkflowEventField;
			}
			set
			{
				this.postWorkflowEventField = value;
			}
		}
		public Moniker Owner
		{
			get
			{
				return this.ownerField;
			}
			set
			{
				this.ownerField = value;
			}
		}
		public bool SendEmail
		{
			get
			{
				return this.sendEmailField;
			}
			set
			{
				this.sendEmailField = value;
			}
		}
	}
}
