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
	public class ExecuteWorkflowRequest : Request
	{
		private Guid entityIdField;

		private Guid workflowIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid WorkflowId
		{
			get
			{
				return this.workflowIdField;
			}
			set
			{
				this.workflowIdField = value;
				base.RaisePropertyChanged("WorkflowId");
			}
		}

		public ExecuteWorkflowRequest()
		{
		}
	}
}