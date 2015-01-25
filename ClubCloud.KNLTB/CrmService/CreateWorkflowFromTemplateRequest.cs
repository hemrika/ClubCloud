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
	public class CreateWorkflowFromTemplateRequest : Request
	{
		private string workflowNameField;

		private Guid workflowTemplateIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public string WorkflowName
		{
			get
			{
				return this.workflowNameField;
			}
			set
			{
				this.workflowNameField = value;
				base.RaisePropertyChanged("WorkflowName");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid WorkflowTemplateId
		{
			get
			{
				return this.workflowTemplateIdField;
			}
			set
			{
				this.workflowTemplateIdField = value;
				base.RaisePropertyChanged("WorkflowTemplateId");
			}
		}

		public CreateWorkflowFromTemplateRequest()
		{
		}
	}
}