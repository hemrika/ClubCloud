using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateWorkflowRequest : Request
	{
		private Guid entityIdField;
		private WorkflowState workflowStateField;
		private int workflowStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public WorkflowState WorkflowState
		{
			get
			{
				return this.workflowStateField;
			}
			set
			{
				this.workflowStateField = value;
			}
		}
		public int WorkflowStatus
		{
			get
			{
				return this.workflowStatusField;
			}
			set
			{
				this.workflowStatusField = value;
			}
		}
	}
}
